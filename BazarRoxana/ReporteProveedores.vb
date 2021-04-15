Public Class ReporteProveedores
    Private Sub ReporteProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BazarRoxana.SelectProveedor' Puede moverla o quitarla según sea necesario.
        Me.SelectProveedorTableAdapter.Fill(Me.BazarRoxana.SelectProveedor)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class