Imports System.Data.SqlClient
Public Class FrmUsuario
    Private Sub chkMostrarContra_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMostrarcontra.CheckedChanged
        TxtContraseña.UseSystemPasswordChar = Not ChkMostrarcontra.Checked '<-Oculta contraseña
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
        AbrirConexion()

        Dim DatosUsu As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using AdaptadorUsu As New SqlDataAdapter("execute consultaDGV", ConexionBase)
            AdaptadorUsu.Fill(DatosUsu)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DgvUsuarios.DataSource = DatosUsu
        DgvUsuarios.Columns(4).Visible = False
        ConexionBase.Close()
        BtnActualizar.Visible = False
        BtnEliminar.Visible = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        AbrirConexion() '<-- Llamado de la funcion 
        If (txtNombreempleado.TextLength < 2) Then
            MessageBox.Show("Debe ingresar como minimo 2 caracteres en nombre del empleado")
        ElseIf (TxtUsuario.TextLength < 2) Then
            MessageBox.Show("Debe ingresar como minimo 2 caracteres en el usuario")
        ElseIf (TxtContraseña.TextLength < 2) Then
            MessageBox.Show("Debe ingresar como minimo 8 caracteres en la contraseña")
        Else

            If txtNombreempleado.Text = "" Or TxtCodigoempleado.Text = "" Or TxtUsuario.Text = "" Or TxtContraseña.Text = "" Then
                MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                If RegistradoUsuario(TxtCodigoempleado.Text) = False Then '<-- Llamado de funcion que verifica si el codigo ya esta repetido en la base de datos.

                    If RegistradoNombreUsuario(TxtUsuario.Text) = False Then
                        Dim ConsultaGuardar As String = "EXECUTE [dbo].[Insertar] @codemp, @users,@pss,'Encriptacion'" '<--Consulta
                        'Toma los valores de los textbox y los guardas en la base de datos. 
                        Dim EjecutarCon As New SqlCommand(ConsultaGuardar, ConexionBase)
                        EjecutarCon.Parameters.AddWithValue("@codemp", (TxtCodigoempleado.Text))
                        EjecutarCon.Parameters.AddWithValue("@users", (TxtUsuario.Text))
                        EjecutarCon.Parameters.AddWithValue("@pss", (TxtContraseña.Text))
                        EjecutarCon.ExecuteNonQuery()
                        MsgBox("El usuario se a guardado", MsgBoxStyle.Information, "Informacion")
                        BtnActualizar.Visible = False
                    Else
                        MsgBox("El nombre de usuario ya esta registrado", MsgBoxStyle.Exclamation, "Advertencia")
                        BtnActualizar.Visible = True
                    End If
                Else
                    MsgBox("El usuario ya esta registrado", MsgBoxStyle.Exclamation, "Advertencia")
                End If
            End If
        End If
        BtnEliminar.Visible = False
        Dim DatosUsu As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using AdaptadorUsu As New SqlDataAdapter("execute consultaDGV", ConexionBase)
            AdaptadorUsu.Fill(DatosUsu)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DgvUsuarios.DataSource = DatosUsu
        DgvUsuarios.Columns(4).Visible = False
        ConexionBase.Close()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        AbrirConexion() '<-- Llamado de la funcion 
        If (txtNombreempleado.TextLength < 2) Then
            MessageBox.Show("Debe ingresar como minimo 2 caracteres en nombre del empleado")
        ElseIf (TxtUsuario.TextLength < 2) Then
            MessageBox.Show("Debe ingresar como minimo 2 caracteres en el usuario")
        ElseIf (TxtContraseña.TextLength < 2) Then
            MessageBox.Show("Debe ingresar como minimo 8 caracteres en la contraseña")
        Else

            If txtNombreempleado.Text = "" Or TxtCodigoempleado.Text = "" Or TxtUsuario.Text = "" Or TxtContraseña.Text = "" Then
                MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                If RegistradoUsuario(TxtCodigoempleado.Text) = True Then '<-- Llamado de funcion que verifica si el codigo ya esta repetido en la base de datos.

                    Dim ConsultaActualizar As String = "EXECUTE [dbo].[ActualizarUsuario] @CodUsuario ,@CodEmple ,@UsuarioEmp ,@ContraseñaEmp" '<--Consulta
                    'Toma los valores de los textbox y los actualiza en la base de datos. 
                    Dim EjecutarCon As New SqlCommand(ConsultaActualizar, ConexionBase)
                    EjecutarCon.Parameters.AddWithValue("@CodUsuario", (TxtCodigousuario.Text))
                    EjecutarCon.Parameters.AddWithValue("@CodEmple", (TxtCodigoempleado.Text))
                    EjecutarCon.Parameters.AddWithValue("@UsuarioEmp", (TxtUsuario.Text))
                    EjecutarCon.Parameters.AddWithValue("@ContraseñaEmp", (TxtContraseña.Text))
                    EjecutarCon.ExecuteNonQuery()
                    MsgBox("El usuario se a actualizado", MsgBoxStyle.Information, "Informacion")
                    BtnGuardar.Visible = False
                Else
                    MsgBox("El usuario ya esta registrado", MsgBoxStyle.Exclamation, "Advertencia")
                    BtnActualizar.Visible = False
                End If
            End If
        End If
        BtnEliminar.Visible = True
        Dim DatosUsu As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using AdaptadorUsu As New SqlDataAdapter("execute consultaDGV", ConexionBase)
            AdaptadorUsu.Fill(DatosUsu)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DgvUsuarios.DataSource = DatosUsu
        DgvUsuarios.Columns(4).Visible = False
        ConexionBase.Close()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        AbrirConexion() '<-- Llamado de la funcion 
        Dim OpcionDia As DialogResult
        OpcionDia = MessageBox.Show("¿Esta seguro que quiere eliminar este usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If OpcionDia = DialogResult.Yes Then

            If TxtCodigoempleado.Text = "" Then
                MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Dim ConsultaElim As String = "delete from Usuario where CodUsuario= @CodUsuario" '<-Consulta
                'Toma el valor del textbox y lo deshabilita en la base de datos.
                Dim EjecutarCon As New SqlCommand(ConsultaElim, ConexionBase)
                EjecutarCon.Parameters.AddWithValue("@CodUsuario", Val(TxtCodigousuario.Text))

                EjecutarCon.ExecuteNonQuery()
                MsgBox("El usuario se a eliminado", MsgBoxStyle.Information, "Informacion")
                'Limpia los textbox y los checkbox.
                TxtCodigousuario.Clear()
                TxtUsuario.Clear()
                TxtContraseña.Clear()
                TxtCodigoempleado.Clear()
                txtNombreempleado.Clear()
                ChkMostrarcontra.Checked = False
                BtnGuardar.Visible = True
                DgvUsuarios.Columns(4).Visible = False
            End If
        End If

        Dim DatosUsu As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using AdaptadorUsu As New SqlDataAdapter("execute consultaDGV", ConexionBase)
            AdaptadorUsu.Fill(DatosUsu)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DgvUsuarios.DataSource = DatosUsu
        ConexionBase.Close()
        BtnActualizar.Visible = False
        BtnEliminar.Visible = False
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click '<-Limpia
        TxtCodigousuario.Clear()
        TxtUsuario.Clear()
        TxtContraseña.Clear()
        TxtCodigoempleado.Clear()
        txtNombreempleado.Clear()
        ChkMostrarcontra.Checked = False
        DgvUsuarios.Columns(4).Visible = False
        BtnGuardar.Visible = True
        BtnActualizar.Visible = False
        BtnEliminar.Visible = False
    End Sub

    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs) Handles DgvUsuarios.DoubleClick '<-manda la informacion a los textbox
        TxtCodigousuario.Text = DgvUsuarios.CurrentRow.Cells(0).Value
        TxtCodigoempleado.Text = DgvUsuarios.CurrentRow.Cells(1).Value
        TxtUsuario.Text = DgvUsuarios.CurrentRow.Cells(2).Value
        TxtContraseña.Text = DgvUsuarios.CurrentRow.Cells(4).Value
        DgvUsuarios.Columns(4).Visible = False
        BtnGuardar.Visible = False
        BtnActualizar.Visible = True
        BtnEliminar.Visible = True
    End Sub
    Public Sub FiltrarDatos(ByVal BuscarUsu As String) '<-Funcion para filtrar datos que se mostraran en el DataGridView.

        Try
            Dim QueryUsu = "select CodUsuario as 'Código del usuario', CodEmple as 'Código del empleado', UsuarioEmp as 'Usuario',ContraseñaEmp as 'Contraseña', CONVERT(varchar(max), DECRYPTBYPASSPHRASE(Llave,ContraseñaEmp)) as Libre from Usuario where UsuarioEmp LIKE @filtro"

            Dim AdapterUsu As New SqlDataAdapter(QueryUsu, ConexionBase)
            AdapterUsu.SelectCommand.Parameters.AddWithValue("@filtro", String.Format("%{0}%", BuscarUsu))

            Dim TableUsu As New DataTable
            AdapterUsu.Fill(TableUsu)

            DgvUsuarios.DataSource = TableUsu
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        LbContador6.Text = TxtBusqueda.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        Dim FiltroUsu As String = CType(sender, TextBox).Text
        If FiltroUsu.Trim() <> String.Empty Then  'Si no es vacío filtra
            filtrarDatos(FiltroUsu)
        Else
            AbrirConexion()

            Dim DatosUsu As New DataTable 'tabla temporal que recoge los datos de la consultadim
            Using AdaptadorUsu As New SqlDataAdapter("execute consultaDGV", ConexionBase)
                AdaptadorUsu.Fill(DatosUsu)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DgvUsuarios.DataSource = DatosUsu
            DgvUsuarios.Columns(4).Visible = False
            ConexionBase.Close()
        End If
    End Sub

    Private Sub btnAgg_E_Click(sender As Object, e As EventArgs) Handles btnAgg_E.Click '<-Llama la ventana de buscar empleado
        Dim FrmEmple As New FrmBusquedaEmpleado
        AddOwnedForm(FrmEmple)
        FrmEmple.ShowDialog()
    End Sub

    Private Sub TxtCodigoEmpleado_TextChanged(sender As Object, e As EventArgs) Handles TxtCodigoempleado.TextChanged '<-Llama al nombre del empleado con el codigo empleado
        AbrirConexion()
        Dim RecuperarCon As String = "select * from Empleados where CodEmple= '" & TxtCodigoempleado.Text & "'"
        Dim MostrarUsu As SqlDataReader
        Dim EjecutarCom As SqlCommand
        EjecutarCom = New SqlCommand(RecuperarCon, ConexionBase)
        MostrarUsu = EjecutarCom.ExecuteReader
        Dim EstadoUsu As String
        EstadoUsu = MostrarUsu.Read
        If (EstadoUsu = True) Then
            txtNombreempleado.Text = MostrarUsu(1)
        Else
            txtNombreempleado.Text = ""
        End If
        MostrarUsu.Close()
        ConexionBase.Close()
    End Sub

    Private Sub btnLimpiarEmple_Click(sender As Object, e As EventArgs) Handles btnLimpiarEmple.Click '<-Limpia
        TxtCodigoempleado.Clear()
        txtNombreempleado.Clear()
    End Sub

    Private Sub TxtContraseña_TextChanged(sender As Object, e As EventArgs) Handles TxtContraseña.TextChanged
        LbContador4.Text = TxtContraseña.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

End Class