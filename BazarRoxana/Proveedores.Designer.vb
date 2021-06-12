<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.DGVProveedores = New System.Windows.Forms.DataGridView()
        Me.chkInhabil = New System.Windows.Forms.CheckBox()
        Me.btActualizarTabla = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.RTBDirec = New System.Windows.Forms.RichTextBox()
        Me.TxtTelfonoEmpresa = New System.Windows.Forms.TextBox()
        Me.TxtCorreoProv = New System.Windows.Forms.TextBox()
        Me.lbCorreoProve = New System.Windows.Forms.Label()
        Me.txtTelProv = New System.Windows.Forms.TextBox()
        Me.lbTelProvee = New System.Windows.Forms.Label()
        Me.lbDireccProvee = New System.Windows.Forms.Label()
        Me.txCorreoEmpresa = New System.Windows.Forms.TextBox()
        Me.txtNombrePreEm = New System.Windows.Forms.TextBox()
        Me.txNomProv = New System.Windows.Forms.TextBox()
        Me.lbNomDistri = New System.Windows.Forms.Label()
        Me.lbTel = New System.Windows.Forms.Label()
        Me.lbCorreoProv = New System.Windows.Forms.Label()
        Me.lbCodigoProv = New System.Windows.Forms.Label()
        Me.txCodProve = New System.Windows.Forms.TextBox()
        Me.lbNombreProv = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtBusqueda)
        Me.GroupBox1.Controls.Add(Me.DGVProveedores)
        Me.GroupBox1.Controls.Add(Me.chkInhabil)
        Me.GroupBox1.Controls.Add(Me.btActualizarTabla)
        Me.GroupBox1.Controls.Add(Me.btEliminar)
        Me.GroupBox1.Controls.Add(Me.btActualizar)
        Me.GroupBox1.Controls.Add(Me.btGuardar)
        Me.GroupBox1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 417)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1185, 370)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de Proveedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 45)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(380, 24)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Escriba el nombre del proveedor(empresa):"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBusqueda.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtBusqueda.Location = New System.Drawing.Point(427, 45)
        Me.TxtBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBusqueda.MaxLength = 20
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(252, 25)
        Me.TxtBusqueda.TabIndex = 80
        '
        'DGVProveedores
        '
        Me.DGVProveedores.AllowUserToAddRows = False
        Me.DGVProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVProveedores.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.DGVProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVProveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVProveedores.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVProveedores.EnableHeadersVisualStyles = False
        Me.DGVProveedores.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGVProveedores.Location = New System.Drawing.Point(58, 83)
        Me.DGVProveedores.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVProveedores.Name = "DGVProveedores"
        Me.DGVProveedores.ReadOnly = True
        Me.DGVProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVProveedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVProveedores.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DGVProveedores.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVProveedores.Size = New System.Drawing.Size(1069, 222)
        Me.DGVProveedores.TabIndex = 72
        '
        'chkInhabil
        '
        Me.chkInhabil.AutoSize = True
        Me.chkInhabil.Location = New System.Drawing.Point(785, 33)
        Me.chkInhabil.Margin = New System.Windows.Forms.Padding(4)
        Me.chkInhabil.Name = "chkInhabil"
        Me.chkInhabil.Size = New System.Drawing.Size(147, 28)
        Me.chkInhabil.TabIndex = 69
        Me.chkInhabil.Text = "Inhabilitados "
        Me.chkInhabil.UseVisualStyleBackColor = True
        '
        'btActualizarTabla
        '
        Me.btActualizarTabla.Location = New System.Drawing.Point(940, 20)
        Me.btActualizarTabla.Margin = New System.Windows.Forms.Padding(4)
        Me.btActualizarTabla.Name = "btActualizarTabla"
        Me.btActualizarTabla.Size = New System.Drawing.Size(165, 48)
        Me.btActualizarTabla.TabIndex = 26
        Me.btActualizarTabla.Text = "Refrescar tabla"
        Me.btActualizarTabla.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(1011, 314)
        Me.btEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(116, 48)
        Me.btEliminar.TabIndex = 24
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(538, 314)
        Me.btActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(116, 48)
        Me.btActualizar.TabIndex = 23
        Me.btActualizar.Text = "Actualizar"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(93, 314)
        Me.btGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(116, 48)
        Me.btGuardar.TabIndex = 22
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BazarRoxana.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(903, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(327, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox2.Controls.Add(Me.chkEstado)
        Me.GroupBox2.Controls.Add(Me.RTBDirec)
        Me.GroupBox2.Controls.Add(Me.TxtTelfonoEmpresa)
        Me.GroupBox2.Controls.Add(Me.TxtCorreoProv)
        Me.GroupBox2.Controls.Add(Me.lbCorreoProve)
        Me.GroupBox2.Controls.Add(Me.txtTelProv)
        Me.GroupBox2.Controls.Add(Me.lbTelProvee)
        Me.GroupBox2.Controls.Add(Me.lbDireccProvee)
        Me.GroupBox2.Controls.Add(Me.txCorreoEmpresa)
        Me.GroupBox2.Controls.Add(Me.txtNombrePreEm)
        Me.GroupBox2.Controls.Add(Me.txNomProv)
        Me.GroupBox2.Controls.Add(Me.lbNomDistri)
        Me.GroupBox2.Controls.Add(Me.lbTel)
        Me.GroupBox2.Controls.Add(Me.lbCorreoProv)
        Me.GroupBox2.Controls.Add(Me.lbCodigoProv)
        Me.GroupBox2.Controls.Add(Me.txCodProve)
        Me.GroupBox2.Controls.Add(Me.lbNombreProv)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(31, 132)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1184, 277)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proveedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(705, 112)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 24)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Estado del proveedor"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLimpiar.Location = New System.Drawing.Point(938, 201)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(165, 48)
        Me.BtnLimpiar.TabIndex = 85
        Me.BtnLimpiar.Text = "Limpiar datos"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.BackColor = System.Drawing.Color.Transparent
        Me.chkEstado.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chkEstado.Location = New System.Drawing.Point(900, 111)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(228, 28)
        Me.chkEstado.TabIndex = 84
        Me.chkEstado.Text = "Habilitado/Inhabilitado"
        Me.chkEstado.UseVisualStyleBackColor = False
        '
        'RTBDirec
        '
        Me.RTBDirec.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.RTBDirec.Location = New System.Drawing.Point(331, 151)
        Me.RTBDirec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RTBDirec.MaxLength = 150
        Me.RTBDirec.Name = "RTBDirec"
        Me.RTBDirec.Size = New System.Drawing.Size(327, 111)
        Me.RTBDirec.TabIndex = 83
        Me.RTBDirec.Text = ""
        '
        'TxtTelfonoEmpresa
        '
        Me.TxtTelfonoEmpresa.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtTelfonoEmpresa.Location = New System.Drawing.Point(331, 52)
        Me.TxtTelfonoEmpresa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTelfonoEmpresa.MaxLength = 11
        Me.TxtTelfonoEmpresa.Name = "TxtTelfonoEmpresa"
        Me.TxtTelfonoEmpresa.Size = New System.Drawing.Size(203, 32)
        Me.TxtTelfonoEmpresa.TabIndex = 82
        '
        'TxtCorreoProv
        '
        Me.TxtCorreoProv.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtCorreoProv.Location = New System.Drawing.Point(331, 116)
        Me.TxtCorreoProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCorreoProv.MaxLength = 50
        Me.TxtCorreoProv.Name = "TxtCorreoProv"
        Me.TxtCorreoProv.Size = New System.Drawing.Size(203, 32)
        Me.TxtCorreoProv.TabIndex = 81
        '
        'lbCorreoProve
        '
        Me.lbCorreoProve.AutoSize = True
        Me.lbCorreoProve.BackColor = System.Drawing.Color.Transparent
        Me.lbCorreoProve.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbCorreoProve.Location = New System.Drawing.Point(115, 116)
        Me.lbCorreoProve.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCorreoProve.Name = "lbCorreoProve"
        Me.lbCorreoProve.Size = New System.Drawing.Size(193, 24)
        Me.lbCorreoProve.TabIndex = 80
        Me.lbCorreoProve.Text = "Correo del proveedor"
        '
        'txtTelProv
        '
        Me.txtTelProv.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.txtTelProv.Location = New System.Drawing.Point(900, 80)
        Me.txtTelProv.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelProv.MaxLength = 11
        Me.txtTelProv.Name = "txtTelProv"
        Me.txtTelProv.Size = New System.Drawing.Size(185, 32)
        Me.txtTelProv.TabIndex = 79
        '
        'lbTelProvee
        '
        Me.lbTelProvee.AutoSize = True
        Me.lbTelProvee.BackColor = System.Drawing.Color.Transparent
        Me.lbTelProvee.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbTelProvee.Location = New System.Drawing.Point(692, 80)
        Me.lbTelProvee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTelProvee.Name = "lbTelProvee"
        Me.lbTelProvee.Size = New System.Drawing.Size(209, 24)
        Me.lbTelProvee.TabIndex = 78
        Me.lbTelProvee.Text = "Teléfono del proveedor"
        '
        'lbDireccProvee
        '
        Me.lbDireccProvee.AutoSize = True
        Me.lbDireccProvee.BackColor = System.Drawing.Color.Transparent
        Me.lbDireccProvee.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbDireccProvee.Location = New System.Drawing.Point(8, 149)
        Me.lbDireccProvee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDireccProvee.Name = "lbDireccProvee"
        Me.lbDireccProvee.Size = New System.Drawing.Size(317, 24)
        Me.lbDireccProvee.TabIndex = 77
        Me.lbDireccProvee.Text = "Dirección de la empresa proveedora"
        '
        'txCorreoEmpresa
        '
        Me.txCorreoEmpresa.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.txCorreoEmpresa.Location = New System.Drawing.Point(900, 48)
        Me.txCorreoEmpresa.Margin = New System.Windows.Forms.Padding(4)
        Me.txCorreoEmpresa.MaxLength = 50
        Me.txCorreoEmpresa.Name = "txCorreoEmpresa"
        Me.txCorreoEmpresa.Size = New System.Drawing.Size(185, 32)
        Me.txCorreoEmpresa.TabIndex = 76
        '
        'txtNombrePreEm
        '
        Me.txtNombrePreEm.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.txtNombrePreEm.Location = New System.Drawing.Point(331, 84)
        Me.txtNombrePreEm.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombrePreEm.MaxLength = 50
        Me.txtNombrePreEm.Name = "txtNombrePreEm"
        Me.txtNombrePreEm.Size = New System.Drawing.Size(203, 32)
        Me.txtNombrePreEm.TabIndex = 75
        '
        'txNomProv
        '
        Me.txNomProv.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.txNomProv.Location = New System.Drawing.Point(900, 16)
        Me.txNomProv.Margin = New System.Windows.Forms.Padding(4)
        Me.txNomProv.MaxLength = 35
        Me.txNomProv.Name = "txNomProv"
        Me.txNomProv.Size = New System.Drawing.Size(185, 32)
        Me.txNomProv.TabIndex = 74
        '
        'lbNomDistri
        '
        Me.lbNomDistri.AutoSize = True
        Me.lbNomDistri.BackColor = System.Drawing.Color.Transparent
        Me.lbNomDistri.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbNomDistri.Location = New System.Drawing.Point(8, 87)
        Me.lbNomDistri.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNomDistri.Name = "lbNomDistri"
        Me.lbNomDistri.Size = New System.Drawing.Size(327, 24)
        Me.lbNomDistri.TabIndex = 73
        Me.lbNomDistri.Text = "Nombre del proveedor(empleado(a))"
        '
        'lbTel
        '
        Me.lbTel.AutoSize = True
        Me.lbTel.BackColor = System.Drawing.Color.Transparent
        Me.lbTel.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbTel.Location = New System.Drawing.Point(8, 52)
        Me.lbTel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTel.Name = "lbTel"
        Me.lbTel.Size = New System.Drawing.Size(311, 24)
        Me.lbTel.TabIndex = 72
        Me.lbTel.Text = "Teléfono de la empresa proveedora" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbCorreoProv
        '
        Me.lbCorreoProv.AutoSize = True
        Me.lbCorreoProv.BackColor = System.Drawing.Color.Transparent
        Me.lbCorreoProv.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbCorreoProv.Location = New System.Drawing.Point(606, 51)
        Me.lbCorreoProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCorreoProv.Name = "lbCorreoProv"
        Me.lbCorreoProv.Size = New System.Drawing.Size(295, 24)
        Me.lbCorreoProv.TabIndex = 71
        Me.lbCorreoProv.Text = "Correo de la empresa proveedora" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbCodigoProv
        '
        Me.lbCodigoProv.AutoSize = True
        Me.lbCodigoProv.BackColor = System.Drawing.Color.Transparent
        Me.lbCodigoProv.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbCodigoProv.Location = New System.Drawing.Point(102, 26)
        Me.lbCodigoProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCodigoProv.Name = "lbCodigoProv"
        Me.lbCodigoProv.Size = New System.Drawing.Size(194, 24)
        Me.lbCodigoProv.TabIndex = 70
        Me.lbCodigoProv.Text = "Código del proveedor"
        '
        'txCodProve
        '
        Me.txCodProve.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.txCodProve.Location = New System.Drawing.Point(331, 20)
        Me.txCodProve.Margin = New System.Windows.Forms.Padding(4)
        Me.txCodProve.Name = "txCodProve"
        Me.txCodProve.Size = New System.Drawing.Size(116, 32)
        Me.txCodProve.TabIndex = 69
        '
        'lbNombreProv
        '
        Me.lbNombreProv.AutoSize = True
        Me.lbNombreProv.BackColor = System.Drawing.Color.Transparent
        Me.lbNombreProv.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbNombreProv.Location = New System.Drawing.Point(595, 20)
        Me.lbNombreProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNombreProv.Name = "lbNombreProv"
        Me.lbNombreProv.Size = New System.Drawing.Size(306, 24)
        Me.lbNombreProv.TabIndex = 68
        Me.lbNombreProv.Text = "Nombre de la empresa proveedora"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Candara", 19.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 39)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Proveedores"
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1245, 800)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Proveedores"
        Me.Text = "Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btEliminar As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents btActualizarTabla As Button
    Friend WithEvents chkInhabil As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents RTBDirec As RichTextBox
    Friend WithEvents TxtTelfonoEmpresa As TextBox
    Friend WithEvents TxtCorreoProv As TextBox
    Friend WithEvents lbCorreoProve As Label
    Friend WithEvents txtTelProv As TextBox
    Friend WithEvents lbTelProvee As Label
    Friend WithEvents lbDireccProvee As Label
    Friend WithEvents txCorreoEmpresa As TextBox
    Friend WithEvents txtNombrePreEm As TextBox
    Friend WithEvents txNomProv As TextBox
    Friend WithEvents lbNomDistri As Label
    Friend WithEvents lbTel As Label
    Friend WithEvents lbCorreoProv As Label
    Friend WithEvents lbCodigoProv As Label
    Friend WithEvents txCodProve As TextBox
    Friend WithEvents lbNombreProv As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVProveedores As DataGridView
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBusqueda As TextBox
End Class
