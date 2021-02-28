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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txbuscarCli = New System.Windows.Forms.TextBox()
        Me.lbBusquedacli = New System.Windows.Forms.Label()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbNombreCli
        '
        Me.lbNombreCli.AutoSize = True
        Me.lbNombreCli.Location = New System.Drawing.Point(447, 150)
        Me.lbNombreCli.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNombreCli.Name = "lbNombreCli"
        Me.lbNombreCli.Size = New System.Drawing.Size(128, 17)
        Me.lbNombreCli.TabIndex = 0
        Me.lbNombreCli.Text = "Nombre del Cliente"
        '
        'txCodCli
        '
        Me.txCodCli.Location = New System.Drawing.Point(175, 142)
        Me.txCodCli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txCodCli.Name = "txCodCli"
        Me.txCodCli.Size = New System.Drawing.Size(132, 22)
        Me.txCodCli.TabIndex = 1
        '
        'lbCodigoCli
        '
        Me.lbCodigoCli.AutoSize = True
        Me.lbCodigoCli.Location = New System.Drawing.Point(39, 150)
        Me.lbCodigoCli.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCodigoCli.Name = "lbCodigoCli"
        Me.lbCodigoCli.Size = New System.Drawing.Size(122, 17)
        Me.lbCodigoCli.TabIndex = 2
        Me.lbCodigoCli.Text = "Codigo del Cliente"
        '
        'lbTelCli
        '
        Me.lbTelCli.AutoSize = True
        Me.lbTelCli.Location = New System.Drawing.Point(39, 199)
        Me.lbTelCli.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTelCli.Name = "lbTelCli"
        Me.lbTelCli.Size = New System.Drawing.Size(64, 17)
        Me.lbTelCli.TabIndex = 4
        Me.lbTelCli.Text = "Telefono"
        '
        'lbCorreo
        '
        Me.lbCorreo.AutoSize = True
        Me.lbCorreo.Location = New System.Drawing.Point(479, 199)
        Me.lbCorreo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCorreo.Name = "lbCorreo"
        Me.lbCorreo.Size = New System.Drawing.Size(51, 17)
        Me.lbCorreo.TabIndex = 3
        Me.lbCorreo.Text = "Correo"
        '
        'lbDirCli
        '
        Me.lbDirCli.AutoSize = True
        Me.lbDirCli.Location = New System.Drawing.Point(39, 261)
        Me.lbDirCli.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDirCli.Name = "lbDirCli"
        Me.lbDirCli.Size = New System.Drawing.Size(137, 17)
        Me.lbDirCli.TabIndex = 5
        Me.lbDirCli.Text = "Dirección del Cliente"
        '
        'txNomCli
        '
        Me.txNomCli.Location = New System.Drawing.Point(591, 145)
        Me.txNomCli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txNomCli.Name = "txNomCli"
        Me.txNomCli.Size = New System.Drawing.Size(132, 22)
        Me.txNomCli.TabIndex = 6
        '
        'txCorreoCli
        '
        Me.txCorreoCli.Location = New System.Drawing.Point(591, 199)
        Me.txCorreoCli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txCorreoCli.Name = "txCorreoCli"
        Me.txCorreoCli.Size = New System.Drawing.Size(132, 22)
        Me.txCorreoCli.TabIndex = 8
        '
        'txTelCli
        '
        Me.txTelCli.Location = New System.Drawing.Point(175, 196)
        Me.txTelCli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txTelCli.Name = "txTelCli"
        Me.txTelCli.Size = New System.Drawing.Size(132, 22)
        Me.txTelCli.TabIndex = 7
        '
        'rtxDirCli
        '
        Me.rtxDirCli.Location = New System.Drawing.Point(185, 261)
        Me.rtxDirCli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rtxDirCli.Name = "rtxDirCli"
        Me.rtxDirCli.Size = New System.Drawing.Size(225, 47)
        Me.rtxDirCli.TabIndex = 18
        Me.rtxDirCli.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btSalir)
        Me.GroupBox1.Controls.Add(Me.btEliminar)
        Me.GroupBox1.Controls.Add(Me.btActualizar)
        Me.GroupBox1.Controls.Add(Me.btGuardar)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.txbuscarCli)
        Me.GroupBox1.Controls.Add(Me.lbBusquedacli)
        Me.GroupBox1.Controls.Add(Me.btBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 345)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(709, 338)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda del Cliente"
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(597, 300)
        Me.btSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(100, 28)
        Me.btSalir.TabIndex = 25
        Me.btSalir.Text = "Salir"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(424, 300)
        Me.btEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(100, 28)
        Me.btEliminar.TabIndex = 24
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(232, 300)
        Me.btActualizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(100, 28)
        Me.btActualizar.TabIndex = 23
        Me.btActualizar.Text = "Actualizar"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(41, 300)
        Me.btGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(100, 28)
        Me.btGuardar.TabIndex = 22
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 91)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(681, 185)
        Me.DataGridView1.TabIndex = 21
        '
        'txbuscarCli
        '
        Me.txbuscarCli.Location = New System.Drawing.Point(208, 33)
        Me.txbuscarCli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txbuscarCli.Name = "txbuscarCli"
        Me.txbuscarCli.Size = New System.Drawing.Size(273, 22)
        Me.txbuscarCli.TabIndex = 20
        '
        'lbBusquedacli
        '
        Me.lbBusquedacli.AutoSize = True
        Me.lbBusquedacli.Location = New System.Drawing.Point(12, 36)
        Me.lbBusquedacli.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbBusquedacli.Name = "lbBusquedacli"
        Me.lbBusquedacli.Size = New System.Drawing.Size(188, 17)
        Me.lbBusquedacli.TabIndex = 19
        Me.lbBusquedacli.Text = "Escriba el Codigo del Cliente"
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(548, 30)
        Me.btBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(100, 28)
        Me.btBuscar.TabIndex = 18
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(323, 38)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 63)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 702)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btSalir As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txbuscarCli As TextBox
    Friend WithEvents lbBusquedacli As Label
    Friend WithEvents btBuscar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
