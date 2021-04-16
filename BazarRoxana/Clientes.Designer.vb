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
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.DGVCliente = New System.Windows.Forms.DataGridView()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btActualizarTabla = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkInhabil = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DGVCliente.Location = New System.Drawing.Point(20, 74)
        Me.DGVCliente.Name = "DGVCliente"
        Me.DGVCliente.RowHeadersWidth = 51
        Me.DGVCliente.Size = New System.Drawing.Size(783, 170)
        Me.DGVCliente.TabIndex = 21
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(11, 273)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btGuardar.TabIndex = 22
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(382, 273)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btActualizar.TabIndex = 23
        Me.btActualizar.Text = "Actualizar"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'btActualizarTabla
        '
        Me.btActualizarTabla.Location = New System.Drawing.Point(709, 35)
        Me.btActualizarTabla.Name = "btActualizarTabla"
        Me.btActualizarTabla.Size = New System.Drawing.Size(94, 23)
        Me.btActualizarTabla.TabIndex = 23
        Me.btActualizarTabla.Text = "Actualizar Tabla"
        Me.btActualizarTabla.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(709, 273)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btEliminar.TabIndex = 24
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.chkInhabil)
        Me.GroupBox1.Controls.Add(Me.btEliminar)
        Me.GroupBox1.Controls.Add(Me.btActualizarTabla)
        Me.GroupBox1.Controls.Add(Me.btActualizar)
        Me.GroupBox1.Controls.Add(Me.btGuardar)
        Me.GroupBox1.Controls.Add(Me.DGVCliente)
        Me.GroupBox1.Controls.Add(Me.btBuscar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(40, 304)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(835, 323)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda del Cliente"
        '
        'chkInhabil
        '
        Me.chkInhabil.AutoSize = True
        Me.chkInhabil.Location = New System.Drawing.Point(604, 39)
        Me.chkInhabil.Name = "chkInhabil"
        Me.chkInhabil.Size = New System.Drawing.Size(102, 17)
        Me.chkInhabil.TabIndex = 68
        Me.chkInhabil.Text = "Inhabilitados "
        Me.chkInhabil.UseVisualStyleBackColor = True
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
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
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
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(40, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(835, 183)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.BackColor = System.Drawing.Color.Transparent
        Me.chkEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.Location = New System.Drawing.Point(625, 122)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(65, 17)
        Me.chkEstado.TabIndex = 78
        Me.chkEstado.Text = "Estado"
        Me.chkEstado.UseVisualStyleBackColor = False
        '
        'rtxDirCli
        '
        Me.rtxDirCli.Location = New System.Drawing.Point(315, 117)
        Me.rtxDirCli.Name = "rtxDirCli"
        Me.rtxDirCli.Size = New System.Drawing.Size(174, 57)
        Me.rtxDirCli.TabIndex = 77
        Me.rtxDirCli.Text = ""
        '
        'txCorreoCli
        '
        Me.txCorreoCli.Location = New System.Drawing.Point(625, 72)
        Me.txCorreoCli.MaxLength = 50
        Me.txCorreoCli.Name = "txCorreoCli"
        Me.txCorreoCli.Size = New System.Drawing.Size(159, 20)
        Me.txCorreoCli.TabIndex = 76
        '
        'txTelCli
        '
        Me.txTelCli.Location = New System.Drawing.Point(315, 72)
        Me.txTelCli.MaxLength = 12
        Me.txTelCli.Name = "txTelCli"
        Me.txTelCli.Size = New System.Drawing.Size(100, 20)
        Me.txTelCli.TabIndex = 75
        '
        'txNomCli
        '
        Me.txNomCli.Location = New System.Drawing.Point(625, 21)
        Me.txNomCli.MaxLength = 50
        Me.txNomCli.Name = "txNomCli"
        Me.txNomCli.Size = New System.Drawing.Size(159, 20)
        Me.txNomCli.TabIndex = 74
        '
        'lbDirCli
        '
        Me.lbDirCli.AutoSize = True
        Me.lbDirCli.BackColor = System.Drawing.Color.Transparent
        Me.lbDirCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDirCli.Location = New System.Drawing.Point(163, 120)
        Me.lbDirCli.Name = "lbDirCli"
        Me.lbDirCli.Size = New System.Drawing.Size(125, 13)
        Me.lbDirCli.TabIndex = 73
        Me.lbDirCli.Text = "Dirección del Cliente"
        '
        'lbTelCli
        '
        Me.lbTelCli.AutoSize = True
        Me.lbTelCli.BackColor = System.Drawing.Color.Transparent
        Me.lbTelCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTelCli.Location = New System.Drawing.Point(231, 68)
        Me.lbTelCli.Name = "lbTelCli"
        Me.lbTelCli.Size = New System.Drawing.Size(57, 13)
        Me.lbTelCli.TabIndex = 72
        Me.lbTelCli.Text = "Telefono"
        '
        'lbCorreo
        '
        Me.lbCorreo.AutoSize = True
        Me.lbCorreo.BackColor = System.Drawing.Color.Transparent
        Me.lbCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCorreo.Location = New System.Drawing.Point(530, 75)
        Me.lbCorreo.Name = "lbCorreo"
        Me.lbCorreo.Size = New System.Drawing.Size(44, 13)
        Me.lbCorreo.TabIndex = 71
        Me.lbCorreo.Text = "Correo"
        '
        'lbCodigoCli
        '
        Me.lbCodigoCli.AutoSize = True
        Me.lbCodigoCli.BackColor = System.Drawing.Color.Transparent
        Me.lbCodigoCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodigoCli.Location = New System.Drawing.Point(187, 28)
        Me.lbCodigoCli.Name = "lbCodigoCli"
        Me.lbCodigoCli.Size = New System.Drawing.Size(110, 13)
        Me.lbCodigoCli.TabIndex = 70
        Me.lbCodigoCli.Text = "Codigo del Cliente"
        '
        'txCodCli
        '
        Me.txCodCli.Location = New System.Drawing.Point(315, 21)
        Me.txCodCli.Name = "txCodCli"
        Me.txCodCli.Size = New System.Drawing.Size(100, 20)
        Me.txCodCli.TabIndex = 69
        '
        'lbNombreCli
        '
        Me.lbNombreCli.AutoSize = True
        Me.lbNombreCli.BackColor = System.Drawing.Color.Transparent
        Me.lbNombreCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombreCli.Location = New System.Drawing.Point(504, 24)
        Me.lbNombreCli.Name = "lbNombreCli"
        Me.lbNombreCli.Size = New System.Drawing.Size(114, 13)
        Me.lbNombreCli.TabIndex = 68
        Me.lbNombreCli.Text = "Nombre del Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Clarendon BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 29)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Clientes"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BazarRoxana.My.Resources.Resources.A
        Me.ClientSize = New System.Drawing.Size(934, 650)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btBuscar As Button
    Friend WithEvents DGVCliente As DataGridView
    Friend WithEvents btGuardar As Button
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
    Friend WithEvents lbCodigoCli As Label
    Friend WithEvents txCodCli As TextBox
    Friend WithEvents lbNombreCli As Label
    Friend WithEvents Label1 As Label
End Class
