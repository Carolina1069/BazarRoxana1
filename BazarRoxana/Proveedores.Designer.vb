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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelContador7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.DGVProveedores = New System.Windows.Forms.DataGridView()
        Me.ChkInhabil = New System.Windows.Forms.CheckBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LabelContador6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelContador5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LabelContador4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelContador3 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelContador2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelContador1 = New System.Windows.Forms.Label()
        Me.LlContador1 = New System.Windows.Forms.Label()
        Me.LbContador = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.RtbDirec = New System.Windows.Forms.RichTextBox()
        Me.TxtTelfonoempresa = New System.Windows.Forms.TextBox()
        Me.TxtCorreoprov = New System.Windows.Forms.TextBox()
        Me.lbCorreoProve = New System.Windows.Forms.Label()
        Me.TxtTelprov = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbDireccProvee = New System.Windows.Forms.Label()
        Me.TxtCorreoempresa = New System.Windows.Forms.TextBox()
        Me.TxtNombreproem = New System.Windows.Forms.TextBox()
        Me.TxtNomprov = New System.Windows.Forms.TextBox()
        Me.lbNomDistri = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbTel = New System.Windows.Forms.Label()
        Me.lbCodigoProv = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCodprov = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnHabilitar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.BtnHabilitar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LabelContador7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtBusqueda)
        Me.GroupBox1.Controls.Add(Me.DGVProveedores)
        Me.GroupBox1.Controls.Add(Me.ChkInhabil)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnActualizar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 417)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1359, 370)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de Proveedor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(851, 44)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 24)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "/50"
        '
        'LabelContador7
        '
        Me.LabelContador7.AutoSize = True
        Me.LabelContador7.BackColor = System.Drawing.Color.Transparent
        Me.LabelContador7.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelContador7.ForeColor = System.Drawing.Color.Black
        Me.LabelContador7.Location = New System.Drawing.Point(821, 44)
        Me.LabelContador7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelContador7.Name = "LabelContador7"
        Me.LabelContador7.Size = New System.Drawing.Size(21, 24)
        Me.LabelContador7.TabIndex = 91
        Me.LabelContador7.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 46)
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
        Me.TxtBusqueda.Location = New System.Drawing.Point(465, 44)
        Me.TxtBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBusqueda.MaxLength = 50
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(349, 25)
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
        Me.DGVProveedores.Location = New System.Drawing.Point(59, 82)
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
        Me.DGVProveedores.Size = New System.Drawing.Size(1248, 222)
        Me.DGVProveedores.TabIndex = 72
        '
        'ChkInhabil
        '
        Me.ChkInhabil.AutoSize = True
        Me.ChkInhabil.Location = New System.Drawing.Point(938, 33)
        Me.ChkInhabil.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkInhabil.Name = "ChkInhabil"
        Me.ChkInhabil.Size = New System.Drawing.Size(147, 28)
        Me.ChkInhabil.TabIndex = 69
        Me.ChkInhabil.Text = "Inhabilitados "
        Me.ChkInhabil.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(1181, 313)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(116, 48)
        Me.BtnEliminar.TabIndex = 24
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(659, 314)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(116, 48)
        Me.BtnActualizar.TabIndex = 23
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(93, 314)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(116, 48)
        Me.BtnGuardar.TabIndex = 22
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BazarRoxana.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(1079, 14)
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
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.LabelContador6)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.LabelContador5)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.LabelContador4)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.LabelContador3)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.LabelContador2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.LabelContador1)
        Me.GroupBox2.Controls.Add(Me.LlContador1)
        Me.GroupBox2.Controls.Add(Me.LbContador)
        Me.GroupBox2.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox2.Controls.Add(Me.RtbDirec)
        Me.GroupBox2.Controls.Add(Me.TxtTelfonoempresa)
        Me.GroupBox2.Controls.Add(Me.TxtCorreoprov)
        Me.GroupBox2.Controls.Add(Me.lbCorreoProve)
        Me.GroupBox2.Controls.Add(Me.TxtTelprov)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lbDireccProvee)
        Me.GroupBox2.Controls.Add(Me.TxtCorreoempresa)
        Me.GroupBox2.Controls.Add(Me.TxtNombreproem)
        Me.GroupBox2.Controls.Add(Me.TxtNomprov)
        Me.GroupBox2.Controls.Add(Me.lbNomDistri)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lbTel)
        Me.GroupBox2.Controls.Add(Me.lbCodigoProv)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtCodprov)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(31, 132)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1357, 277)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proveedor"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(733, 164)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 24)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "/500"
        '
        'LabelContador6
        '
        Me.LabelContador6.AutoSize = True
        Me.LabelContador6.BackColor = System.Drawing.Color.Transparent
        Me.LabelContador6.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelContador6.ForeColor = System.Drawing.Color.Black
        Me.LabelContador6.Location = New System.Drawing.Point(705, 164)
        Me.LabelContador6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelContador6.Name = "LabelContador6"
        Me.LabelContador6.Size = New System.Drawing.Size(21, 24)
        Me.LabelContador6.TabIndex = 99
        Me.LabelContador6.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(607, 114)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 24)
        Me.Label11.TabIndex = 98
        Me.Label11.Text = "/100"
        '
        'LabelContador5
        '
        Me.LabelContador5.AutoSize = True
        Me.LabelContador5.BackColor = System.Drawing.Color.Transparent
        Me.LabelContador5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelContador5.ForeColor = System.Drawing.Color.Black
        Me.LabelContador5.Location = New System.Drawing.Point(579, 114)
        Me.LabelContador5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelContador5.Name = "LabelContador5"
        Me.LabelContador5.Size = New System.Drawing.Size(21, 24)
        Me.LabelContador5.TabIndex = 97
        Me.LabelContador5.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(603, 82)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 24)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "/50"
        '
        'LabelContador4
        '
        Me.LabelContador4.AutoSize = True
        Me.LabelContador4.BackColor = System.Drawing.Color.Transparent
        Me.LabelContador4.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelContador4.ForeColor = System.Drawing.Color.Black
        Me.LabelContador4.Location = New System.Drawing.Point(579, 82)
        Me.LabelContador4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelContador4.Name = "LabelContador4"
        Me.LabelContador4.Size = New System.Drawing.Size(21, 24)
        Me.LabelContador4.TabIndex = 95
        Me.LabelContador4.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(1273, 89)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 24)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "/8"
        '
        'LabelContador3
        '
        Me.LabelContador3.AutoSize = True
        Me.LabelContador3.BackColor = System.Drawing.Color.Transparent
        Me.LabelContador3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelContador3.ForeColor = System.Drawing.Color.Black
        Me.LabelContador3.Location = New System.Drawing.Point(1244, 87)
        Me.LabelContador3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelContador3.Name = "LabelContador3"
        Me.LabelContador3.Size = New System.Drawing.Size(21, 24)
        Me.LabelContador3.TabIndex = 93
        Me.LabelContador3.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(1269, 54)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 24)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "/100"
        '
        'LabelContador2
        '
        Me.LabelContador2.AutoSize = True
        Me.LabelContador2.BackColor = System.Drawing.Color.Transparent
        Me.LabelContador2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelContador2.ForeColor = System.Drawing.Color.Black
        Me.LabelContador2.Location = New System.Drawing.Point(1244, 55)
        Me.LabelContador2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelContador2.Name = "LabelContador2"
        Me.LabelContador2.Size = New System.Drawing.Size(21, 24)
        Me.LabelContador2.TabIndex = 91
        Me.LabelContador2.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1269, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 24)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "/50"
        '
        'LabelContador1
        '
        Me.LabelContador1.AutoSize = True
        Me.LabelContador1.BackColor = System.Drawing.Color.Transparent
        Me.LabelContador1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelContador1.ForeColor = System.Drawing.Color.Black
        Me.LabelContador1.Location = New System.Drawing.Point(1244, 23)
        Me.LabelContador1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelContador1.Name = "LabelContador1"
        Me.LabelContador1.Size = New System.Drawing.Size(21, 24)
        Me.LabelContador1.TabIndex = 89
        Me.LabelContador1.Text = "0"
        '
        'LlContador1
        '
        Me.LlContador1.AutoSize = True
        Me.LlContador1.BackColor = System.Drawing.Color.Transparent
        Me.LlContador1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LlContador1.ForeColor = System.Drawing.Color.Black
        Me.LlContador1.Location = New System.Drawing.Point(603, 54)
        Me.LlContador1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LlContador1.Name = "LlContador1"
        Me.LlContador1.Size = New System.Drawing.Size(26, 24)
        Me.LlContador1.TabIndex = 88
        Me.LlContador1.Text = "/8"
        '
        'LbContador
        '
        Me.LbContador.AutoSize = True
        Me.LbContador.BackColor = System.Drawing.Color.Transparent
        Me.LbContador.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador.ForeColor = System.Drawing.Color.Black
        Me.LbContador.Location = New System.Drawing.Point(579, 54)
        Me.LbContador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbContador.Name = "LbContador"
        Me.LbContador.Size = New System.Drawing.Size(21, 24)
        Me.LbContador.TabIndex = 87
        Me.LbContador.Text = "0"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLimpiar.Location = New System.Drawing.Point(1131, 203)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(165, 48)
        Me.BtnLimpiar.TabIndex = 85
        Me.BtnLimpiar.Text = "Limpiar datos"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'RtbDirec
        '
        Me.RtbDirec.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.RtbDirec.Location = New System.Drawing.Point(367, 151)
        Me.RtbDirec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RtbDirec.MaxLength = 500
        Me.RtbDirec.Name = "RtbDirec"
        Me.RtbDirec.Size = New System.Drawing.Size(327, 111)
        Me.RtbDirec.TabIndex = 7
        Me.RtbDirec.Text = ""
        '
        'TxtTelfonoempresa
        '
        Me.TxtTelfonoempresa.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtTelfonoempresa.Location = New System.Drawing.Point(367, 52)
        Me.TxtTelfonoempresa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTelfonoempresa.MaxLength = 8
        Me.TxtTelfonoempresa.Name = "TxtTelfonoempresa"
        Me.TxtTelfonoempresa.Size = New System.Drawing.Size(203, 32)
        Me.TxtTelfonoempresa.TabIndex = 2
        '
        'TxtCorreoprov
        '
        Me.TxtCorreoprov.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtCorreoprov.Location = New System.Drawing.Point(367, 116)
        Me.TxtCorreoprov.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCorreoprov.MaxLength = 100
        Me.TxtCorreoprov.Name = "TxtCorreoprov"
        Me.TxtCorreoprov.Size = New System.Drawing.Size(203, 32)
        Me.TxtCorreoprov.TabIndex = 6
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
        'TxtTelprov
        '
        Me.TxtTelprov.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtTelprov.Location = New System.Drawing.Point(967, 81)
        Me.TxtTelprov.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTelprov.MaxLength = 8
        Me.TxtTelprov.Name = "TxtTelprov"
        Me.TxtTelprov.Size = New System.Drawing.Size(269, 32)
        Me.TxtTelprov.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(732, 84)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(209, 24)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Teléfono del proveedor"
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
        'TxtCorreoempresa
        '
        Me.TxtCorreoempresa.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtCorreoempresa.Location = New System.Drawing.Point(967, 49)
        Me.TxtCorreoempresa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCorreoempresa.MaxLength = 100
        Me.TxtCorreoempresa.Name = "TxtCorreoempresa"
        Me.TxtCorreoempresa.Size = New System.Drawing.Size(269, 32)
        Me.TxtCorreoempresa.TabIndex = 3
        '
        'TxtNombreproem
        '
        Me.TxtNombreproem.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtNombreproem.Location = New System.Drawing.Point(367, 84)
        Me.TxtNombreproem.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombreproem.MaxLength = 50
        Me.TxtNombreproem.Name = "TxtNombreproem"
        Me.TxtNombreproem.Size = New System.Drawing.Size(203, 32)
        Me.TxtNombreproem.TabIndex = 4
        '
        'TxtNomprov
        '
        Me.TxtNomprov.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtNomprov.Location = New System.Drawing.Point(967, 17)
        Me.TxtNomprov.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNomprov.MaxLength = 50
        Me.TxtNomprov.Name = "TxtNomprov"
        Me.TxtNomprov.Size = New System.Drawing.Size(269, 32)
        Me.TxtNomprov.TabIndex = 1
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(652, 50)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(295, 24)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Correo de la empresa proveedora" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        'lbCodigoProv
        '
        Me.lbCodigoProv.AutoSize = True
        Me.lbCodigoProv.BackColor = System.Drawing.Color.Transparent
        Me.lbCodigoProv.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbCodigoProv.Location = New System.Drawing.Point(101, 26)
        Me.lbCodigoProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCodigoProv.Name = "lbCodigoProv"
        Me.lbCodigoProv.Size = New System.Drawing.Size(194, 24)
        Me.lbCodigoProv.TabIndex = 70
        Me.lbCodigoProv.Text = "Código del proveedor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(635, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(306, 24)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Nombre de la empresa proveedora"
        '
        'TxtCodprov
        '
        Me.TxtCodprov.Enabled = False
        Me.TxtCodprov.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtCodprov.Location = New System.Drawing.Point(367, 20)
        Me.TxtCodprov.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodprov.Name = "TxtCodprov"
        Me.TxtCodprov.Size = New System.Drawing.Size(116, 32)
        Me.TxtCodprov.TabIndex = 69
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
        'BtnHabilitar
        '
        Me.BtnHabilitar.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnHabilitar.Location = New System.Drawing.Point(1112, 20)
        Me.BtnHabilitar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnHabilitar.Name = "BtnHabilitar"
        Me.BtnHabilitar.Size = New System.Drawing.Size(212, 48)
        Me.BtnHabilitar.TabIndex = 93
        Me.BtnHabilitar.Text = "Habilitar proveedor"
        Me.BtnHabilitar.UseVisualStyleBackColor = True
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1387, 788)
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
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents ChkInhabil As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RtbDirec As RichTextBox
    Friend WithEvents TxtTelfonoempresa As TextBox
    Friend WithEvents TxtCorreoprov As TextBox
    Friend WithEvents lbCorreoProve As Label
    Friend WithEvents TxtTelprov As TextBox
    Friend WithEvents lbDireccProvee As Label
    Friend WithEvents TxtCorreoempresa As TextBox
    Friend WithEvents TxtNombreproem As TextBox
    Friend WithEvents TxtNomprov As TextBox
    Friend WithEvents lbNomDistri As Label
    Friend WithEvents lbTel As Label
    Friend WithEvents lbCodigoProv As Label
    Friend WithEvents TxtCodprov As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVProveedores As DataGridView
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents LlContador1 As Label
    Friend WithEvents LbContador As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelContador1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LabelContador6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LabelContador5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LabelContador4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelContador3 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelContador2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelContador7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnHabilitar As Button
End Class
