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
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
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
        Me.txMin = New System.Windows.Forms.TextBox()
        Me.lbMinima = New System.Windows.Forms.Label()
        Me.txMax = New System.Windows.Forms.TextBox()
        Me.lbMaxima = New System.Windows.Forms.Label()
        Me.txtUnidStock = New System.Windows.Forms.TextBox()
        Me.lbUnidStock = New System.Windows.Forms.Label()
        Me.txCodCateg = New System.Windows.Forms.TextBox()
        Me.lbCodCateg = New System.Windows.Forms.Label()
        Me.btBuscarProv = New System.Windows.Forms.Button()
        Me.btBuscarCateg = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(576, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 51)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btEliminar)
        Me.GroupBox1.Controls.Add(Me.btActualizar)
        Me.GroupBox1.Controls.Add(Me.btGuardar)
        Me.GroupBox1.Controls.Add(Me.DGV)
        Me.GroupBox1.Controls.Add(Me.btBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(71, 321)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 275)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de Producto"
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
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 74)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.Size = New System.Drawing.Size(511, 150)
        Me.DGV.TabIndex = 21
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
        'rtxDescProd
        '
        Me.rtxDescProd.Location = New System.Drawing.Point(200, 153)
        Me.rtxDescProd.Name = "rtxDescProd"
        Me.rtxDescProd.Size = New System.Drawing.Size(159, 54)
        Me.rtxDescProd.TabIndex = 30
        Me.rtxDescProd.Text = ""
        '
        'txCodProv
        '
        Me.txCodProv.Location = New System.Drawing.Point(490, 153)
        Me.txCodProv.Name = "txCodProv"
        Me.txCodProv.Size = New System.Drawing.Size(100, 20)
        Me.txCodProv.TabIndex = 29
        '
        'txtPriPre
        '
        Me.txtPriPre.Location = New System.Drawing.Point(137, 232)
        Me.txtPriPre.Name = "txtPriPre"
        Me.txtPriPre.Size = New System.Drawing.Size(100, 20)
        Me.txtPriPre.TabIndex = 28
        '
        'txNomProd
        '
        Me.txNomProd.Location = New System.Drawing.Point(490, 111)
        Me.txNomProd.Name = "txNomProd"
        Me.txNomProd.Size = New System.Drawing.Size(100, 20)
        Me.txNomProd.TabIndex = 27
        '
        'lbPriPre
        '
        Me.lbPriPre.AutoSize = True
        Me.lbPriPre.Location = New System.Drawing.Point(68, 232)
        Me.lbPriPre.Name = "lbPriPre"
        Me.lbPriPre.Size = New System.Drawing.Size(69, 13)
        Me.lbPriPre.TabIndex = 26
        Me.lbPriPre.Text = "Primer Precio"
        '
        'lbDescProd
        '
        Me.lbDescProd.AutoSize = True
        Me.lbDescProd.Location = New System.Drawing.Point(69, 153)
        Me.lbDescProd.Name = "lbDescProd"
        Me.lbDescProd.Size = New System.Drawing.Size(126, 13)
        Me.lbDescProd.TabIndex = 25
        Me.lbDescProd.Text = "Descripcion del Producto"
        '
        'lbCodProv
        '
        Me.lbCodProv.AutoSize = True
        Me.lbCodProv.Location = New System.Drawing.Point(375, 153)
        Me.lbCodProv.Name = "lbCodProv"
        Me.lbCodProv.Size = New System.Drawing.Size(109, 13)
        Me.lbCodProv.TabIndex = 24
        Me.lbCodProv.Text = "Codigo del Proveedor"
        '
        'lbCodigoCli
        '
        Me.lbCodigoCli.AutoSize = True
        Me.lbCodigoCli.Location = New System.Drawing.Point(69, 113)
        Me.lbCodigoCli.Name = "lbCodigoCli"
        Me.lbCodigoCli.Size = New System.Drawing.Size(103, 13)
        Me.lbCodigoCli.TabIndex = 23
        Me.lbCodigoCli.Text = "Codigo del Producto"
        '
        'txCodProd
        '
        Me.txCodProd.Location = New System.Drawing.Point(173, 109)
        Me.txCodProd.Name = "txCodProd"
        Me.txCodProd.Size = New System.Drawing.Size(100, 20)
        Me.txCodProd.TabIndex = 22
        '
        'lbNombreProd
        '
        Me.lbNombreProd.AutoSize = True
        Me.lbNombreProd.Location = New System.Drawing.Point(375, 113)
        Me.lbNombreProd.Name = "lbNombreProd"
        Me.lbNombreProd.Size = New System.Drawing.Size(107, 13)
        Me.lbNombreProd.TabIndex = 21
        Me.lbNombreProd.Text = "Nombre del Producto"
        '
        'txtSegPre
        '
        Me.txtSegPre.Location = New System.Drawing.Point(333, 232)
        Me.txtSegPre.Name = "txtSegPre"
        Me.txtSegPre.Size = New System.Drawing.Size(100, 20)
        Me.txtSegPre.TabIndex = 34
        '
        'lbSegPre
        '
        Me.lbSegPre.AutoSize = True
        Me.lbSegPre.Location = New System.Drawing.Point(249, 232)
        Me.lbSegPre.Name = "lbSegPre"
        Me.lbSegPre.Size = New System.Drawing.Size(83, 13)
        Me.lbSegPre.TabIndex = 33
        Me.lbSegPre.Text = "Segundo Precio"
        '
        'txtTerPre
        '
        Me.txtTerPre.Location = New System.Drawing.Point(519, 232)
        Me.txtTerPre.Name = "txtTerPre"
        Me.txtTerPre.Size = New System.Drawing.Size(100, 20)
        Me.txtTerPre.TabIndex = 36
        '
        'lbTerPre
        '
        Me.lbTerPre.AutoSize = True
        Me.lbTerPre.Location = New System.Drawing.Point(443, 235)
        Me.lbTerPre.Name = "lbTerPre"
        Me.lbTerPre.Size = New System.Drawing.Size(71, 13)
        Me.lbTerPre.TabIndex = 35
        Me.lbTerPre.Text = "Tercer Precio"
        '
        'txMin
        '
        Me.txMin.Location = New System.Drawing.Point(490, 285)
        Me.txMin.Name = "txMin"
        Me.txMin.Size = New System.Drawing.Size(100, 20)
        Me.txMin.TabIndex = 42
        '
        'lbMinima
        '
        Me.lbMinima.AutoSize = True
        Me.lbMinima.Location = New System.Drawing.Point(445, 285)
        Me.lbMinima.Name = "lbMinima"
        Me.lbMinima.Size = New System.Drawing.Size(40, 13)
        Me.lbMinima.TabIndex = 41
        Me.lbMinima.Text = "Minima"
        '
        'txMax
        '
        Me.txMax.Location = New System.Drawing.Point(320, 281)
        Me.txMax.Name = "txMax"
        Me.txMax.Size = New System.Drawing.Size(100, 20)
        Me.txMax.TabIndex = 40
        '
        'lbMaxima
        '
        Me.lbMaxima.AutoSize = True
        Me.lbMaxima.Location = New System.Drawing.Point(272, 282)
        Me.lbMaxima.Name = "lbMaxima"
        Me.lbMaxima.Size = New System.Drawing.Size(43, 13)
        Me.lbMaxima.TabIndex = 39
        Me.lbMaxima.Text = "Maxima"
        '
        'txtUnidStock
        '
        Me.txtUnidStock.Location = New System.Drawing.Point(163, 280)
        Me.txtUnidStock.Name = "txtUnidStock"
        Me.txtUnidStock.Size = New System.Drawing.Size(81, 20)
        Me.txtUnidStock.TabIndex = 38
        '
        'lbUnidStock
        '
        Me.lbUnidStock.AutoSize = True
        Me.lbUnidStock.Location = New System.Drawing.Point(68, 281)
        Me.lbUnidStock.Name = "lbUnidStock"
        Me.lbUnidStock.Size = New System.Drawing.Size(98, 13)
        Me.lbUnidStock.TabIndex = 37
        Me.lbUnidStock.Text = "Unidades en Stock"
        '
        'txCodCateg
        '
        Me.txCodCateg.Location = New System.Drawing.Point(490, 194)
        Me.txCodCateg.Name = "txCodCateg"
        Me.txCodCateg.Size = New System.Drawing.Size(100, 20)
        Me.txCodCateg.TabIndex = 44
        '
        'lbCodCateg
        '
        Me.lbCodCateg.AutoSize = True
        Me.lbCodCateg.Location = New System.Drawing.Point(375, 194)
        Me.lbCodCateg.Name = "lbCodCateg"
        Me.lbCodCateg.Size = New System.Drawing.Size(103, 13)
        Me.lbCodCateg.TabIndex = 43
        Me.lbCodCateg.Text = "Codigo de Categoria"
        '
        'btBuscarProv
        '
        Me.btBuscarProv.BackColor = System.Drawing.SystemColors.Control
        Me.btBuscarProv.Location = New System.Drawing.Point(600, 153)
        Me.btBuscarProv.Name = "btBuscarProv"
        Me.btBuscarProv.Size = New System.Drawing.Size(29, 23)
        Me.btBuscarProv.TabIndex = 26
        Me.btBuscarProv.Text = "..."
        Me.btBuscarProv.UseVisualStyleBackColor = False
        '
        'btBuscarCateg
        '
        Me.btBuscarCateg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btBuscarCateg.Location = New System.Drawing.Point(600, 192)
        Me.btBuscarCateg.Name = "btBuscarCateg"
        Me.btBuscarCateg.Size = New System.Drawing.Size(29, 23)
        Me.btBuscarCateg.TabIndex = 26
        Me.btBuscarCateg.Text = "..."
        Me.btBuscarCateg.UseVisualStyleBackColor = True
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 650)
        Me.Controls.Add(Me.btBuscarCateg)
        Me.Controls.Add(Me.btBuscarProv)
        Me.Controls.Add(Me.txCodCateg)
        Me.Controls.Add(Me.lbCodCateg)
        Me.Controls.Add(Me.txMin)
        Me.Controls.Add(Me.lbMinima)
        Me.Controls.Add(Me.txMax)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Productos"
        Me.Text = "Productos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btEliminar As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents DGV As DataGridView
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
    Friend WithEvents txMin As TextBox
    Friend WithEvents lbMinima As Label
    Friend WithEvents txMax As TextBox
    Friend WithEvents lbMaxima As Label
    Friend WithEvents txtUnidStock As TextBox
    Friend WithEvents lbUnidStock As Label
    Friend WithEvents txCodCateg As TextBox
    Friend WithEvents lbCodCateg As Label
    Friend WithEvents btBuscarProv As Button
    Friend WithEvents btBuscarCateg As Button
End Class
