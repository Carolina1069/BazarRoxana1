Imports System.Data.SqlClient
Public Class Categorias
    Dim dt As New DataTable()
    Private Sub Categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        abrir()
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("Select CodCateg as 'Código de la categoría', NombCateg as 'Nombre de la categoría', CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la categoría' from Categoria  where EstadoCateg=1", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat
        conexion.Close()

    End Sub

    Private Sub insertarCategoria()
        Dim nombre As String
        Dim descripcion As String
        Dim estado As Integer

        txtNombCat.Text = nombre
        txtDescripcion.Text = descripcion
        If chkEstado.Checked = True Then
            estado = 1
        Else
            estado = 0
        End If
        Try
            If ConexionLogin.insertarCategoria(nombre, estado, descripcion) Then
                MessageBox.Show("Categoria ingresada con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub mostrar_categoria()
        Try

            dt = ConexionLogin.mostrarCategoria()

            If dt.Rows.Count <> 0 Then
                DGV.DataSource = dt
                TxtBusqueda.Enabled = True
                DGV.ColumnHeadersVisible = True

            Else
                DGV.DataSource = Nothing
                TxtBusqueda.Enabled = False
                DGV.ColumnHeadersVisible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        buscar()
    End Sub
    Public Sub Limpia()
        Try
            Dim DatosCat As New DataTable

            DGV.DataSource = DatosCat
            conexion.Close()
            txCodCat.Clear()
            txtNombCat.Clear()
            chkEstado.Checked = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        buscar()
    End Sub





    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        abrir()

        If txtNombCat.Text = "" Or DGV.Rows.Count = 0 Then
            MsgBox("Hay campos vacios")
        Else
            If PersonaRegistradaCategoria(txCodCat.Text) = False Then
                Dim consultaGuardar As String = "insert into Categoria( NombCateg, EstadoCateg, DescripCateg) values( @NombCateg, 1,@DescripCateg)"
                Dim ejecutar As New SqlCommand(consultaGuardar, conexion)
                ejecutar.Parameters.AddWithValue("@NombCateg", (txtNombCat.Text))
                ejecutar.Parameters.AddWithValue("@DescripCateg", (txtDescripcion.Text))
                ejecutar.ExecuteNonQuery()
            Else
                MsgBox("La Categoria ya esta registrada")
            End If
        End If

        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria  where EstadoCateg=1", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DGV.DataSource = DatosCat
        conexion.Close()

        txCodCat.Clear()
        txtNombCat.Clear()
        chkEstado.Checked = False

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        abrir()
        Dim estado As Integer

        If chkEstado.Checked = True Then

            estado = 1
        Else

            estado = 0
        End If

        If txCodCat.Text = "" Or txtNombCat.Text = "" Or DGV.Rows.Count = 0 Then
            MsgBox("Hay campos vacios")
        Else
            Dim consultaAct As String = "update Categoria set NombCateg=@NombCateg, EstadoCateg=@EstadoCateg where CodCateg= @CodCateg"
            Dim ejecutar As New SqlCommand(consultaAct, conexion)
                ejecutar.Parameters.AddWithValue("@CodCateg", Val(txCodCat.Text))
                ejecutar.Parameters.AddWithValue("@NombCateg", (txtNombCat.Text))
                ejecutar.Parameters.AddWithValue("@EstadoCateg", (estado))
                ejecutar.ExecuteNonQuery()

        End If

            Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria  where EstadoCateg=1", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable



    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        abrir()

        If txCodCat.Text = "" Then
            MsgBox("Hay campos vacios")
        Else

            Dim consultaElim As String = "Update Categoria set EstadoCateg=0   where CodCateg= @CodCateg"
            Dim ejecutar As New SqlCommand(consultaElim, conexion)
            ejecutar.Parameters.AddWithValue("@CodCateg", Val(txCodCat.Text))
            ejecutar.ExecuteNonQuery()

        End If

        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria  where EstadoCateg=1", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DGV.DataSource = DatosCat
        conexion.Close()

    End Sub

    Private Sub buscar()
        Dim dt As New DataTable()
        Dim dato As String

        Try
            dato = TxtBusqueda.Text
            dt = ConexionLogin.buscarCategoria(dato)

            If dt.Rows.Count <> 0 Then
                DGV.DataSource = dt
                ConexionLogin.conexion.Close()

            Else
                DGV.DataSource = Nothing
                ConexionLogin.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'abrir()

        'Dim busqueda As Integer

        'busqueda = InputBox("Ingrese Codigo", "Busqueda")


        'Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        'Dim query As String = "Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria where CodCateg=" & busqueda

        'Using adaptador As New SqlDataAdapter(query, conexion)
        '    adaptador.Fill(DatosCat)
        'End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        'DGV.DataSource = DatosCat
        'conexion.Close()

    End Sub



    Private Sub btnActTabla_Click(sender As Object, e As EventArgs) Handles btnActTabla.Click
        abrir()
        chkInhabil.Checked = False
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria  where EstadoCateg=1", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DGV.DoubleClick

        txCodCat.Text = DGV.CurrentRow.Cells(0).Value
        txtNombCat.Text = DGV.CurrentRow.Cells(1).Value

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

    Private Sub chkInhabil_CheckedChanged(sender As Object, e As EventArgs) Handles chkInhabil.CheckedChanged

        abrir()

        If chkInhabil.Checked = True Then

            Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria  where EstadoCateg=0", conexion)
                adaptador.Fill(DatosCat)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGV.DataSource = DatosCat

        Else

            Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria  where EstadoCateg=1", conexion)
                adaptador.Fill(DatosCat)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGV.DataSource = DatosCat

        End If
        conexion.Close()
    End Sub


    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        buscar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLimpia.Click
        Limpia()
    End Sub
End Class