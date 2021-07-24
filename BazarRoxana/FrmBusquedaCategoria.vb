Public Class FrmBusquedaCategoria
    Dim dt As New DataTable()
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtBuscarCateg_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCateg.TextChanged
        buscar()
    End Sub
    Private Sub FrmBusquedaCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Public Sub mostrar()
        Try
            dt = ConexionLogin.MostrarCategoria

            If dt.Rows.Count <> 0 Then
                dgvcategoria.DataSource = dt

                dgvcategoria.ColumnHeadersVisible = True


            Else
                dgvcategoria.DataSource = Nothing

                dgvcategoria.ColumnHeadersVisible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub buscar()
        Dim dt As New DataTable()
        Dim Catg As String

        Try
            Catg = txtBuscarCateg.Text
            dt = ConexionLogin.buscarCategoriaH(Catg)

            If dt.Rows.Count <> 0 Then
                dgvcategoria.DataSource = dt
                ConexionLogin.ConexionBase.Close()

            Else
                dgvcategoria.DataSource = Nothing
                ConexionLogin.ConexionBase.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub dgvcategoria_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcategoria.CellDoubleClick
        Dim frm As Productos = CType(Owner, Productos)
        frm.TxtNombreCategoria.Text = dgvcategoria.CurrentRow.Cells(1).Value
        frm.TxtCodigoCategoria.Text = dgvcategoria.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub
End Class