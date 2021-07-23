Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Image



Public Class MiEmpresa
    Public CantidadCaracteres1 As Integer
    Public CantidadCaracteres2 As Integer
    Public CantidadCaracteres3 As Integer
    Public CantidadCaracteres4 As Integer
    Public CantidadCaracteres5 As Integer
    Public CantidadCaracteres6 As Integer
    Dim fichero As [Byte]() = Nothing
    Public Shared statePlato As String = "INS"
    Public Shared stateIMG As Boolean = False
    Private Ls As Integer
    Private Li As Integer
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
        txtCAI2.Enabled = False
        txtCAI3.Enabled = False
        txtCAI4.Enabled = False
        txtCAI5.Enabled = False
        txtCAI6.Enabled = False
        AbrirConeccion()

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from MiEmpresa", ConexionBase)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp

        ConexionBase.Close()

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            Dim mail As New System.Net.Mail.MailAddress(TxtEmail.Text) '<-Validar el correro
        Catch ex As Exception
            MsgBox("Verifique los datos del email", MsgBoxStyle.Exclamation, "Advertencia")
        End Try

        AbrirConeccion()
        If RegistradoMiEmpresa() = False Then
            If statePlato = "INS" Then
                If fichero IsNot Nothing Or txtDireccion.Text = "" Or txtRTN.Text = "" Or TxtEmail.Text = "" Or txtCAI1.Text = "" Or txtCAI2.Text = "" Or txtCAI3.Text = "" Or txtCAI4.Text = "" Or txtCAI5.Text = "" Or txtCAI6.Text = "" Then
                    If TxtEmail.TextLength < 6 Then
                        MsgBox("Debe ingresar como minimo 6 caracteres en el correro.", MsgBoxStyle.Exclamation, "Advertencia")
                    ElseIf (txtTelefono.TextLength < 8) Then
                        MsgBox("Debe ingresar 8 caracteres en el teléfono.", MsgBoxStyle.Exclamation, "Advertencia")
                    ElseIf Cuantas(".", TxtEmail.Text) > 1 Then
                        MessageBox.Show("No podes ingresar mas de 1 punto.", "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    ElseIf (txtDireccion.TextLength < 10) Then
                        MsgBox("Debe ingresar 10 caracteres en la dirección.", MsgBoxStyle.Exclamation, "Advertencia")
                    ElseIf (txtRTN.TextLength < 14) Then
                        MsgBox("Debe ingresar 14 caracteres en el RTN.", MsgBoxStyle.Exclamation, "Advertencia")
                    ElseIf (txtCAI1.TextLength < 6) Then
                        MsgBox("Debe ingresar 6 caracteres en la primera agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
                    ElseIf (txtCAI2.TextLength < 6) Then
                        MsgBox("Debe ingresar 6 caracteres en la segunda agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
                    ElseIf (txtCAI3.TextLength < 6) Then
                        MsgBox("Debe ingresar 6 caracteres en la tercera agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
                    ElseIf (txtCAI4.TextLength < 6) Then
                        MsgBox("Debe ingresar 6 caracteres en la cuarta agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
                    ElseIf (txtCAI5.TextLength < 6) Then
                        MsgBox("Debe ingresar 6 caracteres en la quinta agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
                    ElseIf (txtCAI6.TextLength < 2) Then
                        MsgBox("Debe ingresar 2 caracteres en la sexta agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
                    ElseIf VerificarRTN(txtRTN.Text) Then
                        'cn.Guardar(txtnombre.Text, txtdesc.Text, cmbcateg.SelectedIndex + 1, txtdif.Text, txtfinalp.Text, fichero)
                        Dim consultaAct As String = "insert into MiEmpresa (Codigo,Direccion,RTN,CAI,Email,Telefono,Imagen) values(1,@Direccion,@RTN, (@GRP1+'-'+@GRP2+'-'+@GRP3+'-'+@GRP4+'-'+@GRP5+'-'+@GRP6), @Email, @Telefono, @Imagen)" '<-Consulta.
                        'Toma los valores de los textbox  y los actualiza en la base de datos. 
                        Dim ejecutar As New SqlCommand(consultaAct, ConexionBase)
                        ejecutar.Parameters.AddWithValue("@Direccion", (txtDireccion.Text))
                        ejecutar.Parameters.AddWithValue("@RTN", (txtRTN.Text))
                        ejecutar.Parameters.AddWithValue("@GRP1", (txtCAI1.Text))
                        ejecutar.Parameters.AddWithValue("@GRP2", (txtCAI2.Text))
                        ejecutar.Parameters.AddWithValue("@GRP3", (txtCAI3.Text))
                        ejecutar.Parameters.AddWithValue("@GRP4", (txtCAI4.Text))
                        ejecutar.Parameters.AddWithValue("@GRP5", (txtCAI5.Text))
                        ejecutar.Parameters.AddWithValue("@GRP6", (txtCAI6.Text))
                        ejecutar.Parameters.AddWithValue("@Email", TxtEmail.Text)
                        ejecutar.Parameters.AddWithValue("@Telefono", (txtTelefono.Text))
                        ejecutar.Parameters.AddWithValue("@Imagen", (fichero))
                        ejecutar.ExecuteNonQuery()
                        MsgBox("La informacion se a guardado", MsgBoxStyle.Information, "Informacion")


                        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
                        Using adaptador As New SqlDataAdapter("select * from MiEmpresa", ConexionBase)
                            adaptador.Fill(DatosEmp)
                        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

                        DGV.DataSource = DatosEmp

                    End If


                Else
                    MsgBox("Ingrese una imagen y/o hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
                End If

            End If
        Else
            MsgBox("Ya hay registro de información, si desea actulice los datos con el boton actualizar.", MsgBoxStyle.Information, "Informacion")
        End If

        ConexionBase.Close()
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        AbrirConeccion()
        Dim consultaAct As String = "delete from MiEmpresa where Codigo=1" '<-Consulta.
        'Toma los valores de los textbox  y los actualiza en la base de datos. 
        Dim ejecutar As New SqlCommand(consultaAct, ConexionBase)
        ejecutar.ExecuteNonQuery()
        MsgBox("La informacion se a eliminado", MsgBoxStyle.Information, "Informacion")

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from MiEmpresa", ConexionBase)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp


        ConexionBase.Close()

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim mail As New System.Net.Mail.MailAddress(TxtEmail.Text) '<-Validar el correro
        AbrirConeccion()
        Try
            If TxtEmail.TextLength < 6 Then
                MsgBox("Debe ingresar como minimo 6 caracteres en el correro.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txtTelefono.TextLength < 8) Then
                MsgBox("Debe ingresar 8 caracteres en el teléfono.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf Cuantas(".", TxtEmail.Text) > 1 Then
                MessageBox.Show("No podes ingresar mas de 1 punto.", "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf (txtDireccion.TextLength < 10) Then
                MsgBox("Debe ingresar 10 caracteres en la dirección.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txtRTN.TextLength < 14) Then
                MsgBox("Debe ingresar 14 caracteres en el RTN.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txtCAI1.TextLength < 6) Then
                MsgBox("Debe ingresar 6 caracteres en la primera agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txtCAI2.TextLength < 6) Then
                MsgBox("Debe ingresar 6 caracteres en la segunda agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txtCAI3.TextLength < 6) Then
                MsgBox("Debe ingresar 6 caracteres en la tercera agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txtCAI4.TextLength < 6) Then
                MsgBox("Debe ingresar 6 caracteres en la cuarta agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txtCAI5.TextLength < 6) Then
                MsgBox("Debe ingresar 6 caracteres en la quinta agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txtCAI6.TextLength < 2) Then
                MsgBox("Debe ingresar 2 caracteres en la sexta agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")

            ElseIf VerificarRTN(txtRTN.Text) Then
                stateIMG = True
                'cn.Actualizar(txtnombre.Text, txtdesc.Text, cmbcateg.SelectedIndex + 1, txtdif.Text, txtfinalp.Text, fichero, txtcod.Text)
                Dim consultaAct As String = "update MiEmpresa set Direccion=@Direccion, RTN=@RTN, CAI=(@GRP1+'-'+@GRP2+'-'+@GRP3+'-'+@GRP4+'-'+@GRP5+'-'+@GRP6), Email=@Email,Telefono=@Telefono, Imagen=@Imagen where Codigo= 1" '<-Consulta.
                'Toma los valores de los textbox  y los actualiza en la base de datos. 
                Dim ejecutar As New SqlCommand(consultaAct, ConexionBase)
                ejecutar.Parameters.AddWithValue("@Direccion", (txtDireccion.Text))
                ejecutar.Parameters.AddWithValue("@RTN", (txtRTN.Text))
                ejecutar.Parameters.AddWithValue("@GRP1", (txtCAI1.Text))
                ejecutar.Parameters.AddWithValue("@GRP2", (txtCAI2.Text))
                ejecutar.Parameters.AddWithValue("@GRP3", (txtCAI3.Text))
                ejecutar.Parameters.AddWithValue("@GRP4", (txtCAI4.Text))
                ejecutar.Parameters.AddWithValue("@GRP5", (txtCAI5.Text))
                ejecutar.Parameters.AddWithValue("@GRP6", (txtCAI6.Text))
                ejecutar.Parameters.AddWithValue("@Email", (TxtEmail.Text))
                ejecutar.Parameters.AddWithValue("@Telefono", Val(txtTelefono.Text))
                ejecutar.Parameters.AddWithValue("@Imagen", (fichero))

                ejecutar.ExecuteNonQuery()
                MsgBox("La informacion se a actualizado", MsgBoxStyle.Information, "Informacion")

                Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
                Using adaptador As New SqlDataAdapter("select * from MiEmpresa", ConexionBase)
                    adaptador.Fill(DatosEmp)
                End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

                DGV.DataSource = DatosEmp

            End If
        Catch
            If TxtEmail.TextLength < 6 Then
                MsgBox("Debe ingresar como minimo 6 caracteres en el correro.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txtTelefono.TextLength < 8) Then
                MsgBox("Debe ingresar 8 caracteres en el teléfono.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf Cuantas(".", TxtEmail.Text) > 1 Then
                MessageBox.Show("No podes ingresar mas de 1 punto.", "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf (txtDireccion.TextLength < 10) Then
                MsgBox("Debe ingresar 10 caracteres en la dirección.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txtRTN.TextLength < 14) Then
                MsgBox("Debe ingresar 14 caracteres en el RTN.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txtCAI1.TextLength < 6) Then
                MsgBox("Debe ingresar 6 caracteres en la primera agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txtCAI2.TextLength < 6) Then
                MsgBox("Debe ingresar 6 caracteres en la segunda agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txtCAI3.TextLength < 6) Then
                MsgBox("Debe ingresar 6 caracteres en la tercera agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txtCAI4.TextLength < 6) Then
                MsgBox("Debe ingresar 6 caracteres en la cuarta agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txtCAI5.TextLength < 6) Then
                MsgBox("Debe ingresar 6 caracteres en la quinta agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txtCAI6.TextLength < 2) Then
                MsgBox("Debe ingresar 2 caracteres en la sexta agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")

            ElseIf VerificarRTN(txtRTN.Text) Then
                stateIMG = False
                'cn.Actualizar(txtnombre.Text, txtdesc.Text, cmbcateg.SelectedIndex + 1, txtdif.Text, txtfinalp.Text, fichero, txtcod.Text)
                Dim consultaAct As String = "update MiEmpresa set Direccion=@Direccion, RTN=@RTN, CAI=(@GRP1+'-'+@GRP2+'-'+@GRP3+'-'+@GRP4+'-'+@GRP5+'-'+@GRP6), Email=@Email,Telefono=@Telefono where Codigo= 1" '<-Consulta.
                'Toma los valores de los textbox  y los actualiza en la base de datos. 
                Dim ejecutar As New SqlCommand(consultaAct, ConexionBase)
                ejecutar.Parameters.AddWithValue("@Direccion", (txtDireccion.Text))
                ejecutar.Parameters.AddWithValue("@RTN", (txtRTN.Text))
                ejecutar.Parameters.AddWithValue("@GRP1", (txtCAI1.Text))
                ejecutar.Parameters.AddWithValue("@GRP2", (txtCAI2.Text))
                ejecutar.Parameters.AddWithValue("@GRP3", (txtCAI3.Text))
                ejecutar.Parameters.AddWithValue("@GRP4", (txtCAI4.Text))
                ejecutar.Parameters.AddWithValue("@GRP5", (txtCAI5.Text))
                ejecutar.Parameters.AddWithValue("@GRP6", (txtCAI6.Text))
                ejecutar.Parameters.AddWithValue("@Email", (TxtEmail.Text))
                ejecutar.Parameters.AddWithValue("@Telefono", Val(txtTelefono.Text))

                ejecutar.ExecuteNonQuery()
                MsgBox("La informacion se a actualizado", MsgBoxStyle.Information, "Informacion")

                Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
                Using adaptador As New SqlDataAdapter("select * from MiEmpresa", ConexionBase)
                    adaptador.Fill(DatosEmp)
                End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

                DGV.DataSource = DatosEmp

            End If

        End Try

        ConexionBase.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        txtCAI2.Enabled = False
        txtDireccion.Clear()
        txtRTN.Clear()
        txtCAI1.Clear()
        txtCAI2.Clear()
        txtCAI3.Clear()
        txtCAI4.Clear()
        txtCAI5.Clear()
        txtCAI6.Clear()
        TextBox1.Clear()
        TxtEmail.Clear()
        txtTelefono.Clear()
        PictureBox1.Image = Nothing
        LbContador7.Text = 0

    End Sub

    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs) Handles DGV.DoubleClick

        txtDireccion.Text = DGV.CurrentRow.Cells(1).Value
        txtRTN.Text = DGV.CurrentRow.Cells(2).Value
        TextBox1.Text = DGV.CurrentRow.Cells(3).Value
        TxtEmail.Text = DGV.CurrentRow.Cells(4).Value
        txtTelefono.Text = DGV.CurrentRow.Cells(5).Value
        Dim bytesArray As Byte() = DGV.CurrentRow.Cells(6).Value
        Dim ms As MemoryStream = New MemoryStream(bytesArray)
        Dim imagen As Image = Image.FromStream(ms)
        PictureBox1.Image = imagen
        PictureBox1.SizeMode = PictureBox1.SizeMode.StretchImage

        ':::Declaramos una variable tipo string para almacenar la frase
        Dim Cadena As String = TextBox1.Text
        ':::Creamos el array tambien de tipo string para guardar cada palabra
        Dim Palabra() As String
        ':::Asignamos al array nuestra Cadena con la funcion Split y como separador un espacio vacio
        Palabra = Cadena.Split("-")
        ':::Iniciamos nuestro capturador de errores
        Try
            ':::Ahora pasamos a nuestro Label cada parte o seccion del array y le sustraemos las dos (2) primera letras
            txtCAI1.Text = Palabra(0).Substring(0, 6)
            txtCAI2.Text = Palabra(1).Substring(0, 6)
            txtCAI3.Text = Palabra(2).Substring(0, 6)
            txtCAI4.Text = Palabra(3).Substring(0, 6)
            txtCAI5.Text = Palabra(4).Substring(0, 6)
            txtCAI6.Text = Palabra(5).Substring(0, 2)

        Catch ex As Exception
            MsgBox("No se completo la operación por :" & ex.Message)
        End Try

    End Sub

    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        Dim caracteresPermitidos As String = "áéíóúÁÉÍÓÚqwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890-,. " & Convert.ToChar(8)
        Dim c As Char = e.KeyChar
        If (Not (caracteresPermitidos.Contains(c))) Then

            MessageBox.Show("Solo se puede ingresar valores de tipo texto, numericos y caracteres especiales como -,.", "ERROR de escritura",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ' Deshechamos el carácter
            e.Handled = True
        ElseIf Len(Me.txtDireccion.Text) = "0" Then
            If InStr(1, "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,1,2,3,4,5,6,7,8,9,0," & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios o caracteres especiales al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress

        SoloNumeros(e)
        If Len(Me.txtTelefono.Text) = "0" Then
            If InStr(1, "2,3,8,9" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("Solo numero inical en 2,3,8 o 9", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub TxtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEmail.KeyPress
        SoloLetrascorreo(e) '<-- Llamado de la funcion 
    End Sub

    Private Sub TxtEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail.TextChanged
        LbContador2.Text = TxtEmail.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        TxtEmail.Text = Minusculas(TxtEmail.Text, TxtEmail) '<--Validacion solo minusculas.
    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged
        LbContador.Text = txtDireccion.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub txtRTN_TextChanged(sender As Object, e As EventArgs) Handles txtRTN.TextChanged
        LbContador5.Text = txtRTN.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub txtCAI_TextChanged(sender As Object, e As EventArgs) Handles txtCAI1.TextChanged
        If txtCAI1.Text.Length = 6 Then
            txtCAI2.Enabled = True
        Else
            txtCAI3.Enabled = False
            txtCAI4.Enabled = False
            txtCAI5.Enabled = False
            txtCAI6.Enabled = False
        End If
        txtCAI1.Text = Mayuscula(txtCAI1.Text, txtCAI1)

        CantidadCaracteres1 = (txtCAI1.Text.Length) + 1 '<-- Muestra la cantidad de caracteres escritas en textbox.

        LbContador7.Text = CantidadCaracteres1
    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged
        LbContador9.Text = txtTelefono.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub txtRTN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRTN.KeyPress
        SoloNumeros(e)
        If Len(Me.txtRTN.Text) = "0" Then
            If InStr(1, "1,2,3,4,5,6,7,8,9,0" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios o caracteres especiales al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub txtCAI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCAI1.KeyPress

        If Len(Me.txtCAI1.Text) = "0" Then
            If InStr(1, "q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,1,2,3,4,5,6,7,8,9,0" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios y caracteres especiales", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub txtCAI_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCAI1.KeyDown
        Select Case e.KeyData

            Case Keys.Back

                Try

                    txtCAI1.Text = txtCAI1.Text.Substring(38, txtCAI1.Text.Count() - 1)

                Catch ex As Exception

                End Try

        End Select
    End Sub

    Private Sub txtCAI_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCAI1.KeyUp
        If Len(Me.txtCAI1.Text) = (Me.txtCAI1.MaxLength) Then
            txtCAI2.Focus()
        End If
    End Sub

    Private Sub txtCAI2_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCAI2.KeyUp
        If Len(Me.txtCAI2.Text) = (Me.txtCAI2.MaxLength) Then
            txtCAI3.Focus()
        End If
    End Sub

    Private Sub txtCAI3_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCAI3.KeyUp
        If Len(Me.txtCAI3.Text) = (Me.txtCAI3.MaxLength) Then
            txtCAI4.Focus()
        End If
    End Sub

    Private Sub txtCAI4_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCAI4.KeyUp
        If Len(Me.txtCAI4.Text) = (Me.txtCAI4.MaxLength) Then
            txtCAI5.Focus()
        End If
    End Sub

    Private Sub txtCAI5_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCAI5.KeyUp
        If Len(Me.txtCAI5.Text) = (Me.txtCAI5.MaxLength) Then
            txtCAI6.Focus()
        End If
    End Sub

    Private Sub txtCAI2_TextChanged(sender As Object, e As EventArgs) Handles txtCAI2.TextChanged
        If txtCAI2.Text.Length = 6 Then
            txtCAI3.Enabled = True
        Else
            txtCAI4.Enabled = False
            txtCAI5.Enabled = False
            txtCAI6.Enabled = False
        End If
        Dim sumacontador As Integer
        txtCAI2.Text = Mayuscula(txtCAI2.Text, txtCAI2)
        CantidadCaracteres2 = (txtCAI2.Text.Length) + 1 '<-- Muestra la cantidad de caracteres escritas en textbox.
        sumacontador = CantidadCaracteres1 + CantidadCaracteres2
        LbContador7.Text = sumacontador

    End Sub

    Private Sub txtCAI3_TextChanged(sender As Object, e As EventArgs) Handles txtCAI3.TextChanged
        If txtCAI3.Text.Length = 6 Then
            txtCAI4.Enabled = True
        Else
            txtCAI5.Enabled = False
            txtCAI6.Enabled = False
        End If
        Dim sumacontador As Integer
        txtCAI3.Text = Mayuscula(txtCAI3.Text, txtCAI3)
        CantidadCaracteres3 = (txtCAI3.Text.Length) + 1 '<-- Muestra la cantidad de caracteres escritas en textbox.
        sumacontador = CantidadCaracteres1 + CantidadCaracteres2 + CantidadCaracteres3
        LbContador7.Text = sumacontador
    End Sub

    Private Sub txtCAI4_TextChanged(sender As Object, e As EventArgs) Handles txtCAI4.TextChanged
        If txtCAI4.Text.Length = 6 Then
            txtCAI5.Enabled = True
        Else
            txtCAI6.Enabled = False
        End If
        Dim sumacontador As Integer
        txtCAI4.Text = Mayuscula(txtCAI4.Text, txtCAI4)
        CantidadCaracteres4 = (txtCAI4.Text.Length) + 1 '<-- Muestra la cantidad de caracteres escritas en textbox.
        sumacontador = CantidadCaracteres1 + CantidadCaracteres2 + CantidadCaracteres3 + CantidadCaracteres4
        LbContador7.Text = sumacontador
    End Sub

    Private Sub txtCAI5_TextChanged(sender As Object, e As EventArgs) Handles txtCAI5.TextChanged
        If txtCAI5.Text.Length = 6 Then
            txtCAI6.Enabled = True
        End If
        Dim sumacontador As Integer
        txtCAI5.Text = Mayuscula(txtCAI5.Text, txtCAI5)
        CantidadCaracteres5 = (txtCAI5.Text.Length) + 1 '<-- Muestra la cantidad de caracteres escritas en textbox.
        sumacontador = CantidadCaracteres1 + CantidadCaracteres2 + CantidadCaracteres3 + CantidadCaracteres4 + CantidadCaracteres5
        LbContador7.Text = sumacontador
    End Sub

    Private Sub txtCAI6_TextChanged(sender As Object, e As EventArgs) Handles txtCAI6.TextChanged
        Dim sumacontador As Integer
        txtCAI6.Text = Mayuscula(txtCAI6.Text, txtCAI6)
        CantidadCaracteres6 = (txtCAI6.Text.Length) '<-- Muestra la cantidad de caracteres escritas en textbox.
        sumacontador = CantidadCaracteres1 + CantidadCaracteres2 + CantidadCaracteres3 + CantidadCaracteres4 + CantidadCaracteres5 + CantidadCaracteres6
        LbContador7.Text = sumacontador
    End Sub

    Private Sub txtCAI2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCAI2.KeyPress
        If Len(Me.txtCAI2.Text) = "0" Then
            If InStr(1, "q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,1,2,3,4,5,6,7,8,9,0" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios y caracteres especiales", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If

    End Sub

    Private Sub txtCAI3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCAI3.KeyPress
        If Len(Me.txtCAI3.Text) = "0" Then
            If InStr(1, "q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,1,2,3,4,5,6,7,8,9,0" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios y caracteres especiales", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub txtCAI4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCAI4.KeyPress
        If Len(Me.txtCAI4.Text) = "0" Then
            If InStr(1, "q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,1,2,3,4,5,6,7,8,9,0" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios y caracteres especiales", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If

    End Sub

    Private Sub txtCAI5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCAI5.KeyPress
        If Len(Me.txtCAI5.Text) = "0" Then
            If InStr(1, "q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,1,2,3,4,5,6,7,8,9,0" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios y caracteres especiales", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub txtCAI6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCAI6.KeyPress
        If Len(Me.txtCAI6.Text) = "0" Then
            If InStr(1, "q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,1,2,3,4,5,6,7,8,9,0" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios y caracteres especiales", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub


    Private Function VerificarRTN(ByVal cadena As String) As Boolean
            Dim resultado As Boolean = False
            Dim depto As Integer = Integer.Parse(cadena.Substring(0, 2))
            Dim muni As Integer = Integer.Parse(cadena.Substring(2, 2))
            Dim año As Integer = Integer.Parse(cadena.Substring(4, 4))
            Dim folio As Integer = Integer.Parse(cadena.Substring(8, 6))
            AggDatosDiccionario()

            If NumerosEnteros(depto, 1, 18) Then
                Dim Est As Boolean = BuscarDiccionario(depto)

                If NumerosEnteros2(muni, Li, Ls) Then

                    If NumerosEnteros(año, 1900, 2100) Then

                        If NumerosEnteros(folio, 1, 999999) Then
                            resultado = True
                        Else
                            MessageBox.Show("el folio debe estar en un rango del 00001-99999", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtRTN.Focus()


                    End If
                    Else
                    MessageBox.Show("el año debe estar en un rango del 1900-2100", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtRTN.Focus()
                    End If
                Else
                    Return False
                End If
            Else
            MessageBox.Show("1. Los primeros dos numeros del RTN. " & vbLf & "2.Deben estar en un rango de 1-18.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRTN.Focus()
                Return False
            End If

            Return resultado
        End Function

        Private Function NumerosEnteros(ByVal valor As Integer, ByVal li As Integer, ByVal ls As Integer) As Boolean
            If valor < li OrElse valor > ls Then
                Return False
            Else
                Return True
            End If
        End Function

        Private Function NumerosEnteros2(ByVal valor As Integer, ByVal li As Integer, ByVal ls As Integer) As Boolean
            If valor < li OrElse valor > ls Then
                MessageBox.Show(String.Concat("Los siguientes dos digitos: ", valor, " del municipio.", vbLf & "Solo se permiten numero del rango: ", li, " y ", ls, "."), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Else
                Return True
            End If
        End Function

        Public Departamentos As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)()

        Private Sub AggDatosDiccionario()
            Departamentos.Clear()
            Departamentos.Add(1, "1-8")
            Departamentos.Add(2, "1-10")
            Departamentos.Add(3, "1-21")
            Departamentos.Add(4, "1-23")
            Departamentos.Add(5, "1-12")
            Departamentos.Add(6, "1-16")
            Departamentos.Add(7, "1-19")
            Departamentos.Add(8, "1-28")
            Departamentos.Add(9, "1-6")
            Departamentos.Add(10, "1-17")
            Departamentos.Add(11, "1-4")
            Departamentos.Add(12, "1-19")
            Departamentos.Add(13, "1-28")
            Departamentos.Add(14, "1-16")
            Departamentos.Add(15, "1-23")
            Departamentos.Add(16, "1-28")
            Departamentos.Add(17, "1-9")
            Departamentos.Add(18, "1-11")
        End Sub

        Private Function BuscarDiccionario(ByVal x As Integer) As Boolean
            If Departamentos.ContainsKey(x) Then
                Dim source As String = Departamentos(x)
                Dim result As String() = source.Split(New Char() {"-"c, "-"c})
                Li = Integer.Parse(result(0))
                Ls = Integer.Parse(result(1))
                Return True
            Else
                Return False
            End If
        End Function




End Class