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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtbuscarempleado = New System.Windows.Forms.TextBox()
        Me.lbBusquedaEmpleado = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.TxtCodigoEmpleado = New System.Windows.Forms.TextBox()
        Me.lbNivel = New System.Windows.Forms.Label()
        Me.lbNombreEmpleado = New System.Windows.Forms.Label()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.lbCodigoEmpleado = New System.Windows.Forms.Label()
        Me.CbxNivel = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(233, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 51)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.txtbuscarempleado)
        Me.GroupBox1.Controls.Add(Me.lbBusquedaEmpleado)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 205)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 337)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda del empleado"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(445, 273)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 25
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(315, 273)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 24
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(171, 273)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 23
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(28, 273)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(511, 150)
        Me.DataGridView1.TabIndex = 21
        '
        'txtbuscarempleado
        '
        Me.txtbuscarempleado.Location = New System.Drawing.Point(174, 27)
        Me.txtbuscarempleado.Name = "txtbuscarempleado"
        Me.txtbuscarempleado.Size = New System.Drawing.Size(206, 20)
        Me.txtbuscarempleado.TabIndex = 20
        '
        'lbBusquedaEmpleado
        '
        Me.lbBusquedaEmpleado.AutoSize = True
        Me.lbBusquedaEmpleado.Location = New System.Drawing.Point(6, 29)
        Me.lbBusquedaEmpleado.Name = "lbBusquedaEmpleado"
        Me.lbBusquedaEmpleado.Size = New System.Drawing.Size(159, 13)
        Me.lbBusquedaEmpleado.TabIndex = 19
        Me.lbBusquedaEmpleado.Text = "Escriba el Numero del empleado"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(411, 24)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 18
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'TxtCodigoEmpleado
        '
        Me.TxtCodigoEmpleado.Location = New System.Drawing.Point(122, 97)
        Me.TxtCodigoEmpleado.Name = "TxtCodigoEmpleado"
        Me.TxtCodigoEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodigoEmpleado.TabIndex = 37
        '
        'lbNivel
        '
        Me.lbNivel.AutoSize = True
        Me.lbNivel.Location = New System.Drawing.Point(20, 155)
        Me.lbNivel.Name = "lbNivel"
        Me.lbNivel.Size = New System.Drawing.Size(98, 13)
        Me.lbNivel.TabIndex = 36
        Me.lbNivel.Text = "Nivel del Empleado"
        '
        'lbNombreEmpleado
        '
        Me.lbNombreEmpleado.AutoSize = True
        Me.lbNombreEmpleado.Location = New System.Drawing.Point(324, 97)
        Me.lbNombreEmpleado.Name = "lbNombreEmpleado"
        Me.lbNombreEmpleado.Size = New System.Drawing.Size(113, 13)
        Me.lbNombreEmpleado.TabIndex = 35
        Me.lbNombreEmpleado.Text = "Nombre Del Empleado"
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(443, 90)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreEmpleado.TabIndex = 34
        '
        'lbCodigoEmpleado
        '
        Me.lbCodigoEmpleado.AutoSize = True
        Me.lbCodigoEmpleado.Location = New System.Drawing.Point(14, 101)
        Me.lbCodigoEmpleado.Name = "lbCodigoEmpleado"
        Me.lbCodigoEmpleado.Size = New System.Drawing.Size(90, 13)
        Me.lbCodigoEmpleado.TabIndex = 33
        Me.lbCodigoEmpleado.Text = "Codigo Empleado"
        '
        'CbxNivel
        '
        Me.CbxNivel.FormattingEnabled = True
        Me.CbxNivel.Location = New System.Drawing.Point(124, 155)
        Me.CbxNivel.Name = "CbxNivel"
        Me.CbxNivel.Size = New System.Drawing.Size(121, 21)
        Me.CbxNivel.TabIndex = 41
        '
        'Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 554)
        Me.Controls.Add(Me.CbxNivel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtCodigoEmpleado)
        Me.Controls.Add(Me.lbNivel)
        Me.Controls.Add(Me.lbNombreEmpleado)
        Me.Controls.Add(Me.txtNombreEmpleado)
        Me.Controls.Add(Me.lbCodigoEmpleado)
        Me.Name = "Empleado"
        Me.Text = "Empleado"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtbuscarempleado As TextBox
    Friend WithEvents lbBusquedaEmpleado As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents TxtCodigoEmpleado As TextBox
    Friend WithEvents lbNivel As Label
    Friend WithEvents lbNombreEmpleado As Label
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents lbCodigoEmpleado As Label
    Friend WithEvents CbxNivel As ComboBox
End Class
