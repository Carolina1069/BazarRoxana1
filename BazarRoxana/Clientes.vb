Imports System.Data.SqlClient
Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Clientes", conec)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVCliente.DataSource = DatosCliente
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim ConsultaGuardar As String = "insert into Clientes(CodCli, NombCli, DirecCli,TelCli, CorreoCli, EstadoCli) values(@CodCli, @NombCli, @DirecCli,@TelCli, @CorreoCli,1)"
        Dim ejecutar As New SqlCommand(ConsultaGuardar, conec)
        ejecutar.Parameters.AddWithValue("@CodCli", Val(txCodCli.Text))
        ejecutar.Parameters.AddWithValue("@NombCli", (txNomCli.Text))
        ejecutar.Parameters.AddWithValue("@DirecCli", (rtxDirCli.Text))
        ejecutar.Parameters.AddWithValue("@TelCli", Val(txTelCli.Text))
        ejecutar.Parameters.AddWithValue("@CorreoCli", (txCorreoCli.Text))

        ejecutar.ExecuteNonQuery()
        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Clientes", conec)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVCliente.DataSource = DatosCliente
    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click, btActualizarTabla.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim ConsultaActualizar As String = "update Clientes set NombCli=@NombCli, DirecCli=@DirecCli,TelCli=@TelCli, CorreoCli=@CorreoCli where CodCli=@CodCli"
        Dim ejecutar As New SqlCommand(ConsultaActualizar, conec)
        ejecutar.Parameters.AddWithValue("@CodCli", Val(txCodCli.Text))
        ejecutar.Parameters.AddWithValue("@NombCli", (txNomCli.Text))
        ejecutar.Parameters.AddWithValue("@DirecCli", (rtxDirCli.Text))
        ejecutar.Parameters.AddWithValue("@TelCli", Val(txTelCli.Text))
        ejecutar.Parameters.AddWithValue("@CorreoCli", (txCorreoCli.Text))

        ejecutar.ExecuteNonQuery()
        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Clientes", conec)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVCliente.DataSource = DatosCliente
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim ConsultaEliminar As String = "delete from Clientes where CodCli=@CodCli"
        Dim ejecutar As New SqlCommand(ConsultaEliminar, conec)
        ejecutar.Parameters.AddWithValue("@CodCli", Val(txCodCli.Text))

        ejecutar.ExecuteNonQuery()
        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Clientes", conec)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVCliente.DataSource = DatosCliente
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim busqueda As Integer
        busqueda = InputBox("Ingrese Codigo", "Busqueda")

      

        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Dim query As String = "select * from Clientes where CodCli=" & busqueda
        Using adaptador As New SqlDataAdapter(query, conec)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVCliente.DataSource = DatosCliente
    End Sub

    Private Sub DGVCliente_DoubleClick(sender As Object, e As EventArgs) Handles DGVCliente.DoubleClick

        txCodCli.Text = DGVCliente.CurrentRow.Cells(0).Value
        txNomCli.Text = DGVCliente.CurrentRow.Cells(1).Value
        rtxDirCli.Text = DGVCliente.CurrentRow.Cells(2).Value
        txTelCli.Text = DGVCliente.CurrentRow.Cells(3).Value
        txCorreoCli.Text = DGVCliente.CurrentRow.Cells(4).Value

    End Sub
End Class
