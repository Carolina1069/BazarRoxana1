Imports System.Data.SqlClient
Public Class MenuPrincipal
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblHora.Text = DateTime.Now.ToString("hh:mm:tt")
        LblFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Label1.Text = Login.txtNombreEmpleado.Text
    End Sub

    Private Sub EmpleadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem1.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim formEmpleado As New Empleado
        formEmpleado.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(formEmpleado)
        formEmpleado.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim formProveedores As New Proveedores
        formProveedores.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(formProveedores)
        formProveedores.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim FormClientes As New Clientes
        FormClientes.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(FormClientes)
        FormClientes.Show()
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim FormCategorias As New Categorias
        FormCategorias.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(FormCategorias)
        FormCategorias.Show()
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click

        Me.ToolStripContainer1.ContentPanel.Controls.Clear()

    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim FormCompras As New Compras
        FormCompras.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(FormCompras)
        FormCompras.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim FormVentas As New Ventas
        FormVentas.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(FormVentas)
        FormVentas.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim FormInicio As New Inicio
        FormInicio.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(FormInicio)
        FormInicio.Show()
    End Sub

    Private Sub MinimoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimoToolStripMenuItem.Click

        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim FormProductoMinimo As New Minimo
        FormProductoMinimo.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(FormProductoMinimo)
        FormProductoMinimo.Show()

    End Sub

    Private Sub ProductoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem1.Click

        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim FormProductos As New Productos
        FormProductos.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(FormProductos)
        FormProductos.Show()

    End Sub

    Private Sub TodasLasComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodasLasComprasToolStripMenuItem.Click
        ReporteCompra.Show()
    End Sub

    Private Sub CompraPorFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraPorFechaToolStripMenuItem.Click
        ReporteCompraParametro.Show()
    End Sub

    Private Sub TodasLasVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodasLasVentasToolStripMenuItem.Click
        ReporteVenta.Show()
    End Sub

    Private Sub VentasPorFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasPorFechaToolStripMenuItem.Click
        ReporteVentaParametro.Show()
    End Sub

    Private Sub ProductosPorCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosPorCategoriaToolStripMenuItem.Click
        ReporteProductoParametro.Show()
    End Sub

    Private Sub ProductosMásVendidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosMásVendidosToolStripMenuItem.Click
        ReporteMasVendido.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        ReporteEmpleados.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        ReporteProveedores.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        ReporteCliente.Show()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
    End Sub

    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged

        abrir()
        Dim Recuperar As String = "select * from Empleados where UsuarioEmple= '" & Label1.Text & "'"
        Dim Mostrar As SqlDataReader
        Dim Ejecutar As SqlCommand
        Ejecutar = New SqlCommand(Recuperar, conexion)
        Mostrar = Ejecutar.ExecuteReader
        Dim Estado As String
        Estado = Mostrar.Read
        If (Estado = True) Then
            Label2.Text = Mostrar(1)

            If Mostrar(4) = 1 Then
                Label3.Text = "Gerencia"
            Else
                Label3.Text = "General"
            End If
        Else
            Label2.Text = ""
        End If
        Mostrar.Close()
        conexion.Close()

    End Sub
End Class