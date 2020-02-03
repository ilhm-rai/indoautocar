<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreviewReportRental
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreviewReportRental))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnCarRent = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.indoautocarDataSet = New IndoAutoCar.indoautocarDataSet()
        Me.t_rentalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.t_rentalTableAdapter = New IndoAutoCar.indoautocarDataSetTableAdapters.t_rentalTableAdapter()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.indoautocarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t_rentalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ReportViewer1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 60)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1101, 638)
        Me.Panel3.TabIndex = 1
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.t_rentalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "IndoAutoCar.ReportRental.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1101, 638)
        Me.ReportViewer1.TabIndex = 0
        '
        'btnCarRent
        '
        Me.btnCarRent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCarRent.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCarRent.FlatAppearance.BorderSize = 0
        Me.btnCarRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarRent.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarRent.ForeColor = System.Drawing.Color.White
        Me.btnCarRent.Image = CType(resources.GetObject("btnCarRent.Image"), System.Drawing.Image)
        Me.btnCarRent.Location = New System.Drawing.Point(971, 0)
        Me.btnCarRent.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnCarRent.Name = "btnCarRent"
        Me.btnCarRent.Size = New System.Drawing.Size(130, 60)
        Me.btnCarRent.TabIndex = 9
        Me.btnCarRent.Text = "Kembali"
        Me.btnCarRent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCarRent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCarRent.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.btnCarRent)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1101, 60)
        Me.Panel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1101, 698)
        Me.Panel1.TabIndex = 5
        '
        'indoautocarDataSet
        '
        Me.indoautocarDataSet.DataSetName = "indoautocarDataSet"
        Me.indoautocarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        't_rentalBindingSource
        '
        Me.t_rentalBindingSource.DataMember = "t_rental"
        Me.t_rentalBindingSource.DataSource = Me.indoautocarDataSet
        '
        't_rentalTableAdapter
        '
        Me.t_rentalTableAdapter.ClearBeforeFill = True
        '
        'PreviewReportRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PreviewReportRental"
        Me.Size = New System.Drawing.Size(1101, 698)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.indoautocarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t_rentalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnCarRent As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents t_rentalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents indoautocarDataSet As IndoAutoCar.indoautocarDataSet
    Friend WithEvents t_rentalTableAdapter As IndoAutoCar.indoautocarDataSetTableAdapters.t_rentalTableAdapter

End Class
