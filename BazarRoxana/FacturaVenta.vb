Public Class FacturaVenta
    Private Sub FacturaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim factura As Integer
        factura = 2
        'TODO: esta línea de código carga datos en la tabla 'BazarRoxana.SelectFactura' Puede moverla o quitarla según sea necesario.
        Me.SelectFacturaTableAdapter.Fill(Me.BazarRoxana.SelectFactura, Ventas.txNumVenta.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class