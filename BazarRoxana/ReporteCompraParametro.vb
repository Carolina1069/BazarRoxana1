Public Class ReporteCompraParametro


    Private Sub BtnBuscar_Click_1(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.SelectCompraFechaTableAdapter.Fill(Me.BazarRoxana.SelectCompraFecha, DtpPrimerFecha.Value.ToString("yyyy/MM/dd"), DtpSegundaFecha.Value.ToString("yyyy/MM/dd"))
    End Sub


End Class