Public Class FrmBusquedaProveedor
    Dim dt As New DataTable()
    Private Sub FrmBusquedaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Public Sub mostrar()
        Try
            dt = ConexionLogin.mostrarProveedor

            If dt.Rows.Count <> 0 Then
                dgvprov.DataSource = dt

                dgvprov.ColumnHeadersVisible = True


            Else
                dgvprov.DataSource = Nothing

                dgvprov.ColumnHeadersVisible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub buscar()
        Dim dt As New DataTable()
        Dim producto As String

        Try
            producto = txtBuscarProv.Text
            dt = ConexionLogin.buscarProduct(producto)

            If dt.Rows.Count <> 0 Then
                dgvprov.DataSource = dt
                ConexionLogin.conexion.Close()

            Else
                dgvprov.DataSource = Nothing
                ConexionLogin.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub txtBuscarProv_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProv.TextChanged
        buscar()
    End Sub

    Private Sub dgvprov_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprov.CellContentClick

    End Sub

    Private Sub dgvprov_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprov.CellDoubleClick

        Productos.txCodCateg.Text = dgvprov.SelectedCells.Item(0).Value
            Productos.txNombCateg.Text = dgvprov.SelectedCells.Item(1).Value
            Me.Close()

    End Sub
End Class