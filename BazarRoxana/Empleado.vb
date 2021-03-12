Imports System.Data.SqlClient

Public Class Empleado
    Private Sub Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=DANIELRUEDA\LOCALHOST;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Empleados", conec)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=DANIELRUEDA\LOCALHOST;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim consultaGuardar As String = "insert into Empleados(CodEmple, NombEmple, NivelEmple,EstadoEmple) values(@CodEmple, @NombEmple,@NivelEmple,1)"
        Dim ejecutar As New SqlCommand(consultaGuardar, conec)
        ejecutar.Parameters.AddWithValue("@CodEmple", Val(TxtCodigoEmpleado.Text))
        ejecutar.Parameters.AddWithValue("@NombEmple", (txtNombreEmpleado.Text))
        ejecutar.Parameters.AddWithValue("@NivelEmple", (CbxNivel.SelectedItem))


        ejecutar.ExecuteNonQuery()
        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Empleados", conec)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=DANIELRUEDA\LOCALHOST;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim consultaAct As String = "update Empleados set NombEmple=@NombEmple, NivelEmple=@NivelEmple where CodEmple= @CodEmple"
        Dim ejecutar As New SqlCommand(consultaAct, conec)
        ejecutar.Parameters.AddWithValue("@CodEmple", Val(TxtCodigoEmpleado.Text))
        ejecutar.Parameters.AddWithValue("@NombEmple", (txtNombreEmpleado.Text))
        ejecutar.Parameters.AddWithValue("@NivelEmple", (CbxNivel.SelectedItem))


        ejecutar.ExecuteNonQuery()
        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Empleados", conec)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=DANIELRUEDA\LOCALHOST;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim consultaElim As String = "delete from Empleados  where CodEmple= @CodEmple"
        Dim ejecutar As New SqlCommand(consultaElim, conec)
        ejecutar.Parameters.AddWithValue("@CodEmple", Val(TxtCodigoEmpleado.Text))

        ejecutar.ExecuteNonQuery()
        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Empleados", conec)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=DANIELRUEDA\LOCALHOST;Initial Catalog=BazarRoxana;Integrated Security=True"
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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs) Handles DGV.DoubleClick
        TxtCodigoEmpleado.Text = DGV.CurrentRow.Cells(0).Value
        txtNombreEmpleado.Text = DGV.CurrentRow.Cells(1).Value
        CbxNivel.SelectedItem = DGV.CurrentRow.Cells(2).Value
    End Sub

    Private Sub btnActTabla_Click(sender As Object, e As EventArgs) Handles btnActTabla.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=DANIELRUEDA\LOCALHOST;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Empleados", conec)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
    End Sub
End Class