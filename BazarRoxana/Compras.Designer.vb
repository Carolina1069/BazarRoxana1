<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txbuscarVenta = New System.Windows.Forms.TextBox()
        Me.lbBusquedaVenta = New System.Windows.Forms.Label()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.txCodEmple = New System.Windows.Forms.TextBox()
        Me.txNumCompra = New System.Windows.Forms.TextBox()
        Me.lbCodEmple = New System.Windows.Forms.Label()
        Me.lbCodigoProv = New System.Windows.Forms.Label()
        Me.txCodProv = New System.Windows.Forms.TextBox()
        Me.lbNumeroCompra = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(327, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 63)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btSalir)
        Me.GroupBox1.Controls.Add(Me.btEliminar)
        Me.GroupBox1.Controls.Add(Me.btActualizar)
        Me.GroupBox1.Controls.Add(Me.btGuardar)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.txbuscarVenta)
        Me.GroupBox1.Controls.Add(Me.lbBusquedaVenta)
        Me.GroupBox1.Controls.Add(Me.btBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 320)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(709, 338)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de la Compra"
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
        'txbuscarVenta
        '
        Me.txbuscarVenta.Location = New System.Drawing.Point(228, 36)
        Me.txbuscarVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.txbuscarVenta.Name = "txbuscarVenta"
        Me.txbuscarVenta.Size = New System.Drawing.Size(273, 22)
        Me.txbuscarVenta.TabIndex = 20
        '
        'lbBusquedaVenta
        '
        Me.lbBusquedaVenta.AutoSize = True
        Me.lbBusquedaVenta.Location = New System.Drawing.Point(8, 36)
        Me.lbBusquedaVenta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbBusquedaVenta.Name = "lbBusquedaVenta"
        Me.lbBusquedaVenta.Size = New System.Drawing.Size(212, 17)
        Me.lbBusquedaVenta.TabIndex = 19
        Me.lbBusquedaVenta.Text = "Escriba el Numero de la Compra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        'txCodEmple
        '
        Me.txCodEmple.Location = New System.Drawing.Point(179, 182)
        Me.txCodEmple.Margin = New System.Windows.Forms.Padding(4)
        Me.txCodEmple.Name = "txCodEmple"
        Me.txCodEmple.Size = New System.Drawing.Size(132, 22)
        Me.txCodEmple.TabIndex = 38
        '
        'txNumCompra
        '
        Me.txNumCompra.Location = New System.Drawing.Point(179, 114)
        Me.txNumCompra.Margin = New System.Windows.Forms.Padding(4)
        Me.txNumCompra.Name = "txNumCompra"
        Me.txNumCompra.Size = New System.Drawing.Size(132, 22)
        Me.txNumCompra.TabIndex = 37
        '
        'lbCodEmple
        '
        Me.lbCodEmple.AutoSize = True
        Me.lbCodEmple.Location = New System.Drawing.Point(35, 185)
        Me.lbCodEmple.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCodEmple.Name = "lbCodEmple"
        Me.lbCodEmple.Size = New System.Drawing.Size(139, 17)
        Me.lbCodEmple.TabIndex = 36
        Me.lbCodEmple.Text = "Codigo de Empleado"
        '
        'lbCodigoProv
        '
        Me.lbCodigoProv.AutoSize = True
        Me.lbCodigoProv.Location = New System.Drawing.Point(448, 114)
        Me.lbCodigoProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCodigoProv.Name = "lbCodigoProv"
        Me.lbCodigoProv.Size = New System.Drawing.Size(145, 17)
        Me.lbCodigoProv.TabIndex = 35
        Me.lbCodigoProv.Text = "Codigo del Proveedor"
        '
        'txCodProv
        '
        Me.txCodProv.Location = New System.Drawing.Point(601, 111)
        Me.txCodProv.Margin = New System.Windows.Forms.Padding(4)
        Me.txCodProv.Name = "txCodProv"
        Me.txCodProv.Size = New System.Drawing.Size(132, 22)
        Me.txCodProv.TabIndex = 34
        '
        'lbNumeroCompra
        '
        Me.lbNumeroCompra.AutoSize = True
        Me.lbNumeroCompra.Location = New System.Drawing.Point(35, 119)
        Me.lbNumeroCompra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNumeroCompra.Name = "lbNumeroCompra"
        Me.lbNumeroCompra.Size = New System.Drawing.Size(131, 17)
        Me.lbNumeroCompra.TabIndex = 33
        Me.lbNumeroCompra.Text = "Numero de Compra"
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 680)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txCodEmple)
        Me.Controls.Add(Me.txNumCompra)
        Me.Controls.Add(Me.lbCodEmple)
        Me.Controls.Add(Me.lbCodigoProv)
        Me.Controls.Add(Me.txCodProv)
        Me.Controls.Add(Me.lbNumeroCompra)
        Me.Name = "Compras"
        Me.Text = "Compras"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btSalir As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txbuscarVenta As TextBox
    Friend WithEvents lbBusquedaVenta As Label
    Friend WithEvents btBuscar As Button
    Friend WithEvents txCodEmple As TextBox
    Friend WithEvents txNumCompra As TextBox
    Friend WithEvents lbCodEmple As Label
    Friend WithEvents lbCodigoProv As Label
    Friend WithEvents txCodProv As TextBox
    Friend WithEvents lbNumeroCompra As Label
End Class
