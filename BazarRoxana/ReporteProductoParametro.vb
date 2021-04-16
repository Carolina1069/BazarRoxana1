Public Class ReporteProductoParametro
    Private Sub ReporteProductoParametro_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.SelectProductoParametroTableAdapter.Fill(Me.BazarRoxana.SelectProductoParametro, TxtBusqueda.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class