<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTypeCar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddTypeCar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtIdTypeCar = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTypeCar = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnSave = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtTypeCar)
        Me.Panel1.Controls.Add(Me.txtIdTypeCar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 261)
        Me.Panel1.TabIndex = 0
        '
        'txtIdTypeCar
        '
        Me.txtIdTypeCar.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtIdTypeCar.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtIdTypeCar.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtIdTypeCar.BorderThickness = 1
        Me.txtIdTypeCar.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdTypeCar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdTypeCar.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtIdTypeCar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIdTypeCar.isPassword = False
        Me.txtIdTypeCar.Location = New System.Drawing.Point(411, 56)
        Me.txtIdTypeCar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdTypeCar.MaxLength = 32767
        Me.txtIdTypeCar.Name = "txtIdTypeCar"
        Me.txtIdTypeCar.Size = New System.Drawing.Size(140, 35)
        Me.txtIdTypeCar.TabIndex = 50
        Me.txtIdTypeCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(51, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 23)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Jenis Mobil"
        '
        'txtTypeCar
        '
        Me.txtTypeCar.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtTypeCar.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtTypeCar.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtTypeCar.BorderThickness = 1
        Me.txtTypeCar.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTypeCar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTypeCar.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtTypeCar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTypeCar.isPassword = False
        Me.txtTypeCar.Location = New System.Drawing.Point(51, 99)
        Me.txtTypeCar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTypeCar.MaxLength = 32767
        Me.txtTypeCar.Name = "txtTypeCar"
        Me.txtTypeCar.Size = New System.Drawing.Size(500, 35)
        Me.txtTypeCar.TabIndex = 52
        Me.txtTypeCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.btnSave.Location = New System.Drawing.Point(51, 143)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(500, 45)
        Me.btnSave.TabIndex = 86
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddTypeCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 261)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddTypeCar"
        Me.Text = "AddTypeCar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtIdTypeCar As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTypeCar As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuThinButton2
End Class
