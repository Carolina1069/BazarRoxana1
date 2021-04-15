Public Class FacturaVentas
    Private Sub FacturaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BazarRoxana.SelectDetalleVenta' Puede moverla o quitarla según sea necesario.
        Me.SelectDetalleVentaTableAdapter.Fill(Me.BazarRoxana.SelectDetalleVenta, Ventas.txNumVenta.Text)
        'TODO: esta línea de código carga datos en la tabla 'BazarRoxana.SelectVenta' Puede moverla o quitarla según sea necesario.
        Me.SelectVentaTableAdapter.Fill(Me.BazarRoxana.SelectVenta, Ventas.txNumVenta.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class