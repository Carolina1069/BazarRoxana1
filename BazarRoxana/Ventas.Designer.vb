<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.txtNumVenta = New System.Windows.Forms.TextBox()
        Me.lbCodEmple = New System.Windows.Forms.Label()
        Me.lbCodigoCli = New System.Windows.Forms.Label()
        Me.txCodCli = New System.Windows.Forms.TextBox()
        Me.lbNumeroVenta = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(234, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 51)
        Me.PictureBox1.TabIndex = 32
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
        Me.GroupBox1.Location = New System.Drawing.Point(24, 271)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 275)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de la Venta"
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(511, 150)
        Me.DataGridView1.TabIndex = 21
        '
        'txbuscarVenta
        '
        Me.txbuscarVenta.Location = New System.Drawing.Point(156, 27)
        Me.txbuscarVenta.Name = "txbuscarVenta"
        Me.txbuscarVenta.Size = New System.Drawing.Size(206, 20)
        Me.txbuscarVenta.TabIndex = 20
        '
        'lbBusquedaVenta
        '
        Me.lbBusquedaVenta.AutoSize = True
        Me.lbBusquedaVenta.Location = New System.Drawing.Point(6, 29)
        Me.lbBusquedaVenta.Name = "lbBusquedaVenta"
        Me.lbBusquedaVenta.Size = New System.Drawing.Size(150, 13)
        Me.lbBusquedaVenta.TabIndex = 19
        Me.lbBusquedaVenta.Text = "Escriba el Numero de la Venta"
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(411, 24)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btBuscar.TabIndex = 18
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'txCodEmple
        '
        Me.txCodEmple.Location = New System.Drawing.Point(123, 159)
        Me.txCodEmple.Name = "txCodEmple"
        Me.txCodEmple.Size = New System.Drawing.Size(100, 20)
        Me.txCodEmple.TabIndex = 28
        '
        'txtNumVenta
        '
        Me.txtNumVenta.Location = New System.Drawing.Point(123, 104)
        Me.txtNumVenta.Name = "txtNumVenta"
        Me.txtNumVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtNumVenta.TabIndex = 27
        '
        'lbCodEmple
        '
        Me.lbCodEmple.AutoSize = True
        Me.lbCodEmple.Location = New System.Drawing.Point(21, 162)
        Me.lbCodEmple.Name = "lbCodEmple"
        Me.lbCodEmple.Size = New System.Drawing.Size(105, 13)
        Me.lbCodEmple.TabIndex = 25
        Me.lbCodEmple.Text = "Codigo de Empleado"
        '
        'lbCodigoCli
        '
        Me.lbCodigoCli.AutoSize = True
        Me.lbCodigoCli.Location = New System.Drawing.Point(325, 104)
        Me.lbCodigoCli.Name = "lbCodigoCli"
        Me.lbCodigoCli.Size = New System.Drawing.Size(92, 13)
        Me.lbCodigoCli.TabIndex = 23
        Me.lbCodigoCli.Text = "Codigo del Cliente"
        '
        'txCodCli
        '
        Me.txCodCli.Location = New System.Drawing.Point(427, 97)
        Me.txCodCli.Name = "txCodCli"
        Me.txCodCli.Size = New System.Drawing.Size(100, 20)
        Me.txCodCli.TabIndex = 22
        '
        'lbNumeroVenta
        '
        Me.lbNumeroVenta.AutoSize = True
        Me.lbNumeroVenta.Location = New System.Drawing.Point(15, 108)
        Me.lbNumeroVenta.Name = "lbNumeroVenta"
        Me.lbNumeroVenta.Size = New System.Drawing.Size(90, 13)
        Me.lbNumeroVenta.TabIndex = 21
        Me.lbNumeroVenta.Text = "Numero de Venta"
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 554)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txCodEmple)
        Me.Controls.Add(Me.txtNumVenta)
        Me.Controls.Add(Me.lbCodEmple)
        Me.Controls.Add(Me.lbCodigoCli)
        Me.Controls.Add(Me.txCodCli)
        Me.Controls.Add(Me.lbNumeroVenta)
        Me.Name = "Ventas"
        Me.Text = "Ventas"
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
    Friend WithEvents txtNumVenta As TextBox
    Friend WithEvents lbCodEmple As Label
    Friend WithEvents lbCodigoCli As Label
    Friend WithEvents txCodCli As TextBox
    Friend WithEvents lbNumeroVenta As Label
End Class
