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
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.DGVCliente = New System.Windows.Forms.DataGridView()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btActualizarTabla = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkInhabil = New System.Windows.Forms.CheckBox()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbNombreCli
        '
        Me.lbNombreCli.AutoSize = True
        Me.lbNombreCli.BackColor = System.Drawing.Color.Transparent
        Me.lbNombreCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombreCli.Location = New System.Drawing.Point(363, 146)
        Me.lbNombreCli.Name = "lbNombreCli"
        Me.lbNombreCli.Size = New System.Drawing.Size(75, 26)
        Me.lbNombreCli.TabIndex = 0
        Me.lbNombreCli.Text = "Nombre del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cliente"
        '
        'txCodCli
        '
        Me.txCodCli.Location = New System.Drawing.Point(159, 139)
        Me.txCodCli.Name = "txCodCli"
        Me.txCodCli.Size = New System.Drawing.Size(100, 20)
        Me.txCodCli.TabIndex = 1
        '
        'lbCodigoCli
        '
        Me.lbCodigoCli.AutoSize = True
        Me.lbCodigoCli.BackColor = System.Drawing.Color.Transparent
        Me.lbCodigoCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodigoCli.Location = New System.Drawing.Point(75, 139)
        Me.lbCodigoCli.Name = "lbCodigoCli"
        Me.lbCodigoCli.Size = New System.Drawing.Size(67, 26)
        Me.lbCodigoCli.TabIndex = 2
        Me.lbCodigoCli.Text = "Codigo del" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cliente"
        '
        'lbTelCli
        '
        Me.lbTelCli.AutoSize = True
        Me.lbTelCli.BackColor = System.Drawing.Color.Transparent
        Me.lbTelCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTelCli.Location = New System.Drawing.Point(75, 179)
        Me.lbTelCli.Name = "lbTelCli"
        Me.lbTelCli.Size = New System.Drawing.Size(57, 13)
        Me.lbTelCli.TabIndex = 4
        Me.lbTelCli.Text = "Telefono"
        '
        'lbCorreo
        '
        Me.lbCorreo.AutoSize = True
        Me.lbCorreo.BackColor = System.Drawing.Color.Transparent
        Me.lbCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCorreo.Location = New System.Drawing.Point(387, 186)
        Me.lbCorreo.Name = "lbCorreo"
        Me.lbCorreo.Size = New System.Drawing.Size(44, 13)
        Me.lbCorreo.TabIndex = 3
        Me.lbCorreo.Text = "Correo"
        '
        'lbDirCli
        '
        Me.lbDirCli.AutoSize = True
        Me.lbDirCli.BackColor = System.Drawing.Color.Transparent
        Me.lbDirCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDirCli.Location = New System.Drawing.Point(69, 236)
        Me.lbDirCli.Name = "lbDirCli"
        Me.lbDirCli.Size = New System.Drawing.Size(86, 26)
        Me.lbDirCli.TabIndex = 5
        Me.lbDirCli.Text = "Dirección del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cliente"
        '
        'txNomCli
        '
        Me.txNomCli.Location = New System.Drawing.Point(444, 143)
        Me.txNomCli.Name = "txNomCli"
        Me.txNomCli.Size = New System.Drawing.Size(100, 20)
        Me.txNomCli.TabIndex = 6
        '
        'txCorreoCli
        '
        Me.txCorreoCli.Location = New System.Drawing.Point(444, 186)
        Me.txCorreoCli.Name = "txCorreoCli"
        Me.txCorreoCli.Size = New System.Drawing.Size(100, 20)
        Me.txCorreoCli.TabIndex = 8
        '
        'txTelCli
        '
        Me.txTelCli.Location = New System.Drawing.Point(159, 183)
        Me.txTelCli.Name = "txTelCli"
        Me.txTelCli.Size = New System.Drawing.Size(100, 20)
        Me.txTelCli.TabIndex = 7
        '
        'rtxDirCli
        '
        Me.rtxDirCli.Location = New System.Drawing.Point(159, 236)
        Me.rtxDirCli.Name = "rtxDirCli"
        Me.rtxDirCli.Size = New System.Drawing.Size(170, 39)
        Me.rtxDirCli.TabIndex = 18
        Me.rtxDirCli.Text = ""
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
        Me.btGuardar.Location = New System.Drawing.Point(6, 246)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btGuardar.TabIndex = 22
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(239, 246)
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
        Me.btEliminar.Location = New System.Drawing.Point(448, 246)
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
        Me.GroupBox1.Location = New System.Drawing.Point(60, 304)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 275)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda del Cliente"
        '
        'chkInhabil
        '
        Me.chkInhabil.AutoSize = True
        Me.chkInhabil.Location = New System.Drawing.Point(306, 39)
        Me.chkInhabil.Name = "chkInhabil"
        Me.chkInhabil.Size = New System.Drawing.Size(102, 17)
        Me.chkInhabil.TabIndex = 68
        Me.chkInhabil.Text = "Inhabilitados "
        Me.chkInhabil.UseVisualStyleBackColor = True
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.BackColor = System.Drawing.Color.Transparent
        Me.chkEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.Location = New System.Drawing.Point(444, 212)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(65, 17)
        Me.chkEstado.TabIndex = 67
        Me.chkEstado.Text = "Estado"
        Me.chkEstado.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BazarRoxana.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(409, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BazarRoxana.My.Resources.Resources.WhatsApp_Image_2021_04_08_at_10_15_57_PM
        Me.ClientSize = New System.Drawing.Size(666, 650)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chkEstado)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btBuscar As Button
    Friend WithEvents DGVCliente As DataGridView
    Friend WithEvents btGuardar As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents btActualizarTabla As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents chkInhabil As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
