<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Me.txbuscarProd = New System.Windows.Forms.TextBox()
        Me.lbBusquedaProd = New System.Windows.Forms.Label()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.rtxDescProd = New System.Windows.Forms.RichTextBox()
        Me.txCodProv = New System.Windows.Forms.TextBox()
        Me.txtPriPre = New System.Windows.Forms.TextBox()
        Me.txNomProd = New System.Windows.Forms.TextBox()
        Me.lbPriPre = New System.Windows.Forms.Label()
        Me.lbDescProd = New System.Windows.Forms.Label()
        Me.lbCodProv = New System.Windows.Forms.Label()
        Me.lbCodigoCli = New System.Windows.Forms.Label()
        Me.txCodProd = New System.Windows.Forms.TextBox()
        Me.lbNombreProd = New System.Windows.Forms.Label()
        Me.txtSegPre = New System.Windows.Forms.TextBox()
        Me.lbSegPre = New System.Windows.Forms.Label()
        Me.txtTerPre = New System.Windows.Forms.TextBox()
        Me.lbTerPre = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbMinima = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lbMaxima = New System.Windows.Forms.Label()
        Me.txtUnidStock = New System.Windows.Forms.TextBox()
        Me.lbUnidStock = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(328, 37)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 63)
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
        Me.GroupBox1.Controls.Add(Me.txbuscarProd)
        Me.GroupBox1.Controls.Add(Me.lbBusquedaProd)
        Me.GroupBox1.Controls.Add(Me.btBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 405)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(709, 338)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de Producto"
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
        Me.lbBusquedaProd.Size = New System.Drawing.Size(202, 17)
        Me.lbBusquedaProd.TabIndex = 19
        Me.lbBusquedaProd.Text = "Escriba el Codigo del Producto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        'rtxDescProd
        '
        Me.rtxDescProd.Location = New System.Drawing.Point(218, 198)
        Me.rtxDescProd.Margin = New System.Windows.Forms.Padding(4)
        Me.rtxDescProd.Name = "rtxDescProd"
        Me.rtxDescProd.Size = New System.Drawing.Size(225, 74)
        Me.rtxDescProd.TabIndex = 30
        Me.rtxDescProd.Text = ""
        '
        'txCodProv
        '
        Me.txCodProv.Location = New System.Drawing.Point(605, 198)
        Me.txCodProv.Margin = New System.Windows.Forms.Padding(4)
        Me.txCodProv.Name = "txCodProv"
        Me.txCodProv.Size = New System.Drawing.Size(132, 22)
        Me.txCodProv.TabIndex = 29
        '
        'txtPriPre
        '
        Me.txtPriPre.Location = New System.Drawing.Point(135, 296)
        Me.txtPriPre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPriPre.Name = "txtPriPre"
        Me.txtPriPre.Size = New System.Drawing.Size(132, 22)
        Me.txtPriPre.TabIndex = 28
        '
        'txNomProd
        '
        Me.txNomProd.Location = New System.Drawing.Point(605, 146)
        Me.txNomProd.Margin = New System.Windows.Forms.Padding(4)
        Me.txNomProd.Name = "txNomProd"
        Me.txNomProd.Size = New System.Drawing.Size(132, 22)
        Me.txNomProd.TabIndex = 27
        '
        'lbPriPre
        '
        Me.lbPriPre.AutoSize = True
        Me.lbPriPre.Location = New System.Drawing.Point(43, 296)
        Me.lbPriPre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPriPre.Name = "lbPriPre"
        Me.lbPriPre.Size = New System.Drawing.Size(93, 17)
        Me.lbPriPre.TabIndex = 26
        Me.lbPriPre.Text = "Primer Precio"
        '
        'lbDescProd
        '
        Me.lbDescProd.AutoSize = True
        Me.lbDescProd.Location = New System.Drawing.Point(44, 198)
        Me.lbDescProd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDescProd.Name = "lbDescProd"
        Me.lbDescProd.Size = New System.Drawing.Size(166, 17)
        Me.lbDescProd.TabIndex = 25
        Me.lbDescProd.Text = "Descripcion del Producto"
        '
        'lbCodProv
        '
        Me.lbCodProv.AutoSize = True
        Me.lbCodProv.Location = New System.Drawing.Point(452, 198)
        Me.lbCodProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCodProv.Name = "lbCodProv"
        Me.lbCodProv.Size = New System.Drawing.Size(145, 17)
        Me.lbCodProv.TabIndex = 24
        Me.lbCodProv.Text = "Codigo del Proveedor"
        '
        'lbCodigoCli
        '
        Me.lbCodigoCli.AutoSize = True
        Me.lbCodigoCli.Location = New System.Drawing.Point(44, 149)
        Me.lbCodigoCli.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCodigoCli.Name = "lbCodigoCli"
        Me.lbCodigoCli.Size = New System.Drawing.Size(136, 17)
        Me.lbCodigoCli.TabIndex = 23
        Me.lbCodigoCli.Text = "Codigo del Producto"
        '
        'txCodProd
        '
        Me.txCodProd.Location = New System.Drawing.Point(180, 144)
        Me.txCodProd.Margin = New System.Windows.Forms.Padding(4)
        Me.txCodProd.Name = "txCodProd"
        Me.txCodProd.Size = New System.Drawing.Size(132, 22)
        Me.txCodProd.TabIndex = 22
        '
        'lbNombreProd
        '
        Me.lbNombreProd.AutoSize = True
        Me.lbNombreProd.Location = New System.Drawing.Point(452, 149)
        Me.lbNombreProd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNombreProd.Name = "lbNombreProd"
        Me.lbNombreProd.Size = New System.Drawing.Size(142, 17)
        Me.lbNombreProd.TabIndex = 21
        Me.lbNombreProd.Text = "Nombre del Producto"
        '
        'txtSegPre
        '
        Me.txtSegPre.Location = New System.Drawing.Point(396, 296)
        Me.txtSegPre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSegPre.Name = "txtSegPre"
        Me.txtSegPre.Size = New System.Drawing.Size(132, 22)
        Me.txtSegPre.TabIndex = 34
        '
        'lbSegPre
        '
        Me.lbSegPre.AutoSize = True
        Me.lbSegPre.Location = New System.Drawing.Point(284, 296)
        Me.lbSegPre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbSegPre.Name = "lbSegPre"
        Me.lbSegPre.Size = New System.Drawing.Size(109, 17)
        Me.lbSegPre.TabIndex = 33
        Me.lbSegPre.Text = "Segundo Precio"
        '
        'txtTerPre
        '
        Me.txtTerPre.Location = New System.Drawing.Point(644, 296)
        Me.txtTerPre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTerPre.Name = "txtTerPre"
        Me.txtTerPre.Size = New System.Drawing.Size(132, 22)
        Me.txtTerPre.TabIndex = 36
        '
        'lbTerPre
        '
        Me.lbTerPre.AutoSize = True
        Me.lbTerPre.Location = New System.Drawing.Point(543, 299)
        Me.lbTerPre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTerPre.Name = "lbTerPre"
        Me.lbTerPre.Size = New System.Drawing.Size(94, 17)
        Me.lbTerPre.TabIndex = 35
        Me.lbTerPre.Text = "Tercer Precio"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(605, 361)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 42
        '
        'lbMinima
        '
        Me.lbMinima.AutoSize = True
        Me.lbMinima.Location = New System.Drawing.Point(545, 361)
        Me.lbMinima.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMinima.Name = "lbMinima"
        Me.lbMinima.Size = New System.Drawing.Size(52, 17)
        Me.lbMinima.TabIndex = 41
        Me.lbMinima.Text = "Minima"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(378, 356)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 22)
        Me.TextBox2.TabIndex = 40
        '
        'lbMaxima
        '
        Me.lbMaxima.AutoSize = True
        Me.lbMaxima.Location = New System.Drawing.Point(315, 357)
        Me.lbMaxima.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMaxima.Name = "lbMaxima"
        Me.lbMaxima.Size = New System.Drawing.Size(55, 17)
        Me.lbMaxima.TabIndex = 39
        Me.lbMaxima.Text = "Maxima"
        '
        'txtUnidStock
        '
        Me.txtUnidStock.Location = New System.Drawing.Point(169, 354)
        Me.txtUnidStock.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnidStock.Name = "txtUnidStock"
        Me.txtUnidStock.Size = New System.Drawing.Size(107, 22)
        Me.txtUnidStock.TabIndex = 38
        '
        'lbUnidStock
        '
        Me.lbUnidStock.AutoSize = True
        Me.lbUnidStock.Location = New System.Drawing.Point(43, 356)
        Me.lbUnidStock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbUnidStock.Name = "lbUnidStock"
        Me.lbUnidStock.Size = New System.Drawing.Size(127, 17)
        Me.lbUnidStock.TabIndex = 37
        Me.lbUnidStock.Text = "Unidades en Stock"
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 765)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbMinima)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lbMaxima)
        Me.Controls.Add(Me.txtUnidStock)
        Me.Controls.Add(Me.lbUnidStock)
        Me.Controls.Add(Me.txtTerPre)
        Me.Controls.Add(Me.lbTerPre)
        Me.Controls.Add(Me.txtSegPre)
        Me.Controls.Add(Me.lbSegPre)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rtxDescProd)
        Me.Controls.Add(Me.txCodProv)
        Me.Controls.Add(Me.txtPriPre)
        Me.Controls.Add(Me.txNomProd)
        Me.Controls.Add(Me.lbPriPre)
        Me.Controls.Add(Me.lbDescProd)
        Me.Controls.Add(Me.lbCodProv)
        Me.Controls.Add(Me.lbCodigoCli)
        Me.Controls.Add(Me.txCodProd)
        Me.Controls.Add(Me.lbNombreProd)
        Me.Name = "Productos"
        Me.Text = "Productos"
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
    Friend WithEvents txbuscarProd As TextBox
    Friend WithEvents lbBusquedaProd As Label
    Friend WithEvents btBuscar As Button
    Friend WithEvents rtxDescProd As RichTextBox
    Friend WithEvents txCodProv As TextBox
    Friend WithEvents txtPriPre As TextBox
    Friend WithEvents txNomProd As TextBox
    Friend WithEvents lbPriPre As Label
    Friend WithEvents lbDescProd As Label
    Friend WithEvents lbCodProv As Label
    Friend WithEvents lbCodigoCli As Label
    Friend WithEvents txCodProd As TextBox
    Friend WithEvents lbNombreProd As Label
    Friend WithEvents txtSegPre As TextBox
    Friend WithEvents lbSegPre As Label
    Friend WithEvents txtTerPre As TextBox
    Friend WithEvents lbTerPre As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbMinima As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lbMaxima As Label
    Friend WithEvents txtUnidStock As TextBox
    Friend WithEvents lbUnidStock As Label
End Class
