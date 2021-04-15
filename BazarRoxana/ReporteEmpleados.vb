Public Class ReporteEmpleados
    Private Sub ReporteEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BazarRoxana.SelectEmpleado' Puede moverla o quitarla según sea necesario.
        Me.SelectEmpleadoTableAdapter.Fill(Me.BazarRoxana.SelectEmpleado)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class