Public Class ReporteVenta
    Private Sub ReporteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BazarRoxana.SelectTodaslasVentas' Puede moverla o quitarla según sea necesario.
        Me.SelectTodaslasVentasTableAdapter.Fill(Me.BazarRoxana.SelectTodaslasVentas)

        Me.ReportViewer1.RefreshReport
    End Sub
End Class