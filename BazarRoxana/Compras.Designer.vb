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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CbxPrecio = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.NumCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodProduc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombProduc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantProduc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioProduc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCodProducto = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtNombreProducto = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtUnidades = New System.Windows.Forms.TextBox()
        Me.TxtCodEmple = New System.Windows.Forms.TextBox()
        Me.txNumCompra = New System.Windows.Forms.TextBox()
        Me.lbCodEmple = New System.Windows.Forms.Label()
        Me.lbCodigoProv = New System.Windows.Forms.Label()
        Me.TxtCodProv = New System.Windows.Forms.TextBox()
        Me.lbNumeroCompra = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtTipoTransaccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTipoPago = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCodTransa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodPago = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtTotal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.CbxPrecio)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btEliminar)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btActualizar)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btGuardar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DGV)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtCodProducto)
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Controls.Add(Me.TxtNombreProducto)
        Me.GroupBox1.Controls.Add(Me.TxtCantidad)
        Me.GroupBox1.Controls.Add(Me.TxtUnidades)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(47, 328)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(570, 275)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de la Compra"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(463, 246)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotal.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(426, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Total"
        '
        'CbxPrecio
        '
        Me.CbxPrecio.FormattingEnabled = True
        Me.CbxPrecio.Location = New System.Drawing.Point(219, 41)
        Me.CbxPrecio.Name = "CbxPrecio"
        Me.CbxPrecio.Size = New System.Drawing.Size(100, 21)
        Me.CbxPrecio.TabIndex = 42
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(537, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 20)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(244, 246)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btEliminar.TabIndex = 24
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(428, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Cantidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(323, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 13)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Unidades en Stock"
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(125, 246)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btActualizar.TabIndex = 23
        Me.btActualizar.Text = "Actualizar"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(219, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Precio"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Codigo Producto"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumCompra, Me.CodProduc, Me.NombProduc, Me.Impuesto, Me.CantProduc, Me.PrecioProduc, Me.SubTotal})
        Me.DGV.Location = New System.Drawing.Point(12, 74)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.Size = New System.Drawing.Size(537, 150)
        Me.DGV.TabIndex = 21
        '
        'NumCompra
        '
        Me.NumCompra.HeaderText = "Numero de Compra"
        Me.NumCompra.Name = "NumCompra"
        '
        'CodProduc
        '
        Me.CodProduc.HeaderText = "Codigo de Producto"
        Me.CodProduc.Name = "CodProduc"
        '
        'NombProduc
        '
        Me.NombProduc.HeaderText = "Nombre del Producto"
        Me.NombProduc.Name = "NombProduc"
        '
        'Impuesto
        '
        Me.Impuesto.HeaderText = "Impuesto"
        Me.Impuesto.Name = "Impuesto"
        '
        'CantProduc
        '
        Me.CantProduc.HeaderText = "Cantidad del Producto"
        Me.CantProduc.Name = "CantProduc"
        '
        'PrecioProduc
        '
        Me.PrecioProduc.HeaderText = "Precio del Producto"
        Me.PrecioProduc.Name = "PrecioProduc"
        '
        'SubTotal
        '
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.Name = "SubTotal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(110, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Nombre Producto"
        '
        'TxtCodProducto
        '
        Me.TxtCodProducto.Location = New System.Drawing.Point(7, 41)
        Me.TxtCodProducto.Name = "TxtCodProducto"
        Me.TxtCodProducto.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodProducto.TabIndex = 48
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(537, 25)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(26, 20)
        Me.BtnAgregar.TabIndex = 53
        Me.BtnAgregar.Text = "+"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.Location = New System.Drawing.Point(113, 41)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombreProducto.TabIndex = 49
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(431, 41)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtCantidad.TabIndex = 52
        '
        'TxtUnidades
        '
        Me.TxtUnidades.Location = New System.Drawing.Point(325, 41)
        Me.TxtUnidades.Name = "TxtUnidades"
        Me.TxtUnidades.Size = New System.Drawing.Size(100, 20)
        Me.TxtUnidades.TabIndex = 51
        '
        'TxtCodEmple
        '
        Me.TxtCodEmple.Location = New System.Drawing.Point(147, 59)
        Me.TxtCodEmple.Name = "TxtCodEmple"
        Me.TxtCodEmple.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodEmple.TabIndex = 38
        '
        'txNumCompra
        '
        Me.txNumCompra.Location = New System.Drawing.Point(173, 102)
        Me.txNumCompra.Name = "txNumCompra"
        Me.txNumCompra.Size = New System.Drawing.Size(100, 20)
        Me.txNumCompra.TabIndex = 37
        '
        'lbCodEmple
        '
        Me.lbCodEmple.AutoSize = True
        Me.lbCodEmple.Location = New System.Drawing.Point(3, 59)
        Me.lbCodEmple.Name = "lbCodEmple"
        Me.lbCodEmple.Size = New System.Drawing.Size(123, 13)
        Me.lbCodEmple.TabIndex = 36
        Me.lbCodEmple.Text = "Codigo de Empleado"
        '
        'lbCodigoProv
        '
        Me.lbCodigoProv.AutoSize = True
        Me.lbCodigoProv.Location = New System.Drawing.Point(3, 37)
        Me.lbCodigoProv.Name = "lbCodigoProv"
        Me.lbCodigoProv.Size = New System.Drawing.Size(129, 13)
        Me.lbCodigoProv.TabIndex = 35
        Me.lbCodigoProv.Text = "Codigo del Proveedor"
        '
        'TxtCodProv
        '
        Me.TxtCodProv.Location = New System.Drawing.Point(147, 34)
        Me.TxtCodProv.Name = "TxtCodProv"
        Me.TxtCodProv.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodProv.TabIndex = 34
        '
        'lbNumeroCompra
        '
        Me.lbNumeroCompra.AutoSize = True
        Me.lbNumeroCompra.BackColor = System.Drawing.Color.Transparent
        Me.lbNumeroCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumeroCompra.Location = New System.Drawing.Point(53, 102)
        Me.lbNumeroCompra.Name = "lbNumeroCompra"
        Me.lbNumeroCompra.Size = New System.Drawing.Size(114, 13)
        Me.lbNumeroCompra.TabIndex = 33
        Me.lbNumeroCompra.Text = "Numero de Compra"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TxtTipoTransaccion)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtTipoPago)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtNombreProveedor)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtNombreEmpleado)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtCodTransa)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtCodPago)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtCodProv)
        Me.GroupBox2.Controls.Add(Me.lbCodigoProv)
        Me.GroupBox2.Controls.Add(Me.TxtCodEmple)
        Me.GroupBox2.Controls.Add(Me.lbCodEmple)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(45, 125)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(572, 175)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Compra"
        '
        'TxtTipoTransaccion
        '
        Me.TxtTipoTransaccion.Location = New System.Drawing.Point(394, 111)
        Me.TxtTipoTransaccion.Name = "TxtTipoTransaccion"
        Me.TxtTipoTransaccion.Size = New System.Drawing.Size(100, 20)
        Me.TxtTipoTransaccion.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(264, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Tipo de Transaccion"
        '
        'TxtTipoPago
        '
        Me.TxtTipoPago.Location = New System.Drawing.Point(394, 85)
        Me.TxtTipoPago.Name = "TxtTipoPago"
        Me.TxtTipoPago.Size = New System.Drawing.Size(100, 20)
        Me.TxtTipoPago.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(264, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Tipo de Pago"
        '
        'TxtNombreProveedor
        '
        Me.TxtNombreProveedor.Location = New System.Drawing.Point(394, 34)
        Me.TxtNombreProveedor.Name = "TxtNombreProveedor"
        Me.TxtNombreProveedor.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombreProveedor.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(264, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Nombre del Proveedor"
        '
        'TxtNombreEmpleado
        '
        Me.TxtNombreEmpleado.Location = New System.Drawing.Point(394, 59)
        Me.TxtNombreEmpleado.Name = "TxtNombreEmpleado"
        Me.TxtNombreEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombreEmpleado.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(264, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Nombre de Empleado"
        '
        'TxtCodTransa
        '
        Me.TxtCodTransa.Location = New System.Drawing.Point(147, 111)
        Me.TxtCodTransa.Name = "TxtCodTransa"
        Me.TxtCodTransa.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodTransa.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Codigo de Transaccion"
        '
        'TxtCodPago
        '
        Me.TxtCodPago.Location = New System.Drawing.Point(147, 85)
        Me.TxtCodPago.Name = "TxtCodPago"
        Me.TxtCodPago.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodPago.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Codigo de Pago"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BazarRoxana.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(409, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BazarRoxana.My.Resources.Resources.WhatsApp_Image_2021_04_08_at_10_15_57_PM
        Me.ClientSize = New System.Drawing.Size(666, 650)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txNumCompra)
        Me.Controls.Add(Me.lbNumeroCompra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Compras"
        Me.Text = "Compras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btEliminar As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents TxtCodEmple As TextBox
    Friend WithEvents txNumCompra As TextBox
    Friend WithEvents lbCodEmple As Label
    Friend WithEvents lbCodigoProv As Label
    Friend WithEvents TxtCodProv As TextBox
    Friend WithEvents lbNumeroCompra As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtCodPago As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCodTransa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtCodProducto As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtNombreProducto As TextBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents TxtUnidades As TextBox
    Friend WithEvents TxtTipoTransaccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTipoPago As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNombreProveedor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNombreEmpleado As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CbxPrecio As ComboBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents NumCompra As DataGridViewTextBoxColumn
    Friend WithEvents CodProduc As DataGridViewTextBoxColumn
    Friend WithEvents NombProduc As DataGridViewTextBoxColumn
    Friend WithEvents Impuesto As DataGridViewTextBoxColumn
    Friend WithEvents CantProduc As DataGridViewTextBoxColumn
    Friend WithEvents PrecioProduc As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
