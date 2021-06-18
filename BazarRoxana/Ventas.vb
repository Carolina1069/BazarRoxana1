Imports System.Data.SqlClient
Public Class Ventas
    Private Sub txCodProv_TextChanged(sender As Object, e As EventArgs) Handles TxtCodCli.TextChanged
        'abrir()
        'Dim Recuperar As String = "select * from Clientes where CodCli= '" & TxtCodCli.Text & "'"
        'Dim Mostrar As SqlDataReader
        'Dim Ejecutar As SqlCommand
        'Ejecutar = New SqlCommand(Recuperar, conexion)
        'Mostrar = Ejecutar.ExecuteReader
        'Dim Estado As String
        'Estado = Mostrar.Read
        'If (Estado = True) Then
        '    TxtNombreCliente.Text = Mostrar(1)
        'Else
        '    TxtNombreCliente.Text = ""
        'End If
        'Mostrar.Close()
        'conexion.Close()
    End Sub

    Private Sub TxtCodProducto_TextChanged(sender As Object, e As EventArgs) Handles TxtCodProducto.TextChanged
        abrir()

        'Dim Recuperar As String = "select * from Producto where CodProduc= '" & TxtCodProducto.Text & "'"
        'Dim Mostrar As SqlDataReader
        'Dim Ejecutar As SqlCommand
        'Ejecutar = New SqlCommand(Recuperar, conexion)
        'Mostrar = Ejecutar.ExecuteReader
        'Dim Estado As String
        'Estado = Mostrar.Read

        'If (Estado = True) Then
        '    TxtNombreProducto.Text = Mostrar(1)
        '    TxtUnidades.Text = Mostrar(8)
        '    txMinimo.Text = Mostrar(9)
        'Else
        '    TxtNombreProducto.Text = ""
        '    TxtUnidades.Text = ""
        '    CbxPrecio.Text = ""
        '    txMinimo.Text = ""
        'End If
        'Mostrar.Close()

        Dim DATOSusuarios As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProduc, Precios from Producto unpivot ( Precios for Valor in(PrimerPrecio,SegundoPrecio, TercerPrecio) ) as P where CodProduc ='" & TxtCodProducto.Text & "'", conexion)
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
        Impuesto = 0.25

        Dim Cantidad As Integer
        Dim UnidadStock As Integer

        Cantidad = Val(TxtCantidad.Text)
        UnidadStock = Val(TxtUnidades.Text)

        If Cantidad <= UnidadStock Then

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

            MsgBox("La cantidad solicitada supera las unidades en Inventario")

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
        Dim TP As Integer
        Dim TT As Integer

        If TxtCodCli.Text = "" Or cbxTipoPago.Text = "" Or cbxTipoTransac.Text = "" Or TxtCodEmple.Text = "" Or DGV.Rows.Count = 0 Then
            MsgBox("Hay campos vacios")
        Else
            If cbxTipoPago.SelectedItem = "Crédito" Then
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

            If RegistradoVentas(txNumVenta.Text) = False Then
                Dim ConsultaGuardar As String = "insert into Ventas(NumVent, CodCli, CodPago, CodTransa, CodEmple, FechayHoraVenta,Total) values(@NumVent, @CodCli, @CodPago, @CodTransa, @CodEmple, GETDATE(), @Total)"
                Dim ejecutar As New SqlCommand(ConsultaGuardar, conexion)
                ejecutar.Parameters.AddWithValue("@NumVent", Val(txNumVenta.Text))
                ejecutar.Parameters.AddWithValue("@CodCli", Val(TxtCodCli.Text))
                ejecutar.Parameters.AddWithValue("@CodPago", TP)
                ejecutar.Parameters.AddWithValue("@CodTransa", TT)
                ejecutar.Parameters.AddWithValue("@CodEmple", Val(TxtCodEmple.Text))
                ejecutar.Parameters.AddWithValue("@Total", Val(TxtTotal.Text))
                ejecutar.ExecuteNonQuery()

                Dim DatosFacturaD As String = "insert into DetalleVentas(NumVent, CodProduc , NombProduc, Impuesto , CantVenta, PrecioVenta, SubTotal) values(@NumVent, @CodProduc , @NombProduc, @Impuesto , @CantVenta, @PrecioVenta,  @SubTotal)"
                Dim RegistrarD As New SqlCommand(DatosFacturaD, conexion)

                Dim fila As DataGridViewRow = New DataGridViewRow()
                For Each fila In DGV.Rows
                    RegistrarD.Parameters.Clear()
                    RegistrarD.Parameters.AddWithValue("@NumVent", fila.Cells("NumVent").Value)
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


                conexion.Close()

                DGV.Rows.Clear()
                TxtCantidad.Clear()
                TxtNombreCliente.Clear()
                TxtCodCli.Clear()
                TxtCodEmple.Clear()
                TxtCodProducto.Clear()
                TxtTotal.Clear()

                TxtNombreEmpleado.Clear()
                TxtNombreCliente.Clear()
                TxtNombreProducto.Clear()

                total = 0
                'FacturaVenta.Show()
            Else
                MsgBox("La venta ya esta registrada")
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
        SoloNumeros(e)
    End Sub

    Private Sub TxtCodCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodCli.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtCodEmple_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodEmple.KeyPress
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

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        FacturaVenta.Show()
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtCodEmple.Text = Login.txtNombreEmpleado.Text
        lbUsuario.Text = Login.txtNombreEmpleado.Text

        'TxtCodCli.Text = BuscarCliente.codcli.Text
        'TxtNombreCliente.Text = BuscarCliente.nombcli.Text
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
        LbContador.Text = TxtCantidad.Text.Length
    End Sub

    Private Sub btnBusqCliente_Click(sender As Object, e As EventArgs) Handles btnBusqCliente.Click
        MenuPrincipal.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim Buscar As New BuscarCliente
        Buscar.MdiParent = MenuPrincipal
        MenuPrincipal.ToolStripContainer1.ContentPanel.Controls.Add(Buscar)
        Buscar.Show()

    End Sub

    Private Sub btnBuscProd_Click(sender As Object, e As EventArgs) Handles btnBuscProd.Click
        MenuPrincipal.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim BuscarP As New BuscarProducto
        BuscarP.MdiParent = MenuPrincipal
        MenuPrincipal.ToolStripContainer1.ContentPanel.Controls.Add(BuscarP)
        BuscarP.Show()
    End Sub

    Private Sub CbxPrecio_TextChanged(sender As Object, e As EventArgs) Handles CbxPrecio.TextChanged



    End Sub
End Class