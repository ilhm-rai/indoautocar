<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCarRent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCarRent))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpRent = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLongRent = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCustomer = New System.Windows.Forms.ComboBox()
        Me.TpelangganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IndoautocarDataSet = New IndoAutoCar.indoautocarDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbCar = New System.Windows.Forms.ComboBox()
        Me.TmobilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_mobilTableAdapter = New IndoAutoCar.indoautocarDataSetTableAdapters.t_mobilTableAdapter()
        Me.T_pelangganTableAdapter = New IndoAutoCar.indoautocarDataSetTableAdapters.t_pelangganTableAdapter()
        Me.btnSave = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtIdRental = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Panel1.SuspendLayout()
        CType(Me.TpelangganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IndoautocarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TmobilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtIdRental)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dtpRent)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtLongRent)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbCustomer)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbCar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 361)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(47, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 23)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Tanggal Rental"
        '
        'dtpRent
        '
        Me.dtpRent.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.dtpRent.Location = New System.Drawing.Point(51, 246)
        Me.dtpRent.Name = "dtpRent"
        Me.dtpRent.Size = New System.Drawing.Size(500, 27)
        Me.dtpRent.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(47, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 23)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Lama Rental"
        '
        'txtLongRent
        '
        Me.txtLongRent.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtLongRent.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtLongRent.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtLongRent.BorderThickness = 1
        Me.txtLongRent.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtLongRent.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLongRent.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtLongRent.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLongRent.isPassword = False
        Me.txtLongRent.Location = New System.Drawing.Point(51, 181)
        Me.txtLongRent.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLongRent.MaxLength = 32767
        Me.txtLongRent.Name = "txtLongRent"
        Me.txtLongRent.Size = New System.Drawing.Size(500, 35)
        Me.txtLongRent.TabIndex = 77
        Me.txtLongRent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(47, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Pelanggan"
        '
        'cbCustomer
        '
        Me.cbCustomer.DataSource = Me.TpelangganBindingSource
        Me.cbCustomer.DisplayMember = "no_ktp"
        Me.cbCustomer.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCustomer.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbCustomer.FormattingEnabled = True
        Me.cbCustomer.Location = New System.Drawing.Point(51, 120)
        Me.cbCustomer.Name = "cbCustomer"
        Me.cbCustomer.Size = New System.Drawing.Size(500, 31)
        Me.cbCustomer.TabIndex = 75
        Me.cbCustomer.ValueMember = "no_ktp"
        '
        'TpelangganBindingSource
        '
        Me.TpelangganBindingSource.DataMember = "t_pelanggan"
        Me.TpelangganBindingSource.DataSource = Me.IndoautocarDataSet
        '
        'IndoautocarDataSet
        '
        Me.IndoautocarDataSet.DataSetName = "indoautocarDataSet"
        Me.IndoautocarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(47, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 23)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Mobil"
        '
        'cbCar
        '
        Me.cbCar.DataSource = Me.TmobilBindingSource
        Me.cbCar.DisplayMember = "nama_mobil"
        Me.cbCar.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbCar.FormattingEnabled = True
        Me.cbCar.Location = New System.Drawing.Point(51, 60)
        Me.cbCar.Name = "cbCar"
        Me.cbCar.Size = New System.Drawing.Size(500, 31)
        Me.cbCar.TabIndex = 73
        Me.cbCar.ValueMember = "no_plat"
        '
        'TmobilBindingSource
        '
        Me.TmobilBindingSource.DataMember = "t_mobil"
        Me.TmobilBindingSource.DataSource = Me.IndoautocarDataSet
        '
        'T_mobilTableAdapter
        '
        Me.T_mobilTableAdapter.ClearBeforeFill = True
        '
        'T_pelangganTableAdapter
        '
        Me.T_pelangganTableAdapter.ClearBeforeFill = True
        '
        'btnSave
        '
        Me.btnSave.ActiveBorderThickness = 1
        Me.btnSave.ActiveCornerRadius = 5
        Me.btnSave.ActiveFillColor = System.Drawing.Color.CornflowerBlue
        Me.btnSave.ActiveForecolor = System.Drawing.Color.White
        Me.btnSave.ActiveLineColor = System.Drawing.Color.CornflowerBlue
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.ButtonText = "SIMPAN"
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnSave.IdleBorderThickness = 1
        Me.btnSave.IdleCornerRadius = 5
        Me.btnSave.IdleFillColor = System.Drawing.Color.SteelBlue
        Me.btnSave.IdleForecolor = System.Drawing.Color.White
        Me.btnSave.IdleLineColor = System.Drawing.Color.SteelBlue
        Me.btnSave.Location = New System.Drawing.Point(51, 281)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(500, 45)
        Me.btnSave.TabIndex = 86
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIdRental
        '
        Me.txtIdRental.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtIdRental.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtIdRental.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtIdRental.BorderThickness = 1
        Me.txtIdRental.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdRental.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdRental.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtIdRental.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIdRental.isPassword = False
        Me.txtIdRental.Location = New System.Drawing.Point(387, 18)
        Me.txtIdRental.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdRental.MaxLength = 32767
        Me.txtIdRental.Name = "txtIdRental"
        Me.txtIdRental.Size = New System.Drawing.Size(164, 35)
        Me.txtIdRental.TabIndex = 87
        Me.txtIdRental.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'AddCarRent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 361)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddCarRent"
        Me.Text = "AddCarRent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TpelangganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IndoautocarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TmobilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbCar As System.Windows.Forms.ComboBox
    Friend WithEvents IndoautocarDataSet As IndoAutoCar.indoautocarDataSet
    Friend WithEvents TmobilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_mobilTableAdapter As IndoAutoCar.indoautocarDataSetTableAdapters.t_mobilTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents TpelangganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_pelangganTableAdapter As IndoAutoCar.indoautocarDataSetTableAdapters.t_pelangganTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpRent As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLongRent As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtIdRental As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
