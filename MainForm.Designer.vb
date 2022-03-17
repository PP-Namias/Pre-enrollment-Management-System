<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UsernameToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel10 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DateToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel11 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimeToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DateStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimeStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLoginHistory = New System.Windows.Forms.Button()
        Me.btnAboutMe = New System.Windows.Forms.Button()
        Me.txtTimeOut = New System.Windows.Forms.TextBox()
        Me.btnPrintID = New System.Windows.Forms.Button()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.btnEnrollmentPortal = New System.Windows.Forms.Button()
        Me.btnStatus = New System.Windows.Forms.Button()
        Me.Username = New System.Windows.Forms.Label()
        Me.IDPicture = New System.Windows.Forms.PictureBox()
        Me.btnEnrollmentDatabase = New System.Windows.Forms.Button()
        Me.btnTeacherDatabase = New System.Windows.Forms.Button()
        Me.AdministratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.AdminDataMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnrollmentDataMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherDataMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SemesterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.GenerateIDToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendanceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox()
        Me.EnrollmentPortalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form137ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentsDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentsGradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintGradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeachersDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateIDToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdminToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnrollmentPortalToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnrollmentDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchoolDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnrollmentPortalToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuestToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnrollmentPortalToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.PicMinimize = New System.Windows.Forms.PictureBox()
        Me.StatusStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.IDPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel9, Me.ToolStripStatusLabel1, Me.UsernameToolStripStatusLabel, Me.ToolStripStatusLabel10, Me.ToolStripStatusLabel4, Me.DateToolStripStatusLabel, Me.ToolStripStatusLabel11, Me.ToolStripStatusLabel7, Me.TimeToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 671)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip.Size = New System.Drawing.Size(1199, 30)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.Stretch = False
        Me.StatusStrip.TabIndex = 18
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel9
        '
        Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        Me.ToolStripStatusLabel9.Size = New System.Drawing.Size(13, 25)
        Me.ToolStripStatusLabel9.Text = "  "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Image = CType(resources.GetObject("ToolStripStatusLabel1.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(131, 25)
        Me.ToolStripStatusLabel1.Text = "Username:"
        '
        'UsernameToolStripStatusLabel
        '
        Me.UsernameToolStripStatusLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameToolStripStatusLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameToolStripStatusLabel.Name = "UsernameToolStripStatusLabel"
        Me.UsernameToolStripStatusLabel.Size = New System.Drawing.Size(65, 25)
        Me.UsernameToolStripStatusLabel.Text = "Guest"
        '
        'ToolStripStatusLabel10
        '
        Me.ToolStripStatusLabel10.Name = "ToolStripStatusLabel10"
        Me.ToolStripStatusLabel10.Size = New System.Drawing.Size(13, 25)
        Me.ToolStripStatusLabel10.Text = "  "
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel4.Image = CType(resources.GetObject("ToolStripStatusLabel4.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(86, 25)
        Me.ToolStripStatusLabel4.Text = "Date:"
        '
        'DateToolStripStatusLabel
        '
        Me.DateToolStripStatusLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateToolStripStatusLabel.ForeColor = System.Drawing.Color.White
        Me.DateToolStripStatusLabel.Name = "DateToolStripStatusLabel"
        Me.DateToolStripStatusLabel.Size = New System.Drawing.Size(0, 25)
        '
        'ToolStripStatusLabel11
        '
        Me.ToolStripStatusLabel11.Name = "ToolStripStatusLabel11"
        Me.ToolStripStatusLabel11.Size = New System.Drawing.Size(13, 25)
        Me.ToolStripStatusLabel11.Text = "  "
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel7.Image = CType(resources.GetObject("ToolStripStatusLabel7.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(80, 25)
        Me.ToolStripStatusLabel7.Text = "Time:"
        '
        'TimeToolStripStatusLabel
        '
        Me.TimeToolStripStatusLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeToolStripStatusLabel.ForeColor = System.Drawing.Color.White
        Me.TimeToolStripStatusLabel.Name = "TimeToolStripStatusLabel"
        Me.TimeToolStripStatusLabel.Size = New System.Drawing.Size(0, 25)
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel3.Image = CType(resources.GetObject("ToolStripStatusLabel3.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripStatusLabel3.Margin = New System.Windows.Forms.Padding(8, 3, 0, 2)
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(65, 25)
        Me.ToolStripStatusLabel3.Text = "Date"
        '
        'DateStatusLabel
        '
        Me.DateStatusLabel.BackColor = System.Drawing.SystemColors.Control
        Me.DateStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateStatusLabel.ForeColor = System.Drawing.Color.Black
        Me.DateStatusLabel.Margin = New System.Windows.Forms.Padding(0, 3, 7, 2)
        Me.DateStatusLabel.Name = "DateStatusLabel"
        Me.DateStatusLabel.Size = New System.Drawing.Size(0, 25)
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel5.Image = CType(resources.GetObject("ToolStripStatusLabel5.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripStatusLabel5.Margin = New System.Windows.Forms.Padding(8, 3, 0, 2)
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(67, 25)
        Me.ToolStripStatusLabel5.Text = "Time"
        '
        'TimeStatusLabel
        '
        Me.TimeStatusLabel.BackColor = System.Drawing.SystemColors.Control
        Me.TimeStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeStatusLabel.ForeColor = System.Drawing.Color.Black
        Me.TimeStatusLabel.Margin = New System.Windows.Forms.Padding(0, 3, 3, 2)
        Me.TimeStatusLabel.Name = "TimeStatusLabel"
        Me.TimeStatusLabel.Size = New System.Drawing.Size(0, 25)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.btnLoginHistory)
        Me.Panel1.Controls.Add(Me.btnAboutMe)
        Me.Panel1.Controls.Add(Me.txtTimeOut)
        Me.Panel1.Controls.Add(Me.btnPrintID)
        Me.Panel1.Controls.Add(Me.txtRemark)
        Me.Panel1.Controls.Add(Me.btnEnrollmentPortal)
        Me.Panel1.Controls.Add(Me.btnStatus)
        Me.Panel1.Controls.Add(Me.Username)
        Me.Panel1.Controls.Add(Me.IDPicture)
        Me.Panel1.Controls.Add(Me.btnEnrollmentDatabase)
        Me.Panel1.Controls.Add(Me.btnTeacherDatabase)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 646)
        Me.Panel1.TabIndex = 23
        '
        'btnLoginHistory
        '
        Me.btnLoginHistory.BackColor = System.Drawing.Color.MediumBlue
        Me.btnLoginHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLoginHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoginHistory.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginHistory.ForeColor = System.Drawing.Color.White
        Me.btnLoginHistory.Image = CType(resources.GetObject("btnLoginHistory.Image"), System.Drawing.Image)
        Me.btnLoginHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoginHistory.Location = New System.Drawing.Point(10, 398)
        Me.btnLoginHistory.Name = "btnLoginHistory"
        Me.btnLoginHistory.Size = New System.Drawing.Size(180, 35)
        Me.btnLoginHistory.TabIndex = 31
        Me.btnLoginHistory.Text = "&Login History"
        Me.btnLoginHistory.UseVisualStyleBackColor = False
        '
        'btnAboutMe
        '
        Me.btnAboutMe.BackColor = System.Drawing.Color.MediumBlue
        Me.btnAboutMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAboutMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAboutMe.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAboutMe.ForeColor = System.Drawing.Color.White
        Me.btnAboutMe.Image = CType(resources.GetObject("btnAboutMe.Image"), System.Drawing.Image)
        Me.btnAboutMe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAboutMe.Location = New System.Drawing.Point(10, 603)
        Me.btnAboutMe.Name = "btnAboutMe"
        Me.btnAboutMe.Size = New System.Drawing.Size(180, 35)
        Me.btnAboutMe.TabIndex = 30
        Me.btnAboutMe.Text = "&About Me"
        Me.btnAboutMe.UseVisualStyleBackColor = False
        '
        'txtTimeOut
        '
        Me.txtTimeOut.Location = New System.Drawing.Point(12, 574)
        Me.txtTimeOut.Name = "txtTimeOut"
        Me.txtTimeOut.Size = New System.Drawing.Size(100, 23)
        Me.txtTimeOut.TabIndex = 29
        Me.txtTimeOut.Visible = False
        '
        'btnPrintID
        '
        Me.btnPrintID.BackColor = System.Drawing.Color.MediumBlue
        Me.btnPrintID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrintID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintID.ForeColor = System.Drawing.Color.White
        Me.btnPrintID.Image = CType(resources.GetObject("btnPrintID.Image"), System.Drawing.Image)
        Me.btnPrintID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrintID.Location = New System.Drawing.Point(10, 439)
        Me.btnPrintID.Name = "btnPrintID"
        Me.btnPrintID.Size = New System.Drawing.Size(180, 35)
        Me.btnPrintID.TabIndex = 28
        Me.btnPrintID.Text = "&Print ID"
        Me.btnPrintID.UseVisualStyleBackColor = False
        Me.btnPrintID.Visible = False
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(12, 547)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(100, 23)
        Me.txtRemark.TabIndex = 29
        Me.txtRemark.Text = "No Remarks"
        Me.txtRemark.Visible = False
        '
        'btnEnrollmentPortal
        '
        Me.btnEnrollmentPortal.BackColor = System.Drawing.Color.MediumBlue
        Me.btnEnrollmentPortal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnrollmentPortal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnrollmentPortal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnrollmentPortal.ForeColor = System.Drawing.Color.White
        Me.btnEnrollmentPortal.Image = CType(resources.GetObject("btnEnrollmentPortal.Image"), System.Drawing.Image)
        Me.btnEnrollmentPortal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnrollmentPortal.Location = New System.Drawing.Point(10, 275)
        Me.btnEnrollmentPortal.Name = "btnEnrollmentPortal"
        Me.btnEnrollmentPortal.Size = New System.Drawing.Size(180, 35)
        Me.btnEnrollmentPortal.TabIndex = 24
        Me.btnEnrollmentPortal.Text = "&Enrollment Portal"
        Me.btnEnrollmentPortal.UseVisualStyleBackColor = False
        '
        'btnStatus
        '
        Me.btnStatus.BackColor = System.Drawing.Color.Navy
        Me.btnStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStatus.Enabled = False
        Me.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatus.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatus.ForeColor = System.Drawing.Color.White
        Me.btnStatus.Location = New System.Drawing.Point(35, 205)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(130, 28)
        Me.btnStatus.TabIndex = 24
        Me.btnStatus.Text = "Guest"
        Me.btnStatus.UseVisualStyleBackColor = False
        '
        'Username
        '
        Me.Username.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Username.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(0, 175)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(200, 27)
        Me.Username.TabIndex = 24
        Me.Username.Text = "Guest"
        Me.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IDPicture
        '
        Me.IDPicture.BackColor = System.Drawing.Color.White
        Me.IDPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IDPicture.Image = CType(resources.GetObject("IDPicture.Image"), System.Drawing.Image)
        Me.IDPicture.Location = New System.Drawing.Point(25, 25)
        Me.IDPicture.Name = "IDPicture"
        Me.IDPicture.Size = New System.Drawing.Size(150, 150)
        Me.IDPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IDPicture.TabIndex = 24
        Me.IDPicture.TabStop = False
        '
        'btnEnrollmentDatabase
        '
        Me.btnEnrollmentDatabase.BackColor = System.Drawing.Color.MediumBlue
        Me.btnEnrollmentDatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnrollmentDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnrollmentDatabase.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnrollmentDatabase.ForeColor = System.Drawing.Color.White
        Me.btnEnrollmentDatabase.Image = CType(resources.GetObject("btnEnrollmentDatabase.Image"), System.Drawing.Image)
        Me.btnEnrollmentDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnrollmentDatabase.Location = New System.Drawing.Point(10, 316)
        Me.btnEnrollmentDatabase.Name = "btnEnrollmentDatabase"
        Me.btnEnrollmentDatabase.Size = New System.Drawing.Size(180, 35)
        Me.btnEnrollmentDatabase.TabIndex = 26
        Me.btnEnrollmentDatabase.Text = "Enrollment &Data"
        Me.btnEnrollmentDatabase.UseVisualStyleBackColor = False
        '
        'btnTeacherDatabase
        '
        Me.btnTeacherDatabase.BackColor = System.Drawing.Color.MediumBlue
        Me.btnTeacherDatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTeacherDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeacherDatabase.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeacherDatabase.ForeColor = System.Drawing.Color.White
        Me.btnTeacherDatabase.Image = CType(resources.GetObject("btnTeacherDatabase.Image"), System.Drawing.Image)
        Me.btnTeacherDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTeacherDatabase.Location = New System.Drawing.Point(10, 357)
        Me.btnTeacherDatabase.Name = "btnTeacherDatabase"
        Me.btnTeacherDatabase.Size = New System.Drawing.Size(180, 35)
        Me.btnTeacherDatabase.TabIndex = 25
        Me.btnTeacherDatabase.Text = "&Teacher Data"
        Me.btnTeacherDatabase.UseVisualStyleBackColor = False
        '
        'AdministratorToolStripMenuItem
        '
        Me.AdministratorToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.AdministratorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.AdminDataMenuItem, Me.EnrollmentDataMenuItem10, Me.TeacherDataMenuItem, Me.ToolStripSeparator2, Me.ToolStripTextBox2, Me.ScheduleToolStripMenuItem, Me.AttendanceToolStripMenuItem, Me.SectionToolStripMenuItem, Me.SemesterToolStripMenuItem, Me.ToolStripSeparator6, Me.ToolStripTextBox3, Me.GenerateIDToolStripMenuItem2, Me.AttendanceToolStripMenuItem1, Me.ToolStripSeparator1, Me.ToolStripTextBox4, Me.EnrollmentPortalToolStripMenuItem, Me.Form137ToolStripMenuItem})
        Me.AdministratorToolStripMenuItem.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdministratorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AdministratorToolStripMenuItem.Name = "AdministratorToolStripMenuItem"
        Me.AdministratorToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.AdministratorToolStripMenuItem.Text = "&Administrator"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BackColor = System.Drawing.Color.White
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.ReadOnly = True
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripTextBox1.Text = "      Database"
        '
        'AdminDataMenuItem
        '
        Me.AdminDataMenuItem.Name = "AdminDataMenuItem"
        Me.AdminDataMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.AdminDataMenuItem.Text = "&Admin Data"
        '
        'EnrollmentDataMenuItem10
        '
        Me.EnrollmentDataMenuItem10.Name = "EnrollmentDataMenuItem10"
        Me.EnrollmentDataMenuItem10.Size = New System.Drawing.Size(193, 22)
        Me.EnrollmentDataMenuItem10.Text = "&Enrollment Data"
        '
        'TeacherDataMenuItem
        '
        Me.TeacherDataMenuItem.Name = "TeacherDataMenuItem"
        Me.TeacherDataMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.TeacherDataMenuItem.Text = "&Teacher Data"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(190, 6)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.BackColor = System.Drawing.Color.White
        Me.ToolStripTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.ReadOnly = True
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripTextBox2.Text = "      Classroom"
        '
        'ScheduleToolStripMenuItem
        '
        Me.ScheduleToolStripMenuItem.Name = "ScheduleToolStripMenuItem"
        Me.ScheduleToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ScheduleToolStripMenuItem.Text = "&Schedule"
        '
        'AttendanceToolStripMenuItem
        '
        Me.AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        Me.AttendanceToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.AttendanceToolStripMenuItem.Text = "A&ttendance"
        '
        'SectionToolStripMenuItem
        '
        Me.SectionToolStripMenuItem.Name = "SectionToolStripMenuItem"
        Me.SectionToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.SectionToolStripMenuItem.Text = "S&ection"
        '
        'SemesterToolStripMenuItem
        '
        Me.SemesterToolStripMenuItem.Name = "SemesterToolStripMenuItem"
        Me.SemesterToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.SemesterToolStripMenuItem.Text = "Se&mester"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(190, 6)
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.BackColor = System.Drawing.Color.White
        Me.ToolStripTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.ReadOnly = True
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripTextBox3.Text = "      Students"
        '
        'GenerateIDToolStripMenuItem2
        '
        Me.GenerateIDToolStripMenuItem2.Name = "GenerateIDToolStripMenuItem2"
        Me.GenerateIDToolStripMenuItem2.Size = New System.Drawing.Size(193, 22)
        Me.GenerateIDToolStripMenuItem2.Text = "&Generate ID"
        '
        'AttendanceToolStripMenuItem1
        '
        Me.AttendanceToolStripMenuItem1.Name = "AttendanceToolStripMenuItem1"
        Me.AttendanceToolStripMenuItem1.Size = New System.Drawing.Size(193, 22)
        Me.AttendanceToolStripMenuItem1.Text = "&Report Card"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(190, 6)
        '
        'ToolStripTextBox4
        '
        Me.ToolStripTextBox4.BackColor = System.Drawing.Color.White
        Me.ToolStripTextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox4.Name = "ToolStripTextBox4"
        Me.ToolStripTextBox4.ReadOnly = True
        Me.ToolStripTextBox4.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripTextBox4.Text = "      Registrar"
        '
        'EnrollmentPortalToolStripMenuItem
        '
        Me.EnrollmentPortalToolStripMenuItem.Name = "EnrollmentPortalToolStripMenuItem"
        Me.EnrollmentPortalToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.EnrollmentPortalToolStripMenuItem.Text = "&Enrollment Portal"
        '
        'Form137ToolStripMenuItem
        '
        Me.Form137ToolStripMenuItem.Name = "Form137ToolStripMenuItem"
        Me.Form137ToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.Form137ToolStripMenuItem.Text = "&Student ID"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentsDataToolStripMenuItem, Me.StudentsGradesToolStripMenuItem, Me.PrintGradeToolStripMenuItem, Me.GenerateIDToolStripMenuItem})
        Me.StudentToolStripMenuItem.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'StudentsDataToolStripMenuItem
        '
        Me.StudentsDataToolStripMenuItem.Name = "StudentsDataToolStripMenuItem"
        Me.StudentsDataToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.StudentsDataToolStripMenuItem.Text = "Students &Data"
        '
        'StudentsGradesToolStripMenuItem
        '
        Me.StudentsGradesToolStripMenuItem.Name = "StudentsGradesToolStripMenuItem"
        Me.StudentsGradesToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.StudentsGradesToolStripMenuItem.Text = "Students &Grades"
        '
        'PrintGradeToolStripMenuItem
        '
        Me.PrintGradeToolStripMenuItem.Name = "PrintGradeToolStripMenuItem"
        Me.PrintGradeToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.PrintGradeToolStripMenuItem.Text = "&Print Grade"
        '
        'GenerateIDToolStripMenuItem
        '
        Me.GenerateIDToolStripMenuItem.Name = "GenerateIDToolStripMenuItem"
        Me.GenerateIDToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.GenerateIDToolStripMenuItem.Text = "Generate &ID"
        '
        'TeacherToolStripMenuItem
        '
        Me.TeacherToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.TeacherToolStripMenuItem.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TeacherToolStripMenuItem.Image = CType(resources.GetObject("TeacherToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TeacherToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TeacherToolStripMenuItem.Name = "TeacherToolStripMenuItem"
        Me.TeacherToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.TeacherToolStripMenuItem.Text = "&Teachers"
        '
        'TeacherInfoToolStripMenuItem
        '
        Me.TeacherInfoToolStripMenuItem.Name = "TeacherInfoToolStripMenuItem"
        Me.TeacherInfoToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.TeacherInfoToolStripMenuItem.Text = "Teacher &Info"
        '
        'TeachersDataToolStripMenuItem
        '
        Me.TeachersDataToolStripMenuItem.Name = "TeachersDataToolStripMenuItem"
        Me.TeachersDataToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.TeachersDataToolStripMenuItem.Text = "Teachers &Data"
        '
        'GenerateIDToolStripMenuItem1
        '
        Me.GenerateIDToolStripMenuItem1.Name = "GenerateIDToolStripMenuItem1"
        Me.GenerateIDToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.GenerateIDToolStripMenuItem1.Text = "&Generate ID"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem1, Me.TeacherToolStripMenuItem2, Me.GuestToolStripMenuItem3})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1199, 25)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdminToolStripMenuItem1
        '
        Me.AdminToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnrollmentPortalToolStripMenuItem1, Me.EnrollmentDatabaseToolStripMenuItem, Me.TeacherDatabaseToolStripMenuItem, Me.SchoolDatabaseToolStripMenuItem, Me.PrintIDToolStripMenuItem})
        Me.AdminToolStripMenuItem1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminToolStripMenuItem1.Image = CType(resources.GetObject("AdminToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.AdminToolStripMenuItem1.Name = "AdminToolStripMenuItem1"
        Me.AdminToolStripMenuItem1.Size = New System.Drawing.Size(122, 21)
        Me.AdminToolStripMenuItem1.Text = "Administrator"
        '
        'EnrollmentPortalToolStripMenuItem1
        '
        Me.EnrollmentPortalToolStripMenuItem1.Image = CType(resources.GetObject("EnrollmentPortalToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.EnrollmentPortalToolStripMenuItem1.Name = "EnrollmentPortalToolStripMenuItem1"
        Me.EnrollmentPortalToolStripMenuItem1.Size = New System.Drawing.Size(212, 22)
        Me.EnrollmentPortalToolStripMenuItem1.Text = "Enrollment Portal"
        '
        'EnrollmentDatabaseToolStripMenuItem
        '
        Me.EnrollmentDatabaseToolStripMenuItem.Image = CType(resources.GetObject("EnrollmentDatabaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EnrollmentDatabaseToolStripMenuItem.Name = "EnrollmentDatabaseToolStripMenuItem"
        Me.EnrollmentDatabaseToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.EnrollmentDatabaseToolStripMenuItem.Text = "Enrollment Database"
        '
        'TeacherDatabaseToolStripMenuItem
        '
        Me.TeacherDatabaseToolStripMenuItem.Image = CType(resources.GetObject("TeacherDatabaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TeacherDatabaseToolStripMenuItem.Name = "TeacherDatabaseToolStripMenuItem"
        Me.TeacherDatabaseToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.TeacherDatabaseToolStripMenuItem.Text = "Teacher Database"
        '
        'SchoolDatabaseToolStripMenuItem
        '
        Me.SchoolDatabaseToolStripMenuItem.Image = CType(resources.GetObject("SchoolDatabaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SchoolDatabaseToolStripMenuItem.Name = "SchoolDatabaseToolStripMenuItem"
        Me.SchoolDatabaseToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.SchoolDatabaseToolStripMenuItem.Text = "School Database"
        '
        'PrintIDToolStripMenuItem
        '
        Me.PrintIDToolStripMenuItem.Image = CType(resources.GetObject("PrintIDToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintIDToolStripMenuItem.Name = "PrintIDToolStripMenuItem"
        Me.PrintIDToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.PrintIDToolStripMenuItem.Text = "Print ID"
        '
        'TeacherToolStripMenuItem2
        '
        Me.TeacherToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnrollmentPortalToolStripMenuItem2})
        Me.TeacherToolStripMenuItem2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherToolStripMenuItem2.Image = CType(resources.GetObject("TeacherToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.TeacherToolStripMenuItem2.Name = "TeacherToolStripMenuItem2"
        Me.TeacherToolStripMenuItem2.Size = New System.Drawing.Size(86, 21)
        Me.TeacherToolStripMenuItem2.Text = "Teacher"
        '
        'EnrollmentPortalToolStripMenuItem2
        '
        Me.EnrollmentPortalToolStripMenuItem2.Image = CType(resources.GetObject("EnrollmentPortalToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.EnrollmentPortalToolStripMenuItem2.Name = "EnrollmentPortalToolStripMenuItem2"
        Me.EnrollmentPortalToolStripMenuItem2.Size = New System.Drawing.Size(186, 22)
        Me.EnrollmentPortalToolStripMenuItem2.Text = "Enrollment Portal"
        '
        'GuestToolStripMenuItem3
        '
        Me.GuestToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnrollmentPortalToolStripMenuItem3})
        Me.GuestToolStripMenuItem3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuestToolStripMenuItem3.Image = CType(resources.GetObject("GuestToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.GuestToolStripMenuItem3.Name = "GuestToolStripMenuItem3"
        Me.GuestToolStripMenuItem3.Size = New System.Drawing.Size(73, 21)
        Me.GuestToolStripMenuItem3.Text = "Guest"
        '
        'EnrollmentPortalToolStripMenuItem3
        '
        Me.EnrollmentPortalToolStripMenuItem3.Image = CType(resources.GetObject("EnrollmentPortalToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.EnrollmentPortalToolStripMenuItem3.Name = "EnrollmentPortalToolStripMenuItem3"
        Me.EnrollmentPortalToolStripMenuItem3.Size = New System.Drawing.Size(186, 22)
        Me.EnrollmentPortalToolStripMenuItem3.Text = "Enrollment Portal"
        '
        'picClose
        '
        Me.picClose.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.picClose.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.picClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(1176, 0)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(23, 24)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClose.TabIndex = 2
        Me.picClose.TabStop = False
        '
        'PicMinimize
        '
        Me.PicMinimize.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.PicMinimize.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PicMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicMinimize.Image = CType(resources.GetObject("PicMinimize.Image"), System.Drawing.Image)
        Me.PicMinimize.Location = New System.Drawing.Point(1152, 0)
        Me.PicMinimize.Name = "PicMinimize"
        Me.PicMinimize.Size = New System.Drawing.Size(23, 24)
        Me.PicMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicMinimize.TabIndex = 27
        Me.PicMinimize.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1199, 701)
        Me.Controls.Add(Me.PicMinimize)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Form"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IDPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DateStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TimeStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents picClose As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnStatus As Button
    Friend WithEvents Username As Label
    Friend WithEvents btnEnrollmentPortal As Button
    Friend WithEvents IDPicture As PictureBox
    Friend WithEvents AdministratorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents EnrollmentDataMenuItem10 As ToolStripMenuItem
    Friend WithEvents TeacherDataMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents ScheduleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SemesterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox3 As ToolStripTextBox
    Friend WithEvents GenerateIDToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox4 As ToolStripTextBox
    Friend WithEvents EnrollmentPortalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Form137ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentsDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentsGradesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintGradeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateIDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeacherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeacherInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeachersDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdminDataMenuItem As ToolStripMenuItem
    Friend WithEvents btnPrintID As Button
    Friend WithEvents btnEnrollmentDatabase As Button
    Friend WithEvents btnTeacherDatabase As Button
    Friend WithEvents GenerateIDToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents UsernameToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents DateToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As ToolStripStatusLabel
    Friend WithEvents TimeToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents AdminToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EnrollmentPortalToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TeacherDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnrollmentDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SchoolDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintIDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeacherToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents GuestToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents EnrollmentPortalToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents EnrollmentPortalToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents ToolStripStatusLabel9 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel10 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel11 As ToolStripStatusLabel
    Private WithEvents PicMinimize As PictureBox
    Friend WithEvents txtTimeOut As TextBox
    Friend WithEvents btnAboutMe As Button
    Friend WithEvents btnLoginHistory As Button
End Class
