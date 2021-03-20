<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Me.TxtCorreoProv = New System.Windows.Forms.TextBox()
        Me.lbCorreoProve = New System.Windows.Forms.Label()
        Me.txtTelProv = New System.Windows.Forms.TextBox()
        Me.lbTelProvee = New System.Windows.Forms.Label()
        Me.lbDireccProvee = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btActualizarTabla = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.DGVProveedores = New System.Windows.Forms.DataGridView()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.txCorreoEmpresa = New System.Windows.Forms.TextBox()
        Me.txtNombrePreEm = New System.Windows.Forms.TextBox()
        Me.txNomProv = New System.Windows.Forms.TextBox()
        Me.lbNomDistri = New System.Windows.Forms.Label()
        Me.lbTel = New System.Windows.Forms.Label()
        Me.lbCorreoProv = New System.Windows.Forms.Label()
        Me.lbCodigoProv = New System.Windows.Forms.Label()
        Me.txCodProve = New System.Windows.Forms.TextBox()
        Me.lbNombreProv = New System.Windows.Forms.Label()
        Me.TxtTelfonoEmpresa = New System.Windows.Forms.TextBox()
        Me.RTBDirec = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCorreoProv
        '
        Me.TxtCorreoProv.Location = New System.Drawing.Point(187, 299)
        Me.TxtCorreoProv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCorreoProv.Name = "TxtCorreoProv"
        Me.TxtCorreoProv.Size = New System.Drawing.Size(107, 22)
        Me.TxtCorreoProv.TabIndex = 59
        '
        'lbCorreoProve
        '
        Me.lbCorreoProve.AutoSize = True
        Me.lbCorreoProve.Location = New System.Drawing.Point(35, 299)
        Me.lbCorreoProve.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCorreoProve.Name = "lbCorreoProve"
        Me.lbCorreoProve.Size = New System.Drawing.Size(143, 17)
        Me.lbCorreoProve.TabIndex = 58
        Me.lbCorreoProve.Text = "Correo del proveedor"
        '
        'txtTelProv
        '
        Me.txtTelProv.Location = New System.Drawing.Point(597, 239)
        Me.txtTelProv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTelProv.Name = "txtTelProv"
        Me.txtTelProv.Size = New System.Drawing.Size(132, 22)
        Me.txtTelProv.TabIndex = 57
        '
        'lbTelProvee
        '
        Me.lbTelProvee.AutoSize = True
        Me.lbTelProvee.Location = New System.Drawing.Point(433, 239)
        Me.lbTelProvee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTelProvee.Name = "lbTelProvee"
        Me.lbTelProvee.Size = New System.Drawing.Size(156, 17)
        Me.lbTelProvee.TabIndex = 56
        Me.lbTelProvee.Text = "Telefono del proveedor"
        '
        'lbDireccProvee
        '
        Me.lbDireccProvee.AutoSize = True
        Me.lbDireccProvee.Location = New System.Drawing.Point(36, 337)
        Me.lbDireccProvee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDireccProvee.Name = "lbDireccProvee"
        Me.lbDireccProvee.Size = New System.Drawing.Size(239, 17)
        Me.lbDireccProvee.TabIndex = 54
        Me.lbDireccProvee.Text = "Direccion de la empresa Proveedora"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btActualizarTabla)
        Me.GroupBox1.Controls.Add(Me.btSalir)
        Me.GroupBox1.Controls.Add(Me.btEliminar)
        Me.GroupBox1.Controls.Add(Me.btActualizar)
        Me.GroupBox1.Controls.Add(Me.btGuardar)
        Me.GroupBox1.Controls.Add(Me.DGVProveedores)
        Me.GroupBox1.Controls.Add(Me.btBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 455)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(709, 338)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de Proveedor"
        '
        'btActualizarTabla
        '
        Me.btActualizarTabla.Location = New System.Drawing.Point(559, 44)
        Me.btActualizarTabla.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btActualizarTabla.Name = "btActualizarTabla"
        Me.btActualizarTabla.Size = New System.Drawing.Size(125, 28)
        Me.btActualizarTabla.TabIndex = 26
        Me.btActualizarTabla.Text = "Actualizar Tabla"
        Me.btActualizarTabla.UseVisualStyleBackColor = True
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
        'DGVProveedores
        '
        Me.DGVProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProveedores.Location = New System.Drawing.Point(16, 91)
        Me.DGVProveedores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVProveedores.Name = "DGVProveedores"
        Me.DGVProveedores.RowHeadersWidth = 51
        Me.DGVProveedores.Size = New System.Drawing.Size(681, 185)
        Me.DGVProveedores.TabIndex = 21
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(43, 44)
        Me.btBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(100, 28)
        Me.btBuscar.TabIndex = 18
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'txCorreoEmpresa
        '
        Me.txCorreoEmpresa.Location = New System.Drawing.Point(616, 171)
        Me.txCorreoEmpresa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txCorreoEmpresa.Name = "txCorreoEmpresa"
        Me.txCorreoEmpresa.Size = New System.Drawing.Size(132, 22)
        Me.txCorreoEmpresa.TabIndex = 51
        '
        'txtNombrePreEm
        '
        Me.txtNombrePreEm.Location = New System.Drawing.Point(271, 238)
        Me.txtNombrePreEm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombrePreEm.Name = "txtNombrePreEm"
        Me.txtNombrePreEm.Size = New System.Drawing.Size(132, 22)
        Me.txtNombrePreEm.TabIndex = 50
        '
        'txNomProv
        '
        Me.txNomProv.Location = New System.Drawing.Point(597, 112)
        Me.txNomProv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txNomProv.Name = "txNomProv"
        Me.txNomProv.Size = New System.Drawing.Size(132, 22)
        Me.txNomProv.TabIndex = 49
        '
        'lbNomDistri
        '
        Me.lbNomDistri.AutoSize = True
        Me.lbNomDistri.Location = New System.Drawing.Point(35, 239)
        Me.lbNomDistri.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNomDistri.Name = "lbNomDistri"
        Me.lbNomDistri.Size = New System.Drawing.Size(240, 17)
        Me.lbNomDistri.TabIndex = 48
        Me.lbNomDistri.Text = "Nombre del proveedor(empleado(a))"
        '
        'lbTel
        '
        Me.lbTel.AutoSize = True
        Me.lbTel.Location = New System.Drawing.Point(27, 174)
        Me.lbTel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTel.Name = "lbTel"
        Me.lbTel.Size = New System.Drawing.Size(235, 17)
        Me.lbTel.TabIndex = 47
        Me.lbTel.Text = "Telefono de la empresa proveedora" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbCorreoProv
        '
        Me.lbCorreoProv.AutoSize = True
        Me.lbCorreoProv.Location = New System.Drawing.Point(397, 172)
        Me.lbCorreoProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCorreoProv.Name = "lbCorreoProv"
        Me.lbCorreoProv.Size = New System.Drawing.Size(222, 17)
        Me.lbCorreoProv.TabIndex = 46
        Me.lbCorreoProv.Text = "Correo de la empresa proveedora" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbCodigoProv
        '
        Me.lbCodigoProv.AutoSize = True
        Me.lbCodigoProv.Location = New System.Drawing.Point(36, 114)
        Me.lbCodigoProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCodigoProv.Name = "lbCodigoProv"
        Me.lbCodigoProv.Size = New System.Drawing.Size(145, 17)
        Me.lbCodigoProv.TabIndex = 45
        Me.lbCodigoProv.Text = "Codigo del Proveedor"
        '
        'txCodProve
        '
        Me.txCodProve.Location = New System.Drawing.Point(189, 112)
        Me.txCodProve.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txCodProve.Name = "txCodProve"
        Me.txCodProve.Size = New System.Drawing.Size(132, 22)
        Me.txCodProve.TabIndex = 44
        '
        'lbNombreProv
        '
        Me.lbNombreProv.AutoSize = True
        Me.lbNombreProv.Location = New System.Drawing.Point(367, 114)
        Me.lbNombreProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNombreProv.Name = "lbNombreProv"
        Me.lbNombreProv.Size = New System.Drawing.Size(229, 17)
        Me.lbNombreProv.TabIndex = 43
        Me.lbNombreProv.Text = "Nombre de la empresa proveedora"
        '
        'TxtTelfonoEmpresa
        '
        Me.TxtTelfonoEmpresa.Location = New System.Drawing.Point(269, 169)
        Me.TxtTelfonoEmpresa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTelfonoEmpresa.Name = "TxtTelfonoEmpresa"
        Me.TxtTelfonoEmpresa.Size = New System.Drawing.Size(124, 22)
        Me.TxtTelfonoEmpresa.TabIndex = 64
        '
        'RTBDirec
        '
        Me.RTBDirec.Location = New System.Drawing.Point(293, 337)
        Me.RTBDirec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RTBDirec.Name = "RTBDirec"
        Me.RTBDirec.Size = New System.Drawing.Size(327, 111)
        Me.RTBDirec.TabIndex = 65
        Me.RTBDirec.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(349, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 70)
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 816)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RTBDirec)
        Me.Controls.Add(Me.TxtTelfonoEmpresa)
        Me.Controls.Add(Me.TxtCorreoProv)
        Me.Controls.Add(Me.lbCorreoProve)
        Me.Controls.Add(Me.txtTelProv)
        Me.Controls.Add(Me.lbTelProvee)
        Me.Controls.Add(Me.lbDireccProvee)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txCorreoEmpresa)
        Me.Controls.Add(Me.txtNombrePreEm)
        Me.Controls.Add(Me.txNomProv)
        Me.Controls.Add(Me.lbNomDistri)
        Me.Controls.Add(Me.lbTel)
        Me.Controls.Add(Me.lbCorreoProv)
        Me.Controls.Add(Me.lbCodigoProv)
        Me.Controls.Add(Me.txCodProve)
        Me.Controls.Add(Me.lbNombreProv)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Proveedores"
        Me.Text = "Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCorreoProv As TextBox
    Friend WithEvents lbCorreoProve As Label
    Friend WithEvents txtTelProv As TextBox
    Friend WithEvents lbTelProvee As Label
    Friend WithEvents lbDireccProvee As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btSalir As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents DGVProveedores As DataGridView
    Friend WithEvents btBuscar As Button
    Friend WithEvents txCorreoEmpresa As TextBox
    Friend WithEvents txtNombrePreEm As TextBox
    Friend WithEvents txNomProv As TextBox
    Friend WithEvents lbNomDistri As Label
    Friend WithEvents lbTel As Label
    Friend WithEvents lbCorreoProv As Label
    Friend WithEvents lbCodigoProv As Label
    Friend WithEvents txCodProve As TextBox
    Friend WithEvents lbNombreProv As Label
    Friend WithEvents TxtTelfonoEmpresa As TextBox
    Friend WithEvents RTBDirec As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btActualizarTabla As Button
End Class
