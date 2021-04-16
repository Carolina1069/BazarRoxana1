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
        Using adaptador As New SqlDataAdapter("select CodProduc as 'Codigo del Producto', NombProduc as 'Nombre del Producto', DescripProduc as 'Descripcion del Producto', CodProv as 'Codigo del Proveedor', CodCateg as 'Codigo de la Categoria', PrimerPrecio as 'Precio #1', SegundoPrecio as 'Precio #2', TercerPrecio as 'Precio #3', UnidadesStock as 'Unidades en Stock',Minimo as 'Unidades Minimas', Maximo as 'Unidades Maximas' from Producto", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat

        conexion.Close()
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click

        txtUnidStock.Text = 0
        abrir()
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProduc as 'Codigo del Producto', NombProduc as 'Nombre del Producto', DescripProduc as 'Descripcion del Producto', CodProv as 'Codigo del Proveedor', CodCateg as 'Codigo de la Categoria', PrimerPrecio as 'Precio #1', SegundoPrecio as 'Precio #2', TercerPrecio as 'Precio #3', UnidadesStock as 'Unidades en Stock',Minimo as 'Unidades Minimas', Maximo as 'Unidades Maximas' from Producto", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat
        If txCodProd.Text = "" Or txNomProd.Text = "" Or rtxDescProd.Text = "" Or txCodProv.Text = "" Or txCodCateg.Text = "" Or txtPriPre.Text = "" Or txtSegPre.Text = "" Or txtTerPre.Text = "" Or txtUnidStock.Text = "" Or txMin.Text = "" Or txMax.Text = "" Or DGV.Rows.Count = 0 Then
            MsgBox("Hay campos vacios")
        Else

            If RegistradoProducto(txCodProd.Text) = False Then
                Dim consultaGuardar As String = "insert into Producto(CodProduc,NombProduc,DescripProduc,CodProv,CodCateg,PrimerPrecio,SegundoPrecio,TercerPrecio,UnidadesStock,Minimo,Maximo) values(@CodProduc,@NombProduc,@DescripProduc,@CodProv,@CodCateg,@PrimerPrecio,@SegundoPrecio,@TercerPrecio,@UnidadesStock,@Minimo,@Maximo)"

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
            Else
                MsgBox("El producto ya esta registrado")
            End If
        End If

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

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click


        abrir()
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProduc as 'Codigo del Producto', NombProduc as 'Nombre del Producto', DescripProduc as 'Descripcion del Producto', CodProv as 'Codigo del Proveedor', CodCateg as 'Codigo de la Categoria', PrimerPrecio as 'Precio #1', SegundoPrecio as 'Precio #2', TercerPrecio as 'Precio #3', UnidadesStock as 'Unidades en Stock',Minimo as 'Unidades Minimas', Maximo as 'Unidades Maximas' from Producto", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat
        If txCodProd.Text = "" Or txNomProd.Text = "" Or rtxDescProd.Text = "" Or txCodProv.Text = "" Or txCodCateg.Text = "" Or txtPriPre.Text = "" Or txtSegPre.Text = "" Or txtTerPre.Text = "" Or txtUnidStock.Text = "" Or txMin.Text = "" Or txMax.Text = "" Or DGV.Rows.Count = 0 Then
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


    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        abrir()

        Dim busqueda As Integer

        busqueda = InputBox("Ingrese Codigo", "Busqueda")


        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Dim query As String = "select CodProduc as 'Codigo del Producto', NombProduc as 'Nombre del Producto', DescripProduc as 'Descripcion del Producto', CodProv as 'Codigo del Proveedor', CodCateg as 'Codigo de la Categoria', PrimerPrecio as 'Precio #1', SegundoPrecio as 'Precio #2', TercerPrecio as 'Precio #3', UnidadesStock as 'Unidades en Stock',Minimo as 'Unidades Minimas', Maximo as 'Unidades Maximas' from Producto where CodProduc=" & busqueda
        Using adaptador As New SqlDataAdapter(query, conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat

    End Sub

    Private Sub txCodProv_TextChanged(sender As Object, e As EventArgs) Handles txCodProv.TextChanged

        abrir()
        Dim Recuperar As String = "select * from Proveedores where CodProv= '" & txCodProv.Text & "'"
        Dim Mostrar As SqlDataReader
        Dim Ejecutar As SqlCommand
        Ejecutar = New SqlCommand(Recuperar, conexion)
        Mostrar = Ejecutar.ExecuteReader
        Dim Estado As String
        Estado = Mostrar.Read
        If (Estado = True) Then
            txNombProv.Text = Mostrar(1)
        Else
            txNombProv.Text = ""
        End If
        Mostrar.Close()
        conexion.Close()

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

    Private Sub btActualizarTabla_Click(sender As Object, e As EventArgs) Handles btActualizarTabla.Click

        abrir()
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProduc as 'Codigo del Producto', NombProduc as 'Nombre del Producto', DescripProduc as 'Descripcion del Producto', CodProv as 'Codigo del Proveedor', CodCateg as 'Codigo de la Categoria', PrimerPrecio as 'Precio #1', SegundoPrecio as 'Precio #2', TercerPrecio as 'Precio #3', UnidadesStock as 'Unidades en Stock',Minimo as 'Unidades Minimas', Maximo as 'Unidades Maximas' from Producto", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat

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

    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs) Handles DGV.DoubleClick
        txCodProd.Text = DGV.CurrentRow.Cells(0).Value
        txNomProd.Text = DGV.CurrentRow.Cells(1).Value
        rtxDescProd.Text = DGV.CurrentRow.Cells(2).Value
        txCodProv.Text = DGV.CurrentRow.Cells(3).Value
        txCodCateg.Text = DGV.CurrentRow.Cells(4).Value
        txtPriPre.Text = DGV.CurrentRow.Cells(5).Value
        txtSegPre.Text = DGV.CurrentRow.Cells(6).Value
        txtTerPre.Text = DGV.CurrentRow.Cells(7).Value
        txtUnidStock.Text = DGV.CurrentRow.Cells(8).Value
        txMax.Text = DGV.CurrentRow.Cells(9).Value
        txMin.Text = DGV.CurrentRow.Cells(10).Value
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
End Class