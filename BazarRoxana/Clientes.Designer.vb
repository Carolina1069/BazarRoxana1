<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.lbNombreCli = New System.Windows.Forms.Label()
        Me.txCodCli = New System.Windows.Forms.TextBox()
        Me.lbCodigoCli = New System.Windows.Forms.Label()
        Me.lbTelCli = New System.Windows.Forms.Label()
        Me.lbCorreo = New System.Windows.Forms.Label()
        Me.lbDirCli = New System.Windows.Forms.Label()
        Me.txNomCli = New System.Windows.Forms.TextBox()
        Me.txCorreoCli = New System.Windows.Forms.TextBox()
        Me.txTelCli = New System.Windows.Forms.TextBox()
        Me.rtxDirCli = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.DGVCliente = New System.Windows.Forms.DataGridView()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btActualizarTabla = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbNombreCli
        '
        Me.lbNombreCli.AutoSize = True
        Me.lbNombreCli.Location = New System.Drawing.Point(335, 122)
        Me.lbNombreCli.Name = "lbNombreCli"
        Me.lbNombreCli.Size = New System.Drawing.Size(96, 13)
        Me.lbNombreCli.TabIndex = 0
        Me.lbNombreCli.Text = "Nombre del Cliente"
        '
        'txCodCli
        '
        Me.txCodCli.Location = New System.Drawing.Point(131, 115)
        Me.txCodCli.Name = "txCodCli"
        Me.txCodCli.Size = New System.Drawing.Size(100, 20)
        Me.txCodCli.TabIndex = 1
        '
        'lbCodigoCli
        '
        Me.lbCodigoCli.AutoSize = True
        Me.lbCodigoCli.Location = New System.Drawing.Point(29, 122)
        Me.lbCodigoCli.Name = "lbCodigoCli"
        Me.lbCodigoCli.Size = New System.Drawing.Size(92, 13)
        Me.lbCodigoCli.TabIndex = 2
        Me.lbCodigoCli.Text = "Codigo del Cliente"
        '
        'lbTelCli
        '
        Me.lbTelCli.AutoSize = True
        Me.lbTelCli.Location = New System.Drawing.Point(29, 162)
        Me.lbTelCli.Name = "lbTelCli"
        Me.lbTelCli.Size = New System.Drawing.Size(49, 13)
        Me.lbTelCli.TabIndex = 4
        Me.lbTelCli.Text = "Telefono"
        '
        'lbCorreo
        '
        Me.lbCorreo.AutoSize = True
        Me.lbCorreo.Location = New System.Drawing.Point(359, 162)
        Me.lbCorreo.Name = "lbCorreo"
        Me.lbCorreo.Size = New System.Drawing.Size(38, 13)
        Me.lbCorreo.TabIndex = 3
        Me.lbCorreo.Text = "Correo"
        '
        'lbDirCli
        '
        Me.lbDirCli.AutoSize = True
        Me.lbDirCli.Location = New System.Drawing.Point(29, 212)
        Me.lbDirCli.Name = "lbDirCli"
        Me.lbDirCli.Size = New System.Drawing.Size(104, 13)
        Me.lbDirCli.TabIndex = 5
        Me.lbDirCli.Text = "Dirección del Cliente"
        '
        'txNomCli
        '
        Me.txNomCli.Location = New System.Drawing.Point(443, 118)
        Me.txNomCli.Name = "txNomCli"
        Me.txNomCli.Size = New System.Drawing.Size(100, 20)
        Me.txNomCli.TabIndex = 6
        '
        'txCorreoCli
        '
        Me.txCorreoCli.Location = New System.Drawing.Point(443, 162)
        Me.txCorreoCli.Name = "txCorreoCli"
        Me.txCorreoCli.Size = New System.Drawing.Size(100, 20)
        Me.txCorreoCli.TabIndex = 8
        '
        'txTelCli
        '
        Me.txTelCli.Location = New System.Drawing.Point(131, 159)
        Me.txTelCli.Name = "txTelCli"
        Me.txTelCli.Size = New System.Drawing.Size(100, 20)
        Me.txTelCli.TabIndex = 7
        '
        'rtxDirCli
        '
        Me.rtxDirCli.Location = New System.Drawing.Point(139, 212)
        Me.rtxDirCli.Name = "rtxDirCli"
        Me.rtxDirCli.Size = New System.Drawing.Size(170, 39)
        Me.rtxDirCli.TabIndex = 18
        Me.rtxDirCli.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(242, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 51)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(31, 35)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btBuscar.TabIndex = 18
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'DGVCliente
        '
        Me.DGVCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCliente.Location = New System.Drawing.Point(12, 74)
        Me.DGVCliente.Name = "DGVCliente"
        Me.DGVCliente.RowHeadersWidth = 51
        Me.DGVCliente.Size = New System.Drawing.Size(511, 150)
        Me.DGVCliente.TabIndex = 21
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(31, 244)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btGuardar.TabIndex = 22
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(174, 244)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btActualizar.TabIndex = 23
        Me.btActualizar.Text = "Actualizar"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'btActualizarTabla
        '
        Me.btActualizarTabla.Location = New System.Drawing.Point(411, 35)
        Me.btActualizarTabla.Name = "btActualizarTabla"
        Me.btActualizarTabla.Size = New System.Drawing.Size(94, 23)
        Me.btActualizarTabla.TabIndex = 23
        Me.btActualizarTabla.Text = "Actualizar Tabla"
        Me.btActualizarTabla.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(318, 244)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btEliminar.TabIndex = 24
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(448, 244)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(75, 23)
        Me.btSalir.TabIndex = 25
        Me.btSalir.Text = "Salir"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btSalir)
        Me.GroupBox1.Controls.Add(Me.btEliminar)
        Me.GroupBox1.Controls.Add(Me.btActualizarTabla)
        Me.GroupBox1.Controls.Add(Me.btActualizar)
        Me.GroupBox1.Controls.Add(Me.btGuardar)
        Me.GroupBox1.Controls.Add(Me.DGVCliente)
        Me.GroupBox1.Controls.Add(Me.btBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 280)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 275)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda del Cliente"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 570)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rtxDirCli)
        Me.Controls.Add(Me.txCorreoCli)
        Me.Controls.Add(Me.txTelCli)
        Me.Controls.Add(Me.txNomCli)
        Me.Controls.Add(Me.lbDirCli)
        Me.Controls.Add(Me.lbTelCli)
        Me.Controls.Add(Me.lbCorreo)
        Me.Controls.Add(Me.lbCodigoCli)
        Me.Controls.Add(Me.txCodCli)
        Me.Controls.Add(Me.lbNombreCli)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbNombreCli As Label
    Friend WithEvents txCodCli As TextBox
    Friend WithEvents lbCodigoCli As Label
    Friend WithEvents lbTelCli As Label
    Friend WithEvents lbCorreo As Label
    Friend WithEvents lbDirCli As Label
    Friend WithEvents txNomCli As TextBox
    Friend WithEvents txCorreoCli As TextBox
    Friend WithEvents txTelCli As TextBox
    Friend WithEvents rtxDirCli As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btBuscar As Button
    Friend WithEvents DGVCliente As DataGridView
    Friend WithEvents btGuardar As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents btActualizarTabla As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btSalir As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
