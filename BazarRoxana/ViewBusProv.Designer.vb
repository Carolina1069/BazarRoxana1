<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewBusProv
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
        Me.DGVProveedores = New System.Windows.Forms.DataGridView()
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVProveedores
        '
        Me.DGVProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVProveedores.Location = New System.Drawing.Point(0, 0)
        Me.DGVProveedores.Name = "DGVProveedores"
        Me.DGVProveedores.Size = New System.Drawing.Size(800, 450)
        Me.DGVProveedores.TabIndex = 0
        '
        'ViewBusProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DGVProveedores)
        Me.Name = "ViewBusProv"
        Me.Text = "Buscar Proveedor"
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVProveedores As DataGridView
End Class
