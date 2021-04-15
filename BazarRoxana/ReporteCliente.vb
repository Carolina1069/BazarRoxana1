Public Class ReporteCliente
    Private Sub ReporteCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BazarRoxana.SelectCliente' Puede moverla o quitarla según sea necesario.
        Me.SelectClienteTableAdapter.Fill(Me.BazarRoxana.SelectCliente)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class