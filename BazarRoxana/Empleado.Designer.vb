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
        Me.BtnHabilitar = New System.Windows.Forms.Button()
        Me.LbContador7 = New System.Windows.Forms.Label()
        Me.LbContador6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.DgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.chkInhabil = New System.Windows.Forms.CheckBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TxtCodigoempleado = New System.Windows.Forms.TextBox()
        Me.lbNivel = New System.Windows.Forms.Label()
        Me.lbNombreempleado = New System.Windows.Forms.Label()
        Me.txtNombreempleado = New System.Windows.Forms.TextBox()
        Me.lbCodigoempleado = New System.Windows.Forms.Label()
        Me.CbxNivel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.LbContador = New System.Windows.Forms.Label()
        Me.LlContador1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.BtnHabilitar)
        Me.GroupBox1.Controls.Add(Me.LbContador7)
        Me.GroupBox1.Controls.Add(Me.LbContador6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtBusqueda)
        Me.GroupBox1.Controls.Add(Me.DgvEmpleados)
        Me.GroupBox1.Controls.Add(Me.chkInhabil)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 294)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 333)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda del empleado"
        '
        'BtnHabilitar
        '
        Me.BtnHabilitar.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnHabilitar.Location = New System.Drawing.Point(858, 28)
        Me.BtnHabilitar.Name = "BtnHabilitar"
        Me.BtnHabilitar.Size = New System.Drawing.Size(127, 39)
        Me.BtnHabilitar.TabIndex = 95
        Me.BtnHabilitar.Text = "Habilitar cliente"
        Me.BtnHabilitar.UseVisualStyleBackColor = True
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
        'DgvEmpleados
        '
        Me.DgvEmpleados.AllowUserToAddRows = False
        Me.DgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEmpleados.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.DgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvEmpleados.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvEmpleados.EnableHeadersVisualStyles = False
        Me.DgvEmpleados.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DgvEmpleados.Location = New System.Drawing.Point(12, 76)
        Me.DgvEmpleados.Name = "DgvEmpleados"
        Me.DgvEmpleados.ReadOnly = True
        Me.DgvEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEmpleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvEmpleados.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DgvEmpleados.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEmpleados.Size = New System.Drawing.Size(973, 180)
        Me.DgvEmpleados.TabIndex = 71
        '
        'chkInhabil
        '
        Me.chkInhabil.AutoSize = True
        Me.chkInhabil.Location = New System.Drawing.Point(731, 37)
        Me.chkInhabil.Name = "chkInhabil"
        Me.chkInhabil.Size = New System.Drawing.Size(121, 23)
        Me.chkInhabil.TabIndex = 70
        Me.chkInhabil.Text = "Inhabilitados "
        Me.chkInhabil.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(898, 281)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 39)
        Me.btnEliminar.TabIndex = 24
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(500, 281)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(87, 39)
        Me.btnActualizar.TabIndex = 23
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(12, 281)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(87, 39)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'TxtCodigoempleado
        '
        Me.TxtCodigoempleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodigoempleado.Enabled = False
        Me.TxtCodigoempleado.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtCodigoempleado.Location = New System.Drawing.Point(197, 139)
        Me.TxtCodigoempleado.Name = "TxtCodigoempleado"
        Me.TxtCodigoempleado.Size = New System.Drawing.Size(121, 20)
        Me.TxtCodigoempleado.TabIndex = 37
        '
        'lbNivel
        '
        Me.lbNivel.AutoSize = True
        Me.lbNivel.BackColor = System.Drawing.Color.Transparent
        Me.lbNivel.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbNivel.Location = New System.Drawing.Point(34, 178)
        Me.lbNivel.Name = "lbNivel"
        Me.lbNivel.Size = New System.Drawing.Size(139, 19)
        Me.lbNivel.TabIndex = 36
        Me.lbNivel.Text = "Nivel del empleado"
        '
        'lbNombreempleado
        '
        Me.lbNombreempleado.AutoSize = True
        Me.lbNombreempleado.BackColor = System.Drawing.Color.Transparent
        Me.lbNombreempleado.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbNombreempleado.Location = New System.Drawing.Point(547, 133)
        Me.lbNombreempleado.Name = "lbNombreempleado"
        Me.lbNombreempleado.Size = New System.Drawing.Size(160, 19)
        Me.lbNombreempleado.TabIndex = 35
        Me.lbNombreempleado.Text = "Nombre del empleado"
        '
        'txtNombreempleado
        '
        Me.txtNombreempleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreempleado.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.txtNombreempleado.Location = New System.Drawing.Point(734, 133)
        Me.txtNombreempleado.MaxLength = 20
        Me.txtNombreempleado.Name = "txtNombreempleado"
        Me.txtNombreempleado.Size = New System.Drawing.Size(189, 20)
        Me.txtNombreempleado.TabIndex = 34
        '
        'lbCodigoempleado
        '
        Me.lbCodigoempleado.AutoSize = True
        Me.lbCodigoempleado.BackColor = System.Drawing.Color.Transparent
        Me.lbCodigoempleado.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbCodigoempleado.Location = New System.Drawing.Point(34, 139)
        Me.lbCodigoempleado.Name = "lbCodigoempleado"
        Me.lbCodigoempleado.Size = New System.Drawing.Size(153, 19)
        Me.lbCodigoempleado.TabIndex = 33
        Me.lbCodigoempleado.Text = "Código del empleado"
        '
        'CbxNivel
        '
        Me.CbxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxNivel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CbxNivel.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.CbxNivel.FormattingEnabled = True
        Me.CbxNivel.Items.AddRange(New Object() {"Administrador", "Gerente", "Vendedor"})
        Me.CbxNivel.Location = New System.Drawing.Point(197, 177)
        Me.CbxNivel.Name = "CbxNivel"
        Me.CbxNivel.Size = New System.Drawing.Size(121, 27)
        Me.CbxNivel.TabIndex = 41
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
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLimpiar.Location = New System.Drawing.Point(799, 239)
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
        Me.LbContador.Location = New System.Drawing.Point(931, 136)
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
        Me.LlContador1.Location = New System.Drawing.Point(953, 137)
        Me.LlContador1.Name = "LlContador1"
        Me.LlContador1.Size = New System.Drawing.Size(30, 19)
        Me.LlContador1.TabIndex = 74
        Me.LlContador1.Text = "/20"
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
        'Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.LlContador1)
        Me.Controls.Add(Me.LbContador)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CbxNivel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtCodigoempleado)
        Me.Controls.Add(Me.lbNivel)
        Me.Controls.Add(Me.lbNombreempleado)
        Me.Controls.Add(Me.txtNombreempleado)
        Me.Controls.Add(Me.lbCodigoempleado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Empleado"
        Me.Text = "Empleado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents TxtCodigoempleado As TextBox
    Friend WithEvents lbNivel As Label
    Friend WithEvents lbNombreempleado As Label
    Friend WithEvents txtNombreempleado As TextBox
    Friend WithEvents lbCodigoempleado As Label
    Friend WithEvents CbxNivel As ComboBox
    Friend WithEvents chkInhabil As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DgvEmpleados As DataGridView
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents LbContador As Label
    Friend WithEvents LlContador1 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LbContador7 As Label
    Friend WithEvents LbContador6 As Label
    Friend WithEvents BtnHabilitar As Button
End Class
