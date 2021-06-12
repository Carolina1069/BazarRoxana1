<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventas
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtTipoTransaccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTipoPago = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCodTransa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodPago = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCodCli = New System.Windows.Forms.TextBox()
        Me.lbCodigoCli = New System.Windows.Forms.Label()
        Me.TxtCodEmple = New System.Windows.Forms.TextBox()
        Me.lbCodEmple = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txMinimo = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CbxPrecio = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.NumVent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodProduc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombProduc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCodProducto = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtNombreProducto = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtUnidades = New System.Windows.Forms.TextBox()
        Me.txNumVenta = New System.Windows.Forms.TextBox()
        Me.lbNumeroVenta = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TxtTipoTransaccion)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtTipoPago)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtNombreCliente)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtNombreEmpleado)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtCodTransa)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtCodPago)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtCodCli)
        Me.GroupBox2.Controls.Add(Me.lbCodigoCli)
        Me.GroupBox2.Controls.Add(Me.TxtCodEmple)
        Me.GroupBox2.Controls.Add(Me.lbCodEmple)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(48, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(847, 175)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Venta"
        '
        'TxtTipoTransaccion
        '
        Me.TxtTipoTransaccion.Enabled = False
        Me.TxtTipoTransaccion.Location = New System.Drawing.Point(584, 110)
        Me.TxtTipoTransaccion.Name = "TxtTipoTransaccion"
        Me.TxtTipoTransaccion.Size = New System.Drawing.Size(174, 20)
        Me.TxtTipoTransaccion.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(454, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Tipo de Transaccion"
        '
        'TxtTipoPago
        '
        Me.TxtTipoPago.Enabled = False
        Me.TxtTipoPago.Location = New System.Drawing.Point(584, 84)
        Me.TxtTipoPago.Name = "TxtTipoPago"
        Me.TxtTipoPago.Size = New System.Drawing.Size(174, 20)
        Me.TxtTipoPago.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(454, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Tipo de Pago"
        '
        'TxtNombreCliente
        '
        Me.TxtNombreCliente.Enabled = False
        Me.TxtNombreCliente.Location = New System.Drawing.Point(584, 33)
        Me.TxtNombreCliente.Name = "TxtNombreCliente"
        Me.TxtNombreCliente.Size = New System.Drawing.Size(174, 20)
        Me.TxtNombreCliente.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(454, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Nombre del Cliente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtNombreEmpleado
        '
        Me.TxtNombreEmpleado.Enabled = False
        Me.TxtNombreEmpleado.Location = New System.Drawing.Point(584, 58)
        Me.TxtNombreEmpleado.Name = "TxtNombreEmpleado"
        Me.TxtNombreEmpleado.Size = New System.Drawing.Size(174, 20)
        Me.TxtNombreEmpleado.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(454, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Nombre de Empleado"
        '
        'TxtCodTransa
        '
        Me.TxtCodTransa.Location = New System.Drawing.Point(219, 110)
        Me.TxtCodTransa.MaxLength = 1
        Me.TxtCodTransa.Name = "TxtCodTransa"
        Me.TxtCodTransa.Size = New System.Drawing.Size(125, 20)
        Me.TxtCodTransa.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Codigo de Transaccion"
        '
        'TxtCodPago
        '
        Me.TxtCodPago.Location = New System.Drawing.Point(219, 84)
        Me.TxtCodPago.MaxLength = 1
        Me.TxtCodPago.Name = "TxtCodPago"
        Me.TxtCodPago.Size = New System.Drawing.Size(125, 20)
        Me.TxtCodPago.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Codigo de Pago"
        '
        'TxtCodCli
        '
        Me.TxtCodCli.Location = New System.Drawing.Point(219, 33)
        Me.TxtCodCli.Name = "TxtCodCli"
        Me.TxtCodCli.Size = New System.Drawing.Size(125, 20)
        Me.TxtCodCli.TabIndex = 34
        '
        'lbCodigoCli
        '
        Me.lbCodigoCli.AutoSize = True
        Me.lbCodigoCli.Location = New System.Drawing.Point(75, 36)
        Me.lbCodigoCli.Name = "lbCodigoCli"
        Me.lbCodigoCli.Size = New System.Drawing.Size(110, 13)
        Me.lbCodigoCli.TabIndex = 35
        Me.lbCodigoCli.Text = "Codigo del Cliente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtCodEmple
        '
        Me.TxtCodEmple.Location = New System.Drawing.Point(219, 58)
        Me.TxtCodEmple.Name = "TxtCodEmple"
        Me.TxtCodEmple.Size = New System.Drawing.Size(125, 20)
        Me.TxtCodEmple.TabIndex = 38
        '
        'lbCodEmple
        '
        Me.lbCodEmple.AutoSize = True
        Me.lbCodEmple.Location = New System.Drawing.Point(75, 58)
        Me.lbCodEmple.Name = "lbCodEmple"
        Me.lbCodEmple.Size = New System.Drawing.Size(123, 13)
        Me.lbCodEmple.TabIndex = 36
        Me.lbCodEmple.Text = "Codigo de Empleado"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BazarRoxana.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(677, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnImprimir)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txMinimo)
        Me.GroupBox1.Controls.Add(Me.TxtTotal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.CbxPrecio)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
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
        Me.GroupBox1.Location = New System.Drawing.Point(50, 324)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(845, 314)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de la Venta"
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Location = New System.Drawing.Point(121, 278)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.BtnImprimir.TabIndex = 62
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(559, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 13)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Unidades Minimas"
        '
        'txMinimo
        '
        Me.txMinimo.Enabled = False
        Me.txMinimo.Location = New System.Drawing.Point(561, 41)
        Me.txMinimo.Name = "txMinimo"
        Me.txMinimo.Size = New System.Drawing.Size(100, 20)
        Me.txMinimo.TabIndex = 60
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(718, 278)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotal.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(681, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Total"
        '
        'CbxPrecio
        '
        Me.CbxPrecio.FormattingEnabled = True
        Me.CbxPrecio.Location = New System.Drawing.Point(318, 40)
        Me.CbxPrecio.Name = "CbxPrecio"
        Me.CbxPrecio.Size = New System.Drawing.Size(100, 21)
        Me.CbxPrecio.TabIndex = 42
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(787, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 20)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(688, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Cantidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(437, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 13)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Unidades en Stock"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(318, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Precio"
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(26, 278)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btGuardar.TabIndex = 22
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Codigo Producto"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumVent, Me.CodProduc, Me.NombProduc, Me.Impuesto, Me.CantVenta, Me.PrecioVenta, Me.SubTotal})
        Me.DGV.Location = New System.Drawing.Point(22, 81)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.Size = New System.Drawing.Size(796, 176)
        Me.DGV.TabIndex = 21
        '
        'NumVent
        '
        Me.NumVent.HeaderText = "Numero de Venta"
        Me.NumVent.MinimumWidth = 6
        Me.NumVent.Name = "NumVent"
        Me.NumVent.Width = 125
        '
        'CodProduc
        '
        Me.CodProduc.HeaderText = "Codigo de Producto"
        Me.CodProduc.MinimumWidth = 6
        Me.CodProduc.Name = "CodProduc"
        Me.CodProduc.Width = 125
        '
        'NombProduc
        '
        Me.NombProduc.HeaderText = "Nombre del Producto"
        Me.NombProduc.MinimumWidth = 6
        Me.NombProduc.Name = "NombProduc"
        Me.NombProduc.Width = 125
        '
        'Impuesto
        '
        Me.Impuesto.HeaderText = "Impuesto"
        Me.Impuesto.MinimumWidth = 6
        Me.Impuesto.Name = "Impuesto"
        Me.Impuesto.Width = 125
        '
        'CantVenta
        '
        Me.CantVenta.HeaderText = "Cantidad del Producto"
        Me.CantVenta.MinimumWidth = 6
        Me.CantVenta.Name = "CantVenta"
        Me.CantVenta.Width = 125
        '
        'PrecioVenta
        '
        Me.PrecioVenta.HeaderText = "Precio del Producto"
        Me.PrecioVenta.MinimumWidth = 6
        Me.PrecioVenta.Name = "PrecioVenta"
        Me.PrecioVenta.Width = 125
        '
        'SubTotal
        '
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.MinimumWidth = 6
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.Width = 125
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(177, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Nombre Producto"
        '
        'TxtCodProducto
        '
        Me.TxtCodProducto.Location = New System.Drawing.Point(58, 41)
        Me.TxtCodProducto.Name = "TxtCodProducto"
        Me.TxtCodProducto.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodProducto.TabIndex = 48
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(787, 25)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(26, 20)
        Me.BtnAgregar.TabIndex = 53
        Me.BtnAgregar.Text = "+"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.Enabled = False
        Me.TxtNombreProducto.Location = New System.Drawing.Point(180, 40)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombreProducto.TabIndex = 49
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(681, 41)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtCantidad.TabIndex = 52
        '
        'TxtUnidades
        '
        Me.TxtUnidades.Enabled = False
        Me.TxtUnidades.Location = New System.Drawing.Point(445, 41)
        Me.TxtUnidades.Name = "TxtUnidades"
        Me.TxtUnidades.Size = New System.Drawing.Size(100, 20)
        Me.TxtUnidades.TabIndex = 51
        '
        'txNumVenta
        '
        Me.txNumVenta.Location = New System.Drawing.Point(161, 95)
        Me.txNumVenta.Name = "txNumVenta"
        Me.txNumVenta.Size = New System.Drawing.Size(100, 20)
        Me.txNumVenta.TabIndex = 43
        '
        'lbNumeroVenta
        '
        Me.lbNumeroVenta.AutoSize = True
        Me.lbNumeroVenta.BackColor = System.Drawing.Color.Transparent
        Me.lbNumeroVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumeroVenta.Location = New System.Drawing.Point(50, 98)
        Me.lbNumeroVenta.Name = "lbNumeroVenta"
        Me.lbNumeroVenta.Size = New System.Drawing.Size(105, 13)
        Me.lbNumeroVenta.TabIndex = 42
        Me.lbNumeroVenta.Text = "Numero de Venta"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Clarendon BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 29)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Ventas"
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BazarRoxana.My.Resources.Resources.A
        Me.ClientSize = New System.Drawing.Size(934, 650)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txNumVenta)
        Me.Controls.Add(Me.lbNumeroVenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtTipoTransaccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTipoPago As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNombreCliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNombreEmpleado As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCodTransa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCodPago As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCodCli As TextBox
    Friend WithEvents lbCodigoCli As Label
    Friend WithEvents TxtCodEmple As TextBox
    Friend WithEvents lbCodEmple As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CbxPrecio As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btGuardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtCodProducto As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtNombreProducto As TextBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents TxtUnidades As TextBox
    Friend WithEvents txNumVenta As TextBox
    Friend WithEvents lbNumeroVenta As Label
    Friend WithEvents NumVent As DataGridViewTextBoxColumn
    Friend WithEvents CodProduc As DataGridViewTextBoxColumn
    Friend WithEvents NombProduc As DataGridViewTextBoxColumn
    Friend WithEvents Impuesto As DataGridViewTextBoxColumn
    Friend WithEvents CantVenta As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVenta As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents Label13 As Label
    Friend WithEvents txMinimo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnImprimir As Button
End Class
