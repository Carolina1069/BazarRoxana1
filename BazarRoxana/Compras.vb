Public Class Compras
    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
        Login.Show()

    End Sub
End Class