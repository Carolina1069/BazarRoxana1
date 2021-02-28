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
        Me.txtUnidStock = New System.Windows.Forms.TextBox()
        Me.lbCorreoProve = New System.Windows.Forms.Label()
        Me.txtTelProv = New System.Windows.Forms.TextBox()
        Me.lbTelProvee = New System.Windows.Forms.Label()
        Me.lbDireccProvee = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txbuscarProd = New System.Windows.Forms.TextBox()
        Me.lbBusquedaProd = New System.Windows.Forms.Label()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.txCodProv = New System.Windows.Forms.TextBox()
        Me.txtPriPre = New System.Windows.Forms.TextBox()
        Me.txNomProv = New System.Windows.Forms.TextBox()
        Me.lbNomDistri = New System.Windows.Forms.Label()
        Me.lbTel = New System.Windows.Forms.Label()
        Me.lbCorreoProv = New System.Windows.Forms.Label()
        Me.lbCodigoProv = New System.Windows.Forms.Label()
        Me.txCodProve = New System.Windows.Forms.TextBox()
        Me.lbNombreProv = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUnidStock
        '
        Me.txtUnidStock.Location = New System.Drawing.Point(186, 299)
        Me.txtUnidStock.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnidStock.Name = "txtUnidStock"
        Me.txtUnidStock.Size = New System.Drawing.Size(107, 22)
        Me.txtUnidStock.TabIndex = 59
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
        Me.txtTelProv.Margin = New System.Windows.Forms.Padding(4)
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
        Me.GroupBox1.Controls.Add(Me.btSalir)
        Me.GroupBox1.Controls.Add(Me.btEliminar)
        Me.GroupBox1.Controls.Add(Me.btActualizar)
        Me.GroupBox1.Controls.Add(Me.btGuardar)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.txbuscarProd)
        Me.GroupBox1.Controls.Add(Me.lbBusquedaProd)
        Me.GroupBox1.Controls.Add(Me.btBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 455)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(709, 338)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de Proveedor"
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(597, 300)
        Me.btSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(100, 28)
        Me.btSalir.TabIndex = 25
        Me.btSalir.Text = "Salir"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(424, 300)
        Me.btEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(100, 28)
        Me.btEliminar.TabIndex = 24
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(232, 300)
        Me.btActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(100, 28)
        Me.btActualizar.TabIndex = 23
        Me.btActualizar.Text = "Actualizar"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(41, 300)
        Me.btGuardar.Margin = New System.Windows.Forms.Padding(4)
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
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(681, 185)
        Me.DataGridView1.TabIndex = 21
        '
        'txbuscarProd
        '
        Me.txbuscarProd.Location = New System.Drawing.Point(222, 33)
        Me.txbuscarProd.Margin = New System.Windows.Forms.Padding(4)
        Me.txbuscarProd.Name = "txbuscarProd"
        Me.txbuscarProd.Size = New System.Drawing.Size(273, 22)
        Me.txbuscarProd.TabIndex = 20
        '
        'lbBusquedaProd
        '
        Me.lbBusquedaProd.AutoSize = True
        Me.lbBusquedaProd.Location = New System.Drawing.Point(12, 36)
        Me.lbBusquedaProd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbBusquedaProd.Name = "lbBusquedaProd"
        Me.lbBusquedaProd.Size = New System.Drawing.Size(211, 34)
        Me.lbBusquedaProd.TabIndex = 19
        Me.lbBusquedaProd.Text = "Escriba el Codigo del Proveedor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(548, 30)
        Me.btBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(100, 28)
        Me.btBuscar.TabIndex = 18
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'txCodProv
        '
        Me.txCodProv.Location = New System.Drawing.Point(616, 171)
        Me.txCodProv.Margin = New System.Windows.Forms.Padding(4)
        Me.txCodProv.Name = "txCodProv"
        Me.txCodProv.Size = New System.Drawing.Size(132, 22)
        Me.txCodProv.TabIndex = 51
        '
        'txtPriPre
        '
        Me.txtPriPre.Location = New System.Drawing.Point(271, 237)
        Me.txtPriPre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPriPre.Name = "txtPriPre"
        Me.txtPriPre.Size = New System.Drawing.Size(132, 22)
        Me.txtPriPre.TabIndex = 50
        '
        'txNomProv
        '
        Me.txNomProv.Location = New System.Drawing.Point(597, 112)
        Me.txNomProv.Margin = New System.Windows.Forms.Padding(4)
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
        Me.lbCorreoProv.Location = New System.Drawing.Point(398, 172)
        Me.lbCorreoProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCorreoProv.Name = "lbCorreoProv"
        Me.lbCorreoProv.Size = New System.Drawing.Size(222, 17)
        Me.lbCorreoProv.TabIndex = 46
        Me.lbCorreoProv.Text = "Correo de la empresa proveedora" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbCodigoProv
        '
        Me.lbCodigoProv.AutoSize = True
        Me.lbCodigoProv.Location = New System.Drawing.Point(36, 115)
        Me.lbCodigoProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCodigoProv.Name = "lbCodigoProv"
        Me.lbCodigoProv.Size = New System.Drawing.Size(145, 17)
        Me.lbCodigoProv.TabIndex = 45
        Me.lbCodigoProv.Text = "Codigo del Proveedor"
        '
        'txCodProve
        '
        Me.txCodProve.Location = New System.Drawing.Point(189, 112)
        Me.txCodProve.Margin = New System.Windows.Forms.Padding(4)
        Me.txCodProve.Name = "txCodProve"
        Me.txCodProve.Size = New System.Drawing.Size(132, 22)
        Me.txCodProve.TabIndex = 44
        '
        'lbNombreProv
        '
        Me.lbNombreProv.AutoSize = True
        Me.lbNombreProv.Location = New System.Drawing.Point(367, 115)
        Me.lbNombreProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNombreProv.Name = "lbNombreProv"
        Me.lbNombreProv.Size = New System.Drawing.Size(229, 17)
        Me.lbNombreProv.TabIndex = 43
        Me.lbNombreProv.Text = "Nombre de la empresa proveedora"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(269, 169)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(124, 22)
        Me.TextBox3.TabIndex = 64
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(293, 337)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(327, 111)
        Me.RichTextBox1.TabIndex = 65
        Me.RichTextBox1.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(349, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 70)
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 806)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtUnidStock)
        Me.Controls.Add(Me.lbCorreoProve)
        Me.Controls.Add(Me.txtTelProv)
        Me.Controls.Add(Me.lbTelProvee)
        Me.Controls.Add(Me.lbDireccProvee)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txCodProv)
        Me.Controls.Add(Me.txtPriPre)
        Me.Controls.Add(Me.txNomProv)
        Me.Controls.Add(Me.lbNomDistri)
        Me.Controls.Add(Me.lbTel)
        Me.Controls.Add(Me.lbCorreoProv)
        Me.Controls.Add(Me.lbCodigoProv)
        Me.Controls.Add(Me.txCodProve)
        Me.Controls.Add(Me.lbNombreProv)
        Me.Name = "Proveedores"
        Me.Text = "Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUnidStock As TextBox
    Friend WithEvents lbCorreoProve As Label
    Friend WithEvents txtTelProv As TextBox
    Friend WithEvents lbTelProvee As Label
    Friend WithEvents lbDireccProvee As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btSalir As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txbuscarProd As TextBox
    Friend WithEvents lbBusquedaProd As Label
    Friend WithEvents btBuscar As Button
    Friend WithEvents txCodProv As TextBox
    Friend WithEvents txtPriPre As TextBox
    Friend WithEvents txNomProv As TextBox
    Friend WithEvents lbNomDistri As Label
    Friend WithEvents lbTel As Label
    Friend WithEvents lbCorreoProv As Label
    Friend WithEvents lbCodigoProv As Label
    Friend WithEvents txCodProve As TextBox
    Friend WithEvents lbNombreProv As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
