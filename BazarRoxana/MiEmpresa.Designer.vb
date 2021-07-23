<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MiEmpresa
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
        Dim DataGridViewCellStyle77 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle78 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle79 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle80 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCAI1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRTN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.LlContador1 = New System.Windows.Forms.Label()
        Me.LbContador = New System.Windows.Forms.Label()
        Me.LbContador3 = New System.Windows.Forms.Label()
        Me.LbContador2 = New System.Windows.Forms.Label()
        Me.LbContador6 = New System.Windows.Forms.Label()
        Me.LbContador5 = New System.Windows.Forms.Label()
        Me.LbContador8 = New System.Windows.Forms.Label()
        Me.LbContador7 = New System.Windows.Forms.Label()
        Me.LbContador10 = New System.Windows.Forms.Label()
        Me.LbContador9 = New System.Windows.Forms.Label()
        Me.txtCAI2 = New System.Windows.Forms.TextBox()
        Me.txtCAI3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCAI4 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCAI6 = New System.Windows.Forms.TextBox()
        Me.txtCAI5 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(744, 306)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 38)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Selecciona una imagen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    (dar clic al cuadro)"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(675, 124)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(308, 179)
        Me.Panel1.TabIndex = 33
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(14, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(280, 150)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btndel
        '
        Me.btndel.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btndel.Location = New System.Drawing.Point(897, 165)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(85, 35)
        Me.btndel.TabIndex = 14
        Me.btndel.Text = "Eliminar"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnsave.Location = New System.Drawing.Point(19, 165)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(85, 35)
        Me.btnsave.TabIndex = 12
        Me.btnsave.Text = "Guardar"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefono.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.txtTelefono.Location = New System.Drawing.Point(423, 212)
        Me.txtTelefono.MaxLength = 8
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(181, 20)
        Me.txtTelefono.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(348, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 19)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Teléfono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(22, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 19)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Email"
        '
        'txtCAI1
        '
        Me.txtCAI1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCAI1.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.txtCAI1.Location = New System.Drawing.Point(95, 258)
        Me.txtCAI1.MaxLength = 6
        Me.txtCAI1.Name = "txtCAI1"
        Me.txtCAI1.Size = New System.Drawing.Size(67, 20)
        Me.txtCAI1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(57, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 19)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "CAI"
        '
        'txtRTN
        '
        Me.txtRTN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRTN.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.txtRTN.Location = New System.Drawing.Point(423, 166)
        Me.txtRTN.MaxLength = 14
        Me.txtRTN.Name = "txtRTN"
        Me.txtRTN.Size = New System.Drawing.Size(181, 20)
        Me.txtRTN.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(379, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 19)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "RTN"
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnUpdate.Location = New System.Drawing.Point(462, 165)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(90, 35)
        Me.BtnUpdate.TabIndex = 13
        Me.BtnUpdate.Text = "Actualizar"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDireccion.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.txtDireccion.Location = New System.Drawing.Point(96, 167)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(187, 20)
        Me.txtDireccion.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(17, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Dirección"
        '
        'TxtEmail
        '
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEmail.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtEmail.Location = New System.Drawing.Point(96, 213)
        Me.TxtEmail.MaxLength = 25
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(187, 20)
        Me.TxtEmail.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Candara", 19.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(227, 32)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Información basica"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.BazarRoxana.My.Resources.Resources.Logo
        Me.PictureBox2.Location = New System.Drawing.Point(699, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(245, 97)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 71
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.DGV)
        Me.GroupBox1.Controls.Add(Me.BtnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.btndel)
        Me.GroupBox1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 409)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(998, 219)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle77.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle77.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle77.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle77.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle77.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle77.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle77.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle77
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle78.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle78.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle78.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle78.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle78.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle78.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle78.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle78
        Me.DGV.EnableHeadersVisualStyles = False
        Me.DGV.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGV.Location = New System.Drawing.Point(15, 26)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle79.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle79.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle79.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle79.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle79.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle79.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle79.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle79
        Me.DGV.RowHeadersWidth = 51
        DataGridViewCellStyle80.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle80.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle80.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle80.SelectionForeColor = System.Drawing.Color.White
        Me.DGV.RowsDefaultCellStyle = DataGridViewCellStyle80
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(967, 120)
        Me.DGV.TabIndex = 71
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBorrar.Location = New System.Drawing.Point(21, 368)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(85, 35)
        Me.BtnBorrar.TabIndex = 11
        Me.BtnBorrar.Text = "Limpiar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'LlContador1
        '
        Me.LlContador1.AutoSize = True
        Me.LlContador1.BackColor = System.Drawing.Color.Transparent
        Me.LlContador1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LlContador1.ForeColor = System.Drawing.Color.Black
        Me.LlContador1.Location = New System.Drawing.Point(307, 169)
        Me.LlContador1.Name = "LlContador1"
        Me.LlContador1.Size = New System.Drawing.Size(30, 19)
        Me.LlContador1.TabIndex = 82
        Me.LlContador1.Text = "/50"
        '
        'LbContador
        '
        Me.LbContador.AutoSize = True
        Me.LbContador.BackColor = System.Drawing.Color.Transparent
        Me.LbContador.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador.ForeColor = System.Drawing.Color.Black
        Me.LbContador.Location = New System.Drawing.Point(289, 169)
        Me.LbContador.Name = "LbContador"
        Me.LbContador.Size = New System.Drawing.Size(18, 19)
        Me.LbContador.TabIndex = 81
        Me.LbContador.Text = "0"
        '
        'LbContador3
        '
        Me.LbContador3.AutoSize = True
        Me.LbContador3.BackColor = System.Drawing.Color.Transparent
        Me.LbContador3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador3.ForeColor = System.Drawing.Color.Black
        Me.LbContador3.Location = New System.Drawing.Point(307, 215)
        Me.LbContador3.Name = "LbContador3"
        Me.LbContador3.Size = New System.Drawing.Size(29, 19)
        Me.LbContador3.TabIndex = 84
        Me.LbContador3.Text = "/25"
        '
        'LbContador2
        '
        Me.LbContador2.AutoSize = True
        Me.LbContador2.BackColor = System.Drawing.Color.Transparent
        Me.LbContador2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador2.ForeColor = System.Drawing.Color.Black
        Me.LbContador2.Location = New System.Drawing.Point(289, 214)
        Me.LbContador2.Name = "LbContador2"
        Me.LbContador2.Size = New System.Drawing.Size(18, 19)
        Me.LbContador2.TabIndex = 83
        Me.LbContador2.Text = "0"
        '
        'LbContador6
        '
        Me.LbContador6.AutoSize = True
        Me.LbContador6.BackColor = System.Drawing.Color.Transparent
        Me.LbContador6.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador6.ForeColor = System.Drawing.Color.Black
        Me.LbContador6.Location = New System.Drawing.Point(626, 168)
        Me.LbContador6.Name = "LbContador6"
        Me.LbContador6.Size = New System.Drawing.Size(27, 19)
        Me.LbContador6.TabIndex = 86
        Me.LbContador6.Text = "/14"
        '
        'LbContador5
        '
        Me.LbContador5.AutoSize = True
        Me.LbContador5.BackColor = System.Drawing.Color.Transparent
        Me.LbContador5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador5.ForeColor = System.Drawing.Color.Black
        Me.LbContador5.Location = New System.Drawing.Point(609, 166)
        Me.LbContador5.Name = "LbContador5"
        Me.LbContador5.Size = New System.Drawing.Size(18, 19)
        Me.LbContador5.TabIndex = 85
        Me.LbContador5.Text = "0"
        '
        'LbContador8
        '
        Me.LbContador8.AutoSize = True
        Me.LbContador8.BackColor = System.Drawing.Color.Transparent
        Me.LbContador8.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador8.ForeColor = System.Drawing.Color.Black
        Me.LbContador8.Location = New System.Drawing.Point(580, 258)
        Me.LbContador8.Name = "LbContador8"
        Me.LbContador8.Size = New System.Drawing.Size(28, 19)
        Me.LbContador8.TabIndex = 88
        Me.LbContador8.Text = "/37"
        '
        'LbContador7
        '
        Me.LbContador7.AutoSize = True
        Me.LbContador7.BackColor = System.Drawing.Color.Transparent
        Me.LbContador7.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador7.ForeColor = System.Drawing.Color.Black
        Me.LbContador7.Location = New System.Drawing.Point(561, 258)
        Me.LbContador7.Name = "LbContador7"
        Me.LbContador7.Size = New System.Drawing.Size(18, 19)
        Me.LbContador7.TabIndex = 87
        Me.LbContador7.Text = "0"
        '
        'LbContador10
        '
        Me.LbContador10.AutoSize = True
        Me.LbContador10.BackColor = System.Drawing.Color.Transparent
        Me.LbContador10.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador10.ForeColor = System.Drawing.Color.Black
        Me.LbContador10.Location = New System.Drawing.Point(632, 212)
        Me.LbContador10.Name = "LbContador10"
        Me.LbContador10.Size = New System.Drawing.Size(22, 19)
        Me.LbContador10.TabIndex = 90
        Me.LbContador10.Text = "/8"
        '
        'LbContador9
        '
        Me.LbContador9.AutoSize = True
        Me.LbContador9.BackColor = System.Drawing.Color.Transparent
        Me.LbContador9.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador9.ForeColor = System.Drawing.Color.Black
        Me.LbContador9.Location = New System.Drawing.Point(620, 212)
        Me.LbContador9.Name = "LbContador9"
        Me.LbContador9.Size = New System.Drawing.Size(18, 19)
        Me.LbContador9.TabIndex = 89
        Me.LbContador9.Text = "0"
        '
        'txtCAI2
        '
        Me.txtCAI2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCAI2.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.txtCAI2.Location = New System.Drawing.Point(181, 258)
        Me.txtCAI2.MaxLength = 6
        Me.txtCAI2.Name = "txtCAI2"
        Me.txtCAI2.Size = New System.Drawing.Size(67, 20)
        Me.txtCAI2.TabIndex = 6
        '
        'txtCAI3
        '
        Me.txtCAI3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCAI3.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.txtCAI3.Location = New System.Drawing.Point(265, 259)
        Me.txtCAI3.MaxLength = 6
        Me.txtCAI3.Name = "txtCAI3"
        Me.txtCAI3.Size = New System.Drawing.Size(67, 20)
        Me.txtCAI3.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(165, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 19)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(250, 259)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 19)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(335, 259)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 19)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = "-"
        '
        'txtCAI4
        '
        Me.txtCAI4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCAI4.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.txtCAI4.Location = New System.Drawing.Point(352, 259)
        Me.txtCAI4.MaxLength = 6
        Me.txtCAI4.Name = "txtCAI4"
        Me.txtCAI4.Size = New System.Drawing.Size(67, 20)
        Me.txtCAI4.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(422, 258)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 19)
        Me.Label11.TabIndex = 98
        Me.Label11.Text = "-"
        '
        'txtCAI6
        '
        Me.txtCAI6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCAI6.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.txtCAI6.Location = New System.Drawing.Point(526, 259)
        Me.txtCAI6.MaxLength = 2
        Me.txtCAI6.Name = "txtCAI6"
        Me.txtCAI6.Size = New System.Drawing.Size(23, 20)
        Me.txtCAI6.TabIndex = 10
        '
        'txtCAI5
        '
        Me.txtCAI5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCAI5.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.txtCAI5.Location = New System.Drawing.Point(439, 259)
        Me.txtCAI5.MaxLength = 6
        Me.txtCAI5.Name = "txtCAI5"
        Me.txtCAI5.Size = New System.Drawing.Size(67, 20)
        Me.txtCAI5.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(509, 259)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 19)
        Me.Label12.TabIndex = 100
        Me.Label12.Text = "-"
        '
        'MiEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCAI5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCAI6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCAI4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCAI3)
        Me.Controls.Add(Me.txtCAI2)
        Me.Controls.Add(Me.LbContador10)
        Me.Controls.Add(Me.LbContador9)
        Me.Controls.Add(Me.LbContador8)
        Me.Controls.Add(Me.LbContador7)
        Me.Controls.Add(Me.LbContador6)
        Me.Controls.Add(Me.LbContador5)
        Me.Controls.Add(Me.LbContador3)
        Me.Controls.Add(Me.LbContador2)
        Me.Controls.Add(Me.LlContador1)
        Me.Controls.Add(Me.LbContador)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCAI1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRTN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MiEmpresa"
        Me.Text = "MiEmpresa"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btndel As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCAI1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRTN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents LlContador1 As Label
    Friend WithEvents LbContador As Label
    Friend WithEvents LbContador3 As Label
    Friend WithEvents LbContador2 As Label
    Friend WithEvents LbContador6 As Label
    Friend WithEvents LbContador5 As Label
    Friend WithEvents LbContador8 As Label
    Friend WithEvents LbContador7 As Label
    Friend WithEvents LbContador10 As Label
    Friend WithEvents LbContador9 As Label
    Friend WithEvents txtCAI2 As TextBox
    Friend WithEvents txtCAI3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCAI4 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCAI6 As TextBox
    Friend WithEvents txtCAI5 As TextBox
    Friend WithEvents Label12 As Label
End Class
