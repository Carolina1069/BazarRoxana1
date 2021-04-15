Public Class ReporteVenta
    Private Sub ReporteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BazarRoxana.SelectVenta' Puede moverla o quitarla según sea necesario.
        Me.SelectVentasTableAdapter.Fill(Me.BazarRoxana.SelectVentas)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class