Imports System.Data.SqlClient
Public Class Minimo
    Private Sub Minimo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConeccion()
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProduc as 'Codigo del Producto', NombProduc as 'Nombre del Producto', PrimerPrecio as 'Precio #1', SegundoPrecio as 'Precio #2', TercerPrecio as 'Precio #3', UnidadesStock 'Unidades en Stock', Minimo as 'Unidades Minimas' from Producto where UnidadesStock <= Minimo", ConexionBase)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat

        ConexionBase.Close()
    End Sub
End Class