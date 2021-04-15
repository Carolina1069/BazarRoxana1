Public Class ReporteMasVendido
    Private Sub ReporteMasVendido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BazarRoxana.SelectMasVendido' Puede moverla o quitarla según sea necesario.
        Me.SelectMasVendidoTableAdapter.Fill(Me.BazarRoxana.SelectMasVendido)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class