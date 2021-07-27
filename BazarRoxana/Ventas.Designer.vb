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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscarCliente = New System.Windows.Forms.Button()
        Me.CbxTipoTransac = New System.Windows.Forms.ComboBox()
        Me.CbxTipoPago = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCodCli = New System.Windows.Forms.TextBox()
        Me.lbCodigoCli = New System.Windows.Forms.Label()
        Me.TxtCodEmple = New System.Windows.Forms.TextBox()
        Me.lbCodEmple = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtArticulo = New System.Windows.Forms.TextBox()
        Me.LblContador1 = New System.Windows.Forms.Label()
        Me.LblContador = New System.Windows.Forms.Label()
        Me.BtnBuscarProducto = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtUnidadesMinimas = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CbxPrecio = New System.Windows.Forms.ComboBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.CodProduc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombProduc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Artículo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtNombreProducto = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtUnidades = New System.Windows.Forms.TextBox()
        Me.TxtNumeroVenta = New System.Windows.Forms.TextBox()
        Me.lbNumeroVenta = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtnBuscarCliente)
        Me.GroupBox2.Controls.Add(Me.CbxTipoTransac)
        Me.GroupBox2.Controls.Add(Me.CbxTipoPago)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtNombreCliente)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtNombreEmpleado)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtCodCli)
        Me.GroupBox2.Controls.Add(Me.lbCodigoCli)
        Me.GroupBox2.Controls.Add(Me.TxtCodEmple)
        Me.GroupBox2.Controls.Add(Me.lbCodEmple)
        Me.GroupBox2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(75, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(947, 139)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Venta"
        '
        'BtnBuscarCliente
        '
        Me.BtnBuscarCliente.Location = New System.Drawing.Point(818, 25)
        Me.BtnBuscarCliente.Name = "BtnBuscarCliente"
        Me.BtnBuscarCliente.Size = New System.Drawing.Size(116, 39)
        Me.BtnBuscarCliente.TabIndex = 65
        Me.BtnBuscarCliente.Text = "Buscar cliente"
        Me.BtnBuscarCliente.UseVisualStyleBackColor = True
        '
        'CbxTipoTransac
        '
        Me.CbxTipoTransac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxTipoTransac.FormattingEnabled = True
        Me.CbxTipoTransac.Items.AddRange(New Object() {"Efectivo", "Tarjeta de crédito", "Tarjeta de débito"})
        Me.CbxTipoTransac.Location = New System.Drawing.Point(632, 94)
        Me.CbxTipoTransac.Name = "CbxTipoTransac"
        Me.CbxTipoTransac.Size = New System.Drawing.Size(151, 27)
        Me.CbxTipoTransac.TabIndex = 6
        '
        'CbxTipoPago
        '
        Me.CbxTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxTipoPago.FormattingEnabled = True
        Me.CbxTipoPago.Items.AddRange(New Object() {"Crédito", "Contado"})
        Me.CbxTipoPago.Location = New System.Drawing.Point(212, 90)
        Me.CbxTipoPago.Name = "CbxTipoPago"
        Me.CbxTipoPago.Size = New System.Drawing.Size(151, 27)
        Me.CbxTipoPago.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(447, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 19)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Tipo de transacción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 19)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Tipo de pago"
        '
        'TxtNombreCliente
        '
        Me.TxtNombreCliente.Enabled = False
        Me.TxtNombreCliente.Location = New System.Drawing.Point(632, 32)
        Me.TxtNombreCliente.Name = "TxtNombreCliente"
        Me.TxtNombreCliente.Size = New System.Drawing.Size(151, 27)
        Me.TxtNombreCliente.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(447, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 19)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Nombre del cliente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtNombreEmpleado
        '
        Me.TxtNombreEmpleado.Enabled = False
        Me.TxtNombreEmpleado.Location = New System.Drawing.Point(632, 61)
        Me.TxtNombreEmpleado.Name = "TxtNombreEmpleado"
        Me.TxtNombreEmpleado.Size = New System.Drawing.Size(151, 27)
        Me.TxtNombreEmpleado.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(447, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 19)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Nombre de empleado"
        '
        'TxtCodCli
        '
        Me.TxtCodCli.Enabled = False
        Me.TxtCodCli.Location = New System.Drawing.Point(212, 32)
        Me.TxtCodCli.Name = "TxtCodCli"
        Me.TxtCodCli.Size = New System.Drawing.Size(151, 27)
        Me.TxtCodCli.TabIndex = 1
        '
        'lbCodigoCli
        '
        Me.lbCodigoCli.AutoSize = True
        Me.lbCodigoCli.Location = New System.Drawing.Point(44, 35)
        Me.lbCodigoCli.Name = "lbCodigoCli"
        Me.lbCodigoCli.Size = New System.Drawing.Size(131, 19)
        Me.lbCodigoCli.TabIndex = 35
        Me.lbCodigoCli.Text = "Código del cliente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtCodEmple
        '
        Me.TxtCodEmple.Enabled = False
        Me.TxtCodEmple.Location = New System.Drawing.Point(212, 61)
        Me.TxtCodEmple.Name = "TxtCodEmple"
        Me.TxtCodEmple.Size = New System.Drawing.Size(151, 27)
        Me.TxtCodEmple.TabIndex = 3
        '
        'lbCodEmple
        '
        Me.lbCodEmple.AutoSize = True
        Me.lbCodEmple.Location = New System.Drawing.Point(44, 64)
        Me.lbCodEmple.Name = "lbCodEmple"
        Me.lbCodEmple.Size = New System.Drawing.Size(149, 19)
        Me.lbCodEmple.TabIndex = 36
        Me.lbCodEmple.Text = "Código de empleado"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtArticulo)
        Me.GroupBox1.Controls.Add(Me.LblContador1)
        Me.GroupBox1.Controls.Add(Me.LblContador)
        Me.GroupBox1.Controls.Add(Me.BtnBuscarProducto)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TxtUnidadesMinimas)
        Me.GroupBox1.Controls.Add(Me.TxtTotal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.CbxPrecio)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DGV)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtCodigoProducto)
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Controls.Add(Me.TxtNombreProducto)
        Me.GroupBox1.Controls.Add(Me.TxtCantidad)
        Me.GroupBox1.Controls.Add(Me.TxtUnidades)
        Me.GroupBox1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 288)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1023, 381)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de la Venta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(400, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Descripción"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.Location = New System.Drawing.Point(402, 77)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(122, 27)
        Me.TxtDescripcion.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(273, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 19)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Artículo"
        '
        'TxtArticulo
        '
        Me.TxtArticulo.Enabled = False
        Me.TxtArticulo.Location = New System.Drawing.Point(272, 77)
        Me.TxtArticulo.Name = "TxtArticulo"
        Me.TxtArticulo.Size = New System.Drawing.Size(122, 27)
        Me.TxtArticulo.TabIndex = 78
        '
        'LblContador1
        '
        Me.LblContador1.AutoSize = True
        Me.LblContador1.BackColor = System.Drawing.Color.Transparent
        Me.LblContador1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblContador1.ForeColor = System.Drawing.Color.Black
        Me.LblContador1.Location = New System.Drawing.Point(957, 81)
        Me.LblContador1.Name = "LblContador1"
        Me.LblContador1.Size = New System.Drawing.Size(24, 19)
        Me.LblContador1.TabIndex = 76
        Me.LblContador1.Text = "/ 3"
        '
        'LblContador
        '
        Me.LblContador.AutoSize = True
        Me.LblContador.BackColor = System.Drawing.Color.Transparent
        Me.LblContador.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblContador.ForeColor = System.Drawing.Color.Black
        Me.LblContador.Location = New System.Drawing.Point(939, 80)
        Me.LblContador.Name = "LblContador"
        Me.LblContador.Size = New System.Drawing.Size(18, 19)
        Me.LblContador.TabIndex = 75
        Me.LblContador.Text = "0"
        '
        'BtnBuscarProducto
        '
        Me.BtnBuscarProducto.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBuscarProducto.Location = New System.Drawing.Point(5, 23)
        Me.BtnBuscarProducto.Name = "BtnBuscarProducto"
        Me.BtnBuscarProducto.Size = New System.Drawing.Size(116, 35)
        Me.BtnBuscarProducto.TabIndex = 66
        Me.BtnBuscarProducto.Text = "Buscar producto"
        Me.BtnBuscarProducto.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(733, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 19)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Unidades mínimas"
        '
        'TxtUnidadesMinimas
        '
        Me.TxtUnidadesMinimas.Enabled = False
        Me.TxtUnidadesMinimas.Location = New System.Drawing.Point(735, 77)
        Me.TxtUnidadesMinimas.Name = "TxtUnidadesMinimas"
        Me.TxtUnidadesMinimas.Size = New System.Drawing.Size(134, 27)
        Me.TxtUnidadesMinimas.TabIndex = 60
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(767, 336)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 27)
        Me.TxtTotal.TabIndex = 59
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
        'CbxPrecio
        '
        Me.CbxPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPrecio.FormattingEnabled = True
        Me.CbxPrecio.Location = New System.Drawing.Point(534, 77)
        Me.CbxPrecio.Name = "CbxPrecio"
        Me.CbxPrecio.Size = New System.Drawing.Size(65, 27)
        Me.CbxPrecio.TabIndex = 42
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(989, 85)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(31, 28)
        Me.BtnEliminar.TabIndex = 57
        Me.BtnEliminar.Text = "-"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(871, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 19)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Cantidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(601, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 19)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Unidades en stock"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(530, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 19)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Precio"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(67, 324)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(87, 39)
        Me.BtnGuardar.TabIndex = 22
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 19)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Código producto"
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
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodProduc, Me.NombProduc, Me.Artículo, Me.Descripción, Me.Impuesto, Me.CantVenta, Me.PrecioVenta, Me.SubTotal})
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
        Me.DGV.Location = New System.Drawing.Point(20, 119)
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
        Me.DGV.Size = New System.Drawing.Size(984, 195)
        Me.DGV.TabIndex = 21
        '
        'CodProduc
        '
        Me.CodProduc.HeaderText = "Código del producto"
        Me.CodProduc.MinimumWidth = 6
        Me.CodProduc.Name = "CodProduc"
        Me.CodProduc.ReadOnly = True
        Me.CodProduc.Visible = False
        '
        'NombProduc
        '
        Me.NombProduc.HeaderText = "Nombre del producto"
        Me.NombProduc.MinimumWidth = 6
        Me.NombProduc.Name = "NombProduc"
        Me.NombProduc.ReadOnly = True
        '
        'Artículo
        '
        Me.Artículo.HeaderText = "Artículo"
        Me.Artículo.Name = "Artículo"
        Me.Artículo.ReadOnly = True
        '
        'Descripción
        '
        Me.Descripción.HeaderText = "Descripción"
        Me.Descripción.Name = "Descripción"
        Me.Descripción.ReadOnly = True
        '
        'Impuesto
        '
        Me.Impuesto.HeaderText = "Impuesto"
        Me.Impuesto.MinimumWidth = 6
        Me.Impuesto.Name = "Impuesto"
        Me.Impuesto.ReadOnly = True
        Me.Impuesto.Visible = False
        '
        'CantVenta
        '
        Me.CantVenta.HeaderText = "Cantidad del producto"
        Me.CantVenta.MinimumWidth = 6
        Me.CantVenta.Name = "CantVenta"
        Me.CantVenta.ReadOnly = True
        '
        'PrecioVenta
        '
        Me.PrecioVenta.HeaderText = "Precio del producto"
        Me.PrecioVenta.MinimumWidth = 6
        Me.PrecioVenta.Name = "PrecioVenta"
        Me.PrecioVenta.ReadOnly = True
        '
        'SubTotal
        '
        Me.SubTotal.HeaderText = "Sub total"
        Me.SubTotal.MinimumWidth = 6
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(133, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 19)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Nombre producto"
        '
        'TxtCodigoProducto
        '
        Me.TxtCodigoProducto.Enabled = False
        Me.TxtCodigoProducto.Location = New System.Drawing.Point(8, 78)
        Me.TxtCodigoProducto.Name = "TxtCodigoProducto"
        Me.TxtCodigoProducto.Size = New System.Drawing.Size(122, 27)
        Me.TxtCodigoProducto.TabIndex = 48
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(989, 53)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(31, 30)
        Me.BtnAgregar.TabIndex = 53
        Me.BtnAgregar.Text = "+"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.Enabled = False
        Me.TxtNombreProducto.Location = New System.Drawing.Point(137, 78)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(129, 27)
        Me.TxtNombreProducto.TabIndex = 49
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(875, 77)
        Me.TxtCantidad.MaxLength = 3
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(61, 27)
        Me.TxtCantidad.TabIndex = 52
        '
        'TxtUnidades
        '
        Me.TxtUnidades.Enabled = False
        Me.TxtUnidades.Location = New System.Drawing.Point(605, 77)
        Me.TxtUnidades.Name = "TxtUnidades"
        Me.TxtUnidades.Size = New System.Drawing.Size(124, 27)
        Me.TxtUnidades.TabIndex = 51
        '
        'TxtNumeroVenta
        '
        Me.TxtNumeroVenta.Enabled = False
        Me.TxtNumeroVenta.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtNumeroVenta.Location = New System.Drawing.Point(184, 98)
        Me.TxtNumeroVenta.Name = "TxtNumeroVenta"
        Me.TxtNumeroVenta.Size = New System.Drawing.Size(100, 27)
        Me.TxtNumeroVenta.TabIndex = 43
        '
        'lbNumeroVenta
        '
        Me.lbNumeroVenta.AutoSize = True
        Me.lbNumeroVenta.BackColor = System.Drawing.Color.Transparent
        Me.lbNumeroVenta.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbNumeroVenta.Location = New System.Drawing.Point(50, 98)
        Me.lbNumeroVenta.Name = "lbNumeroVenta"
        Me.lbNumeroVenta.Size = New System.Drawing.Size(128, 19)
        Me.lbNumeroVenta.TabIndex = 42
        Me.lbNumeroVenta.Text = "Número de Venta"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Candara", 19.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(12, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 32)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Ventas"
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.lbUsuario.Location = New System.Drawing.Point(915, 121)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(0, 13)
        Me.lbUsuario.TabIndex = 70
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BazarRoxana.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(796, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1053, 681)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtNumeroVenta)
        Me.Controls.Add(Me.lbNumeroVenta)
        Me.Controls.Add(Me.lbUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNombreCliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNombreEmpleado As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCodCli As TextBox
    Friend WithEvents lbCodigoCli As Label
    Friend WithEvents TxtCodEmple As TextBox
    Friend WithEvents lbCodEmple As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CbxPrecio As ComboBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtCodigoProducto As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtNombreProducto As TextBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents TxtUnidades As TextBox
    Friend WithEvents TxtNumeroVenta As TextBox
    Friend WithEvents lbNumeroVenta As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtUnidadesMinimas As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents CbxTipoTransac As ComboBox
    Friend WithEvents CbxTipoPago As ComboBox
    Friend WithEvents lbUsuario As Label
    Friend WithEvents BtnBuscarCliente As Button
    Friend WithEvents BtnBuscarProducto As Button
    Friend WithEvents LblContador1 As Label
    Friend WithEvents LblContador As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtArticulo As TextBox
    Friend WithEvents CodProduc As DataGridViewTextBoxColumn
    Friend WithEvents NombProduc As DataGridViewTextBoxColumn
    Friend WithEvents Artículo As DataGridViewTextBoxColumn
    Friend WithEvents Descripción As DataGridViewTextBoxColumn
    Friend WithEvents Impuesto As DataGridViewTextBoxColumn
    Friend WithEvents CantVenta As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVenta As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
End Class
