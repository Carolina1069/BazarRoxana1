Imports System.Data.SqlClient

Public Class Categorias
    Dim dt As New DataTable()

    Private Sub Categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConeccion()
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using DtAdaptador As New SqlDataAdapter("Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', DescripCateg as 'Descripcion', CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria  where EstadoCateg=1", ConexionBase)
            DtAdaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DgvCategorias.DataSource = DatosCat
        ConexionBase.Close()
        BtnHabilitar.Visible = False

    End Sub

    'Funcion que limpia las cajas de texto
    Public Sub FuncLimpia()
        Try
            TxCodCat.Clear()
            TxtNombCat.Clear()
            TxtDescripcion.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Guarda un nuevo registro en la base de datos
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        AbrirConeccion()
        If TxtNombCat.Text = "" Or TxtDescripcion.Text = "" Then
            MsgBox("Hay campos vacios")

        Else
            If PersonaRegistradaCategoria(TxtNombCat.Text) = False Then

                Dim ConsultaGuardar As String = "insert into Categoria( NombCateg, EstadoCateg, DescripCateg) values( @NombCateg, 1,@DescripCateg)"
                Dim EjecutarSql As New SqlCommand(ConsultaGuardar, ConexionBase)
                EjecutarSql.Parameters.AddWithValue("@NombCateg", (TxtNombCat.Text))
                EjecutarSql.Parameters.AddWithValue("@DescripCateg", (TxtDescripcion.Text))
                If EjecutarSql.ExecuteNonQuery() Then
                    MessageBox.Show("Categoria insertada con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("Error al insertar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("El registro ya existe")
            End If
        End If

        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using DtAdaptador As New SqlDataAdapter("Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', DescripCateg as 'Descripcion', CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria  where EstadoCateg=1", ConexionBase)
            DtAdaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DgvCategorias.DataSource = DatosCat
        ConexionBase.Close()

    End Sub

    'Actualiza los datos que se hayan modificado del DataGridView
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        Dim CodigoCateg As Integer, NombreCateg As String, DescripcionCateg As String

        If TxtNombCat.Text = "" Or TxtDescripcion.Text = "" Then
            MsgBox("Hay campos vacios")
        Else
            Try
                CodigoCateg = Val(TxCodCat.Text)
                NombreCateg = TxtNombCat.Text
                DescripcionCateg = TxtDescripcion.Text

                If (ConexionLogin.ActualizarCategoria(CodigoCateg, NombreCateg, DescripcionCateg)) Then
                    MessageBox.Show("Actualizado")

                Else
                    MessageBox.Show("Error al actualizar")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                ConexionLogin.ConexionBase.Close()
            End Try

        End If

        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta 
        Using DtAdaptador As New SqlDataAdapter("Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', DescripCateg as 'Descripcion', CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria  where EstadoCateg=1", ConexionBase)
            DtAdaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable 
        DgvCategorias.DataSource = DatosCat
        ConexionBase.Close()
    End Sub

    'Elimina un registro cambiando su estado en 0
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        AbrirConeccion()

        If TxCodCat.Text = "" Then
            MsgBox("Hay campos vacios")
        Else

            Dim ConsultaElim As String = "Update Categoria set EstadoCateg=0   where CodCateg= @CodCateg"
            Dim EjecutarSql As New SqlCommand(ConsultaElim, ConexionBase)
            EjecutarSql.Parameters.AddWithValue("@CodCateg", Val(TxCodCat.Text))
            If EjecutarSql.ExecuteNonQuery() Then
                MessageBox.Show("Categoria eliminada con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Error al eliminar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using DtAdaptador As New SqlDataAdapter("Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', DescripCateg as 'Descripcion', CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria  where EstadoCateg=1", ConexionBase)
            DtAdaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DgvCategorias.DataSource = DatosCat
        ConexionBase.Close()
        FuncLimpia()
    End Sub

    'Funcion que busca en el DataGridView los datos ingresados en la caja de texto 
    Private Sub FuncBuscar()
        Dim InstDt As New DataTable()
        Dim DatoBusqueda As String

        Try
            If ChkInhabil.Checked = True Then
                DatoBusqueda = TxtBusqueda.Text
                InstDt = ConexionLogin.BuscarCategoriaI(DatoBusqueda)

                If InstDt.Rows.Count <> 0 Then
                    DgvCategorias.DataSource = InstDt
                    ConexionLogin.ConexionBase.Close()

                Else
                    DgvCategorias.DataSource = Nothing
                    ConexionLogin.ConexionBase.Close()
                End If

            Else
                DatoBusqueda = TxtBusqueda.Text
                InstDt = ConexionLogin.buscarCategoriaH(DatoBusqueda)

                If InstDt.Rows.Count <> 0 Then
                    DgvCategorias.DataSource = InstDt
                    ConexionLogin.ConexionBase.Close()

                Else
                    DgvCategorias.DataSource = Nothing
                    ConexionLogin.ConexionBase.Close()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Boton que habilita una categoria que se haya eliminado
    Private Sub BtnHabilitar_Click(sender As Object, e As EventArgs) Handles BtnHabilitar.Click
        AbrirConeccion()

        Try
            Dim ConsultaAct As String = "update Categoria set EstadoCateg=1 where CodCateg= @CodCateg"
            Dim EjecutarSql As New SqlCommand(ConsultaAct, ConexionBase)
            EjecutarSql.Parameters.AddWithValue("@CodCateg", Val(TxCodCat.Text))

            If EjecutarSql.ExecuteNonQuery() Then
                MessageBox.Show("Categoria habilitada con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al habilitar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using AdaptadorDt As New SqlDataAdapter("Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', DescripCateg as 'Descripcion', CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria  where EstadoCateg=0", ConexionBase)
            AdaptadorDt.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DgvCategorias.DataSource = DatosCat
        ConexionBase.Close()
        FuncLimpia()

    End Sub

    'Al dar doble click se muestran los campos del DataGridView en los TextBox 
    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DgvCategorias.DoubleClick

        TxCodCat.Text = DgvCategorias.CurrentRow.Cells(0).Value
        TxtNombCat.Text = DgvCategorias.CurrentRow.Cells(1).Value
        TxtDescripcion.Text = DgvCategorias.CurrentRow.Cells(2).Value

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

    Private Sub TxCodCat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxCodCat.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtNombCat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombCat.KeyPress
        SoloLetras(e)
    End Sub

    'Al esta seleccionado muestra los registros Inhabilitados
    Private Sub ChkInhabil_CheckedChanged(sender As Object, e As EventArgs) Handles ChkInhabil.CheckedChanged

        AbrirConeccion()

        If ChkInhabil.Checked = True Then

            Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using AdaptadorDt As New SqlDataAdapter("Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', DescripCateg as 'Descripcion',CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria  where EstadoCateg=0", ConexionBase)
                AdaptadorDt.Fill(DatosCat)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DgvCategorias.DataSource = DatosCat
            BtnGuardar.Visible = False
            BtnActualizar.Visible = False
            BtnEliminar.Visible = False
            BtnHabilitar.Visible = True
        Else

            Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using AdaptadorDt As New SqlDataAdapter("Select CodCateg as 'Codigo de la Categoria', NombCateg as 'Nombre de la Categoria', DescripCateg as 'Descripcion',CASE When EstadoCateg=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado de la Categoria' from Categoria  where EstadoCateg=1", ConexionBase)
                AdaptadorDt.Fill(DatosCat)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DgvCategorias.DataSource = DatosCat
            BtnGuardar.Visible = True
            BtnActualizar.Visible = True
            BtnEliminar.Visible = True
            BtnHabilitar.Visible = False

        End If
        ConexionBase.Close()
        FuncLimpia()

    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        FuncBuscar()
        LbContBuscar.Text = TxtBusqueda.Text.Length 'Contador de caracteres
    End Sub

    Private Sub BtnLimpia_Click(sender As Object, e As EventArgs) Handles BtnLimpia.Click
        FuncLimpia()
    End Sub

    Public Sub MostrarCateg()
        Try
            dt = ConexionLogin.MostrarCategoria

            If dt.Rows.Count <> 0 Then
                DgvCategorias.DataSource = dt
                DgvCategorias.ColumnHeadersVisible = True

            Else
                DgvCategorias.DataSource = Nothing

                DgvCategorias.ColumnHeadersVisible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtNombCat_TextChanged(sender As Object, e As EventArgs) Handles TxtNombCat.TextChanged
        LbContNombre.Text = TxtNombCat.Text.Length 'Contador de caracteres
    End Sub

    Private Sub TxtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles TxtDescripcion.TextChanged
        LbContDescripcion.Text = TxtDescripcion.Text.Length 'Contador de caracteres
    End Sub
End Class