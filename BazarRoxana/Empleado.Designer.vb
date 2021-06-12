<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleado
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
        Me.chkInhabil = New System.Windows.Forms.CheckBox()
        Me.btnActTabla = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TxtCodigoEmpleado = New System.Windows.Forms.TextBox()
        Me.lbNivel = New System.Windows.Forms.Label()
        Me.lbNombreEmpleado = New System.Windows.Forms.Label()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.lbCodigoEmpleado = New System.Windows.Forms.Label()
        Me.CbxNivel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.chkMostrarContra = New System.Windows.Forms.CheckBox()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.LbContador = New System.Windows.Forms.Label()
        Me.LlContador1 = New System.Windows.Forms.Label()
        Me.LbContador3 = New System.Windows.Forms.Label()
        Me.LbContador2 = New System.Windows.Forms.Label()
        Me.LbContador5 = New System.Windows.Forms.Label()
        Me.LbContador4 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LbContador7 = New System.Windows.Forms.Label()
        Me.LbContador6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.LbContador7)
        Me.GroupBox1.Controls.Add(Me.LbContador6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtBusqueda)
        Me.GroupBox1.Controls.Add(Me.DGV)
        Me.GroupBox1.Controls.Add(Me.chkInhabil)
        Me.GroupBox1.Controls.Add(Me.btnActTabla)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 284)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(826, 333)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda del empleado"
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
        'btnActTabla
        '
        Me.btnActTabla.Location = New System.Drawing.Point(658, 29)
        Me.btnActTabla.Name = "btnActTabla"
        Me.btnActTabla.Size = New System.Drawing.Size(124, 39)
        Me.btnActTabla.TabIndex = 27
        Me.btnActTabla.Text = "Refrescar tabla"
        Me.btnActTabla.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(670, 281)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 39)
        Me.btnEliminar.TabIndex = 24
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(360, 281)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(87, 39)
        Me.btnActualizar.TabIndex = 23
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(28, 281)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(87, 39)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'TxtCodigoEmpleado
        '
        Me.TxtCodigoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodigoEmpleado.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtCodigoEmpleado.Location = New System.Drawing.Point(246, 133)
        Me.TxtCodigoEmpleado.Name = "TxtCodigoEmpleado"
        Me.TxtCodigoEmpleado.Size = New System.Drawing.Size(121, 20)
        Me.TxtCodigoEmpleado.TabIndex = 37
        '
        'lbNivel
        '
        Me.lbNivel.AutoSize = True
        Me.lbNivel.BackColor = System.Drawing.Color.Transparent
        Me.lbNivel.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbNivel.Location = New System.Drawing.Point(83, 172)
        Me.lbNivel.Name = "lbNivel"
        Me.lbNivel.Size = New System.Drawing.Size(139, 19)
        Me.lbNivel.TabIndex = 36
        Me.lbNivel.Text = "Nivel del empleado"
        '
        'lbNombreEmpleado
        '
        Me.lbNombreEmpleado.AutoSize = True
        Me.lbNombreEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.lbNombreEmpleado.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbNombreEmpleado.Location = New System.Drawing.Point(457, 133)
        Me.lbNombreEmpleado.Name = "lbNombreEmpleado"
        Me.lbNombreEmpleado.Size = New System.Drawing.Size(160, 19)
        Me.lbNombreEmpleado.TabIndex = 35
        Me.lbNombreEmpleado.Text = "Nombre del empleado"
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreEmpleado.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(644, 133)
        Me.txtNombreEmpleado.MaxLength = 20
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(189, 20)
        Me.txtNombreEmpleado.TabIndex = 34
        '
        'lbCodigoEmpleado
        '
        Me.lbCodigoEmpleado.AutoSize = True
        Me.lbCodigoEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.lbCodigoEmpleado.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbCodigoEmpleado.Location = New System.Drawing.Point(83, 133)
        Me.lbCodigoEmpleado.Name = "lbCodigoEmpleado"
        Me.lbCodigoEmpleado.Size = New System.Drawing.Size(153, 19)
        Me.lbCodigoEmpleado.TabIndex = 33
        Me.lbCodigoEmpleado.Text = "Código del empleado"
        '
        'CbxNivel
        '
        Me.CbxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxNivel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CbxNivel.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.CbxNivel.FormattingEnabled = True
        Me.CbxNivel.Items.AddRange(New Object() {"Gerente", "General"})
        Me.CbxNivel.Location = New System.Drawing.Point(246, 171)
        Me.CbxNivel.Name = "CbxNivel"
        Me.CbxNivel.Size = New System.Drawing.Size(121, 27)
        Me.CbxNivel.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(454, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 19)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Contraseña del empleado"
        '
        'TxtContraseña
        '
        Me.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtContraseña.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtContraseña.Location = New System.Drawing.Point(644, 185)
        Me.TxtContraseña.MaxLength = 25
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(189, 20)
        Me.TxtContraseña.TabIndex = 42
        Me.TxtContraseña.UseSystemPasswordChar = True
        '
        'chkMostrarContra
        '
        Me.chkMostrarContra.AutoSize = True
        Me.chkMostrarContra.BackColor = System.Drawing.Color.Transparent
        Me.chkMostrarContra.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chkMostrarContra.Location = New System.Drawing.Point(644, 210)
        Me.chkMostrarContra.Margin = New System.Windows.Forms.Padding(2)
        Me.chkMostrarContra.Name = "chkMostrarContra"
        Me.chkMostrarContra.Size = New System.Drawing.Size(158, 23)
        Me.chkMostrarContra.TabIndex = 44
        Me.chkMostrarContra.Text = "Mostrar contaseña"
        Me.chkMostrarContra.UseVisualStyleBackColor = False
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.BackColor = System.Drawing.Color.Transparent
        Me.chkEstado.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chkEstado.Location = New System.Drawing.Point(246, 210)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(186, 23)
        Me.chkEstado.TabIndex = 67
        Me.chkEstado.Text = "Habilitado/Inhabilitado"
        Me.chkEstado.UseVisualStyleBackColor = False
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Candara", 19.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 32)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Empleados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(458, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 19)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Usuario del empleado"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUsuario.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtUsuario.Location = New System.Drawing.Point(644, 159)
        Me.TxtUsuario.MaxLength = 20
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(189, 20)
        Me.TxtUsuario.TabIndex = 70
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.EnableHeadersVisualStyles = False
        Me.DGV.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGV.Location = New System.Drawing.Point(12, 76)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DGV.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(802, 180)
        Me.DGV.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 19)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Estado del empleado"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLimpiar.Location = New System.Drawing.Point(709, 239)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(124, 39)
        Me.BtnLimpiar.TabIndex = 72
        Me.BtnLimpiar.Text = "Limpiar datos"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'LbContador
        '
        Me.LbContador.AutoSize = True
        Me.LbContador.BackColor = System.Drawing.Color.Transparent
        Me.LbContador.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador.ForeColor = System.Drawing.Color.Black
        Me.LbContador.Location = New System.Drawing.Point(841, 136)
        Me.LbContador.Name = "LbContador"
        Me.LbContador.Size = New System.Drawing.Size(18, 19)
        Me.LbContador.TabIndex = 73
        Me.LbContador.Text = "0"
        '
        'LlContador1
        '
        Me.LlContador1.AutoSize = True
        Me.LlContador1.BackColor = System.Drawing.Color.Transparent
        Me.LlContador1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LlContador1.ForeColor = System.Drawing.Color.Black
        Me.LlContador1.Location = New System.Drawing.Point(863, 137)
        Me.LlContador1.Name = "LlContador1"
        Me.LlContador1.Size = New System.Drawing.Size(30, 19)
        Me.LlContador1.TabIndex = 74
        Me.LlContador1.Text = "/20"
        '
        'LbContador3
        '
        Me.LbContador3.AutoSize = True
        Me.LbContador3.BackColor = System.Drawing.Color.Transparent
        Me.LbContador3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador3.ForeColor = System.Drawing.Color.Black
        Me.LbContador3.Location = New System.Drawing.Point(863, 160)
        Me.LbContador3.Name = "LbContador3"
        Me.LbContador3.Size = New System.Drawing.Size(30, 19)
        Me.LbContador3.TabIndex = 76
        Me.LbContador3.Text = "/20"
        '
        'LbContador2
        '
        Me.LbContador2.AutoSize = True
        Me.LbContador2.BackColor = System.Drawing.Color.Transparent
        Me.LbContador2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador2.ForeColor = System.Drawing.Color.Black
        Me.LbContador2.Location = New System.Drawing.Point(841, 159)
        Me.LbContador2.Name = "LbContador2"
        Me.LbContador2.Size = New System.Drawing.Size(18, 19)
        Me.LbContador2.TabIndex = 75
        Me.LbContador2.Text = "0"
        '
        'LbContador5
        '
        Me.LbContador5.AutoSize = True
        Me.LbContador5.BackColor = System.Drawing.Color.Transparent
        Me.LbContador5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador5.ForeColor = System.Drawing.Color.Black
        Me.LbContador5.Location = New System.Drawing.Point(863, 185)
        Me.LbContador5.Name = "LbContador5"
        Me.LbContador5.Size = New System.Drawing.Size(29, 19)
        Me.LbContador5.TabIndex = 78
        Me.LbContador5.Text = "/25"
        '
        'LbContador4
        '
        Me.LbContador4.AutoSize = True
        Me.LbContador4.BackColor = System.Drawing.Color.Transparent
        Me.LbContador4.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador4.ForeColor = System.Drawing.Color.Black
        Me.LbContador4.Location = New System.Drawing.Point(841, 184)
        Me.LbContador4.Name = "LbContador4"
        Me.LbContador4.Size = New System.Drawing.Size(18, 19)
        Me.LbContador4.TabIndex = 77
        Me.LbContador4.Text = "0"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 19)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Escriba el nombre del empleado:"
        '
        'LbContador7
        '
        Me.LbContador7.AutoSize = True
        Me.LbContador7.BackColor = System.Drawing.Color.Transparent
        Me.LbContador7.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador7.ForeColor = System.Drawing.Color.Black
        Me.LbContador7.Location = New System.Drawing.Point(459, 42)
        Me.LbContador7.Name = "LbContador7"
        Me.LbContador7.Size = New System.Drawing.Size(30, 19)
        Me.LbContador7.TabIndex = 81
        Me.LbContador7.Text = "/20"
        '
        'LbContador6
        '
        Me.LbContador6.AutoSize = True
        Me.LbContador6.BackColor = System.Drawing.Color.Transparent
        Me.LbContador6.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador6.ForeColor = System.Drawing.Color.Black
        Me.LbContador6.Location = New System.Drawing.Point(437, 41)
        Me.LbContador6.Name = "LbContador6"
        Me.LbContador6.Size = New System.Drawing.Size(18, 19)
        Me.LbContador6.TabIndex = 80
        Me.LbContador6.Text = "0"
        '
        'Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(934, 650)
        Me.Controls.Add(Me.LbContador5)
        Me.Controls.Add(Me.LbContador4)
        Me.Controls.Add(Me.LbContador3)
        Me.Controls.Add(Me.LbContador2)
        Me.Controls.Add(Me.LlContador1)
        Me.Controls.Add(Me.LbContador)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.chkMostrarContra)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.CbxNivel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtCodigoEmpleado)
        Me.Controls.Add(Me.lbNivel)
        Me.Controls.Add(Me.lbNombreEmpleado)
        Me.Controls.Add(Me.txtNombreEmpleado)
        Me.Controls.Add(Me.lbCodigoEmpleado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Empleado"
        Me.Text = "Empleado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents TxtCodigoEmpleado As TextBox
    Friend WithEvents lbNivel As Label
    Friend WithEvents lbNombreEmpleado As Label
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents lbCodigoEmpleado As Label
    Friend WithEvents CbxNivel As ComboBox
    Friend WithEvents btnActTabla As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents chkMostrarContra As CheckBox
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents chkInhabil As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents LbContador As Label
    Friend WithEvents LlContador1 As Label
    Friend WithEvents LbContador3 As Label
    Friend WithEvents LbContador2 As Label
    Friend WithEvents LbContador5 As Label
    Friend WithEvents LbContador4 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LbContador7 As Label
    Friend WithEvents LbContador6 As Label
End Class
