﻿Public Class ReporteVentaParametro

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.SelectVentaFechaTableAdapter.Fill(Me.BazarRoxana.SelectVentaFecha, DtpPrimerFecha.Value.ToString("yyyy/MM/dd"), DtpSegundaFecha.Value.ToString("yyyy/MM/dd"))

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class