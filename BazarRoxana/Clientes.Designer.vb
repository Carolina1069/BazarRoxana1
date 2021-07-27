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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnHabilitar = New System.Windows.Forms.Button()
        Me.LbContador9 = New System.Windows.Forms.Label()
        Me.LbContador8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.DgvCliente = New System.Windows.Forms.DataGridView()
        Me.ChkInhabil = New System.Windows.Forms.CheckBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
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
        Me.RtbDircli = New System.Windows.Forms.RichTextBox()
        Me.TxtCorreocli = New System.Windows.Forms.TextBox()
        Me.TxtTelcli = New System.Windows.Forms.TextBox()
        Me.TxtNomcli = New System.Windows.Forms.TextBox()
        Me.lbDirCli = New System.Windows.Forms.Label()
        Me.lbTelCli = New System.Windows.Forms.Label()
        Me.LbCorreo = New System.Windows.Forms.Label()
        Me.lbCodigoCli = New System.Windows.Forms.Label()
        Me.TxtCodcli = New System.Windows.Forms.TextBox()
        Me.LbNombrecli = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(491, 273)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(87, 39)
        Me.BtnActualizar.TabIndex = 23
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(922, 273)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(87, 39)
        Me.BtnEliminar.TabIndex = 24
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.BtnHabilitar)
        Me.GroupBox1.Controls.Add(Me.LbContador9)
        Me.GroupBox1.Controls.Add(Me.LbContador8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtBusqueda)
        Me.GroupBox1.Controls.Add(Me.DgvCliente)
        Me.GroupBox1.Controls.Add(Me.ChkInhabil)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnActualizar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 315)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1015, 323)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda del Cliente"
        '
        'BtnHabilitar
        '
        Me.BtnHabilitar.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnHabilitar.Location = New System.Drawing.Point(882, 25)
        Me.BtnHabilitar.Name = "BtnHabilitar"
        Me.BtnHabilitar.Size = New System.Drawing.Size(127, 39)
        Me.BtnHabilitar.TabIndex = 94
        Me.BtnHabilitar.Text = "Habilitar cliente"
        Me.BtnHabilitar.UseVisualStyleBackColor = True
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
        'DgvCliente
        '
        Me.DgvCliente.AllowUserToAddRows = False
        Me.DgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCliente.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.DgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvCliente.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvCliente.EnableHeadersVisualStyles = False
        Me.DgvCliente.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DgvCliente.Location = New System.Drawing.Point(16, 71)
        Me.DgvCliente.Name = "DgvCliente"
        Me.DgvCliente.ReadOnly = True
        Me.DgvCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvCliente.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DgvCliente.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCliente.Size = New System.Drawing.Size(993, 180)
        Me.DgvCliente.TabIndex = 72
        '
        'ChkInhabil
        '
        Me.ChkInhabil.AutoSize = True
        Me.ChkInhabil.Location = New System.Drawing.Point(755, 36)
        Me.ChkInhabil.Name = "ChkInhabil"
        Me.ChkInhabil.Size = New System.Drawing.Size(121, 23)
        Me.ChkInhabil.TabIndex = 68
        Me.ChkInhabil.Text = "Inhabilitados "
        Me.ChkInhabil.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(21, 273)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(87, 39)
        Me.BtnGuardar.TabIndex = 22
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'LbContador7
        '
        Me.LbContador7.AutoSize = True
        Me.LbContador7.BackColor = System.Drawing.Color.Transparent
        Me.LbContador7.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador7.ForeColor = System.Drawing.Color.Black
        Me.LbContador7.Location = New System.Drawing.Point(953, 77)
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
        Me.LbContador6.Location = New System.Drawing.Point(933, 76)
        Me.LbContador6.Name = "LbContador6"
        Me.LbContador6.Size = New System.Drawing.Size(18, 19)
        Me.LbContador6.TabIndex = 84
        Me.LbContador6.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BazarRoxana.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(809, 11)
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
        Me.GroupBox2.Controls.Add(Me.RtbDircli)
        Me.GroupBox2.Controls.Add(Me.TxtCorreocli)
        Me.GroupBox2.Controls.Add(Me.TxtTelcli)
        Me.GroupBox2.Controls.Add(Me.TxtNomcli)
        Me.GroupBox2.Controls.Add(Me.lbDirCli)
        Me.GroupBox2.Controls.Add(Me.lbTelCli)
        Me.GroupBox2.Controls.Add(Me.LbCorreo)
        Me.GroupBox2.Controls.Add(Me.lbCodigoCli)
        Me.GroupBox2.Controls.Add(Me.TxtCodcli)
        Me.GroupBox2.Controls.Add(Me.LbNombrecli)
        Me.GroupBox2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1009, 183)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLimpiar.Location = New System.Drawing.Point(771, 134)
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
        Me.LbContador5.Location = New System.Drawing.Point(954, 27)
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
        Me.LbContador4.Location = New System.Drawing.Point(934, 26)
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
        Me.LbContador3.Location = New System.Drawing.Point(383, 105)
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
        Me.LbContador2.Location = New System.Drawing.Point(363, 104)
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
        Me.LlContador1.Location = New System.Drawing.Point(311, 69)
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
        Me.LbContador.Location = New System.Drawing.Point(299, 69)
        Me.LbContador.Name = "LbContador"
        Me.LbContador.Size = New System.Drawing.Size(18, 19)
        Me.LbContador.TabIndex = 79
        Me.LbContador.Text = "0"
        '
        'RtbDircli
        '
        Me.RtbDircli.Location = New System.Drawing.Point(183, 101)
        Me.RtbDircli.MaxLength = 50
        Me.RtbDircli.Name = "RtbDircli"
        Me.RtbDircli.Size = New System.Drawing.Size(174, 57)
        Me.RtbDircli.TabIndex = 77
        Me.RtbDircli.Text = ""
        '
        'TxtCorreocli
        '
        Me.TxtCorreocli.Location = New System.Drawing.Point(771, 72)
        Me.TxtCorreocli.MaxLength = 20
        Me.TxtCorreocli.Name = "TxtCorreocli"
        Me.TxtCorreocli.Size = New System.Drawing.Size(159, 27)
        Me.TxtCorreocli.TabIndex = 76
        '
        'TxtTelcli
        '
        Me.TxtTelcli.Location = New System.Drawing.Point(183, 65)
        Me.TxtTelcli.MaxLength = 8
        Me.TxtTelcli.Name = "TxtTelcli"
        Me.TxtTelcli.Size = New System.Drawing.Size(100, 27)
        Me.TxtTelcli.TabIndex = 75
        '
        'TxtNomcli
        '
        Me.TxtNomcli.Location = New System.Drawing.Point(771, 21)
        Me.TxtNomcli.MaxLength = 20
        Me.TxtNomcli.Name = "TxtNomcli"
        Me.TxtNomcli.Size = New System.Drawing.Size(159, 27)
        Me.TxtNomcli.TabIndex = 74
        '
        'lbDirCli
        '
        Me.lbDirCli.AutoSize = True
        Me.lbDirCli.BackColor = System.Drawing.Color.Transparent
        Me.lbDirCli.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbDirCli.Location = New System.Drawing.Point(20, 104)
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
        Me.lbTelCli.Location = New System.Drawing.Point(99, 68)
        Me.lbTelCli.Name = "lbTelCli"
        Me.lbTelCli.Size = New System.Drawing.Size(69, 19)
        Me.lbTelCli.TabIndex = 72
        Me.lbTelCli.Text = "Teléfono"
        '
        'LbCorreo
        '
        Me.LbCorreo.AutoSize = True
        Me.LbCorreo.BackColor = System.Drawing.Color.Transparent
        Me.LbCorreo.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbCorreo.Location = New System.Drawing.Point(709, 77)
        Me.LbCorreo.Name = "LbCorreo"
        Me.LbCorreo.Size = New System.Drawing.Size(59, 19)
        Me.LbCorreo.TabIndex = 71
        Me.LbCorreo.Text = "Correo "
        '
        'lbCodigoCli
        '
        Me.lbCodigoCli.AutoSize = True
        Me.lbCodigoCli.BackColor = System.Drawing.Color.Transparent
        Me.lbCodigoCli.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbCodigoCli.Location = New System.Drawing.Point(44, 28)
        Me.lbCodigoCli.Name = "lbCodigoCli"
        Me.lbCodigoCli.Size = New System.Drawing.Size(133, 19)
        Me.lbCodigoCli.TabIndex = 70
        Me.lbCodigoCli.Text = "Código del Cliente"
        '
        'TxtCodcli
        '
        Me.TxtCodcli.Enabled = False
        Me.TxtCodcli.Location = New System.Drawing.Point(183, 24)
        Me.TxtCodcli.Name = "TxtCodcli"
        Me.TxtCodcli.Size = New System.Drawing.Size(100, 27)
        Me.TxtCodcli.TabIndex = 69
        '
        'LbNombrecli
        '
        Me.LbNombrecli.AutoSize = True
        Me.LbNombrecli.BackColor = System.Drawing.Color.Transparent
        Me.LbNombrecli.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbNombrecli.Location = New System.Drawing.Point(625, 26)
        Me.LbNombrecli.Name = "LbNombrecli"
        Me.LbNombrecli.Size = New System.Drawing.Size(140, 19)
        Me.LbNombrecli.TabIndex = 68
        Me.LbNombrecli.Text = "Nombre del Cliente"
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
        Me.ClientSize = New System.Drawing.Size(1053, 681)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clientes"
        Me.Text = "c"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ChkInhabil As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RtbDircli As RichTextBox
    Friend WithEvents TxtCorreocli As TextBox
    Friend WithEvents TxtTelcli As TextBox
    Friend WithEvents TxtNomcli As TextBox
    Friend WithEvents lbDirCli As Label
    Friend WithEvents lbTelCli As Label
    Friend WithEvents LbCorreo As Label
    Friend WithEvents LbNombrecli As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvCliente As DataGridView
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
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents lbCodigoCli As Label
    Friend WithEvents TxtCodcli As TextBox
    Friend WithEvents BtnHabilitar As Button
End Class
