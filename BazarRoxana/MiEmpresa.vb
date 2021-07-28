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
    Dim FicheroEmpresa As [Byte]() = Nothing
    Public Shared StatePlato As String = "INS"
    Public Shared StateImg As Boolean = False
    Private LimiteSuperior As Integer
    Private LimiteInferior As Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PtbImagen.Click
        Dim OpenFileDialog As New OpenFileDialog()

        OpenFileDialog.CheckFileExists = True
        OpenFileDialog.AddExtension = True
        OpenFileDialog.Multiselect = True
        OpenFileDialog.Filter = "Image files (*.png)|*.jpg"


        If OpenFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim RutaArchivo As String = OpenFileDialog.FileNames(0)
            Dim FsEmp = File.Open(RutaArchivo, FileMode.Open)
            FicheroEmpresa = New [Byte](FsEmp.Length - 1) {}
            FsEmp.Read(FicheroEmpresa, 0, CInt(FsEmp.Length))


            FsEmp.Close()
            PtbImagen.Image = Image.FromFile(OpenFileDialog.FileName)
            PtbImagen.SizeMode = PtbImagen.SizeMode.StretchImage
        End If

    End Sub

    Private Sub MiEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtCai2.Enabled = False
        TxtCai3.Enabled = False
        TxtCai4.Enabled = False
        TxtCai5.Enabled = False
        TxtCai6.Enabled = False
        AbrirConexion()

        Dim DatosEmpleado As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from MiEmpresa", ConexionBase)
            adaptador.Fill(DatosEmpleado)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DgvInformacion.DataSource = DatosEmpleado

        ConexionBase.Close()

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim MailEmpresa As New System.Net.Mail.MailAddress(TxtEmail.Text) '<-Validar el correro
        Catch
            MsgBox("Verifique los datos del email", MsgBoxStyle.Exclamation, "Advertencia")
        End Try

        AbrirConexion()
        If RegistradoMiEmpresa() = False Then
            If StatePlato = "INS" Then
                If FicheroEmpresa IsNot Nothing Or TxtDireccion.Text = "" Or TxtRtn.Text = "" Or TxtEmail.Text = "" Or TxtCai1.Text = "" Or TxtCai2.Text = "" Or TxtCai3.Text = "" Or TxtCai4.Text = "" Or TxtCai5.Text = "" Or TxtCai6.Text = "" Then
                    If TxtEmail.TextLength < 6 Then
                        MsgBox("Debe ingresar como minimo 6 caracteres en el correro.", MsgBoxStyle.Exclamation, "Advertencia")
                    ElseIf (TxtTelefono.TextLength < 8) Then
                        MsgBox("Debe ingresar 8 caracteres en el teléfono.", MsgBoxStyle.Exclamation, "Advertencia")
                    ElseIf Cuantas(".", TxtEmail.Text) > 1 Then
                        MessageBox.Show("No podes ingresar mas de 1 punto.", "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    ElseIf (TxtDireccion.TextLength < 10) Then
                        MsgBox("Debe ingresar 10 caracteres en la dirección.", MsgBoxStyle.Exclamation, "Advertencia")
                    ElseIf (TxtRtn.TextLength < 14) Then
                        MsgBox("Debe ingresar 14 caracteres en el RTN.", MsgBoxStyle.Exclamation, "Advertencia")
                    ElseIf (TxtCai1.TextLength < 6) Then
                        MsgBox("Debe ingresar 6 caracteres en la primera agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
                    ElseIf (TxtCai2.TextLength < 6) Then
                        MsgBox("Debe ingresar 6 caracteres en la segunda agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
                    ElseIf (TxtCai3.TextLength < 6) Then
                        MsgBox("Debe ingresar 6 caracteres en la tercera agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
                    ElseIf (TxtCai4.TextLength < 6) Then
                        MsgBox("Debe ingresar 6 caracteres en la cuarta agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
                    ElseIf (TxtCai5.TextLength < 6) Then
                        MsgBox("Debe ingresar 6 caracteres en la quinta agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
                    ElseIf (TxtCai6.TextLength < 2) Then
                        MsgBox("Debe ingresar 2 caracteres en la sexta agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
                    ElseIf VerificarRTN(TxtRtn.Text) Then
                        'cn.Guardar(txtnombre.Text, txtdesc.Text, cmbcateg.SelectedIndex + 1, txtdif.Text, txtfinalp.Text, fichero)
                        Dim ConsultaAct As String = "insert into MiEmpresa (Codigo,Direccion,RTN,CAI,Email,Telefono,Imagen) values(1,@Direccion,@RTN, (@GRP1+'-'+@GRP2+'-'+@GRP3+'-'+@GRP4+'-'+@GRP5+'-'+@GRP6), @Email, @Telefono, @Imagen)" '<-Consulta.
                        'Toma los valores de los textbox  y los actualiza en la base de datos. 
                        Dim EjecutarConsulta As New SqlCommand(ConsultaAct, ConexionBase)
                        EjecutarConsulta.Parameters.AddWithValue("@Direccion", (TxtDireccion.Text))
                        EjecutarConsulta.Parameters.AddWithValue("@RTN", (TxtRtn.Text))
                        EjecutarConsulta.Parameters.AddWithValue("@GRP1", (TxtCai1.Text))
                        EjecutarConsulta.Parameters.AddWithValue("@GRP2", (TxtCai2.Text))
                        EjecutarConsulta.Parameters.AddWithValue("@GRP3", (TxtCai3.Text))
                        EjecutarConsulta.Parameters.AddWithValue("@GRP4", (TxtCai4.Text))
                        EjecutarConsulta.Parameters.AddWithValue("@GRP5", (TxtCai5.Text))
                        EjecutarConsulta.Parameters.AddWithValue("@GRP6", (TxtCai6.Text))
                        EjecutarConsulta.Parameters.AddWithValue("@Email", TxtEmail.Text)
                        EjecutarConsulta.Parameters.AddWithValue("@Telefono", (TxtTelefono.Text))
                        EjecutarConsulta.Parameters.AddWithValue("@Imagen", (FicheroEmpresa))
                        EjecutarConsulta.ExecuteNonQuery()
                        MsgBox("La informacion se a guardado", MsgBoxStyle.Information, "Informacion")


                        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
                        Using adaptador As New SqlDataAdapter("select * from MiEmpresa", ConexionBase)
                            adaptador.Fill(DatosEmp)
                        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

                        DgvInformacion.DataSource = DatosEmp

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

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        AbrirConexion()
        Dim ConsultaAct As String = "delete from MiEmpresa where Codigo=1" '<-Consulta.
        'Toma los valores de los textbox  y los actualiza en la base de datos. 
        Dim EjecutarConsulta As New SqlCommand(ConsultaAct, ConexionBase)
        EjecutarConsulta.ExecuteNonQuery()
        MsgBox("La informacion se a eliminado", MsgBoxStyle.Information, "Informacion")

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from MiEmpresa", ConexionBase)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DgvInformacion.DataSource = DatosEmp


        ConexionBase.Close()

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim MailEmpresa As New System.Net.Mail.MailAddress(TxtEmail.Text) '<-Validar el correro
        AbrirConexion()
        Try
            If TxtEmail.TextLength < 6 Then
                MsgBox("Debe ingresar como minimo 6 caracteres en el correro.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtTelefono.TextLength < 8) Then
                MsgBox("Debe ingresar 8 caracteres en el teléfono.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf Cuantas(".", TxtEmail.Text) > 1 Then
                MessageBox.Show("No podes ingresar mas de 1 punto.", "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf (TxtDireccion.TextLength < 10) Then
                MsgBox("Debe ingresar 10 caracteres en la dirección.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtRtn.TextLength < 14) Then
                MsgBox("Debe ingresar 14 caracteres en el RTN.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtCai1.TextLength < 6) Then
                MsgBox("Debe ingresar 6 caracteres en la primera agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtCai2.TextLength < 6) Then
                MsgBox("Debe ingresar 6 caracteres en la segunda agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtCai3.TextLength < 6) Then
                MsgBox("Debe ingresar 6 caracteres en la tercera agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtCai4.TextLength < 6) Then
                MsgBox("Debe ingresar 6 caracteres en la cuarta agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtCai5.TextLength < 6) Then
                MsgBox("Debe ingresar 6 caracteres en la quinta agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtCai6.TextLength < 2) Then
                MsgBox("Debe ingresar 2 caracteres en la sexta agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")

            ElseIf VerificarRTN(TxtRtn.Text) Then
                StateImg = True
                'cn.Actualizar(txtnombre.Text, txtdesc.Text, cmbcateg.SelectedIndex + 1, txtdif.Text, txtfinalp.Text, fichero, txtcod.Text)
                Dim ConsultaAct As String = "update MiEmpresa set Direccion=@Direccion, RTN=@RTN, CAI=(@GRP1+'-'+@GRP2+'-'+@GRP3+'-'+@GRP4+'-'+@GRP5+'-'+@GRP6), Email=@Email,Telefono=@Telefono, Imagen=@Imagen where Codigo= 1" '<-Consulta.
                'Toma los valores de los textbox  y los actualiza en la base de datos. 
                Dim EjecutarConsulta As New SqlCommand(ConsultaAct, ConexionBase)
                EjecutarConsulta.Parameters.AddWithValue("@Direccion", (TxtDireccion.Text))
                EjecutarConsulta.Parameters.AddWithValue("@RTN", (TxtRtn.Text))
                EjecutarConsulta.Parameters.AddWithValue("@GRP1", (TxtCai1.Text))
                EjecutarConsulta.Parameters.AddWithValue("@GRP2", (TxtCai2.Text))
                EjecutarConsulta.Parameters.AddWithValue("@GRP3", (TxtCai3.Text))
                EjecutarConsulta.Parameters.AddWithValue("@GRP4", (TxtCai4.Text))
                EjecutarConsulta.Parameters.AddWithValue("@GRP5", (TxtCai5.Text))
                EjecutarConsulta.Parameters.AddWithValue("@GRP6", (TxtCai6.Text))
                EjecutarConsulta.Parameters.AddWithValue("@Email", (TxtEmail.Text))
                EjecutarConsulta.Parameters.AddWithValue("@Telefono", Val(TxtTelefono.Text))
                EjecutarConsulta.Parameters.AddWithValue("@Imagen", (FicheroEmpresa))

                EjecutarConsulta.ExecuteNonQuery()
                MsgBox("La informacion se a actualizado", MsgBoxStyle.Information, "Informacion")

                Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
                Using adaptador As New SqlDataAdapter("select * from MiEmpresa", ConexionBase)
                    adaptador.Fill(DatosEmp)
                End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

                DgvInformacion.DataSource = DatosEmp

            End If
        Catch
            If TxtEmail.TextLength < 6 Then
                MsgBox("Debe ingresar como minimo 6 caracteres en el correro.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtTelefono.TextLength < 8) Then
                MsgBox("Debe ingresar 8 caracteres en el teléfono.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf Cuantas(".", TxtEmail.Text) > 1 Then
                MessageBox.Show("No podes ingresar mas de 1 punto.", "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf (TxtDireccion.TextLength < 10) Then
                MsgBox("Debe ingresar 10 caracteres en la dirección.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtRtn.TextLength < 14) Then
                MsgBox("Debe ingresar 14 caracteres en el RTN.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtCai1.TextLength < 6) Then
                MsgBox("Debe ingresar 6 caracteres en la primera agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtCai2.TextLength < 6) Then
                MsgBox("Debe ingresar 6 caracteres en la segunda agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtCai3.TextLength < 6) Then
                MsgBox("Debe ingresar 6 caracteres en la tercera agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtCai4.TextLength < 6) Then
                MsgBox("Debe ingresar 6 caracteres en la cuarta agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtCai5.TextLength < 6) Then
                MsgBox("Debe ingresar 6 caracteres en la quinta agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtCai6.TextLength < 2) Then
                MsgBox("Debe ingresar 2 caracteres en la sexta agrupación del CAI.", MsgBoxStyle.Exclamation, "Advertencia")

            ElseIf VerificarRTN(TxtRtn.Text) Then
                StateImg = False
                'cn.Actualizar(txtnombre.Text, txtdesc.Text, cmbcateg.SelectedIndex + 1, txtdif.Text, txtfinalp.Text, fichero, txtcod.Text)
                Dim ConsultaAct As String = "update MiEmpresa set Direccion=@Direccion, RTN=@RTN, CAI=(@GRP1+'-'+@GRP2+'-'+@GRP3+'-'+@GRP4+'-'+@GRP5+'-'+@GRP6), Email=@Email,Telefono=@Telefono where Codigo= 1" '<-Consulta.
                'Toma los valores de los textbox  y los actualiza en la base de datos. 
                Dim EjecutarConsulta As New SqlCommand(ConsultaAct, ConexionBase)
                EjecutarConsulta.Parameters.AddWithValue("@Direccion", (TxtDireccion.Text))
                EjecutarConsulta.Parameters.AddWithValue("@RTN", (TxtRtn.Text))
                EjecutarConsulta.Parameters.AddWithValue("@GRP1", (TxtCai1.Text))
                EjecutarConsulta.Parameters.AddWithValue("@GRP2", (TxtCai2.Text))
                EjecutarConsulta.Parameters.AddWithValue("@GRP3", (TxtCai3.Text))
                EjecutarConsulta.Parameters.AddWithValue("@GRP4", (TxtCai4.Text))
                EjecutarConsulta.Parameters.AddWithValue("@GRP5", (TxtCai5.Text))
                EjecutarConsulta.Parameters.AddWithValue("@GRP6", (TxtCai6.Text))
                EjecutarConsulta.Parameters.AddWithValue("@Email", (TxtEmail.Text))
                EjecutarConsulta.Parameters.AddWithValue("@Telefono", Val(TxtTelefono.Text))

                EjecutarConsulta.ExecuteNonQuery()
                MsgBox("La informacion se a actualizado", MsgBoxStyle.Information, "Informacion")

                Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
                Using adaptador As New SqlDataAdapter("select * from MiEmpresa", ConexionBase)
                    adaptador.Fill(DatosEmp)
                End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

                DgvInformacion.DataSource = DatosEmp

            End If

        End Try

        ConexionBase.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        TxtCai2.Enabled = False
        TxtDireccion.Clear()
        TxtRtn.Clear()
        TxtCai1.Clear()
        TxtCai2.Clear()
        TxtCai3.Clear()
        TxtCai4.Clear()
        TxtCai5.Clear()
        TxtCai6.Clear()
        TxtCai.Clear()
        TxtEmail.Clear()
        TxtTelefono.Clear()
        PtbImagen.Image = Nothing
        LbContador7.Text = 0

    End Sub

    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs) Handles DgvInformacion.DoubleClick

        TxtDireccion.Text = DgvInformacion.CurrentRow.Cells(1).Value
        TxtRtn.Text = DgvInformacion.CurrentRow.Cells(2).Value
        TxtCai.Text = DgvInformacion.CurrentRow.Cells(3).Value
        TxtEmail.Text = DgvInformacion.CurrentRow.Cells(4).Value
        TxtTelefono.Text = DgvInformacion.CurrentRow.Cells(5).Value
        Dim BytesArray As Byte() = DgvInformacion.CurrentRow.Cells(6).Value
        Dim MemStream As MemoryStream = New MemoryStream(BytesArray)
        Dim ImagenEmp As Image = Image.FromStream(MemStream)
        PtbImagen.Image = ImagenEmp
        PtbImagen.SizeMode = PtbImagen.SizeMode.StretchImage

        ':::Declaramos una variable tipo string para almacenar la frase
        Dim CadenaCai As String = TxtCai.Text
        ':::Creamos el array tambien de tipo string para guardar cada palabra
        Dim PalabraCai() As String
        ':::Asignamos al array nuestra Cadena con la funcion Split y como separador un espacio vacio
        PalabraCai = CadenaCai.Split("-")
        ':::Iniciamos nuestro capturador de errores
        Try
            ':::Ahora pasamos a nuestro Label cada parte o seccion del array y le sustraemos las dos (2) primera letras
            TxtCai1.Text = PalabraCai(0).Substring(0, 6)
            TxtCai2.Text = PalabraCai(1).Substring(0, 6)
            TxtCai3.Text = PalabraCai(2).Substring(0, 6)
            TxtCai4.Text = PalabraCai(3).Substring(0, 6)
            TxtCai5.Text = PalabraCai(4).Substring(0, 6)
            TxtCai6.Text = PalabraCai(5).Substring(0, 2)

        Catch ex As Exception
            MsgBox("No se completo la operación por :" & ex.Message)
        End Try

    End Sub

    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDireccion.KeyPress
        Dim CaracteresPermitidos As String = "áéíóúÁÉÍÓÚqwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890-,. " & Convert.ToChar(8)
        Dim CharPress As Char = e.KeyChar
        If (Not (CaracteresPermitidos.Contains(CharPress))) Then

            MessageBox.Show("Solo se puede ingresar valores de tipo texto, numericos y caracteres especiales como -,.", "ERROR de escritura",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ' Deshechamos el carácter
            e.Handled = True
        ElseIf Len(Me.TxtDireccion.Text) = "0" Then
            If InStr(1, "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,1,2,3,4,5,6,7,8,9,0," & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios o caracteres especiales al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress

        SoloNumeros(e)
        If Len(Me.TxtTelefono.Text) = "0" Then
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

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles TxtDireccion.TextChanged
        LbContador.Text = TxtDireccion.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub txtRTN_TextChanged(sender As Object, e As EventArgs) Handles TxtRtn.TextChanged
        LbContador5.Text = TxtRtn.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub txtCAI_TextChanged(sender As Object, e As EventArgs) Handles TxtCai1.TextChanged
        If TxtCai1.Text.Length = 6 Then
            TxtCai2.Enabled = True
        Else
            TxtCai3.Enabled = False
            TxtCai4.Enabled = False
            TxtCai5.Enabled = False
            TxtCai6.Enabled = False
        End If
        TxtCai1.Text = Mayuscula(TxtCai1.Text, TxtCai1)

        CantidadCaracteres1 = (TxtCai1.Text.Length) + 1 '<-- Muestra la cantidad de caracteres escritas en textbox.

        LbContador7.Text = CantidadCaracteres1
    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles TxtTelefono.TextChanged
        LbContador9.Text = TxtTelefono.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub txtRTN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRtn.KeyPress
        SoloNumeros(e)
        If Len(Me.TxtRtn.Text) = "0" Then
            If InStr(1, "1,2,3,4,5,6,7,8,9,0" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios o caracteres especiales al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub txtCAI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCai1.KeyPress

        If Len(Me.TxtCai1.Text) = "0" Then
            If InStr(1, "q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,1,2,3,4,5,6,7,8,9,0" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios y caracteres especiales", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub txtCAI_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCai1.KeyDown
        Select Case e.KeyData

            Case Keys.Back

                Try

                    TxtCai1.Text = TxtCai1.Text.Substring(38, TxtCai1.Text.Count() - 1)

                Catch ex As Exception

                End Try

        End Select
    End Sub

    Private Sub txtCAI_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtCai1.KeyUp
        If Len(Me.TxtCai1.Text) = (Me.TxtCai1.MaxLength) Then
            TxtCai2.Focus()
        End If
    End Sub

    Private Sub txtCAI2_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtCai2.KeyUp
        If Len(Me.TxtCai2.Text) = (Me.TxtCai2.MaxLength) Then
            TxtCai3.Focus()
        End If
    End Sub

    Private Sub txtCAI3_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtCai3.KeyUp
        If Len(Me.TxtCai3.Text) = (Me.TxtCai3.MaxLength) Then
            TxtCai4.Focus()
        End If
    End Sub

    Private Sub txtCAI4_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtCai4.KeyUp
        If Len(Me.TxtCai4.Text) = (Me.TxtCai4.MaxLength) Then
            TxtCai5.Focus()
        End If
    End Sub

    Private Sub txtCAI5_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtCai5.KeyUp
        If Len(Me.TxtCai5.Text) = (Me.TxtCai5.MaxLength) Then
            TxtCai6.Focus()
        End If
    End Sub

    Private Sub txtCAI2_TextChanged(sender As Object, e As EventArgs) Handles TxtCai2.TextChanged
        If TxtCai2.Text.Length = 6 Then
            TxtCai3.Enabled = True
        Else
            TxtCai4.Enabled = False
            TxtCai5.Enabled = False
            TxtCai6.Enabled = False
        End If
        Dim SumaContador As Integer
        TxtCai2.Text = Mayuscula(TxtCai2.Text, TxtCai2)
        CantidadCaracteres2 = (TxtCai2.Text.Length) + 1 '<-- Muestra la cantidad de caracteres escritas en textbox.
        SumaContador = CantidadCaracteres1 + CantidadCaracteres2
        LbContador7.Text = SumaContador

    End Sub

    Private Sub txtCAI3_TextChanged(sender As Object, e As EventArgs) Handles TxtCai3.TextChanged
        If TxtCai3.Text.Length = 6 Then
            TxtCai4.Enabled = True
        Else
            TxtCai5.Enabled = False
            TxtCai6.Enabled = False
        End If
        Dim SumaContador As Integer
        TxtCai3.Text = Mayuscula(TxtCai3.Text, TxtCai3)
        CantidadCaracteres3 = (TxtCai3.Text.Length) + 1 '<-- Muestra la cantidad de caracteres escritas en textbox.
        SumaContador = CantidadCaracteres1 + CantidadCaracteres2 + CantidadCaracteres3
        LbContador7.Text = SumaContador
    End Sub

    Private Sub txtCAI4_TextChanged(sender As Object, e As EventArgs) Handles TxtCai4.TextChanged
        If TxtCai4.Text.Length = 6 Then
            TxtCai5.Enabled = True
        Else
            TxtCai6.Enabled = False
        End If
        Dim SumaContador As Integer
        TxtCai4.Text = Mayuscula(TxtCai4.Text, TxtCai4)
        CantidadCaracteres4 = (TxtCai4.Text.Length) + 1 '<-- Muestra la cantidad de caracteres escritas en textbox.
        SumaContador = CantidadCaracteres1 + CantidadCaracteres2 + CantidadCaracteres3 + CantidadCaracteres4
        LbContador7.Text = SumaContador
    End Sub

    Private Sub txtCAI5_TextChanged(sender As Object, e As EventArgs) Handles TxtCai5.TextChanged
        If TxtCai5.Text.Length = 6 Then
            TxtCai6.Enabled = True
        End If
        Dim SumaContador As Integer
        TxtCai5.Text = Mayuscula(TxtCai5.Text, TxtCai5)
        CantidadCaracteres5 = (TxtCai5.Text.Length) + 1 '<-- Muestra la cantidad de caracteres escritas en textbox.
        SumaContador = CantidadCaracteres1 + CantidadCaracteres2 + CantidadCaracteres3 + CantidadCaracteres4 + CantidadCaracteres5
        LbContador7.Text = SumaContador
    End Sub

    Private Sub txtCAI6_TextChanged(sender As Object, e As EventArgs) Handles TxtCai6.TextChanged
        Dim SumaContador As Integer
        TxtCai6.Text = Mayuscula(TxtCai6.Text, TxtCai6)
        CantidadCaracteres6 = (TxtCai6.Text.Length) '<-- Muestra la cantidad de caracteres escritas en textbox.
        SumaContador = CantidadCaracteres1 + CantidadCaracteres2 + CantidadCaracteres3 + CantidadCaracteres4 + CantidadCaracteres5 + CantidadCaracteres6
        LbContador7.Text = SumaContador
    End Sub

    Private Sub txtCAI2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCai2.KeyPress
        If Len(Me.TxtCai2.Text) = "0" Then
            If InStr(1, "q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,1,2,3,4,5,6,7,8,9,0" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios y caracteres especiales", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If

    End Sub

    Private Sub txtCAI3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCai3.KeyPress
        If Len(Me.TxtCai3.Text) = "0" Then
            If InStr(1, "q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,1,2,3,4,5,6,7,8,9,0" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios y caracteres especiales", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub txtCAI4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCai4.KeyPress
        If Len(Me.TxtCai4.Text) = "0" Then
            If InStr(1, "q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,1,2,3,4,5,6,7,8,9,0" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios y caracteres especiales", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If

    End Sub

    Private Sub txtCAI5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCai5.KeyPress
        If Len(Me.TxtCai5.Text) = "0" Then
            If InStr(1, "q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,1,2,3,4,5,6,7,8,9,0" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios y caracteres especiales", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub txtCAI6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCai6.KeyPress
        If Len(Me.TxtCai6.Text) = "0" Then
            If InStr(1, "q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,1,2,3,4,5,6,7,8,9,0" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios y caracteres especiales", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub


    Private Function VerificarRTN(ByVal cadena As String) As Boolean
        Dim ResultadoRtn As Boolean = False
        Dim DeptoRtn As Integer = Integer.Parse(cadena.Substring(0, 2))
        Dim MuniRtn As Integer = Integer.Parse(cadena.Substring(2, 2))
        Dim AñoRtn As Integer = Integer.Parse(cadena.Substring(4, 4))
        Dim FolioRtn As Integer = Integer.Parse(cadena.Substring(8, 6))
        AggDatosDiccionario()

        If NumerosEnteros(DeptoRtn, 1, 18) Then
            Dim Est As Boolean = BuscarDiccionario(DeptoRtn)

            If NumerosEnteros2(MuniRtn, LimiteInferior, LimiteSuperior) Then

                If NumerosEnteros(AñoRtn, 1900, 2100) Then

                    If NumerosEnteros(FolioRtn, 1, 999999) Then
                        ResultadoRtn = True
                    Else
                        MessageBox.Show("El folio debe estar en un rango del 00001-99999", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        TxtRtn.Focus()


                    End If
                Else
                    MessageBox.Show("El año debe estar en un rango del 1900-2100", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    TxtRtn.Focus()
                End If
            Else
                Return False
            End If
        Else
            MessageBox.Show("1. Los primeros dos numeros del RTN. " & vbLf & "2. Deben estar en un rango de 1-18.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtRtn.Focus()
                Return False
            End If

        Return ResultadoRtn
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
            MessageBox.Show(String.Concat("Los siguientes dos dígitos: ", valor, " del municipio.", vbLf & "Solo se permiten número del rango: ", li, " y ", ls, "."), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
            Dim SourceDep As String = Departamentos(x)
            Dim ResultDep As String() = SourceDep.Split(New Char() {"-"c, "-"c})
            LimiteInferior = Integer.Parse(ResultDep(0))
            LimiteSuperior = Integer.Parse(ResultDep(1))
            Return True
            Else
                Return False
            End If
        End Function




End Class