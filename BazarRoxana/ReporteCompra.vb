Public Class ReporteCompra
    Private Sub ReporteCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BazarRoxana.SelectCompras' Puede moverla o quitarla según sea necesario.
        Me.SelectComprasTableAdapter.Fill(Me.BazarRoxana.SelectCompras)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class