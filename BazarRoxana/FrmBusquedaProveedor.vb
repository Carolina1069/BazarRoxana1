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
        Dim Proveedores As String

        Try
            Proveedores = txtBuscarProv.Text
            dt = ConexionLogin.buscarProveedorH(Proveedores)

            If dt.Rows.Count <> 0 Then
                dgvprov.DataSource = dt
                ConexionLogin.ConexionBase.Close()

            Else
                dgvprov.DataSource = Nothing
                ConexionLogin.ConexionBase.Close()
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
        Dim frm As Productos = CType(Owner, Productos)
        frm.TxtCodigoProveedor.Text = dgvprov.CurrentRow.Cells(0).Value
        frm.TxtNombreProveedor.Text = dgvprov.CurrentRow.Cells(1).Value


        Me.Close()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class