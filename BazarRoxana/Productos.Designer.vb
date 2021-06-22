<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnlimpiaf = New System.Windows.Forms.Button()
        Me.btnAgg_C = New System.Windows.Forms.Button()
        Me.btnAgg_P = New System.Windows.Forms.Button()
        Me.txNombCateg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txNombProv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txCodCateg = New System.Windows.Forms.TextBox()
        Me.lbCodCateg = New System.Windows.Forms.Label()
        Me.txMin = New System.Windows.Forms.TextBox()
        Me.lbMinima = New System.Windows.Forms.Label()
        Me.txMax = New System.Windows.Forms.TextBox()
        Me.lbMaxima = New System.Windows.Forms.Label()
        Me.txtUnidStock = New System.Windows.Forms.TextBox()
        Me.lbUnidStock = New System.Windows.Forms.Label()
        Me.txtTerPre = New System.Windows.Forms.TextBox()
        Me.lbTerPre = New System.Windows.Forms.Label()
        Me.txtSegPre = New System.Windows.Forms.TextBox()
        Me.lbSegPre = New System.Windows.Forms.Label()
        Me.rtxDescProd = New System.Windows.Forms.RichTextBox()
        Me.txCodProv = New System.Windows.Forms.TextBox()
        Me.txtPriPre = New System.Windows.Forms.TextBox()
        Me.txNomProd = New System.Windows.Forms.TextBox()
        Me.lbPriPre = New System.Windows.Forms.Label()
        Me.lbDescProd = New System.Windows.Forms.Label()
        Me.lbCodProv = New System.Windows.Forms.Label()
        Me.lbCodigoCli = New System.Windows.Forms.Label()
        Me.txCodProd = New System.Windows.Forms.TextBox()
        Me.lbNombreProd = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnHabilitar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.DGVProducto = New System.Windows.Forms.DataGridView()
        Me.chkInhabil = New System.Windows.Forms.CheckBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.btnlimpiaf)
        Me.GroupBox2.Controls.Add(Me.btnAgg_C)
        Me.GroupBox2.Controls.Add(Me.btnAgg_P)
        Me.GroupBox2.Controls.Add(Me.txNombCateg)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txNombProv)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txCodCateg)
        Me.GroupBox2.Controls.Add(Me.lbCodCateg)
        Me.GroupBox2.Controls.Add(Me.txMin)
        Me.GroupBox2.Controls.Add(Me.lbMinima)
        Me.GroupBox2.Controls.Add(Me.txMax)
        Me.GroupBox2.Controls.Add(Me.lbMaxima)
        Me.GroupBox2.Controls.Add(Me.txtUnidStock)
        Me.GroupBox2.Controls.Add(Me.lbUnidStock)
        Me.GroupBox2.Controls.Add(Me.txtTerPre)
        Me.GroupBox2.Controls.Add(Me.lbTerPre)
        Me.GroupBox2.Controls.Add(Me.txtSegPre)
        Me.GroupBox2.Controls.Add(Me.lbSegPre)
        Me.GroupBox2.Controls.Add(Me.rtxDescProd)
        Me.GroupBox2.Controls.Add(Me.txCodProv)
        Me.GroupBox2.Controls.Add(Me.txtPriPre)
        Me.GroupBox2.Controls.Add(Me.txNomProd)
        Me.GroupBox2.Controls.Add(Me.lbPriPre)
        Me.GroupBox2.Controls.Add(Me.lbDescProd)
        Me.GroupBox2.Controls.Add(Me.lbCodProv)
        Me.GroupBox2.Controls.Add(Me.lbCodigoCli)
        Me.GroupBox2.Controls.Add(Me.txCodProd)
        Me.GroupBox2.Controls.Add(Me.lbNombreProd)
        Me.GroupBox2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1017, 238)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Producto"
        '
        'btnlimpiaf
        '
        Me.btnlimpiaf.Location = New System.Drawing.Point(748, 169)
        Me.btnlimpiaf.Name = "btnlimpiaf"
        Me.btnlimpiaf.Size = New System.Drawing.Size(118, 27)
        Me.btnlimpiaf.TabIndex = 77
        Me.btnlimpiaf.Text = "Limpiar"
        Me.btnlimpiaf.UseVisualStyleBackColor = True
        '
        'btnAgg_C
        '
        Me.btnAgg_C.BackColor = System.Drawing.Color.Silver
        Me.btnAgg_C.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgg_C.Location = New System.Drawing.Point(885, 93)
        Me.btnAgg_C.Name = "btnAgg_C"
        Me.btnAgg_C.Size = New System.Drawing.Size(77, 28)
        Me.btnAgg_C.TabIndex = 74
        Me.btnAgg_C.Text = "Agregar"
        Me.btnAgg_C.UseVisualStyleBackColor = False
        '
        'btnAgg_P
        '
        Me.btnAgg_P.BackColor = System.Drawing.Color.Silver
        Me.btnAgg_P.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgg_P.Location = New System.Drawing.Point(550, 90)
        Me.btnAgg_P.Name = "btnAgg_P"
        Me.btnAgg_P.Size = New System.Drawing.Size(77, 28)
        Me.btnAgg_P.TabIndex = 73
        Me.btnAgg_P.Text = "Agregar"
        Me.btnAgg_P.UseVisualStyleBackColor = False
        '
        'txNombCateg
        '
        Me.txNombCateg.Enabled = False
        Me.txNombCateg.Location = New System.Drawing.Point(872, 60)
        Me.txNombCateg.Name = "txNombCateg"
        Me.txNombCateg.Size = New System.Drawing.Size(100, 27)
        Me.txNombCateg.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(696, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 19)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Nombre de la Categoría"
        '
        'txNombProv
        '
        Me.txNombProv.Enabled = False
        Me.txNombProv.Location = New System.Drawing.Point(538, 57)
        Me.txNombProv.Name = "txNombProv"
        Me.txNombProv.Size = New System.Drawing.Size(100, 27)
        Me.txNombProv.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(370, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 19)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Nombre del Proveedor"
        '
        'txCodCateg
        '
        Me.txCodCateg.Enabled = False
        Me.txCodCateg.Location = New System.Drawing.Point(872, 20)
        Me.txCodCateg.Name = "txCodCateg"
        Me.txCodCateg.Size = New System.Drawing.Size(100, 27)
        Me.txCodCateg.TabIndex = 68
        '
        'lbCodCateg
        '
        Me.lbCodCateg.AutoSize = True
        Me.lbCodCateg.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodCateg.Location = New System.Drawing.Point(696, 23)
        Me.lbCodCateg.Name = "lbCodCateg"
        Me.lbCodCateg.Size = New System.Drawing.Size(148, 19)
        Me.lbCodCateg.TabIndex = 67
        Me.lbCodCateg.Text = "Código de Categoría"
        '
        'txMin
        '
        Me.txMin.Location = New System.Drawing.Point(186, 192)
        Me.txMin.Name = "txMin"
        Me.txMin.Size = New System.Drawing.Size(100, 27)
        Me.txMin.TabIndex = 66
        '
        'lbMinima
        '
        Me.lbMinima.AutoSize = True
        Me.lbMinima.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMinima.Location = New System.Drawing.Point(7, 195)
        Me.lbMinima.Name = "lbMinima"
        Me.lbMinima.Size = New System.Drawing.Size(143, 19)
        Me.lbMinima.TabIndex = 65
        Me.lbMinima.Text = "Productos Mínimos"
        '
        'txMax
        '
        Me.txMax.Location = New System.Drawing.Point(186, 166)
        Me.txMax.Name = "txMax"
        Me.txMax.Size = New System.Drawing.Size(100, 27)
        Me.txMax.TabIndex = 64
        '
        'lbMaxima
        '
        Me.lbMaxima.AutoSize = True
        Me.lbMaxima.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaxima.Location = New System.Drawing.Point(7, 169)
        Me.lbMaxima.Name = "lbMaxima"
        Me.lbMaxima.Size = New System.Drawing.Size(146, 19)
        Me.lbMaxima.TabIndex = 63
        Me.lbMaxima.Text = "Productos Máximos"
        '
        'txtUnidStock
        '
        Me.txtUnidStock.Location = New System.Drawing.Point(186, 143)
        Me.txtUnidStock.Name = "txtUnidStock"
        Me.txtUnidStock.Size = New System.Drawing.Size(100, 27)
        Me.txtUnidStock.TabIndex = 62
        '
        'lbUnidStock
        '
        Me.lbUnidStock.AutoSize = True
        Me.lbUnidStock.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUnidStock.Location = New System.Drawing.Point(6, 139)
        Me.lbUnidStock.Name = "lbUnidStock"
        Me.lbUnidStock.Size = New System.Drawing.Size(135, 19)
        Me.lbUnidStock.TabIndex = 61
        Me.lbUnidStock.Text = "Unidades en Stock"
        '
        'txtTerPre
        '
        Me.txtTerPre.Location = New System.Drawing.Point(493, 192)
        Me.txtTerPre.Name = "txtTerPre"
        Me.txtTerPre.Size = New System.Drawing.Size(100, 27)
        Me.txtTerPre.TabIndex = 60
        '
        'lbTerPre
        '
        Me.lbTerPre.AutoSize = True
        Me.lbTerPre.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTerPre.Location = New System.Drawing.Point(370, 195)
        Me.lbTerPre.Name = "lbTerPre"
        Me.lbTerPre.Size = New System.Drawing.Size(97, 19)
        Me.lbTerPre.TabIndex = 59
        Me.lbTerPre.Text = "Tercer Precio"
        '
        'txtSegPre
        '
        Me.txtSegPre.Location = New System.Drawing.Point(493, 166)
        Me.txtSegPre.Name = "txtSegPre"
        Me.txtSegPre.Size = New System.Drawing.Size(100, 27)
        Me.txtSegPre.TabIndex = 58
        '
        'lbSegPre
        '
        Me.lbSegPre.AutoSize = True
        Me.lbSegPre.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSegPre.Location = New System.Drawing.Point(370, 169)
        Me.lbSegPre.Name = "lbSegPre"
        Me.lbSegPre.Size = New System.Drawing.Size(116, 19)
        Me.lbSegPre.TabIndex = 57
        Me.lbSegPre.Text = "Segundo Precio"
        '
        'rtxDescProd
        '
        Me.rtxDescProd.Location = New System.Drawing.Point(186, 81)
        Me.rtxDescProd.Name = "rtxDescProd"
        Me.rtxDescProd.Size = New System.Drawing.Size(159, 54)
        Me.rtxDescProd.TabIndex = 56
        Me.rtxDescProd.Text = ""
        '
        'txCodProv
        '
        Me.txCodProv.Enabled = False
        Me.txCodProv.Location = New System.Drawing.Point(538, 20)
        Me.txCodProv.Name = "txCodProv"
        Me.txCodProv.Size = New System.Drawing.Size(100, 27)
        Me.txCodProv.TabIndex = 55
        '
        'txtPriPre
        '
        Me.txtPriPre.Location = New System.Drawing.Point(493, 140)
        Me.txtPriPre.Name = "txtPriPre"
        Me.txtPriPre.Size = New System.Drawing.Size(100, 27)
        Me.txtPriPre.TabIndex = 54
        '
        'txNomProd
        '
        Me.txNomProd.Location = New System.Drawing.Point(186, 46)
        Me.txNomProd.Name = "txNomProd"
        Me.txNomProd.Size = New System.Drawing.Size(100, 27)
        Me.txNomProd.TabIndex = 53
        '
        'lbPriPre
        '
        Me.lbPriPre.AutoSize = True
        Me.lbPriPre.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPriPre.Location = New System.Drawing.Point(370, 142)
        Me.lbPriPre.Name = "lbPriPre"
        Me.lbPriPre.Size = New System.Drawing.Size(101, 19)
        Me.lbPriPre.TabIndex = 50
        Me.lbPriPre.Text = "Primer Precio"
        '
        'lbDescProd
        '
        Me.lbDescProd.AutoSize = True
        Me.lbDescProd.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescProd.Location = New System.Drawing.Point(6, 81)
        Me.lbDescProd.Name = "lbDescProd"
        Me.lbDescProd.Size = New System.Drawing.Size(180, 19)
        Me.lbDescProd.TabIndex = 49
        Me.lbDescProd.Text = "Descripción del Producto"
        '
        'lbCodProv
        '
        Me.lbCodProv.AutoSize = True
        Me.lbCodProv.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodProv.Location = New System.Drawing.Point(370, 23)
        Me.lbCodProv.Name = "lbCodProv"
        Me.lbCodProv.Size = New System.Drawing.Size(157, 19)
        Me.lbCodProv.TabIndex = 48
        Me.lbCodProv.Text = "Código del Proveedor"
        '
        'lbCodigoCli
        '
        Me.lbCodigoCli.AutoSize = True
        Me.lbCodigoCli.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodigoCli.Location = New System.Drawing.Point(6, 23)
        Me.lbCodigoCli.Name = "lbCodigoCli"
        Me.lbCodigoCli.Size = New System.Drawing.Size(153, 19)
        Me.lbCodigoCli.TabIndex = 47
        Me.lbCodigoCli.Text = "Cóldigo del Producto"
        '
        'txCodProd
        '
        Me.txCodProd.Enabled = False
        Me.txCodProd.Location = New System.Drawing.Point(186, 20)
        Me.txCodProd.Name = "txCodProd"
        Me.txCodProd.Size = New System.Drawing.Size(100, 27)
        Me.txCodProd.TabIndex = 46
        '
        'lbNombreProd
        '
        Me.lbNombreProd.AutoSize = True
        Me.lbNombreProd.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombreProd.Location = New System.Drawing.Point(6, 49)
        Me.lbNombreProd.Name = "lbNombreProd"
        Me.lbNombreProd.Size = New System.Drawing.Size(156, 19)
        Me.lbNombreProd.TabIndex = 45
        Me.lbNombreProd.Text = "Nombre del Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 29)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Productos"
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.btnHabilitar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtBusqueda)
        Me.GroupBox1.Controls.Add(Me.DGVProducto)
        Me.GroupBox1.Controls.Add(Me.chkInhabil)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 348)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1017, 333)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda de productos"
        '
        'btnHabilitar
        '
        Me.btnHabilitar.Location = New System.Drawing.Point(700, 30)
        Me.btnHabilitar.Name = "btnHabilitar"
        Me.btnHabilitar.Size = New System.Drawing.Size(146, 39)
        Me.btnHabilitar.TabIndex = 81
        Me.btnHabilitar.Text = "Habilitar Producto"
        Me.btnHabilitar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(221, 19)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Escriba el nombre del producto"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBusqueda.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtBusqueda.Location = New System.Drawing.Point(241, 40)
        Me.TxtBusqueda.MaxLength = 20
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(189, 20)
        Me.TxtBusqueda.TabIndex = 72
        '
        'DGVProducto
        '
        Me.DGVProducto.AllowUserToAddRows = False
        Me.DGVProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVProducto.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.DGVProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVProducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DGVProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVProducto.DefaultCellStyle = DataGridViewCellStyle10
        Me.DGVProducto.EnableHeadersVisualStyles = False
        Me.DGVProducto.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGVProducto.Location = New System.Drawing.Point(12, 76)
        Me.DGVProducto.Name = "DGVProducto"
        Me.DGVProducto.ReadOnly = True
        Me.DGVProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVProducto.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DGVProducto.RowHeadersWidth = 51
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.DGVProducto.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DGVProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVProducto.Size = New System.Drawing.Size(969, 180)
        Me.DGVProducto.TabIndex = 71
        '
        'chkInhabil
        '
        Me.chkInhabil.AutoSize = True
        Me.chkInhabil.Location = New System.Drawing.Point(531, 38)
        Me.chkInhabil.Name = "chkInhabil"
        Me.chkInhabil.Size = New System.Drawing.Size(121, 23)
        Me.chkInhabil.TabIndex = 70
        Me.chkInhabil.Text = "Inhabilitados "
        Me.chkInhabil.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(894, 288)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 39)
        Me.btnEliminar.TabIndex = 24
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(476, 288)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(87, 39)
        Me.btnActualizar.TabIndex = 23
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(6, 285)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(87, 39)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BazarRoxana.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(677, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 684)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Productos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbCodCateg As Label
    Friend WithEvents txMin As TextBox
    Friend WithEvents lbMinima As Label
    Friend WithEvents txMax As TextBox
    Friend WithEvents lbMaxima As Label
    Friend WithEvents txtUnidStock As TextBox
    Friend WithEvents lbUnidStock As Label
    Friend WithEvents txtTerPre As TextBox
    Friend WithEvents lbTerPre As Label
    Friend WithEvents txtSegPre As TextBox
    Friend WithEvents lbSegPre As Label
    Friend WithEvents rtxDescProd As RichTextBox
    Friend WithEvents txtPriPre As TextBox
    Friend WithEvents txNomProd As TextBox
    Friend WithEvents lbPriPre As Label
    Friend WithEvents lbDescProd As Label
    Friend WithEvents lbCodProv As Label
    Friend WithEvents lbCodigoCli As Label
    Friend WithEvents txCodProd As TextBox
    Friend WithEvents lbNombreProd As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents btnAgg_C As Button
    Friend WithEvents btnAgg_P As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents DGVProducto As DataGridView
    Friend WithEvents chkInhabil As CheckBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnHabilitar As Button
    Friend WithEvents btnlimpiaf As Button
    Public WithEvents txCodCateg As TextBox
    Public WithEvents txCodProv As TextBox
    Public WithEvents txNombCateg As TextBox
    Public WithEvents txNombProv As TextBox
End Class
