<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.timerTime = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnCars = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.labelIndoAutoCar = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelMainNav = New System.Windows.Forms.Panel()
        Me.labelStatus = New System.Windows.Forms.Label()
        Me.pictureBoxStatus = New System.Windows.Forms.PictureBox()
        Me.labelFullname = New System.Windows.Forms.Label()
        Me.panelLeft = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnTypeCar = New System.Windows.Forms.Button()
        Me.btnCarRent = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.panelControls = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.panelMainNav.SuspendLayout()
        CType(Me.pictureBoxStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLeft.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(11, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "MAIN NAVIGATION"
        '
        'btnCars
        '
        Me.btnCars.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCars.FlatAppearance.BorderSize = 0
        Me.btnCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCars.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCars.ForeColor = System.Drawing.Color.White
        Me.btnCars.Image = CType(resources.GetObject("btnCars.Image"), System.Drawing.Image)
        Me.btnCars.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCars.Location = New System.Drawing.Point(11, 187)
        Me.btnCars.Name = "btnCars"
        Me.btnCars.Size = New System.Drawing.Size(234, 50)
        Me.btnCars.TabIndex = 7
        Me.btnCars.Text = "   Mobil"
        Me.btnCars.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCars.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(11, 131)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(234, 50)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "   Beranda"
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'labelIndoAutoCar
        '
        Me.labelIndoAutoCar.AutoSize = True
        Me.labelIndoAutoCar.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIndoAutoCar.ForeColor = System.Drawing.Color.White
        Me.labelIndoAutoCar.Location = New System.Drawing.Point(22, 9)
        Me.labelIndoAutoCar.Name = "labelIndoAutoCar"
        Me.labelIndoAutoCar.Size = New System.Drawing.Size(201, 42)
        Me.labelIndoAutoCar.TabIndex = 0
        Me.labelIndoAutoCar.Text = "INDO AUTO CAR"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Panel2.Controls.Add(Me.labelIndoAutoCar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(245, 60)
        Me.Panel2.TabIndex = 1
        '
        'panelMainNav
        '
        Me.panelMainNav.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.panelMainNav.Controls.Add(Me.Label4)
        Me.panelMainNav.Location = New System.Drawing.Point(0, 80)
        Me.panelMainNav.Name = "panelMainNav"
        Me.panelMainNav.Size = New System.Drawing.Size(245, 45)
        Me.panelMainNav.TabIndex = 5
        '
        'labelStatus
        '
        Me.labelStatus.AutoSize = True
        Me.labelStatus.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelStatus.ForeColor = System.Drawing.Color.White
        Me.labelStatus.Location = New System.Drawing.Point(26, 40)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(48, 22)
        Me.labelStatus.TabIndex = 4
        Me.labelStatus.Text = "Online"
        Me.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pictureBoxStatus
        '
        Me.pictureBoxStatus.Image = CType(resources.GetObject("pictureBoxStatus.Image"), System.Drawing.Image)
        Me.pictureBoxStatus.Location = New System.Drawing.Point(11, 46)
        Me.pictureBoxStatus.Name = "pictureBoxStatus"
        Me.pictureBoxStatus.Size = New System.Drawing.Size(10, 10)
        Me.pictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBoxStatus.TabIndex = 3
        Me.pictureBoxStatus.TabStop = False
        '
        'labelFullname
        '
        Me.labelFullname.AutoSize = True
        Me.labelFullname.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFullname.ForeColor = System.Drawing.Color.White
        Me.labelFullname.Location = New System.Drawing.Point(11, 13)
        Me.labelFullname.Name = "labelFullname"
        Me.labelFullname.Size = New System.Drawing.Size(141, 26)
        Me.labelFullname.TabIndex = 0
        Me.labelFullname.Text = "RIZKY ARDI ILHAMI"
        Me.labelFullname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelLeft
        '
        Me.panelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.panelLeft.Controls.Add(Me.Button1)
        Me.panelLeft.Controls.Add(Me.btnUsers)
        Me.panelLeft.Controls.Add(Me.btnCustomer)
        Me.panelLeft.Controls.Add(Me.btnTypeCar)
        Me.panelLeft.Controls.Add(Me.btnCarRent)
        Me.panelLeft.Controls.Add(Me.btnCars)
        Me.panelLeft.Controls.Add(Me.btnHome)
        Me.panelLeft.Controls.Add(Me.panelMainNav)
        Me.panelLeft.Controls.Add(Me.labelStatus)
        Me.panelLeft.Controls.Add(Me.pictureBoxStatus)
        Me.panelLeft.Controls.Add(Me.labelFullname)
        Me.panelLeft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelLeft.Location = New System.Drawing.Point(0, 60)
        Me.panelLeft.Name = "panelLeft"
        Me.panelLeft.Size = New System.Drawing.Size(245, 708)
        Me.panelLeft.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(11, 458)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(234, 50)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "   Keluar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsers.FlatAppearance.BorderSize = 0
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.Color.White
        Me.btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), System.Drawing.Image)
        Me.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.Location = New System.Drawing.Point(12, 402)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(234, 50)
        Me.btnUsers.TabIndex = 11
        Me.btnUsers.Text = "   Pengguna"
        Me.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomer.FlatAppearance.BorderSize = 0
        Me.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomer.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.ForeColor = System.Drawing.Color.White
        Me.btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), System.Drawing.Image)
        Me.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomer.Location = New System.Drawing.Point(12, 346)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(234, 50)
        Me.btnCustomer.TabIndex = 10
        Me.btnCustomer.Text = "   Pelanggan"
        Me.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnTypeCar
        '
        Me.btnTypeCar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTypeCar.FlatAppearance.BorderSize = 0
        Me.btnTypeCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTypeCar.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTypeCar.ForeColor = System.Drawing.Color.White
        Me.btnTypeCar.Image = CType(resources.GetObject("btnTypeCar.Image"), System.Drawing.Image)
        Me.btnTypeCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTypeCar.Location = New System.Drawing.Point(12, 290)
        Me.btnTypeCar.Name = "btnTypeCar"
        Me.btnTypeCar.Size = New System.Drawing.Size(234, 50)
        Me.btnTypeCar.TabIndex = 9
        Me.btnTypeCar.Text = "   Tipe Mobil"
        Me.btnTypeCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTypeCar.UseVisualStyleBackColor = True
        '
        'btnCarRent
        '
        Me.btnCarRent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCarRent.FlatAppearance.BorderSize = 0
        Me.btnCarRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarRent.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarRent.ForeColor = System.Drawing.Color.White
        Me.btnCarRent.Image = CType(resources.GetObject("btnCarRent.Image"), System.Drawing.Image)
        Me.btnCarRent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCarRent.Location = New System.Drawing.Point(11, 234)
        Me.btnCarRent.Name = "btnCarRent"
        Me.btnCarRent.Size = New System.Drawing.Size(234, 50)
        Me.btnCarRent.TabIndex = 8
        Me.btnCarRent.Text = "   Rental Mobil"
        Me.btnCarRent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCarRent.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 60)
        Me.Panel1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1306, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 60)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.panelControls)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(245, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1121, 708)
        Me.Panel3.TabIndex = 5
        '
        'panelControls
        '
        Me.panelControls.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelControls.Location = New System.Drawing.Point(10, 10)
        Me.panelControls.Name = "panelControls"
        Me.panelControls.Size = New System.Drawing.Size(1101, 688)
        Me.panelControls.TabIndex = 6
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(10, 698)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1101, 10)
        Me.Panel7.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(1111, 10)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 698)
        Me.Panel6.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(10, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1111, 10)
        Me.Panel5.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 708)
        Me.Panel4.TabIndex = 0
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.panelLeft)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelMainNav.ResumeLayout(False)
        Me.panelMainNav.PerformLayout()
        CType(Me.pictureBoxStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLeft.ResumeLayout(False)
        Me.panelLeft.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents timerTime As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnCars As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents labelIndoAutoCar As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents panelMainNav As System.Windows.Forms.Panel
    Friend WithEvents labelStatus As System.Windows.Forms.Label
    Friend WithEvents pictureBoxStatus As System.Windows.Forms.PictureBox
    Friend WithEvents labelFullname As System.Windows.Forms.Label
    Friend WithEvents panelLeft As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents panelControls As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnTypeCar As System.Windows.Forms.Button
    Friend WithEvents btnCarRent As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
