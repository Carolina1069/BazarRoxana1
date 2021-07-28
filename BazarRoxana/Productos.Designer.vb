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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RtxDescripcionProducto2 = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLimpiarCateg = New System.Windows.Forms.Button()
        Me.btnLimpiarProv = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.btnAgg_C = New System.Windows.Forms.Button()
        Me.btnAgg_P = New System.Windows.Forms.Button()
        Me.TxtNombreCategoria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodigoCategoria = New System.Windows.Forms.TextBox()
        Me.lbCodCateg = New System.Windows.Forms.Label()
        Me.TxtProductosMinimos = New System.Windows.Forms.TextBox()
        Me.lbMinima = New System.Windows.Forms.Label()
        Me.TxtProductosMaximos = New System.Windows.Forms.TextBox()
        Me.lbMaxima = New System.Windows.Forms.Label()
        Me.TxtTercerPrecio = New System.Windows.Forms.TextBox()
        Me.lbTerPre = New System.Windows.Forms.Label()
        Me.TxtSegundoPrecio = New System.Windows.Forms.TextBox()
        Me.lbSegPre = New System.Windows.Forms.Label()
        Me.RtxDescripcionProducto = New System.Windows.Forms.RichTextBox()
        Me.TxtCodigoProveedor = New System.Windows.Forms.TextBox()
        Me.TxtPrimerPrecio = New System.Windows.Forms.TextBox()
        Me.TxtNombreProducto = New System.Windows.Forms.TextBox()
        Me.lbPriPre = New System.Windows.Forms.Label()
        Me.lbDescProd = New System.Windows.Forms.Label()
        Me.lbCodProv = New System.Windows.Forms.Label()
        Me.lbCodigoCli = New System.Windows.Forms.Label()
        Me.TxtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.lbNombreProd = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvProductos = New System.Windows.Forms.DataGridView()
        Me.BtnHabilitar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.ChkInhabil = New System.Windows.Forms.CheckBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.RtxDescripcionProducto2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnLimpiarCateg)
        Me.GroupBox2.Controls.Add(Me.btnLimpiarProv)
        Me.GroupBox2.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox2.Controls.Add(Me.btnAgg_C)
        Me.GroupBox2.Controls.Add(Me.btnAgg_P)
        Me.GroupBox2.Controls.Add(Me.TxtNombreCategoria)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtNombreProveedor)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtCodigoCategoria)
        Me.GroupBox2.Controls.Add(Me.lbCodCateg)
        Me.GroupBox2.Controls.Add(Me.TxtProductosMinimos)
        Me.GroupBox2.Controls.Add(Me.lbMinima)
        Me.GroupBox2.Controls.Add(Me.TxtProductosMaximos)
        Me.GroupBox2.Controls.Add(Me.lbMaxima)
        Me.GroupBox2.Controls.Add(Me.TxtTercerPrecio)
        Me.GroupBox2.Controls.Add(Me.lbTerPre)
        Me.GroupBox2.Controls.Add(Me.TxtSegundoPrecio)
        Me.GroupBox2.Controls.Add(Me.lbSegPre)
        Me.GroupBox2.Controls.Add(Me.RtxDescripcionProducto)
        Me.GroupBox2.Controls.Add(Me.TxtCodigoProveedor)
        Me.GroupBox2.Controls.Add(Me.TxtPrimerPrecio)
        Me.GroupBox2.Controls.Add(Me.TxtNombreProducto)
        Me.GroupBox2.Controls.Add(Me.lbPriPre)
        Me.GroupBox2.Controls.Add(Me.lbDescProd)
        Me.GroupBox2.Controls.Add(Me.lbCodProv)
        Me.GroupBox2.Controls.Add(Me.lbCodigoCli)
        Me.GroupBox2.Controls.Add(Me.TxtCodigoProducto)
        Me.GroupBox2.Controls.Add(Me.lbNombreProd)
        Me.GroupBox2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1017, 238)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Producto"
        '
        'RtxDescripcionProducto2
        '
        Me.RtxDescripcionProducto2.Location = New System.Drawing.Point(207, 157)
        Me.RtxDescripcionProducto2.MaxLength = 100
        Me.RtxDescripcionProducto2.Name = "RtxDescripcionProducto2"
        Me.RtxDescripcionProducto2.Size = New System.Drawing.Size(159, 34)
        Me.RtxDescripcionProducto2.TabIndex = 81
        Me.RtxDescripcionProducto2.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 19)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Descripción del Producto 2"
        '
        'btnLimpiarCateg
        '
        Me.btnLimpiarCateg.BackgroundImage = CType(resources.GetObject("btnLimpiarCateg.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpiarCateg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLimpiarCateg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiarCateg.Location = New System.Drawing.Point(972, 20)
        Me.btnLimpiarCateg.Name = "btnLimpiarCateg"
        Me.btnLimpiarCateg.Size = New System.Drawing.Size(32, 31)
        Me.btnLimpiarCateg.TabIndex = 79
        Me.btnLimpiarCateg.UseVisualStyleBackColor = True
        '
        'btnLimpiarProv
        '
        Me.btnLimpiarProv.BackgroundImage = CType(resources.GetObject("btnLimpiarProv.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpiarProv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLimpiarProv.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiarProv.Location = New System.Drawing.Point(637, 20)
        Me.btnLimpiarProv.Name = "btnLimpiarProv"
        Me.btnLimpiarProv.Size = New System.Drawing.Size(32, 31)
        Me.btnLimpiarProv.TabIndex = 78
        Me.btnLimpiarProv.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(418, 192)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(118, 27)
        Me.BtnLimpiar.TabIndex = 77
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAgg_C
        '
        Me.btnAgg_C.BackColor = System.Drawing.Color.Silver
        Me.btnAgg_C.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgg_C.Image = CType(resources.GetObject("btnAgg_C.Image"), System.Drawing.Image)
        Me.btnAgg_C.Location = New System.Drawing.Point(969, 60)
        Me.btnAgg_C.Name = "btnAgg_C"
        Me.btnAgg_C.Size = New System.Drawing.Size(37, 28)
        Me.btnAgg_C.TabIndex = 74
        Me.btnAgg_C.UseVisualStyleBackColor = False
        '
        'btnAgg_P
        '
        Me.btnAgg_P.BackColor = System.Drawing.Color.Silver
        Me.btnAgg_P.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgg_P.Image = CType(resources.GetObject("btnAgg_P.Image"), System.Drawing.Image)
        Me.btnAgg_P.Location = New System.Drawing.Point(637, 57)
        Me.btnAgg_P.Name = "btnAgg_P"
        Me.btnAgg_P.Size = New System.Drawing.Size(32, 28)
        Me.btnAgg_P.TabIndex = 73
        Me.btnAgg_P.UseVisualStyleBackColor = False
        '
        'TxtNombreCategoria
        '
        Me.TxtNombreCategoria.Enabled = False
        Me.TxtNombreCategoria.Location = New System.Drawing.Point(867, 60)
        Me.TxtNombreCategoria.Name = "TxtNombreCategoria"
        Me.TxtNombreCategoria.Size = New System.Drawing.Size(100, 27)
        Me.TxtNombreCategoria.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(691, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 19)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Nombre de la Categoría"
        '
        'TxtNombreProveedor
        '
        Me.TxtNombreProveedor.Enabled = False
        Me.TxtNombreProveedor.Location = New System.Drawing.Point(531, 57)
        Me.TxtNombreProveedor.Name = "TxtNombreProveedor"
        Me.TxtNombreProveedor.Size = New System.Drawing.Size(100, 27)
        Me.TxtNombreProveedor.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(363, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 19)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Nombre del Proveedor"
        '
        'TxtCodigoCategoria
        '
        Me.TxtCodigoCategoria.Enabled = False
        Me.TxtCodigoCategoria.Location = New System.Drawing.Point(867, 20)
        Me.TxtCodigoCategoria.Name = "TxtCodigoCategoria"
        Me.TxtCodigoCategoria.Size = New System.Drawing.Size(100, 27)
        Me.TxtCodigoCategoria.TabIndex = 68
        '
        'lbCodCateg
        '
        Me.lbCodCateg.AutoSize = True
        Me.lbCodCateg.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodCateg.Location = New System.Drawing.Point(691, 23)
        Me.lbCodCateg.Name = "lbCodCateg"
        Me.lbCodCateg.Size = New System.Drawing.Size(148, 19)
        Me.lbCodCateg.TabIndex = 67
        Me.lbCodCateg.Text = "Código de Categoría"
        '
        'TxtProductosMinimos
        '
        Me.TxtProductosMinimos.Location = New System.Drawing.Point(569, 139)
        Me.TxtProductosMinimos.MaxLength = 1
        Me.TxtProductosMinimos.Name = "TxtProductosMinimos"
        Me.TxtProductosMinimos.Size = New System.Drawing.Size(100, 27)
        Me.TxtProductosMinimos.TabIndex = 66
        '
        'lbMinima
        '
        Me.lbMinima.AutoSize = True
        Me.lbMinima.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMinima.Location = New System.Drawing.Point(390, 147)
        Me.lbMinima.Name = "lbMinima"
        Me.lbMinima.Size = New System.Drawing.Size(143, 19)
        Me.lbMinima.TabIndex = 65
        Me.lbMinima.Text = "Productos Mínimos"
        '
        'TxtProductosMaximos
        '
        Me.TxtProductosMaximos.Location = New System.Drawing.Point(569, 109)
        Me.TxtProductosMaximos.MaxLength = 3
        Me.TxtProductosMaximos.Name = "TxtProductosMaximos"
        Me.TxtProductosMaximos.Size = New System.Drawing.Size(100, 27)
        Me.TxtProductosMaximos.TabIndex = 64
        '
        'lbMaxima
        '
        Me.lbMaxima.AutoSize = True
        Me.lbMaxima.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaxima.Location = New System.Drawing.Point(390, 114)
        Me.lbMaxima.Name = "lbMaxima"
        Me.lbMaxima.Size = New System.Drawing.Size(146, 19)
        Me.lbMaxima.TabIndex = 63
        Me.lbMaxima.Text = "Productos Máximos"
        '
        'TxtTercerPrecio
        '
        Me.TxtTercerPrecio.Location = New System.Drawing.Point(865, 169)
        Me.TxtTercerPrecio.MaxLength = 6
        Me.TxtTercerPrecio.Name = "TxtTercerPrecio"
        Me.TxtTercerPrecio.Size = New System.Drawing.Size(100, 27)
        Me.TxtTercerPrecio.TabIndex = 60
        '
        'lbTerPre
        '
        Me.lbTerPre.AutoSize = True
        Me.lbTerPre.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTerPre.Location = New System.Drawing.Point(742, 172)
        Me.lbTerPre.Name = "lbTerPre"
        Me.lbTerPre.Size = New System.Drawing.Size(97, 19)
        Me.lbTerPre.TabIndex = 59
        Me.lbTerPre.Text = "Tercer Precio"
        '
        'TxtSegundoPrecio
        '
        Me.TxtSegundoPrecio.Location = New System.Drawing.Point(865, 136)
        Me.TxtSegundoPrecio.MaxLength = 6
        Me.TxtSegundoPrecio.Name = "TxtSegundoPrecio"
        Me.TxtSegundoPrecio.Size = New System.Drawing.Size(100, 27)
        Me.TxtSegundoPrecio.TabIndex = 58
        '
        'lbSegPre
        '
        Me.lbSegPre.AutoSize = True
        Me.lbSegPre.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSegPre.Location = New System.Drawing.Point(742, 139)
        Me.lbSegPre.Name = "lbSegPre"
        Me.lbSegPre.Size = New System.Drawing.Size(116, 19)
        Me.lbSegPre.TabIndex = 57
        Me.lbSegPre.Text = "Segundo Precio"
        '
        'RtxDescripcionProducto
        '
        Me.RtxDescripcionProducto.Location = New System.Drawing.Point(207, 105)
        Me.RtxDescripcionProducto.MaxLength = 100
        Me.RtxDescripcionProducto.Name = "RtxDescripcionProducto"
        Me.RtxDescripcionProducto.Size = New System.Drawing.Size(159, 34)
        Me.RtxDescripcionProducto.TabIndex = 56
        Me.RtxDescripcionProducto.Text = ""
        '
        'TxtCodigoProveedor
        '
        Me.TxtCodigoProveedor.Enabled = False
        Me.TxtCodigoProveedor.Location = New System.Drawing.Point(531, 20)
        Me.TxtCodigoProveedor.Name = "TxtCodigoProveedor"
        Me.TxtCodigoProveedor.Size = New System.Drawing.Size(100, 27)
        Me.TxtCodigoProveedor.TabIndex = 55
        '
        'TxtPrimerPrecio
        '
        Me.TxtPrimerPrecio.Location = New System.Drawing.Point(865, 105)
        Me.TxtPrimerPrecio.MaxLength = 6
        Me.TxtPrimerPrecio.Name = "TxtPrimerPrecio"
        Me.TxtPrimerPrecio.Size = New System.Drawing.Size(100, 27)
        Me.TxtPrimerPrecio.TabIndex = 54
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.Location = New System.Drawing.Point(186, 65)
        Me.TxtNombreProducto.MaxLength = 50
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(136, 27)
        Me.TxtNombreProducto.TabIndex = 53
        '
        'lbPriPre
        '
        Me.lbPriPre.AutoSize = True
        Me.lbPriPre.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPriPre.Location = New System.Drawing.Point(742, 107)
        Me.lbPriPre.Name = "lbPriPre"
        Me.lbPriPre.Size = New System.Drawing.Size(101, 19)
        Me.lbPriPre.TabIndex = 50
        Me.lbPriPre.Text = "Primer Precio"
        '
        'lbDescProd
        '
        Me.lbDescProd.AutoSize = True
        Me.lbDescProd.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescProd.Location = New System.Drawing.Point(10, 108)
        Me.lbDescProd.Name = "lbDescProd"
        Me.lbDescProd.Size = New System.Drawing.Size(180, 19)
        Me.lbDescProd.TabIndex = 49
        Me.lbDescProd.Text = "Descripción del Producto"
        '
        'lbCodProv
        '
        Me.lbCodProv.AutoSize = True
        Me.lbCodProv.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodProv.Location = New System.Drawing.Point(363, 23)
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
        Me.lbCodigoCli.Size = New System.Drawing.Size(149, 19)
        Me.lbCodigoCli.TabIndex = 47
        Me.lbCodigoCli.Text = "Código del Producto"
        '
        'TxtCodigoProducto
        '
        Me.TxtCodigoProducto.Enabled = False
        Me.TxtCodigoProducto.Location = New System.Drawing.Point(186, 20)
        Me.TxtCodigoProducto.Name = "TxtCodigoProducto"
        Me.TxtCodigoProducto.Size = New System.Drawing.Size(100, 27)
        Me.TxtCodigoProducto.TabIndex = 46
        '
        'lbNombreProd
        '
        Me.lbNombreProd.AutoSize = True
        Me.lbNombreProd.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombreProd.Location = New System.Drawing.Point(6, 65)
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
        Me.GroupBox1.Controls.Add(Me.DgvProductos)
        Me.GroupBox1.Controls.Add(Me.BtnHabilitar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtBusqueda)
        Me.GroupBox1.Controls.Add(Me.ChkInhabil)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnActualizar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 348)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1017, 333)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda de productos"
        '
        'DgvProductos
        '
        Me.DgvProductos.AllowUserToAddRows = False
        Me.DgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvProductos.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.DgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvProductos.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvProductos.EnableHeadersVisualStyles = False
        Me.DgvProductos.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DgvProductos.Location = New System.Drawing.Point(9, 90)
        Me.DgvProductos.Name = "DgvProductos"
        Me.DgvProductos.ReadOnly = True
        Me.DgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvProductos.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DgvProductos.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProductos.Size = New System.Drawing.Size(996, 173)
        Me.DgvProductos.TabIndex = 83
        '
        'BtnHabilitar
        '
        Me.BtnHabilitar.Location = New System.Drawing.Point(821, 26)
        Me.BtnHabilitar.Name = "BtnHabilitar"
        Me.BtnHabilitar.Size = New System.Drawing.Size(146, 39)
        Me.BtnHabilitar.TabIndex = 81
        Me.BtnHabilitar.Text = "Habilitar Producto"
        Me.BtnHabilitar.UseVisualStyleBackColor = True
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
        Me.TxtBusqueda.Size = New System.Drawing.Size(279, 20)
        Me.TxtBusqueda.TabIndex = 72
        '
        'ChkInhabil
        '
        Me.ChkInhabil.AutoSize = True
        Me.ChkInhabil.Location = New System.Drawing.Point(637, 39)
        Me.ChkInhabil.Name = "ChkInhabil"
        Me.ChkInhabil.Size = New System.Drawing.Size(121, 23)
        Me.ChkInhabil.TabIndex = 70
        Me.ChkInhabil.Text = "Inhabilitados "
        Me.ChkInhabil.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(894, 288)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(87, 39)
        Me.BtnEliminar.TabIndex = 24
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(476, 288)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(87, 39)
        Me.BtnActualizar.TabIndex = 23
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(6, 285)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(87, 39)
        Me.BtnGuardar.TabIndex = 22
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BazarRoxana.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(796, 12)
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
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1034, 634)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Productos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbCodCateg As Label
    Friend WithEvents TxtProductosMinimos As TextBox
    Friend WithEvents lbMinima As Label
    Friend WithEvents TxtProductosMaximos As TextBox
    Friend WithEvents lbMaxima As Label
    Friend WithEvents TxtTercerPrecio As TextBox
    Friend WithEvents lbTerPre As Label
    Friend WithEvents TxtSegundoPrecio As TextBox
    Friend WithEvents lbSegPre As Label
    Friend WithEvents RtxDescripcionProducto As RichTextBox
    Friend WithEvents TxtPrimerPrecio As TextBox
    Friend WithEvents TxtNombreProducto As TextBox
    Friend WithEvents lbPriPre As Label
    Friend WithEvents lbDescProd As Label
    Friend WithEvents lbCodProv As Label
    Friend WithEvents lbCodigoCli As Label
    Friend WithEvents TxtCodigoProducto As TextBox
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
    Friend WithEvents ChkInhabil As CheckBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnHabilitar As Button
    Friend WithEvents BtnLimpiar As Button
    Public WithEvents TxtCodigoCategoria As TextBox
    Public WithEvents TxtCodigoProveedor As TextBox
    Public WithEvents TxtNombreCategoria As TextBox
    Public WithEvents TxtNombreProveedor As TextBox
    Friend WithEvents btnLimpiarCateg As Button
    Friend WithEvents btnLimpiarProv As Button
    Friend WithEvents RtxDescripcionProducto2 As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DgvProductos As DataGridView
End Class
