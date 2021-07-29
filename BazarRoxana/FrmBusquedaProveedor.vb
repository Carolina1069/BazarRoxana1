Public Class FrmBusquedaProveedor
    Dim dt As New DataTable()
    Private Sub FrmBusquedaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub
    Public Sub mostrar()
        Try
            ConexionBase.Close()
            dt = ConexionLogin.mostrarProveedor

            If dt.Rows.Count <> 0 Then
                DgvProv.DataSource = dt

                DgvProv.ColumnHeadersVisible = True


            Else
                DgvProv.DataSource = Nothing

                DgvProv.ColumnHeadersVisible = False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub buscar()
        Dim dt As New DataTable()
        Dim Proveedores As String

        Try
            Proveedores = TxtBuscarProv.Text
            dt = ConexionLogin.buscarProveedorH(Proveedores)

            If dt.Rows.Count <> 0 Then
                DgvProv.DataSource = dt
                ConexionLogin.ConexionBase.Close()

            Else
                DgvProv.DataSource = Nothing
                ConexionLogin.ConexionBase.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub txtBuscarProv_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarProv.TextChanged
        buscar()
    End Sub



    Private Sub dgvprov_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim frm As Productos = CType(Owner, Productos)
        frm.TxtCodigoProveedor.Text = DgvProv.CurrentRow.Cells(0).Value
        frm.TxtNombreProveedor.Text = DgvProv.CurrentRow.Cells(1).Value


        Me.Close()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class