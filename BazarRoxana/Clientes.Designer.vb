<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clientes
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
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btActualizarTabla = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbContador9 = New System.Windows.Forms.Label()
        Me.LbContador8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.DGVCliente = New System.Windows.Forms.DataGridView()
        Me.chkInhabil = New System.Windows.Forms.CheckBox()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.LbContador7 = New System.Windows.Forms.Label()
        Me.LbContador6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.LbContador5 = New System.Windows.Forms.Label()
        Me.LbContador4 = New System.Windows.Forms.Label()
        Me.LbContador3 = New System.Windows.Forms.Label()
        Me.LbContador2 = New System.Windows.Forms.Label()
        Me.LlContador1 = New System.Windows.Forms.Label()
        Me.LbContador = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.rtxDirCli = New System.Windows.Forms.RichTextBox()
        Me.txCorreoCli = New System.Windows.Forms.TextBox()
        Me.txTelCli = New System.Windows.Forms.TextBox()
        Me.txNomCli = New System.Windows.Forms.TextBox()
        Me.lbDirCli = New System.Windows.Forms.Label()
        Me.lbTelCli = New System.Windows.Forms.Label()
        Me.lbCorreo = New System.Windows.Forms.Label()
        Me.lbCodigoCli = New System.Windows.Forms.Label()
        Me.txCodCli = New System.Windows.Forms.TextBox()
        Me.lbNombreCli = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(382, 273)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(87, 39)
        Me.btActualizar.TabIndex = 23
        Me.btActualizar.Text = "Actualizar"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'btActualizarTabla
        '
        Me.btActualizarTabla.Location = New System.Drawing.Point(694, 26)
        Me.btActualizarTabla.Name = "btActualizarTabla"
        Me.btActualizarTabla.Size = New System.Drawing.Size(124, 39)
        Me.btActualizarTabla.TabIndex = 23
        Me.btActualizarTabla.Text = "Refrescar Tabla"
        Me.btActualizarTabla.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(709, 273)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(87, 39)
        Me.btEliminar.TabIndex = 24
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.LbContador9)
        Me.GroupBox1.Controls.Add(Me.LbContador8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtBusqueda)
        Me.GroupBox1.Controls.Add(Me.DGVCliente)
        Me.GroupBox1.Controls.Add(Me.chkInhabil)
        Me.GroupBox1.Controls.Add(Me.btEliminar)
        Me.GroupBox1.Controls.Add(Me.btActualizarTabla)
        Me.GroupBox1.Controls.Add(Me.btActualizar)
        Me.GroupBox1.Controls.Add(Me.btGuardar)
        Me.GroupBox1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 304)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(835, 323)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda del Cliente"
        '
        'LbContador9
        '
        Me.LbContador9.AutoSize = True
        Me.LbContador9.BackColor = System.Drawing.Color.Transparent
        Me.LbContador9.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador9.ForeColor = System.Drawing.Color.Black
        Me.LbContador9.Location = New System.Drawing.Point(470, 35)
        Me.LbContador9.Name = "LbContador9"
        Me.LbContador9.Size = New System.Drawing.Size(30, 19)
        Me.LbContador9.TabIndex = 86
        Me.LbContador9.Text = "/20"
        '
        'LbContador8
        '
        Me.LbContador8.AutoSize = True
        Me.LbContador8.BackColor = System.Drawing.Color.Transparent
        Me.LbContador8.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador8.ForeColor = System.Drawing.Color.Black
        Me.LbContador8.Location = New System.Drawing.Point(450, 34)
        Me.LbContador8.Name = "LbContador8"
        Me.LbContador8.Size = New System.Drawing.Size(18, 19)
        Me.LbContador8.TabIndex = 85
        Me.LbContador8.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 19)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Escriba el nombre del empleado:"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBusqueda.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtBusqueda.Location = New System.Drawing.Point(251, 35)
        Me.TxtBusqueda.MaxLength = 20
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(189, 20)
        Me.TxtBusqueda.TabIndex = 82
        '
        'DGVCliente
        '
        Me.DGVCliente.AllowUserToAddRows = False
        Me.DGVCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVCliente.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.DGVCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGVCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCliente.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGVCliente.EnableHeadersVisualStyles = False
        Me.DGVCliente.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGVCliente.Location = New System.Drawing.Point(16, 71)
        Me.DGVCliente.Name = "DGVCliente"
        Me.DGVCliente.ReadOnly = True
        Me.DGVCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVCliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGVCliente.RowHeadersWidth = 51
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.DGVCliente.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DGVCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCliente.Size = New System.Drawing.Size(802, 180)
        Me.DGVCliente.TabIndex = 72
        '
        'chkInhabil
        '
        Me.chkInhabil.AutoSize = True
        Me.chkInhabil.Location = New System.Drawing.Point(567, 35)
        Me.chkInhabil.Name = "chkInhabil"
        Me.chkInhabil.Size = New System.Drawing.Size(121, 23)
        Me.chkInhabil.TabIndex = 68
        Me.chkInhabil.Text = "Inhabilitados "
        Me.chkInhabil.UseVisualStyleBackColor = True
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(11, 273)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(87, 39)
        Me.btGuardar.TabIndex = 22
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'LbContador7
        '
        Me.LbContador7.AutoSize = True
        Me.LbContador7.BackColor = System.Drawing.Color.Transparent
        Me.LbContador7.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador7.ForeColor = System.Drawing.Color.Black
        Me.LbContador7.Location = New System.Drawing.Point(788, 77)
        Me.LbContador7.Name = "LbContador7"
        Me.LbContador7.Size = New System.Drawing.Size(30, 19)
        Me.LbContador7.TabIndex = 85
        Me.LbContador7.Text = "/20"
        '
        'LbContador6
        '
        Me.LbContador6.AutoSize = True
        Me.LbContador6.BackColor = System.Drawing.Color.Transparent
        Me.LbContador6.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador6.ForeColor = System.Drawing.Color.Black
        Me.LbContador6.Location = New System.Drawing.Point(768, 76)
        Me.LbContador6.Name = "LbContador6"
        Me.LbContador6.Size = New System.Drawing.Size(18, 19)
        Me.LbContador6.TabIndex = 84
        Me.LbContador6.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BazarRoxana.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(677, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox2.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox2.Controls.Add(Me.LbContador5)
        Me.GroupBox2.Controls.Add(Me.LbContador4)
        Me.GroupBox2.Controls.Add(Me.LbContador7)
        Me.GroupBox2.Controls.Add(Me.LbContador6)
        Me.GroupBox2.Controls.Add(Me.LbContador3)
        Me.GroupBox2.Controls.Add(Me.LbContador2)
        Me.GroupBox2.Controls.Add(Me.LlContador1)
        Me.GroupBox2.Controls.Add(Me.LbContador)
        Me.GroupBox2.Controls.Add(Me.chkEstado)
        Me.GroupBox2.Controls.Add(Me.rtxDirCli)
        Me.GroupBox2.Controls.Add(Me.txCorreoCli)
        Me.GroupBox2.Controls.Add(Me.txTelCli)
        Me.GroupBox2.Controls.Add(Me.txNomCli)
        Me.GroupBox2.Controls.Add(Me.lbDirCli)
        Me.GroupBox2.Controls.Add(Me.lbTelCli)
        Me.GroupBox2.Controls.Add(Me.lbCorreo)
        Me.GroupBox2.Controls.Add(Me.lbCodigoCli)
        Me.GroupBox2.Controls.Add(Me.txCodCli)
        Me.GroupBox2.Controls.Add(Me.lbNombreCli)
        Me.GroupBox2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(40, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(835, 183)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLimpiar.Location = New System.Drawing.Point(606, 134)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(124, 39)
        Me.BtnLimpiar.TabIndex = 86
        Me.BtnLimpiar.Text = "Limpiar datos"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'LbContador5
        '
        Me.LbContador5.AutoSize = True
        Me.LbContador5.BackColor = System.Drawing.Color.Transparent
        Me.LbContador5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador5.ForeColor = System.Drawing.Color.Black
        Me.LbContador5.Location = New System.Drawing.Point(789, 27)
        Me.LbContador5.Name = "LbContador5"
        Me.LbContador5.Size = New System.Drawing.Size(30, 19)
        Me.LbContador5.TabIndex = 84
        Me.LbContador5.Text = "/20"
        '
        'LbContador4
        '
        Me.LbContador4.AutoSize = True
        Me.LbContador4.BackColor = System.Drawing.Color.Transparent
        Me.LbContador4.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador4.ForeColor = System.Drawing.Color.Black
        Me.LbContador4.Location = New System.Drawing.Point(769, 26)
        Me.LbContador4.Name = "LbContador4"
        Me.LbContador4.Size = New System.Drawing.Size(18, 19)
        Me.LbContador4.TabIndex = 83
        Me.LbContador4.Text = "0"
        '
        'LbContador3
        '
        Me.LbContador3.AutoSize = True
        Me.LbContador3.BackColor = System.Drawing.Color.Transparent
        Me.LbContador3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador3.ForeColor = System.Drawing.Color.Black
        Me.LbContador3.Location = New System.Drawing.Point(396, 105)
        Me.LbContador3.Name = "LbContador3"
        Me.LbContador3.Size = New System.Drawing.Size(30, 19)
        Me.LbContador3.TabIndex = 82
        Me.LbContador3.Text = "/50"
        '
        'LbContador2
        '
        Me.LbContador2.AutoSize = True
        Me.LbContador2.BackColor = System.Drawing.Color.Transparent
        Me.LbContador2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador2.ForeColor = System.Drawing.Color.Black
        Me.LbContador2.Location = New System.Drawing.Point(376, 104)
        Me.LbContador2.Name = "LbContador2"
        Me.LbContador2.Size = New System.Drawing.Size(18, 19)
        Me.LbContador2.TabIndex = 81
        Me.LbContador2.Text = "0"
        '
        'LlContador1
        '
        Me.LlContador1.AutoSize = True
        Me.LlContador1.BackColor = System.Drawing.Color.Transparent
        Me.LlContador1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LlContador1.ForeColor = System.Drawing.Color.Black
        Me.LlContador1.Location = New System.Drawing.Point(324, 69)
        Me.LlContador1.Name = "LlContador1"
        Me.LlContador1.Size = New System.Drawing.Size(22, 19)
        Me.LlContador1.TabIndex = 80
        Me.LlContador1.Text = "/8"
        '
        'LbContador
        '
        Me.LbContador.AutoSize = True
        Me.LbContador.BackColor = System.Drawing.Color.Transparent
        Me.LbContador.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador.ForeColor = System.Drawing.Color.Black
        Me.LbContador.Location = New System.Drawing.Point(312, 69)
        Me.LbContador.Name = "LbContador"
        Me.LbContador.Size = New System.Drawing.Size(18, 19)
        Me.LbContador.TabIndex = 79
        Me.LbContador.Text = "0"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.BackColor = System.Drawing.Color.Transparent
        Me.chkEstado.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chkEstado.Location = New System.Drawing.Point(606, 105)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(75, 23)
        Me.chkEstado.TabIndex = 78
        Me.chkEstado.Text = "Estado"
        Me.chkEstado.UseVisualStyleBackColor = False
        '
        'rtxDirCli
        '
        Me.rtxDirCli.Location = New System.Drawing.Point(196, 101)
        Me.rtxDirCli.MaxLength = 50
        Me.rtxDirCli.Name = "rtxDirCli"
        Me.rtxDirCli.Size = New System.Drawing.Size(174, 57)
        Me.rtxDirCli.TabIndex = 77
        Me.rtxDirCli.Text = ""
        '
        'txCorreoCli
        '
        Me.txCorreoCli.Location = New System.Drawing.Point(606, 72)
        Me.txCorreoCli.MaxLength = 20
        Me.txCorreoCli.Name = "txCorreoCli"
        Me.txCorreoCli.Size = New System.Drawing.Size(159, 27)
        Me.txCorreoCli.TabIndex = 76
        '
        'txTelCli
        '
        Me.txTelCli.Location = New System.Drawing.Point(196, 65)
        Me.txTelCli.MaxLength = 8
        Me.txTelCli.Name = "txTelCli"
        Me.txTelCli.Size = New System.Drawing.Size(100, 27)
        Me.txTelCli.TabIndex = 75
        '
        'txNomCli
        '
        Me.txNomCli.Location = New System.Drawing.Point(606, 21)
        Me.txNomCli.MaxLength = 20
        Me.txNomCli.Name = "txNomCli"
        Me.txNomCli.Size = New System.Drawing.Size(159, 27)
        Me.txNomCli.TabIndex = 74
        '
        'lbDirCli
        '
        Me.lbDirCli.AutoSize = True
        Me.lbDirCli.BackColor = System.Drawing.Color.Transparent
        Me.lbDirCli.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbDirCli.Location = New System.Drawing.Point(33, 104)
        Me.lbDirCli.Name = "lbDirCli"
        Me.lbDirCli.Size = New System.Drawing.Size(148, 19)
        Me.lbDirCli.TabIndex = 73
        Me.lbDirCli.Text = "Dirección del Cliente"
        '
        'lbTelCli
        '
        Me.lbTelCli.AutoSize = True
        Me.lbTelCli.BackColor = System.Drawing.Color.Transparent
        Me.lbTelCli.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbTelCli.Location = New System.Drawing.Point(112, 68)
        Me.lbTelCli.Name = "lbTelCli"
        Me.lbTelCli.Size = New System.Drawing.Size(69, 19)
        Me.lbTelCli.TabIndex = 72
        Me.lbTelCli.Text = "Teléfono"
        '
        'lbCorreo
        '
        Me.lbCorreo.AutoSize = True
        Me.lbCorreo.BackColor = System.Drawing.Color.Transparent
        Me.lbCorreo.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbCorreo.Location = New System.Drawing.Point(544, 77)
        Me.lbCorreo.Name = "lbCorreo"
        Me.lbCorreo.Size = New System.Drawing.Size(59, 19)
        Me.lbCorreo.TabIndex = 71
        Me.lbCorreo.Text = "Correo "
        '
        'lbCodigoCli
        '
        Me.lbCodigoCli.AutoSize = True
        Me.lbCodigoCli.BackColor = System.Drawing.Color.Transparent
        Me.lbCodigoCli.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbCodigoCli.Location = New System.Drawing.Point(57, 28)
        Me.lbCodigoCli.Name = "lbCodigoCli"
        Me.lbCodigoCli.Size = New System.Drawing.Size(133, 19)
        Me.lbCodigoCli.TabIndex = 70
        Me.lbCodigoCli.Text = "Código del Cliente"
        '
        'txCodCli
        '
        Me.txCodCli.Enabled = False
        Me.txCodCli.Location = New System.Drawing.Point(196, 24)
        Me.txCodCli.Name = "txCodCli"
        Me.txCodCli.Size = New System.Drawing.Size(100, 27)
        Me.txCodCli.TabIndex = 69
        '
        'lbNombreCli
        '
        Me.lbNombreCli.AutoSize = True
        Me.lbNombreCli.BackColor = System.Drawing.Color.Transparent
        Me.lbNombreCli.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbNombreCli.Location = New System.Drawing.Point(460, 26)
        Me.lbNombreCli.Name = "lbNombreCli"
        Me.lbNombreCli.Size = New System.Drawing.Size(140, 19)
        Me.lbNombreCli.TabIndex = 68
        Me.lbNombreCli.Text = "Nombre del Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Candara", 19.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 32)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Clientes"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(934, 650)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clientes"
        Me.Text = "c"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btActualizar As Button
    Friend WithEvents btActualizarTabla As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkInhabil As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents rtxDirCli As RichTextBox
    Friend WithEvents txCorreoCli As TextBox
    Friend WithEvents txTelCli As TextBox
    Friend WithEvents txNomCli As TextBox
    Friend WithEvents lbDirCli As Label
    Friend WithEvents lbTelCli As Label
    Friend WithEvents lbCorreo As Label
    Friend WithEvents lbNombreCli As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVCliente As DataGridView
    Friend WithEvents LbContador7 As Label
    Friend WithEvents LbContador6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents LbContador3 As Label
    Friend WithEvents LbContador2 As Label
    Friend WithEvents LlContador1 As Label
    Friend WithEvents LbContador As Label
    Friend WithEvents LbContador5 As Label
    Friend WithEvents LbContador4 As Label
    Friend WithEvents LbContador9 As Label
    Friend WithEvents LbContador8 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents lbCodigoCli As Label
    Friend WithEvents txCodCli As TextBox
End Class
