Imports System.Data.SqlClient
Public Class Ventas


    Private Sub TxtCodProducto_TextChanged(sender As Object, e As EventArgs) Handles TxtCodigoProducto.TextChanged
        AbrirConexion()
        Dim ProductoVenta As Integer
        ProductoVenta = Val(TxtCodigoProducto.Text)

        Dim RecuperarProducto As String = "select * from Producto where CodProduc= '" & ProductoVenta & "'"
        Dim MostrarProducto As SqlDataReader
        Dim EjecutarProducto As SqlCommand
        EjecutarProducto = New SqlCommand(RecuperarProducto, ConexionBase)
        MostrarProducto = EjecutarProducto.ExecuteReader
        Dim EstadoProducto As String
        EstadoProducto = MostrarProducto.Read

        If (EstadoProducto = True) Then
            TxtNombreProducto.Text = MostrarProducto(1)
            TxtArticulo.Text = MostrarProducto(2)
            TxtDescripcion.Text = MostrarProducto(3)
            TxtUnidades.Text = MostrarProducto(11)
            TxtUnidadesMinimas.Text = MostrarProducto(12)
        Else
            TxtNombreProducto.Text = ""
            TxtArticulo.Text = ""
            TxtDescripcion.Text = ""
            TxtUnidades.Text = ""
            CbxPrecio.Text = ""
            TxtUnidadesMinimas.Text = ""
        End If
        MostrarProducto.Close()

        AbrirConexion()

        Dim DatosUsuarios As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using AdaptadorProducto As New SqlDataAdapter("select CodProduc, Precios from Producto unpivot ( Precios for Valor in(PrimerPrecio,SegundoPrecio, TercerPrecio) ) as P where CodProduc ='" & ProductoVenta & "'", ConexionBase)
            AdaptadorProducto.Fill(DatosUsuarios)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        CbxPrecio.DataSource = DatosUsuarios
        CbxPrecio.DisplayMember = "Precios"

        ConexionBase.Close()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        Dim TotalVenta As Double
        Dim SubtotalVenta As Double
        Dim Subtotal2Venta As Double
        Dim SubTotal1Venta As Integer
        Dim ImpuestoVenta As Double
        ImpuestoVenta = 0.15

        Dim CantidadVenta As Integer
        Dim UnidadStock As Integer

        CantidadVenta = Val(TxtCantidad.Text)
        UnidadStock = Val(TxtUnidades.Text)

        If TxtCodigoProducto.Text = "" Or TxtNombreProducto.Text = "" Or CbxPrecio.Text = "" Or TxtUnidades.Text = "" Or TxtUnidadesMinimas.Text = "" Then

            MsgBox("Porfavor realice la búsqueda del producto", MessageBoxIcon.Exclamation, "Venta")

        ElseIf TxtCantidad.Text = "" Then

            MsgBox("Porfavor ingrese la cantidad que desea del producto ya buscado", MessageBoxIcon.Exclamation, "Venta")

        ElseIf CantidadVenta <= UnidadStock Then

            SubTotal1Venta = (Val(CbxPrecio.Text) * Val(TxtCantidad.Text))
            Subtotal2Venta = SubTotal1Venta * ImpuestoVenta
            SubtotalVenta = SubTotal1Venta + Subtotal2Venta
            DGV.Rows.Add(TxtCodigoProducto.Text, TxtNombreProducto.Text, TxtArticulo.Text, TxtDescripcion.Text, ImpuestoVenta, TxtCantidad.Text, CbxPrecio.Text, SubtotalVenta)
            For Each row As DataGridViewRow In DGV.Rows
                TotalVenta += Val(row.Cells(7).Value)
            Next
            TxtTotal.Text = TotalVenta.ToString
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
            Dim TotalVenta As Single
            For Each row As DataGridViewRow In DGV.Rows
                TotalVenta -= Val(row.Cells(7).Value)
            Next
            TxtTotal.Text = -TotalVenta
        End If

    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim TotalVenta As Integer

        AbrirConexion() '<-- Llamado de la funcion 
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
                Dim EjecutarConsulta As New SqlCommand(ConsultaGuardar, ConexionBase)

                EjecutarConsulta.Parameters.AddWithValue("@CodCli", Val(TxtCodCli.Text))
                EjecutarConsulta.Parameters.AddWithValue("@CodPago", TipoPago)
                EjecutarConsulta.Parameters.AddWithValue("@CodTransa", TipoTransaccion)
                EjecutarConsulta.Parameters.AddWithValue("@CodEmple", Val(TxtCodEmple.Text))
                EjecutarConsulta.Parameters.AddWithValue("@Total", Val(TxtTotal.Text))
                EjecutarConsulta.ExecuteNonQuery()

                Dim DatosFacturaD As String = "insert into DetalleVentas(NumVent, CodProduc , NombProduc,Articulo ,Descripcion,Impuesto , CantVenta, PrecioVenta, SubTotal) values(@NumVent, @CodProduc , @NombProduc,@Articulo ,@Descripcion, @Impuesto , @CantVenta, @PrecioVenta,  @SubTotal)"
                Dim RegistrarFactura As New SqlCommand(DatosFacturaD, ConexionBase)

                Dim FilaTabla As DataGridViewRow = New DataGridViewRow()
                For Each FilaTabla In DGV.Rows '<-- Recorre el datagridview para insertar los valores en la base de datos 
                    RegistrarFactura.Parameters.Clear()
                    RegistrarFactura.Parameters.AddWithValue("@NumVent", Val(TxtNumeroVenta.Text))
                    RegistrarFactura.Parameters.AddWithValue("@CodProduc", FilaTabla.Cells("CodProduc").Value)
                    RegistrarFactura.Parameters.AddWithValue("@NombProduc", FilaTabla.Cells("NombProduc").Value)
                    RegistrarFactura.Parameters.AddWithValue("@Articulo", FilaTabla.Cells("Artículo").Value)
                    RegistrarFactura.Parameters.AddWithValue("@Descripcion", FilaTabla.Cells("Descripción").Value)
                    RegistrarFactura.Parameters.AddWithValue("@Impuesto", FilaTabla.Cells("Impuesto").Value)
                    RegistrarFactura.Parameters.AddWithValue("@CantVenta", FilaTabla.Cells("CantVenta").Value)
                    RegistrarFactura.Parameters.AddWithValue("@PrecioVenta", FilaTabla.Cells("PrecioVenta").Value)
                    RegistrarFactura.Parameters.AddWithValue("@SubTotal", FilaTabla.Cells("SubTotal").Value)
                    RegistrarFactura.ExecuteNonQuery()

                    Dim DatosFacturaA As String = "update Producto set UnidadesStock -= @UnidadesStock where CodProduc = @CodProduc"
                    Dim RegistrarFacturaA As New SqlCommand(DatosFacturaA, ConexionBase)

                    RegistrarFacturaA.Parameters.AddWithValue("@UnidadesStock", FilaTabla.Cells("CantVenta").Value)
                    RegistrarFacturaA.Parameters.AddWithValue("@CodProduc", FilaTabla.Cells("CodProduc").Value)
                    RegistrarFacturaA.ExecuteNonQuery()
                Next


                ConexionBase.Close() '<-- cierre de la funcion

                'Limpia los textbox luego de generar la venta
                DGV.Rows.Clear()
                TxtCantidad.Clear()
                TxtCodigoProducto.Clear()
                TxtTotal.Clear()

                TxtNombreProducto.Clear()

                TotalVenta = 0
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

        AbrirConexion()

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
        AbrirConexion()
        Dim RecuperarEmpleado As String = "select E.CodEmple, E.NombEmple from Empleados as E inner join Usuario as U on E.CodEmple=U.CodEmple where U.UsuarioEmp='" & lbUsuario.Text & "'"
        Dim MostrarEmpleado As SqlDataReader
        Dim EjecutarEmpleado As SqlCommand
        EjecutarEmpleado = New SqlCommand(RecuperarEmpleado, ConexionBase)
        MostrarEmpleado = EjecutarEmpleado.ExecuteReader
        Dim Estado As String
        Estado = MostrarEmpleado.Read

        If (Estado = True) Then

            TxtCodEmple.Text = MostrarEmpleado(0)
            TxtNombreEmpleado.Text = MostrarEmpleado(1)

        Else
            TxtCodEmple.Text = ""
            TxtNombreEmpleado.Text = ""
        End If
        MostrarEmpleado.Close()
        ConexionBase.Close()
    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged
        LblContador.Text = TxtCantidad.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub btnBusqCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click

        Dim FrmCliente As New BuscarCliente '<-- Ejecuta una llamada de la pantalla cliente con el metodo padre hijo  
        AddOwnedForm(FrmCliente)
        FrmCliente.ShowDialog()

    End Sub

    Private Sub btnBuscProd_Click(sender As Object, e As EventArgs) Handles BtnBuscarProducto.Click
        ProductosValidar = 1
        Dim FrmProducto As New BuscarProducto '<-- Ejecuta una llamada de la pantalla producto con el metodo padre hijo  
        AddOwnedForm(FrmProducto)
        FrmProducto.ShowDialog()

    End Sub

End Class