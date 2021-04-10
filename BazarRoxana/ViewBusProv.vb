Imports System.Data.SqlClient
Public Class ViewBusProv
    Private Sub ViewBusProv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=CAROLINA10\CAROLINA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Proveedores where EstadoProv=1", conec)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosCliente

    End Sub

    Private Sub DGVProveedores_DoubleClick(sender As Object, e As EventArgs) Handles DGVProveedores.DoubleClick

        Productos.txCodProv.Text = DGVProveedores.CurrentRow.Cells(0).Value

        Me.Close()


    End Sub
End Class