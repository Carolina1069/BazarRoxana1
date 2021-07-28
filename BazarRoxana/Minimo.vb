Imports System.Data.SqlClient
Public Class Minimo
    Private Sub Minimo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        Dim DatosMinimo As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using Adaptador As New SqlDataAdapter("select CodProduc as 'Código del producto', NombProduc as 'Nombre del producto',DescripProduc as 'Artículo',Descripcion as 'Descripción', PrimerPrecio as 'Precio #1', SegundoPrecio as 'Precio #2', TercerPrecio as 'Precio #3', UnidadesStock 'Unidades en stock', Minimo as 'Unidades minimas' from Producto where UnidadesStock <= Minimo", ConexionBase)
            Adaptador.Fill(DatosMinimo)
        End Using 'intermediario eDatosCatntre la base de datos y DATOSusuario para poder ingresar a datatable

        DgvMinimo.DataSource = DatosMinimo

        ConexionBase.Close()
    End Sub
End Class