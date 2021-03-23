Imports System.Data.SqlClient
Public Class Categorias

    Private Sub Categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Categoria", conec)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Categoria", conec)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DGV.DataSource = DatosCat
        If txCodCat.Text = "" Or txtNombCat.Text = "" Then
            MsgBox("Hay campos vacios")
        Else
            Dim consultaGuardar As String = "insert into Categoria(CodCateg, NombCateg) values(@CodCateg, @NombCateg)"
            Dim ejecutar As New SqlCommand(consultaGuardar, conec)
            ejecutar.Parameters.AddWithValue("@CodCateg", Val(txCodCat.Text))
            ejecutar.Parameters.AddWithValue("@NombCateg", (txtNombCat.Text))
            ejecutar.ExecuteNonQuery()

        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Categoria", conec)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat
        If txCodCat.Text = "" Or txtNombCat.Text = "" Then
            MsgBox("Hay campos vacios")
        Else

            Dim consultaAct As String = "update Categoria set NombCateg=@NombCateg where CodCateg= @CodCateg"
            Dim ejecutar As New SqlCommand(consultaAct, conec)
            ejecutar.Parameters.AddWithValue("@CodCateg", Val(txCodCat.Text))
            ejecutar.Parameters.AddWithValue("@NombCateg", (txtNombCat.Text))
            ejecutar.ExecuteNonQuery()

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Categoria", conec)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DGV.DataSource = DatosCat
        If txCodCat.Text = "" Then
            MsgBox("Hay campos vacios")
        Else

            Dim consultaElim As String = "delete from Categoria  where CodCateg= @CodCateg"
            Dim ejecutar As New SqlCommand(consultaElim, conec)
            ejecutar.Parameters.AddWithValue("@CodCateg", Val(txCodCat.Text))
            ejecutar.ExecuteNonQuery()

        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim busqueda As Integer

        busqueda = InputBox("Ingrese Codigo", "Busqueda")


        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Dim query As String = "select * from Categoria where CodCateg=" & busqueda

        Using adaptador As New SqlDataAdapter(query, conec)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat

    End Sub

    Private Sub btnActTabla_Click(sender As Object, e As EventArgs) Handles btnActTabla.Click

        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Categoria", conec)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat

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

    'Funcion para que solo permite el ingreso de caracteres tipo letra
    Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    'Funcion para que solo permite el ingreso de caracteres tipo numerico
    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub txCodCat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCodCat.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtNombCat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombCat.KeyPress
        SoloLetras(e)
    End Sub
End Class