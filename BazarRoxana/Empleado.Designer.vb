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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnActTabla = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.TxtCodigoEmpleado = New System.Windows.Forms.TextBox()
        Me.lbNivel = New System.Windows.Forms.Label()
        Me.lbNombreEmpleado = New System.Windows.Forms.Label()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.lbCodigoEmpleado = New System.Windows.Forms.Label()
        Me.CbxNivel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.cbxMostrarContra = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(576, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 51)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnActTabla)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.DGV)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 250)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 304)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda del empleado"
        '
        'btnActTabla
        '
        Me.btnActTabla.Location = New System.Drawing.Point(415, 37)
        Me.btnActTabla.Name = "btnActTabla"
        Me.btnActTabla.Size = New System.Drawing.Size(108, 23)
        Me.btnActTabla.TabIndex = 27
        Me.btnActTabla.Text = "Actualizar Tabla"
        Me.btnActTabla.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(451, 273)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 24
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(236, 273)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 23
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(6, 273)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 74)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.Size = New System.Drawing.Size(511, 150)
        Me.DGV.TabIndex = 21
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(28, 37)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 18
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'TxtCodigoEmpleado
        '
        Me.TxtCodigoEmpleado.Location = New System.Drawing.Point(166, 142)
        Me.TxtCodigoEmpleado.Name = "TxtCodigoEmpleado"
        Me.TxtCodigoEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodigoEmpleado.TabIndex = 37
        '
        'lbNivel
        '
        Me.lbNivel.AutoSize = True
        Me.lbNivel.Location = New System.Drawing.Point(64, 200)
        Me.lbNivel.Name = "lbNivel"
        Me.lbNivel.Size = New System.Drawing.Size(98, 13)
        Me.lbNivel.TabIndex = 36
        Me.lbNivel.Text = "Nivel del Empleado"
        '
        'lbNombreEmpleado
        '
        Me.lbNombreEmpleado.AutoSize = True
        Me.lbNombreEmpleado.Location = New System.Drawing.Point(368, 142)
        Me.lbNombreEmpleado.Name = "lbNombreEmpleado"
        Me.lbNombreEmpleado.Size = New System.Drawing.Size(113, 13)
        Me.lbNombreEmpleado.TabIndex = 35
        Me.lbNombreEmpleado.Text = "Nombre Del Empleado"
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(487, 135)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreEmpleado.TabIndex = 34
        '
        'lbCodigoEmpleado
        '
        Me.lbCodigoEmpleado.AutoSize = True
        Me.lbCodigoEmpleado.Location = New System.Drawing.Point(64, 145)
        Me.lbCodigoEmpleado.Name = "lbCodigoEmpleado"
        Me.lbCodigoEmpleado.Size = New System.Drawing.Size(90, 13)
        Me.lbCodigoEmpleado.TabIndex = 33
        Me.lbCodigoEmpleado.Text = "Codigo Empleado"
        '
        'CbxNivel
        '
        Me.CbxNivel.FormattingEnabled = True
        Me.CbxNivel.Items.AddRange(New Object() {"Gerente", "General"})
        Me.CbxNivel.Location = New System.Drawing.Point(168, 200)
        Me.CbxNivel.Name = "CbxNivel"
        Me.CbxNivel.Size = New System.Drawing.Size(121, 21)
        Me.CbxNivel.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(351, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Contraseña Del Empleado"
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Location = New System.Drawing.Point(487, 175)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(100, 20)
        Me.TxtContraseña.TabIndex = 42
        Me.TxtContraseña.UseSystemPasswordChar = True
        '
        'cbxMostrarContra
        '
        Me.cbxMostrarContra.AutoSize = True
        Me.cbxMostrarContra.Location = New System.Drawing.Point(482, 204)
        Me.cbxMostrarContra.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxMostrarContra.Name = "cbxMostrarContra"
        Me.cbxMostrarContra.Size = New System.Drawing.Size(114, 17)
        Me.cbxMostrarContra.TabIndex = 44
        Me.cbxMostrarContra.Text = "Mostrar contaseña"
        Me.cbxMostrarContra.UseVisualStyleBackColor = True
        '
        'Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 650)
        Me.Controls.Add(Me.cbxMostrarContra)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.CbxNivel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtCodigoEmpleado)
        Me.Controls.Add(Me.lbNivel)
        Me.Controls.Add(Me.lbNombreEmpleado)
        Me.Controls.Add(Me.txtNombreEmpleado)
        Me.Controls.Add(Me.lbCodigoEmpleado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Empleado"
        Me.Text = "Empleado"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents TxtCodigoEmpleado As TextBox
    Friend WithEvents lbNivel As Label
    Friend WithEvents lbNombreEmpleado As Label
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents lbCodigoEmpleado As Label
    Friend WithEvents CbxNivel As ComboBox
    Friend WithEvents btnActTabla As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents cbxMostrarContra As CheckBox
End Class
