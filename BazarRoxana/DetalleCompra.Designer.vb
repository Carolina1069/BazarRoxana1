<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleCompra
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtbuscarCompra = New System.Windows.Forms.TextBox()
        Me.lbBusquedaCompra = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txCodProducto = New System.Windows.Forms.TextBox()
        Me.txtNumCompra = New System.Windows.Forms.TextBox()
        Me.lbCodProducto = New System.Windows.Forms.Label()
        Me.lbCantidadProducto = New System.Windows.Forms.Label()
        Me.txtCantidadProducto = New System.Windows.Forms.TextBox()
        Me.lbNumeroCompra = New System.Windows.Forms.Label()
        Me.LbIVA = New System.Windows.Forms.Label()
        Me.TxtIVA = New System.Windows.Forms.TextBox()
        Me.TxtPrecioProducto = New System.Windows.Forms.TextBox()
        Me.LbPrecioProducto = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(233, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 51)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.txtbuscarCompra)
        Me.GroupBox1.Controls.Add(Me.lbBusquedaCompra)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 264)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 275)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de la Compra"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(448, 244)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 25
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(318, 244)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 24
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(174, 244)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 23
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(31, 244)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(511, 150)
        Me.DataGridView1.TabIndex = 21
        '
        'txtbuscarCompra
        '
        Me.txtbuscarCompra.Location = New System.Drawing.Point(170, 29)
        Me.txtbuscarCompra.Name = "txtbuscarCompra"
        Me.txtbuscarCompra.Size = New System.Drawing.Size(206, 20)
        Me.txtbuscarCompra.TabIndex = 20
        '
        'lbBusquedaCompra
        '
        Me.lbBusquedaCompra.AutoSize = True
        Me.lbBusquedaCompra.Location = New System.Drawing.Point(6, 29)
        Me.lbBusquedaCompra.Name = "lbBusquedaCompra"
        Me.lbBusquedaCompra.Size = New System.Drawing.Size(158, 13)
        Me.lbBusquedaCompra.TabIndex = 19
        Me.lbBusquedaCompra.Text = "Escriba el Numero de la Compra"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(411, 24)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 18
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txCodProducto
        '
        Me.txCodProducto.Location = New System.Drawing.Point(122, 152)
        Me.txCodProducto.Name = "txCodProducto"
        Me.txCodProducto.Size = New System.Drawing.Size(100, 20)
        Me.txCodProducto.TabIndex = 38
        '
        'txtNumCompra
        '
        Me.txtNumCompra.Location = New System.Drawing.Point(122, 97)
        Me.txtNumCompra.Name = "txtNumCompra"
        Me.txtNumCompra.Size = New System.Drawing.Size(100, 20)
        Me.txtNumCompra.TabIndex = 37
        '
        'lbCodProducto
        '
        Me.lbCodProducto.AutoSize = True
        Me.lbCodProducto.Location = New System.Drawing.Point(20, 155)
        Me.lbCodProducto.Name = "lbCodProducto"
        Me.lbCodProducto.Size = New System.Drawing.Size(102, 13)
        Me.lbCodProducto.TabIndex = 36
        Me.lbCodProducto.Text = "Codigo del producto"
        '
        'lbCantidadProducto
        '
        Me.lbCantidadProducto.AutoSize = True
        Me.lbCantidadProducto.Location = New System.Drawing.Point(324, 97)
        Me.lbCantidadProducto.Name = "lbCantidadProducto"
        Me.lbCantidadProducto.Size = New System.Drawing.Size(111, 13)
        Me.lbCantidadProducto.TabIndex = 35
        Me.lbCantidadProducto.Text = "Cantidad del producto"
        '
        'txtCantidadProducto
        '
        Me.txtCantidadProducto.Location = New System.Drawing.Point(441, 94)
        Me.txtCantidadProducto.Name = "txtCantidadProducto"
        Me.txtCantidadProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadProducto.TabIndex = 34
        '
        'lbNumeroCompra
        '
        Me.lbNumeroCompra.AutoSize = True
        Me.lbNumeroCompra.Location = New System.Drawing.Point(14, 101)
        Me.lbNumeroCompra.Name = "lbNumeroCompra"
        Me.lbNumeroCompra.Size = New System.Drawing.Size(98, 13)
        Me.lbNumeroCompra.TabIndex = 33
        Me.lbNumeroCompra.Text = "Numero de Compra"
        '
        'LbIVA
        '
        Me.LbIVA.AutoSize = True
        Me.LbIVA.Location = New System.Drawing.Point(92, 194)
        Me.LbIVA.Name = "LbIVA"
        Me.LbIVA.Size = New System.Drawing.Size(24, 13)
        Me.LbIVA.TabIndex = 36
        Me.LbIVA.Text = "IVA"
        '
        'TxtIVA
        '
        Me.TxtIVA.Location = New System.Drawing.Point(122, 187)
        Me.TxtIVA.Name = "TxtIVA"
        Me.TxtIVA.Size = New System.Drawing.Size(100, 20)
        Me.TxtIVA.TabIndex = 38
        '
        'TxtPrecioProducto
        '
        Me.TxtPrecioProducto.Location = New System.Drawing.Point(446, 139)
        Me.TxtPrecioProducto.Name = "TxtPrecioProducto"
        Me.TxtPrecioProducto.Size = New System.Drawing.Size(100, 20)
        Me.TxtPrecioProducto.TabIndex = 34
        '
        'LbPrecioProducto
        '
        Me.LbPrecioProducto.AutoSize = True
        Me.LbPrecioProducto.Location = New System.Drawing.Point(324, 146)
        Me.LbPrecioProducto.Name = "LbPrecioProducto"
        Me.LbPrecioProducto.Size = New System.Drawing.Size(99, 13)
        Me.LbPrecioProducto.TabIndex = 35
        Me.LbPrecioProducto.Text = "Precio del producto"
        '
        'DetalleCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 554)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtIVA)
        Me.Controls.Add(Me.txCodProducto)
        Me.Controls.Add(Me.txtNumCompra)
        Me.Controls.Add(Me.LbIVA)
        Me.Controls.Add(Me.lbCodProducto)
        Me.Controls.Add(Me.LbPrecioProducto)
        Me.Controls.Add(Me.lbCantidadProducto)
        Me.Controls.Add(Me.TxtPrecioProducto)
        Me.Controls.Add(Me.txtCantidadProducto)
        Me.Controls.Add(Me.lbNumeroCompra)
        Me.Name = "DetalleCompra"
        Me.Text = "DetalleCompra"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtbuscarCompra As TextBox
    Friend WithEvents lbBusquedaCompra As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txCodProducto As TextBox
    Friend WithEvents txtNumCompra As TextBox
    Friend WithEvents lbCodProducto As Label
    Friend WithEvents lbCantidadProducto As Label
    Friend WithEvents txtCantidadProducto As TextBox
    Friend WithEvents lbNumeroCompra As Label
    Friend WithEvents LbIVA As Label
    Friend WithEvents TxtIVA As TextBox
    Friend WithEvents TxtPrecioProducto As TextBox
    Friend WithEvents LbPrecioProducto As Label
End Class
