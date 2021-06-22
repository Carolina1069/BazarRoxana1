<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteVentaParametro
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteVentaParametro))
        Me.SelectVentaFechaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BazarRoxana = New BazarRoxana()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SelectVentaFechaTableAdapter = New BazarRoxanaTableAdapters.SelectVentaFechaTableAdapter()
        Me.DtpPrimerFecha = New System.Windows.Forms.DateTimePicker()
        Me.DtpSegundaFecha = New System.Windows.Forms.DateTimePicker()
        CType(Me.SelectVentaFechaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BazarRoxana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelectVentaFechaBindingSource
        '
        Me.SelectVentaFechaBindingSource.DataMember = "SelectVentaFecha"
        Me.SelectVentaFechaBindingSource.DataSource = Me.BazarRoxana
        '
        'BazarRoxana
        '
        Me.BazarRoxana.DataSetName = "BazarRoxana"
        Me.BazarRoxana.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "VentaFecha"
        ReportDataSource1.Value = Me.SelectVentaFechaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BazarRoxana.RpVentaParametro.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 76)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(776, 661)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Año/(mm)/(dd)"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(318, 23)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 21)
        Me.BtnBuscar.TabIndex = 11
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Segunda Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Primer Fecha:"
        '
        'SelectVentaFechaTableAdapter
        '
        Me.SelectVentaFechaTableAdapter.ClearBeforeFill = True
        '
        'DtpPrimerFecha
        '
        Me.DtpPrimerFecha.Location = New System.Drawing.Point(99, 10)
        Me.DtpPrimerFecha.Name = "DtpPrimerFecha"
        Me.DtpPrimerFecha.Size = New System.Drawing.Size(200, 20)
        Me.DtpPrimerFecha.TabIndex = 13
        '
        'DtpSegundaFecha
        '
        Me.DtpSegundaFecha.Location = New System.Drawing.Point(99, 36)
        Me.DtpSegundaFecha.Name = "DtpSegundaFecha"
        Me.DtpSegundaFecha.Size = New System.Drawing.Size(200, 20)
        Me.DtpSegundaFecha.TabIndex = 14
        '
        'ReporteVentaParametro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 749)
        Me.Controls.Add(Me.DtpSegundaFecha)
        Me.Controls.Add(Me.DtpPrimerFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ReporteVentaParametro"
        Me.Text = "Reporte de las Ventas con Intervalo de Fecha"
        CType(Me.SelectVentaFechaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BazarRoxana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SelectVentaFechaBindingSource As BindingSource
    Friend WithEvents BazarRoxana As BazarRoxana
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SelectVentaFechaTableAdapter As BazarRoxanaTableAdapters.SelectVentaFechaTableAdapter
    Friend WithEvents DtpPrimerFecha As DateTimePicker
    Friend WithEvents DtpSegundaFecha As DateTimePicker
End Class
