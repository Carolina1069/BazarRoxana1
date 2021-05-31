Public Class FacturaVenta
    Private Sub FacturaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim factura As String
        factura = Val(Ventas.txNumVenta.Text)
        'TODO: esta línea de código carga datos en la tabla 'BazarRoxana.SelectFactura' Puede moverla o quitarla según sea necesario.
        Me.SelectFacturaTableAdapter.Fill(Me.BazarRoxana.SelectFactura, factura)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class