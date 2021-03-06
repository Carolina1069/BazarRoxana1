﻿Imports System.Data.SqlClient
Public Class Ventas


    Private Sub TxtCodProducto_TextChanged(sender As Object, e As EventArgs) Handles TxtCodProducto.TextChanged
        abrir()

        Dim produ As Integer
        produ = Val(TxtCodProducto.Text)
        abrir()

        Dim DATOSusuarios As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProduc, Precios from Producto unpivot ( Precios for Valor in(PrimerPrecio,SegundoPrecio, TercerPrecio) ) as P where CodProduc ='" & produ & "'", conexion)
            adaptador.Fill(DATOSusuarios)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        CbxPrecio.DataSource = DATOSusuarios
        CbxPrecio.DisplayMember = "Precios"

        conexion.Close()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        Dim Total As Double
        Dim Subtotal As Double
        Dim Subtotal2 As Double
        Dim SubTotal1 As Integer
        Dim Impuesto As Double
        Impuesto = 0.25

        Dim Cantidad As Integer
        Dim UnidadStock As Integer

        Cantidad = Val(TxtCantidad.Text)
        UnidadStock = Val(TxtUnidades.Text)

        If TxtCodProducto.Text = "" Or TxtNombreProducto.Text = "" Or CbxPrecio.Text = "" Or TxtUnidades.Text = "" Or txMinimo.Text = "" Then

            MsgBox("Porfavor realice la búsqueda del producto", MessageBoxIcon.Exclamation, "Venta")

        ElseIf TxtCantidad.Text = "" Then

            MsgBox("Porfavor ingrese la cantidad que desea del producto ya buscado", MessageBoxIcon.Exclamation, "Venta")

        ElseIf Cantidad <= UnidadStock Then

            SubTotal1 = (Val(CbxPrecio.Text) * Val(TxtCantidad.Text))
            Subtotal2 = SubTotal1 * Impuesto
            Subtotal = SubTotal1 + Subtotal2
            DGV.Rows.Add(TxtCodProducto.Text, TxtNombreProducto.Text, Impuesto, TxtCantidad.Text, CbxPrecio.Text, Subtotal)
            For Each row As DataGridViewRow In DGV.Rows
                Total += Val(row.Cells(5).Value)
            Next
            TxtTotal.Text = Total.ToString
            TxtCodProducto.Clear()
            TxtNombreProducto.Clear()
            CbxPrecio.Text = ""
            TxtCantidad.Clear()
            TxtUnidades.Clear()
            txMinimo.Clear()

        Else

            MsgBox("La cantidad solicitada supera las unidades en Inventario", MessageBoxIcon.Warning, "Advertencia")

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.DGV.Rows.Count = 0 Then
            MessageBox.Show("Por favor ingrese datos en la tabla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            DGV.Rows.Remove(DGV.CurrentRow)
            Dim Total As Single
            For Each row As DataGridViewRow In DGV.Rows
                Total -= Val(row.Cells(5).Value)
            Next
            TxtTotal.Text = -Total
        End If

    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Dim total As Integer

        abrir() '<-- Llamado de la funcion 
        Dim TP As Integer
        Dim TT As Integer

        If TxtCodCli.Text = "" Or cbxTipoPago.Text = "" Or cbxTipoTransac.Text = "" Or TxtCodEmple.Text = "" Or DGV.Rows.Count = 0 Then
            MsgBox("Hay campos vacios", MessageBoxIcon.Warning, "Advertencia")

        Else
            If cbxTipoPago.SelectedItem = "Crédito" Then '<-- Especifica los valores del combobox que toman un valor numerico con la variable "TP de tipo Pago y TT de Tipo transferencia".
                TP = 1

            Else
                TP = 2

            End If
            If cbxTipoTransac.SelectedItem = "Efectivo" Then
                TT = 1

            ElseIf cbxTipoTransac.SelectedItem = "Tarjeta de crédito" Then

                TT = 2

            Else
                TT = 3
            End If

            If RegistradoVentas(txNumVenta.Text) = False Then  '<-- Verifica si el numero de la venta no esta registrado para asi poder hacer la insercion en la base de datos  
                Dim ConsultaGuardar As String = "insert into Ventas(CodCli, CodPago, CodTransa, CodEmple, FechayHoraVenta,Total) values(@CodCli, @CodPago, @CodTransa, @CodEmple, GETDATE(), @Total)"
                Dim ejecutar As New SqlCommand(ConsultaGuardar, conexion)

                ejecutar.Parameters.AddWithValue("@CodCli", Val(TxtCodCli.Text))
                ejecutar.Parameters.AddWithValue("@CodPago", TP)
                ejecutar.Parameters.AddWithValue("@CodTransa", TT)
                ejecutar.Parameters.AddWithValue("@CodEmple", Val(TxtCodEmple.Text))
                ejecutar.Parameters.AddWithValue("@Total", Val(TxtTotal.Text))
                ejecutar.ExecuteNonQuery()

                Dim DatosFacturaD As String = "insert into DetalleVentas(NumVent, CodProduc , NombProduc, Impuesto , CantVenta, PrecioVenta, SubTotal) values(@NumVent, @CodProduc , @NombProduc, @Impuesto , @CantVenta, @PrecioVenta,  @SubTotal)"
                Dim RegistrarD As New SqlCommand(DatosFacturaD, conexion)

                Dim fila As DataGridViewRow = New DataGridViewRow()
                For Each fila In DGV.Rows '<-- Recorre el datagridview para insertar los valores en la base de datos 
                    RegistrarD.Parameters.Clear()
                    RegistrarD.Parameters.AddWithValue("@NumVent", Val(txNumVenta.Text))
                    RegistrarD.Parameters.AddWithValue("@CodProduc", fila.Cells("CodProduc").Value)
                    RegistrarD.Parameters.AddWithValue("@NombProduc", fila.Cells("NombProduc").Value)
                    RegistrarD.Parameters.AddWithValue("@Impuesto", fila.Cells("Impuesto").Value)
                    RegistrarD.Parameters.AddWithValue("@CantVenta", fila.Cells("CantVenta").Value)
                    RegistrarD.Parameters.AddWithValue("@PrecioVenta", fila.Cells("PrecioVenta").Value)
                    RegistrarD.Parameters.AddWithValue("@SubTotal", fila.Cells("SubTotal").Value)
                    RegistrarD.ExecuteNonQuery()

                    Dim DatosFacturaA As String = "update Producto set UnidadesStock -= @UnidadesStock where CodProduc = @CodProduc"
                    Dim RegistrarA As New SqlCommand(DatosFacturaA, conexion)

                    RegistrarA.Parameters.AddWithValue("@UnidadesStock", fila.Cells("CantVenta").Value)
                    RegistrarA.Parameters.AddWithValue("@CodProduc", fila.Cells("CodProduc").Value)
                    RegistrarA.ExecuteNonQuery()
                Next


                conexion.Close() '<-- cierre de la funcion

                'Limpia los textbox luego de generar la venta
                DGV.Rows.Clear()
                TxtCantidad.Clear()
                TxtCodProducto.Clear()
                TxtTotal.Clear()

                TxtNombreProducto.Clear()

                total = 0
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

    Private Sub txNumVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txNumVenta.KeyPress
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

    Private Sub TxtCodProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodProducto.KeyPress
        SoloNumeros(e) '<-- Llamado de la funcion que solo permite el ingreso de caracteres tipo numerico
    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        SoloNumeros(e) '<-- Llamado de la funcion que solo permite el ingreso de caracteres tipo numerico
    End Sub


    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtCodEmple.Text = cod

        abrir()

        Dim CodUVenta As String = CodUltimaVenta() '<-- Declaracion de una variable tipo string para igualarla a la funcion CodUltimaVenta

        txNumVenta.Text = CodUVenta
        TxtCodEmple.Text = Login.txtNombreEmpleado.Text
        lbUsuario.Text = Login.txtNombreEmpleado.Text

        conexion.Close()


    End Sub

    Private Sub lbUsuario_TextChanged(sender As Object, e As EventArgs) Handles lbUsuario.TextChanged
        abrir()
        Dim Recuperar As String = "select * from Empleados where UsuarioEmple= '" & lbUsuario.Text & "'"
        Dim Mostrar As SqlDataReader
        Dim Ejecutar As SqlCommand
        Ejecutar = New SqlCommand(Recuperar, conexion)
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
        conexion.Close()
    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged
        LbContador.Text = TxtCantidad.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub btnBusqCliente_Click(sender As Object, e As EventArgs) Handles btnBusqCliente.Click

        Dim frm As New BuscarCliente
        AddOwnedForm(frm)
        frm.ShowDialog()

    End Sub

    Private Sub btnBuscProd_Click(sender As Object, e As EventArgs) Handles btnBuscProd.Click
        ProductosValidar = 1
        Dim frm As New BuscarProducto
        AddOwnedForm(frm)
        frm.ShowDialog()

    End Sub

End Class