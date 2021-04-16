<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteProductoParametro
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SelectProductoParametroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BazarRoxana = New BazarRoxana()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.SelectProductoParametroTableAdapter = New BazarRoxanaTableAdapters.SelectProductoParametroTableAdapter()
        CType(Me.SelectProductoParametroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BazarRoxana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelectProductoParametroBindingSource
        '
        Me.SelectProductoParametroBindingSource.DataMember = "SelectProductoParametro"
        Me.SelectProductoParametroBindingSource.DataSource = Me.BazarRoxana
        '
        'BazarRoxana
        '
        Me.BazarRoxana.DataSetName = "BazarRoxana"
        Me.BazarRoxana.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ProductoParametro"
        ReportDataSource1.Value = Me.SelectProductoParametroBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BazarRoxana.RpProductoParametro.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 54)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(776, 683)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Escriba la Categoria:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(282, 26)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(176, 28)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(100, 20)
        Me.TxtBusqueda.TabIndex = 3
        '
        'SelectProductoParametroTableAdapter
        '
        Me.SelectProductoParametroTableAdapter.ClearBeforeFill = True
        '
        'ReporteProductoParametro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 749)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReporteProductoParametro"
        Me.Text = "ReporteProductoParametro"
        CType(Me.SelectProductoParametroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BazarRoxana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents SelectProductoParametroBindingSource As BindingSource
    Friend WithEvents BazarRoxana As BazarRoxana
    Friend WithEvents SelectProductoParametroTableAdapter As BazarRoxanaTableAdapters.SelectProductoParametroTableAdapter
End Class
