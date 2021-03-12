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
        Me.btActualizarTabla = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCorreoProv
        '
        Me.TxtCorreoProv.Location = New System.Drawing.Point(140, 243)
        Me.TxtCorreoProv.Name = "TxtCorreoProv"
        Me.TxtCorreoProv.Size = New System.Drawing.Size(81, 20)
        Me.TxtCorreoProv.TabIndex = 59
        '
        'lbCorreoProve
        '
        Me.lbCorreoProve.AutoSize = True
        Me.lbCorreoProve.Location = New System.Drawing.Point(26, 243)
        Me.lbCorreoProve.Name = "lbCorreoProve"
        Me.lbCorreoProve.Size = New System.Drawing.Size(106, 13)
        Me.lbCorreoProve.TabIndex = 58
        Me.lbCorreoProve.Text = "Correo del proveedor"
        '
        'txtTelProv
        '
        Me.txtTelProv.Location = New System.Drawing.Point(448, 194)
        Me.txtTelProv.Name = "txtTelProv"
        Me.txtTelProv.Size = New System.Drawing.Size(100, 20)
        Me.txtTelProv.TabIndex = 57
        '
        'lbTelProvee
        '
        Me.lbTelProvee.AutoSize = True
        Me.lbTelProvee.Location = New System.Drawing.Point(325, 194)
        Me.lbTelProvee.Name = "lbTelProvee"
        Me.lbTelProvee.Size = New System.Drawing.Size(117, 13)
        Me.lbTelProvee.TabIndex = 56
        Me.lbTelProvee.Text = "Telefono del proveedor"
        '
        'lbDireccProvee
        '
        Me.lbDireccProvee.AutoSize = True
        Me.lbDireccProvee.Location = New System.Drawing.Point(27, 274)
        Me.lbDireccProvee.Name = "lbDireccProvee"
        Me.lbDireccProvee.Size = New System.Drawing.Size(179, 13)
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
        Me.GroupBox1.Location = New System.Drawing.Point(29, 370)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 275)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de Proveedor"
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
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(318, 244)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btEliminar.TabIndex = 24
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
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
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(31, 244)
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
        Me.txCorreoEmpresa.Location = New System.Drawing.Point(462, 139)
        Me.txCorreoEmpresa.Name = "txCorreoEmpresa"
        Me.txCorreoEmpresa.Size = New System.Drawing.Size(100, 20)
        Me.txCorreoEmpresa.TabIndex = 51
        '
        'txtNombrePreEm
        '
        Me.txtNombrePreEm.Location = New System.Drawing.Point(203, 193)
        Me.txtNombrePreEm.Name = "txtNombrePreEm"
        Me.txtNombrePreEm.Size = New System.Drawing.Size(100, 20)
        Me.txtNombrePreEm.TabIndex = 50
        '
        'txNomProv
        '
        Me.txNomProv.Location = New System.Drawing.Point(448, 91)
        Me.txNomProv.Name = "txNomProv"
        Me.txNomProv.Size = New System.Drawing.Size(100, 20)
        Me.txNomProv.TabIndex = 49
        '
        'lbNomDistri
        '
        Me.lbNomDistri.AutoSize = True
        Me.lbNomDistri.Location = New System.Drawing.Point(26, 194)
        Me.lbNomDistri.Name = "lbNomDistri"
        Me.lbNomDistri.Size = New System.Drawing.Size(176, 13)
        Me.lbNomDistri.TabIndex = 48
        Me.lbNomDistri.Text = "Nombre del proveedor(empleado(a))"
        '
        'lbTel
        '
        Me.lbTel.AutoSize = True
        Me.lbTel.Location = New System.Drawing.Point(20, 141)
        Me.lbTel.Name = "lbTel"
        Me.lbTel.Size = New System.Drawing.Size(175, 13)
        Me.lbTel.TabIndex = 47
        Me.lbTel.Text = "Telefono de la empresa proveedora" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbCorreoProv
        '
        Me.lbCorreoProv.AutoSize = True
        Me.lbCorreoProv.Location = New System.Drawing.Point(298, 140)
        Me.lbCorreoProv.Name = "lbCorreoProv"
        Me.lbCorreoProv.Size = New System.Drawing.Size(164, 13)
        Me.lbCorreoProv.TabIndex = 46
        Me.lbCorreoProv.Text = "Correo de la empresa proveedora" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbCodigoProv
        '
        Me.lbCodigoProv.AutoSize = True
        Me.lbCodigoProv.Location = New System.Drawing.Point(27, 93)
        Me.lbCodigoProv.Name = "lbCodigoProv"
        Me.lbCodigoProv.Size = New System.Drawing.Size(109, 13)
        Me.lbCodigoProv.TabIndex = 45
        Me.lbCodigoProv.Text = "Codigo del Proveedor"
        '
        'txCodProve
        '
        Me.txCodProve.Location = New System.Drawing.Point(142, 91)
        Me.txCodProve.Name = "txCodProve"
        Me.txCodProve.Size = New System.Drawing.Size(100, 20)
        Me.txCodProve.TabIndex = 44
        '
        'lbNombreProv
        '
        Me.lbNombreProv.AutoSize = True
        Me.lbNombreProv.Location = New System.Drawing.Point(275, 93)
        Me.lbNombreProv.Name = "lbNombreProv"
        Me.lbNombreProv.Size = New System.Drawing.Size(170, 13)
        Me.lbNombreProv.TabIndex = 43
        Me.lbNombreProv.Text = "Nombre de la empresa proveedora"
        '
        'TxtTelfonoEmpresa
        '
        Me.TxtTelfonoEmpresa.Location = New System.Drawing.Point(202, 137)
        Me.TxtTelfonoEmpresa.Name = "TxtTelfonoEmpresa"
        Me.TxtTelfonoEmpresa.Size = New System.Drawing.Size(94, 20)
        Me.TxtTelfonoEmpresa.TabIndex = 64
        '
        'RTBDirec
        '
        Me.RTBDirec.Location = New System.Drawing.Point(220, 274)
        Me.RTBDirec.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RTBDirec.Name = "RTBDirec"
        Me.RTBDirec.Size = New System.Drawing.Size(246, 91)
        Me.RTBDirec.TabIndex = 65
        Me.RTBDirec.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(262, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 57)
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
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
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 663)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
