Public Class Ventas
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblHora.Text = DateTime.Now.ToString("hh:mm:ss:tt")
        LblFecha.Text = DateTime.Now.ToLongDateString()
    End Sub
End Class