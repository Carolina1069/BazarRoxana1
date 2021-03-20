<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categorias
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
        Me.btnActTabla = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txCodCat = New System.Windows.Forms.TextBox()
        Me.lbDescripcion = New System.Windows.Forms.Label()
        Me.lbCodigoCategoria = New System.Windows.Forms.Label()
        Me.txtNombCat = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(332, 6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 63)
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnActTabla)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.DGV)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 306)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(709, 338)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de la categoria"
        '
        'btnActTabla
        '
        Me.btnActTabla.Location = New System.Drawing.Point(539, 43)
        Me.btnActTabla.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnActTabla.Name = "btnActTabla"
        Me.btnActTabla.Size = New System.Drawing.Size(144, 28)
        Me.btnActTabla.TabIndex = 26
        Me.btnActTabla.Text = "Actualizar Tabla"
        Me.btnActTabla.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(597, 300)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 28)
        Me.btnSalir.TabIndex = 25
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(413, 300)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 28)
        Me.btnEliminar.TabIndex = 24
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(232, 300)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(100, 28)
        Me.btnActualizar.TabIndex = 23
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(41, 300)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 28)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(16, 91)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.Size = New System.Drawing.Size(681, 185)
        Me.DGV.TabIndex = 21
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(41, 43)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 28)
        Me.btnBuscar.TabIndex = 18
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txCodCat
        '
        Me.txCodCat.Location = New System.Drawing.Point(200, 112)
        Me.txCodCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txCodCat.Name = "txCodCat"
        Me.txCodCat.Size = New System.Drawing.Size(132, 22)
        Me.txCodCat.TabIndex = 60
        '
        'lbDescripcion
        '
        Me.lbDescripcion.AutoSize = True
        Me.lbDescripcion.Location = New System.Drawing.Point(44, 178)
        Me.lbDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.Size = New System.Drawing.Size(156, 17)
        Me.lbDescripcion.TabIndex = 57
        Me.lbDescripcion.Text = "Nombre de la categoria" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbCodigoCategoria
        '
        Me.lbCodigoCategoria.AutoSize = True
        Me.lbCodigoCategoria.Location = New System.Drawing.Point(40, 112)
        Me.lbCodigoCategoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCodigoCategoria.Name = "lbCodigoCategoria"
        Me.lbCodigoCategoria.Size = New System.Drawing.Size(152, 17)
        Me.lbCodigoCategoria.TabIndex = 53
        Me.lbCodigoCategoria.Text = "Codigo de la Categoria" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtNombCat
        '
        Me.txtNombCat.Location = New System.Drawing.Point(208, 178)
        Me.txtNombCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombCat.Name = "txtNombCat"
        Me.txtNombCat.Size = New System.Drawing.Size(132, 22)
        Me.txtNombCat.TabIndex = 65
        '
        'Categorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 657)
        Me.Controls.Add(Me.txtNombCat)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txCodCat)
        Me.Controls.Add(Me.lbDescripcion)
        Me.Controls.Add(Me.lbCodigoCategoria)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Categorias"
        Me.Text = "Categorias"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txCodCat As TextBox
    Friend WithEvents lbDescripcion As Label
    Friend WithEvents lbCodigoCategoria As Label
    Friend WithEvents txtNombCat As TextBox
    Friend WithEvents btnActTabla As Button
End Class
