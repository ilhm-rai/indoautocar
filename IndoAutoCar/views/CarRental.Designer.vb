﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarRental
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CarRental))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TanngalRentalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoPlatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaMobilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaRentalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoKTPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaPelangganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoHPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LamaRentalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalBayarRentalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdRentalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TviewrentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IndoautocarDataSet = New IndoAutoCar.indoautocarDataSet()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.T_view_rentTableAdapter = New IndoAutoCar.indoautocarDataSetTableAdapters.t_view_rentTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TviewrentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IndoautocarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TanngalRentalDataGridViewTextBoxColumn, Me.NoPlatDataGridViewTextBoxColumn, Me.NamaMobilDataGridViewTextBoxColumn, Me.HargaRentalDataGridViewTextBoxColumn, Me.NoKTPDataGridViewTextBoxColumn, Me.NamaPelangganDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.NoHPDataGridViewTextBoxColumn, Me.LamaRentalDataGridViewTextBoxColumn, Me.TotalBayarRentalDataGridViewTextBoxColumn, Me.IdRentalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TviewrentBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.LightGray
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1101, 638)
        Me.DataGridView1.TabIndex = 1
        '
        'TanngalRentalDataGridViewTextBoxColumn
        '
        Me.TanngalRentalDataGridViewTextBoxColumn.DataPropertyName = "Tanngal Rental"
        Me.TanngalRentalDataGridViewTextBoxColumn.HeaderText = "Tanngal Rental"
        Me.TanngalRentalDataGridViewTextBoxColumn.Name = "TanngalRentalDataGridViewTextBoxColumn"
        Me.TanngalRentalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoPlatDataGridViewTextBoxColumn
        '
        Me.NoPlatDataGridViewTextBoxColumn.DataPropertyName = "No Plat"
        Me.NoPlatDataGridViewTextBoxColumn.HeaderText = "No Plat"
        Me.NoPlatDataGridViewTextBoxColumn.Name = "NoPlatDataGridViewTextBoxColumn"
        Me.NoPlatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaMobilDataGridViewTextBoxColumn
        '
        Me.NamaMobilDataGridViewTextBoxColumn.DataPropertyName = "Nama Mobil"
        Me.NamaMobilDataGridViewTextBoxColumn.HeaderText = "Nama Mobil"
        Me.NamaMobilDataGridViewTextBoxColumn.Name = "NamaMobilDataGridViewTextBoxColumn"
        Me.NamaMobilDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HargaRentalDataGridViewTextBoxColumn
        '
        Me.HargaRentalDataGridViewTextBoxColumn.DataPropertyName = "Harga Rental"
        Me.HargaRentalDataGridViewTextBoxColumn.HeaderText = "Harga Rental"
        Me.HargaRentalDataGridViewTextBoxColumn.Name = "HargaRentalDataGridViewTextBoxColumn"
        Me.HargaRentalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoKTPDataGridViewTextBoxColumn
        '
        Me.NoKTPDataGridViewTextBoxColumn.DataPropertyName = "No KTP"
        Me.NoKTPDataGridViewTextBoxColumn.HeaderText = "No KTP"
        Me.NoKTPDataGridViewTextBoxColumn.Name = "NoKTPDataGridViewTextBoxColumn"
        Me.NoKTPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaPelangganDataGridViewTextBoxColumn
        '
        Me.NamaPelangganDataGridViewTextBoxColumn.DataPropertyName = "Nama Pelanggan"
        Me.NamaPelangganDataGridViewTextBoxColumn.HeaderText = "Nama Pelanggan"
        Me.NamaPelangganDataGridViewTextBoxColumn.Name = "NamaPelangganDataGridViewTextBoxColumn"
        Me.NamaPelangganDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        Me.AlamatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoHPDataGridViewTextBoxColumn
        '
        Me.NoHPDataGridViewTextBoxColumn.DataPropertyName = "No HP"
        Me.NoHPDataGridViewTextBoxColumn.HeaderText = "No HP"
        Me.NoHPDataGridViewTextBoxColumn.Name = "NoHPDataGridViewTextBoxColumn"
        Me.NoHPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LamaRentalDataGridViewTextBoxColumn
        '
        Me.LamaRentalDataGridViewTextBoxColumn.DataPropertyName = "Lama Rental"
        Me.LamaRentalDataGridViewTextBoxColumn.HeaderText = "Lama Rental"
        Me.LamaRentalDataGridViewTextBoxColumn.Name = "LamaRentalDataGridViewTextBoxColumn"
        Me.LamaRentalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalBayarRentalDataGridViewTextBoxColumn
        '
        Me.TotalBayarRentalDataGridViewTextBoxColumn.DataPropertyName = "Total Bayar Rental"
        Me.TotalBayarRentalDataGridViewTextBoxColumn.HeaderText = "Total Bayar Rental"
        Me.TotalBayarRentalDataGridViewTextBoxColumn.Name = "TotalBayarRentalDataGridViewTextBoxColumn"
        Me.TotalBayarRentalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdRentalDataGridViewTextBoxColumn
        '
        Me.IdRentalDataGridViewTextBoxColumn.DataPropertyName = "Id Rental"
        Me.IdRentalDataGridViewTextBoxColumn.HeaderText = "Id Rental"
        Me.IdRentalDataGridViewTextBoxColumn.Name = "IdRentalDataGridViewTextBoxColumn"
        Me.IdRentalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TviewrentBindingSource
        '
        Me.TviewrentBindingSource.DataMember = "t_view_rent"
        Me.TviewrentBindingSource.DataSource = Me.IndoautocarDataSet
        '
        'IndoautocarDataSet
        '
        Me.IndoautocarDataSet.DataSetName = "indoautocarDataSet"
        Me.IndoautocarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnUpdate
        '
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.Location = New System.Drawing.Point(130, 0)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(130, 60)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Ubah"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.btnReport)
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1101, 60)
        Me.Panel2.TabIndex = 0
        '
        'btnReport
        '
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Image)
        Me.btnReport.Location = New System.Drawing.Point(520, 0)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(130, 60)
        Me.btnReport.TabIndex = 9
        Me.btnReport.Text = "Cetak"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(390, 0)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(130, 60)
        Me.btnRefresh.TabIndex = 8
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(260, 0)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(130, 60)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Hapus"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(0, 0)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(130, 60)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Tambah"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
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
        Me.Panel1.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 60)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1101, 638)
        Me.Panel3.TabIndex = 1
        '
        'T_view_rentTableAdapter
        '
        Me.T_view_rentTableAdapter.ClearBeforeFill = True
        '
        'CarRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CarRental"
        Me.Size = New System.Drawing.Size(1101, 698)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TviewrentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IndoautocarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents TanngalRentalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoPlatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaMobilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaRentalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoKTPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaPelangganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoHPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LamaRentalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalBayarRentalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdRentalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TviewrentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IndoautocarDataSet As IndoAutoCar.indoautocarDataSet
    Friend WithEvents T_view_rentTableAdapter As IndoAutoCar.indoautocarDataSetTableAdapters.t_view_rentTableAdapter

End Class
