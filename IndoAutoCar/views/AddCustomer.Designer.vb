<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCustomer))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSave = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNoKTP = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAddress = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPhone = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtPhone)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtNoKTP)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 411)
        Me.Panel1.TabIndex = 1
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
        Me.btnSave.Location = New System.Drawing.Point(49, 333)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(500, 45)
        Me.btnSave.TabIndex = 85
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(49, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 23)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "No. KTP"
        '
        'txtNoKTP
        '
        Me.txtNoKTP.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtNoKTP.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtNoKTP.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtNoKTP.BorderThickness = 1
        Me.txtNoKTP.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNoKTP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoKTP.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtNoKTP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNoKTP.isPassword = False
        Me.txtNoKTP.Location = New System.Drawing.Point(49, 60)
        Me.txtNoKTP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoKTP.MaxLength = 32767
        Me.txtNoKTP.Name = "txtNoKTP"
        Me.txtNoKTP.Size = New System.Drawing.Size(500, 35)
        Me.txtNoKTP.TabIndex = 81
        Me.txtNoKTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(49, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 23)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Nama"
        '
        'txtName
        '
        Me.txtName.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtName.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtName.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtName.BorderThickness = 1
        Me.txtName.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtName.isPassword = False
        Me.txtName.Location = New System.Drawing.Point(49, 126)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.MaxLength = 32767
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(500, 35)
        Me.txtName.TabIndex = 86
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(49, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 23)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Alamat"
        '
        'txtAddress
        '
        Me.txtAddress.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtAddress.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtAddress.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtAddress.BorderThickness = 1
        Me.txtAddress.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAddress.isPassword = False
        Me.txtAddress.Location = New System.Drawing.Point(49, 192)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.MaxLength = 32767
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(500, 66)
        Me.txtAddress.TabIndex = 88
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(49, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 23)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Telepon"
        '
        'txtPhone
        '
        Me.txtPhone.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtPhone.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtPhone.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtPhone.BorderThickness = 1
        Me.txtPhone.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhone.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtPhone.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPhone.isPassword = False
        Me.txtPhone.Location = New System.Drawing.Point(49, 289)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhone.MaxLength = 32767
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(500, 35)
        Me.txtPhone.TabIndex = 90
        Me.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'AddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 411)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddCustomer"
        Me.Text = "AddCustomer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNoKTP As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
