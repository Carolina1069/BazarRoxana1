Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Categorias
    Dim dt As New DataTable()
    Private Sub Categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', DescripCateg as 'Descripcion', CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria  where EstadoCateg=1", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat
        conexion.Close()
        btnHabilitar.Visible = False

    End Sub

    'Private Sub insertarCategoria()
    '    Dim nombre As String
    '    Dim descripcion As String
    '    Dim estado As Integer

    '    txtNombCat.Text = nombre
    '    txtDescripcion.Text = descripcion
    '    If chkEstado.Checked = True Then
    '        estado = 1
    '    Else
    '        estado = 0
    '    End If
    '    Try
    '        If ConexionLogin.insertarCategoria(nombre, estado, descripcion) Then
    '            MessageBox.Show("Categoria ingresada con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '        Else
    '            MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Public Sub mostrar_categoria()
    '    Try

    '        dt = ConexionLogin.mostrarCategoria()

    '        If dt.Rows.Count <> 0 Then
    '            DGV.DataSource = dt
    '            TxtBusqueda.Enabled = True
    '            DGV.ColumnHeadersVisible = True

    '        Else
    '            DGV.DataSource = Nothing
    '            TxtBusqueda.Enabled = False
    '            DGV.ColumnHeadersVisible = False

    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    buscar()
    'End Sub
    Public Sub Limpia()
        Try

            txCodCat.Clear()
            txtNombCat.Clear()
            txtDescripcion.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub





    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        abrir()
        If txtNombCat.Text = "" Or txtDescripcion.Text = "" Then
            MsgBox("Hay campos vacios")


        Else
            If PersonaRegistradaCategoria(txtNombCat.Text) = False Then

                Dim consultaGuardar As String = "insert into Categoria( NombCateg, EstadoCateg, DescripCateg) values( @NombCateg, 1,@DescripCateg)"
                Dim ejecutar As New SqlCommand(consultaGuardar, conexion)
                ejecutar.Parameters.AddWithValue("@NombCateg", (txtNombCat.Text))
                ejecutar.Parameters.AddWithValue("@DescripCateg", (txtDescripcion.Text))
                If ejecutar.ExecuteNonQuery() Then
                    MessageBox.Show("Categoria insertada con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("Error al insertar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("El registro ya existe")
            End If
        End If


        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', DescripCateg as 'Descripcion', CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria  where EstadoCateg=1", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DGV.DataSource = DatosCat
        conexion.Close()


    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Dim codigo As Integer, nombre As String, descripcion As String

        If txtNombCat.Text = "" Or txtDescripcion.Text = "" Then
            MsgBox("Hay campos vacios")
        Else
            Try
                codigo = Val(txCodCat.Text)
                nombre = txtNombCat.Text
                descripcion = txtDescripcion.Text

                If (ConexionLogin.ActualizarCategoria(codigo, nombre, descripcion)) Then
                    MessageBox.Show("Actualizado")

                    'conexion.conexion.Close() 
                Else
                    MessageBox.Show("Error al actualizar")
                    'conexion.conexion.Close() 
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                ConexionLogin.conexion.Close()
            End Try

        End If

        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta 
        Using adaptador As New SqlDataAdapter("Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', DescripCateg as 'Descripcion', CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria  where EstadoCateg=1", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable 
        DGV.DataSource = DatosCat
        conexion.Close()
    End Sub




    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        abrir()

        If txCodCat.Text = "" Then
            MsgBox("Hay campos vacios")
        Else

            Dim consultaElim As String = "Update Categoria set EstadoCateg=0   where CodCateg= @CodCateg"
            Dim ejecutar As New SqlCommand(consultaElim, conexion)
            ejecutar.Parameters.AddWithValue("@CodCateg", Val(txCodCat.Text))
            If ejecutar.ExecuteNonQuery() Then
                MessageBox.Show("Categoria eliminada con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Error al eliminar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', DescripCateg as 'Descripcion', CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria  where EstadoCateg=1", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DGV.DataSource = DatosCat
        conexion.Close()
        Limpia()
    End Sub

    Private Sub buscar()
        Dim dt As New DataTable()
        Dim dato As String

        Try
            If chkInhabil.Checked = True Then
                dato = TxtBusqueda.Text
                dt = ConexionLogin.buscarCategoriaI(dato)

                If dt.Rows.Count <> 0 Then
                    DGV.DataSource = dt
                    ConexionLogin.conexion.Close()

                Else
                    DGV.DataSource = Nothing
                    ConexionLogin.conexion.Close()
                End If

            Else
                dato = TxtBusqueda.Text
                dt = ConexionLogin.buscarCategoriaH(dato)

                If dt.Rows.Count <> 0 Then
                    DGV.DataSource = dt
                    ConexionLogin.conexion.Close()

                Else
                    DGV.DataSource = Nothing
                    ConexionLogin.conexion.Close()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub



    Private Sub btnActTabla_Click(sender As Object, e As EventArgs) Handles btnHabilitar.Click
        abrir()

        Try
            Dim consultaAct As String = "update Categoria set EstadoCateg=1 where CodCateg= @CodCateg"
            Dim ejecutar As New SqlCommand(consultaAct, conexion)
            ejecutar.Parameters.AddWithValue("@CodCateg", Val(txCodCat.Text))

            If ejecutar.ExecuteNonQuery() Then
                MessageBox.Show("Categoria habilitada con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Error al habilitar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', DescripCateg as 'Descripcion', CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria  where EstadoCateg=0", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DGV.DataSource = DatosCat



        conexion.Close()
        Limpia()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DGV.DoubleClick

        txCodCat.Text = DGV.CurrentRow.Cells(0).Value
        txtNombCat.Text = DGV.CurrentRow.Cells(1).Value
        'chkEstado.Checked = DGV.CurrentRow.Cells(2).Value
        txtDescripcion.Text = DGV.CurrentRow.Cells(2).Value

    End Sub

    'Funcion para que solo permite el ingreso de caracteres tipo letra
    Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If



        'If Char.IsDigit(e.KeyChar) Then
        '    e.Handled = True
        '    MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        'ElseIf Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    e.Handled = False
        'End If
        'If Char.IsSeparator(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    e.Handled = False

        'End If
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
        'If Char.IsWhiteSpace(e.KeyChar) Then
        '    e.Handled = True
        '    MessageBox.Show(" ")
        'End If
    End Sub

    Private Sub chkInhabil_CheckedChanged(sender As Object, e As EventArgs) Handles chkInhabil.CheckedChanged

        abrir()

        If chkInhabil.Checked = True Then

            Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', DescripCateg as 'Descripcion',CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria  where EstadoCateg=0", conexion)
                adaptador.Fill(DatosCat)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGV.DataSource = DatosCat
            btnGuardar.Visible = False
            btnActualizar.Visible = False
            btnEliminar.Visible = False
            btnHabilitar.Visible = True
        Else

            Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', DescripCateg as 'Descripcion',CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria  where EstadoCateg=1", conexion)
                adaptador.Fill(DatosCat)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGV.DataSource = DatosCat
            btnGuardar.Visible = True
            btnActualizar.Visible = True
            btnEliminar.Visible = True
            btnHabilitar.Visible = False

        End If
        conexion.Close()
        Limpia()


    End Sub


    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        buscar()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLimpia.Click
        Limpia()
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        'Dim FilaActual As Integer
        'FilaActual = DGV.CurrentRow.Index
        'txCodCat.Text = Convert.ToString(DGV.Rows(FilaActual).Cells(0).Value)
        'txtNombCat.Text = Convert.ToString(DGV.Rows(FilaActual).Cells(1).Value)
        'txtDescripcion.Text = Convert.ToString(DGV.Rows(FilaActual).Cells(3).Value)


    End Sub

    Private Sub chkEstado_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Public Sub mostrar()
        Try
            dt = ConexionLogin.mostrarCategoria

            If dt.Rows.Count <> 0 Then
                DGV.DataSource = dt

                DGV.ColumnHeadersVisible = True


            Else
                DGV.DataSource = Nothing

                DGV.ColumnHeadersVisible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function validarCorreo(ByVal isCorreo As String) As Boolean
        Return Regex.IsMatch(isCorreo, "^[_a-z 0-9-]$")
    End Function

    Private Sub txtNombCat_TextChanged(sender As Object, e As EventArgs) Handles txtNombCat.TextChanged

    End Sub

    Private Sub txtNombCat_TabStopChanged(sender As Object, e As EventArgs) Handles txtNombCat.TabStopChanged

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub
End Class