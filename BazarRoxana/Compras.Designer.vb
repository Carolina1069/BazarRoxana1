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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbxPrecio = New System.Windows.Forms.ComboBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.CodProduc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombProduc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantProduc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioProduc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscProd = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.txMaximo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCodProducto = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtNombreProducto = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtUnidades = New System.Windows.Forms.TextBox()
        Me.TxtTipoTransaccion = New System.Windows.Forms.TextBox()
        Me.TxtCodEmple = New System.Windows.Forms.TextBox()
        Me.txNumCompra = New System.Windows.Forms.TextBox()
        Me.lbCodEmple = New System.Windows.Forms.Label()
        Me.lbCodigoProv = New System.Windows.Forms.Label()
        Me.TxtCodProv = New System.Windows.Forms.TextBox()
        Me.lbNumeroCompra = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnsearchProv = New System.Windows.Forms.Button()
        Me.cmbTipoTransac = New System.Windows.Forms.ComboBox()
        Me.cmbTipoPago = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTipoPago = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.CbxPrecio)
        Me.GroupBox1.Controls.Add(Me.DGV)
        Me.GroupBox1.Controls.Add(Me.btnBuscProd)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TxtTotal)
        Me.GroupBox1.Controls.Add(Me.txMaximo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btGuardar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtCodProducto)
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Controls.Add(Me.TxtNombreProducto)
        Me.GroupBox1.Controls.Add(Me.TxtCantidad)
        Me.GroupBox1.Controls.Add(Me.TxtUnidades)
        Me.GroupBox1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(75, 288)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(947, 381)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de la Compra"
        '
        'CbxPrecio
        '
        Me.CbxPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPrecio.FormattingEnabled = True
        Me.CbxPrecio.Location = New System.Drawing.Point(333, 77)
        Me.CbxPrecio.Name = "CbxPrecio"
        Me.CbxPrecio.Size = New System.Drawing.Size(100, 27)
        Me.CbxPrecio.TabIndex = 69
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodProduc, Me.NombProduc, Me.Impuesto, Me.CantProduc, Me.PrecioProduc, Me.SubTotal})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGV.EnableHeadersVisualStyles = False
        Me.DGV.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGV.Location = New System.Drawing.Point(20, 120)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV.RowHeadersWidth = 51
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.DGV.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(900, 194)
        Me.DGV.TabIndex = 68
        '
        'CodProduc
        '
        Me.CodProduc.HeaderText = "Código del producto"
        Me.CodProduc.MinimumWidth = 6
        Me.CodProduc.Name = "CodProduc"
        Me.CodProduc.ReadOnly = True
        '
        'NombProduc
        '
        Me.NombProduc.HeaderText = "Nombre del producto"
        Me.NombProduc.MinimumWidth = 6
        Me.NombProduc.Name = "NombProduc"
        Me.NombProduc.ReadOnly = True
        '
        'Impuesto
        '
        Me.Impuesto.HeaderText = "Impuesto"
        Me.Impuesto.MinimumWidth = 6
        Me.Impuesto.Name = "Impuesto"
        Me.Impuesto.ReadOnly = True
        '
        'CantProduc
        '
        Me.CantProduc.HeaderText = "Cantidad del producto"
        Me.CantProduc.MinimumWidth = 6
        Me.CantProduc.Name = "CantProduc"
        Me.CantProduc.ReadOnly = True
        '
        'PrecioProduc
        '
        Me.PrecioProduc.HeaderText = "Precio del producto"
        Me.PrecioProduc.MinimumWidth = 6
        Me.PrecioProduc.Name = "PrecioProduc"
        Me.PrecioProduc.ReadOnly = True
        '
        'SubTotal
        '
        Me.SubTotal.HeaderText = "Sub total"
        Me.SubTotal.MinimumWidth = 6
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        '
        'btnBuscProd
        '
        Me.btnBuscProd.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscProd.Location = New System.Drawing.Point(36, 23)
        Me.btnBuscProd.Name = "btnBuscProd"
        Me.btnBuscProd.Size = New System.Drawing.Size(116, 35)
        Me.btnBuscProd.TabIndex = 67
        Me.btnBuscProd.Text = "Buscar producto"
        Me.btnBuscProd.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(600, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 19)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Máximo"
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(767, 336)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 27)
        Me.TxtTotal.TabIndex = 59
        '
        'txMaximo
        '
        Me.txMaximo.Enabled = False
        Me.txMaximo.Location = New System.Drawing.Point(602, 78)
        Me.txMaximo.Name = "txMaximo"
        Me.txMaximo.Size = New System.Drawing.Size(134, 27)
        Me.txMaximo.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(718, 339)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 19)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Total"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(903, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 30)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(748, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 19)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Cantidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(453, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 19)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Unidades en Stock"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(333, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 19)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Precio"
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(67, 324)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(82, 42)
        Me.btGuardar.TabIndex = 22
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 19)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Codigo Producto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(181, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 19)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Nombre Producto"
        '
        'TxtCodProducto
        '
        Me.TxtCodProducto.Enabled = False
        Me.TxtCodProducto.Location = New System.Drawing.Point(38, 78)
        Me.TxtCodProducto.Name = "TxtCodProducto"
        Me.TxtCodProducto.Size = New System.Drawing.Size(122, 27)
        Me.TxtCodProducto.TabIndex = 48
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(903, 53)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(31, 30)
        Me.BtnAgregar.TabIndex = 53
        Me.BtnAgregar.Text = "+"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.Enabled = False
        Me.TxtNombreProducto.Location = New System.Drawing.Point(184, 77)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(129, 27)
        Me.TxtNombreProducto.TabIndex = 49
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(750, 77)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(100, 27)
        Me.TxtCantidad.TabIndex = 52
        '
        'TxtUnidades
        '
        Me.TxtUnidades.Enabled = False
        Me.TxtUnidades.Location = New System.Drawing.Point(461, 78)
        Me.TxtUnidades.Name = "TxtUnidades"
        Me.TxtUnidades.Size = New System.Drawing.Size(124, 27)
        Me.TxtUnidades.TabIndex = 51
        '
        'TxtTipoTransaccion
        '
        Me.TxtTipoTransaccion.Enabled = False
        Me.TxtTipoTransaccion.Location = New System.Drawing.Point(709, 124)
        Me.TxtTipoTransaccion.Name = "TxtTipoTransaccion"
        Me.TxtTipoTransaccion.Size = New System.Drawing.Size(168, 27)
        Me.TxtTipoTransaccion.TabIndex = 54
        '
        'TxtCodEmple
        '
        Me.TxtCodEmple.Enabled = False
        Me.TxtCodEmple.Location = New System.Drawing.Point(205, 64)
        Me.TxtCodEmple.Name = "TxtCodEmple"
        Me.TxtCodEmple.Size = New System.Drawing.Size(100, 27)
        Me.TxtCodEmple.TabIndex = 38
        '
        'txNumCompra
        '
        Me.txNumCompra.Enabled = False
        Me.txNumCompra.Location = New System.Drawing.Point(190, 60)
        Me.txNumCompra.Name = "txNumCompra"
        Me.txNumCompra.Size = New System.Drawing.Size(100, 20)
        Me.txNumCompra.TabIndex = 37
        '
        'lbCodEmple
        '
        Me.lbCodEmple.AutoSize = True
        Me.lbCodEmple.Location = New System.Drawing.Point(50, 64)
        Me.lbCodEmple.Name = "lbCodEmple"
        Me.lbCodEmple.Size = New System.Drawing.Size(149, 19)
        Me.lbCodEmple.TabIndex = 36
        Me.lbCodEmple.Text = "Código de Empleado"
        '
        'lbCodigoProv
        '
        Me.lbCodigoProv.AutoSize = True
        Me.lbCodigoProv.Location = New System.Drawing.Point(50, 25)
        Me.lbCodigoProv.Name = "lbCodigoProv"
        Me.lbCodigoProv.Size = New System.Drawing.Size(157, 19)
        Me.lbCodigoProv.TabIndex = 35
        Me.lbCodigoProv.Text = "Código del Proveedor"
        '
        'TxtCodProv
        '
        Me.TxtCodProv.Enabled = False
        Me.TxtCodProv.Location = New System.Drawing.Point(205, 22)
        Me.TxtCodProv.Name = "TxtCodProv"
        Me.TxtCodProv.Size = New System.Drawing.Size(100, 27)
        Me.TxtCodProv.TabIndex = 34
        '
        'lbNumeroCompra
        '
        Me.lbNumeroCompra.AutoSize = True
        Me.lbNumeroCompra.BackColor = System.Drawing.Color.Transparent
        Me.lbNumeroCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumeroCompra.Location = New System.Drawing.Point(53, 67)
        Me.lbNumeroCompra.Name = "lbNumeroCompra"
        Me.lbNumeroCompra.Size = New System.Drawing.Size(114, 13)
        Me.lbNumeroCompra.TabIndex = 33
        Me.lbNumeroCompra.Text = "Número de Compra"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnsearchProv)
        Me.GroupBox2.Controls.Add(Me.cmbTipoTransac)
        Me.GroupBox2.Controls.Add(Me.TxtTipoTransaccion)
        Me.GroupBox2.Controls.Add(Me.cmbTipoPago)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtTipoPago)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtNombreProveedor)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtNombreEmpleado)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtCodProv)
        Me.GroupBox2.Controls.Add(Me.lbCodigoProv)
        Me.GroupBox2.Controls.Add(Me.TxtCodEmple)
        Me.GroupBox2.Controls.Add(Me.lbCodEmple)
        Me.GroupBox2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(75, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(947, 167)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Compra"
        '
        'btnsearchProv
        '
        Me.btnsearchProv.Location = New System.Drawing.Point(311, 20)
        Me.btnsearchProv.Name = "btnsearchProv"
        Me.btnsearchProv.Size = New System.Drawing.Size(85, 29)
        Me.btnsearchProv.TabIndex = 57
        Me.btnsearchProv.Text = "Buscar"
        Me.btnsearchProv.UseVisualStyleBackColor = True
        '
        'cmbTipoTransac
        '
        Me.cmbTipoTransac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbTipoTransac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoTransac.FormattingEnabled = True
        Me.cmbTipoTransac.Items.AddRange(New Object() {"1-Efectivo", "2-Tarjeta de crédito", "3-Tarjeta de débito"})
        Me.cmbTipoTransac.Location = New System.Drawing.Point(709, 91)
        Me.cmbTipoTransac.Name = "cmbTipoTransac"
        Me.cmbTipoTransac.Size = New System.Drawing.Size(168, 27)
        Me.cmbTipoTransac.TabIndex = 56
        '
        'cmbTipoPago
        '
        Me.cmbTipoPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoPago.FormattingEnabled = True
        Me.cmbTipoPago.Items.AddRange(New Object() {"1-Crédito", "2-Contado"})
        Me.cmbTipoPago.Location = New System.Drawing.Point(205, 97)
        Me.cmbTipoPago.Name = "cmbTipoPago"
        Me.cmbTipoPago.Size = New System.Drawing.Size(100, 27)
        Me.cmbTipoPago.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(548, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 19)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Tipo de Transacción"
        '
        'TxtTipoPago
        '
        Me.TxtTipoPago.Enabled = False
        Me.TxtTipoPago.Location = New System.Drawing.Point(205, 127)
        Me.TxtTipoPago.Name = "TxtTipoPago"
        Me.TxtTipoPago.Size = New System.Drawing.Size(168, 27)
        Me.TxtTipoPago.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 19)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Tipo de Pago"
        '
        'TxtNombreProveedor
        '
        Me.TxtNombreProveedor.Enabled = False
        Me.TxtNombreProveedor.Location = New System.Drawing.Point(709, 19)
        Me.TxtNombreProveedor.Name = "TxtNombreProveedor"
        Me.TxtNombreProveedor.Size = New System.Drawing.Size(168, 27)
        Me.TxtNombreProveedor.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(539, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 19)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Nombre del Proveedor"
        '
        'TxtNombreEmpleado
        '
        Me.TxtNombreEmpleado.Enabled = False
        Me.TxtNombreEmpleado.Location = New System.Drawing.Point(709, 58)
        Me.TxtNombreEmpleado.Name = "TxtNombreEmpleado"
        Me.TxtNombreEmpleado.Size = New System.Drawing.Size(168, 27)
        Me.TxtNombreEmpleado.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(539, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 19)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Nombre de Empleado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(542, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 19)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Código de Transacción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 19)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Código de Pago"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BazarRoxana.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(796, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 29)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Compras"
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1053, 681)
        Me.Controls.Add(Me.Label14)
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
    Friend WithEvents btGuardar As Button
    Friend WithEvents TxtCodEmple As TextBox
    Friend WithEvents txNumCompra As TextBox
    Friend WithEvents lbCodEmple As Label
    Friend WithEvents lbCodigoProv As Label
    Friend WithEvents TxtCodProv As TextBox
    Friend WithEvents lbNumeroCompra As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
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
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txMaximo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbTipoTransac As ComboBox
    Friend WithEvents cmbTipoPago As ComboBox
    Friend WithEvents btnsearchProv As Button
    Friend WithEvents btnBuscProd As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents CbxPrecio As ComboBox
    Friend WithEvents CodProduc As DataGridViewTextBoxColumn
    Friend WithEvents NombProduc As DataGridViewTextBoxColumn
    Friend WithEvents Impuesto As DataGridViewTextBoxColumn
    Friend WithEvents CantProduc As DataGridViewTextBoxColumn
    Friend WithEvents PrecioProduc As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
End Class
