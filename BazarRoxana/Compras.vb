Public Class Compras
    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
        Login.Show()

    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblHora.Text = DateTime.Now.ToString("hh:mm:ss:tt")
        LblFecha.Text = DateTime.Now.ToLongDateString()
    End Sub
End Class