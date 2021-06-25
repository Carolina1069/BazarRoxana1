Imports System.Data.SqlClient

Public Class Empleado
    Private Sub Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkEstado.Checked = True
        abrir()

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', UsuarioEmple as 'Usuario del empleado',Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", conexion)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
        conexion.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Cat As Integer
        abrir() '<-- Llamado de la funcion 
        If (txtNombreEmpleado.TextLength < 2) Then
            MessageBox.Show("Debe ingresar como minimo 2 caracteres en nombre del empleado")
        ElseIf (TxtUsuario.TextLength < 2) Then
            MessageBox.Show("Debe ingresar como minimo 2 caracteres en usuario del empleado")
        ElseIf (TxtContraseña.TextLength < 8) Then
            MessageBox.Show("Debe ingresar como minimo 8 caracteres en la contraseña del empleado")
        Else

            If txtNombreEmpleado.Text = "" Or TxtContraseña.Text = "" Or chkEstado.Checked = False Or DGV.Rows.Count = 0 Then
                MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                If RegistradoEmpleados(TxtCodigoEmpleado.Text) = False Then '<-- Llamado de funcion que verifica si el codigo ya esta repetido en la base de datos.

                    If CbxNivel.SelectedItem = "Gerente" Then '<-- Especifica los valores del combobox que toman un valor numerico con la variable "cat".
                        Cat = 1
                    Else
                        Cat = 2
                    End If

                    Dim consultaGuardar As String = "insert into Empleados(NombEmple, UsuarioEmple,Contraseña,NivelEmple,EstadoEmple) values(@NombEmple,@UsuarioEmple,@Contraseña,@NivelEmple,1)" '<--Consulta
                    'Toma los valores de los textbox y el combobox y los guardas en la base de datos. 
                    Dim ejecutar As New SqlCommand(consultaGuardar, conexion)
                    ejecutar.Parameters.AddWithValue("@NombEmple", (txtNombreEmpleado.Text))
                    ejecutar.Parameters.AddWithValue("@UsuarioEmple", (TxtUsuario.Text))
                    ejecutar.Parameters.AddWithValue("@Contraseña", (TxtContraseña.Text))
                    ejecutar.Parameters.AddWithValue("@NivelEmple", (Cat))

                    ejecutar.ExecuteNonQuery()
                    MsgBox("El empleado se a guardado", MsgBoxStyle.Information, "Informacion")
                Else
                    MsgBox("El Empleado ya esta registrado", MsgBoxStyle.Exclamation, "Advertencia")
                End If
            End If
        End If

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', UsuarioEmple as 'Usuario del empleado',Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", conexion)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp

        conexion.Close()

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        abrir()
        If (txtNombreEmpleado.TextLength < 2) Then
            MessageBox.Show("Debe ingresar como minimo 2 caracteres en nombre del empleado")
        ElseIf (TxtUsuario.TextLength < 2) Then
            MessageBox.Show("Debe ingresar como minimo 2 caracteres en usuario del empleado")
        ElseIf (TxtContraseña.TextLength < 8) Then
            MessageBox.Show("Debe ingresar como minimo 8 caracteres en la contraseña del empleado")

        Else

            If txtNombreEmpleado.Text = "" Or TxtContraseña.Text = "" Or DGV.Rows.Count = 0 Then
                MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Dim Cat As Integer
                Dim estado As Integer

                If CbxNivel.SelectedItem = "Gerente" And chkEstado.Checked = True Then '<-- Especifica los valores del combobox que toman un valor numerico con la variable "cat" y tambien del checkbox del estado.
                    Cat = 1
                    estado = 1
                Else
                    Cat = 2
                    estado = 0
                End If

                Dim consultaAct As String = "update Empleados set NombEmple=@NombEmple, UsuarioEmple=@UsuarioEmple,Contraseña=@Contraseña ,NivelEmple=@NivelEmple, EstadoEmple=@EstadoEmple where CodEmple= @CodEmple" '<-Consulta.
                'Toma los valores de los textbox y el checkbox y los actualiza en la base de datos. 
                Dim ejecutar As New SqlCommand(consultaAct, conexion)
                ejecutar.Parameters.AddWithValue("@CodEmple", Val(TxtCodigoEmpleado.Text))
                ejecutar.Parameters.AddWithValue("@NombEmple", (txtNombreEmpleado.Text))
                ejecutar.Parameters.AddWithValue("@UsuarioEmple", (TxtUsuario.Text))
                ejecutar.Parameters.AddWithValue("@Contraseña", (TxtContraseña.Text))
                ejecutar.Parameters.AddWithValue("@NivelEmple", (Cat))
                ejecutar.Parameters.AddWithValue("@EstadoEmple", (estado))
                ejecutar.ExecuteNonQuery()
                MsgBox("El empleado se a actualizo", MsgBoxStyle.Information, "Informacion")
            End If
        End If
        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', UsuarioEmple as 'Usuario del empleado',Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", conexion)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DGV.DataSource = DatosEmp

        conexion.Close()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        abrir() '<-- Llamado de la funcion 
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Esta seguro que quiere eliminar este empleado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then

            If TxtCodigoEmpleado.Text = "" Then
                MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Dim consultaElim As String = "Update Empleados set EstadoEmple=0   where CodEmple= @CodEmple" '<-Consulta
                'Toma el valor del textbox y lo deshabilita en la base de datos.
                Dim ejecutar As New SqlCommand(consultaElim, conexion)
                ejecutar.Parameters.AddWithValue("@CodEmple", Val(TxtCodigoEmpleado.Text))

                ejecutar.ExecuteNonQuery()
                MsgBox("El empleado se a eliminado", MsgBoxStyle.Information, "Informacion")
            End If
        End If

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', UsuarioEmple as 'Usuario del empleado',Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", conexion)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
        conexion.Close()
        'Limpia los textbox, combobox y los checkbox.
        TxtCodigoEmpleado.Clear()
        txtNombreEmpleado.Clear()
        TxtUsuario.Clear()
        TxtContraseña.Clear()
        CbxNivel.SelectedIndex = -1
        chkEstado.Checked = False
        chkMostrarContra.Checked = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        abrir()
        'Dim busqueda As String
        'busqueda = InputBox("Ingrese Codigo", "Busqueda")

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Dim query As String = "select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where 'Nombre del empleado'=" & TxtBusqueda.Text
        Using adaptador As New SqlDataAdapter(query, conexion)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
        conexion.Close()
    End Sub

    'Funcion  que solo permite el ingreso de caracteres tipo letra
    Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        ' Lista con los caracteres que deseo permitir.
        '
        Dim caracteresPermitidos As String = "qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM " & Convert.ToChar(8)

        ' Carácter presionado.
        '
        Dim c As Char = e.KeyChar

        ' Si la tecla presionada no se encuentra en la matriz 
        ' de caracteres permitidos, anulamos la tecla pulsada.
        '
        If (Not (caracteresPermitidos.Contains(c))) Then

            MessageBox.Show("Ingrese solamente letras.", "ERROR de escritura",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ' Deshechamos el carácter
            e.Handled = True
        ElseIf Len(Me.txtNombreEmpleado.Text) = "0" Then
            If InStr(1, "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If

    End Sub


    Private Sub TxtCodigoEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodigoEmpleado.KeyPress
        SoloNumeros(e) '<-- Llamado de la funcion 
    End Sub

    Private Sub txtNombreEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreEmpleado.KeyPress
        SoloLetras(e) '<-- Llamado de la funcion 

    End Sub

    Private Sub cbxMostrarContra_CheckedChanged(sender As Object, e As EventArgs) Handles chkMostrarContra.CheckedChanged
        TxtContraseña.UseSystemPasswordChar = Not chkMostrarContra.Checked '<-Oculta contraseña

    End Sub

    Private Sub chkInhabil_CheckedChanged(sender As Object, e As EventArgs) Handles chkInhabil.CheckedChanged
        abrir()

        If chkInhabil.Checked = True Then

            Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', UsuarioEmple as 'Usuario del empleado',Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 0", conexion)
                adaptador.Fill(DatosEmp)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGV.DataSource = DatosEmp

        Else

            Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', UsuarioEmple as 'Usuario del empleado',Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", conexion)
                adaptador.Fill(DatosEmp)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGV.DataSource = DatosEmp

        End If
        conexion.Close()
    End Sub

    Private Sub DGV_DoubleClick_1(sender As Object, e As EventArgs) Handles DGV.DoubleClick '<-- Con doble clic manda campos del DataGridView a los textbox referidos.
        TxtCodigoEmpleado.Text = DGV.CurrentRow.Cells(0).Value
        txtNombreEmpleado.Text = DGV.CurrentRow.Cells(1).Value
        TxtUsuario.Text = DGV.CurrentRow.Cells(2).Value
        TxtContraseña.Text = DGV.CurrentRow.Cells(3).Value
        CbxNivel.Text = DGV.CurrentRow.Cells(4).Value

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click '<--Limpia los textbox, combobox y los checkbox.

        TxtCodigoEmpleado.Clear()
        txtNombreEmpleado.Clear()
        TxtUsuario.Clear()
        TxtContraseña.Clear()
        CbxNivel.SelectedIndex = -1
        chkEstado.Checked = False
        chkMostrarContra.Checked = False
    End Sub

    Private Sub txtNombreEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtNombreEmpleado.TextChanged
        LbContador.Text = txtNombreEmpleado.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        txtNombreEmpleado.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombreEmpleado.Text) '<-- Evita que se introduzca nombres y apellidos con inicial minisculas. 
        txtNombreEmpleado.SelectionStart = txtNombreEmpleado.Text.Length '<-- Evitar que texto ingresado se muestre al revez(o sea de derecha a la izquierda).
    End Sub

    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuario.TextChanged
        LbContador2.Text = TxtUsuario.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub TxtContraseña_TextChanged(sender As Object, e As EventArgs) Handles TxtContraseña.TextChanged
        LbContador4.Text = TxtContraseña.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub TxtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBusqueda.KeyPress
        SoloLetras(e) '<-- Llamado de la funcion 
    End Sub

    Public Sub filtrarDatos(ByVal buscar As String) '<-Funcion para filtrar datos que se mostraran en el DataGridView.
        If chkInhabil.Checked = False Then
            Try
                Using con As New SqlConnection("Data Source=localhost;Initial Catalog=BazarRoxana;Integrated Security=True")
                    Dim query = "select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', UsuarioEmple as 'Usuario del empleado',Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1 and NombEmple LIKE @filtro"

                    Dim adapter As New SqlDataAdapter(query, con)
                    adapter.SelectCommand.Parameters.AddWithValue("@filtro", String.Format("%{0}%", buscar))

                    Dim table As New DataTable
                    adapter.Fill(table)

                    DGV.DataSource = table
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                Using con As New SqlConnection("Data Source=localhost;Initial Catalog=BazarRoxana;Integrated Security=True")
                    Dim query = "select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', UsuarioEmple as 'Usuario del empleado',Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 0 and NombEmple LIKE @filtro"

                    Dim adapter As New SqlDataAdapter(query, con)
                    adapter.SelectCommand.Parameters.AddWithValue("@filtro", String.Format("%{0}%", buscar))

                    Dim table As New DataTable
                    adapter.Fill(table)

                    DGV.DataSource = table
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        LbContador6.Text = TxtBusqueda.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        Dim filtro As String = CType(sender, TextBox).Text
        If filtro.Trim() <> String.Empty Then  'Si no es vacío filtra
            filtrarDatos(filtro)
        Else
            abrir()

            If chkInhabil.Checked = True Then

                Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
                Using adaptador As New SqlDataAdapter("select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', UsuarioEmple as 'Usuario del empleado',Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 0", conexion)
                    adaptador.Fill(DatosEmp)
                End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

                DGV.DataSource = DatosEmp

            Else

                Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
                Using adaptador As New SqlDataAdapter("select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', UsuarioEmple as 'Usuario del empleado',Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", conexion)
                    adaptador.Fill(DatosEmp)
                End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

                DGV.DataSource = DatosEmp

            End If
            conexion.Close()
        End If
    End Sub

    Private Sub TxtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsuario.KeyPress '<--Funcion para validar que caracteres son permitidos y evitar que se introduscan espacio al principio. 
        If Len(Me.TxtUsuario.Text) = "0" Then
            If InStr(1, "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,°,!,#,$,%,&,/,(,),=,?,¡,*,¨,[,],_,:,;,.,-,{,},+,´,',¿" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub TxtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtContraseña.KeyPress '<--Funcion para validar que caracteres son permitidos y evitar que se introduscan espacio al principio. 
        If Len(Me.TxtContraseña.Text) = "0" Then
            If InStr(1, "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,°,!,#,$,%,&,/,(,),=,?,¡,*,¨,[,],_,:,;,.,-,{,},+,´,',¿" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub
End Class