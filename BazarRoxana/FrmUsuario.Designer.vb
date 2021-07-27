<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuario))
        Me.LbContador5 = New System.Windows.Forms.Label()
        Me.LbContador4 = New System.Windows.Forms.Label()
        Me.LbContador3 = New System.Windows.Forms.Label()
        Me.LbContador2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.ChkMostrarcontra = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.TxtCodigousuario = New System.Windows.Forms.TextBox()
        Me.lbCodigoUsuario = New System.Windows.Forms.Label()
        Me.TxtCodigoempleado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbNombreEmpleado = New System.Windows.Forms.Label()
        Me.txtNombreempleado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbContador7 = New System.Windows.Forms.Label()
        Me.LbContador6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.DgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.btnLimpiarEmple = New System.Windows.Forms.Button()
        Me.btnAgg_E = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbContador5
        '
        Me.LbContador5.AutoSize = True
        Me.LbContador5.BackColor = System.Drawing.Color.Transparent
        Me.LbContador5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador5.ForeColor = System.Drawing.Color.Black
        Me.LbContador5.Location = New System.Drawing.Point(629, 265)
        Me.LbContador5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbContador5.Name = "LbContador5"
        Me.LbContador5.Size = New System.Drawing.Size(34, 24)
        Me.LbContador5.TabIndex = 87
        Me.LbContador5.Text = "/25"
        '
        'LbContador4
        '
        Me.LbContador4.AutoSize = True
        Me.LbContador4.BackColor = System.Drawing.Color.Transparent
        Me.LbContador4.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador4.ForeColor = System.Drawing.Color.Black
        Me.LbContador4.Location = New System.Drawing.Point(600, 263)
        Me.LbContador4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbContador4.Name = "LbContador4"
        Me.LbContador4.Size = New System.Drawing.Size(21, 24)
        Me.LbContador4.TabIndex = 86
        Me.LbContador4.Text = "0"
        '
        'LbContador3
        '
        Me.LbContador3.AutoSize = True
        Me.LbContador3.BackColor = System.Drawing.Color.Transparent
        Me.LbContador3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador3.ForeColor = System.Drawing.Color.Black
        Me.LbContador3.Location = New System.Drawing.Point(629, 234)
        Me.LbContador3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbContador3.Name = "LbContador3"
        Me.LbContador3.Size = New System.Drawing.Size(36, 24)
        Me.LbContador3.TabIndex = 85
        Me.LbContador3.Text = "/20"
        '
        'LbContador2
        '
        Me.LbContador2.AutoSize = True
        Me.LbContador2.BackColor = System.Drawing.Color.Transparent
        Me.LbContador2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador2.ForeColor = System.Drawing.Color.Black
        Me.LbContador2.Location = New System.Drawing.Point(600, 233)
        Me.LbContador2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbContador2.Name = "LbContador2"
        Me.LbContador2.Size = New System.Drawing.Size(21, 24)
        Me.LbContador2.TabIndex = 84
        Me.LbContador2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(89, 234)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 24)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Usuario del empleado"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUsuario.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtUsuario.Location = New System.Drawing.Point(337, 233)
        Me.TxtUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtUsuario.MaxLength = 20
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(252, 25)
        Me.TxtUsuario.TabIndex = 82
        '
        'ChkMostrarcontra
        '
        Me.ChkMostrarcontra.AutoSize = True
        Me.ChkMostrarcontra.BackColor = System.Drawing.Color.Transparent
        Me.ChkMostrarcontra.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ChkMostrarcontra.Location = New System.Drawing.Point(337, 295)
        Me.ChkMostrarcontra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkMostrarcontra.Name = "ChkMostrarcontra"
        Me.ChkMostrarcontra.Size = New System.Drawing.Size(192, 28)
        Me.ChkMostrarcontra.TabIndex = 81
        Me.ChkMostrarcontra.Text = "Mostrar contaseña"
        Me.ChkMostrarcontra.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(84, 270)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 24)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Contraseña del empleado"
        '
        'TxtContraseña
        '
        Me.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtContraseña.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtContraseña.Location = New System.Drawing.Point(337, 265)
        Me.TxtContraseña.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtContraseña.MaxLength = 25
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(252, 25)
        Me.TxtContraseña.TabIndex = 79
        Me.TxtContraseña.UseSystemPasswordChar = True
        '
        'TxtCodigousuario
        '
        Me.TxtCodigousuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodigousuario.Enabled = False
        Me.TxtCodigousuario.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtCodigousuario.Location = New System.Drawing.Point(337, 201)
        Me.TxtCodigousuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCodigousuario.Name = "TxtCodigousuario"
        Me.TxtCodigousuario.Size = New System.Drawing.Size(161, 25)
        Me.TxtCodigousuario.TabIndex = 89
        '
        'lbCodigoUsuario
        '
        Me.lbCodigoUsuario.AutoSize = True
        Me.lbCodigoUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lbCodigoUsuario.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbCodigoUsuario.Location = New System.Drawing.Point(120, 201)
        Me.lbCodigoUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCodigoUsuario.Name = "lbCodigoUsuario"
        Me.lbCodigoUsuario.Size = New System.Drawing.Size(168, 24)
        Me.lbCodigoUsuario.TabIndex = 88
        Me.lbCodigoUsuario.Text = "Código del usuario"
        '
        'TxtCodigoempleado
        '
        Me.TxtCodigoempleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodigoempleado.Enabled = False
        Me.TxtCodigoempleado.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtCodigoempleado.Location = New System.Drawing.Point(955, 199)
        Me.TxtCodigoempleado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCodigoempleado.Name = "TxtCodigoempleado"
        Me.TxtCodigoempleado.Size = New System.Drawing.Size(161, 25)
        Me.TxtCodigoempleado.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(737, 199)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 24)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Código del empleado"
        '
        'lbNombreEmpleado
        '
        Me.lbNombreEmpleado.AutoSize = True
        Me.lbNombreEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.lbNombreEmpleado.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbNombreEmpleado.Location = New System.Drawing.Point(705, 231)
        Me.lbNombreEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNombreEmpleado.Name = "lbNombreEmpleado"
        Me.lbNombreEmpleado.Size = New System.Drawing.Size(199, 24)
        Me.lbNombreEmpleado.TabIndex = 93
        Me.lbNombreEmpleado.Text = "Nombre del empleado"
        '
        'txtNombreempleado
        '
        Me.txtNombreempleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreempleado.Enabled = False
        Me.txtNombreempleado.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.txtNombreempleado.Location = New System.Drawing.Point(955, 231)
        Me.txtNombreempleado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombreempleado.MaxLength = 20
        Me.txtNombreempleado.Name = "txtNombreempleado"
        Me.txtNombreempleado.Size = New System.Drawing.Size(252, 25)
        Me.txtNombreempleado.TabIndex = 92
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Candara", 19.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(16, 11)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 39)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Usuarios"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLimpiar.Location = New System.Drawing.Point(1021, 306)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(165, 48)
        Me.BtnLimpiar.TabIndex = 101
        Me.BtnLimpiar.Text = "Limpiar datos"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.LbContador7)
        Me.GroupBox1.Controls.Add(Me.LbContador6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtBusqueda)
        Me.GroupBox1.Controls.Add(Me.DgvUsuarios)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnActualizar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(144, 362)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1101, 410)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda del usuario"
        '
        'LbContador7
        '
        Me.LbContador7.AutoSize = True
        Me.LbContador7.BackColor = System.Drawing.Color.Transparent
        Me.LbContador7.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador7.ForeColor = System.Drawing.Color.Black
        Me.LbContador7.Location = New System.Drawing.Point(612, 52)
        Me.LbContador7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbContador7.Name = "LbContador7"
        Me.LbContador7.Size = New System.Drawing.Size(36, 24)
        Me.LbContador7.TabIndex = 81
        Me.LbContador7.Text = "/20"
        '
        'LbContador6
        '
        Me.LbContador6.AutoSize = True
        Me.LbContador6.BackColor = System.Drawing.Color.Transparent
        Me.LbContador6.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador6.ForeColor = System.Drawing.Color.Black
        Me.LbContador6.Location = New System.Drawing.Point(583, 50)
        Me.LbContador6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbContador6.Name = "LbContador6"
        Me.LbContador6.Size = New System.Drawing.Size(21, 24)
        Me.LbContador6.TabIndex = 80
        Me.LbContador6.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 47)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(287, 24)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Escriba el nombre del empleado:"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBusqueda.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtBusqueda.Location = New System.Drawing.Point(321, 49)
        Me.TxtBusqueda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBusqueda.MaxLength = 20
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(252, 25)
        Me.TxtBusqueda.TabIndex = 72
        '
        'DgvUsuarios
        '
        Me.DgvUsuarios.AllowUserToAddRows = False
        Me.DgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.DgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvUsuarios.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvUsuarios.EnableHeadersVisualStyles = False
        Me.DgvUsuarios.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DgvUsuarios.Location = New System.Drawing.Point(16, 94)
        Me.DgvUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DgvUsuarios.Name = "DgvUsuarios"
        Me.DgvUsuarios.ReadOnly = True
        Me.DgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvUsuarios.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DgvUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvUsuarios.Size = New System.Drawing.Size(1069, 222)
        Me.DgvUsuarios.TabIndex = 71
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(893, 346)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(116, 48)
        Me.BtnEliminar.TabIndex = 24
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(480, 346)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(116, 48)
        Me.BtnActualizar.TabIndex = 23
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(37, 346)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(116, 48)
        Me.BtnGuardar.TabIndex = 22
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'btnLimpiarEmple
        '
        Me.btnLimpiarEmple.BackgroundImage = CType(resources.GetObject("btnLimpiarEmple.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpiarEmple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLimpiarEmple.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiarEmple.Location = New System.Drawing.Point(1216, 180)
        Me.btnLimpiarEmple.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLimpiarEmple.Name = "btnLimpiarEmple"
        Me.btnLimpiarEmple.Size = New System.Drawing.Size(43, 38)
        Me.btnLimpiarEmple.TabIndex = 99
        Me.btnLimpiarEmple.UseVisualStyleBackColor = True
        '
        'btnAgg_E
        '
        Me.btnAgg_E.BackColor = System.Drawing.Color.Silver
        Me.btnAgg_E.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgg_E.Image = CType(resources.GetObject("btnAgg_E.Image"), System.Drawing.Image)
        Me.btnAgg_E.Location = New System.Drawing.Point(1216, 225)
        Me.btnAgg_E.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgg_E.Name = "btnAgg_E"
        Me.btnAgg_E.Size = New System.Drawing.Size(43, 34)
        Me.btnAgg_E.TabIndex = 98
        Me.btnAgg_E.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BazarRoxana.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(932, 26)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(327, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 94
        Me.PictureBox1.TabStop = False
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1404, 838)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLimpiarEmple)
        Me.Controls.Add(Me.btnAgg_E)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbNombreEmpleado)
        Me.Controls.Add(Me.txtNombreempleado)
        Me.Controls.Add(Me.TxtCodigoempleado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCodigousuario)
        Me.Controls.Add(Me.lbCodigoUsuario)
        Me.Controls.Add(Me.LbContador5)
        Me.Controls.Add(Me.LbContador4)
        Me.Controls.Add(Me.LbContador3)
        Me.Controls.Add(Me.LbContador2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.ChkMostrarcontra)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtContraseña)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmUsuario"
        Me.Text = "FrmUsuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbContador5 As Label
    Friend WithEvents LbContador4 As Label
    Friend WithEvents LbContador3 As Label
    Friend WithEvents LbContador2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents ChkMostrarcontra As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents TxtCodigousuario As TextBox
    Friend WithEvents lbCodigoUsuario As Label
    Friend WithEvents TxtCodigoempleado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbNombreEmpleado As Label
    Friend WithEvents txtNombreempleado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLimpiarEmple As Button
    Friend WithEvents btnAgg_E As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LbContador7 As Label
    Friend WithEvents LbContador6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents DgvUsuarios As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnGuardar As Button
End Class
