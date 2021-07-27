Imports System.Data.SqlClient

Public Class Empleado
    Private Sub Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AbrirConeccion()

        Dim DatosEmpleados As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using Adaptador As New SqlDataAdapter("select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', case when NivelEmple=1 Then 'Administrador' when NivelEmple=2 Then 'Gerente' else 'Vendedor' end as 'Nivel del empleado', case 
        when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", ConexionBase)
            Adaptador.Fill(DatosEmpleados)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DgvEmpleados.DataSource = DatosEmpleados
        ConexionBase.Close()
        BtnHabilitar.Visible = False
        btnActualizar.Visible = False
        btnEliminar.Visible = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Categoria As Integer
        AbrirConeccion() '<-- Llamado de la funcion 
        If (txtNombreempleado.TextLength < 2) Then
            MessageBox.Show("Debe ingresar como minimo 2 caracteres en nombre del empleado")
        Else

            If txtNombreempleado.Text = "" Or DgvEmpleados.Rows.Count = 0 Then
                MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                If RegistradoEmpleados(TxtCodigoempleado.Text) = False Then '<-- Llamado de funcion que verifica si el codigo ya esta repetido en la base de datos.

                    If CbxNivel.SelectedItem = "Administrador" Then '<-- Especifica los valores del combobox que toman un valor numerico con la variable "cat".
                        Categoria = 1
                    ElseIf CbxNivel.SelectedItem = "Gerente" Then
                        Categoria = 2
                    Else
                        Categoria = 3
                    End If

                    Dim consultaGuardar As String = "insert into Empleados(NombEmple, NivelEmple,EstadoEmple) values(@NombEmple,@NivelEmple,1)" '<--Consulta
                    'Toma los valores de los textbox y el combobox y los guardas en la base de datos. 
                    Dim ejecutar As New SqlCommand(consultaGuardar, ConexionBase)
                    ejecutar.Parameters.AddWithValue("@NombEmple", (txtNombreempleado.Text))
                    ejecutar.Parameters.AddWithValue("@NivelEmple", (Categoria))

                    ejecutar.ExecuteNonQuery()
                    MsgBox("El empleado se a guardado", MsgBoxStyle.Information, "Informacion")
                Else
                    MsgBox("El Empleado ya esta registrado", MsgBoxStyle.Exclamation, "Advertencia")
                End If
            End If
        End If

        Dim DatosEmpleados As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', case when NivelEmple=1 Then 'Administrador' when NivelEmple=2 Then 'Gerente' else 'Vendedor' end as 'Nivel del empleado', case 
        when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", ConexionBase)
            adaptador.Fill(DatosEmpleados)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DgvEmpleados.DataSource = DatosEmpleados

        ConexionBase.Close()

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        AbrirConeccion()
        Try
            If (txtNombreempleado.TextLength < 2) Then
                MessageBox.Show("Debe ingresar como minimo 2 caracteres en nombre del empleado")

            Else

                If txtNombreempleado.Text = "" Or DgvEmpleados.Rows.Count = 0 Then
                    MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
                Else
                    Dim Categoria As Integer


                    If CbxNivel.SelectedItem = "Administrador" Then '<-- Especifica los valores del combobox que toman un valor numerico con la variable "cat" 
                        Categoria = 1

                    ElseIf CbxNivel.SelectedItem = "Gerente" Then
                        Categoria = 2
                    Else
                        Categoria = 3
                    End If


                    Dim consultaAct As String = "update Empleados set NombEmple=@NombEmple, NivelEmple=@NivelEmple, EstadoEmple=1 where CodEmple= @CodEmple" '<-Consulta.
                    'Toma los valores de los textbox y el checkbox y los actualiza en la base de datos. 
                    Dim ejecutar As New SqlCommand(consultaAct, ConexionBase)
                    ejecutar.Parameters.AddWithValue("@CodEmple", Val(TxtCodigoempleado.Text))
                    ejecutar.Parameters.AddWithValue("@NombEmple", (txtNombreempleado.Text))
                    ejecutar.Parameters.AddWithValue("@NivelEmple", (Categoria))
                    ejecutar.ExecuteNonQuery()
                    Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
                    Using adaptador As New SqlDataAdapter("select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', case when NivelEmple=1 Then 'Administrador' when NivelEmple=2 Then 'Gerente' else 'Vendedor' end as 'Nivel del empleado', case 
                    when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", ConexionBase)
                        adaptador.Fill(DatosEmp)
                    End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
                    DgvEmpleados.DataSource = DatosEmp

                    ConexionBase.Close()

                    MsgBox("El empleado se a actualizo", MsgBoxStyle.Information, "Informacion")
                    chkInhabil.Checked = False
                    btnGuardar.Visible = False
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        btnActualizar.Visible = False
        End Try
        btnEliminar.Visible = True

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        AbrirConeccion() '<-- Llamado de la funcion 
        If TxtCodigoempleado.Text = String.Empty Then
            MsgBox("Por favor haga doble click a una fila de la tabla antes de eliminar algún dato deseado.", MsgBoxStyle.Exclamation, "Advertencia")
        Else

            Dim opcion As DialogResult
            opcion = MessageBox.Show("¿Esta seguro que quiere eliminar este empleado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If opcion = DialogResult.Yes Then

                If TxtCodigoempleado.Text = "" Then
                    MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
                Else
                    Dim consultaElim As String = "Update Empleados set EstadoEmple=0   where CodEmple= @CodEmple" '<-Consulta
                    'Toma el valor del textbox y lo deshabilita en la base de datos.
                    Dim ejecutar As New SqlCommand(consultaElim, ConexionBase)
                    ejecutar.Parameters.AddWithValue("@CodEmple", Val(TxtCodigoempleado.Text))

                    ejecutar.ExecuteNonQuery()
                    MsgBox("El empleado se a eliminado", MsgBoxStyle.Information, "Informacion")

                End If
            End If
            btnEliminar.Visible = False
            btnActualizar.Visible = False
        End If
        Dim DatosEmpleados As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using Adaptador As New SqlDataAdapter("select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', case when NivelEmple=1 Then 'Administrador' when NivelEmple=2 Then 'Gerente' else 'Vendedor' end as 'Nivel del empleado', case 
        when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", ConexionBase)
            Adaptador.Fill(DatosEmpleados)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DgvEmpleados.DataSource = DatosEmpleados
        ConexionBase.Close()
        'Limpia los textbox, combobox y los checkbox.
        CbxNivel.SelectedIndex = -1
        TxtCodigoempleado.Clear()
        txtNombreempleado.Clear()


    End Sub


    'Funcion  que solo permite el ingreso de caracteres tipo letra
    Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        ' Lista con los caracteres que deseo permitir.
        '
        Dim CaracteresPermitidos As String = "qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM " & Convert.ToChar(8)

        ' Carácter presionado.
        '
        Dim c As Char = e.KeyChar

        ' Si la tecla presionada no se encuentra en la matriz 
        ' de caracteres permitidos, anulamos la tecla pulsada.
        '
        If (Not (CaracteresPermitidos.Contains(c))) Then

            MessageBox.Show("Ingrese solamente letras.", "ERROR de escritura",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ' Deshechamos el carácter
            e.Handled = True
        ElseIf Len(Me.txtNombreempleado.Text) = "0" Then
            If InStr(1, "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If

    End Sub


    Private Sub TxtCodigoEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodigoempleado.KeyPress
        SoloNumeros(e) '<-- Llamado de la funcion 
    End Sub

    Private Sub txtNombreEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreempleado.KeyPress
        SoloLetras(e) '<-- Llamado de la funcion 

    End Sub


    Private Sub chkInhabil_CheckedChanged(sender As Object, e As EventArgs) Handles chkInhabil.CheckedChanged
        AbrirConeccion()

        If chkInhabil.Checked = True Then

            Dim DatosEmpleados As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using Adaptador As New SqlDataAdapter("select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', case when NivelEmple=1 Then 'Administrador' when NivelEmple=2 Then 'Gerente' else 'Vendedor' end as 'Nivel del empleado', case 
        when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 0", ConexionBase)
                Adaptador.Fill(DatosEmpleados)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DgvEmpleados.DataSource = DatosEmpleados
            btnGuardar.Visible = False
            btnActualizar.Visible = False
            btnEliminar.Visible = False
            BtnHabilitar.Visible = True
        Else

            Dim DatosEmpleados As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using Adaptador As New SqlDataAdapter("select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', case when NivelEmple=1 Then 'Administrador' when NivelEmple=2 Then 'Gerente' else 'Vendedor' end as 'Nivel del empleado', case 
        when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", ConexionBase)
                Adaptador.Fill(DatosEmpleados)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DgvEmpleados.DataSource = DatosEmpleados
            btnGuardar.Visible = True
            btnActualizar.Visible = False
            btnEliminar.Visible = False
            BtnHabilitar.Visible = False
        End If
        ConexionBase.Close()
    End Sub

    Private Sub DGV_DoubleClick_1(sender As Object, e As EventArgs) Handles DgvEmpleados.DoubleClick '<-- Con doble clic manda campos del DataGridView a los textbox referidos.
        TxtCodigoempleado.Text = DgvEmpleados.CurrentRow.Cells(0).Value
        txtNombreempleado.Text = DgvEmpleados.CurrentRow.Cells(1).Value
        CbxNivel.Text = DgvEmpleados.CurrentRow.Cells(2).Value
        If chkInhabil.Checked = True Then
            btnEliminar.Visible = False
            btnActualizar.Visible = False
            btnGuardar.Visible = False
        Else
            btnEliminar.Visible = True
            btnActualizar.Visible = True
            btnGuardar.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click '<--Limpia los textbox, combobox y los checkbox.

        TxtCodigoempleado.Clear()
        txtNombreempleado.Clear()
        CbxNivel.SelectedIndex = -1
        btnActualizar.Visible = False
        btnEliminar.Visible = False
        btnGuardar.Visible = True

    End Sub

    Private Sub txtNombreEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtNombreempleado.TextChanged
        LbContador.Text = txtNombreempleado.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        txtNombreempleado.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombreempleado.Text) '<-- Evita que se introduzca nombres y apellidos con inicial minisculas. 
        txtNombreempleado.SelectionStart = txtNombreempleado.Text.Length '<-- Evitar que texto ingresado se muestre al revez(o sea de derecha a la izquierda).
    End Sub

    Private Sub TxtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBusqueda.KeyPress
        SoloLetras(e) '<-- Llamado de la funcion 
    End Sub

    Public Sub FiltrarDatos(ByVal Buscar As String) '<-Funcion para filtrar datos que se mostraran en el DataGridView.
        If chkInhabil.Checked = False Then
            Try
                Using Con As New SqlConnection("Data Source=localhost;Initial Catalog=BazarRoxana;Integrated Security=True")
                    Dim Query = "select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', case when NivelEmple=1 Then 'Administrador' when NivelEmple=2 Then 'Gerente' else 'Vendedor' end as 'Nivel del empleado', case 
        when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1 and NombEmple LIKE @filtro"

                    Dim Adapter As New SqlDataAdapter(Query, Con)
                    Adapter.SelectCommand.Parameters.AddWithValue("@filtro", String.Format("%{0}%", Buscar))

                    Dim Table As New DataTable
                    Adapter.Fill(Table)

                    DgvEmpleados.DataSource = Table
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                Using Con As New SqlConnection("Data Source=localhost;Initial Catalog=BazarRoxana;Integrated Security=True")
                    Dim Query = "select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', case when NivelEmple=1 Then 'Administrador' when NivelEmple=2 Then 'Gerente' else 'Vendedor' end as 'Nivel del empleado', case 
        when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 0 and NombEmple LIKE @filtro"

                    Dim Adapter As New SqlDataAdapter(Query, Con)
                    Adapter.SelectCommand.Parameters.AddWithValue("@filtro", String.Format("%{0}%", Buscar))

                    Dim Table As New DataTable
                    Adapter.Fill(Table)

                    DgvEmpleados.DataSource = Table
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Private Sub TxtBusqueda_TextChanged(Sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        LbContador6.Text = TxtBusqueda.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        Dim Filtro As String = CType(Sender, TextBox).Text
        If Filtro.Trim() <> String.Empty Then  'Si no es vacío filtra
            FiltrarDatos(Filtro)
        Else
            AbrirConeccion()

            If chkInhabil.Checked = True Then

                Dim DatosEmpleados As New DataTable 'tabla temporal que recoge los datos de la consulta
                Using Adaptador As New SqlDataAdapter("select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', case when NivelEmple=1 Then 'Administrador' when NivelEmple=2 Then 'Gerente' else 'Vendedor' end as 'Nivel del empleado', case 
                                                       when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 0", ConexionBase)
                    Adaptador.Fill(DatosEmpleados)
                End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

                DgvEmpleados.DataSource = DatosEmpleados

            Else

                Dim DatosEmpleados As New DataTable 'tabla temporal que recoge los datos de la consulta
                Using Adaptador As New SqlDataAdapter("select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', case when NivelEmple=1 Then 'Administrador' when NivelEmple=2 Then 'Gerente' else 'Vendedor' end as 'Nivel del empleado', case 
                                                       when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", ConexionBase)
                    Adaptador.Fill(DatosEmpleados)
                End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

                DgvEmpleados.DataSource = DatosEmpleados

            End If
            ConexionBase.Close()
        End If
    End Sub

    Private Sub BtnHabilitar_Click(sender As Object, e As EventArgs) Handles BtnHabilitar.Click
        AbrirConeccion()
        Dim OpcionDia As DialogResult
        OpcionDia = MessageBox.Show("¿Está seguro que quiere habilitar este empleado?", "Habilitar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If OpcionDia = DialogResult.Yes Then
            If TxtCodigoempleado.Text = "" Then
                MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Dim ConsultaHabilitar As String = "Update Empleados set EstadoEmple=1  where CodEmple=@CodEmple"
                'Toma el valor del textbox y lo habilita en la base de datos. 
                Dim EjecutarCon As New SqlCommand(ConsultaHabilitar, ConexionBase)
                EjecutarCon.Parameters.AddWithValue("@CodEmple", Val(TxtCodigoempleado.Text))
                EjecutarCon.ExecuteNonQuery()
                'Limpia los textbox, el rich y el checkbox
                TxtCodigoempleado.Clear()
                txtNombreempleado.Clear()
                chkInhabil.Checked = False
                CbxNivel.SelectedIndex = -1
            End If
        End If
        CbxNivel.SelectedIndex = -1
        chkInhabil.Checked = False
        btnEliminar.Visible = False
        btnActualizar.Visible = False
        ConexionBase.Close()
    End Sub
End Class