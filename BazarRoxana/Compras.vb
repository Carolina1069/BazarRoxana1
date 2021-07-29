Imports System.Data.SqlClient
Public Class Compras


    Private Sub TxtCodProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodProv.KeyPress
        SoloNumeros(e)
    End Sub
    Dim TipoPago As Integer = 0
    Dim TipoTransac As Integer = 0
    Private Sub txCodProv_TextChanged(sender As Object, e As EventArgs) Handles TxtCodProv.TextChanged
        AbrirConeccion()
        Dim Recuperar As String = "select * from Proveedores where CodProv= '" & TxtCodProv.Text & "'"
        Dim Mostrar As SqlDataReader
        Dim Ejecutar As SqlCommand
        Ejecutar = New SqlCommand(Recuperar, ConexionBase)
        Mostrar = Ejecutar.ExecuteReader
        Dim Estado As String
        Estado = Mostrar.Read
        If (Estado = True) Then
            TxtNombreProveedor.Text = Mostrar(1)
        Else
            TxtNombreProveedor.Text = ""
        End If
        Mostrar.Close()
        ConexionBase.Close()
    End Sub

    Private Sub TxtCodEmple_TextChanged(sender As Object, e As EventArgs) Handles TxtCodEmple.TextChanged
        AbrirConeccion()
        Dim Recuperar As String = "select * from Empleados where CodEmple= '" & TxtCodEmple.Text & "'"
        Dim Mostrar As SqlDataReader
        Dim Ejecutar As SqlCommand
        Ejecutar = New SqlCommand(Recuperar, ConexionBase)
        Mostrar = Ejecutar.ExecuteReader
        Dim Estado As String
        Estado = Mostrar.Read
        If (Estado = True) Then
            TxtNombreEmpleado.Text = Mostrar(1)
        Else
            TxtNombreEmpleado.Text = ""
        End If
        Mostrar.Close()
        ConexionBase.Close()
    End Sub
    Private Sub TxtCodPago_TextChanged(sender As Object, e As EventArgs)
        Dim Pago As Integer

    End Sub
    Private Sub TxtCodTransa_TextChanged(sender As Object, e As EventArgs)
        Dim Tran As Integer
        AbrirConeccion()
        Dim Mostrar As SqlDataReader
        Dim Ejecutar As SqlCommand
        Mostrar = Ejecutar.ExecuteReader
        Dim Estado As String
        Estado = Mostrar.Read
        If (Estado = True) Then
            TxtTipoTransaccion.Text = Mostrar(1)
        Else
            TxtTipoTransaccion.Text = ""
        End If
        Mostrar.Close()
        ConexionBase.Close()
        MsgBox("Solo hay tres tipos de transaccion")
    End Sub

    Private Sub TxtCodProducto_TextChanged(sender As Object, e As EventArgs) Handles TxtCodProducto.TextChanged '<--- funcion que carga el producto seleccionado
        Dim Produ As Integer
        Produ = Val(TxtCodProducto.Text)
        AbrirConeccion()
        Dim Recuperar As String = "select * from Producto where CodProduc= '" & Produ & "'"
        Dim Mostrar As SqlDataReader
        Dim Ejecutar As SqlCommand
        Ejecutar = New SqlCommand(Recuperar, ConexionBase)
        Mostrar = Ejecutar.ExecuteReader
        Dim Estado As String
        Estado = Mostrar.Read
        If (Estado = True) Then
            TxtNombreProducto.Text = Mostrar(1)
            TxtArticulo.Text = Mostrar(2)
            TxtDesc.Text = Mostrar(3)
            TxtUnidades.Text = Mostrar(11)
            TxtMaximo.Text = Mostrar(13)
        Else
            TxtNombreProducto.Text = ""
            TxtUnidades.Text = ""
            TxtArticulo.Text = ""
            TxtDesc.Text = ""
            CbxPrecio.Text = ""
            TxtMaximo.Text = ""
        End If
        Mostrar.Close()
        Dim DatosUsuarios As New DataTable '<--- tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProduc, Precios from Producto unpivot ( Precios for Valor in(PrimerPrecio,SegundoPrecio, TercerPrecio) ) as P where CodProduc ='" & Produ & "'", ConexionBase)
            adaptador.Fill(DatosUsuarios)
        End Using '<--- intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        CbxPrecio.DataSource = DatosUsuarios
        CbxPrecio.DisplayMember = "Precios"
        ConexionBase.Close()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim Total As Double
        Dim Subtotal As Double
        Dim Subtotal2 As Double
        Dim SubTotal1 As Integer
        Dim Impuesto As Double
        Dim Max As Integer
        Dim Suma As Integer
        Max = Val(TxtMaximo.Text)
        Suma = (Val(TxtUnidades.Text) + Val(TxtCantidad.Text))
        If TxtCodProducto.Text = "" Or TxtNombreProducto.Text = "" Or CbxPrecio.Text = "" Or TxtUnidades.Text = "" Or TxtMaximo.Text = "" Then
            MsgBox("Porfavor realice la búsqueda del producto", MessageBoxIcon.Exclamation, "Venta")
        ElseIf TxtCantidad.Text = "" Then
            MsgBox("Porfavor ingrese la cantidad que desea del producto ya buscado", MessageBoxIcon.Exclamation, "Venta")
        ElseIf Max >= Suma Then
            Impuesto = 0.15
            SubTotal1 = (Val(CbxPrecio.Text) * Val(TxtCantidad.Text))
            Subtotal2 = SubTotal1 * Impuesto
            Subtotal = SubTotal1 + Subtotal2
            DGV.Rows.Add(TxtCodProducto.Text, TxtNombreProducto.Text, TxtArticulo.Text, TxtDesc.Text, Impuesto, TxtCantidad.Text, CbxPrecio.Text, Subtotal)
            For Each row As DataGridViewRow In DGV.Rows
                Total += Val(row.Cells(7).Value)
            Next
            TxtTotal.Text = Total.ToString
            TxtCodProducto.Clear()
            TxtNombreProducto.Clear()
            CbxPrecio.Text = ""
            TxtCantidad.Clear()
        Else
            MsgBox("Cantidad solicitada supera el Maximo del Inventario")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.DGV.Rows.Count = 0 Then
            MessageBox.Show("Por favor ingrese datos en la tabla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            DGV.Rows.Remove(DGV.CurrentRow)
            Dim Total As Single
            For Each row As DataGridViewRow In DGV.Rows
                Total -= Val(row.Cells(6).Value)
            Next
            TxtTotal.Text = -Total
        End If
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Dim Total As Integer
        AbrirConeccion()
        If TxtNumCompra.Text = "" Or TxtCodProv.Text = "" Or TxtCodEmple.Text = "" Or DGV.Rows.Count = 0 Then
            MsgBox("Hay campos vacios")
        Else
            If RegistradoCompras(TxtNumCompra.Text) = False Then
                Try
                    Dim ConsultaGuardar As String = "insert into Compras(CodProv, CodPago, CodTransa, CodEmple, FechayHora, Total) values( @CodProv, @CodPago, @CodTransa, @CodEmple, GETDATE(), @Total)"
                    Dim ejecutar As New SqlCommand(ConsultaGuardar, ConexionBase)
                    ejecutar.Parameters.AddWithValue("@CodProv", Val(TxtCodProv.Text))
                    ejecutar.Parameters.AddWithValue("@CodPago", Val(TipoPago))
                    ejecutar.Parameters.AddWithValue("@CodTransa", Val(TipoTransac))
                    ejecutar.Parameters.AddWithValue("@CodEmple", Val(TxtCodEmple.Text))
                    ejecutar.Parameters.AddWithValue("@Total", Val(TxtTotal.Text))
                    ejecutar.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("error insert" + ex.ToString())
                End Try
                Dim DatosFacturaD As String = "insert into DetalleCompra(NumCompra,CodProduc , NombProduc,Articulo,Descripcion, Impuesto , CantProduc, PrecioProduc, SubTotal) values(@NumCompra, @CodProduc , @NombProduc,@Articulo,@Descripcion, @Impuesto , @CantProduc, @PrecioProduc,  @SubTotal)"
                Dim RegistrarD As New SqlCommand(DatosFacturaD, ConexionBase)
                Dim fila As DataGridViewRow = New DataGridViewRow()
                For Each fila In DGV.Rows
                    RegistrarD.Parameters.Clear()
                    RegistrarD.Parameters.AddWithValue("@NumCompra", Val(TxtNumCompra.Text))
                    RegistrarD.Parameters.AddWithValue("@CodProduc", fila.Cells("CodProduc").Value)
                    RegistrarD.Parameters.AddWithValue("@NombProduc", fila.Cells("NombProduc").Value)
                    RegistrarD.Parameters.AddWithValue("@Articulo", fila.Cells("Articulo").Value)
                    RegistrarD.Parameters.AddWithValue("@Descripcion", fila.Cells("Descripcion").Value)
                    RegistrarD.Parameters.AddWithValue("@Impuesto", fila.Cells("Impuesto").Value)
                    RegistrarD.Parameters.AddWithValue("@CantProduc", fila.Cells("CantProduc").Value)
                    RegistrarD.Parameters.AddWithValue("@PrecioProduc", fila.Cells("PrecioProduc").Value)
                    RegistrarD.Parameters.AddWithValue("@SubTotal", fila.Cells("SubTotal").Value)
                    RegistrarD.ExecuteNonQuery()
                    Dim DatosFacturaA As String = "update Producto set UnidadesStock += @UnidadesStock where CodProduc = @CodProduc"
                    Dim RegistrarA As New SqlCommand(DatosFacturaA, ConexionBase)
                    RegistrarA.Parameters.AddWithValue("@UnidadesStock", fila.Cells("CantProduc").Value)
                    RegistrarA.Parameters.AddWithValue("@CodProduc", fila.Cells("CodProduc").Value)
                    RegistrarA.ExecuteNonQuery()

                Next
                CodUltmaVenta = CodUVenta()
                TxtNumCompra.Text = codUltmaVenta
                MsgBox("Registro de venta Exitoso!")
                ConexionBase.Close()
                DGV.Rows.Clear()
                TxtCantidad.Clear()
                TxtNombreProveedor.Clear()
                TxtCodProv.Clear()
                TxtCodProducto.Clear()
                TxtTotal.Clear()
                CbxPrecio.Text = ""
                TxtNombreProveedor.Clear()
                TxtNombreProducto.Clear()
                Total = 0
            Else
                MsgBox("La compra ya esta registrada")
            End If
        End If

    End Sub

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

    Private Sub txNumCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumCompra.KeyPress
        SoloNumeros(e) '<-- Llamado de la funcion que solo permite el ingreso de caracteres tipo numerico
    End Sub

    Private Sub TxtCodPago_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e) '<-- Llamado de la funcion que solo permite el ingreso de caracteres tipo numerico
    End Sub

    Private Sub TxtCodTransa_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e) '<-- Llamado de la funcion que solo permite el ingreso de caracteres tipo numerico
    End Sub

    Private Sub TxtCodProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodProducto.KeyPress
        SoloNumeros(e) '<-- Llamado de la funcion que solo permite el ingreso de caracteres tipo numerico
    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        SoloNumeros(e) '<-- Llamado de la funcion que solo permite el ingreso de caracteres tipo numerico
    End Sub

    Private Sub TxtCodEmple_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodEmple.KeyPress
        SoloNumeros(e) '<-- Llamado de la funcion que solo permite el ingreso de caracteres tipo numerico
    End Sub

    Public Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbTipoPago.SelectedIndex = 0
        CmbTipoTransac.SelectedIndex = 0
        TxtCodEmple.Text = CodUser
        TxtCodProv.Text = CodProv
        Label5.Visible = False
        Label4.Visible = False
        TxtTipoPago.Visible = False
        TxtTipoTransaccion.Visible = False
        CodUltmaVenta = CodUVenta()
        If CodUltmaVenta = "0" Then
            TxtNumCompra.Text = "1"
        Else
            TxtNumCompra.Text = CodUltmaVenta
        End If
    End Sub
    Public Sub setCodProv()
        TxtCodProv.Text = CodProv
    End Sub
    Private Sub cmbTipoPago_TabIndexChanged(sender As Object, e As EventArgs) Handles CmbTipoPago.TabIndexChanged

    End Sub

    Private Sub cmbTipoPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipoPago.SelectedIndexChanged
        Dim Pago As Integer
        TipoPago = CmbTipoPago.SelectedIndex + 1
        If TipoPago >= 1 And TipoPago <= 2 Then
            AbrirConeccion()
            Dim Recuperar As String = "select * from FormasPago where CodPago= '" & TipoPago & "'"
            Dim Mostrar As SqlDataReader
            Dim Ejecutar As SqlCommand
            Ejecutar = New SqlCommand(Recuperar, ConexionBase)
            Mostrar = Ejecutar.ExecuteReader
            Dim Estado As String
            Estado = Mostrar.Read
            If (Estado = True) Then
                TxtTipoPago.Text = Mostrar(1)
            Else
                TxtTipoPago.Text = ""
            End If
            Mostrar.Close()
            ConexionBase.Close()
        Else
            MsgBox("Solo hay dos tipos de pago")
        End If
    End Sub

    Private Sub cmbTipoTransac_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipoTransac.SelectedIndexChanged
        Dim Tran As Integer

        TipoTransac = CmbTipoTransac.SelectedIndex + 1
        If tipoTransac >= 1 And tipoTransac <= 3 Then
            AbrirConeccion()
            Dim Recuperar As String = "select * from Transacciones where CodTransa= '" & tipoTransac & "'"
            Dim Mostrar As SqlDataReader
            Dim Ejecutar As SqlCommand
            Ejecutar = New SqlCommand(Recuperar, ConexionBase)
            Mostrar = Ejecutar.ExecuteReader
            Dim Estado As String
            Estado = Mostrar.Read
            If (Estado = True) Then
                TxtTipoTransaccion.Text = Mostrar(1)
            Else
                TxtTipoTransaccion.Text = ""
            End If
            Mostrar.Close()
            ConexionBase.Close()
        Else
            MsgBox("Solo hay tres tipos de transaccion")
        End If
    End Sub

    Private Sub btnsearchProv_Click(sender As Object, e As EventArgs) Handles btnsearchProv.Click
        AddOwnedForm(viewProveedor) '<-- Ejecuta una llamada de la pantalla cliente con el metodo padre hijo  
        viewProveedor.Show()
    End Sub

    Private Sub btnBuscProd_Click(sender As Object, e As EventArgs) Handles btnBuscProd.Click
        ProductosValidar = 2
        Dim frm As New BuscarProducto '<-- Ejecuta una llamada de la pantalla producto con el metodo padre hijo  
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub
End Class