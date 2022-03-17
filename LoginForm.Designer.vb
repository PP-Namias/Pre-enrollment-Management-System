<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtTimeIn = New System.Windows.Forms.TextBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.dtpLoginDate = New System.Windows.Forms.DateTimePicker()
        Me.picHelp1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbFormState = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AdminForgetPassword = New System.Windows.Forms.LinkLabel()
        Me.btnAdminCancel = New System.Windows.Forms.Button()
        Me.AdminLabel1 = New System.Windows.Forms.Label()
        Me.btnAdminLogin = New System.Windows.Forms.Button()
        Me.txtAdminPassword = New System.Windows.Forms.TextBox()
        Me.txtAdminUsername = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.picHelp2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TeacherForgetPassword = New System.Windows.Forms.LinkLabel()
        Me.lblAttempt = New System.Windows.Forms.Label()
        Me.txtTeacherUsername = New System.Windows.Forms.TextBox()
        Me.btnTeacherCancel = New System.Windows.Forms.Button()
        Me.txtTeacherPassword = New System.Windows.Forms.TextBox()
        Me.btnTeacherLogin = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.picHelp3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnEnterAsGuest = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.picHelp1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.picHelp2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.picHelp3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 22)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1200, 708)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.txtTimeIn)
        Me.TabPage1.Controls.Add(Me.txtRemark)
        Me.TabPage1.Controls.Add(Me.txtPosition)
        Me.TabPage1.Controls.Add(Me.txtUsername)
        Me.TabPage1.Controls.Add(Me.dtpLoginDate)
        Me.TabPage1.Controls.Add(Me.picHelp1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1192, 678)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Admin"
        '
        'txtTimeIn
        '
        Me.txtTimeIn.Location = New System.Drawing.Point(19, 106)
        Me.txtTimeIn.Name = "txtTimeIn"
        Me.txtTimeIn.Size = New System.Drawing.Size(114, 23)
        Me.txtTimeIn.TabIndex = 13
        Me.txtTimeIn.Visible = False
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(19, 77)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(114, 23)
        Me.txtRemark.TabIndex = 12
        Me.txtRemark.Text = "No Logout"
        Me.txtRemark.Visible = False
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(19, 48)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(114, 23)
        Me.txtPosition.TabIndex = 10
        Me.txtPosition.Text = "Guest"
        Me.txtPosition.Visible = False
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(19, 19)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(114, 23)
        Me.txtUsername.TabIndex = 8
        Me.txtUsername.Text = "Guest"
        Me.txtUsername.Visible = False
        '
        'dtpLoginDate
        '
        Me.dtpLoginDate.Enabled = False
        Me.dtpLoginDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLoginDate.Location = New System.Drawing.Point(-126, 3)
        Me.dtpLoginDate.Name = "dtpLoginDate"
        Me.dtpLoginDate.Size = New System.Drawing.Size(114, 23)
        Me.dtpLoginDate.TabIndex = 7
        '
        'picHelp1
        '
        Me.picHelp1.BackColor = System.Drawing.Color.Transparent
        Me.picHelp1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picHelp1.Image = CType(resources.GetObject("picHelp1.Image"), System.Drawing.Image)
        Me.picHelp1.Location = New System.Drawing.Point(1154, 6)
        Me.picHelp1.Name = "picHelp1"
        Me.picHelp1.Size = New System.Drawing.Size(30, 30)
        Me.picHelp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHelp1.TabIndex = 1
        Me.picHelp1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmbFormState)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.AdminForgetPassword)
        Me.GroupBox2.Controls.Add(Me.btnAdminCancel)
        Me.GroupBox2.Controls.Add(Me.AdminLabel1)
        Me.GroupBox2.Controls.Add(Me.btnAdminLogin)
        Me.GroupBox2.Controls.Add(Me.txtAdminPassword)
        Me.GroupBox2.Controls.Add(Me.txtAdminUsername)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(200, 150)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(800, 400)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(332, 150)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 24)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Login Admin"
        '
        'cmbFormState
        '
        Me.cmbFormState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbFormState.FormattingEnabled = True
        Me.cmbFormState.Items.AddRange(New Object() {"Admin", "User"})
        Me.cmbFormState.Location = New System.Drawing.Point(7, 131)
        Me.cmbFormState.Name = "cmbFormState"
        Me.cmbFormState.Size = New System.Drawing.Size(16, 23)
        Me.cmbFormState.TabIndex = 25
        Me.cmbFormState.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 125)
        Me.Panel1.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(112, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(688, 51)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Pre-enrollment Management System"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(112, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(688, 62)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Young Achievers` School of Caloocan, Inc."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(243, 220)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 24)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Password:"
        '
        'AdminForgetPassword
        '
        Me.AdminForgetPassword.AutoSize = True
        Me.AdminForgetPassword.BackColor = System.Drawing.Color.Transparent
        Me.AdminForgetPassword.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminForgetPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AdminForgetPassword.LinkColor = System.Drawing.Color.RoyalBlue
        Me.AdminForgetPassword.Location = New System.Drawing.Point(350, 310)
        Me.AdminForgetPassword.Name = "AdminForgetPassword"
        Me.AdminForgetPassword.Size = New System.Drawing.Size(96, 14)
        Me.AdminForgetPassword.TabIndex = 4
        Me.AdminForgetPassword.TabStop = True
        Me.AdminForgetPassword.Text = "Forget Password"
        Me.AdminForgetPassword.Visible = False
        Me.AdminForgetPassword.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'btnAdminCancel
        '
        Me.btnAdminCancel.BackColor = System.Drawing.Color.Salmon
        Me.btnAdminCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminCancel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminCancel.ForeColor = System.Drawing.Color.White
        Me.btnAdminCancel.Image = CType(resources.GetObject("btnAdminCancel.Image"), System.Drawing.Image)
        Me.btnAdminCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdminCancel.Location = New System.Drawing.Point(405, 266)
        Me.btnAdminCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminCancel.Name = "btnAdminCancel"
        Me.btnAdminCancel.Size = New System.Drawing.Size(117, 40)
        Me.btnAdminCancel.TabIndex = 3
        Me.btnAdminCancel.Text = "&Cancel"
        Me.btnAdminCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdminCancel.UseVisualStyleBackColor = False
        '
        'AdminLabel1
        '
        Me.AdminLabel1.AutoSize = True
        Me.AdminLabel1.BackColor = System.Drawing.Color.Transparent
        Me.AdminLabel1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminLabel1.ForeColor = System.Drawing.Color.Black
        Me.AdminLabel1.Location = New System.Drawing.Point(243, 189)
        Me.AdminLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AdminLabel1.Name = "AdminLabel1"
        Me.AdminLabel1.Size = New System.Drawing.Size(118, 24)
        Me.AdminLabel1.TabIndex = 15
        Me.AdminLabel1.Text = "Username:"
        '
        'btnAdminLogin
        '
        Me.btnAdminLogin.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminLogin.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminLogin.ForeColor = System.Drawing.Color.White
        Me.btnAdminLogin.Image = CType(resources.GetObject("btnAdminLogin.Image"), System.Drawing.Image)
        Me.btnAdminLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdminLogin.Location = New System.Drawing.Point(280, 266)
        Me.btnAdminLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminLogin.Name = "btnAdminLogin"
        Me.btnAdminLogin.Size = New System.Drawing.Size(117, 40)
        Me.btnAdminLogin.TabIndex = 2
        Me.btnAdminLogin.Text = "   &Login"
        Me.btnAdminLogin.UseVisualStyleBackColor = False
        '
        'txtAdminPassword
        '
        Me.txtAdminPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdminPassword.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminPassword.Location = New System.Drawing.Point(369, 220)
        Me.txtAdminPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdminPassword.Name = "txtAdminPassword"
        Me.txtAdminPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAdminPassword.Size = New System.Drawing.Size(200, 26)
        Me.txtAdminPassword.TabIndex = 1
        '
        'txtAdminUsername
        '
        Me.txtAdminUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdminUsername.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminUsername.Location = New System.Drawing.Point(369, 189)
        Me.txtAdminUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdminUsername.Name = "txtAdminUsername"
        Me.txtAdminUsername.Size = New System.Drawing.Size(200, 26)
        Me.txtAdminUsername.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.picHelp2)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1192, 678)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Teacher"
        '
        'picHelp2
        '
        Me.picHelp2.BackColor = System.Drawing.Color.Transparent
        Me.picHelp2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picHelp2.Image = CType(resources.GetObject("picHelp2.Image"), System.Drawing.Image)
        Me.picHelp2.Location = New System.Drawing.Point(1154, 6)
        Me.picHelp2.Name = "picHelp2"
        Me.picHelp2.Size = New System.Drawing.Size(30, 30)
        Me.picHelp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHelp2.TabIndex = 2
        Me.picHelp2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TeacherForgetPassword)
        Me.GroupBox3.Controls.Add(Me.lblAttempt)
        Me.GroupBox3.Controls.Add(Me.txtTeacherUsername)
        Me.GroupBox3.Controls.Add(Me.btnTeacherCancel)
        Me.GroupBox3.Controls.Add(Me.txtTeacherPassword)
        Me.GroupBox3.Controls.Add(Me.btnTeacherLogin)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(200, 150)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(800, 400)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(324, 150)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 24)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "Login Teacher"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(243, 220)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 24)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Password:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 125)
        Me.Panel2.TabIndex = 24
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(243, 189)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 24)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Username:"
        '
        'TeacherForgetPassword
        '
        Me.TeacherForgetPassword.AutoSize = True
        Me.TeacherForgetPassword.BackColor = System.Drawing.Color.Transparent
        Me.TeacherForgetPassword.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherForgetPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.TeacherForgetPassword.LinkColor = System.Drawing.Color.RoyalBlue
        Me.TeacherForgetPassword.Location = New System.Drawing.Point(350, 310)
        Me.TeacherForgetPassword.Name = "TeacherForgetPassword"
        Me.TeacherForgetPassword.Size = New System.Drawing.Size(96, 14)
        Me.TeacherForgetPassword.TabIndex = 4
        Me.TeacherForgetPassword.TabStop = True
        Me.TeacherForgetPassword.Text = "Forget Password"
        Me.TeacherForgetPassword.Visible = False
        Me.TeacherForgetPassword.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'lblAttempt
        '
        Me.lblAttempt.AutoSize = True
        Me.lblAttempt.BackColor = System.Drawing.Color.Transparent
        Me.lblAttempt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttempt.ForeColor = System.Drawing.Color.White
        Me.lblAttempt.Location = New System.Drawing.Point(383, 330)
        Me.lblAttempt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAttempt.Name = "lblAttempt"
        Me.lblAttempt.Size = New System.Drawing.Size(0, 19)
        Me.lblAttempt.TabIndex = 90
        '
        'txtTeacherUsername
        '
        Me.txtTeacherUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTeacherUsername.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeacherUsername.Location = New System.Drawing.Point(369, 189)
        Me.txtTeacherUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTeacherUsername.Name = "txtTeacherUsername"
        Me.txtTeacherUsername.Size = New System.Drawing.Size(200, 26)
        Me.txtTeacherUsername.TabIndex = 0
        '
        'btnTeacherCancel
        '
        Me.btnTeacherCancel.BackColor = System.Drawing.Color.Salmon
        Me.btnTeacherCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeacherCancel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeacherCancel.ForeColor = System.Drawing.Color.White
        Me.btnTeacherCancel.Image = CType(resources.GetObject("btnTeacherCancel.Image"), System.Drawing.Image)
        Me.btnTeacherCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTeacherCancel.Location = New System.Drawing.Point(405, 266)
        Me.btnTeacherCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTeacherCancel.Name = "btnTeacherCancel"
        Me.btnTeacherCancel.Size = New System.Drawing.Size(117, 40)
        Me.btnTeacherCancel.TabIndex = 3
        Me.btnTeacherCancel.Text = "&Cancel"
        Me.btnTeacherCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTeacherCancel.UseVisualStyleBackColor = False
        '
        'txtTeacherPassword
        '
        Me.txtTeacherPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTeacherPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTeacherPassword.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeacherPassword.Location = New System.Drawing.Point(369, 220)
        Me.txtTeacherPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTeacherPassword.Name = "txtTeacherPassword"
        Me.txtTeacherPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtTeacherPassword.Size = New System.Drawing.Size(200, 26)
        Me.txtTeacherPassword.TabIndex = 1
        '
        'btnTeacherLogin
        '
        Me.btnTeacherLogin.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnTeacherLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeacherLogin.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeacherLogin.ForeColor = System.Drawing.Color.White
        Me.btnTeacherLogin.Image = CType(resources.GetObject("btnTeacherLogin.Image"), System.Drawing.Image)
        Me.btnTeacherLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTeacherLogin.Location = New System.Drawing.Point(280, 266)
        Me.btnTeacherLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTeacherLogin.Name = "btnTeacherLogin"
        Me.btnTeacherLogin.Size = New System.Drawing.Size(117, 40)
        Me.btnTeacherLogin.TabIndex = 2
        Me.btnTeacherLogin.Text = "   &Login"
        Me.btnTeacherLogin.UseVisualStyleBackColor = False
        '
        'TabPage4
        '
        Me.TabPage4.BackgroundImage = CType(resources.GetObject("TabPage4.BackgroundImage"), System.Drawing.Image)
        Me.TabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage4.Controls.Add(Me.picHelp3)
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1192, 678)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Guest"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'picHelp3
        '
        Me.picHelp3.BackColor = System.Drawing.Color.Transparent
        Me.picHelp3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picHelp3.Image = CType(resources.GetObject("picHelp3.Image"), System.Drawing.Image)
        Me.picHelp3.Location = New System.Drawing.Point(1154, 6)
        Me.picHelp3.Name = "picHelp3"
        Me.picHelp3.Size = New System.Drawing.Size(30, 30)
        Me.picHelp3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHelp3.TabIndex = 3
        Me.picHelp3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.btnEnterAsGuest)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Panel4)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(200, 150)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(800, 400)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'btnEnterAsGuest
        '
        Me.btnEnterAsGuest.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEnterAsGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnterAsGuest.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterAsGuest.ForeColor = System.Drawing.Color.White
        Me.btnEnterAsGuest.Location = New System.Drawing.Point(280, 229)
        Me.btnEnterAsGuest.Name = "btnEnterAsGuest"
        Me.btnEnterAsGuest.Size = New System.Drawing.Size(240, 46)
        Me.btnEnterAsGuest.TabIndex = 0
        Me.btnEnterAsGuest.Text = "Enter as a Guest"
        Me.btnEnterAsGuest.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(237, 164)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(326, 31)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Enter as a Guest to enrolll"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(800, 125)
        Me.Panel4.TabIndex = 24
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox4.TabIndex = 23
        Me.PictureBox4.TabStop = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(112, 74)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(688, 51)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Pre-enrollment Management System"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(112, 12)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(688, 62)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Young Achievers` School of Caloocan, Inc."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(112, 74)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(688, 51)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Pre-enrollment Management System"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(112, 12)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(688, 62)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Young Achievers` School of Caloocan, Inc."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoginForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1183, 730)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.Resizable = False
        Me.Text = "Login Form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.picHelp1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.picHelp2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.picHelp3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Private WithEvents AdminForgetPassword As LinkLabel
    Friend WithEvents btnAdminCancel As Button
    Friend WithEvents AdminLabel1 As Label
    Friend WithEvents btnAdminLogin As Button
    Friend WithEvents txtAdminPassword As TextBox
    Friend WithEvents txtAdminUsername As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Private WithEvents TeacherForgetPassword As LinkLabel
    Friend WithEvents lblAttempt As Label
    Friend WithEvents txtTeacherUsername As TextBox
    Friend WithEvents btnTeacherCancel As Button
    Friend WithEvents txtTeacherPassword As TextBox
    Friend WithEvents btnTeacherLogin As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnEnterAsGuest As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Public WithEvents cmbFormState As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents picHelp1 As PictureBox
    Friend WithEvents picHelp2 As PictureBox
    Friend WithEvents picHelp3 As PictureBox
    Friend WithEvents dtpLoginDate As DateTimePicker
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents txtTimeIn As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
