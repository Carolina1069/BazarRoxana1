<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteCompraParametro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteCompraParametro))
        Me.SelectCompraFechaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BazarRoxana = New BazarRoxana()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.SelectCompraFechaTableAdapter = New BazarRoxanaTableAdapters.SelectCompraFechaTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DtpSegundaFecha = New System.Windows.Forms.DateTimePicker()
        Me.DtpPrimerFecha = New System.Windows.Forms.DateTimePicker()
        CType(Me.SelectCompraFechaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BazarRoxana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelectCompraFechaBindingSource
        '
        Me.SelectCompraFechaBindingSource.DataMember = "SelectCompraFecha"
        Me.SelectCompraFechaBindingSource.DataSource = Me.BazarRoxana
        '
        'BazarRoxana
        '
        Me.BazarRoxana.DataSetName = "BazarRoxana"
        Me.BazarRoxana.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Primer Fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Segunda Fecha:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(318, 27)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 21)
        Me.BtnBuscar.TabIndex = 5
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'SelectCompraFechaTableAdapter
        '
        Me.SelectCompraFechaTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "CompraFecha"
        ReportDataSource1.Value = Me.SelectCompraFechaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BazarRoxana.RpCompraParametro.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 80)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(776, 657)
        Me.ReportViewer1.TabIndex = 7
        '
        'DtpSegundaFecha
        '
        Me.DtpSegundaFecha.Location = New System.Drawing.Point(104, 40)
        Me.DtpSegundaFecha.Name = "DtpSegundaFecha"
        Me.DtpSegundaFecha.Size = New System.Drawing.Size(200, 20)
        Me.DtpSegundaFecha.TabIndex = 16
        '
        'DtpPrimerFecha
        '
        Me.DtpPrimerFecha.Location = New System.Drawing.Point(104, 14)
        Me.DtpPrimerFecha.Name = "DtpPrimerFecha"
        Me.DtpPrimerFecha.Size = New System.Drawing.Size(200, 20)
        Me.DtpPrimerFecha.TabIndex = 15
        '
        'ReporteCompraParametro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 749)
        Me.Controls.Add(Me.DtpSegundaFecha)
        Me.Controls.Add(Me.DtpPrimerFecha)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReporteCompraParametro"
        Me.Text = "Reporte de las Compras con Intervalo de Fecha"
        CType(Me.SelectCompraFechaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BazarRoxana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents SelectCompraFechaBindingSource As BindingSource
    Friend WithEvents BazarRoxana As BazarRoxana
    Friend WithEvents SelectCompraFechaTableAdapter As BazarRoxanaTableAdapters.SelectCompraFechaTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DtpSegundaFecha As DateTimePicker
    Friend WithEvents DtpPrimerFecha As DateTimePicker
End Class
