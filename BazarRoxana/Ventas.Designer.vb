<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.txtNumVenta = New System.Windows.Forms.TextBox()
        Me.LblNumeroVenta = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnBusquedaProducto = New System.Windows.Forms.Button()
        Me.TxtPrecioProduc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCantProduc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtImpuestoImpuesto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCodProduc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnBusquedaTransaccion = New System.Windows.Forms.Button()
        Me.BtnBusquedaPago = New System.Windows.Forms.Button()
        Me.BtnBusquedaEmpleado = New System.Windows.Forms.Button()
        Me.BtnBuscarCliente = New System.Windows.Forms.Button()
        Me.TxtCodTransa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodPago = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCodCliente = New System.Windows.Forms.TextBox()
        Me.lbCodigoProv = New System.Windows.Forms.Label()
        Me.TxtCodigoEmpleado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btEliminar)
        Me.GroupBox1.Controls.Add(Me.btActualizar)
        Me.GroupBox1.Controls.Add(Me.btGuardar)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.btBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 304)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 275)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de la Venta"
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(477, 244)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btEliminar.TabIndex = 24
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(256, 246)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btActualizar.TabIndex = 23
        Me.btActualizar.Text = "Actualizar"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(12, 244)
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
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(537, 150)
        Me.DataGridView1.TabIndex = 21
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(31, 45)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btBuscar.TabIndex = 18
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'txtNumVenta
        '
        Me.txtNumVenta.Location = New System.Drawing.Point(166, 97)
        Me.txtNumVenta.Name = "txtNumVenta"
        Me.txtNumVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtNumVenta.TabIndex = 27
        '
        'LblNumeroVenta
        '
        Me.LblNumeroVenta.AutoSize = True
        Me.LblNumeroVenta.Location = New System.Drawing.Point(70, 100)
        Me.LblNumeroVenta.Name = "LblNumeroVenta"
        Me.LblNumeroVenta.Size = New System.Drawing.Size(90, 13)
        Me.LblNumeroVenta.TabIndex = 21
        Me.LblNumeroVenta.Text = "Numero de Venta"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnBusquedaProducto)
        Me.GroupBox3.Controls.Add(Me.TxtPrecioProduc)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TxtCantProduc)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtImpuestoImpuesto)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtCodProduc)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(346, 123)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(274, 175)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle de Venta"
        '
        'BtnBusquedaProducto
        '
        Me.BtnBusquedaProducto.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBusquedaProducto.Location = New System.Drawing.Point(236, 31)
        Me.BtnBusquedaProducto.Name = "BtnBusquedaProducto"
        Me.BtnBusquedaProducto.Size = New System.Drawing.Size(29, 23)
        Me.BtnBusquedaProducto.TabIndex = 47
        Me.BtnBusquedaProducto.Text = "..."
        Me.BtnBusquedaProducto.UseVisualStyleBackColor = False
        '
        'TxtPrecioProduc
        '
        Me.TxtPrecioProduc.Location = New System.Drawing.Point(130, 111)
        Me.TxtPrecioProduc.Name = "TxtPrecioProduc"
        Me.TxtPrecioProduc.Size = New System.Drawing.Size(100, 20)
        Me.TxtPrecioProduc.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Precio de la Venta"
        '
        'TxtCantProduc
        '
        Me.TxtCantProduc.Location = New System.Drawing.Point(130, 85)
        Me.TxtCantProduc.Name = "TxtCantProduc"
        Me.TxtCantProduc.Size = New System.Drawing.Size(100, 20)
        Me.TxtCantProduc.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Cantidad de la Venta"
        '
        'TxtImpuestoImpuesto
        '
        Me.TxtImpuestoImpuesto.Location = New System.Drawing.Point(130, 59)
        Me.TxtImpuestoImpuesto.Name = "TxtImpuestoImpuesto"
        Me.TxtImpuestoImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.TxtImpuestoImpuesto.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(68, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Impuesto"
        '
        'TxtCodProduc
        '
        Me.TxtCodProduc.Location = New System.Drawing.Point(130, 33)
        Me.TxtCodProduc.Name = "TxtCodProduc"
        Me.TxtCodProduc.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodProduc.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Codigo de Producto"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnBusquedaTransaccion)
        Me.GroupBox2.Controls.Add(Me.BtnBusquedaPago)
        Me.GroupBox2.Controls.Add(Me.BtnBusquedaEmpleado)
        Me.GroupBox2.Controls.Add(Me.BtnBuscarCliente)
        Me.GroupBox2.Controls.Add(Me.TxtCodTransa)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtCodPago)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtCodCliente)
        Me.GroupBox2.Controls.Add(Me.lbCodigoProv)
        Me.GroupBox2.Controls.Add(Me.TxtCodigoEmpleado)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(62, 123)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(278, 175)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Venta"
        '
        'BtnBusquedaTransaccion
        '
        Me.BtnBusquedaTransaccion.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBusquedaTransaccion.Location = New System.Drawing.Point(239, 109)
        Me.BtnBusquedaTransaccion.Name = "BtnBusquedaTransaccion"
        Me.BtnBusquedaTransaccion.Size = New System.Drawing.Size(29, 23)
        Me.BtnBusquedaTransaccion.TabIndex = 46
        Me.BtnBusquedaTransaccion.Text = "..."
        Me.BtnBusquedaTransaccion.UseVisualStyleBackColor = False
        '
        'BtnBusquedaPago
        '
        Me.BtnBusquedaPago.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBusquedaPago.Location = New System.Drawing.Point(239, 83)
        Me.BtnBusquedaPago.Name = "BtnBusquedaPago"
        Me.BtnBusquedaPago.Size = New System.Drawing.Size(29, 23)
        Me.BtnBusquedaPago.TabIndex = 45
        Me.BtnBusquedaPago.Text = "..."
        Me.BtnBusquedaPago.UseVisualStyleBackColor = False
        '
        'BtnBusquedaEmpleado
        '
        Me.BtnBusquedaEmpleado.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBusquedaEmpleado.Location = New System.Drawing.Point(238, 57)
        Me.BtnBusquedaEmpleado.Name = "BtnBusquedaEmpleado"
        Me.BtnBusquedaEmpleado.Size = New System.Drawing.Size(29, 23)
        Me.BtnBusquedaEmpleado.TabIndex = 44
        Me.BtnBusquedaEmpleado.Text = "..."
        Me.BtnBusquedaEmpleado.UseVisualStyleBackColor = False
        '
        'BtnBuscarCliente
        '
        Me.BtnBuscarCliente.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBuscarCliente.Location = New System.Drawing.Point(238, 32)
        Me.BtnBuscarCliente.Name = "BtnBuscarCliente"
        Me.BtnBuscarCliente.Size = New System.Drawing.Size(29, 23)
        Me.BtnBuscarCliente.TabIndex = 43
        Me.BtnBuscarCliente.Text = "..."
        Me.BtnBuscarCliente.UseVisualStyleBackColor = False
        '
        'TxtCodTransa
        '
        Me.TxtCodTransa.Location = New System.Drawing.Point(132, 111)
        Me.TxtCodTransa.Name = "TxtCodTransa"
        Me.TxtCodTransa.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodTransa.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Codigo de Transaccion"
        '
        'TxtCodPago
        '
        Me.TxtCodPago.Location = New System.Drawing.Point(132, 85)
        Me.TxtCodPago.Name = "TxtCodPago"
        Me.TxtCodPago.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodPago.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Codigo de Pago"
        '
        'TxtCodCliente
        '
        Me.TxtCodCliente.Location = New System.Drawing.Point(132, 34)
        Me.TxtCodCliente.Name = "TxtCodCliente"
        Me.TxtCodCliente.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodCliente.TabIndex = 34
        '
        'lbCodigoProv
        '
        Me.lbCodigoProv.AutoSize = True
        Me.lbCodigoProv.Location = New System.Drawing.Point(9, 37)
        Me.lbCodigoProv.Name = "lbCodigoProv"
        Me.lbCodigoProv.Size = New System.Drawing.Size(92, 13)
        Me.lbCodigoProv.TabIndex = 35
        Me.lbCodigoProv.Text = "Codigo del Cliente"
        '
        'TxtCodigoEmpleado
        '
        Me.TxtCodigoEmpleado.Location = New System.Drawing.Point(132, 59)
        Me.TxtCodigoEmpleado.Name = "TxtCodigoEmpleado"
        Me.TxtCodigoEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodigoEmpleado.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Codigo de Empleado"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(576, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 51)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 650)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNumVenta)
        Me.Controls.Add(Me.LblNumeroVenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btEliminar As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btBuscar As Button
    Friend WithEvents txtNumVenta As TextBox
    Friend WithEvents LblNumeroVenta As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnBusquedaProducto As Button
    Friend WithEvents TxtPrecioProduc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtCantProduc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtImpuestoImpuesto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCodProduc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnBusquedaTransaccion As Button
    Friend WithEvents BtnBusquedaPago As Button
    Friend WithEvents BtnBusquedaEmpleado As Button
    Friend WithEvents BtnBuscarCliente As Button
    Friend WithEvents TxtCodTransa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCodPago As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCodCliente As TextBox
    Friend WithEvents lbCodigoProv As Label
    Friend WithEvents TxtCodigoEmpleado As TextBox
    Friend WithEvents Label3 As Label
End Class
