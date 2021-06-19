Public Class FacturaVenta

    Private Sub FacturaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()

        Dim CodUVenta As String = CodUltimaVenta()
        Dim Uventa As String
        Uventa = CodUVenta - 1


        'TODO: esta línea de código carga datos en la tabla 'BazarRoxana.SelectVentaEncabezado' Puede moverla o quitarla según sea necesario.
        Me.SelectVentaEncabezadoTableAdapter.Fill(Me.BazarRoxana.SelectVentaEncabezado)
        'TODO: esta línea de código carga datos en la tabla 'BazarRoxana.SelectDetalleVenta' Puede moverla o quitarla según sea necesario.
        Me.SelectDetalleVentaTableAdapter.Fill(Me.BazarRoxana.SelectDetalleVenta, Uventa)


        Me.ReportViewer1.RefreshReport()

        conexion.Close()
    End Sub
End Class