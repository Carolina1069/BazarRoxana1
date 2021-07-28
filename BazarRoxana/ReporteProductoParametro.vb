Imports System.Data.SqlClient
Public Class ReporteProductoParametro

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.SelectProductoParametroTableAdapter.Fill(Me.BazarRoxana.SelectProductoParametro, CbxBusqueda.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReporteProductoParametro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()

        Dim DATOSusuarios As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select NombCateg from Categoria ", ConexionBase)
            adaptador.Fill(DATOSusuarios)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        CbxBusqueda.DataSource = DATOSusuarios
        CbxBusqueda.DisplayMember = "NombCateg"

        ConexionBase.Close()
    End Sub
End Class