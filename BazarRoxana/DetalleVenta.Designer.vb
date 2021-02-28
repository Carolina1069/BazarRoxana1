<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleVenta
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
        Me.txtbuscarVenta = New System.Windows.Forms.TextBox()
        Me.lbBusquedaVenta = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.TxtIVA = New System.Windows.Forms.TextBox()
        Me.txCodVenta = New System.Windows.Forms.TextBox()
        Me.txtNumVenta = New System.Windows.Forms.TextBox()
        Me.LbIVA = New System.Windows.Forms.Label()
        Me.lbCodVenta = New System.Windows.Forms.Label()
        Me.LbPrecioVenta = New System.Windows.Forms.Label()
        Me.lbCantidadVenta = New System.Windows.Forms.Label()
        Me.TxtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.txtCantidadVenta = New System.Windows.Forms.TextBox()
        Me.lbNumeroVenta = New System.Windows.Forms.Label()
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
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.txtbuscarVenta)
        Me.GroupBox1.Controls.Add(Me.lbBusquedaVenta)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 264)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 275)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de la Venta"
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
        'txtbuscarVenta
        '
        Me.txtbuscarVenta.Location = New System.Drawing.Point(170, 29)
        Me.txtbuscarVenta.Name = "txtbuscarVenta"
        Me.txtbuscarVenta.Size = New System.Drawing.Size(206, 20)
        Me.txtbuscarVenta.TabIndex = 20
        '
        'lbBusquedaVenta
        '
        Me.lbBusquedaVenta.AutoSize = True
        Me.lbBusquedaVenta.Location = New System.Drawing.Point(6, 29)
        Me.lbBusquedaVenta.Name = "lbBusquedaVenta"
        Me.lbBusquedaVenta.Size = New System.Drawing.Size(150, 13)
        Me.lbBusquedaVenta.TabIndex = 19
        Me.lbBusquedaVenta.Text = "Escriba el Numero de la Venta"
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
        'TxtIVA
        '
        Me.TxtIVA.Location = New System.Drawing.Point(122, 187)
        Me.TxtIVA.Name = "TxtIVA"
        Me.TxtIVA.Size = New System.Drawing.Size(100, 20)
        Me.TxtIVA.TabIndex = 49
        '
        'txCodVenta
        '
        Me.txCodVenta.Location = New System.Drawing.Point(122, 152)
        Me.txCodVenta.Name = "txCodVenta"
        Me.txCodVenta.Size = New System.Drawing.Size(100, 20)
        Me.txCodVenta.TabIndex = 50
        '
        'txtNumVenta
        '
        Me.txtNumVenta.Location = New System.Drawing.Point(122, 97)
        Me.txtNumVenta.Name = "txtNumVenta"
        Me.txtNumVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtNumVenta.TabIndex = 48
        '
        'LbIVA
        '
        Me.LbIVA.AutoSize = True
        Me.LbIVA.Location = New System.Drawing.Point(92, 194)
        Me.LbIVA.Name = "LbIVA"
        Me.LbIVA.Size = New System.Drawing.Size(24, 13)
        Me.LbIVA.TabIndex = 46
        Me.LbIVA.Text = "IVA"
        '
        'lbCodVenta
        '
        Me.lbCodVenta.AutoSize = True
        Me.lbCodVenta.Location = New System.Drawing.Point(20, 155)
        Me.lbCodVenta.Name = "lbCodVenta"
        Me.lbCodVenta.Size = New System.Drawing.Size(100, 13)
        Me.lbCodVenta.TabIndex = 47
        Me.lbCodVenta.Text = "Codigo de la Vernta"
        '
        'LbPrecioVenta
        '
        Me.LbPrecioVenta.AutoSize = True
        Me.LbPrecioVenta.Location = New System.Drawing.Point(324, 146)
        Me.LbPrecioVenta.Name = "LbPrecioVenta"
        Me.LbPrecioVenta.Size = New System.Drawing.Size(99, 13)
        Me.LbPrecioVenta.TabIndex = 44
        Me.LbPrecioVenta.Text = "Precio del producto"
        '
        'lbCantidadVenta
        '
        Me.lbCantidadVenta.AutoSize = True
        Me.lbCantidadVenta.Location = New System.Drawing.Point(324, 97)
        Me.lbCantidadVenta.Name = "lbCantidadVenta"
        Me.lbCantidadVenta.Size = New System.Drawing.Size(96, 13)
        Me.lbCantidadVenta.TabIndex = 45
        Me.lbCantidadVenta.Text = "Cantidad del venta"
        '
        'TxtPrecioVenta
        '
        Me.TxtPrecioVenta.Location = New System.Drawing.Point(446, 139)
        Me.TxtPrecioVenta.Name = "TxtPrecioVenta"
        Me.TxtPrecioVenta.Size = New System.Drawing.Size(100, 20)
        Me.TxtPrecioVenta.TabIndex = 42
        '
        'txtCantidadVenta
        '
        Me.txtCantidadVenta.Location = New System.Drawing.Point(441, 94)
        Me.txtCantidadVenta.Name = "txtCantidadVenta"
        Me.txtCantidadVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadVenta.TabIndex = 43
        '
        'lbNumeroVenta
        '
        Me.lbNumeroVenta.AutoSize = True
        Me.lbNumeroVenta.Location = New System.Drawing.Point(14, 101)
        Me.lbNumeroVenta.Name = "lbNumeroVenta"
        Me.lbNumeroVenta.Size = New System.Drawing.Size(90, 13)
        Me.lbNumeroVenta.TabIndex = 41
        Me.lbNumeroVenta.Text = "Numero de Venta"
        '
        'DetalleVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 554)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtIVA)
        Me.Controls.Add(Me.txCodVenta)
        Me.Controls.Add(Me.txtNumVenta)
        Me.Controls.Add(Me.LbIVA)
        Me.Controls.Add(Me.lbCodVenta)
        Me.Controls.Add(Me.LbPrecioVenta)
        Me.Controls.Add(Me.lbCantidadVenta)
        Me.Controls.Add(Me.TxtPrecioVenta)
        Me.Controls.Add(Me.txtCantidadVenta)
        Me.Controls.Add(Me.lbNumeroVenta)
        Me.Name = "DetalleVenta"
        Me.Text = "DetalleVenta"
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
    Friend WithEvents txtbuscarVenta As TextBox
    Friend WithEvents lbBusquedaVenta As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents TxtIVA As TextBox
    Friend WithEvents txCodVenta As TextBox
    Friend WithEvents txtNumVenta As TextBox
    Friend WithEvents LbIVA As Label
    Friend WithEvents lbCodVenta As Label
    Friend WithEvents LbPrecioVenta As Label
    Friend WithEvents lbCantidadVenta As Label
    Friend WithEvents TxtPrecioVenta As TextBox
    Friend WithEvents txtCantidadVenta As TextBox
    Friend WithEvents lbNumeroVenta As Label
End Class
