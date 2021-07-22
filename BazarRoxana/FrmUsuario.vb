Imports System.Data.SqlClient
Public Class FrmUsuario
    Private Sub chkMostrarContra_CheckedChanged(sender As Object, e As EventArgs) Handles chkMostrarContra.CheckedChanged
        TxtContraseña.UseSystemPasswordChar = Not chkMostrarContra.Checked '<-Oculta contraseña
    End Sub

    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuario.TextChanged
        LbContador2.Text = TxtUsuario.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub
    Private Sub TxtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs)  '<--Funcion para validar que caracteres son permitidos y evitar que se introduscan espacio al principio. 
        If Len(Me.TxtUsuario.Text) = "0" Then
            If InStr(1, "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,°,!,#,$,%,&,/,(,),=,?,¡,*,¨,[,],_,:,;,.,-,{,},+,´,',¿" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub TxtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs)  '<--Funcion para validar que caracteres son permitidos y evitar que se introduscan espacio al principio. 
        If Len(Me.TxtContraseña.Text) = "0" Then
            If InStr(1, "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,°,!,#,$,%,&,/,(,),=,?,¡,*,¨,[,],_,:,;,.,-,{,},+,´,',¿" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConeccion()

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodUsuario as 'Código del usuario', CodEmple as 'Código del empleado', UsuarioEmp as 'Usuario',ContraseñaEmp as 'Contraseña' from Usuario", ConexionBase)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
        ConexionBase.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        AbrirConeccion() '<-- Llamado de la funcion 
        If (txtNombreEmpleado.TextLength < 2) Then
            MessageBox.Show("Debe ingresar como minimo 2 caracteres en nombre del empleado")
        ElseIf (TxtUsuario.TextLength < 2) Then
            MessageBox.Show("Debe ingresar como minimo 2 caracteres en el usuario")
        ElseIf (TxtContraseña.TextLength < 2) Then
            MessageBox.Show("Debe ingresar como minimo 8 caracteres en la contraseña")
        Else

            If txtNombreEmpleado.Text = "" Or TxtCodigoEmpleado.Text = "" Or TxtUsuario.Text = "" Or TxtContraseña.Text = "" Then
                MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                If RegistradoUsuario(TxtCodigoEmpleado.Text) = False Then '<-- Llamado de funcion que verifica si el codigo ya esta repetido en la base de datos.

                    If RegistradoNombreUsuario(TxtUsuario.Text) = False Then
                        Dim consultaGuardar As String = "insert into Usuario(CodEmple, UsuarioEmp, ContraseñaEmp) values(@CodEmple, @UsuarioEmp, @ContraseñaEmp)" '<--Consulta
                        'Toma los valores de los textbox y los guardas en la base de datos. 
                        Dim ejecutar As New SqlCommand(consultaGuardar, ConexionBase)
                        ejecutar.Parameters.AddWithValue("@CodEmple", (TxtCodigoEmpleado.Text))
                        ejecutar.Parameters.AddWithValue("@UsuarioEmp", (TxtUsuario.Text))
                        ejecutar.Parameters.AddWithValue("@ContraseñaEmp", (TxtContraseña.Text))
                        ejecutar.ExecuteNonQuery()
                        MsgBox("El usuario se a guardado", MsgBoxStyle.Information, "Informacion")
                    Else
                        MsgBox("El nombre de usuario ya esta registrado", MsgBoxStyle.Exclamation, "Advertencia")
                    End If
                Else
                    MsgBox("El usuario ya esta registrado", MsgBoxStyle.Exclamation, "Advertencia")
                End If
            End If
        End If

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodUsuario as 'Código del usuario', CodEmple as 'Código del empleado', UsuarioEmp as 'Usuario',ContraseñaEmp as 'Contraseña' from Usuario", ConexionBase)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp

        ConexionBase.Close()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        AbrirConeccion() '<-- Llamado de la funcion 
        If (txtNombreEmpleado.TextLength < 2) Then
            MessageBox.Show("Debe ingresar como minimo 2 caracteres en nombre del empleado")
        ElseIf (TxtUsuario.TextLength < 2) Then
            MessageBox.Show("Debe ingresar como minimo 2 caracteres en el usuario")
        ElseIf (TxtContraseña.TextLength < 2) Then
            MessageBox.Show("Debe ingresar como minimo 8 caracteres en la contraseña")
        Else

            If txtNombreEmpleado.Text = "" Or TxtCodigoEmpleado.Text = "" Or TxtUsuario.Text = "" Or TxtContraseña.Text = "" Then
                MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                If RegistradoUsuario(TxtCodigoEmpleado.Text) = True Then '<-- Llamado de funcion que verifica si el codigo ya esta repetido en la base de datos.

                    Dim consultaActualizar As String = "update Usuario set CodEmple=@CodEmple, UsuarioEmp=@UsuarioEmp, ContraseñaEmp=@ContraseñaEmp where CodUsuario=@CodUsuario" '<--Consulta
                    'Toma los valores de los textbox y los actualiza en la base de datos. 
                    Dim ejecutar As New SqlCommand(consultaActualizar, ConexionBase)
                    ejecutar.Parameters.AddWithValue("@CodUsuario", (TxtCodigoUsuario.Text))
                    ejecutar.Parameters.AddWithValue("@CodEmple", (TxtCodigoEmpleado.Text))
                    ejecutar.Parameters.AddWithValue("@UsuarioEmp", (TxtUsuario.Text))
                    ejecutar.Parameters.AddWithValue("@ContraseñaEmp", (TxtContraseña.Text))
                    ejecutar.ExecuteNonQuery()
                    MsgBox("El usuario se a actualizado", MsgBoxStyle.Information, "Informacion")
                Else
                    MsgBox("El usuario ya esta registrado", MsgBoxStyle.Exclamation, "Advertencia")
                End If
            End If
        End If

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodUsuario as 'Código del usuario', CodEmple as 'Código del empleado', UsuarioEmp as 'Usuario',ContraseñaEmp as 'Contraseña' from Usuario", ConexionBase)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp

        ConexionBase.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        AbrirConeccion() '<-- Llamado de la funcion 
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Esta seguro que quiere eliminar este usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then

            If TxtCodigoEmpleado.Text = "" Then
                MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Dim consultaElim As String = "delete from Usuario where CodUsuario= @CodUsuario" '<-Consulta
                'Toma el valor del textbox y lo deshabilita en la base de datos.
                Dim ejecutar As New SqlCommand(consultaElim, ConexionBase)
                ejecutar.Parameters.AddWithValue("@CodUsuario", Val(TxtCodigoUsuario.Text))

                ejecutar.ExecuteNonQuery()
                MsgBox("El usuario se a eliminado", MsgBoxStyle.Information, "Informacion")
            End If
        End If

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodUsuario as 'Código del usuario', CodEmple as 'Código del empleado', UsuarioEmp as 'Usuario',ContraseñaEmp as 'Contraseña' from Usuario", ConexionBase)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
        ConexionBase.Close()
        'Limpia los textbox y los checkbox.
        TxtCodigoUsuario.Clear()
        TxtUsuario.Clear()
        TxtContraseña.Clear()
        TxtCodigoEmpleado.Clear()
        txtNombreEmpleado.Clear()
        chkMostrarContra.Checked = False
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click '<-Limpia
        TxtCodigoUsuario.Clear()
        TxtUsuario.Clear()
        TxtContraseña.Clear()
        TxtCodigoEmpleado.Clear()
        txtNombreEmpleado.Clear()
        chkMostrarContra.Checked = False
    End Sub

    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs) Handles DGV.DoubleClick '<-manda la informacion a los textbox
        TxtCodigoUsuario.Text = DGV.CurrentRow.Cells(0).Value
        TxtCodigoEmpleado.Text = DGV.CurrentRow.Cells(1).Value
        TxtUsuario.Text = DGV.CurrentRow.Cells(2).Value
        TxtContraseña.Text = DGV.CurrentRow.Cells(3).Value
    End Sub
    Public Sub filtrarDatos(ByVal buscar As String) '<-Funcion para filtrar datos que se mostraran en el DataGridView.

        Try
            Using con As New SqlConnection("Data Source=localhost;Initial Catalog=BazarRoxana;Integrated Security=True")
                Dim query = "select CodUsuario as 'Código del usuario', CodEmple as 'Código del empleado', UsuarioEmp as 'Usuario',ContraseñaEmp as 'Contraseña' from Usuario where UsuarioEmp LIKE @filtro"

                Dim adapter As New SqlDataAdapter(query, con)
                adapter.SelectCommand.Parameters.AddWithValue("@filtro", String.Format("%{0}%", buscar))

                Dim table As New DataTable
                adapter.Fill(table)

                DGV.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        LbContador6.Text = TxtBusqueda.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        Dim filtro As String = CType(sender, TextBox).Text
        If filtro.Trim() <> String.Empty Then  'Si no es vacío filtra
            filtrarDatos(filtro)
        Else
            AbrirConeccion()

            Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consultadim
            Using adaptador As New SqlDataAdapter("select CodUsuario as 'Código del usuario', CodEmple as 'Código del empleado', UsuarioEmp as 'Usuario',ContraseñaEmp as 'Contraseña' from Usuario", ConexionBase)
                adaptador.Fill(DatosEmp)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGV.DataSource = DatosEmp

            ConexionBase.Close()
        End If
    End Sub

    Private Sub btnAgg_E_Click(sender As Object, e As EventArgs) Handles btnAgg_E.Click '<-Llama la ventana de buscar empleado
        Dim frm As New FrmBusquedaEmpleado
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub TxtCodigoEmpleado_TextChanged(sender As Object, e As EventArgs) Handles TxtCodigoEmpleado.TextChanged '<-Llama al nombre del empleado con el codigo empleado
        AbrirConeccion()
        Dim Recuperar As String = "select * from Empleados where CodEmple= '" & TxtCodigoEmpleado.Text & "'"
        Dim Mostrar As SqlDataReader
        Dim Ejecutar As SqlCommand
        Ejecutar = New SqlCommand(Recuperar, ConexionBase)
        Mostrar = Ejecutar.ExecuteReader
        Dim Estado As String
        Estado = Mostrar.Read
        If (Estado = True) Then
            txtNombreEmpleado.Text = Mostrar(1)
        Else
            txtNombreEmpleado.Text = ""
        End If
        Mostrar.Close()
        ConexionBase.Close()
    End Sub

    Private Sub btnLimpiarEmple_Click(sender As Object, e As EventArgs) Handles btnLimpiarEmple.Click '<-Limpia
        TxtCodigoEmpleado.Clear()
        txtNombreEmpleado.Clear()
    End Sub

    Private Sub TxtContraseña_TextChanged(sender As Object, e As EventArgs) Handles TxtContraseña.TextChanged
        LbContador4.Text = TxtContraseña.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub
End Class