Public Class FrmBusquedaCategoria
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub buscar()
        Dim dt As New DataTable()
        Dim producto As String

        Try
            producto = txtBuscarCateg.Text
            dt = ConexionLogin.buscarProduct(producto)

            If dt.Rows.Count <> 0 Then
                dgvcategoria.DataSource = dt
                ConexionLogin.conexion.Close()

            Else
                dgvcategoria.DataSource = Nothing
                ConexionLogin.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Private Sub txtBuscarCateg_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCateg.TextChanged
        buscar()
    End Sub

    Private Sub dgvcategoria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcategoria.CellContentClick

    End Sub
End Class