<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoPlat = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.cbTypeCar = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IndoautocarDataSet = New IndoAutoCar.indoautocarDataSet()
        Me.TjenismobilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_jenis_mobilTableAdapter = New IndoAutoCar.indoautocarDataSetTableAdapters.t_jenis_mobilTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCarName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPabrikan = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtYear = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTenaga = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRentPrice = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnSave = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        CType(Me.IndoautocarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TjenismobilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtRentPrice)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtTenaga)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtYear)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtPabrikan)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtCarName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbTypeCar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNoPlat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 591)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(47, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Plat Nomor"
        '
        'txtNoPlat
        '
        Me.txtNoPlat.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtNoPlat.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtNoPlat.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtNoPlat.BorderThickness = 1
        Me.txtNoPlat.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNoPlat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoPlat.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtNoPlat.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNoPlat.isPassword = False
        Me.txtNoPlat.Location = New System.Drawing.Point(51, 69)
        Me.txtNoPlat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoPlat.MaxLength = 32767
        Me.txtNoPlat.Name = "txtNoPlat"
        Me.txtNoPlat.Size = New System.Drawing.Size(500, 35)
        Me.txtNoPlat.TabIndex = 48
        Me.txtNoPlat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cbTypeCar
        '
        Me.cbTypeCar.DataSource = Me.TjenismobilBindingSource
        Me.cbTypeCar.DisplayMember = "jenis_mobil"
        Me.cbTypeCar.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTypeCar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbTypeCar.FormattingEnabled = True
        Me.cbTypeCar.Location = New System.Drawing.Point(51, 134)
        Me.cbTypeCar.Name = "cbTypeCar"
        Me.cbTypeCar.Size = New System.Drawing.Size(500, 31)
        Me.cbTypeCar.TabIndex = 71
        Me.cbTypeCar.ValueMember = "id_jenis_mobil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(47, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 23)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Jenis Mobil"
        '
        'IndoautocarDataSet
        '
        Me.IndoautocarDataSet.DataSetName = "indoautocarDataSet"
        Me.IndoautocarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TjenismobilBindingSource
        '
        Me.TjenismobilBindingSource.DataMember = "t_jenis_mobil"
        Me.TjenismobilBindingSource.DataSource = Me.IndoautocarDataSet
        '
        'T_jenis_mobilTableAdapter
        '
        Me.T_jenis_mobilTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(47, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 23)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Nama Mobil"
        '
        'txtCarName
        '
        Me.txtCarName.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtCarName.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtCarName.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtCarName.BorderThickness = 1
        Me.txtCarName.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCarName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCarName.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtCarName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCarName.isPassword = False
        Me.txtCarName.Location = New System.Drawing.Point(51, 195)
        Me.txtCarName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCarName.MaxLength = 32767
        Me.txtCarName.Name = "txtCarName"
        Me.txtCarName.Size = New System.Drawing.Size(500, 35)
        Me.txtCarName.TabIndex = 73
        Me.txtCarName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(47, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 23)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Pabrikan"
        '
        'txtPabrikan
        '
        Me.txtPabrikan.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtPabrikan.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtPabrikan.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtPabrikan.BorderThickness = 1
        Me.txtPabrikan.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPabrikan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPabrikan.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtPabrikan.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPabrikan.isPassword = False
        Me.txtPabrikan.Location = New System.Drawing.Point(51, 261)
        Me.txtPabrikan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPabrikan.MaxLength = 32767
        Me.txtPabrikan.Name = "txtPabrikan"
        Me.txtPabrikan.Size = New System.Drawing.Size(500, 35)
        Me.txtPabrikan.TabIndex = 75
        Me.txtPabrikan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(47, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 23)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Tahun"
        '
        'txtYear
        '
        Me.txtYear.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtYear.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtYear.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtYear.BorderThickness = 1
        Me.txtYear.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYear.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtYear.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtYear.isPassword = False
        Me.txtYear.Location = New System.Drawing.Point(51, 327)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYear.MaxLength = 32767
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(500, 35)
        Me.txtYear.TabIndex = 77
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(47, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 23)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Tenaga (cc)"
        '
        'txtTenaga
        '
        Me.txtTenaga.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtTenaga.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtTenaga.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtTenaga.BorderThickness = 1
        Me.txtTenaga.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTenaga.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTenaga.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtTenaga.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTenaga.isPassword = False
        Me.txtTenaga.Location = New System.Drawing.Point(51, 393)
        Me.txtTenaga.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenaga.MaxLength = 32767
        Me.txtTenaga.Name = "txtTenaga"
        Me.txtTenaga.Size = New System.Drawing.Size(500, 35)
        Me.txtTenaga.TabIndex = 79
        Me.txtTenaga.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(47, 432)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 23)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Harga Sewa (Rp)"
        '
        'txtRentPrice
        '
        Me.txtRentPrice.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtRentPrice.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtRentPrice.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtRentPrice.BorderThickness = 1
        Me.txtRentPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtRentPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRentPrice.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtRentPrice.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRentPrice.isPassword = False
        Me.txtRentPrice.Location = New System.Drawing.Point(51, 459)
        Me.txtRentPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRentPrice.MaxLength = 32767
        Me.txtRentPrice.Name = "txtRentPrice"
        Me.txtRentPrice.Size = New System.Drawing.Size(500, 35)
        Me.txtRentPrice.TabIndex = 81
        Me.txtRentPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.btnSave.Location = New System.Drawing.Point(51, 503)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(500, 45)
        Me.btnSave.TabIndex = 85
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 591)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddCar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddCar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IndoautocarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TjenismobilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTypeCar As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoPlat As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents IndoautocarDataSet As IndoAutoCar.indoautocarDataSet
    Friend WithEvents TjenismobilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_jenis_mobilTableAdapter As IndoAutoCar.indoautocarDataSetTableAdapters.t_jenis_mobilTableAdapter
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRentPrice As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTenaga As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtYear As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPabrikan As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCarName As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
