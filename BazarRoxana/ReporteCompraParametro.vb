﻿Public Class ReporteCompraParametro
    Private Sub ReporteCompraParametro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BazarRoxana.SelectCompraFecha' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        'TODO: esta línea de código carga datos en la tabla 'BazarRoxana.SelectCompraFecha' Puede moverla o quitarla según sea necesario.
        Me.SelectCompraFechaTableAdapter.Fill(Me.BazarRoxana.SelectCompraFecha, TxtFecha1.Text, TxtFecha2.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class