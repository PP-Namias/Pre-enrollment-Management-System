<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserInfo
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserInfo))
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PicID = New System.Windows.Forms.PictureBox()
        Me.EmailID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.PlaceOfBirth = New System.Windows.Forms.Label()
        Me.DateOfBirth = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Status = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.label1.Location = New System.Drawing.Point(23, 60)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(132, 24)
        Me.label1.TabIndex = 112
        Me.label1.Text = "Your Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PicID)
        Me.GroupBox2.Location = New System.Drawing.Point(493, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(194, 200)
        Me.GroupBox2.TabIndex = 111
        Me.GroupBox2.TabStop = False
        '
        'PicID
        '
        Me.PicID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicID.Image = CType(resources.GetObject("PicID.Image"), System.Drawing.Image)
        Me.PicID.Location = New System.Drawing.Point(7, 12)
        Me.PicID.Name = "PicID"
        Me.PicID.Size = New System.Drawing.Size(180, 180)
        Me.PicID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicID.TabIndex = 11
        Me.PicID.TabStop = False
        '
        'EmailID
        '
        Me.EmailID.AutoSize = True
        Me.EmailID.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailID.ForeColor = System.Drawing.Color.Navy
        Me.EmailID.Location = New System.Drawing.Point(177, 135)
        Me.EmailID.Name = "EmailID"
        Me.EmailID.Size = New System.Drawing.Size(80, 22)
        Me.EmailID.TabIndex = 121
        Me.EmailID.Text = "Email ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 24)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Email ID:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.MediumVioletRed
        Me.LinkLabel1.Location = New System.Drawing.Point(23, 234)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(151, 21)
        Me.LinkLabel1.TabIndex = 119
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Change Password"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.DisabledLinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.MediumVioletRed
        Me.LinkLabel2.Location = New System.Drawing.Point(23, 215)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(109, 21)
        Me.LinkLabel2.TabIndex = 118
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Change Info"
        Me.LinkLabel2.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'PlaceOfBirth
        '
        Me.PlaceOfBirth.AutoSize = True
        Me.PlaceOfBirth.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaceOfBirth.ForeColor = System.Drawing.Color.Navy
        Me.PlaceOfBirth.Location = New System.Drawing.Point(177, 110)
        Me.PlaceOfBirth.Name = "PlaceOfBirth"
        Me.PlaceOfBirth.Size = New System.Drawing.Size(128, 22)
        Me.PlaceOfBirth.TabIndex = 117
        Me.PlaceOfBirth.Text = "Place of Birth"
        '
        'DateOfBirth
        '
        Me.DateOfBirth.AutoSize = True
        Me.DateOfBirth.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOfBirth.ForeColor = System.Drawing.Color.Navy
        Me.DateOfBirth.Location = New System.Drawing.Point(177, 85)
        Me.DateOfBirth.Name = "DateOfBirth"
        Me.DateOfBirth.Size = New System.Drawing.Size(123, 22)
        Me.DateOfBirth.TabIndex = 116
        Me.DateOfBirth.Text = "Date of Birth"
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.Color.Navy
        Me.Username.Location = New System.Drawing.Point(177, 60)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(98, 22)
        Me.Username.TabIndex = 115
        Me.Username.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 24)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "Place of Birth:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 24)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Date of Birth:"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel3.DisabledLinkColor = System.Drawing.Color.Black
        Me.LinkLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel3.LinkColor = System.Drawing.Color.MediumVioletRed
        Me.LinkLabel3.Location = New System.Drawing.Point(23, 253)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(108, 21)
        Me.LinkLabel3.TabIndex = 122
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Generate ID"
        Me.LinkLabel3.Visible = False
        Me.LinkLabel3.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.ForeColor = System.Drawing.Color.Navy
        Me.Status.Location = New System.Drawing.Point(177, 160)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(65, 22)
        Me.Status.TabIndex = 124
        Me.Status.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 24)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "Status:"
        '
        'UserInfo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(710, 295)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.EmailID)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.PlaceOfBirth)
        Me.Controls.Add(Me.DateOfBirth)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "UserInfo"
        Me.Resizable = False
        Me.Text = "User Information"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PicID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PicID As System.Windows.Forms.PictureBox
    Friend WithEvents EmailID As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Private WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents PlaceOfBirth As System.Windows.Forms.Label
    Friend WithEvents DateOfBirth As System.Windows.Forms.Label
    Friend WithEvents Username As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Status As Label
    Private WithEvents Label5 As Label
End Class
