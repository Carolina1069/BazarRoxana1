Imports System.Data.SqlClient
Public Class ViewBusCateg
    Private Sub ViewBusCateg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=CAROLINA10\CAROLINA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Categoria", conec)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat

    End Sub


    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs) Handles DGV.DoubleClick

        Productos.txCodCateg.Text = DGV.CurrentRow.Cells(0).Value
        Productos.rtxDescProd.Text = DGV.CurrentRow.Cells(1).Value

        Me.Close()

    End Sub
End Class