<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturaVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FacturaVenta))
        Me.SelectFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BazarRoxana = New BazarRoxana()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SelectFacturaTableAdapter = New BazarRoxanaTableAdapters.SelectFacturaTableAdapter()
        CType(Me.SelectFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BazarRoxana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelectFacturaBindingSource
        '
        Me.SelectFacturaBindingSource.DataMember = "SelectFactura"
        Me.SelectFacturaBindingSource.DataSource = Me.BazarRoxana
        '
        'BazarRoxana
        '
        Me.BazarRoxana.DataSetName = "BazarRoxana"
        Me.BazarRoxana.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Factura"
        ReportDataSource1.Value = Me.SelectFacturaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BazarRoxana.FacturaVenta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'SelectFacturaTableAdapter
        '
        Me.SelectFacturaTableAdapter.ClearBeforeFill = True
        '
        'FacturaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FacturaVenta"
        Me.Text = "Factura de la Venta"
        CType(Me.SelectFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BazarRoxana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SelectFacturaBindingSource As BindingSource
    Friend WithEvents BazarRoxana As BazarRoxana
    Friend WithEvents SelectFacturaTableAdapter As BazarRoxanaTableAdapters.SelectFacturaTableAdapter
End Class
