Imports System.Data.SqlClient
Public Class Compras


    Private Sub TxtCodProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodProv.KeyPress
        SoloNumeros(e)
    End Sub
    Dim tipoPago As Integer = 0
    Dim tipoTransac As Integer = 0
    Private Sub txCodProv_TextChanged(sender As Object, e As EventArgs) Handles TxtCodProv.TextChanged
        abrir()
        Dim Recuperar As String = "select * from Proveedores where CodProv= '" & TxtCodProv.Text & "'"
        Dim Mostrar As SqlDataReader
        Dim Ejecutar As SqlCommand
        Ejecutar = New SqlCommand(Recuperar, conexion)
        Mostrar = Ejecutar.ExecuteReader
        Dim Estado As String
        Estado = Mostrar.Read
        If (Estado = True) Then
            TxtNombreProveedor.Text = Mostrar(1)
        Else
            TxtNombreProveedor.Text = ""
        End If
        Mostrar.Close()
        conexion.Close()
    End Sub

    Private Sub TxtCodEmple_TextChanged(sender As Object, e As EventArgs) Handles TxtCodEmple.TextChanged
        abrir()
        Dim Recuperar As String = "select * from Empleados where CodEmple= '" & TxtCodEmple.Text & "'"
        Dim Mostrar As SqlDataReader
        Dim Ejecutar As SqlCommand
        Ejecutar = New SqlCommand(Recuperar, conexion)
        Mostrar = Ejecutar.ExecuteReader
        Dim Estado As String
        Estado = Mostrar.Read
        If (Estado = True) Then
            TxtNombreEmpleado.Text = Mostrar(1)
        Else
            TxtNombreEmpleado.Text = ""
        End If
        Mostrar.Close()
        conexion.Close()
    End Sub

    Private Sub TxtCodPago_TextChanged(sender As Object, e As EventArgs)
        Dim pago As Integer
        'pago = Val(TxtCodPago.Text)
        'If pago >= 1 And pago <= 2 Or TxtCodPago.Text = "" Then
        'abrir()
        'Dim Recuperar As String = "select * from FormasPago where CodPago= '" & TxtCodPago.Text & "'"
        'Dim Mostrar As SqlDataReader
        'Dim Ejecutar As SqlCommand
        'Ejecutar = New SqlCommand(Recuperar, conexion)
        'Mostrar = Ejecutar.ExecuteReader
        'Dim Estado As String
        'Estado = Mostrar.Read
        'If (Estado = True) Then
        'TxtTipoPago.Text = Mostrar(1)
        'Else
        'TxtTipoPago.Text = ""
        'End If
        'Mostrar.Close()
        'conexion.Close()
        'Else
        'TxtCodPago.Clear()
        'MsgBox("Solo hay dos tipos de pago")
        'End If

    End Sub

    Private Sub TxtCodTransa_TextChanged(sender As Object, e As EventArgs)
        Dim tran As Integer
        ' tran = Val(TxtCodTransa.Text)
        'If tran >= 1 And tran <= 3 Or TxtCodTransa.Text = "" Then
        abrir()
        ' Dim Recuperar As String = "select * from Transacciones where CodTransa= '" & TxtCodTransa.Text & "'"
        Dim Mostrar As SqlDataReader
            Dim Ejecutar As SqlCommand
        '  Ejecutar = New SqlCommand(Recuperar, conexion)
        Mostrar = Ejecutar.ExecuteReader
            Dim Estado As String
            Estado = Mostrar.Read
            If (Estado = True) Then
                TxtTipoTransaccion.Text = Mostrar(1)
            Else
                TxtTipoTransaccion.Text = ""
            End If
            Mostrar.Close()
            conexion.Close()
        ' Else
        'TxtCodTransa.Clear()
        MsgBox("Solo hay tres tipos de transaccion")
        ' End If
    End Sub

    Private Sub TxtCodProducto_TextChanged(sender As Object, e As EventArgs) Handles TxtCodProducto.TextChanged
        Dim produ As Integer
        produ = Val(TxtCodProducto.Text)
        abrir()
        Dim Recuperar As String = "select * from Producto where CodProduc= '" & produ & "'"
        Dim Mostrar As SqlDataReader
        Dim Ejecutar As SqlCommand
        Ejecutar = New SqlCommand(Recuperar, conexion)
        Mostrar = Ejecutar.ExecuteReader
        Dim Estado As String
        Estado = Mostrar.Read

        If (Estado = True) Then
            TxtNombreProducto.Text = Mostrar(1)
            TxtUnidades.Text = Mostrar(8)
            txMaximo.Text = Mostrar(10)
        Else
            TxtNombreProducto.Text = ""
            TxtUnidades.Text = ""
            CbxPrecio.Text = ""
            txMaximo.Text = ""
        End If
        Mostrar.Close()

        Dim DATOSusuarios As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProduc, Precios from Producto unpivot ( Precios for Valor in(PrimerPrecio,SegundoPrecio, TercerPrecio) ) as P where CodProduc ='" & produ & "'", conexion)
            adaptador.Fill(DATOSusuarios)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        'DGV.DataSource = DATOSusuarios
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

        Dim Max As Integer
        Dim suma As Integer

        Max = Val(txMaximo.Text)

        suma = (Val(TxtUnidades.Text) + Val(TxtCantidad.Text))

        If Max >= suma Then

            Impuesto = 0.25
            SubTotal1 = (Val(CbxPrecio.Text) * Val(TxtCantidad.Text))
            Subtotal2 = SubTotal1 * Impuesto
            Subtotal = SubTotal1 + Subtotal2
            DGV.Rows.Add(txNumCompra.Text, TxtCodProducto.Text, TxtNombreProducto.Text, Impuesto, TxtCantidad.Text, CbxPrecio.Text, Subtotal)
            For Each row As DataGridViewRow In DGV.Rows
                Total += Val(row.Cells(6).Value)
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
        DGV.Rows.Remove(DGV.CurrentRow)
        Dim Total As Single
        For Each row As DataGridViewRow In DGV.Rows
            Total -= Val(row.Cells(6).Value)
        Next
        TxtTotal.Text = -Total
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Dim total As Integer
        abrir()


        If txNumCompra.Text = "" Or TxtCodProv.Text = "" Or TxtCodEmple.Text = "" Or DGV.Rows.Count = 0 Then
            MsgBox("Hay campos vacios")
        Else
            If RegistradoCompras(txNumCompra.Text) = False Then
                Try
                    Dim ConsultaGuardar As String = "insert into Compras(CodProv, CodPago, CodTransa, CodEmple, FechayHora, Total) values( @CodProv, @CodPago, @CodTransa, @CodEmple, GETDATE(), @Total)"
                    Dim ejecutar As New SqlCommand(ConsultaGuardar, conexion)

                    ejecutar.Parameters.AddWithValue("@CodProv", Val(TxtCodProv.Text))
                    ejecutar.Parameters.AddWithValue("@CodPago", Val(tipoPago))
                    ejecutar.Parameters.AddWithValue("@CodTransa", Val(tipoTransac))
                    ejecutar.Parameters.AddWithValue("@CodEmple", Val(TxtCodEmple.Text))
                    ejecutar.Parameters.AddWithValue("@Total", Val(TxtTotal.Text))

                    ejecutar.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("error insert" + ex.ToString())
                End Try

                Dim DatosFacturaD As String = "insert into DetalleCompra(NumCompra,CodProduc , NombProduc, Impuesto , CantProduc, PrecioProduc, SubTotal) values(@NumCompra, @CodProduc , @NombProduc, @Impuesto , @CantProduc, @PrecioProduc,  @SubTotal)"
                Dim RegistrarD As New SqlCommand(DatosFacturaD, conexion)

                Dim fila As DataGridViewRow = New DataGridViewRow()
                For Each fila In DGV.Rows
                    RegistrarD.Parameters.Clear()
                    RegistrarD.Parameters.AddWithValue("@NumCompra", Val(txNumCompra.Text))
                    RegistrarD.Parameters.AddWithValue("@CodProduc", fila.Cells("CodProduc").Value)
                    RegistrarD.Parameters.AddWithValue("@NombProduc", fila.Cells("NombProduc").Value)
                    RegistrarD.Parameters.AddWithValue("@Impuesto", fila.Cells("Impuesto").Value)
                    RegistrarD.Parameters.AddWithValue("@CantProduc", fila.Cells("CantProduc").Value)
                    RegistrarD.Parameters.AddWithValue("@PrecioProduc", fila.Cells("PrecioProduc").Value)
                    RegistrarD.Parameters.AddWithValue("@SubTotal", fila.Cells("SubTotal").Value)
                    RegistrarD.ExecuteNonQuery()

                    Dim DatosFacturaA As String = "update Producto set UnidadesStock += @UnidadesStock where CodProduc = @CodProduc"
                    Dim RegistrarA As New SqlCommand(DatosFacturaA, conexion)

                    RegistrarA.Parameters.AddWithValue("@UnidadesStock", fila.Cells("CantProduc").Value)
                    RegistrarA.Parameters.AddWithValue("@CodProduc", fila.Cells("CodProduc").Value)
                    RegistrarA.ExecuteNonQuery()
                    codUltmaVenta = CodUVenta()
                    txNumCompra.Text = codUltmaVenta
                    MsgBox("Registro de venta Exitoso!")
                Next
                conexion.Close()
                DGV.Rows.Clear()
                TxtCantidad.Clear()
                TxtNombreProveedor.Clear()
                TxtCodProv.Clear()
                'TxtCodEmple.Clear()
                TxtCodProducto.Clear()
                TxtTotal.Clear()
                CbxPrecio.Text = ""
                'TxtNombreEmpleado.Clear()
                TxtNombreProveedor.Clear()
                TxtNombreProducto.Clear()
                ' TxtTipoPago.Clear()
                'TxtTipoTransaccion.Clear()
                'TxtCodTransa.Clear()
                'TxtCodPago.Clear()
                total = 0
            Else
                MsgBox("La compra ya esta registrada")
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

    Private Sub txNumCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txNumCompra.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtCodPago_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub TxtCodTransa_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub TxtCodProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodProducto.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtCodEmple_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodEmple.KeyPress
        SoloNumeros(e)
    End Sub

    Public Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTipoPago.SelectedIndex = 0
        cmbTipoTransac.SelectedIndex = 0
        TxtCodEmple.Text = cod
        TxtCodProv.Text = codProv
        'TxtCodTransa.Visible = False
        'TxtCodPago.Visible = False
        Label5.Visible = False
        Label4.Visible = False
        TxtTipoPago.Visible = False
        TxtTipoTransaccion.Visible = False

        codUltmaVenta = CodUVenta()
        txNumCompra.Text = codUltmaVenta



    End Sub
    Public Sub setCodProv()
        TxtCodProv.Text = codProv

    End Sub
    Private Sub cmbTipoPago_TabIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoPago.TabIndexChanged

    End Sub

    Private Sub cmbTipoPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoPago.SelectedIndexChanged
        Dim pago As Integer
        tipoPago = cmbTipoPago.SelectedIndex + 1
        'pago = Val(TxtCodPago.Text)
        If tipoPago >= 1 And tipoPago <= 2 Then
            abrir()
            Dim Recuperar As String = "select * from FormasPago where CodPago= '" & tipoPago & "'"
            Dim Mostrar As SqlDataReader
            Dim Ejecutar As SqlCommand
            Ejecutar = New SqlCommand(Recuperar, conexion)
            Mostrar = Ejecutar.ExecuteReader
            Dim Estado As String
            Estado = Mostrar.Read
            If (Estado = True) Then
                TxtTipoPago.Text = Mostrar(1)
            Else
                TxtTipoPago.Text = ""
            End If
            Mostrar.Close()
            conexion.Close()
        Else
            '  TxtCodPago.Clear()
            MsgBox("Solo hay dos tipos de pago")
        End If
    End Sub

    Private Sub cmbTipoTransac_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoTransac.SelectedIndexChanged
        Dim tran As Integer
        'tran = Val(TxtCodTransa.Text)

        tipoTransac = cmbTipoTransac.SelectedIndex + 1
        If tipoTransac >= 1 And tipoTransac <= 3 Then
            abrir()
            Dim Recuperar As String = "select * from Transacciones where CodTransa= '" & tipoTransac & "'"
            Dim Mostrar As SqlDataReader
            Dim Ejecutar As SqlCommand
            Ejecutar = New SqlCommand(Recuperar, conexion)
            Mostrar = Ejecutar.ExecuteReader
            Dim Estado As String
            Estado = Mostrar.Read
            If (Estado = True) Then
                TxtTipoTransaccion.Text = Mostrar(1)
            Else
                TxtTipoTransaccion.Text = ""
            End If
            Mostrar.Close()
            conexion.Close()
        Else
            'TxtCodTransa.Clear()
            MsgBox("Solo hay tres tipos de transaccion")
        End If
    End Sub

    Private Sub btnsearchProv_Click(sender As Object, e As EventArgs) Handles btnsearchProv.Click
        AddOwnedForm(viewProveedor)
        viewProveedor.Show()
    End Sub

    Private Sub btnBuscProd_Click(sender As Object, e As EventArgs) Handles btnBuscProd.Click
        ProductosValidar = 2
        Dim frm As New BuscarProducto
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub
End Class