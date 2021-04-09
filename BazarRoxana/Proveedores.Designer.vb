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
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.chkInhabil = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCorreoProv
        '
        Me.TxtCorreoProv.Location = New System.Drawing.Point(159, 233)
        Me.TxtCorreoProv.Name = "TxtCorreoProv"
        Me.TxtCorreoProv.Size = New System.Drawing.Size(81, 20)
        Me.TxtCorreoProv.TabIndex = 59
        '
        'lbCorreoProve
        '
        Me.lbCorreoProve.AutoSize = True
        Me.lbCorreoProve.Location = New System.Drawing.Point(45, 233)
        Me.lbCorreoProve.Name = "lbCorreoProve"
        Me.lbCorreoProve.Size = New System.Drawing.Size(106, 13)
        Me.lbCorreoProve.TabIndex = 58
        Me.lbCorreoProve.Text = "Correo del proveedor"
        '
        'txtTelProv
        '
        Me.txtTelProv.Location = New System.Drawing.Point(482, 187)
        Me.txtTelProv.Name = "txtTelProv"
        Me.txtTelProv.Size = New System.Drawing.Size(100, 20)
        Me.txtTelProv.TabIndex = 57
        '
        'lbTelProvee
        '
        Me.lbTelProvee.AutoSize = True
        Me.lbTelProvee.Location = New System.Drawing.Point(359, 187)
        Me.lbTelProvee.Name = "lbTelProvee"
        Me.lbTelProvee.Size = New System.Drawing.Size(117, 13)
        Me.lbTelProvee.TabIndex = 56
        Me.lbTelProvee.Text = "Telefono del proveedor"
        '
        'lbDireccProvee
        '
        Me.lbDireccProvee.AutoSize = True
        Me.lbDireccProvee.Location = New System.Drawing.Point(61, 267)
        Me.lbDireccProvee.Name = "lbDireccProvee"
        Me.lbDireccProvee.Size = New System.Drawing.Size(179, 13)
        Me.lbDireccProvee.TabIndex = 54
        Me.lbDireccProvee.Text = "Direccion de la empresa Proveedora"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkInhabil)
        Me.GroupBox1.Controls.Add(Me.btActualizarTabla)
        Me.GroupBox1.Controls.Add(Me.btEliminar)
        Me.GroupBox1.Controls.Add(Me.btActualizar)
        Me.GroupBox1.Controls.Add(Me.btGuardar)
        Me.GroupBox1.Controls.Add(Me.DGVProveedores)
        Me.GroupBox1.Controls.Add(Me.btBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(63, 363)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 275)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de Proveedor"
        '
        'btActualizarTabla
        '
        Me.btActualizarTabla.Location = New System.Drawing.Point(419, 36)
        Me.btActualizarTabla.Name = "btActualizarTabla"
        Me.btActualizarTabla.Size = New System.Drawing.Size(94, 23)
        Me.btActualizarTabla.TabIndex = 26
        Me.btActualizarTabla.Text = "Actualizar Tabla"
        Me.btActualizarTabla.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(451, 246)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btEliminar.TabIndex = 24
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(249, 246)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btActualizar.TabIndex = 23
        Me.btActualizar.Text = "Actualizar"
        Me.btActualizar.UseVisualStyleBackColor = True
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
        'DGVProveedores
        '
        Me.DGVProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProveedores.Location = New System.Drawing.Point(12, 74)
        Me.DGVProveedores.Name = "DGVProveedores"
        Me.DGVProveedores.RowHeadersWidth = 51
        Me.DGVProveedores.Size = New System.Drawing.Size(511, 150)
        Me.DGVProveedores.TabIndex = 21
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(32, 36)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btBuscar.TabIndex = 18
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'txCorreoEmpresa
        '
        Me.txCorreoEmpresa.Location = New System.Drawing.Point(496, 132)
        Me.txCorreoEmpresa.Name = "txCorreoEmpresa"
        Me.txCorreoEmpresa.Size = New System.Drawing.Size(100, 20)
        Me.txCorreoEmpresa.TabIndex = 51
        '
        'txtNombrePreEm
        '
        Me.txtNombrePreEm.Location = New System.Drawing.Point(222, 183)
        Me.txtNombrePreEm.Name = "txtNombrePreEm"
        Me.txtNombrePreEm.Size = New System.Drawing.Size(100, 20)
        Me.txtNombrePreEm.TabIndex = 50
        '
        'txNomProv
        '
        Me.txNomProv.Location = New System.Drawing.Point(496, 83)
        Me.txNomProv.Name = "txNomProv"
        Me.txNomProv.Size = New System.Drawing.Size(100, 20)
        Me.txNomProv.TabIndex = 49
        '
        'lbNomDistri
        '
        Me.lbNomDistri.AutoSize = True
        Me.lbNomDistri.Location = New System.Drawing.Point(45, 184)
        Me.lbNomDistri.Name = "lbNomDistri"
        Me.lbNomDistri.Size = New System.Drawing.Size(176, 13)
        Me.lbNomDistri.TabIndex = 48
        Me.lbNomDistri.Text = "Nombre del proveedor(empleado(a))"
        '
        'lbTel
        '
        Me.lbTel.AutoSize = True
        Me.lbTel.Location = New System.Drawing.Point(39, 131)
        Me.lbTel.Name = "lbTel"
        Me.lbTel.Size = New System.Drawing.Size(175, 13)
        Me.lbTel.TabIndex = 47
        Me.lbTel.Text = "Telefono de la empresa proveedora" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbCorreoProv
        '
        Me.lbCorreoProv.AutoSize = True
        Me.lbCorreoProv.Location = New System.Drawing.Point(332, 133)
        Me.lbCorreoProv.Name = "lbCorreoProv"
        Me.lbCorreoProv.Size = New System.Drawing.Size(164, 13)
        Me.lbCorreoProv.TabIndex = 46
        Me.lbCorreoProv.Text = "Correo de la empresa proveedora" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbCodigoProv
        '
        Me.lbCodigoProv.AutoSize = True
        Me.lbCodigoProv.Location = New System.Drawing.Point(46, 83)
        Me.lbCodigoProv.Name = "lbCodigoProv"
        Me.lbCodigoProv.Size = New System.Drawing.Size(109, 13)
        Me.lbCodigoProv.TabIndex = 45
        Me.lbCodigoProv.Text = "Codigo del Proveedor"
        '
        'txCodProve
        '
        Me.txCodProve.Location = New System.Drawing.Point(161, 81)
        Me.txCodProve.Name = "txCodProve"
        Me.txCodProve.Size = New System.Drawing.Size(100, 20)
        Me.txCodProve.TabIndex = 44
        '
        'lbNombreProv
        '
        Me.lbNombreProv.AutoSize = True
        Me.lbNombreProv.Location = New System.Drawing.Point(323, 85)
        Me.lbNombreProv.Name = "lbNombreProv"
        Me.lbNombreProv.Size = New System.Drawing.Size(170, 13)
        Me.lbNombreProv.TabIndex = 43
        Me.lbNombreProv.Text = "Nombre de la empresa proveedora"
        '
        'TxtTelfonoEmpresa
        '
        Me.TxtTelfonoEmpresa.Location = New System.Drawing.Point(221, 127)
        Me.TxtTelfonoEmpresa.Name = "TxtTelfonoEmpresa"
        Me.TxtTelfonoEmpresa.Size = New System.Drawing.Size(94, 20)
        Me.TxtTelfonoEmpresa.TabIndex = 64
        '
        'RTBDirec
        '
        Me.RTBDirec.Location = New System.Drawing.Point(254, 267)
        Me.RTBDirec.Margin = New System.Windows.Forms.Padding(2)
        Me.RTBDirec.Name = "RTBDirec"
        Me.RTBDirec.Size = New System.Drawing.Size(246, 91)
        Me.RTBDirec.TabIndex = 65
        Me.RTBDirec.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(589, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 57)
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Location = New System.Drawing.Point(417, 235)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(59, 17)
        Me.chkEstado.TabIndex = 67
        Me.chkEstado.Text = "Estado"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'chkInhabil
        '
        Me.chkInhabil.AutoSize = True
        Me.chkInhabil.Location = New System.Drawing.Point(299, 40)
        Me.chkInhabil.Name = "chkInhabil"
        Me.chkInhabil.Size = New System.Drawing.Size(88, 17)
        Me.chkInhabil.TabIndex = 69
        Me.chkInhabil.Text = "Inhabilitados "
        Me.chkInhabil.UseVisualStyleBackColor = True
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 650)
        Me.Controls.Add(Me.chkEstado)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Proveedores"
        Me.Text = "Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents chkInhabil As CheckBox
End Class
