Imports System.Data.SqlClient
Public Class Ventas


    Private Sub TxtCodProducto_TextChanged(sender As Object, e As EventArgs) Handles TxtCodigoProducto.TextChanged
        AbrirConeccion()
        Dim Produ As Integer
        Produ = Val(TxtCodigoProducto.Text)

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
            TxtDescripcion.Text = Mostrar(3)
            TxtUnidades.Text = Mostrar(11)
            TxtUnidadesMinimas.Text = Mostrar(12)
        Else
            TxtNombreProducto.Text = ""
            TxtArticulo.Text = ""
            TxtDescripcion.Text = ""
            TxtUnidades.Text = ""
            CbxPrecio.Text = ""
            TxtUnidadesMinimas.Text = ""
        End If
        Mostrar.Close()

        AbrirConeccion()

        Dim DATOSusuarios As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProduc, Precios from Producto unpivot ( Precios for Valor in(PrimerPrecio,SegundoPrecio, TercerPrecio) ) as P where CodProduc ='" & produ & "'", ConexionBase)
            adaptador.Fill(DATOSusuarios)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        CbxPrecio.DataSource = DATOSusuarios
        CbxPrecio.DisplayMember = "Precios"

        ConexionBase.Close()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        Dim Total As Double
        Dim Subtotal As Double
        Dim Subtotal2 As Double
        Dim SubTotal1 As Integer
        Dim Impuesto As Double
        Impuesto = 0.15

        Dim Cantidad As Integer
        Dim UnidadStock As Integer

        Cantidad = Val(TxtCantidad.Text)
        UnidadStock = Val(TxtUnidades.Text)

        If TxtCodigoProducto.Text = "" Or TxtNombreProducto.Text = "" Or CbxPrecio.Text = "" Or TxtUnidades.Text = "" Or TxtUnidadesMinimas.Text = "" Then

            MsgBox("Porfavor realice la búsqueda del producto", MessageBoxIcon.Exclamation, "Venta")

        ElseIf TxtCantidad.Text = "" Then

            MsgBox("Porfavor ingrese la cantidad que desea del producto ya buscado", MessageBoxIcon.Exclamation, "Venta")

        ElseIf Cantidad <= UnidadStock Then

            SubTotal1 = (Val(CbxPrecio.Text) * Val(TxtCantidad.Text))
            Subtotal2 = SubTotal1 * Impuesto
            Subtotal = SubTotal1 + Subtotal2
            DGV.Rows.Add(TxtCodigoProducto.Text, TxtNombreProducto.Text, TxtArticulo.Text, TxtDescripcion.Text, Impuesto, TxtCantidad.Text, CbxPrecio.Text, Subtotal)
            For Each row As DataGridViewRow In DGV.Rows
                Total += Val(row.Cells(7).Value)
            Next
            TxtTotal.Text = Total.ToString
            TxtCodigoProducto.Clear()
            TxtNombreProducto.Clear()
            TxtArticulo.Clear()
            TxtCantidad.Clear()
            CbxPrecio.Text = ""
            TxtCantidad.Clear()
            TxtUnidades.Clear()
            TxtUnidadesMinimas.Clear()

        Else

            MsgBox("La cantidad solicitada supera las unidades en Inventario", MessageBoxIcon.Warning, "Advertencia")

        End If


    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If Me.DGV.Rows.Count = 0 Then
            MessageBox.Show("Por favor ingrese datos en la tabla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            DGV.Rows.Remove(DGV.CurrentRow)
            Dim Total As Single
            For Each row As DataGridViewRow In DGV.Rows
                Total -= Val(row.Cells(7).Value)
            Next
            TxtTotal.Text = -Total
        End If

    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim Total As Integer

        AbrirConeccion() '<-- Llamado de la funcion 
        Dim TipoPago As Integer
        Dim TipoTransaccion As Integer

        If TxtCodCli.Text = "" Or CbxTipoPago.Text = "" Or CbxTipoTransac.Text = "" Or TxtCodEmple.Text = "" Or DGV.Rows.Count = 0 Then
            MsgBox("Hay campos vacios", MessageBoxIcon.Warning, "Advertencia")

        Else
            If CbxTipoPago.SelectedItem = "Crédito" Then '<-- Especifica los valores del combobox que toman un valor numerico con la variable "TP de tipo Pago y TT de Tipo transferencia".
                TipoPago = 1

            Else
                TipoPago = 2

            End If
            If CbxTipoTransac.SelectedItem = "Efectivo" Then
                TipoTransaccion = 1

            ElseIf CbxTipoTransac.SelectedItem = "Tarjeta de crédito" Then

                TipoTransaccion = 2

            Else
                TipoTransaccion = 3
            End If

            If RegistradoVentas(TxtNumeroVenta.Text) = False Then  '<-- Verifica si el numero de la venta no esta registrado para asi poder hacer la insercion en la base de datos  
                Dim ConsultaGuardar As String = "insert into Ventas(CodCli, CodPago, CodTransa, CodEmple, FechayHoraVenta,Total) values(@CodCli, @CodPago, @CodTransa, @CodEmple, GETDATE(), @Total)"
                Dim ejecutar As New SqlCommand(ConsultaGuardar, ConexionBase)

                ejecutar.Parameters.AddWithValue("@CodCli", Val(TxtCodCli.Text))
                ejecutar.Parameters.AddWithValue("@CodPago", TipoPago)
                ejecutar.Parameters.AddWithValue("@CodTransa", TipoTransaccion)
                ejecutar.Parameters.AddWithValue("@CodEmple", Val(TxtCodEmple.Text))
                ejecutar.Parameters.AddWithValue("@Total", Val(TxtTotal.Text))
                ejecutar.ExecuteNonQuery()

                Dim DatosFacturaD As String = "insert into DetalleVentas(NumVent, CodProduc , NombProduc,Articulo ,Descripcion,Impuesto , CantVenta, PrecioVenta, SubTotal) values(@NumVent, @CodProduc , @NombProduc,@Articulo ,@Descripcion, @Impuesto , @CantVenta, @PrecioVenta,  @SubTotal)"
                Dim RegistrarD As New SqlCommand(DatosFacturaD, ConexionBase)

                Dim Fila As DataGridViewRow = New DataGridViewRow()
                For Each Fila In DGV.Rows '<-- Recorre el datagridview para insertar los valores en la base de datos 
                    RegistrarD.Parameters.Clear()
                    RegistrarD.Parameters.AddWithValue("@NumVent", Val(TxtNumeroVenta.Text))
                    RegistrarD.Parameters.AddWithValue("@CodProduc", Fila.Cells("CodProduc").Value)
                    RegistrarD.Parameters.AddWithValue("@NombProduc", Fila.Cells("NombProduc").Value)
                    RegistrarD.Parameters.AddWithValue("@Articulo", Fila.Cells("Artículo").Value)
                    RegistrarD.Parameters.AddWithValue("@Descripcion", Fila.Cells("Descripción").Value)
                    RegistrarD.Parameters.AddWithValue("@Impuesto", Fila.Cells("Impuesto").Value)
                    RegistrarD.Parameters.AddWithValue("@CantVenta", Fila.Cells("CantVenta").Value)
                    RegistrarD.Parameters.AddWithValue("@PrecioVenta", Fila.Cells("PrecioVenta").Value)
                    RegistrarD.Parameters.AddWithValue("@SubTotal", Fila.Cells("SubTotal").Value)
                    RegistrarD.ExecuteNonQuery()

                    Dim DatosFacturaA As String = "update Producto set UnidadesStock -= @UnidadesStock where CodProduc = @CodProduc"
                    Dim RegistrarA As New SqlCommand(DatosFacturaA, ConexionBase)

                    RegistrarA.Parameters.AddWithValue("@UnidadesStock", Fila.Cells("CantVenta").Value)
                    RegistrarA.Parameters.AddWithValue("@CodProduc", Fila.Cells("CodProduc").Value)
                    RegistrarA.ExecuteNonQuery()
                Next


                ConexionBase.Close() '<-- cierre de la funcion

                'Limpia los textbox luego de generar la venta
                DGV.Rows.Clear()
                TxtCantidad.Clear()
                TxtCodigoProducto.Clear()
                TxtTotal.Clear()

                TxtNombreProducto.Clear()

                Total = 0
                CodUltmaVenta = CodUltimaVenta()
                TxtNumeroVenta.Text = CodUltmaVenta
                MsgBox("Venta registrada con éxito", MessageBoxIcon.Information, "Compra")
                FacturaVenta.Show() '<-- Llamada al formulario de la factura  
            Else
                MsgBox("La venta ya esta registrada", MessageBoxIcon.Exclamation, "Compra")
            End If
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

    Private Sub txNumVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumeroVenta.KeyPress
        SoloNumeros(e) '<-- Llamado de la funcion que solo permite el ingreso de caracteres tipo numerico
    End Sub

    Private Sub TxtCodCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodCli.KeyPress
        SoloNumeros(e) '<-- Llamado de la funcion que solo permite el ingreso de caracteres tipo numerico
    End Sub

    Private Sub TxtCodEmple_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodEmple.KeyPress
        SoloNumeros(e) '<-- Llamado de la funcion que solo permite el ingreso de caracteres tipo numerico
    End Sub

    Private Sub TxtCodPago_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e) '<-- Llamado de la funcion que solo permite el ingreso de caracteres tipo numerico
    End Sub

    Private Sub TxtCodTransa_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e) '<-- Llamado de la funcion que solo permite el ingreso de caracteres tipo numerico
    End Sub

    Private Sub TxtCodProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodigoProducto.KeyPress
        SoloNumeros(e) '<-- Llamado de la funcion que solo permite el ingreso de caracteres tipo numerico
    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        SoloNumeros(e) '<-- Llamado de la funcion que solo permite el ingreso de caracteres tipo numerico
    End Sub


    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtCodEmple.Text = CodUser

        AbrirConeccion()

        CodUltmaVenta = CodUltimaVenta()

        If CodUltmaVenta = "0" Then
            TxtNumeroVenta.Text = "1"
        Else
            TxtNumeroVenta.Text = CodUltmaVenta
        End If


        TxtCodEmple.Text = Login.TxtNombreEmpleado.Text
        lbUsuario.Text = Login.TxtNombreEmpleado.Text

        ConexionBase.Close()


    End Sub

    Private Sub lbUsuario_TextChanged(sender As Object, e As EventArgs) Handles lbUsuario.TextChanged
        AbrirConeccion()
        Dim Recuperar As String = "select E.CodEmple, E.NombEmple from Empleados as E inner join Usuario as U on E.CodEmple=U.CodEmple where U.UsuarioEmp='" & lbUsuario.Text & "'"
        Dim Mostrar As SqlDataReader
        Dim Ejecutar As SqlCommand
        Ejecutar = New SqlCommand(Recuperar, ConexionBase)
        Mostrar = Ejecutar.ExecuteReader
        Dim Estado As String
        Estado = Mostrar.Read

        If (Estado = True) Then

            TxtCodEmple.Text = Mostrar(0)
            TxtNombreEmpleado.Text = Mostrar(1)

        Else
            TxtCodEmple.Text = ""
            TxtNombreEmpleado.Text = ""
        End If
        Mostrar.Close()
        ConexionBase.Close()
    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged
        LblContador.Text = TxtCantidad.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub btnBusqCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click

        Dim frm As New BuscarCliente
        AddOwnedForm(frm)
        frm.ShowDialog()

    End Sub

    Private Sub btnBuscProd_Click(sender As Object, e As EventArgs) Handles BtnBuscarProducto.Click
        ProductosValidar = 1
        Dim frm As New BuscarProducto
        AddOwnedForm(frm)
        frm.ShowDialog()

    End Sub

End Class