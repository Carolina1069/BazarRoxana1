Imports System.Data.SqlClient
Imports System.IO

Public Class MiEmpresa

    Dim fichero As [Byte]() = Nothing
    Public Shared statePlato As String = "INS"
    Public Shared stateIMG As Boolean = False
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.CheckFileExists = True
        openFileDialog.AddExtension = True
        openFileDialog.Multiselect = True
        openFileDialog.Filter = "Image files (*.png)|*.jpg"


        If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim rutaArchivo As String = openFileDialog.FileNames(0)
            Dim fs = File.Open(rutaArchivo, FileMode.Open)
            fichero = New [Byte](fs.Length - 1) {}
            fs.Read(fichero, 0, CInt(fs.Length))


            fs.Close()
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
            PictureBox1.SizeMode = PictureBox1.SizeMode.StretchImage
        End If

    End Sub

    Private Sub MiEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            AbrirConeccion()
            Dim SqlActions As String
            SqlActions = "select * from MiEmpresa where Codigo= 1"
            Dim cmd As New SqlCommand(SqlActions, ConexionBase)
            cmd.Parameters.AddWithValue(1, txtcod.Text)
            ConexionBase.Open()
            Dim Lectura As SqlDataReader = cmd.ExecuteReader()
                If Lectura.Read = True Then
                txtDireccion.Text = CStr(Lectura(1))
                txtRTN.Text = CStr(Lectura(2))
                txtCAI.Text = CStr(Lectura(4))
                TxtEmail.Text = CStr(Lectura(5))
                txtTelefono.Text = CStr(Lectura(6))


                Dim ms As New System.IO.MemoryStream()
                Dim imageBuffer() As Byte = CType(Lectura.Item("Imagen"), Byte())
                ms = New System.IO.MemoryStream(imageBuffer)
                    PictureBox1.BackgroundImage = Nothing
                    PictureBox1.BackgroundImage = (Image.FromStream(ms))
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch



                    Lectura.Close()

                End If
            ConexionBase.Close()
        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        AbrirConeccion()
        If statePlato = "UPD" Then
            If fichero IsNot Nothing Then
                stateIMG = True
                Dim consultaAct As String = "update MiEmpresa set Direccion=@Direccion, RTN=@RTN, CAI=@CAI, Email=@Email,Telefono=@Telefono,Imagen=@Imagen where Codigo= 1" '<-Consulta.
                'Toma los valores de los textbox  y los actualiza en la base de datos. 
                Dim ejecutar As New SqlCommand(consultaAct, ConexionBase)
                ejecutar.Parameters.AddWithValue("@Direccion", (txtDireccion.Text))
                ejecutar.Parameters.AddWithValue("@RTN", (txtRTN.Text))
                ejecutar.Parameters.AddWithValue("@CAI", (txtCAI.Text))
                ejecutar.Parameters.AddWithValue("@Email", TxtEmail.Text)
                ejecutar.Parameters.AddWithValue("@Telefono", (txtTelefono.Text))
                ejecutar.Parameters.AddWithValue("@Imagen", (fichero))
                ejecutar.ExecuteNonQuery()
                MsgBox("La informacion se a actualizado", MsgBoxStyle.Information, "Informacion")
                txtDireccion.Clear()
                txtRTN.Clear()
                txtCAI.Clear()
                TxtEmail.Clear()
                txtTelefono.Clear()
                Dispose()
            Else
                stateIMG = False
                'cn.Actualizar(txtnombre.Text, txtdesc.Text, cmbcateg.SelectedIndex + 1, txtdif.Text, txtfinalp.Text, fichero, txtcod.Text)
                Dim consultaAct As String = "update MiEmpresa set Direccion=@Direccion, RTN=@RTN, CAI=@CAI, Email=@Email,Telefono=@Telefono,Imagen=@Imagen where Codigo= 1" '<-Consulta.
                'Toma los valores de los textbox  y los actualiza en la base de datos. 
                Dim ejecutar As New SqlCommand(consultaAct, ConexionBase)
                ejecutar.Parameters.AddWithValue("@Direccion", (txtDireccion.Text))
                ejecutar.Parameters.AddWithValue("@RTN", (txtRTN.Text))
                ejecutar.Parameters.AddWithValue("@CAI", (txtCAI.Text))
                ejecutar.Parameters.AddWithValue("@Email", TxtEmail.Text)
                ejecutar.Parameters.AddWithValue("@Telefono", (txtTelefono.Text))
                ejecutar.Parameters.AddWithValue("@Imagen", (fichero))
                ejecutar.ExecuteNonQuery()
                MsgBox("La informacion se a actualizado", MsgBoxStyle.Information, "Informacion")
                Dispose()
            End If

        End If

        If statePlato = "INS" Then
            If fichero IsNot Nothing Then

                'cn.Guardar(txtnombre.Text, txtdesc.Text, cmbcateg.SelectedIndex + 1, txtdif.Text, txtfinalp.Text, fichero)
                Dim consultaAct As String = "insert into MiEmpresa (Codigo,Direccion,RTN,CAI,Email,Telefono,Imagen) values( 1,@Direccion,@RTN, @CAI, @Email, @Telefono, @Imagen)" '<-Consulta.
                'Toma los valores de los textbox  y los actualiza en la base de datos. 
                Dim ejecutar As New SqlCommand(consultaAct, ConexionBase)
                ejecutar.Parameters.AddWithValue("@Direccion", (txtDireccion.Text))
                ejecutar.Parameters.AddWithValue("@RTN", (txtRTN.Text))
                ejecutar.Parameters.AddWithValue("@CAI", (txtCAI.Text))
                ejecutar.Parameters.AddWithValue("@Email", TxtEmail.Text)
                ejecutar.Parameters.AddWithValue("@Telefono", (txtTelefono.Text))
                ejecutar.Parameters.AddWithValue("@Imagen", (fichero))
                ejecutar.ExecuteNonQuery()
                MsgBox("La informacion se a guardado", MsgBoxStyle.Information, "Informacion")
                txtDireccion.Clear()
                txtRTN.Clear()
                txtCAI.Clear()
                TxtEmail.Clear()
                txtTelefono.Clear()
                Dispose()
            Else
                MessageBox.Show("Ingrese una imagen")

            End If

        End If
        ConexionBase.Close()
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        AbrirConeccion()
        Dim consultaAct As String = "delete from MiEmpresa where Codigo=1" '<-Consulta.
        'Toma los valores de los textbox  y los actualiza en la base de datos. 
        Dim ejecutar As New SqlCommand(consultaAct, ConexionBase)
        ejecutar.ExecuteNonQuery()
        MsgBox("La informacion se a guardado", MsgBoxStyle.Information, "Informacion")
        ConexionBase.Close()
    End Sub
End Class