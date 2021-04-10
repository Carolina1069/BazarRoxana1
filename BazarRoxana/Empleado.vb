Imports System.Data.SqlClient

Public Class Empleado
    Private Sub Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=CAROLINA10\CAROLINA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()
        'CAROLINA10\CAROLINA
        'AMAYA
        'DANIELRUEDA\LOCALHOST


        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodEmple as 'Codigo del empleado', NombEmple as 'Nombre del empleado', Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", conec)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=CAROLINA10\CAROLINA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()


        If TxtCodigoEmpleado.Text = "" Or txtNombreEmpleado.Text = "" Or TxtContraseña.Text = "" Or CbxNivel.SelectedItem = 0 Or chkEstado.Checked = False Or DGV.Rows.Count = 0 Then
            MsgBox("Hay campos vacios")
        Else

            Dim Cat As Integer


            If CbxNivel.SelectedItem = "Gerente" Then
                Cat = 1

            Else
                Cat = 2

            End If

            Dim consultaGuardar As String = "insert into Empleados(CodEmple, NombEmple, Contraseña,NivelEmple,EstadoEmple) values(@CodEmple, @NombEmple,@Contraseña,@NivelEmple,1)"
            Dim ejecutar As New SqlCommand(consultaGuardar, conec)
            ejecutar.Parameters.AddWithValue("@CodEmple", Val(TxtCodigoEmpleado.Text))
            ejecutar.Parameters.AddWithValue("@NombEmple", (txtNombreEmpleado.Text))
            ejecutar.Parameters.AddWithValue("@Contraseña", (TxtContraseña.Text))
            ejecutar.Parameters.AddWithValue("@NivelEmple", (Cat))


            ejecutar.ExecuteNonQuery()

        End If

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Empleados where EstadoEmple=1", conec)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=CAROLINA10\CAROLINA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        If TxtCodigoEmpleado.Text = "" Or txtNombreEmpleado.Text = "" Or TxtContraseña.Text = "" Or CbxNivel.SelectedItem = 0 Or DGV.Rows.Count = 0 Then
            MsgBox("Hay campos vacios")
        Else
            Dim Cat As Integer
            Dim estado As Integer

            If CbxNivel.SelectedItem = "Gerente" And chkEstado.Checked = True Then
                Cat = 1
                estado = 1
            Else
                Cat = 2
                estado = 0
            End If

            Dim consultaAct As String = "update Empleados set NombEmple=@NombEmple, NivelEmple=@NivelEmple EstadoEmple=@EstadoEmple where CodEmple= @CodEmple"
            Dim ejecutar As New SqlCommand(consultaAct, conec)
            ejecutar.Parameters.AddWithValue("@CodEmple", Val(TxtCodigoEmpleado.Text))
            ejecutar.Parameters.AddWithValue("@NombEmple", (txtNombreEmpleado.Text))
            ejecutar.Parameters.AddWithValue("@NivelEmple", (Cat))
            ejecutar.Parameters.AddWithValue("@EstadoEmple", (estado))
            ejecutar.ExecuteNonQuery()

        End If

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Empleados where EstadoEmple=1", conec)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DGV.DataSource = DatosEmp

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=CAROLINA10\CAROLINA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        If TxtCodigoEmpleado.Text = "" Then
            MsgBox("Hay campos vacios")
        Else
            Dim consultaElim As String = "Update Empleados set EstadoEmple=0   where CodEmple= @CodEmple"
            Dim ejecutar As New SqlCommand(consultaElim, conec)
            ejecutar.Parameters.AddWithValue("@CodEmple", Val(TxtCodigoEmpleado.Text))

            ejecutar.ExecuteNonQuery()
        End If


        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Empleados where EstadoEmple=1", conec)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=CAROLINA10\CAROLINA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim busqueda As Integer
        busqueda = InputBox("Ingrese Codigo", "Busqueda")

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Dim query As String = "select * from Empleados where CodEmple=" & busqueda
        Using adaptador As New SqlDataAdapter(query, conec)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) 
        Me.Close()
        Login.Show()
    End Sub


    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs) Handles DGV.DoubleClick
        TxtCodigoEmpleado.Text = DGV.CurrentRow.Cells(0).Value
        txtNombreEmpleado.Text = DGV.CurrentRow.Cells(1).Value
        CbxNivel.SelectedItem = DGV.CurrentRow.Cells(2).Value
    End Sub

    Private Sub btnActTabla_Click(sender As Object, e As EventArgs) Handles btnActTabla.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=CAROLINA10\CAROLINA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Empleados", conec)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
    End Sub


    'Funcion  que solo permite el ingreso de caracteres tipo letra
    Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    'Funcion  que solo permite el ingreso de caracteres tipo numerico
    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub
    Private Sub TxtCodigoEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodigoEmpleado.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtNombreEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreEmpleado.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub cbxMostrarContra_CheckedChanged(sender As Object, e As EventArgs) Handles cbxMostrarContra.CheckedChanged
        TxtContraseña.UseSystemPasswordChar = Not cbxMostrarContra.Checked

    End Sub

    Private Sub chkInhabil_CheckedChanged(sender As Object, e As EventArgs) Handles chkInhabil.CheckedChanged

        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=CAROLINA10\CAROLINA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        If chkInhabil.Checked = True Then

            Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("select * from Empleados where EstadoEmple=0", conec)
                adaptador.Fill(DatosEmp)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGV.DataSource = DatosEmp

        Else

            Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("select * from Empleados where EstadoEmple=1", conec)
                adaptador.Fill(DatosEmp)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGV.DataSource = DatosEmp

        End If

    End Sub
End Class