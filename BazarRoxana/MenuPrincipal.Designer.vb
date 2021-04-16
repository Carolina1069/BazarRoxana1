<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.LblHora = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodasLasComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompraPorFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodasLasVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasPorFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosPorCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosMásVendidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.BackColor = System.Drawing.Color.Gainsboro
        Me.LblHora.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.Location = New System.Drawing.Point(12, 628)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(0, 14)
        Me.LblHora.TabIndex = 46
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.BackColor = System.Drawing.Color.Gainsboro
        Me.LblFecha.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(12, 605)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(0, 14)
        Me.LblFecha.TabIndex = 45
        '
        'Timer1
        '
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.BackgroundImage = Global.BazarRoxana.My.Resources.Resources.B
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.PictureBox1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(934, 650)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(191, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(934, 650)
        Me.ToolStripContainer1.TabIndex = 48
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.BazarRoxana.My.Resources.Resources.Blur
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.BazarRoxana.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(199, 186)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(586, 222)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuStrip1.BackgroundImage = Global.BazarRoxana.My.Resources.Resources.pexels_archie_binamira_2463346
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.EmpleadoToolStripMenuItem1, Me.ProveedoresToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.CategoriaToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(191, 650)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.InicioToolStripMenuItem.BackgroundImage = CType(resources.GetObject("InicioToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.InicioToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InicioToolStripMenuItem.Image = Global.BazarRoxana.My.Resources.Resources.ic_home_128_28521
        Me.InicioToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(178, 30)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'EmpleadoToolStripMenuItem1
        '
        Me.EmpleadoToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.EmpleadoToolStripMenuItem1.BackgroundImage = CType(resources.GetObject("EmpleadoToolStripMenuItem1.BackgroundImage"), System.Drawing.Image)
        Me.EmpleadoToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EmpleadoToolStripMenuItem1.Image = Global.BazarRoxana.My.Resources.Resources.ic_account_child_128_28130
        Me.EmpleadoToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmpleadoToolStripMenuItem1.Name = "EmpleadoToolStripMenuItem1"
        Me.EmpleadoToolStripMenuItem1.Size = New System.Drawing.Size(178, 30)
        Me.EmpleadoToolStripMenuItem1.Text = "Empleado         "
        Me.EmpleadoToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ProveedoresToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ProveedoresToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ProveedoresToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProveedoresToolStripMenuItem.Image = Global.BazarRoxana.My.Resources.Resources.ic_local_shipping_128_28443
        Me.ProveedoresToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(178, 30)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        Me.ProveedoresToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ClientesToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ClientesToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientesToolStripMenuItem.Image = Global.BazarRoxana.My.Resources.Resources.ic_face_unlock_128_28406
        Me.ClientesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(178, 30)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        Me.ClientesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.CategoriaToolStripMenuItem.BackgroundImage = CType(resources.GetObject("CategoriaToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.CategoriaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CategoriaToolStripMenuItem.Image = Global.BazarRoxana.My.Resources.Resources.ic_assignment_128_28219
        Me.CategoriaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(178, 30)
        Me.CategoriaToolStripMenuItem.Text = "Categoria"
        Me.CategoriaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ProductoToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ProductoToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ProductoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProductoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductoToolStripMenuItem1, Me.MinimoToolStripMenuItem})
        Me.ProductoToolStripMenuItem.Image = Global.BazarRoxana.My.Resources.Resources.ic_archive_128_28227
        Me.ProductoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(178, 30)
        Me.ProductoToolStripMenuItem.Text = "Inventario"
        Me.ProductoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProductoToolStripMenuItem1
        '
        Me.ProductoToolStripMenuItem1.Name = "ProductoToolStripMenuItem1"
        Me.ProductoToolStripMenuItem1.Size = New System.Drawing.Size(260, 30)
        Me.ProductoToolStripMenuItem1.Text = "Producto"
        '
        'MinimoToolStripMenuItem
        '
        Me.MinimoToolStripMenuItem.Name = "MinimoToolStripMenuItem"
        Me.MinimoToolStripMenuItem.Size = New System.Drawing.Size(260, 30)
        Me.MinimoToolStripMenuItem.Text = "Producto Minimo"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ComprasToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ComprasToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ComprasToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ComprasToolStripMenuItem.Image = Global.BazarRoxana.My.Resources.Resources.ic_shopping_cart_128_28698
        Me.ComprasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(178, 30)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        Me.ComprasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.VentasToolStripMenuItem.BackgroundImage = CType(resources.GetObject("VentasToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.VentasToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VentasToolStripMenuItem.Image = Global.BazarRoxana.My.Resources.Resources.ic_attach_money_128_28210
        Me.VentasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(178, 30)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        Me.VentasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ReportesToolStripMenuItem.BackgroundImage = Global.BazarRoxana.My.Resources.Resources.Blur
        Me.ReportesToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ReportesToolStripMenuItem.Checked = True
        Me.ReportesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprasToolStripMenuItem1, Me.VentasToolStripMenuItem1, Me.ProductosToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.ProveedoresToolStripMenuItem1, Me.ClientesToolStripMenuItem1})
        Me.ReportesToolStripMenuItem.Image = Global.BazarRoxana.My.Resources.Resources.document_icon_icons_com_66534
        Me.ReportesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(178, 30)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.SalirToolStripMenuItem.BackgroundImage = CType(resources.GetObject("SalirToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SalirToolStripMenuItem.Image = Global.BazarRoxana.My.Resources.Resources.Login_37128
        Me.SalirToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(178, 30)
        Me.SalirToolStripMenuItem.Text = "Salir"
        Me.SalirToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComprasToolStripMenuItem1
        '
        Me.ComprasToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodasLasComprasToolStripMenuItem, Me.CompraPorFechaToolStripMenuItem})
        Me.ComprasToolStripMenuItem1.Name = "ComprasToolStripMenuItem1"
        Me.ComprasToolStripMenuItem1.Size = New System.Drawing.Size(207, 30)
        Me.ComprasToolStripMenuItem1.Text = "Compras"
        '
        'TodasLasComprasToolStripMenuItem
        '
        Me.TodasLasComprasToolStripMenuItem.Name = "TodasLasComprasToolStripMenuItem"
        Me.TodasLasComprasToolStripMenuItem.Size = New System.Drawing.Size(270, 30)
        Me.TodasLasComprasToolStripMenuItem.Text = "Todas las Compras"
        '
        'CompraPorFechaToolStripMenuItem
        '
        Me.CompraPorFechaToolStripMenuItem.Name = "CompraPorFechaToolStripMenuItem"
        Me.CompraPorFechaToolStripMenuItem.Size = New System.Drawing.Size(270, 30)
        Me.CompraPorFechaToolStripMenuItem.Text = "Compra por Fecha"
        '
        'VentasToolStripMenuItem1
        '
        Me.VentasToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodasLasVentasToolStripMenuItem, Me.VentasPorFechaToolStripMenuItem})
        Me.VentasToolStripMenuItem1.Name = "VentasToolStripMenuItem1"
        Me.VentasToolStripMenuItem1.Size = New System.Drawing.Size(207, 30)
        Me.VentasToolStripMenuItem1.Text = "Ventas"
        '
        'TodasLasVentasToolStripMenuItem
        '
        Me.TodasLasVentasToolStripMenuItem.Name = "TodasLasVentasToolStripMenuItem"
        Me.TodasLasVentasToolStripMenuItem.Size = New System.Drawing.Size(249, 30)
        Me.TodasLasVentasToolStripMenuItem.Text = "Todas las Ventas"
        '
        'VentasPorFechaToolStripMenuItem
        '
        Me.VentasPorFechaToolStripMenuItem.Name = "VentasPorFechaToolStripMenuItem"
        Me.VentasPorFechaToolStripMenuItem.Size = New System.Drawing.Size(249, 30)
        Me.VentasPorFechaToolStripMenuItem.Text = "Ventas por Fecha"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosPorCategoriaToolStripMenuItem, Me.ProductosMásVendidosToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(207, 30)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ProductosPorCategoriaToolStripMenuItem
        '
        Me.ProductosPorCategoriaToolStripMenuItem.Name = "ProductosPorCategoriaToolStripMenuItem"
        Me.ProductosPorCategoriaToolStripMenuItem.Size = New System.Drawing.Size(328, 30)
        Me.ProductosPorCategoriaToolStripMenuItem.Text = "Productos por Categoria"
        '
        'ProductosMásVendidosToolStripMenuItem
        '
        Me.ProductosMásVendidosToolStripMenuItem.Name = "ProductosMásVendidosToolStripMenuItem"
        Me.ProductosMásVendidosToolStripMenuItem.Size = New System.Drawing.Size(328, 30)
        Me.ProductosMásVendidosToolStripMenuItem.Text = "Productos más Vendidos"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(207, 30)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(207, 30)
        Me.ProveedoresToolStripMenuItem1.Text = "Proveedores"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(207, 30)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 650)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.LblHora)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuPrincipal"
        Me.Text = "Inventario"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmpleadoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LblHora As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ProductoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MinimoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TodasLasComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompraPorFechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TodasLasVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasPorFechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosPorCategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosMásVendidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As ToolStripMenuItem
End Class
