Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Productos


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

    Private Sub TxtPrimerPrecio_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub TxtSegundoPrecio_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub TxtTercerPrecio_KeyPress(sender As Object, e As KeyPressEventArgs)

        SoloNumeros(e)

    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConeccion()
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("SELECT Producto.CodProduc as 'Codigo Producto',
                        CONCAT(Producto.DescripProduc, ' ' , Producto.NombProduc) as 'Nombre Producto',
                        Producto.Descripcion as Descripción,
                        Producto.CodProv as 'Código Proveedor',
                        Producto.NombProv as 'Nombre Proveedor',
                        Producto.CodCateg as 'Código Categoría',
                        CONCAT(Producto.NombCateg, ' ' , Categoria.DescripCateg) as 'Nombre Categoría',
                        Producto.PrimerPrecio as 'Primer Precio',
                        Producto.SegundoPrecio as 'Segundo Precio',
                        Producto.TercerPrecio as 'Tercer Precio',
                        Producto.UnidadesStock as 'Unidades Stock',
                        Producto.Minimo as Minimo,
                        Producto.Maximo as Maximo,
                        case when Estado=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del producto'
                        FROM Categoria INNER JOIN
                        Producto ON Categoria.CodCateg = Producto.CodCateg
                        where Estado = 1", ConexionBase)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DgvProductos.DataSource = DatosCat
        TxtCodigoCategoria.ReadOnly = True
        TxtCodigoProveedor.ReadOnly = True
        TxtNombreCategoria.ReadOnly = True
        TxtNombreProveedor.ReadOnly = True

        ConexionBase.Close()
        BtnHabilitar.Visible = False
        BtnEliminar.Visible = False
        BtnActualizar.Visible = False
    End Sub


    Private Sub TxtCodigoCategoria_TextChanged(sender As Object, e As EventArgs) Handles TxtCodigoCategoria.TextChanged
        AbrirConeccion()
        Dim Recuperar As String = "select * from Categoria where CodCateg= '" & TxtCodigoCategoria.Text & "'"
        Dim Mostrar As SqlDataReader
        Dim Ejecutar As SqlCommand
        Ejecutar = New SqlCommand(Recuperar, ConexionBase)
        Mostrar = Ejecutar.ExecuteReader
        Dim Estado As String
        Estado = Mostrar.Read
        If (Estado = True) Then
            TxtNombreCategoria.Text = Mostrar(1)
        Else
            TxtNombreCategoria.Text = ""
        End If
        Mostrar.Close()
        ConexionBase.Close()
    End Sub



    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs)
        TxtCodigoProducto.Text = DgvProductos.CurrentRow.Cells(0).Value
        TxtNombreProducto.Text = DgvProductos.CurrentRow.Cells(1).Value
        RtxDescripcionProducto.Text = DgvProductos.CurrentRow.Cells(2).Value
        TxtCodigoProveedor.Text = DgvProductos.CurrentRow.Cells(3).Value
        TxtCodigoCategoria.Text = DgvProductos.CurrentRow.Cells(4).Value
        TxtPrimerPrecio.Text = DgvProductos.CurrentRow.Cells(5).Value
        TxtSegundoPrecio.Text = DgvProductos.CurrentRow.Cells(6).Value
        TxtTercerPrecio.Text = DgvProductos.CurrentRow.Cells(7).Value
        TxtProductosMaximos.Text = DgvProductos.CurrentRow.Cells(9).Value
        TxtProductosMinimos.Text = DgvProductos.CurrentRow.Cells(10).Value
    End Sub

    Private Sub TxtCodigoProveedor_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtCodigoProveedor.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtCodigoCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodigoCategoria.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtCodigoProducto_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtCodigoProducto.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtPrimerPrecio_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtPrimerPrecio.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtSegundoPrecio_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtSegundoPrecio.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtProductosMaximos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtProductosMaximos.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtTercerPrecio_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtTercerPrecio.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtProductosMinimos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtProductosMinimos.KeyPress
        SoloNumeros(e)
    End Sub
    Private Sub TxtNombreProducto_Validating(sender As Object, e As CancelEventArgs) Handles TxtNombreProducto.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 And DirectCast(sender, TextBox).Text.Length <= 10 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RtxDescripcionProducto_Validating(sender As Object, e As CancelEventArgs) Handles RtxDescripcionProducto.Validating
        Try
            If DirectCast(sender, RichTextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TxtProductosMaximos_Validating(sender As Object, e As CancelEventArgs) Handles TxtProductosMaximos.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtProductosMinimos_Validating(sender As Object, e As CancelEventArgs) Handles TxtProductosMinimos.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtCodigoProveedor_Validating(sender As Object, e As CancelEventArgs) Handles TxtCodigoProveedor.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtCodigoCategoria_Validating(sender As Object, e As CancelEventArgs) Handles TxtCodigoCategoria.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub TxtNombreProveedor_Validating(sender As Object, e As CancelEventArgs) Handles TxtNombreProveedor.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub TxtNombreCategoria_Validating(sender As Object, e As CancelEventArgs) Handles TxtNombreCategoria.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub TxtPrimerPrecio_Validating(sender As Object, e As CancelEventArgs) Handles TxtPrimerPrecio.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub TxtTercerPrecio_Validating(sender As Object, e As CancelEventArgs) Handles TxtTercerPrecio.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtSegundoPrecio_Validating(sender As Object, e As CancelEventArgs) Handles TxtSegundoPrecio.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LimpiarCajasTexto()
        Try

            TxtCodigoProducto.Clear()
            TxtNombreProducto.Clear()
            RtxDescripcionProducto.Clear()
            RtxDescripcionProducto2.Clear()
            TxtCodigoProveedor.Clear()
            TxtNombreProveedor.Clear()
            TxtCodigoCategoria.Clear()
            TxtNombreCategoria.Clear()
            TxtPrimerPrecio.Clear()
            TxtSegundoPrecio.Clear()
            TxtTercerPrecio.Clear()
            TxtProductosMaximos.Clear()
            TxtProductosMinimos.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        AbrirConeccion()

        If TxtCodigoProducto.Text = "" Then
            MsgBox("Hay campos vacios")
        Else
            Dim consultaElim As String = "Update Producto set Estado=0   where CodProduc= @CodProduc"
            Dim ejecutar As New SqlCommand(consultaElim, ConexionBase)
            ejecutar.Parameters.AddWithValue("@CodProduc", Val(TxtCodigoProducto.Text))
            Dim opcion As DialogResult
            opcion = MessageBox.Show("¿Esta Seguro que desea eliminar el producto?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If opcion = DialogResult.Yes Then
                If ejecutar.ExecuteNonQuery() Then

                    MessageBox.Show("Producto eliminado con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("Error al eliminar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        End If
        BtnEliminar.Visible = False
        BtnActualizar.Visible = False

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("SELECT Producto.CodProduc as 'Codigo Producto',
                        CONCAT(Producto.DescripProduc, ' ' , Producto.NombProduc) as 'Nombre Producto',
                        Producto.Descripcion as Descripción,
                        Producto.CodProv as 'Código Proveedor',
                        Producto.NombProv as 'Nombre Proveedor',
                        Producto.CodCateg as 'Código Categoría',
                        CONCAT(Producto.NombCateg, ' ' , Categoria.DescripCateg) as 'Nombre Categoría',
                        Producto.PrimerPrecio as 'Primer Precio',
                        Producto.SegundoPrecio as 'Segundo Precio',
                        Producto.TercerPrecio as 'Tercer Precio',
                        Producto.UnidadesStock as 'Unidades Stock',
                        Producto.Minimo as Minimo,
                        Producto.Maximo as Maximo,
                        case when Estado=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del producto'
                        FROM Categoria INNER JOIN
                        Producto ON Categoria.CodCateg = Producto.CodCateg
                        where Estado = 1", ConexionBase)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DgvProductos.DataSource = DatosEmp
        ConexionBase.Close()
        LimpiarCajasTexto()



    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim codprod As Integer, NomProd As String, descripcion As String, descripcion2 As String, Codprov As Integer, NombProv As String
        Dim CodCateg As Integer, NombCateg As String, PrimerPrecio As Integer, SegundoPrecio As Integer
        Dim TercerPrecio As Integer, UnidadesStock As Integer, Minimo As Integer, maximo As Integer


        If TxtNombreProducto.Text = "" Or RtxDescripcionProducto.Text = "" Or RtxDescripcionProducto2.Text = "" Or TxtProductosMaximos.Text = "" Or TxtProductosMinimos.Text = "" Or TxtCodigoProveedor.Text = "" Or TxtNombreProveedor.Text = "" Or TxtCodigoCategoria.Text = "" Or TxtNombreCategoria.Text = "" Or TxtPrimerPrecio.Text = "" Or TxtSegundoPrecio.Text = "" Or TxtTercerPrecio.Text = "" Then
            MsgBox("Hay campos vacios")

        Else
            Try
                codprod = Val(TxtCodigoProducto.Text)
                NomProd = TxtNombreProducto.Text
                descripcion = RtxDescripcionProducto.Text
                descripcion2 = RtxDescripcionProducto2.Text
                Codprov = TxtCodigoProveedor.Text
                NombProv = TxtNombreProveedor.Text
                CodCateg = Val(TxtCodigoCategoria.Text)
                NombCateg = TxtNombreCategoria.Text
                PrimerPrecio = Val(TxtPrimerPrecio.Text)
                SegundoPrecio = Val(TxtSegundoPrecio.Text)
                TercerPrecio = Val(TxtTercerPrecio.Text)
                maximo = TxtProductosMaximos.Text
                Minimo = TxtProductosMinimos.Text

                If (ConexionLogin.ActualizarProducto(codprod,
                                                     NomProd,
                                                     descripcion,
                                                     descripcion2,
                                                     Codprov,
                                                     NombProv,
                                                     CodCateg,
                                                     NombCateg,
                                                     PrimerPrecio,
                                                     SegundoPrecio,
                                                     TercerPrecio,
                                                     UnidadesStock,
                                                     Minimo,
                                                     maximo)) Then
                    MessageBox.Show("Actualizado")
                    BtnActualizar.Visible = False
                    'conexion.conexion.Close()
                Else
                    MessageBox.Show("Error al actualizar")
                    'conexion.conexion.Close()
                    BtnActualizar.Visible = True
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                ConexionLogin.ConexionBase.Close()
            End Try

        End If

        BtnEliminar.Visible = False
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("SELECT Producto.CodProduc as 'Codigo Producto',
                        CONCAT(Producto.DescripProduc, ' ' , Producto.NombProduc) as 'Nombre Producto',
                        Producto.Descripcion as Descripción,
                        Producto.CodProv as 'Código Proveedor',
                        Producto.NombProv as 'Nombre Proveedor',
                        Producto.CodCateg as 'Código Categoría',
                        CONCAT(Producto.NombCateg, ' ' , Categoria.DescripCateg) as 'Nombre Categoría',
                        Producto.PrimerPrecio as 'Primer Precio',
                        Producto.SegundoPrecio as 'Segundo Precio',
                        Producto.TercerPrecio as 'Tercer Precio',
                        Producto.UnidadesStock as 'Unidades Stock',
                        Producto.Minimo as Minimo,
                        Producto.Maximo as Maximo,
                        case when Estado=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del producto'
                        FROM Categoria INNER JOIN
                        Producto ON Categoria.CodCateg = Producto.CodCateg
                        where Estado = 1", ConexionBase)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DgvProductos.DataSource = DatosCat

        ConexionBase.Close()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim NomProd As String, descripcion As String, descripcion2 As String, Codprov As Integer, NombProv As String
        Dim CodCateg As Integer, NombCateg As String, PrimerPrecio As Integer, SegundoPrecio As Integer
        Dim TercerPrecio As Integer, Minimo As Integer, maximo As Integer


        If TxtNombreProducto.Text = "" Or RtxDescripcionProducto.Text = "" Or RtxDescripcionProducto2.Text = "" Or TxtProductosMaximos.Text = "" Or TxtProductosMinimos.Text = "" Or TxtCodigoProveedor.Text = "" Or TxtNombreProveedor.Text = "" Or TxtCodigoCategoria.Text = "" Or TxtNombreCategoria.Text = "" Or TxtPrimerPrecio.Text = "" Or TxtSegundoPrecio.Text = "" Or TxtTercerPrecio.Text = "" Then
            MsgBox("Hay campos vacios")

        Else
            Try

                NomProd = TxtNombreProducto.Text
                descripcion = RtxDescripcionProducto.Text
                descripcion2 = RtxDescripcionProducto2.Text
                Codprov = TxtCodigoProveedor.Text
                NombProv = TxtNombreProveedor.Text
                CodCateg = Val(TxtCodigoCategoria.Text)
                NombCateg = TxtNombreCategoria.Text
                PrimerPrecio = Val(TxtPrimerPrecio.Text)
                SegundoPrecio = Val(TxtSegundoPrecio.Text)
                TercerPrecio = Val(TxtTercerPrecio.Text)
                maximo = TxtProductosMaximos.Text
                Minimo = TxtProductosMinimos.Text

                If (ConexionLogin.GuardarProducto(NomProd,
                                                     descripcion,
                                                     descripcion2,
                                                     Codprov,
                                                     NombProv,
                                                     CodCateg,
                                                     NombCateg,
                                                     PrimerPrecio,
                                                     SegundoPrecio,
                                                     TercerPrecio,
                                                     Minimo,
                                                     maximo)) Then
                    MessageBox.Show("El producto se inserto con exito")
                    BtnActualizar.Visible = False
                    'conexion.conexion.Close()
                Else
                    MessageBox.Show("Error al insertar")
                    'conexion.conexion.Close()
                    BtnActualizar.Visible = True
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                ConexionLogin.ConexionBase.Close()
            End Try

        End If

        BtnEliminar.Visible = False
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("SELECT Producto.CodProduc as 'Codigo Producto',
                        CONCAT(Producto.DescripProduc, ' ' , Producto.NombProduc) as 'Nombre Producto',
                        Producto.Descripcion as Descripción,
                        Producto.CodProv as 'Código Proveedor',
                        Producto.NombProv as 'Nombre Proveedor',
                        Producto.CodCateg as 'Código Categoría',
                        CONCAT(Producto.NombCateg, ' ' , Categoria.DescripCateg) as 'Nombre Categoría',
                        Producto.PrimerPrecio as 'Primer Precio',
                        Producto.SegundoPrecio as 'Segundo Precio',
                        Producto.TercerPrecio as 'Tercer Precio',
                        Producto.UnidadesStock as 'Unidades Stock',
                        Producto.Minimo as Minimo,
                        Producto.Maximo as Maximo,
                        case when Estado=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del producto'
                        FROM Categoria INNER JOIN
                        Producto ON Categoria.CodCateg = Producto.CodCateg
                        where Estado = 1", ConexionBase)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DgvProductos.DataSource = DatosCat

        ConexionBase.Close()





    End Sub



    Private Sub ChkInhabil_CheckedChanged(sender As Object, e As EventArgs) Handles ChkInhabil.CheckedChanged

        AbrirConeccion()

        If ChkInhabil.Checked = True Then

            Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("SELECT Producto.CodProduc as 'Codigo Producto',
                        CONCAT(Producto.DescripProduc, ' ' , Producto.NombProduc) as 'Nombre Producto',
                        Producto.Descripcion as Descripción,
                        Producto.CodProv as 'Código Proveedor',
                        Producto.NombProv as 'Nombre Proveedor',
                        Producto.CodCateg as 'Código Categoría',
                        CONCAT(Producto.NombCateg, ' ' , Categoria.DescripCateg) as 'Nombre Categoría',
                        Producto.PrimerPrecio as 'Primer Precio',
                        Producto.SegundoPrecio as 'Segundo Precio',
                        Producto.TercerPrecio as 'Tercer Precio',
                        Producto.UnidadesStock as 'Unidades Stock',
                        Producto.Minimo as Minimo,
                        Producto.Maximo as Maximo,
                        case when Estado=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del producto'
                        FROM Categoria INNER JOIN
                        Producto ON Categoria.CodCateg = Producto.CodCateg
                        where Estado = 0", ConexionBase)
                adaptador.Fill(DatosCat)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DgvProductos.DataSource = DatosCat
            BtnGuardar.Visible = False
            BtnActualizar.Visible = False
            BtnEliminar.Visible = False
            BtnHabilitar.Visible = True
        Else

            Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("SELECT Producto.CodProduc as 'Codigo Producto',
                        CONCAT(Producto.DescripProduc, ' ' , Producto.NombProduc) as 'Nombre Producto',
                        Producto.Descripcion as Descripción,
                        Producto.CodProv as 'Código Proveedor',
                        Producto.NombProv as 'Nombre Proveedor',
                        Producto.CodCateg as 'Código Categoría',
                        CONCAT(Producto.NombCateg, ' ' , Categoria.DescripCateg) as 'Nombre Categoría',
                        Producto.PrimerPrecio as 'Primer Precio',
                        Producto.SegundoPrecio as 'Segundo Precio',
                        Producto.TercerPrecio as 'Tercer Precio',
                        Producto.UnidadesStock as 'Unidades Stock',
                        Producto.Minimo as Minimo,
                        Producto.Maximo as Maximo,
                        case when Estado=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del producto'
                        FROM Categoria INNER JOIN
                        Producto ON Categoria.CodCateg = Producto.CodCateg
                        where Estado = 1", ConexionBase)
                adaptador.Fill(DatosCat)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DgvProductos.DataSource = DatosCat
            BtnGuardar.Visible = True
            BtnActualizar.Visible = False
            BtnEliminar.Visible = False
            BtnHabilitar.Visible = False

        End If
        ConexionBase.Close()

    End Sub
    Private Sub BuscarProducto()
        Dim dt As New DataTable()
        Dim dato As String

        Try
            If ChkInhabil.Checked = True Then
                dato = TxtBusqueda.Text
                dt = ConexionLogin.buscarProductI(dato)

                If dt.Rows.Count <> 0 Then
                    DgvProductos.DataSource = dt
                    ConexionLogin.ConexionBase.Close()

                Else
                    DgvProductos.DataSource = Nothing
                    ConexionLogin.ConexionBase.Close()
                End If

            Else
                dato = TxtBusqueda.Text
                dt = ConexionLogin.buscarProductH(dato)

                If dt.Rows.Count <> 0 Then
                    DgvProductos.DataSource = dt
                    ConexionLogin.ConexionBase.Close()

                Else
                    DgvProductos.DataSource = Nothing
                    ConexionLogin.ConexionBase.Close()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        BuscarProducto()
    End Sub

    Private Sub BtnHabilitar_Click(sender As Object, e As EventArgs) Handles BtnHabilitar.Click
        AbrirConeccion()

        Try
            Dim consultaAct As String = "update Producto set Estado=1 where CodProduc= @CodProduc"
            Dim ejecutar As New SqlCommand(consultaAct, ConexionBase)
            ejecutar.Parameters.AddWithValue("@CodProduc", Val(TxtCodigoProducto.Text))

            If ejecutar.ExecuteNonQuery() Then
                MessageBox.Show("Categoria habilitada con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Error al habilitar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using Adaptador As New SqlDataAdapter("SELECT Producto.CodProduc,
                        CONCAT(Producto.DescripProduc, ' ' , Producto.NombProduc) as 'Nombre Producto',
                        Producto.Descripcion as Descripción,
                        Producto.CodProv as 'Código Proveedor',
                        Producto.NombProv as 'Nombre Proveedor',
                        Producto.CodCateg as 'Código Categoría',
                        CONCAT(Producto.NombCateg, ' ' , Categoria.DescripCateg) as 'Nombre Categoría',
                        Producto.PrimerPrecio as 'Primer Precio',
                        Producto.SegundoPrecio as 'Segundo Precio',
                        Producto.TercerPrecio as 'Tercer Precio',
                        Producto.UnidadesStock as 'Unidades Stock',
                        Producto.Minimo as Minimo,
                        Producto.Maximo as Maximo,
                        case when Estado=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del producto'
                        FROM Categoria INNER JOIN
                        Producto ON Categoria.CodCateg = Producto.CodCateg
                        where Estado = 0", ConexionBase)
            Adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DgvProductos.DataSource = DatosCat



        ConexionBase.Close()
        LimpiarCajasTexto()
    End Sub

    Private Sub DgvProductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProductos.CellDoubleClick
        TxtCodigoProducto.Text = DgvProductos.CurrentRow.Cells(0).Value
        TxtNombreProducto.Text = DgvProductos.CurrentRow.Cells(1).Value
        RtxDescripcionProducto.Text = DgvProductos.CurrentRow.Cells(1).Value
        RtxDescripcionProducto2.Text = DgvProductos.CurrentRow.Cells(2).Value
        TxtCodigoProveedor.Text = DgvProductos.CurrentRow.Cells(3).Value
        TxtNombreProveedor.Text = DgvProductos.CurrentRow.Cells(4).Value
        TxtCodigoCategoria.Text = DgvProductos.CurrentRow.Cells(5).Value
        TxtNombreCategoria.Text = DgvProductos.CurrentRow.Cells(6).Value
        TxtProductosMaximos.Text = DgvProductos.CurrentRow.Cells(12).Value
        TxtProductosMinimos.Text = DgvProductos.CurrentRow.Cells(11).Value
        TxtPrimerPrecio.Text = DgvProductos.CurrentRow.Cells(7).Value
        TxtSegundoPrecio.Text = DgvProductos.CurrentRow.Cells(8).Value
        TxtTercerPrecio.Text = DgvProductos.CurrentRow.Cells(9).Value
        If ChkInhabil.Checked = True Then
            BtnEliminar.Visible = False
            BtnActualizar.Visible = False
        Else
            BtnEliminar.Visible = True
            BtnActualizar.Visible = True
        End If



    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        LimpiarCajasTexto()
        BtnActualizar.Visible = False
        BtnEliminar.Visible = False
    End Sub



    Private Sub TxtNombreProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombreProducto.KeyPress
        If (TxtNombreProducto.TextLength < 1) Then
            If Char.IsWhiteSpace(e.KeyChar) Then
                e.Handled = True
                MessageBox.Show("No se permiten espacios al principio")
            End If


        End If
    End Sub

    Private Sub RtxDescripcionProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RtxDescripcionProducto.KeyPress
        If (RtxDescripcionProducto.TextLength < 1) Then
            If Char.IsWhiteSpace(e.KeyChar) Then
                e.Handled = True
                MessageBox.Show("No se permiten espacios al principio")
            End If


        End If
    End Sub

    Private Sub btnAgg_P_Click(sender As Object, e As EventArgs) Handles btnAgg_P.Click
        Dim frm As New FrmBusquedaProveedor
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnAgg_C_Click(sender As Object, e As EventArgs) Handles btnAgg_C.Click
        Dim frm As New FrmBusquedaCategoria
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnLimpiarProv_Click(sender As Object, e As EventArgs) Handles btnLimpiarProv.Click
        TxtCodigoProveedor.Clear()
        TxtNombreProveedor.Clear()
    End Sub

    Private Sub btnLimpiarCateg_Click(sender As Object, e As EventArgs) Handles btnLimpiarCateg.Click
        TxtCodigoCategoria.Clear()
        TxtNombreCategoria.Clear()
    End Sub

    Private Sub DgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProductos.CellContentClick

    End Sub
End Class