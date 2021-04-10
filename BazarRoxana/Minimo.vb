Imports System.Data.SqlClient
Public Class Minimo
    Private Sub Minimo_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=CAROLINA10\CAROLINA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()



        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Producto where UnidadesStock <= Minimo", conec)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat


    End Sub
End Class