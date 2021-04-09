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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btBuscarCateg = New System.Windows.Forms.Button()
        Me.btBuscarProv = New System.Windows.Forms.Button()
        Me.txCodCateg = New System.Windows.Forms.TextBox()
        Me.lbCodCateg = New System.Windows.Forms.Label()
        Me.txMin = New System.Windows.Forms.TextBox()
        Me.lbMinima = New System.Windows.Forms.Label()
        Me.txMax = New System.Windows.Forms.TextBox()
        Me.lbMaxima = New System.Windows.Forms.Label()
        Me.txtUnidStock = New System.Windows.Forms.TextBox()
        Me.lbUnidStock = New System.Windows.Forms.Label()
        Me.txtTerPre = New System.Windows.Forms.TextBox()
        Me.lbTerPre = New System.Windows.Forms.Label()
        Me.txtSegPre = New System.Windows.Forms.TextBox()
        Me.lbSegPre = New System.Windows.Forms.Label()
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btEliminar)
        Me.GroupBox1.Controls.Add(Me.btActualizar)
        Me.GroupBox1.Controls.Add(Me.btGuardar)
        Me.GroupBox1.Controls.Add(Me.DGV)
        Me.GroupBox1.Controls.Add(Me.btBuscar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 348)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(605, 290)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de Producto"
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(490, 232)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btEliminar.TabIndex = 24
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(288, 232)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btActualizar.TabIndex = 23
        Me.btActualizar.Text = "Actualizar"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(45, 232)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btGuardar.TabIndex = 22
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(51, 60)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.Size = New System.Drawing.Size(511, 150)
        Me.DGV.TabIndex = 21
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(70, 31)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btBuscar.TabIndex = 18
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BazarRoxana.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(409, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImage = Global.BazarRoxana.My.Resources.Resources.Blur
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.btBuscarCateg)
        Me.GroupBox2.Controls.Add(Me.btBuscarProv)
        Me.GroupBox2.Controls.Add(Me.txCodCateg)
        Me.GroupBox2.Controls.Add(Me.lbCodCateg)
        Me.GroupBox2.Controls.Add(Me.txMin)
        Me.GroupBox2.Controls.Add(Me.lbMinima)
        Me.GroupBox2.Controls.Add(Me.txMax)
        Me.GroupBox2.Controls.Add(Me.lbMaxima)
        Me.GroupBox2.Controls.Add(Me.txtUnidStock)
        Me.GroupBox2.Controls.Add(Me.lbUnidStock)
        Me.GroupBox2.Controls.Add(Me.txtTerPre)
        Me.GroupBox2.Controls.Add(Me.lbTerPre)
        Me.GroupBox2.Controls.Add(Me.txtSegPre)
        Me.GroupBox2.Controls.Add(Me.lbSegPre)
        Me.GroupBox2.Controls.Add(Me.rtxDescProd)
        Me.GroupBox2.Controls.Add(Me.txCodProv)
        Me.GroupBox2.Controls.Add(Me.txtPriPre)
        Me.GroupBox2.Controls.Add(Me.txNomProd)
        Me.GroupBox2.Controls.Add(Me.lbPriPre)
        Me.GroupBox2.Controls.Add(Me.lbDescProd)
        Me.GroupBox2.Controls.Add(Me.lbCodProv)
        Me.GroupBox2.Controls.Add(Me.lbCodigoCli)
        Me.GroupBox2.Controls.Add(Me.txCodProd)
        Me.GroupBox2.Controls.Add(Me.lbNombreProd)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(30, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(605, 227)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Producto"
        '
        'btBuscarCateg
        '
        Me.btBuscarCateg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btBuscarCateg.Location = New System.Drawing.Point(554, 106)
        Me.btBuscarCateg.Name = "btBuscarCateg"
        Me.btBuscarCateg.Size = New System.Drawing.Size(29, 23)
        Me.btBuscarCateg.TabIndex = 51
        Me.btBuscarCateg.Text = "..."
        Me.btBuscarCateg.UseVisualStyleBackColor = True
        '
        'btBuscarProv
        '
        Me.btBuscarProv.BackColor = System.Drawing.SystemColors.Control
        Me.btBuscarProv.Location = New System.Drawing.Point(554, 67)
        Me.btBuscarProv.Name = "btBuscarProv"
        Me.btBuscarProv.Size = New System.Drawing.Size(29, 23)
        Me.btBuscarProv.TabIndex = 52
        Me.btBuscarProv.Text = "..."
        Me.btBuscarProv.UseVisualStyleBackColor = False
        '
        'txCodCateg
        '
        Me.txCodCateg.Location = New System.Drawing.Point(444, 108)
        Me.txCodCateg.Name = "txCodCateg"
        Me.txCodCateg.Size = New System.Drawing.Size(100, 20)
        Me.txCodCateg.TabIndex = 68
        '
        'lbCodCateg
        '
        Me.lbCodCateg.AutoSize = True
        Me.lbCodCateg.Location = New System.Drawing.Point(367, 105)
        Me.lbCodCateg.Name = "lbCodCateg"
        Me.lbCodCateg.Size = New System.Drawing.Size(68, 26)
        Me.lbCodCateg.TabIndex = 67
        Me.lbCodCateg.Text = "Codigo de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Categoria"
        '
        'txMin
        '
        Me.txMin.Location = New System.Drawing.Point(444, 199)
        Me.txMin.Name = "txMin"
        Me.txMin.Size = New System.Drawing.Size(100, 20)
        Me.txMin.TabIndex = 66
        '
        'lbMinima
        '
        Me.lbMinima.AutoSize = True
        Me.lbMinima.Location = New System.Drawing.Point(399, 199)
        Me.lbMinima.Name = "lbMinima"
        Me.lbMinima.Size = New System.Drawing.Size(46, 13)
        Me.lbMinima.TabIndex = 65
        Me.lbMinima.Text = "Minima"
        '
        'txMax
        '
        Me.txMax.Location = New System.Drawing.Point(263, 196)
        Me.txMax.Name = "txMax"
        Me.txMax.Size = New System.Drawing.Size(100, 20)
        Me.txMax.TabIndex = 64
        '
        'lbMaxima
        '
        Me.lbMaxima.AutoSize = True
        Me.lbMaxima.Location = New System.Drawing.Point(203, 197)
        Me.lbMaxima.Name = "lbMaxima"
        Me.lbMaxima.Size = New System.Drawing.Size(49, 13)
        Me.lbMaxima.TabIndex = 63
        Me.lbMaxima.Text = "Maxima"
        '
        'txtUnidStock
        '
        Me.txtUnidStock.Location = New System.Drawing.Point(70, 194)
        Me.txtUnidStock.Name = "txtUnidStock"
        Me.txtUnidStock.Size = New System.Drawing.Size(81, 20)
        Me.txtUnidStock.TabIndex = 62
        '
        'lbUnidStock
        '
        Me.lbUnidStock.AutoSize = True
        Me.lbUnidStock.Location = New System.Drawing.Point(6, 188)
        Me.lbUnidStock.Name = "lbUnidStock"
        Me.lbUnidStock.Size = New System.Drawing.Size(64, 26)
        Me.lbUnidStock.TabIndex = 61
        Me.lbUnidStock.Text = "Unidades " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en Stock"
        '
        'txtTerPre
        '
        Me.txtTerPre.Location = New System.Drawing.Point(444, 152)
        Me.txtTerPre.Name = "txtTerPre"
        Me.txtTerPre.Size = New System.Drawing.Size(100, 20)
        Me.txtTerPre.TabIndex = 60
        '
        'lbTerPre
        '
        Me.lbTerPre.AutoSize = True
        Me.lbTerPre.Location = New System.Drawing.Point(397, 149)
        Me.lbTerPre.Name = "lbTerPre"
        Me.lbTerPre.Size = New System.Drawing.Size(48, 26)
        Me.lbTerPre.TabIndex = 59
        Me.lbTerPre.Text = "Tercer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Precio"
        '
        'txtSegPre
        '
        Me.txtSegPre.Location = New System.Drawing.Point(263, 152)
        Me.txtSegPre.Name = "txtSegPre"
        Me.txtSegPre.Size = New System.Drawing.Size(100, 20)
        Me.txtSegPre.TabIndex = 58
        '
        'lbSegPre
        '
        Me.lbSegPre.AutoSize = True
        Me.lbSegPre.Location = New System.Drawing.Point(203, 146)
        Me.lbSegPre.Name = "lbSegPre"
        Me.lbSegPre.Size = New System.Drawing.Size(61, 26)
        Me.lbSegPre.TabIndex = 57
        Me.lbSegPre.Text = "Segundo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Precio"
        '
        'rtxDescProd
        '
        Me.rtxDescProd.Location = New System.Drawing.Point(151, 64)
        Me.rtxDescProd.Name = "rtxDescProd"
        Me.rtxDescProd.Size = New System.Drawing.Size(159, 54)
        Me.rtxDescProd.TabIndex = 56
        Me.rtxDescProd.Text = ""
        '
        'txCodProv
        '
        Me.txCodProv.Location = New System.Drawing.Point(444, 67)
        Me.txCodProv.Name = "txCodProv"
        Me.txCodProv.Size = New System.Drawing.Size(100, 20)
        Me.txCodProv.TabIndex = 55
        '
        'txtPriPre
        '
        Me.txtPriPre.Location = New System.Drawing.Point(70, 152)
        Me.txtPriPre.Name = "txtPriPre"
        Me.txtPriPre.Size = New System.Drawing.Size(100, 20)
        Me.txtPriPre.TabIndex = 54
        '
        'txNomProd
        '
        Me.txNomProd.Location = New System.Drawing.Point(444, 25)
        Me.txNomProd.Name = "txNomProd"
        Me.txNomProd.Size = New System.Drawing.Size(100, 20)
        Me.txNomProd.TabIndex = 53
        '
        'lbPriPre
        '
        Me.lbPriPre.AutoSize = True
        Me.lbPriPre.Location = New System.Drawing.Point(22, 146)
        Me.lbPriPre.Name = "lbPriPre"
        Me.lbPriPre.Size = New System.Drawing.Size(46, 26)
        Me.lbPriPre.TabIndex = 50
        Me.lbPriPre.Text = "Primer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Precio"
        '
        'lbDescProd
        '
        Me.lbDescProd.AutoSize = True
        Me.lbDescProd.Location = New System.Drawing.Point(25, 67)
        Me.lbDescProd.Name = "lbDescProd"
        Me.lbDescProd.Size = New System.Drawing.Size(79, 26)
        Me.lbDescProd.TabIndex = 49
        Me.lbDescProd.Text = "Descripcion " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del Producto"
        '
        'lbCodProv
        '
        Me.lbCodProv.AutoSize = True
        Me.lbCodProv.Location = New System.Drawing.Point(367, 64)
        Me.lbCodProv.Name = "lbCodProv"
        Me.lbCodProv.Size = New System.Drawing.Size(71, 26)
        Me.lbCodProv.TabIndex = 48
        Me.lbCodProv.Text = "Codigo del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proveedor"
        '
        'lbCodigoCli
        '
        Me.lbCodigoCli.AutoSize = True
        Me.lbCodigoCli.Location = New System.Drawing.Point(23, 27)
        Me.lbCodigoCli.Name = "lbCodigoCli"
        Me.lbCodigoCli.Size = New System.Drawing.Size(122, 13)
        Me.lbCodigoCli.TabIndex = 47
        Me.lbCodigoCli.Text = "Codigo del Producto"
        '
        'txCodProd
        '
        Me.txCodProd.Location = New System.Drawing.Point(151, 24)
        Me.txCodProd.Name = "txCodProd"
        Me.txCodProd.Size = New System.Drawing.Size(100, 20)
        Me.txCodProd.TabIndex = 46
        '
        'lbNombreProd
        '
        Me.lbNombreProd.AutoSize = True
        Me.lbNombreProd.Location = New System.Drawing.Point(367, 24)
        Me.lbNombreProd.Name = "lbNombreProd"
        Me.lbNombreProd.Size = New System.Drawing.Size(75, 26)
        Me.lbNombreProd.TabIndex = 45
        Me.lbNombreProd.Text = "Nombre del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Producto"
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BazarRoxana.My.Resources.Resources.WhatsApp_Image_2021_04_08_at_10_15_57_PM
        Me.ClientSize = New System.Drawing.Size(666, 650)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Productos"
        Me.Text = "Productos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btEliminar As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents btBuscar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btBuscarCateg As Button
    Friend WithEvents btBuscarProv As Button
    Friend WithEvents txCodCateg As TextBox
    Friend WithEvents lbCodCateg As Label
    Friend WithEvents txMin As TextBox
    Friend WithEvents lbMinima As Label
    Friend WithEvents txMax As TextBox
    Friend WithEvents lbMaxima As Label
    Friend WithEvents txtUnidStock As TextBox
    Friend WithEvents lbUnidStock As Label
    Friend WithEvents txtTerPre As TextBox
    Friend WithEvents lbTerPre As Label
    Friend WithEvents txtSegPre As TextBox
    Friend WithEvents lbSegPre As Label
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
End Class
