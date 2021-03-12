Imports System.Data.SqlClient
Public Class Proveedores
    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Proveedores", conec)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosCliente
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim busqueda As Integer
        busqueda = InputBox("Ingrese Codigo", "Busqueda")



        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Dim query As String = "select * from Proveedores where CodProv=" & busqueda
        Using adaptador As New SqlDataAdapter(query, conec)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosCliente
    End Sub

    Private Sub btActualizarTabla_Click(sender As Object, e As EventArgs) Handles btActualizarTabla.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Proveedores", conec)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosCliente
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim ConsultaGuardar As String = "insert into Proveedores(CodProv, NombProv,TelProv, NombContProv,CorreoProv, CorreoContProv, TelContProv, DirecProv,EstadoProv) 
        values(@CodProv, @NombProv, @TelProv, @NombContProv, @CorreoProv, @CorreoContProv, @TelContProv, @DirecProv,1)"
        Dim ejecutar As New SqlCommand(ConsultaGuardar, conec)
        ejecutar.Parameters.AddWithValue("@CodProv", Val(txCodProve.Text))
        ejecutar.Parameters.AddWithValue("@NombProv", (txNomProv.Text))
        ejecutar.Parameters.AddWithValue("@TelProv", Val(TxtTelfonoEmpresa.Text))
        ejecutar.Parameters.AddWithValue("@NombContProv", (txtNombrePreEm.Text))
        ejecutar.Parameters.AddWithValue("@CorreoProv", (txCorreoEmpresa.Text))
        ejecutar.Parameters.AddWithValue("@CorreoContProv", (TxtCorreoProv.Text))
        ejecutar.Parameters.AddWithValue("@TelContProv", Val(txtTelProv.Text))
        ejecutar.Parameters.AddWithValue("@DirecProv", (RTBDirec.Text))

        ejecutar.ExecuteNonQuery()
        Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Proveedores", conec)
            adaptador.Fill(DatosProveedor)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosProveedor
    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim ConsultaActualizar As String = "update Proveedores set NombProv=@NombProv,TelProv=@TelProv, NombContProv=@NombContProv, CorreoProv=@CorreoProv, CorreoContProv=@CorreoContProv, TelContProv=@TelContProv, DirecProv=@DirecProv where CodProv=@CodProv"
        Dim ejecutar As New SqlCommand(ConsultaActualizar, conec)
        ejecutar.Parameters.AddWithValue("@CodProv", Val(txCodProve.Text))
        ejecutar.Parameters.AddWithValue("@NombProv", (txNomProv.Text))
        ejecutar.Parameters.AddWithValue("@TelProv", Val(TxtTelfonoEmpresa.Text))
        ejecutar.Parameters.AddWithValue("@NombContProv", (txtNombrePreEm.Text))
        ejecutar.Parameters.AddWithValue("@CorreoProv", (txCorreoEmpresa.Text))
        ejecutar.Parameters.AddWithValue("@CorreoContProv", (TxtCorreoProv.Text))
        ejecutar.Parameters.AddWithValue("@TelContProv", Val(txtTelProv.Text))
        ejecutar.Parameters.AddWithValue("@DirecProv", (RTBDirec.Text))

        ejecutar.ExecuteNonQuery()
        Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Proveedores", conec)
            adaptador.Fill(DatosProveedor)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosProveedor
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim ConsultaEliminar As String = "delete from Proveedores where CodProv=@CodProv"
        Dim ejecutar As New SqlCommand(ConsultaEliminar, conec)
        ejecutar.Parameters.AddWithValue("@CodProv", Val(txCodProve.Text))

        ejecutar.ExecuteNonQuery()
        Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Proveedores", conec)
            adaptador.Fill(DatosProveedor)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosProveedor
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub DGVProveedores_DoubleClick(sender As Object, e As EventArgs) Handles DGVProveedores.DoubleClick
        txCodProve.Text = DGVProveedores.CurrentRow.Cells(0).Value
        txNomProv.Text = DGVProveedores.CurrentRow.Cells(1).Value
        TxtTelfonoEmpresa.Text = DGVProveedores.CurrentRow.Cells(2).Value
        txtNombrePreEm.Text = DGVProveedores.CurrentRow.Cells(3).Value
        txCorreoEmpresa.Text = DGVProveedores.CurrentRow.Cells(4).Value
        TxtCorreoProv.Text = DGVProveedores.CurrentRow.Cells(5).Value
        txtTelProv.Text = DGVProveedores.CurrentRow.Cells(6).Value
        RTBDirec.Text = DGVProveedores.CurrentRow.Cells(7).Value


    End Sub
End Class