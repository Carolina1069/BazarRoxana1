<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Compras
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.txCodEmple = New System.Windows.Forms.TextBox()
        Me.txNumCompra = New System.Windows.Forms.TextBox()
        Me.lbCodEmple = New System.Windows.Forms.Label()
        Me.lbCodigoProv = New System.Windows.Forms.Label()
        Me.txCodProv = New System.Windows.Forms.TextBox()
        Me.lbNumeroCompra = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnBusquedaTransaccion = New System.Windows.Forms.Button()
        Me.BtnBusquedaPago = New System.Windows.Forms.Button()
        Me.BtnBusquedaEmpleado = New System.Windows.Forms.Button()
        Me.BtnBuscarProv = New System.Windows.Forms.Button()
        Me.TxtCodTransa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodPago = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnBusquedaProducto = New System.Windows.Forms.Button()
        Me.TxtPrecioProduc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCantProduc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtImpuestoImpuesto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCodProduc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btEliminar)
        Me.GroupBox1.Controls.Add(Me.btActualizar)
        Me.GroupBox1.Controls.Add(Me.btGuardar)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.btBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 306)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 275)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de la Compra"
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(477, 246)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btEliminar.TabIndex = 24
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(239, 246)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btActualizar.TabIndex = 23
        Me.btActualizar.Text = "Actualizar"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(6, 246)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btGuardar.TabIndex = 22
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(537, 150)
        Me.DataGridView1.TabIndex = 21
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(31, 29)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btBuscar.TabIndex = 18
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'txCodEmple
        '
        Me.txCodEmple.Location = New System.Drawing.Point(132, 59)
        Me.txCodEmple.Name = "txCodEmple"
        Me.txCodEmple.Size = New System.Drawing.Size(100, 20)
        Me.txCodEmple.TabIndex = 38
        '
        'txNumCompra
        '
        Me.txNumCompra.Location = New System.Drawing.Point(169, 99)
        Me.txNumCompra.Name = "txNumCompra"
        Me.txNumCompra.Size = New System.Drawing.Size(100, 20)
        Me.txNumCompra.TabIndex = 37
        '
        'lbCodEmple
        '
        Me.lbCodEmple.AutoSize = True
        Me.lbCodEmple.Location = New System.Drawing.Point(9, 59)
        Me.lbCodEmple.Name = "lbCodEmple"
        Me.lbCodEmple.Size = New System.Drawing.Size(105, 13)
        Me.lbCodEmple.TabIndex = 36
        Me.lbCodEmple.Text = "Codigo de Empleado"
        '
        'lbCodigoProv
        '
        Me.lbCodigoProv.AutoSize = True
        Me.lbCodigoProv.Location = New System.Drawing.Point(9, 37)
        Me.lbCodigoProv.Name = "lbCodigoProv"
        Me.lbCodigoProv.Size = New System.Drawing.Size(109, 13)
        Me.lbCodigoProv.TabIndex = 35
        Me.lbCodigoProv.Text = "Codigo del Proveedor"
        '
        'txCodProv
        '
        Me.txCodProv.Location = New System.Drawing.Point(132, 34)
        Me.txCodProv.Name = "txCodProv"
        Me.txCodProv.Size = New System.Drawing.Size(100, 20)
        Me.txCodProv.TabIndex = 34
        '
        'lbNumeroCompra
        '
        Me.lbNumeroCompra.AutoSize = True
        Me.lbNumeroCompra.Location = New System.Drawing.Point(70, 102)
        Me.lbNumeroCompra.Name = "lbNumeroCompra"
        Me.lbNumeroCompra.Size = New System.Drawing.Size(98, 13)
        Me.lbNumeroCompra.TabIndex = 33
        Me.lbNumeroCompra.Text = "Numero de Compra"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnBusquedaTransaccion)
        Me.GroupBox2.Controls.Add(Me.BtnBusquedaPago)
        Me.GroupBox2.Controls.Add(Me.BtnBusquedaEmpleado)
        Me.GroupBox2.Controls.Add(Me.BtnBuscarProv)
        Me.GroupBox2.Controls.Add(Me.TxtCodTransa)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtCodPago)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txCodProv)
        Me.GroupBox2.Controls.Add(Me.lbCodigoProv)
        Me.GroupBox2.Controls.Add(Me.txCodEmple)
        Me.GroupBox2.Controls.Add(Me.lbCodEmple)
        Me.GroupBox2.Location = New System.Drawing.Point(62, 125)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(278, 175)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Compra"
        '
        'BtnBusquedaTransaccion
        '
        Me.BtnBusquedaTransaccion.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBusquedaTransaccion.Location = New System.Drawing.Point(239, 109)
        Me.BtnBusquedaTransaccion.Name = "BtnBusquedaTransaccion"
        Me.BtnBusquedaTransaccion.Size = New System.Drawing.Size(29, 23)
        Me.BtnBusquedaTransaccion.TabIndex = 46
        Me.BtnBusquedaTransaccion.Text = "..."
        Me.BtnBusquedaTransaccion.UseVisualStyleBackColor = False
        '
        'BtnBusquedaPago
        '
        Me.BtnBusquedaPago.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBusquedaPago.Location = New System.Drawing.Point(239, 83)
        Me.BtnBusquedaPago.Name = "BtnBusquedaPago"
        Me.BtnBusquedaPago.Size = New System.Drawing.Size(29, 23)
        Me.BtnBusquedaPago.TabIndex = 45
        Me.BtnBusquedaPago.Text = "..."
        Me.BtnBusquedaPago.UseVisualStyleBackColor = False
        '
        'BtnBusquedaEmpleado
        '
        Me.BtnBusquedaEmpleado.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBusquedaEmpleado.Location = New System.Drawing.Point(238, 57)
        Me.BtnBusquedaEmpleado.Name = "BtnBusquedaEmpleado"
        Me.BtnBusquedaEmpleado.Size = New System.Drawing.Size(29, 23)
        Me.BtnBusquedaEmpleado.TabIndex = 44
        Me.BtnBusquedaEmpleado.Text = "..."
        Me.BtnBusquedaEmpleado.UseVisualStyleBackColor = False
        '
        'BtnBuscarProv
        '
        Me.BtnBuscarProv.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBuscarProv.Location = New System.Drawing.Point(238, 32)
        Me.BtnBuscarProv.Name = "BtnBuscarProv"
        Me.BtnBuscarProv.Size = New System.Drawing.Size(29, 23)
        Me.BtnBuscarProv.TabIndex = 43
        Me.BtnBuscarProv.Text = "..."
        Me.BtnBuscarProv.UseVisualStyleBackColor = False
        '
        'TxtCodTransa
        '
        Me.TxtCodTransa.Location = New System.Drawing.Point(132, 111)
        Me.TxtCodTransa.Name = "TxtCodTransa"
        Me.TxtCodTransa.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodTransa.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Codigo de Transaccion"
        '
        'TxtCodPago
        '
        Me.TxtCodPago.Location = New System.Drawing.Point(132, 85)
        Me.TxtCodPago.Name = "TxtCodPago"
        Me.TxtCodPago.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodPago.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Codigo de Pago"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnBusquedaProducto)
        Me.GroupBox3.Controls.Add(Me.TxtPrecioProduc)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TxtCantProduc)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtImpuestoImpuesto)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtCodProduc)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(346, 125)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(274, 175)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle de Compra"
        '
        'BtnBusquedaProducto
        '
        Me.BtnBusquedaProducto.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBusquedaProducto.Location = New System.Drawing.Point(236, 31)
        Me.BtnBusquedaProducto.Name = "BtnBusquedaProducto"
        Me.BtnBusquedaProducto.Size = New System.Drawing.Size(29, 23)
        Me.BtnBusquedaProducto.TabIndex = 47
        Me.BtnBusquedaProducto.Text = "..."
        Me.BtnBusquedaProducto.UseVisualStyleBackColor = False
        '
        'TxtPrecioProduc
        '
        Me.TxtPrecioProduc.Location = New System.Drawing.Point(130, 111)
        Me.TxtPrecioProduc.Name = "TxtPrecioProduc"
        Me.TxtPrecioProduc.Size = New System.Drawing.Size(100, 20)
        Me.TxtPrecioProduc.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Precio del Producto"
        '
        'TxtCantProduc
        '
        Me.TxtCantProduc.Location = New System.Drawing.Point(130, 85)
        Me.TxtCantProduc.Name = "TxtCantProduc"
        Me.TxtCantProduc.Size = New System.Drawing.Size(100, 20)
        Me.TxtCantProduc.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Cantidad del Producto"
        '
        'TxtImpuestoImpuesto
        '
        Me.TxtImpuestoImpuesto.Location = New System.Drawing.Point(130, 59)
        Me.TxtImpuestoImpuesto.Name = "TxtImpuestoImpuesto"
        Me.TxtImpuestoImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.TxtImpuestoImpuesto.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(68, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Impuesto"
        '
        'TxtCodProduc
        '
        Me.TxtCodProduc.Location = New System.Drawing.Point(130, 33)
        Me.TxtCodProduc.Name = "TxtCodProduc"
        Me.TxtCodProduc.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodProduc.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Codigo de Producto"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(576, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 51)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 650)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txNumCompra)
        Me.Controls.Add(Me.lbNumeroCompra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Compras"
        Me.Text = "Compras"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btEliminar As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btBuscar As Button
    Friend WithEvents txCodEmple As TextBox
    Friend WithEvents txNumCompra As TextBox
    Friend WithEvents lbCodEmple As Label
    Friend WithEvents lbCodigoProv As Label
    Friend WithEvents txCodProv As TextBox
    Friend WithEvents lbNumeroCompra As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtCodPago As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCodTransa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtPrecioProduc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtCantProduc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtImpuestoImpuesto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCodProduc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnBusquedaTransaccion As Button
    Friend WithEvents BtnBusquedaPago As Button
    Friend WithEvents BtnBusquedaEmpleado As Button
    Friend WithEvents BtnBuscarProv As Button
    Friend WithEvents BtnBusquedaProducto As Button
End Class
