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

    Private Sub txCodProd_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub txCodProv_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub txtPriPre_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub txtSegPre_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub txtTerPre_KeyPress(sender As Object, e As KeyPressEventArgs)

        SoloNumeros(e)

    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("SELECT [CodProduc] as 'Código producto'
               ,[NombProduc] as 'Nombre producto'
              ,[DescripProduc] as 'Descripción'
              ,[CodProv] as 'Código proveedoor'
              ,[NombProv] as 'Nombre proveedor'
              ,[CodCateg] as 'Código categoría'
              ,[NombCateg] as 'Nombre categoría'
              ,[PrimerPrecio] as 'Primero precio'
              ,[SegundoPrecio] as ' Segundo precio'
              ,[TercerPrecio] as 'Tercer precio'
              ,[UnidadesStock] as 'Unidades en stock'
              ,[Minimo] as Mínimo
              ,[Maximo] as Máximo,       
	          case when Estado=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del producto' 
              FROM [dbo].[Producto] 
              where Estado = 1", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProducto.DataSource = DatosCat
        txCodCateg.ReadOnly = True
        txCodProv.ReadOnly = True
        txNombCateg.ReadOnly = True
        txNombProv.ReadOnly = True

        conexion.Close()
        btnHabilitar.Visible = False
        btnEliminar.Visible = False
        btnActualizar.Visible = False
    End Sub



    Private Sub btActualizar_Click(sender As Object, e As EventArgs)


        abrir()
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProduc as 'Codigo del Producto', NombProduc as 'Nombre del Producto', DescripProduc as 'Descripcion del Producto', CodProv as 'Codigo del Proveedor', CodCateg as 'Codigo de la Categoria', PrimerPrecio as 'Precio #1', SegundoPrecio as 'Precio #2', TercerPrecio as 'Precio #3', UnidadesStock as 'Unidades en Stock',Minimo as 'Unidades Minimas', Maximo as 'Unidades Maximas' from Producto", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProducto.DataSource = DatosCat
        If txCodProd.Text = "" Or txNomProd.Text = "" Or rtxDescProd.Text = "" Or txCodProv.Text = "" Or txCodCateg.Text = "" Or txtPriPre.Text = "" Or txtSegPre.Text = "" Or txtTerPre.Text = "" Or txtUnidStock.Text = "" Or txMin.Text = "" Or txMax.Text = "" Or DGVProducto.Rows.Count = 0 Then
            MsgBox("Hay campos vacios")
        Else
            Dim consultaGuardar As String = "Update  Producto set  NombProduc=@NombProduc,DescripProduc=@DescripProduc,CodProv=@CodProv,CodCateg=@CodCateg,PrimerPrecio=@PrimerPrecio,SegundoPrecio=@SegundoPrecio,TercerPrecio=@TercerPrecio,UnidadesStock=@UnidadesStock,Minimo=@Minimo,Maximo=@Maximo Where CodProduc=@CodProduc"
            Dim ejecutar As New SqlCommand(consultaGuardar, conexion)
            ejecutar.Parameters.AddWithValue("@CodProduc", Val(txCodProd.Text))
            ejecutar.Parameters.AddWithValue("@NombProduc", (txNomProd.Text))
            ejecutar.Parameters.AddWithValue("@DescripProduc", (rtxDescProd.Text))
            ejecutar.Parameters.AddWithValue("@CodProv", Val(txCodProv.Text))
            ejecutar.Parameters.AddWithValue("@CodCateg", Val(txCodCateg.Text))
            ejecutar.Parameters.AddWithValue("@PrimerPrecio", Val(txtPriPre.Text))
            ejecutar.Parameters.AddWithValue("@SegundoPrecio", Val(txtSegPre.Text))
            ejecutar.Parameters.AddWithValue("@TercerPrecio", Val(txtTerPre.Text))
            ejecutar.Parameters.AddWithValue("@UnidadesStock", Val(txtUnidStock.Text))
            ejecutar.Parameters.AddWithValue("@Minimo", Val(txMin.Text))
            ejecutar.Parameters.AddWithValue("@Maximo", Val(txMax.Text))


            ejecutar.ExecuteNonQuery()

        End If
        conexion.Close()



    End Sub


    Private Sub btBuscar_Click(sender As Object, e As EventArgs)
        abrir()

        Dim busqueda As Integer

        busqueda = InputBox("Ingrese Codigo", "Busqueda")


        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Dim query As String = "select CodProduc as 'Codigo del Producto', NombProduc as 'Nombre del Producto', DescripProduc as 'Descripcion del Producto', CodProv as 'Codigo del Proveedor', CodCateg as 'Codigo de la Categoria', PrimerPrecio as 'Precio #1', SegundoPrecio as 'Precio #2', TercerPrecio as 'Precio #3', UnidadesStock as 'Unidades en Stock',Minimo as 'Unidades Minimas', Maximo as 'Unidades Maximas' from Producto where CodProduc=" & busqueda
        Using adaptador As New SqlDataAdapter(query, conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProducto.DataSource = DatosCat

    End Sub

    Private Sub txCodProv_TextChanged(sender As Object, e As EventArgs) Handles txCodProv.TextChanged



    End Sub

    Private Sub txCodCateg_TextChanged(sender As Object, e As EventArgs) Handles txCodCateg.TextChanged
        abrir()
        Dim Recuperar As String = "select * from Categoria where CodCateg= '" & txCodCateg.Text & "'"
        Dim Mostrar As SqlDataReader
        Dim Ejecutar As SqlCommand
        Ejecutar = New SqlCommand(Recuperar, conexion)
        Mostrar = Ejecutar.ExecuteReader
        Dim Estado As String
        Estado = Mostrar.Read
        If (Estado = True) Then
            txNombCateg.Text = Mostrar(1)
        Else
            txNombCateg.Text = ""
        End If
        Mostrar.Close()
        conexion.Close()
    End Sub

    Private Sub btActualizarTabla_Click(sender As Object, e As EventArgs)

        abrir()
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProduc as 'Codigo del Producto', NombProduc as 'Nombre del Producto', DescripProduc as 'Descripcion del Producto', CodProv as 'Codigo del Proveedor', CodCateg as 'Codigo de la Categoria', PrimerPrecio as 'Precio #1', SegundoPrecio as 'Precio #2', TercerPrecio as 'Precio #3', UnidadesStock as 'Unidades en Stock',Minimo as 'Unidades Minimas', Maximo as 'Unidades Maximas' from Producto", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProducto.DataSource = DatosCat

        conexion.Close()
        txCodProd.Clear()
        txNomProd.Clear()
        rtxDescProd.Clear()
        txCodProv.Clear()
        txCodCateg.Clear()
        txtPriPre.Clear()
        txtSegPre.Clear()
        txtTerPre.Clear()
        txtUnidStock.Clear()
        txMax.Clear()
        txMin.Clear()

    End Sub

    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs)
        txCodProd.Text = DGVProducto.CurrentRow.Cells(0).Value
        txNomProd.Text = DGVProducto.CurrentRow.Cells(1).Value
        rtxDescProd.Text = DGVProducto.CurrentRow.Cells(2).Value
        txCodProv.Text = DGVProducto.CurrentRow.Cells(3).Value
        txCodCateg.Text = DGVProducto.CurrentRow.Cells(4).Value
        txtPriPre.Text = DGVProducto.CurrentRow.Cells(5).Value
        txtSegPre.Text = DGVProducto.CurrentRow.Cells(6).Value
        txtTerPre.Text = DGVProducto.CurrentRow.Cells(7).Value
        txtUnidStock.Text = DGVProducto.CurrentRow.Cells(8).Value
        txMax.Text = DGVProducto.CurrentRow.Cells(9).Value
        txMin.Text = DGVProducto.CurrentRow.Cells(10).Value
    End Sub

    Private Sub txCodProv_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txCodProv.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txCodCateg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCodCateg.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txCodProd_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txCodProd.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtPriPre_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtPriPre.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtUnidStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnidStock.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtSegPre_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtSegPre.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txMax.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtTerPre_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtTerPre.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txMin.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtTerPre_TextChanged(sender As Object, e As EventArgs) Handles txtTerPre.TextChanged

    End Sub

    Private Sub lbSegPre_Click(sender As Object, e As EventArgs) Handles lbSegPre.Click

    End Sub

    Private Sub lbCodCateg_Click(sender As Object, e As EventArgs) Handles lbCodCateg.Click

    End Sub

    Private Sub lbCodProv_Click(sender As Object, e As EventArgs) Handles lbCodProv.Click

    End Sub

    Private Sub txCodProd_TextChanged(sender As Object, e As EventArgs) Handles txCodProd.TextChanged

    End Sub

    Private Sub txCodProd_Validating(sender As Object, e As CancelEventArgs) Handles txCodProd.Validating

    End Sub

    Private Sub txNomProd_TextChanged(sender As Object, e As EventArgs) Handles txNomProd.TextChanged


    End Sub

    Private Sub txNomProd_Validating(sender As Object, e As CancelEventArgs) Handles txNomProd.Validating
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

    Private Sub rtxDescProd_TextChanged(sender As Object, e As EventArgs) Handles rtxDescProd.TextChanged

    End Sub

    Private Sub txtUnidStock_TextChanged(sender As Object, e As EventArgs) Handles txtUnidStock.TextChanged

    End Sub

    Private Sub txMax_TextChanged(sender As Object, e As EventArgs) Handles txMax.TextChanged

    End Sub

    Private Sub rtxDescProd_Validating(sender As Object, e As CancelEventArgs) Handles rtxDescProd.Validating
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

    Private Sub txtUnidStock_Validating(sender As Object, e As CancelEventArgs) Handles txtUnidStock.Validating
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

    Private Sub txMax_Validating(sender As Object, e As CancelEventArgs) Handles txMax.Validating
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

    Private Sub txMin_TextChanged(sender As Object, e As EventArgs) Handles txMin.TextChanged

    End Sub

    Private Sub txMin_Validating(sender As Object, e As CancelEventArgs) Handles txMin.Validating
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

    Private Sub txCodProv_Validating(sender As Object, e As CancelEventArgs) Handles txCodProv.Validating
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

    Private Sub txCodCateg_Validating(sender As Object, e As CancelEventArgs) Handles txCodCateg.Validating
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

    Private Sub txNombProv_TextChanged(sender As Object, e As EventArgs) Handles txNombProv.TextChanged

    End Sub

    Private Sub txNombProv_Validating(sender As Object, e As CancelEventArgs) Handles txNombProv.Validating
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

    Private Sub txNombCateg_TextChanged(sender As Object, e As EventArgs) Handles txNombCateg.TextChanged

    End Sub

    Private Sub txNombCateg_Validating(sender As Object, e As CancelEventArgs) Handles txNombCateg.Validating
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

    Private Sub txtPriPre_TextChanged(sender As Object, e As EventArgs) Handles txtPriPre.TextChanged

    End Sub

    Private Sub txtPriPre_Validating(sender As Object, e As CancelEventArgs) Handles txtPriPre.Validating
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

    Private Sub txtSegPre_TextChanged(sender As Object, e As EventArgs) Handles txtSegPre.TextChanged

    End Sub

    Private Sub txtTerPre_Validating(sender As Object, e As CancelEventArgs) Handles txtTerPre.Validating
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

    Private Sub txtSegPre_Validating(sender As Object, e As CancelEventArgs) Handles txtSegPre.Validating
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

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Public Sub Limpia()
        Try

            txCodProd.Clear()
            txNomProd.Clear()
            rtxDescProd.Clear()
            txCodProv.Clear()
            txNombProv.Clear()
            txCodCateg.Clear()
            txNombCateg.Clear()
            txtPriPre.Clear()
            txtSegPre.Clear()
            txtTerPre.Clear()
            txtUnidStock.Clear()
            txMax.Clear()
            txMin.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        abrir()

        If txCodProd.Text = "" Then
            MsgBox("Hay campos vacios")
        Else
            Dim consultaElim As String = "Update Producto set Estado=0   where CodProduc= @CodProduc"
            Dim ejecutar As New SqlCommand(consultaElim, conexion)
            ejecutar.Parameters.AddWithValue("@CodProduc", Val(txCodProd.Text))
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
        btnEliminar.Visible = False
        btnActualizar.Visible = False

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("SELECT [CodProduc] as 'Código producto'
               ,[NombProduc] as 'Nombre producto'
              ,[DescripProduc] as 'Descripción'
              ,[CodProv] as 'Código proveedoor'
              ,[NombProv] as 'Nombre proveedor'
              ,[CodCateg] as 'Código categoría'
              ,[NombCateg] as 'Nombre categoría'
              ,[PrimerPrecio] as 'Primero precio'
              ,[SegundoPrecio] as ' Segundo precio'
              ,[TercerPrecio] as 'Tercer precio'
              ,[UnidadesStock] as 'Unidades en stock'
              ,[Minimo] as Mínimo
              ,[Maximo] as Máximo,       
	          case when Estado=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del producto' 
              FROM [dbo].[Producto] 
              where Estado = 1", conexion)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DGVProducto.DataSource = DatosEmp
        conexion.Close()
        Limpia()



    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim codprod As Integer, NomProd As String, descripcion As String, Codprov As Integer, NombProv As String
        Dim CodCateg As Integer, NombCateg As String, PrimerPrecio As Integer, SegundoPrecio As Integer
        Dim TercerPrecio As Integer, UnidadesStock As Integer, Minimo As Integer, maximo As Integer


        If txNomProd.Text = "" Or rtxDescProd.Text = "" Or txtUnidStock.Text = "" Or txMax.Text = "" Or txMin.Text = "" Or txCodProv.Text = "" Or txNombProv.Text = "" Or txCodCateg.Text = "" Or txNombCateg.Text = "" Or txtPriPre.Text = "" Or txtSegPre.Text = "" Or txtTerPre.Text = "" Then
            MsgBox("Hay campos vacios")

        Else
            Try
                codprod = Val(txCodProd.Text)
                NomProd = txNomProd.Text
                descripcion = rtxDescProd.Text
                Codprov = txCodProv.Text
                NombProv = txNombProv.Text
                CodCateg = Val(txCodCateg.Text)
                NombCateg = txNombCateg.Text
                PrimerPrecio = Val(txtPriPre.Text)
                SegundoPrecio = Val(txtSegPre.Text)
                TercerPrecio = Val(txtTerPre.Text)
                UnidadesStock = Val(txtUnidStock.Text)
                maximo = txMax.Text
                Minimo = txMin.Text

                If (ConexionLogin.ActualizarProducto(codprod, NomProd, descripcion, Codprov, NombProv, CodCateg, NombCateg, PrimerPrecio, SegundoPrecio, TercerPrecio, UnidadesStock, Minimo, maximo)) Then
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
        btnActualizar.Visible = False
        btnEliminar.Visible = False
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("SELECT [CodProduc] as 'Código producto'
               ,[NombProduc] as 'Nombre producto'
              ,[DescripProduc] as 'Descripción'
              ,[CodProv] as 'Código proveedoor'
              ,[NombProv] as 'Nombre proveedor'
              ,[CodCateg] as 'Código categoría'
              ,[NombCateg] as 'Nombre categoría'
              ,[PrimerPrecio] as 'Primero precio'
              ,[SegundoPrecio] as ' Segundo precio'
              ,[TercerPrecio] as 'Tercer precio'
              ,[UnidadesStock] as 'Unidades en stock'
              ,[Minimo] as Mínimo
              ,[Maximo] as Máximo,       
	          case when Estado=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del producto' 
              FROM [dbo].[Producto] 
              where Estado = 1", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DGVProducto.DataSource = DatosCat

        conexion.Close()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        abrir()
        If txNomProd.Text = "" Or rtxDescProd.Text = "" Or txtUnidStock.Text = "" Or txMax.Text = "" Or txMin.Text = "" Or txCodProv.Text = "" Or txNombProv.Text = "" Or txCodCateg.Text = "" Or txNombCateg.Text = "" Or txtPriPre.Text = "" Or txtSegPre.Text = "" Or txtTerPre.Text = "" Then
            MsgBox("Hay campos vacios")


        Else
            If (txNomProd.TextLength < 2) Then
                MessageBox.Show("Debe ingresar como minimo 2 caracteres")


            ElseIf (rtxDescProd.TextLength < 2) Then
                MessageBox.Show("Debe ingresar como minimo 2 caracteres")

            Else

                If RegistradoProducto(txNomProd.Text) = False Then

                    Dim consultaGuardar As String = "INSERT INTO [dbo].[Producto]
           ([NombProduc]
           ,[DescripProduc]
           ,[CodProv]
           ,[NombProv]
           ,[CodCateg]
           ,[NombCateg]
           ,[PrimerPrecio]
           ,[SegundoPrecio]
           ,[TercerPrecio]
           ,[UnidadesStock]
           ,[Minimo]
           ,[Maximo]
           ,[Estado])
     VALUES
           (@NombProduc,
           @DescripProduc
           ,@CodProv
		   ,@NombProv
           ,@CodCateg
		   ,@NombCateg
           ,@PrimerPrecio
           ,@SegundoPrecio
           ,@TercerPrecio
           ,@UnidadesStock
           ,@Minimo
           ,@Maximo
           ,1)"
                    Dim ejecutar As New SqlCommand(consultaGuardar, conexion)
                    ejecutar.Parameters.AddWithValue("@NombProduc", (txNomProd.Text))
                    ejecutar.Parameters.AddWithValue("@DescripProduc", (rtxDescProd.Text))
                    ejecutar.Parameters.AddWithValue("@CodProv", (txCodProv.Text))
                    ejecutar.Parameters.AddWithValue("@NombProv", (txNombProv.Text))
                    ejecutar.Parameters.AddWithValue("@CodCateg", (txCodCateg.Text))
                    ejecutar.Parameters.AddWithValue("@NombCateg", (txNombCateg.Text))
                    ejecutar.Parameters.AddWithValue("@PrimerPrecio", (txtPriPre.Text))
                    ejecutar.Parameters.AddWithValue("@SegundoPrecio", (txtSegPre.Text))
                    ejecutar.Parameters.AddWithValue("@TercerPrecio", (txtTerPre.Text))
                    ejecutar.Parameters.AddWithValue("@UnidadesStock", (txtUnidStock.Text))
                    ejecutar.Parameters.AddWithValue("@Minimo", (txMin.Text))
                    ejecutar.Parameters.AddWithValue("@Maximo", (txMax.Text))
                    If ejecutar.ExecuteNonQuery() Then
                        MessageBox.Show("Producto insertado con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        MessageBox.Show("Error al insertar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("El registro ya existe")
                End If
            End If
        End If

        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("SELECT [CodProduc] as 'Código producto'
               ,[NombProduc] as 'Nombre producto'
              ,[DescripProduc] as 'Descripción'
              ,[CodProv] as 'Código proveedoor'
              ,[NombProv] as 'Nombre proveedor'
              ,[CodCateg] as 'Código categoría'
              ,[NombCateg] as 'Nombre categoría'
              ,[PrimerPrecio] as 'Primero precio'
              ,[SegundoPrecio] as ' Segundo precio'
              ,[TercerPrecio] as 'Tercer precio'
              ,[UnidadesStock] as 'Unidades en stock'
              ,[Minimo] as Mínimo
              ,[Maximo] as Máximo,       
	          case when Estado=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del producto' 
              FROM [dbo].[Producto] 
              where Estado = 1", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DGVProducto.DataSource = DatosCat
        conexion.Close()





    End Sub

    Private Sub btnActTabla_Click(sender As Object, e As EventArgs)
        abrir()
        chkInhabil.Checked = False
        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodEmple as 'Codigo del empleado', NombEmple as 'Nombre del empleado', Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", conexion)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProducto.DataSource = DatosEmp
        conexion.Close()
    End Sub

    Private Sub chkInhabil_CheckedChanged(sender As Object, e As EventArgs) Handles chkInhabil.CheckedChanged

        abrir()

        If chkInhabil.Checked = True Then

            Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("SELECT [CodProduc] as 'Código producto'
               ,[NombProduc] as 'Nombre producto'
              ,[DescripProduc] as 'Descripción'
              ,[CodProv] as 'Código proveedoor'
              ,[NombProv] as 'Nombre proveedor'
              ,[CodCateg] as 'Código categoría'
              ,[NombCateg] as 'Nombre categoría'
              ,[PrimerPrecio] as 'Primero precio'
              ,[SegundoPrecio] as ' Segundo precio'
              ,[TercerPrecio] as 'Tercer precio'
              ,[UnidadesStock] as 'Unidades en stock'
              ,[Minimo] as Mínimo
              ,[Maximo] as Máximo,       
	          case when Estado=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del producto' 
              FROM [dbo].[Producto] 
              where Estado = 0", conexion)
                adaptador.Fill(DatosCat)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGVProducto.DataSource = DatosCat
            btnGuardar.Visible = False
            btnActualizar.Visible = False
            btnEliminar.Visible = False
            btnHabilitar.Visible = True
        Else

            Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("SELECT [CodProduc] as 'Código producto'
               ,[NombProduc] as 'Nombre producto'
              ,[DescripProduc] as 'Descripción'
              ,[CodProv] as 'Código proveedoor'
              ,[NombProv] as 'Nombre proveedor'
              ,[CodCateg] as 'Código categoría'
              ,[NombCateg] as 'Nombre categoría'
              ,[PrimerPrecio] as 'Primero precio'
              ,[SegundoPrecio] as ' Segundo precio'
              ,[TercerPrecio] as 'Tercer precio'
              ,[UnidadesStock] as 'Unidades en stock'
              ,[Minimo] as Mínimo
              ,[Maximo] as Máximo,       
	          case when Estado=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del producto' 
              FROM [dbo].[Producto] 
              where Estado = 1", conexion)
                adaptador.Fill(DatosCat)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGVProducto.DataSource = DatosCat
            btnGuardar.Visible = True
            btnActualizar.Visible = False
            btnEliminar.Visible = False
            btnHabilitar.Visible = False

        End If
        conexion.Close()

    End Sub

    Private Sub LbContador7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LbContador6_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ocultar_columnas()
        DGVProducto.Columns(1).Visible = False
    End Sub
    Private Sub buscar()
        Dim dt As New DataTable()
        Dim dato As String

        Try
            If chkInhabil.Checked = True Then
                dato = TxtBusqueda.Text
                dt = ConexionLogin.buscarProductI(dato)

                If dt.Rows.Count <> 0 Then
                    DGVProducto.DataSource = dt
                    ConexionLogin.conexion.Close()

                Else
                    DGVProducto.DataSource = Nothing
                    ConexionLogin.conexion.Close()
                End If

            Else
                dato = TxtBusqueda.Text
                dt = ConexionLogin.buscarProductH(dato)

                If dt.Rows.Count <> 0 Then
                    DGVProducto.DataSource = dt
                    ConexionLogin.conexion.Close()

                Else
                    DGVProducto.DataSource = Nothing
                    ConexionLogin.conexion.Close()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged

        buscar()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub DGV_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProducto.CellContentClick

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

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnHabilitar_Click(sender As Object, e As EventArgs) Handles btnHabilitar.Click
        abrir()

        Try
            Dim consultaAct As String = "update Producto set Estado=1 where CodProduc= @CodProduc"
            Dim ejecutar As New SqlCommand(consultaAct, conexion)
            ejecutar.Parameters.AddWithValue("@CodProduc", Val(txCodProd.Text))

            If ejecutar.ExecuteNonQuery() Then
                MessageBox.Show("Categoria habilitada con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Error al habilitar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("SELECT [CodProduc] as 'Código producto'
               ,[NombProduc] as 'Nombre producto'
              ,[DescripProduc] as 'Descripción'
              ,[CodProv] as 'Código proveedoor'
              ,[NombProv] as 'Nombre proveedor'
              ,[CodCateg] as 'Código categoría'
              ,[NombCateg] as 'Nombre categoría'
              ,[PrimerPrecio] as 'Primero precio'
              ,[SegundoPrecio] as ' Segundo precio'
              ,[TercerPrecio] as 'Tercer precio'
              ,[UnidadesStock] as 'Unidades en stock'
              ,[Minimo] as Mínimo
              ,[Maximo] as Máximo,       
	          case when Estado=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del producto' 
              FROM [dbo].[Producto] 
              where Estado = 0", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DGVProducto.DataSource = DatosCat



        conexion.Close()
        Limpia()
    End Sub

    Private Sub DGVProducto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProducto.CellDoubleClick
        txCodProd.Text = DGVProducto.CurrentRow.Cells(0).Value
        txNomProd.Text = DGVProducto.CurrentRow.Cells(1).Value
        rtxDescProd.Text = DGVProducto.CurrentRow.Cells(2).Value
        txCodProv.Text = DGVProducto.CurrentRow.Cells(3).Value
        txNombProv.Text = DGVProducto.CurrentRow.Cells(4).Value
        txCodCateg.Text = DGVProducto.CurrentRow.Cells(5).Value
        txNombCateg.Text = DGVProducto.CurrentRow.Cells(6).Value
        txMax.Text = DGVProducto.CurrentRow.Cells(12).Value
        txMin.Text = DGVProducto.CurrentRow.Cells(11).Value
        txtUnidStock.Text = DGVProducto.CurrentRow.Cells(10).Value
        txtPriPre.Text = DGVProducto.CurrentRow.Cells(7).Value
        txtSegPre.Text = DGVProducto.CurrentRow.Cells(8).Value
        txtTerPre.Text = DGVProducto.CurrentRow.Cells(9).Value
        If chkInhabil.Checked = True Then
            btnEliminar.Visible = False
            btnActualizar.Visible = False
        Else
            btnEliminar.Visible = True
            btnActualizar.Visible = True
        End If
        txtUnidStock.Enabled = False



    End Sub

    Private Sub lbCodigoCli_Click(sender As Object, e As EventArgs) Handles lbCodigoCli.Click

    End Sub

    Private Sub btnlimpiaf_Click(sender As Object, e As EventArgs) Handles btnlimpiaf.Click
        Limpia()
        txtUnidStock.Enabled = True
    End Sub

    Private Sub DGVProducto_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProducto.CellEndEdit

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLimpiarProv.Click
        txCodProv.Clear()
        txNombProv.Clear()

    End Sub

    Private Sub btnLimpiarCateg_Click(sender As Object, e As EventArgs) Handles btnLimpiarCateg.Click
        txCodCateg.Clear()
        txNombCateg.Clear()
    End Sub
End Class