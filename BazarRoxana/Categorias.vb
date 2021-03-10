Public Class Categorias
    Private Sub Categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BazarRoxanaDataSet.Categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.BazarRoxanaDataSet.Categoria)



    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Me.CategoriaTableAdapter.InsertQuery(Val(txCodCat.Text), txtNombCat.Text)
        Me.CategoriaTableAdapter.Fill(Me.BazarRoxanaDataSet.Categoria)
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Me.CategoriaTableAdapter.UpdateQuery(Val(txCodCat.Text), txtNombCat.Text, Val(txCodCat.Text))
        Me.CategoriaTableAdapter.Fill(Me.BazarRoxanaDataSet.Categoria)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Me.CategoriaTableAdapter.DeleteQuery(Val(txCodCat.Text))
        Me.CategoriaTableAdapter.Fill(Me.BazarRoxanaDataSet.Categoria)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim busqueda As Integer

        busqueda = InputBox("Ingrese Codigo", "Busqueda")
        Me.CategoriaTableAdapter.FillBy(Me.BazarRoxanaDataSet.Categoria, busqueda)

    End Sub

    Private Sub btnActTabla_Click(sender As Object, e As EventArgs) Handles btnActTabla.Click
        Me.CategoriaTableAdapter.Fill(Me.BazarRoxanaDataSet.Categoria)


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DGV.DoubleClick

        txCodCat.Text = DGV.CurrentRow.Cells(0).Value
        txtNombCat.Text = DGV.CurrentRow.Cells(1).Value

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub
End Class