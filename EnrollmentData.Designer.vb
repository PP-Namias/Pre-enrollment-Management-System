<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EnrollmentData
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
        Dim Label3 As System.Windows.Forms.Label
        Dim EnrollmentNumberLabel As System.Windows.Forms.Label
        Dim StudentNumberLabel As System.Windows.Forms.Label
        Dim GradeLevelLabel As System.Windows.Forms.Label
        Dim StrandLabel As System.Windows.Forms.Label
        Dim SemesterLabel As System.Windows.Forms.Label
        Dim SchoolYearLabel As System.Windows.Forms.Label
        Dim LastnameLabel As System.Windows.Forms.Label
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim MiddlenameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim POBLabel As System.Windows.Forms.Label
        Dim NationalityLabel As System.Windows.Forms.Label
        Dim ReligionLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim MobileNumberLabel As System.Windows.Forms.Label
        Dim TelephoneNumberLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim ReasonApplyingLabel As System.Windows.Forms.Label
        Dim AcademicYear3Label As System.Windows.Forms.Label
        Dim AcademicYear2Label As System.Windows.Forms.Label
        Dim AcademicYear1Label As System.Windows.Forms.Label
        Dim SchoolLastAttended3Label As System.Windows.Forms.Label
        Dim SchoolLastAttended2Label As System.Windows.Forms.Label
        Dim SchoolLastAttended1Label As System.Windows.Forms.Label
        Dim SiblingsOfStudentSchool3Label As System.Windows.Forms.Label
        Dim SiblingsOfStudentSchool2Label As System.Windows.Forms.Label
        Dim SiblingsOfStudentSchool1Label As System.Windows.Forms.Label
        Dim SiblingsOfStudentAge3Label As System.Windows.Forms.Label
        Dim SiblingsOfStudentAge2Label As System.Windows.Forms.Label
        Dim SiblingsOfStudentAge1Label As System.Windows.Forms.Label
        Dim SiblingsOfStudent3Label As System.Windows.Forms.Label
        Dim SiblingsOfStudent2Label As System.Windows.Forms.Label
        Dim SiblingsOfStudent1Label As System.Windows.Forms.Label
        Dim FetcherContactNumberLabel As System.Windows.Forms.Label
        Dim FetcherNameLabel As System.Windows.Forms.Label
        Dim GuardianContactNumberLabel As System.Windows.Forms.Label
        Dim GuardianWorkAddressLabel As System.Windows.Forms.Label
        Dim GuardianEmailLabel As System.Windows.Forms.Label
        Dim GuardianRelationLabel As System.Windows.Forms.Label
        Dim GuardianNameLabel As System.Windows.Forms.Label
        Dim PersonEmergencyLabel As System.Windows.Forms.Label
        Dim NumberOfSiblingsLabel As System.Windows.Forms.Label
        Dim MotherContactNumberLabel As System.Windows.Forms.Label
        Dim MotherWorkAddressLabel As System.Windows.Forms.Label
        Dim MotherEmailLabel As System.Windows.Forms.Label
        Dim MotherOccupationLabel As System.Windows.Forms.Label
        Dim MotherNameLabel As System.Windows.Forms.Label
        Dim FatherContactNumberLabel As System.Windows.Forms.Label
        Dim FatherWorkAddressLabel As System.Windows.Forms.Label
        Dim FatherEmailLabel As System.Windows.Forms.Label
        Dim FatherOccupationLabel As System.Windows.Forms.Label
        Dim FatherNameLabel As System.Windows.Forms.Label
        Dim IdentifierLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim ConditionLabel As System.Windows.Forms.Label
        Dim Requirement1Label As System.Windows.Forms.Label
        Dim Requirement2Label As System.Windows.Forms.Label
        Dim Requirement3Label As System.Windows.Forms.Label
        Dim Requirement4Label As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnrollmentData))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbStudentNum = New System.Windows.Forms.ComboBox()
        Me.btnGenerateID = New System.Windows.Forms.Button()
        Me.btnDenied = New System.Windows.Forms.Button()
        Me.EnrollmentNumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.EnrollmentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pre_enrollmentDataSet = New SchoolManagementSystem.Pre_enrollmentDataSet()
        Me.StudentNumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.GradeLevelTextBox1 = New System.Windows.Forms.TextBox()
        Me.StrandTextBox1 = New System.Windows.Forms.TextBox()
        Me.SemesterTextBox1 = New System.Windows.Forms.TextBox()
        Me.SchoolYearTextBox1 = New System.Windows.Forms.TextBox()
        Me.LastnameTextBox1 = New System.Windows.Forms.TextBox()
        Me.FirstnameTextBox1 = New System.Windows.Forms.TextBox()
        Me.MiddlenameTextBox1 = New System.Windows.Forms.TextBox()
        Me.AgeTextBox1 = New System.Windows.Forms.TextBox()
        Me.DOBDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SexTextBox1 = New System.Windows.Forms.TextBox()
        Me.POBTextBox1 = New System.Windows.Forms.TextBox()
        Me.NationalityTextBox1 = New System.Windows.Forms.TextBox()
        Me.ReligionTextBox1 = New System.Windows.Forms.TextBox()
        Me.EmailTextBox1 = New System.Windows.Forms.TextBox()
        Me.MobileNumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.TelephoneNumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.AddressTextBox1 = New System.Windows.Forms.TextBox()
        Me.CityTextBox1 = New System.Windows.Forms.TextBox()
        Me.FatherNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.FatherOccupationTextBox1 = New System.Windows.Forms.TextBox()
        Me.FatherEmailTextBox1 = New System.Windows.Forms.TextBox()
        Me.FatherWorkAddressTextBox1 = New System.Windows.Forms.TextBox()
        Me.FatherContactNumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.MotherNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.MotherOccupationTextBox1 = New System.Windows.Forms.TextBox()
        Me.MotherEmailTextBox1 = New System.Windows.Forms.TextBox()
        Me.MotherWorkAddressTextBox1 = New System.Windows.Forms.TextBox()
        Me.MotherContactNumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.NumberOfSiblingsTextBox1 = New System.Windows.Forms.TextBox()
        Me.PersonEmergencyTextBox1 = New System.Windows.Forms.TextBox()
        Me.GuardianNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.GuardianRelationTextBox1 = New System.Windows.Forms.TextBox()
        Me.GuardianEmailTextBox1 = New System.Windows.Forms.TextBox()
        Me.GuardianWorkAddressTextBox1 = New System.Windows.Forms.TextBox()
        Me.GuardianContactNumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.FetcherNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.FetcherContactNumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.SiblingsOfStudent1TextBox1 = New System.Windows.Forms.TextBox()
        Me.SiblingsOfStudent2TextBox1 = New System.Windows.Forms.TextBox()
        Me.SiblingsOfStudent3TextBox1 = New System.Windows.Forms.TextBox()
        Me.SiblingsOfStudentAge1TextBox1 = New System.Windows.Forms.TextBox()
        Me.SiblingsOfStudentAge2TextBox1 = New System.Windows.Forms.TextBox()
        Me.SiblingsOfStudentAge3TextBox1 = New System.Windows.Forms.TextBox()
        Me.SiblingsOfStudentSchool1TextBox1 = New System.Windows.Forms.TextBox()
        Me.SiblingsOfStudentSchool2TextBox1 = New System.Windows.Forms.TextBox()
        Me.SiblingsOfStudentSchool3TextBox1 = New System.Windows.Forms.TextBox()
        Me.SchoolLastAttended1TextBox1 = New System.Windows.Forms.TextBox()
        Me.SchoolLastAttended2TextBox1 = New System.Windows.Forms.TextBox()
        Me.SchoolLastAttended3TextBox1 = New System.Windows.Forms.TextBox()
        Me.AcademicYear1TextBox1 = New System.Windows.Forms.TextBox()
        Me.AcademicYear2TextBox1 = New System.Windows.Forms.TextBox()
        Me.AcademicYear3TextBox1 = New System.Windows.Forms.TextBox()
        Me.ReasonApplyingTextBox1 = New System.Windows.Forms.TextBox()
        Me.ConditionTextBox = New System.Windows.Forms.TextBox()
        Me.Requirement1TextBox = New System.Windows.Forms.TextBox()
        Me.Requirement2TextBox = New System.Windows.Forms.TextBox()
        Me.Requirement3TextBox = New System.Windows.Forms.TextBox()
        Me.Requirement4TextBox = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.cmbCapture = New System.Windows.Forms.ComboBox()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureID = New System.Windows.Forms.PictureBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.AdvancedDataGridView1 = New ADGV.AdvancedDataGridView()
        Me.StudentPictureDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Approve = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.EnrollmentNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentifierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddlenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemesterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NationalityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReligionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelephoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatherOccupationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatherEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatherWorkAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatherContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotherOccupationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotherEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotherWorkAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotherContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberOfSiblingsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonEmergencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuardianNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuardianRelationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuardianEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuardianWorkAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuardianContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FetcherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FetcherContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiblingsOfStudent1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiblingsOfStudent2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiblingsOfStudent3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiblingsOfStudentAge1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiblingsOfStudentAge2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiblingsOfStudentAge3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiblingsOfStudentSchool1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiblingsOfStudentSchool2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiblingsOfStudentSchool3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolLastAttended1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolLastAttended2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolLastAttended3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcademicYear1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcademicYear2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcademicYear3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReasonApplyingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConditionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Requirement1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Requirement2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Requirement3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Requirement4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentifierDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EnrollmentDataTableAdapter = New SchoolManagementSystem.Pre_enrollmentDataSetTableAdapters.EnrollmentDataTableAdapter()
        Me.TableAdapterManager = New SchoolManagementSystem.Pre_enrollmentDataSetTableAdapters.TableAdapterManager()
        Label3 = New System.Windows.Forms.Label()
        EnrollmentNumberLabel = New System.Windows.Forms.Label()
        StudentNumberLabel = New System.Windows.Forms.Label()
        GradeLevelLabel = New System.Windows.Forms.Label()
        StrandLabel = New System.Windows.Forms.Label()
        SemesterLabel = New System.Windows.Forms.Label()
        SchoolYearLabel = New System.Windows.Forms.Label()
        LastnameLabel = New System.Windows.Forms.Label()
        FirstnameLabel = New System.Windows.Forms.Label()
        MiddlenameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        POBLabel = New System.Windows.Forms.Label()
        NationalityLabel = New System.Windows.Forms.Label()
        ReligionLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        MobileNumberLabel = New System.Windows.Forms.Label()
        TelephoneNumberLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        ReasonApplyingLabel = New System.Windows.Forms.Label()
        AcademicYear3Label = New System.Windows.Forms.Label()
        AcademicYear2Label = New System.Windows.Forms.Label()
        AcademicYear1Label = New System.Windows.Forms.Label()
        SchoolLastAttended3Label = New System.Windows.Forms.Label()
        SchoolLastAttended2Label = New System.Windows.Forms.Label()
        SchoolLastAttended1Label = New System.Windows.Forms.Label()
        SiblingsOfStudentSchool3Label = New System.Windows.Forms.Label()
        SiblingsOfStudentSchool2Label = New System.Windows.Forms.Label()
        SiblingsOfStudentSchool1Label = New System.Windows.Forms.Label()
        SiblingsOfStudentAge3Label = New System.Windows.Forms.Label()
        SiblingsOfStudentAge2Label = New System.Windows.Forms.Label()
        SiblingsOfStudentAge1Label = New System.Windows.Forms.Label()
        SiblingsOfStudent3Label = New System.Windows.Forms.Label()
        SiblingsOfStudent2Label = New System.Windows.Forms.Label()
        SiblingsOfStudent1Label = New System.Windows.Forms.Label()
        FetcherContactNumberLabel = New System.Windows.Forms.Label()
        FetcherNameLabel = New System.Windows.Forms.Label()
        GuardianContactNumberLabel = New System.Windows.Forms.Label()
        GuardianWorkAddressLabel = New System.Windows.Forms.Label()
        GuardianEmailLabel = New System.Windows.Forms.Label()
        GuardianRelationLabel = New System.Windows.Forms.Label()
        GuardianNameLabel = New System.Windows.Forms.Label()
        PersonEmergencyLabel = New System.Windows.Forms.Label()
        NumberOfSiblingsLabel = New System.Windows.Forms.Label()
        MotherContactNumberLabel = New System.Windows.Forms.Label()
        MotherWorkAddressLabel = New System.Windows.Forms.Label()
        MotherEmailLabel = New System.Windows.Forms.Label()
        MotherOccupationLabel = New System.Windows.Forms.Label()
        MotherNameLabel = New System.Windows.Forms.Label()
        FatherContactNumberLabel = New System.Windows.Forms.Label()
        FatherWorkAddressLabel = New System.Windows.Forms.Label()
        FatherEmailLabel = New System.Windows.Forms.Label()
        FatherOccupationLabel = New System.Windows.Forms.Label()
        FatherNameLabel = New System.Windows.Forms.Label()
        IdentifierLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        ConditionLabel = New System.Windows.Forms.Label()
        Requirement1Label = New System.Windows.Forms.Label()
        Requirement2Label = New System.Windows.Forms.Label()
        Requirement3Label = New System.Windows.Forms.Label()
        Requirement4Label = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.EnrollmentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pre_enrollmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvancedDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(18, 25)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(538, 37)
        Label3.TabIndex = 126
        Label3.Text = "Students Pre-enrollment Database"
        '
        'EnrollmentNumberLabel
        '
        EnrollmentNumberLabel.AutoSize = True
        EnrollmentNumberLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EnrollmentNumberLabel.Location = New System.Drawing.Point(21, 542)
        EnrollmentNumberLabel.Name = "EnrollmentNumberLabel"
        EnrollmentNumberLabel.Size = New System.Drawing.Size(163, 21)
        EnrollmentNumberLabel.TabIndex = 135
        EnrollmentNumberLabel.Text = "Enrollment Number:"
        '
        'StudentNumberLabel
        '
        StudentNumberLabel.AutoSize = True
        StudentNumberLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StudentNumberLabel.Location = New System.Drawing.Point(21, 568)
        StudentNumberLabel.Name = "StudentNumberLabel"
        StudentNumberLabel.Size = New System.Drawing.Size(144, 21)
        StudentNumberLabel.TabIndex = 137
        StudentNumberLabel.Text = "Student Number:"
        '
        'GradeLevelLabel
        '
        GradeLevelLabel.AutoSize = True
        GradeLevelLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GradeLevelLabel.Location = New System.Drawing.Point(21, 594)
        GradeLevelLabel.Name = "GradeLevelLabel"
        GradeLevelLabel.Size = New System.Drawing.Size(109, 21)
        GradeLevelLabel.TabIndex = 139
        GradeLevelLabel.Text = "Grade Level:"
        '
        'StrandLabel
        '
        StrandLabel.AutoSize = True
        StrandLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StrandLabel.Location = New System.Drawing.Point(446, 545)
        StrandLabel.Name = "StrandLabel"
        StrandLabel.Size = New System.Drawing.Size(66, 21)
        StrandLabel.TabIndex = 141
        StrandLabel.Text = "Strand:"
        '
        'SemesterLabel
        '
        SemesterLabel.AutoSize = True
        SemesterLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SemesterLabel.Location = New System.Drawing.Point(446, 570)
        SemesterLabel.Name = "SemesterLabel"
        SemesterLabel.Size = New System.Drawing.Size(85, 21)
        SemesterLabel.TabIndex = 143
        SemesterLabel.Text = "Semester:"
        '
        'SchoolYearLabel
        '
        SchoolYearLabel.AutoSize = True
        SchoolYearLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SchoolYearLabel.Location = New System.Drawing.Point(446, 596)
        SchoolYearLabel.Name = "SchoolYearLabel"
        SchoolYearLabel.Size = New System.Drawing.Size(106, 21)
        SchoolYearLabel.TabIndex = 145
        SchoolYearLabel.Text = "School Year:"
        '
        'LastnameLabel
        '
        LastnameLabel.AutoSize = True
        LastnameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastnameLabel.Location = New System.Drawing.Point(21, 620)
        LastnameLabel.Name = "LastnameLabel"
        LastnameLabel.Size = New System.Drawing.Size(95, 21)
        LastnameLabel.TabIndex = 147
        LastnameLabel.Text = "Last name:"
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstnameLabel.Location = New System.Drawing.Point(21, 646)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(93, 21)
        FirstnameLabel.TabIndex = 149
        FirstnameLabel.Text = "First name:"
        '
        'MiddlenameLabel
        '
        MiddlenameLabel.AutoSize = True
        MiddlenameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MiddlenameLabel.Location = New System.Drawing.Point(21, 672)
        MiddlenameLabel.Name = "MiddlenameLabel"
        MiddlenameLabel.Size = New System.Drawing.Size(117, 21)
        MiddlenameLabel.TabIndex = 151
        MiddlenameLabel.Text = "Middle name:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgeLabel.Location = New System.Drawing.Point(446, 622)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(48, 21)
        AgeLabel.TabIndex = 153
        AgeLabel.Text = "Age:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOBLabel.Location = New System.Drawing.Point(446, 649)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(111, 21)
        DOBLabel.TabIndex = 155
        DOBLabel.Text = "Date of Birth:"
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SexLabel.Location = New System.Drawing.Point(446, 675)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(40, 21)
        SexLabel.TabIndex = 157
        SexLabel.Text = "Sex:"
        '
        'POBLabel
        '
        POBLabel.AutoSize = True
        POBLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        POBLabel.Location = New System.Drawing.Point(446, 701)
        POBLabel.Name = "POBLabel"
        POBLabel.Size = New System.Drawing.Size(114, 21)
        POBLabel.TabIndex = 159
        POBLabel.Text = "Place of Birth:"
        '
        'NationalityLabel
        '
        NationalityLabel.AutoSize = True
        NationalityLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NationalityLabel.Location = New System.Drawing.Point(446, 727)
        NationalityLabel.Name = "NationalityLabel"
        NationalityLabel.Size = New System.Drawing.Size(99, 21)
        NationalityLabel.TabIndex = 161
        NationalityLabel.Text = "Nationality:"
        '
        'ReligionLabel
        '
        ReligionLabel.AutoSize = True
        ReligionLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReligionLabel.Location = New System.Drawing.Point(446, 753)
        ReligionLabel.Name = "ReligionLabel"
        ReligionLabel.Size = New System.Drawing.Size(74, 21)
        ReligionLabel.TabIndex = 163
        ReligionLabel.Text = "Religion:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(21, 697)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(55, 21)
        EmailLabel.TabIndex = 165
        EmailLabel.Text = "Email:"
        '
        'MobileNumberLabel
        '
        MobileNumberLabel.AutoSize = True
        MobileNumberLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MobileNumberLabel.Location = New System.Drawing.Point(21, 723)
        MobileNumberLabel.Name = "MobileNumberLabel"
        MobileNumberLabel.Size = New System.Drawing.Size(133, 21)
        MobileNumberLabel.TabIndex = 167
        MobileNumberLabel.Text = "Mobile Number:"
        '
        'TelephoneNumberLabel
        '
        TelephoneNumberLabel.AutoSize = True
        TelephoneNumberLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelephoneNumberLabel.Location = New System.Drawing.Point(21, 749)
        TelephoneNumberLabel.Name = "TelephoneNumberLabel"
        TelephoneNumberLabel.Size = New System.Drawing.Size(163, 21)
        TelephoneNumberLabel.TabIndex = 169
        TelephoneNumberLabel.Text = "Telephone Number:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(21, 775)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(76, 21)
        AddressLabel.TabIndex = 171
        AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CityLabel.Location = New System.Drawing.Point(446, 779)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(45, 21)
        CityLabel.TabIndex = 173
        CityLabel.Text = "City:"
        '
        'ReasonApplyingLabel
        '
        ReasonApplyingLabel.AutoSize = True
        ReasonApplyingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReasonApplyingLabel.Location = New System.Drawing.Point(15, 1634)
        ReasonApplyingLabel.Name = "ReasonApplyingLabel"
        ReasonApplyingLabel.Size = New System.Drawing.Size(133, 20)
        ReasonApplyingLabel.TabIndex = 243
        ReasonApplyingLabel.Text = "Reason Applying:"
        '
        'AcademicYear3Label
        '
        AcademicYear3Label.AutoSize = True
        AcademicYear3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AcademicYear3Label.Location = New System.Drawing.Point(446, 1601)
        AcademicYear3Label.Name = "AcademicYear3Label"
        AcademicYear3Label.Size = New System.Drawing.Size(134, 20)
        AcademicYear3Label.TabIndex = 241
        AcademicYear3Label.Text = "Academic Year 3:"
        '
        'AcademicYear2Label
        '
        AcademicYear2Label.AutoSize = True
        AcademicYear2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AcademicYear2Label.Location = New System.Drawing.Point(446, 1575)
        AcademicYear2Label.Name = "AcademicYear2Label"
        AcademicYear2Label.Size = New System.Drawing.Size(134, 20)
        AcademicYear2Label.TabIndex = 239
        AcademicYear2Label.Text = "Academic Year 2:"
        '
        'AcademicYear1Label
        '
        AcademicYear1Label.AutoSize = True
        AcademicYear1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AcademicYear1Label.Location = New System.Drawing.Point(446, 1549)
        AcademicYear1Label.Name = "AcademicYear1Label"
        AcademicYear1Label.Size = New System.Drawing.Size(134, 20)
        AcademicYear1Label.TabIndex = 237
        AcademicYear1Label.Text = "Academic Year 1:"
        '
        'SchoolLastAttended3Label
        '
        SchoolLastAttended3Label.AutoSize = True
        SchoolLastAttended3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SchoolLastAttended3Label.Location = New System.Drawing.Point(15, 1598)
        SchoolLastAttended3Label.Name = "SchoolLastAttended3Label"
        SchoolLastAttended3Label.Size = New System.Drawing.Size(180, 20)
        SchoolLastAttended3Label.TabIndex = 235
        SchoolLastAttended3Label.Text = "School Last Attended 3:"
        '
        'SchoolLastAttended2Label
        '
        SchoolLastAttended2Label.AutoSize = True
        SchoolLastAttended2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SchoolLastAttended2Label.Location = New System.Drawing.Point(15, 1572)
        SchoolLastAttended2Label.Name = "SchoolLastAttended2Label"
        SchoolLastAttended2Label.Size = New System.Drawing.Size(180, 20)
        SchoolLastAttended2Label.TabIndex = 233
        SchoolLastAttended2Label.Text = "School Last Attended 2:"
        '
        'SchoolLastAttended1Label
        '
        SchoolLastAttended1Label.AutoSize = True
        SchoolLastAttended1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SchoolLastAttended1Label.Location = New System.Drawing.Point(15, 1546)
        SchoolLastAttended1Label.Name = "SchoolLastAttended1Label"
        SchoolLastAttended1Label.Size = New System.Drawing.Size(180, 20)
        SchoolLastAttended1Label.TabIndex = 231
        SchoolLastAttended1Label.Text = "School Last Attended 1:"
        '
        'SiblingsOfStudentSchool3Label
        '
        SiblingsOfStudentSchool3Label.AutoSize = True
        SiblingsOfStudentSchool3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiblingsOfStudentSchool3Label.Location = New System.Drawing.Point(552, 1460)
        SiblingsOfStudentSchool3Label.Name = "SiblingsOfStudentSchool3Label"
        SiblingsOfStudentSchool3Label.Size = New System.Drawing.Size(134, 20)
        SiblingsOfStudentSchool3Label.TabIndex = 229
        SiblingsOfStudentSchool3Label.Text = "Siblings School 3:"
        '
        'SiblingsOfStudentSchool2Label
        '
        SiblingsOfStudentSchool2Label.AutoSize = True
        SiblingsOfStudentSchool2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiblingsOfStudentSchool2Label.Location = New System.Drawing.Point(552, 1434)
        SiblingsOfStudentSchool2Label.Name = "SiblingsOfStudentSchool2Label"
        SiblingsOfStudentSchool2Label.Size = New System.Drawing.Size(134, 20)
        SiblingsOfStudentSchool2Label.TabIndex = 227
        SiblingsOfStudentSchool2Label.Text = "Siblings School 2:"
        '
        'SiblingsOfStudentSchool1Label
        '
        SiblingsOfStudentSchool1Label.AutoSize = True
        SiblingsOfStudentSchool1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiblingsOfStudentSchool1Label.Location = New System.Drawing.Point(552, 1408)
        SiblingsOfStudentSchool1Label.Name = "SiblingsOfStudentSchool1Label"
        SiblingsOfStudentSchool1Label.Size = New System.Drawing.Size(134, 20)
        SiblingsOfStudentSchool1Label.TabIndex = 225
        SiblingsOfStudentSchool1Label.Text = "Siblings School 1:"
        '
        'SiblingsOfStudentAge3Label
        '
        SiblingsOfStudentAge3Label.AutoSize = True
        SiblingsOfStudentAge3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiblingsOfStudentAge3Label.Location = New System.Drawing.Point(391, 1460)
        SiblingsOfStudentAge3Label.Name = "SiblingsOfStudentAge3Label"
        SiblingsOfStudentAge3Label.Size = New System.Drawing.Size(114, 20)
        SiblingsOfStudentAge3Label.TabIndex = 223
        SiblingsOfStudentAge3Label.Text = "Siblings Age 3:"
        '
        'SiblingsOfStudentAge2Label
        '
        SiblingsOfStudentAge2Label.AutoSize = True
        SiblingsOfStudentAge2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiblingsOfStudentAge2Label.Location = New System.Drawing.Point(391, 1434)
        SiblingsOfStudentAge2Label.Name = "SiblingsOfStudentAge2Label"
        SiblingsOfStudentAge2Label.Size = New System.Drawing.Size(114, 20)
        SiblingsOfStudentAge2Label.TabIndex = 221
        SiblingsOfStudentAge2Label.Text = "Siblings Age 2:"
        '
        'SiblingsOfStudentAge1Label
        '
        SiblingsOfStudentAge1Label.AutoSize = True
        SiblingsOfStudentAge1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiblingsOfStudentAge1Label.Location = New System.Drawing.Point(391, 1408)
        SiblingsOfStudentAge1Label.Name = "SiblingsOfStudentAge1Label"
        SiblingsOfStudentAge1Label.Size = New System.Drawing.Size(114, 20)
        SiblingsOfStudentAge1Label.TabIndex = 219
        SiblingsOfStudentAge1Label.Text = "Siblings Age 1:"
        '
        'SiblingsOfStudent3Label
        '
        SiblingsOfStudent3Label.AutoSize = True
        SiblingsOfStudent3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiblingsOfStudent3Label.Location = New System.Drawing.Point(18, 1460)
        SiblingsOfStudent3Label.Name = "SiblingsOfStudent3Label"
        SiblingsOfStudent3Label.Size = New System.Drawing.Size(160, 20)
        SiblingsOfStudent3Label.TabIndex = 217
        SiblingsOfStudent3Label.Text = "Siblings of Student 3:"
        '
        'SiblingsOfStudent2Label
        '
        SiblingsOfStudent2Label.AutoSize = True
        SiblingsOfStudent2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiblingsOfStudent2Label.Location = New System.Drawing.Point(18, 1434)
        SiblingsOfStudent2Label.Name = "SiblingsOfStudent2Label"
        SiblingsOfStudent2Label.Size = New System.Drawing.Size(160, 20)
        SiblingsOfStudent2Label.TabIndex = 215
        SiblingsOfStudent2Label.Text = "Siblings of Student 2:"
        '
        'SiblingsOfStudent1Label
        '
        SiblingsOfStudent1Label.AutoSize = True
        SiblingsOfStudent1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiblingsOfStudent1Label.Location = New System.Drawing.Point(18, 1408)
        SiblingsOfStudent1Label.Name = "SiblingsOfStudent1Label"
        SiblingsOfStudent1Label.Size = New System.Drawing.Size(160, 20)
        SiblingsOfStudent1Label.TabIndex = 213
        SiblingsOfStudent1Label.Text = "Siblings of Student 1:"
        '
        'FetcherContactNumberLabel
        '
        FetcherContactNumberLabel.AutoSize = True
        FetcherContactNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FetcherContactNumberLabel.Location = New System.Drawing.Point(446, 1301)
        FetcherContactNumberLabel.Name = "FetcherContactNumberLabel"
        FetcherContactNumberLabel.Size = New System.Drawing.Size(156, 20)
        FetcherContactNumberLabel.TabIndex = 211
        FetcherContactNumberLabel.Text = "Fetcher Contact No.:"
        '
        'FetcherNameLabel
        '
        FetcherNameLabel.AutoSize = True
        FetcherNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FetcherNameLabel.Location = New System.Drawing.Point(446, 1275)
        FetcherNameLabel.Name = "FetcherNameLabel"
        FetcherNameLabel.Size = New System.Drawing.Size(114, 20)
        FetcherNameLabel.TabIndex = 209
        FetcherNameLabel.Text = "Fetcher Name:"
        '
        'GuardianContactNumberLabel
        '
        GuardianContactNumberLabel.AutoSize = True
        GuardianContactNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GuardianContactNumberLabel.Location = New System.Drawing.Point(18, 1380)
        GuardianContactNumberLabel.Name = "GuardianContactNumberLabel"
        GuardianContactNumberLabel.Size = New System.Drawing.Size(167, 20)
        GuardianContactNumberLabel.TabIndex = 207
        GuardianContactNumberLabel.Text = "Guardian Contact No.:"
        '
        'GuardianWorkAddressLabel
        '
        GuardianWorkAddressLabel.AutoSize = True
        GuardianWorkAddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GuardianWorkAddressLabel.Location = New System.Drawing.Point(18, 1354)
        GuardianWorkAddressLabel.Name = "GuardianWorkAddressLabel"
        GuardianWorkAddressLabel.Size = New System.Drawing.Size(183, 20)
        GuardianWorkAddressLabel.TabIndex = 205
        GuardianWorkAddressLabel.Text = "Guardian Work Address:"
        '
        'GuardianEmailLabel
        '
        GuardianEmailLabel.AutoSize = True
        GuardianEmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GuardianEmailLabel.Location = New System.Drawing.Point(18, 1328)
        GuardianEmailLabel.Name = "GuardianEmailLabel"
        GuardianEmailLabel.Size = New System.Drawing.Size(122, 20)
        GuardianEmailLabel.TabIndex = 203
        GuardianEmailLabel.Text = "Guardian Email:"
        '
        'GuardianRelationLabel
        '
        GuardianRelationLabel.AutoSize = True
        GuardianRelationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GuardianRelationLabel.Location = New System.Drawing.Point(18, 1302)
        GuardianRelationLabel.Name = "GuardianRelationLabel"
        GuardianRelationLabel.Size = New System.Drawing.Size(142, 20)
        GuardianRelationLabel.TabIndex = 201
        GuardianRelationLabel.Text = "Guardian Relation:"
        '
        'GuardianNameLabel
        '
        GuardianNameLabel.AutoSize = True
        GuardianNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GuardianNameLabel.Location = New System.Drawing.Point(18, 1276)
        GuardianNameLabel.Name = "GuardianNameLabel"
        GuardianNameLabel.Size = New System.Drawing.Size(125, 20)
        GuardianNameLabel.TabIndex = 199
        GuardianNameLabel.Text = "Guardian Name:"
        '
        'PersonEmergencyLabel
        '
        PersonEmergencyLabel.AutoSize = True
        PersonEmergencyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PersonEmergencyLabel.Location = New System.Drawing.Point(446, 1250)
        PersonEmergencyLabel.Name = "PersonEmergencyLabel"
        PersonEmergencyLabel.Size = New System.Drawing.Size(147, 20)
        PersonEmergencyLabel.TabIndex = 197
        PersonEmergencyLabel.Text = "Person Emergency:"
        '
        'NumberOfSiblingsLabel
        '
        NumberOfSiblingsLabel.AutoSize = True
        NumberOfSiblingsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumberOfSiblingsLabel.Location = New System.Drawing.Point(18, 1250)
        NumberOfSiblingsLabel.Name = "NumberOfSiblingsLabel"
        NumberOfSiblingsLabel.Size = New System.Drawing.Size(146, 20)
        NumberOfSiblingsLabel.TabIndex = 195
        NumberOfSiblingsLabel.Text = "Number of Siblings:"
        '
        'MotherContactNumberLabel
        '
        MotherContactNumberLabel.AutoSize = True
        MotherContactNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MotherContactNumberLabel.Location = New System.Drawing.Point(446, 1225)
        MotherContactNumberLabel.Name = "MotherContactNumberLabel"
        MotherContactNumberLabel.Size = New System.Drawing.Size(147, 20)
        MotherContactNumberLabel.TabIndex = 193
        MotherContactNumberLabel.Text = "Mother Contact No:"
        '
        'MotherWorkAddressLabel
        '
        MotherWorkAddressLabel.AutoSize = True
        MotherWorkAddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MotherWorkAddressLabel.Location = New System.Drawing.Point(446, 1199)
        MotherWorkAddressLabel.Name = "MotherWorkAddressLabel"
        MotherWorkAddressLabel.Size = New System.Drawing.Size(167, 20)
        MotherWorkAddressLabel.TabIndex = 191
        MotherWorkAddressLabel.Text = "Mother Work Address:"
        '
        'MotherEmailLabel
        '
        MotherEmailLabel.AutoSize = True
        MotherEmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MotherEmailLabel.Location = New System.Drawing.Point(446, 1173)
        MotherEmailLabel.Name = "MotherEmailLabel"
        MotherEmailLabel.Size = New System.Drawing.Size(106, 20)
        MotherEmailLabel.TabIndex = 189
        MotherEmailLabel.Text = "Mother Email:"
        '
        'MotherOccupationLabel
        '
        MotherOccupationLabel.AutoSize = True
        MotherOccupationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MotherOccupationLabel.Location = New System.Drawing.Point(446, 1147)
        MotherOccupationLabel.Name = "MotherOccupationLabel"
        MotherOccupationLabel.Size = New System.Drawing.Size(148, 20)
        MotherOccupationLabel.TabIndex = 187
        MotherOccupationLabel.Text = "Mother Occupation:"
        '
        'MotherNameLabel
        '
        MotherNameLabel.AutoSize = True
        MotherNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MotherNameLabel.Location = New System.Drawing.Point(446, 1121)
        MotherNameLabel.Name = "MotherNameLabel"
        MotherNameLabel.Size = New System.Drawing.Size(109, 20)
        MotherNameLabel.TabIndex = 185
        MotherNameLabel.Text = "Mother Name:"
        '
        'FatherContactNumberLabel
        '
        FatherContactNumberLabel.AutoSize = True
        FatherContactNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FatherContactNumberLabel.Location = New System.Drawing.Point(18, 1225)
        FatherContactNumberLabel.Name = "FatherContactNumberLabel"
        FatherContactNumberLabel.Size = New System.Drawing.Size(148, 20)
        FatherContactNumberLabel.TabIndex = 183
        FatherContactNumberLabel.Text = "Father Contact No.:"
        '
        'FatherWorkAddressLabel
        '
        FatherWorkAddressLabel.AutoSize = True
        FatherWorkAddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FatherWorkAddressLabel.Location = New System.Drawing.Point(18, 1199)
        FatherWorkAddressLabel.Name = "FatherWorkAddressLabel"
        FatherWorkAddressLabel.Size = New System.Drawing.Size(164, 20)
        FatherWorkAddressLabel.TabIndex = 181
        FatherWorkAddressLabel.Text = "Father Work Address:"
        '
        'FatherEmailLabel
        '
        FatherEmailLabel.AutoSize = True
        FatherEmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FatherEmailLabel.Location = New System.Drawing.Point(18, 1173)
        FatherEmailLabel.Name = "FatherEmailLabel"
        FatherEmailLabel.Size = New System.Drawing.Size(103, 20)
        FatherEmailLabel.TabIndex = 179
        FatherEmailLabel.Text = "Father Email:"
        '
        'FatherOccupationLabel
        '
        FatherOccupationLabel.AutoSize = True
        FatherOccupationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FatherOccupationLabel.Location = New System.Drawing.Point(18, 1147)
        FatherOccupationLabel.Name = "FatherOccupationLabel"
        FatherOccupationLabel.Size = New System.Drawing.Size(145, 20)
        FatherOccupationLabel.TabIndex = 177
        FatherOccupationLabel.Text = "Father Occupation:"
        '
        'FatherNameLabel
        '
        FatherNameLabel.AutoSize = True
        FatherNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FatherNameLabel.Location = New System.Drawing.Point(18, 1121)
        FatherNameLabel.Name = "FatherNameLabel"
        FatherNameLabel.Size = New System.Drawing.Size(106, 20)
        FatherNameLabel.TabIndex = 175
        FatherNameLabel.Text = "Father Name:"
        '
        'IdentifierLabel
        '
        IdentifierLabel.AutoSize = True
        IdentifierLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdentifierLabel.Location = New System.Drawing.Point(508, 35)
        IdentifierLabel.Name = "IdentifierLabel"
        IdentifierLabel.Size = New System.Drawing.Size(67, 17)
        IdentifierLabel.TabIndex = 284
        IdentifierLabel.Text = "Identifier:"
        IdentifierLabel.Visible = False
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatusLabel.Location = New System.Drawing.Point(508, 9)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(50, 17)
        StatusLabel.TabIndex = 392
        StatusLabel.Text = "Status:"
        StatusLabel.Visible = False
        '
        'ConditionLabel
        '
        ConditionLabel.AutoSize = True
        ConditionLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ConditionLabel.Location = New System.Drawing.Point(19, 1675)
        ConditionLabel.Name = "ConditionLabel"
        ConditionLabel.Size = New System.Drawing.Size(77, 17)
        ConditionLabel.TabIndex = 394
        ConditionLabel.Text = "Condition:"
        ConditionLabel.Visible = False
        '
        'Requirement1Label
        '
        Requirement1Label.AutoSize = True
        Requirement1Label.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Requirement1Label.Location = New System.Drawing.Point(19, 1701)
        Requirement1Label.Name = "Requirement1Label"
        Requirement1Label.Size = New System.Drawing.Size(101, 17)
        Requirement1Label.TabIndex = 396
        Requirement1Label.Text = "Requirement1:"
        Requirement1Label.Visible = False
        '
        'Requirement2Label
        '
        Requirement2Label.AutoSize = True
        Requirement2Label.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Requirement2Label.Location = New System.Drawing.Point(19, 1727)
        Requirement2Label.Name = "Requirement2Label"
        Requirement2Label.Size = New System.Drawing.Size(101, 17)
        Requirement2Label.TabIndex = 398
        Requirement2Label.Text = "Requirement2:"
        Requirement2Label.Visible = False
        '
        'Requirement3Label
        '
        Requirement3Label.AutoSize = True
        Requirement3Label.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Requirement3Label.Location = New System.Drawing.Point(19, 1753)
        Requirement3Label.Name = "Requirement3Label"
        Requirement3Label.Size = New System.Drawing.Size(101, 17)
        Requirement3Label.TabIndex = 400
        Requirement3Label.Text = "Requirement3:"
        Requirement3Label.Visible = False
        '
        'Requirement4Label
        '
        Requirement4Label.AutoSize = True
        Requirement4Label.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Requirement4Label.Location = New System.Drawing.Point(19, 1779)
        Requirement4Label.Name = "Requirement4Label"
        Requirement4Label.Size = New System.Drawing.Size(101, 17)
        Requirement4Label.TabIndex = 402
        Requirement4Label.Text = "Requirement4:"
        Requirement4Label.Visible = False
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(438, 1760)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(12, 17)
        Label1.TabIndex = 404
        Label1.Text = " "
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cmbStudentNum)
        Me.Panel1.Controls.Add(Me.btnGenerateID)
        Me.Panel1.Controls.Add(Me.btnDenied)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Me.EnrollmentNumberTextBox1)
        Me.Panel1.Controls.Add(Me.StudentNumberTextBox1)
        Me.Panel1.Controls.Add(Me.GradeLevelTextBox1)
        Me.Panel1.Controls.Add(Me.StrandTextBox1)
        Me.Panel1.Controls.Add(Me.SemesterTextBox1)
        Me.Panel1.Controls.Add(Me.SchoolYearTextBox1)
        Me.Panel1.Controls.Add(Me.LastnameTextBox1)
        Me.Panel1.Controls.Add(Me.FirstnameTextBox1)
        Me.Panel1.Controls.Add(Me.MiddlenameTextBox1)
        Me.Panel1.Controls.Add(Me.AgeTextBox1)
        Me.Panel1.Controls.Add(Me.DOBDateTimePicker1)
        Me.Panel1.Controls.Add(Me.SexTextBox1)
        Me.Panel1.Controls.Add(Me.POBTextBox1)
        Me.Panel1.Controls.Add(Me.NationalityTextBox1)
        Me.Panel1.Controls.Add(Me.ReligionTextBox1)
        Me.Panel1.Controls.Add(Me.EmailTextBox1)
        Me.Panel1.Controls.Add(Me.MobileNumberTextBox1)
        Me.Panel1.Controls.Add(Me.TelephoneNumberTextBox1)
        Me.Panel1.Controls.Add(Me.AddressTextBox1)
        Me.Panel1.Controls.Add(Me.CityTextBox1)
        Me.Panel1.Controls.Add(Me.FatherNameTextBox1)
        Me.Panel1.Controls.Add(Me.FatherOccupationTextBox1)
        Me.Panel1.Controls.Add(Me.FatherEmailTextBox1)
        Me.Panel1.Controls.Add(Me.FatherWorkAddressTextBox1)
        Me.Panel1.Controls.Add(Me.FatherContactNumberTextBox1)
        Me.Panel1.Controls.Add(Me.MotherNameTextBox1)
        Me.Panel1.Controls.Add(Me.MotherOccupationTextBox1)
        Me.Panel1.Controls.Add(Me.MotherEmailTextBox1)
        Me.Panel1.Controls.Add(Me.MotherWorkAddressTextBox1)
        Me.Panel1.Controls.Add(Me.MotherContactNumberTextBox1)
        Me.Panel1.Controls.Add(Me.NumberOfSiblingsTextBox1)
        Me.Panel1.Controls.Add(Me.PersonEmergencyTextBox1)
        Me.Panel1.Controls.Add(Me.GuardianNameTextBox1)
        Me.Panel1.Controls.Add(Me.GuardianRelationTextBox1)
        Me.Panel1.Controls.Add(Me.GuardianEmailTextBox1)
        Me.Panel1.Controls.Add(Me.GuardianWorkAddressTextBox1)
        Me.Panel1.Controls.Add(Me.GuardianContactNumberTextBox1)
        Me.Panel1.Controls.Add(Me.FetcherNameTextBox1)
        Me.Panel1.Controls.Add(Me.FetcherContactNumberTextBox1)
        Me.Panel1.Controls.Add(Me.SiblingsOfStudent1TextBox1)
        Me.Panel1.Controls.Add(Me.SiblingsOfStudent2TextBox1)
        Me.Panel1.Controls.Add(Me.SiblingsOfStudent3TextBox1)
        Me.Panel1.Controls.Add(Me.SiblingsOfStudentAge1TextBox1)
        Me.Panel1.Controls.Add(Me.SiblingsOfStudentAge2TextBox1)
        Me.Panel1.Controls.Add(Me.SiblingsOfStudentAge3TextBox1)
        Me.Panel1.Controls.Add(Me.SiblingsOfStudentSchool1TextBox1)
        Me.Panel1.Controls.Add(Me.SiblingsOfStudentSchool2TextBox1)
        Me.Panel1.Controls.Add(Me.SiblingsOfStudentSchool3TextBox1)
        Me.Panel1.Controls.Add(Me.SchoolLastAttended1TextBox1)
        Me.Panel1.Controls.Add(Me.SchoolLastAttended2TextBox1)
        Me.Panel1.Controls.Add(Me.SchoolLastAttended3TextBox1)
        Me.Panel1.Controls.Add(Me.AcademicYear1TextBox1)
        Me.Panel1.Controls.Add(Me.AcademicYear2TextBox1)
        Me.Panel1.Controls.Add(Me.AcademicYear3TextBox1)
        Me.Panel1.Controls.Add(Me.ReasonApplyingTextBox1)
        Me.Panel1.Controls.Add(ConditionLabel)
        Me.Panel1.Controls.Add(Me.ConditionTextBox)
        Me.Panel1.Controls.Add(Requirement1Label)
        Me.Panel1.Controls.Add(Me.Requirement1TextBox)
        Me.Panel1.Controls.Add(Requirement2Label)
        Me.Panel1.Controls.Add(Me.Requirement2TextBox)
        Me.Panel1.Controls.Add(Requirement3Label)
        Me.Panel1.Controls.Add(Me.Requirement3TextBox)
        Me.Panel1.Controls.Add(Requirement4Label)
        Me.Panel1.Controls.Add(Me.Requirement4TextBox)
        Me.Panel1.Controls.Add(Me.Label63)
        Me.Panel1.Controls.Add(Me.Label62)
        Me.Panel1.Controls.Add(Me.Label61)
        Me.Panel1.Controls.Add(Me.Label60)
        Me.Panel1.Controls.Add(Me.Label59)
        Me.Panel1.Controls.Add(Me.Label58)
        Me.Panel1.Controls.Add(Me.Label57)
        Me.Panel1.Controls.Add(Me.cmbCapture)
        Me.Panel1.Controls.Add(Me.btnCapture)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.btnRemove)
        Me.Panel1.Controls.Add(Me.btnBrowse)
        Me.Panel1.Controls.Add(Me.Label31)
        Me.Panel1.Controls.Add(Me.Label55)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(EnrollmentNumberLabel)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(StudentNumberLabel)
        Me.Panel1.Controls.Add(Me.btnApprove)
        Me.Panel1.Controls.Add(GradeLevelLabel)
        Me.Panel1.Controls.Add(StrandLabel)
        Me.Panel1.Controls.Add(SemesterLabel)
        Me.Panel1.Controls.Add(SchoolYearLabel)
        Me.Panel1.Controls.Add(LastnameLabel)
        Me.Panel1.Controls.Add(FirstnameLabel)
        Me.Panel1.Controls.Add(MiddlenameLabel)
        Me.Panel1.Controls.Add(AgeLabel)
        Me.Panel1.Controls.Add(DOBLabel)
        Me.Panel1.Controls.Add(SexLabel)
        Me.Panel1.Controls.Add(POBLabel)
        Me.Panel1.Controls.Add(NationalityLabel)
        Me.Panel1.Controls.Add(ReligionLabel)
        Me.Panel1.Controls.Add(EmailLabel)
        Me.Panel1.Controls.Add(MobileNumberLabel)
        Me.Panel1.Controls.Add(TelephoneNumberLabel)
        Me.Panel1.Controls.Add(AddressLabel)
        Me.Panel1.Controls.Add(CityLabel)
        Me.Panel1.Controls.Add(FatherNameLabel)
        Me.Panel1.Controls.Add(FatherOccupationLabel)
        Me.Panel1.Controls.Add(FatherEmailLabel)
        Me.Panel1.Controls.Add(FatherWorkAddressLabel)
        Me.Panel1.Controls.Add(FatherContactNumberLabel)
        Me.Panel1.Controls.Add(MotherNameLabel)
        Me.Panel1.Controls.Add(MotherOccupationLabel)
        Me.Panel1.Controls.Add(MotherEmailLabel)
        Me.Panel1.Controls.Add(MotherWorkAddressLabel)
        Me.Panel1.Controls.Add(MotherContactNumberLabel)
        Me.Panel1.Controls.Add(NumberOfSiblingsLabel)
        Me.Panel1.Controls.Add(PersonEmergencyLabel)
        Me.Panel1.Controls.Add(GuardianNameLabel)
        Me.Panel1.Controls.Add(GuardianRelationLabel)
        Me.Panel1.Controls.Add(GuardianEmailLabel)
        Me.Panel1.Controls.Add(GuardianWorkAddressLabel)
        Me.Panel1.Controls.Add(GuardianContactNumberLabel)
        Me.Panel1.Controls.Add(FetcherNameLabel)
        Me.Panel1.Controls.Add(FetcherContactNumberLabel)
        Me.Panel1.Controls.Add(SiblingsOfStudent1Label)
        Me.Panel1.Controls.Add(SiblingsOfStudent2Label)
        Me.Panel1.Controls.Add(SiblingsOfStudent3Label)
        Me.Panel1.Controls.Add(SiblingsOfStudentAge1Label)
        Me.Panel1.Controls.Add(SiblingsOfStudentAge2Label)
        Me.Panel1.Controls.Add(SiblingsOfStudentAge3Label)
        Me.Panel1.Controls.Add(SiblingsOfStudentSchool1Label)
        Me.Panel1.Controls.Add(SiblingsOfStudentSchool2Label)
        Me.Panel1.Controls.Add(SiblingsOfStudentSchool3Label)
        Me.Panel1.Controls.Add(SchoolLastAttended1Label)
        Me.Panel1.Controls.Add(SchoolLastAttended2Label)
        Me.Panel1.Controls.Add(SchoolLastAttended3Label)
        Me.Panel1.Controls.Add(AcademicYear1Label)
        Me.Panel1.Controls.Add(AcademicYear2Label)
        Me.Panel1.Controls.Add(AcademicYear3Label)
        Me.Panel1.Controls.Add(ReasonApplyingLabel)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.AdvancedDataGridView1)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Location = New System.Drawing.Point(46, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 475)
        Me.Panel1.TabIndex = 2
        '
        'cmbStudentNum
        '
        Me.cmbStudentNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbStudentNum.FormattingEnabled = True
        Me.cmbStudentNum.Location = New System.Drawing.Point(19, 6)
        Me.cmbStudentNum.Name = "cmbStudentNum"
        Me.cmbStudentNum.Size = New System.Drawing.Size(10, 20)
        Me.cmbStudentNum.TabIndex = 407
        Me.cmbStudentNum.Visible = False
        '
        'btnGenerateID
        '
        Me.btnGenerateID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGenerateID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateID.ForeColor = System.Drawing.Color.White
        Me.btnGenerateID.Image = CType(resources.GetObject("btnGenerateID.Image"), System.Drawing.Image)
        Me.btnGenerateID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerateID.Location = New System.Drawing.Point(154, 426)
        Me.btnGenerateID.Name = "btnGenerateID"
        Me.btnGenerateID.Size = New System.Drawing.Size(142, 38)
        Me.btnGenerateID.TabIndex = 406
        Me.btnGenerateID.Text = "&Generate ID"
        Me.btnGenerateID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenerateID.UseVisualStyleBackColor = False
        '
        'btnDenied
        '
        Me.btnDenied.BackColor = System.Drawing.Color.Purple
        Me.btnDenied.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDenied.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDenied.ForeColor = System.Drawing.Color.White
        Me.btnDenied.Image = CType(resources.GetObject("btnDenied.Image"), System.Drawing.Image)
        Me.btnDenied.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDenied.Location = New System.Drawing.Point(25, 426)
        Me.btnDenied.Name = "btnDenied"
        Me.btnDenied.Size = New System.Drawing.Size(123, 38)
        Me.btnDenied.TabIndex = 405
        Me.btnDenied.Text = "  &Denied"
        Me.btnDenied.UseVisualStyleBackColor = False
        '
        'EnrollmentNumberTextBox1
        '
        Me.EnrollmentNumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "EnrollmentNumber", True))
        Me.EnrollmentNumberTextBox1.Enabled = False
        Me.EnrollmentNumberTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnrollmentNumberTextBox1.Location = New System.Drawing.Point(201, 543)
        Me.EnrollmentNumberTextBox1.Name = "EnrollmentNumberTextBox1"
        Me.EnrollmentNumberTextBox1.Size = New System.Drawing.Size(239, 23)
        Me.EnrollmentNumberTextBox1.TabIndex = 281
        '
        'EnrollmentDataBindingSource
        '
        Me.EnrollmentDataBindingSource.DataMember = "EnrollmentData"
        Me.EnrollmentDataBindingSource.DataSource = Me.Pre_enrollmentDataSet
        '
        'Pre_enrollmentDataSet
        '
        Me.Pre_enrollmentDataSet.DataSetName = "Pre_enrollmentDataSet"
        Me.Pre_enrollmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentNumberTextBox1
        '
        Me.StudentNumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "StudentNumber", True))
        Me.StudentNumberTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentNumberTextBox1.Location = New System.Drawing.Point(201, 569)
        Me.StudentNumberTextBox1.MaxLength = 9
        Me.StudentNumberTextBox1.Name = "StudentNumberTextBox1"
        Me.StudentNumberTextBox1.Size = New System.Drawing.Size(239, 23)
        Me.StudentNumberTextBox1.TabIndex = 283
        '
        'GradeLevelTextBox1
        '
        Me.GradeLevelTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "GradeLevel", True))
        Me.GradeLevelTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeLevelTextBox1.Location = New System.Drawing.Point(201, 595)
        Me.GradeLevelTextBox1.Name = "GradeLevelTextBox1"
        Me.GradeLevelTextBox1.Size = New System.Drawing.Size(239, 23)
        Me.GradeLevelTextBox1.TabIndex = 287
        '
        'StrandTextBox1
        '
        Me.StrandTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "Strand", True))
        Me.StrandTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StrandTextBox1.Location = New System.Drawing.Point(614, 543)
        Me.StrandTextBox1.Name = "StrandTextBox1"
        Me.StrandTextBox1.Size = New System.Drawing.Size(258, 23)
        Me.StrandTextBox1.TabIndex = 289
        '
        'SemesterTextBox1
        '
        Me.SemesterTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "Semester", True))
        Me.SemesterTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SemesterTextBox1.Location = New System.Drawing.Point(614, 569)
        Me.SemesterTextBox1.Name = "SemesterTextBox1"
        Me.SemesterTextBox1.Size = New System.Drawing.Size(258, 23)
        Me.SemesterTextBox1.TabIndex = 291
        '
        'SchoolYearTextBox1
        '
        Me.SchoolYearTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "SchoolYear", True))
        Me.SchoolYearTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolYearTextBox1.Location = New System.Drawing.Point(614, 595)
        Me.SchoolYearTextBox1.Name = "SchoolYearTextBox1"
        Me.SchoolYearTextBox1.Size = New System.Drawing.Size(258, 23)
        Me.SchoolYearTextBox1.TabIndex = 293
        '
        'LastnameTextBox1
        '
        Me.LastnameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "Lastname", True))
        Me.LastnameTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastnameTextBox1.Location = New System.Drawing.Point(201, 621)
        Me.LastnameTextBox1.Name = "LastnameTextBox1"
        Me.LastnameTextBox1.Size = New System.Drawing.Size(239, 23)
        Me.LastnameTextBox1.TabIndex = 295
        '
        'FirstnameTextBox1
        '
        Me.FirstnameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "Firstname", True))
        Me.FirstnameTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstnameTextBox1.Location = New System.Drawing.Point(201, 647)
        Me.FirstnameTextBox1.Name = "FirstnameTextBox1"
        Me.FirstnameTextBox1.Size = New System.Drawing.Size(239, 23)
        Me.FirstnameTextBox1.TabIndex = 297
        '
        'MiddlenameTextBox1
        '
        Me.MiddlenameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "Middlename", True))
        Me.MiddlenameTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiddlenameTextBox1.Location = New System.Drawing.Point(201, 673)
        Me.MiddlenameTextBox1.Name = "MiddlenameTextBox1"
        Me.MiddlenameTextBox1.Size = New System.Drawing.Size(239, 23)
        Me.MiddlenameTextBox1.TabIndex = 299
        '
        'AgeTextBox1
        '
        Me.AgeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "Age", True))
        Me.AgeTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox1.Location = New System.Drawing.Point(614, 621)
        Me.AgeTextBox1.MaxLength = 2
        Me.AgeTextBox1.Name = "AgeTextBox1"
        Me.AgeTextBox1.Size = New System.Drawing.Size(258, 23)
        Me.AgeTextBox1.TabIndex = 301
        '
        'DOBDateTimePicker1
        '
        Me.DOBDateTimePicker1.CustomFormat = "MMMM / d / yyyy"
        Me.DOBDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EnrollmentDataBindingSource, "DOB", True))
        Me.DOBDateTimePicker1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOBDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DOBDateTimePicker1.Location = New System.Drawing.Point(614, 647)
        Me.DOBDateTimePicker1.Name = "DOBDateTimePicker1"
        Me.DOBDateTimePicker1.Size = New System.Drawing.Size(258, 23)
        Me.DOBDateTimePicker1.TabIndex = 303
        '
        'SexTextBox1
        '
        Me.SexTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "Sex", True))
        Me.SexTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SexTextBox1.Location = New System.Drawing.Point(614, 673)
        Me.SexTextBox1.Name = "SexTextBox1"
        Me.SexTextBox1.Size = New System.Drawing.Size(258, 23)
        Me.SexTextBox1.TabIndex = 305
        '
        'POBTextBox1
        '
        Me.POBTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "POB", True))
        Me.POBTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POBTextBox1.Location = New System.Drawing.Point(614, 699)
        Me.POBTextBox1.Name = "POBTextBox1"
        Me.POBTextBox1.Size = New System.Drawing.Size(258, 23)
        Me.POBTextBox1.TabIndex = 307
        '
        'NationalityTextBox1
        '
        Me.NationalityTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "Nationality", True))
        Me.NationalityTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NationalityTextBox1.Location = New System.Drawing.Point(614, 725)
        Me.NationalityTextBox1.Name = "NationalityTextBox1"
        Me.NationalityTextBox1.Size = New System.Drawing.Size(258, 23)
        Me.NationalityTextBox1.TabIndex = 309
        '
        'ReligionTextBox1
        '
        Me.ReligionTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "Religion", True))
        Me.ReligionTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReligionTextBox1.Location = New System.Drawing.Point(614, 751)
        Me.ReligionTextBox1.Name = "ReligionTextBox1"
        Me.ReligionTextBox1.Size = New System.Drawing.Size(258, 23)
        Me.ReligionTextBox1.TabIndex = 311
        '
        'EmailTextBox1
        '
        Me.EmailTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "Email", True))
        Me.EmailTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox1.Location = New System.Drawing.Point(201, 699)
        Me.EmailTextBox1.Name = "EmailTextBox1"
        Me.EmailTextBox1.Size = New System.Drawing.Size(239, 23)
        Me.EmailTextBox1.TabIndex = 313
        '
        'MobileNumberTextBox1
        '
        Me.MobileNumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "MobileNumber", True))
        Me.MobileNumberTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileNumberTextBox1.Location = New System.Drawing.Point(201, 725)
        Me.MobileNumberTextBox1.MaxLength = 11
        Me.MobileNumberTextBox1.Name = "MobileNumberTextBox1"
        Me.MobileNumberTextBox1.Size = New System.Drawing.Size(239, 23)
        Me.MobileNumberTextBox1.TabIndex = 315
        '
        'TelephoneNumberTextBox1
        '
        Me.TelephoneNumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "TelephoneNumber", True))
        Me.TelephoneNumberTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelephoneNumberTextBox1.Location = New System.Drawing.Point(201, 751)
        Me.TelephoneNumberTextBox1.Name = "TelephoneNumberTextBox1"
        Me.TelephoneNumberTextBox1.Size = New System.Drawing.Size(239, 23)
        Me.TelephoneNumberTextBox1.TabIndex = 317
        '
        'AddressTextBox1
        '
        Me.AddressTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "Address", True))
        Me.AddressTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox1.Location = New System.Drawing.Point(201, 777)
        Me.AddressTextBox1.Name = "AddressTextBox1"
        Me.AddressTextBox1.Size = New System.Drawing.Size(239, 23)
        Me.AddressTextBox1.TabIndex = 319
        '
        'CityTextBox1
        '
        Me.CityTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "City", True))
        Me.CityTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox1.Location = New System.Drawing.Point(614, 777)
        Me.CityTextBox1.Name = "CityTextBox1"
        Me.CityTextBox1.Size = New System.Drawing.Size(258, 23)
        Me.CityTextBox1.TabIndex = 321
        '
        'FatherNameTextBox1
        '
        Me.FatherNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "FatherName", True))
        Me.FatherNameTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FatherNameTextBox1.Location = New System.Drawing.Point(199, 1117)
        Me.FatherNameTextBox1.Name = "FatherNameTextBox1"
        Me.FatherNameTextBox1.Size = New System.Drawing.Size(241, 23)
        Me.FatherNameTextBox1.TabIndex = 323
        '
        'FatherOccupationTextBox1
        '
        Me.FatherOccupationTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "FatherOccupation", True))
        Me.FatherOccupationTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FatherOccupationTextBox1.Location = New System.Drawing.Point(199, 1143)
        Me.FatherOccupationTextBox1.Name = "FatherOccupationTextBox1"
        Me.FatherOccupationTextBox1.Size = New System.Drawing.Size(241, 23)
        Me.FatherOccupationTextBox1.TabIndex = 325
        '
        'FatherEmailTextBox1
        '
        Me.FatherEmailTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "FatherEmail", True))
        Me.FatherEmailTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FatherEmailTextBox1.Location = New System.Drawing.Point(199, 1169)
        Me.FatherEmailTextBox1.Name = "FatherEmailTextBox1"
        Me.FatherEmailTextBox1.Size = New System.Drawing.Size(241, 23)
        Me.FatherEmailTextBox1.TabIndex = 327
        '
        'FatherWorkAddressTextBox1
        '
        Me.FatherWorkAddressTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "FatherWorkAddress", True))
        Me.FatherWorkAddressTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FatherWorkAddressTextBox1.Location = New System.Drawing.Point(199, 1195)
        Me.FatherWorkAddressTextBox1.Name = "FatherWorkAddressTextBox1"
        Me.FatherWorkAddressTextBox1.Size = New System.Drawing.Size(241, 23)
        Me.FatherWorkAddressTextBox1.TabIndex = 329
        '
        'FatherContactNumberTextBox1
        '
        Me.FatherContactNumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "FatherContactNumber", True))
        Me.FatherContactNumberTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FatherContactNumberTextBox1.Location = New System.Drawing.Point(199, 1221)
        Me.FatherContactNumberTextBox1.MaxLength = 11
        Me.FatherContactNumberTextBox1.Name = "FatherContactNumberTextBox1"
        Me.FatherContactNumberTextBox1.Size = New System.Drawing.Size(241, 23)
        Me.FatherContactNumberTextBox1.TabIndex = 331
        '
        'MotherNameTextBox1
        '
        Me.MotherNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "MotherName", True))
        Me.MotherNameTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotherNameTextBox1.Location = New System.Drawing.Point(614, 1118)
        Me.MotherNameTextBox1.Name = "MotherNameTextBox1"
        Me.MotherNameTextBox1.Size = New System.Drawing.Size(258, 23)
        Me.MotherNameTextBox1.TabIndex = 333
        '
        'MotherOccupationTextBox1
        '
        Me.MotherOccupationTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "MotherOccupation", True))
        Me.MotherOccupationTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotherOccupationTextBox1.Location = New System.Drawing.Point(614, 1144)
        Me.MotherOccupationTextBox1.Name = "MotherOccupationTextBox1"
        Me.MotherOccupationTextBox1.Size = New System.Drawing.Size(258, 23)
        Me.MotherOccupationTextBox1.TabIndex = 335
        '
        'MotherEmailTextBox1
        '
        Me.MotherEmailTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "MotherEmail", True))
        Me.MotherEmailTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotherEmailTextBox1.Location = New System.Drawing.Point(614, 1170)
        Me.MotherEmailTextBox1.Name = "MotherEmailTextBox1"
        Me.MotherEmailTextBox1.Size = New System.Drawing.Size(258, 23)
        Me.MotherEmailTextBox1.TabIndex = 337
        '
        'MotherWorkAddressTextBox1
        '
        Me.MotherWorkAddressTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "MotherWorkAddress", True))
        Me.MotherWorkAddressTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotherWorkAddressTextBox1.Location = New System.Drawing.Point(614, 1196)
        Me.MotherWorkAddressTextBox1.Name = "MotherWorkAddressTextBox1"
        Me.MotherWorkAddressTextBox1.Size = New System.Drawing.Size(258, 23)
        Me.MotherWorkAddressTextBox1.TabIndex = 339
        '
        'MotherContactNumberTextBox1
        '
        Me.MotherContactNumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "MotherContactNumber", True))
        Me.MotherContactNumberTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotherContactNumberTextBox1.Location = New System.Drawing.Point(614, 1222)
        Me.MotherContactNumberTextBox1.MaxLength = 11
        Me.MotherContactNumberTextBox1.Name = "MotherContactNumberTextBox1"
        Me.MotherContactNumberTextBox1.Size = New System.Drawing.Size(258, 23)
        Me.MotherContactNumberTextBox1.TabIndex = 341
        '
        'NumberOfSiblingsTextBox1
        '
        Me.NumberOfSiblingsTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "NumberOfSiblings", True))
        Me.NumberOfSiblingsTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfSiblingsTextBox1.Location = New System.Drawing.Point(199, 1248)
        Me.NumberOfSiblingsTextBox1.Name = "NumberOfSiblingsTextBox1"
        Me.NumberOfSiblingsTextBox1.Size = New System.Drawing.Size(241, 23)
        Me.NumberOfSiblingsTextBox1.TabIndex = 343
        '
        'PersonEmergencyTextBox1
        '
        Me.PersonEmergencyTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "PersonEmergency", True))
        Me.PersonEmergencyTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonEmergencyTextBox1.Location = New System.Drawing.Point(614, 1248)
        Me.PersonEmergencyTextBox1.Name = "PersonEmergencyTextBox1"
        Me.PersonEmergencyTextBox1.Size = New System.Drawing.Size(258, 23)
        Me.PersonEmergencyTextBox1.TabIndex = 345
        '
        'GuardianNameTextBox1
        '
        Me.GuardianNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "GuardianName", True))
        Me.GuardianNameTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardianNameTextBox1.Location = New System.Drawing.Point(199, 1275)
        Me.GuardianNameTextBox1.Name = "GuardianNameTextBox1"
        Me.GuardianNameTextBox1.Size = New System.Drawing.Size(241, 23)
        Me.GuardianNameTextBox1.TabIndex = 347
        '
        'GuardianRelationTextBox1
        '
        Me.GuardianRelationTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "GuardianRelation", True))
        Me.GuardianRelationTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardianRelationTextBox1.Location = New System.Drawing.Point(199, 1301)
        Me.GuardianRelationTextBox1.Name = "GuardianRelationTextBox1"
        Me.GuardianRelationTextBox1.Size = New System.Drawing.Size(241, 23)
        Me.GuardianRelationTextBox1.TabIndex = 349
        '
        'GuardianEmailTextBox1
        '
        Me.GuardianEmailTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "GuardianEmail", True))
        Me.GuardianEmailTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardianEmailTextBox1.Location = New System.Drawing.Point(199, 1327)
        Me.GuardianEmailTextBox1.Name = "GuardianEmailTextBox1"
        Me.GuardianEmailTextBox1.Size = New System.Drawing.Size(241, 23)
        Me.GuardianEmailTextBox1.TabIndex = 351
        '
        'GuardianWorkAddressTextBox1
        '
        Me.GuardianWorkAddressTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "GuardianWorkAddress", True))
        Me.GuardianWorkAddressTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardianWorkAddressTextBox1.Location = New System.Drawing.Point(199, 1353)
        Me.GuardianWorkAddressTextBox1.Name = "GuardianWorkAddressTextBox1"
        Me.GuardianWorkAddressTextBox1.Size = New System.Drawing.Size(241, 23)
        Me.GuardianWorkAddressTextBox1.TabIndex = 353
        '
        'GuardianContactNumberTextBox1
        '
        Me.GuardianContactNumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "GuardianContactNumber", True))
        Me.GuardianContactNumberTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardianContactNumberTextBox1.Location = New System.Drawing.Point(199, 1379)
        Me.GuardianContactNumberTextBox1.MaxLength = 11
        Me.GuardianContactNumberTextBox1.Name = "GuardianContactNumberTextBox1"
        Me.GuardianContactNumberTextBox1.Size = New System.Drawing.Size(241, 23)
        Me.GuardianContactNumberTextBox1.TabIndex = 355
        '
        'FetcherNameTextBox1
        '
        Me.FetcherNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "FetcherName", True))
        Me.FetcherNameTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FetcherNameTextBox1.Location = New System.Drawing.Point(614, 1275)
        Me.FetcherNameTextBox1.Name = "FetcherNameTextBox1"
        Me.FetcherNameTextBox1.Size = New System.Drawing.Size(258, 23)
        Me.FetcherNameTextBox1.TabIndex = 357
        '
        'FetcherContactNumberTextBox1
        '
        Me.FetcherContactNumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "FetcherContactNumber", True))
        Me.FetcherContactNumberTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FetcherContactNumberTextBox1.Location = New System.Drawing.Point(614, 1301)
        Me.FetcherContactNumberTextBox1.MaxLength = 11
        Me.FetcherContactNumberTextBox1.Name = "FetcherContactNumberTextBox1"
        Me.FetcherContactNumberTextBox1.Size = New System.Drawing.Size(258, 23)
        Me.FetcherContactNumberTextBox1.TabIndex = 359
        '
        'SiblingsOfStudent1TextBox1
        '
        Me.SiblingsOfStudent1TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "SiblingsOfStudent1", True))
        Me.SiblingsOfStudent1TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiblingsOfStudent1TextBox1.Location = New System.Drawing.Point(199, 1408)
        Me.SiblingsOfStudent1TextBox1.Name = "SiblingsOfStudent1TextBox1"
        Me.SiblingsOfStudent1TextBox1.Size = New System.Drawing.Size(186, 23)
        Me.SiblingsOfStudent1TextBox1.TabIndex = 361
        '
        'SiblingsOfStudent2TextBox1
        '
        Me.SiblingsOfStudent2TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "SiblingsOfStudent2", True))
        Me.SiblingsOfStudent2TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiblingsOfStudent2TextBox1.Location = New System.Drawing.Point(199, 1434)
        Me.SiblingsOfStudent2TextBox1.Name = "SiblingsOfStudent2TextBox1"
        Me.SiblingsOfStudent2TextBox1.Size = New System.Drawing.Size(186, 23)
        Me.SiblingsOfStudent2TextBox1.TabIndex = 363
        '
        'SiblingsOfStudent3TextBox1
        '
        Me.SiblingsOfStudent3TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "SiblingsOfStudent3", True))
        Me.SiblingsOfStudent3TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiblingsOfStudent3TextBox1.Location = New System.Drawing.Point(199, 1460)
        Me.SiblingsOfStudent3TextBox1.Name = "SiblingsOfStudent3TextBox1"
        Me.SiblingsOfStudent3TextBox1.Size = New System.Drawing.Size(186, 23)
        Me.SiblingsOfStudent3TextBox1.TabIndex = 365
        '
        'SiblingsOfStudentAge1TextBox1
        '
        Me.SiblingsOfStudentAge1TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "SiblingsOfStudentAge1", True))
        Me.SiblingsOfStudentAge1TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiblingsOfStudentAge1TextBox1.Location = New System.Drawing.Point(507, 1408)
        Me.SiblingsOfStudentAge1TextBox1.MaxLength = 2
        Me.SiblingsOfStudentAge1TextBox1.Name = "SiblingsOfStudentAge1TextBox1"
        Me.SiblingsOfStudentAge1TextBox1.Size = New System.Drawing.Size(39, 23)
        Me.SiblingsOfStudentAge1TextBox1.TabIndex = 367
        '
        'SiblingsOfStudentAge2TextBox1
        '
        Me.SiblingsOfStudentAge2TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "SiblingsOfStudentAge2", True))
        Me.SiblingsOfStudentAge2TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiblingsOfStudentAge2TextBox1.Location = New System.Drawing.Point(507, 1434)
        Me.SiblingsOfStudentAge2TextBox1.MaxLength = 2
        Me.SiblingsOfStudentAge2TextBox1.Name = "SiblingsOfStudentAge2TextBox1"
        Me.SiblingsOfStudentAge2TextBox1.Size = New System.Drawing.Size(39, 23)
        Me.SiblingsOfStudentAge2TextBox1.TabIndex = 369
        '
        'SiblingsOfStudentAge3TextBox1
        '
        Me.SiblingsOfStudentAge3TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "SiblingsOfStudentAge3", True))
        Me.SiblingsOfStudentAge3TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiblingsOfStudentAge3TextBox1.Location = New System.Drawing.Point(507, 1460)
        Me.SiblingsOfStudentAge3TextBox1.MaxLength = 2
        Me.SiblingsOfStudentAge3TextBox1.Name = "SiblingsOfStudentAge3TextBox1"
        Me.SiblingsOfStudentAge3TextBox1.Size = New System.Drawing.Size(39, 23)
        Me.SiblingsOfStudentAge3TextBox1.TabIndex = 371
        '
        'SiblingsOfStudentSchool1TextBox1
        '
        Me.SiblingsOfStudentSchool1TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "SiblingsOfStudentSchool1", True))
        Me.SiblingsOfStudentSchool1TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiblingsOfStudentSchool1TextBox1.Location = New System.Drawing.Point(692, 1408)
        Me.SiblingsOfStudentSchool1TextBox1.Name = "SiblingsOfStudentSchool1TextBox1"
        Me.SiblingsOfStudentSchool1TextBox1.Size = New System.Drawing.Size(180, 23)
        Me.SiblingsOfStudentSchool1TextBox1.TabIndex = 373
        '
        'SiblingsOfStudentSchool2TextBox1
        '
        Me.SiblingsOfStudentSchool2TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "SiblingsOfStudentSchool2", True))
        Me.SiblingsOfStudentSchool2TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiblingsOfStudentSchool2TextBox1.Location = New System.Drawing.Point(692, 1434)
        Me.SiblingsOfStudentSchool2TextBox1.Name = "SiblingsOfStudentSchool2TextBox1"
        Me.SiblingsOfStudentSchool2TextBox1.Size = New System.Drawing.Size(180, 23)
        Me.SiblingsOfStudentSchool2TextBox1.TabIndex = 375
        '
        'SiblingsOfStudentSchool3TextBox1
        '
        Me.SiblingsOfStudentSchool3TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "SiblingsOfStudentSchool3", True))
        Me.SiblingsOfStudentSchool3TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiblingsOfStudentSchool3TextBox1.Location = New System.Drawing.Point(692, 1460)
        Me.SiblingsOfStudentSchool3TextBox1.Name = "SiblingsOfStudentSchool3TextBox1"
        Me.SiblingsOfStudentSchool3TextBox1.Size = New System.Drawing.Size(180, 23)
        Me.SiblingsOfStudentSchool3TextBox1.TabIndex = 377
        '
        'SchoolLastAttended1TextBox1
        '
        Me.SchoolLastAttended1TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "SchoolLastAttended1", True))
        Me.SchoolLastAttended1TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolLastAttended1TextBox1.Location = New System.Drawing.Point(199, 1546)
        Me.SchoolLastAttended1TextBox1.Name = "SchoolLastAttended1TextBox1"
        Me.SchoolLastAttended1TextBox1.Size = New System.Drawing.Size(241, 23)
        Me.SchoolLastAttended1TextBox1.TabIndex = 379
        '
        'SchoolLastAttended2TextBox1
        '
        Me.SchoolLastAttended2TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "SchoolLastAttended2", True))
        Me.SchoolLastAttended2TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolLastAttended2TextBox1.Location = New System.Drawing.Point(199, 1572)
        Me.SchoolLastAttended2TextBox1.Name = "SchoolLastAttended2TextBox1"
        Me.SchoolLastAttended2TextBox1.Size = New System.Drawing.Size(241, 23)
        Me.SchoolLastAttended2TextBox1.TabIndex = 381
        '
        'SchoolLastAttended3TextBox1
        '
        Me.SchoolLastAttended3TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "SchoolLastAttended3", True))
        Me.SchoolLastAttended3TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolLastAttended3TextBox1.Location = New System.Drawing.Point(199, 1598)
        Me.SchoolLastAttended3TextBox1.Name = "SchoolLastAttended3TextBox1"
        Me.SchoolLastAttended3TextBox1.Size = New System.Drawing.Size(241, 23)
        Me.SchoolLastAttended3TextBox1.TabIndex = 383
        '
        'AcademicYear1TextBox1
        '
        Me.AcademicYear1TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "AcademicYear1", True))
        Me.AcademicYear1TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcademicYear1TextBox1.Location = New System.Drawing.Point(614, 1546)
        Me.AcademicYear1TextBox1.MaxLength = 11
        Me.AcademicYear1TextBox1.Name = "AcademicYear1TextBox1"
        Me.AcademicYear1TextBox1.Size = New System.Drawing.Size(258, 23)
        Me.AcademicYear1TextBox1.TabIndex = 385
        '
        'AcademicYear2TextBox1
        '
        Me.AcademicYear2TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "AcademicYear2", True))
        Me.AcademicYear2TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcademicYear2TextBox1.Location = New System.Drawing.Point(614, 1572)
        Me.AcademicYear2TextBox1.MaxLength = 11
        Me.AcademicYear2TextBox1.Name = "AcademicYear2TextBox1"
        Me.AcademicYear2TextBox1.Size = New System.Drawing.Size(258, 23)
        Me.AcademicYear2TextBox1.TabIndex = 387
        '
        'AcademicYear3TextBox1
        '
        Me.AcademicYear3TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "AcademicYear3", True))
        Me.AcademicYear3TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcademicYear3TextBox1.Location = New System.Drawing.Point(614, 1598)
        Me.AcademicYear3TextBox1.MaxLength = 11
        Me.AcademicYear3TextBox1.Name = "AcademicYear3TextBox1"
        Me.AcademicYear3TextBox1.Size = New System.Drawing.Size(258, 23)
        Me.AcademicYear3TextBox1.TabIndex = 389
        '
        'ReasonApplyingTextBox1
        '
        Me.ReasonApplyingTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "ReasonApplying", True))
        Me.ReasonApplyingTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReasonApplyingTextBox1.Location = New System.Drawing.Point(201, 1634)
        Me.ReasonApplyingTextBox1.Multiline = True
        Me.ReasonApplyingTextBox1.Name = "ReasonApplyingTextBox1"
        Me.ReasonApplyingTextBox1.Size = New System.Drawing.Size(671, 123)
        Me.ReasonApplyingTextBox1.TabIndex = 391
        '
        'ConditionTextBox
        '
        Me.ConditionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "Condition", True))
        Me.ConditionTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConditionTextBox.Location = New System.Drawing.Point(126, 1672)
        Me.ConditionTextBox.MaxLength = 1
        Me.ConditionTextBox.Name = "ConditionTextBox"
        Me.ConditionTextBox.Size = New System.Drawing.Size(44, 23)
        Me.ConditionTextBox.TabIndex = 395
        Me.ConditionTextBox.Visible = False
        '
        'Requirement1TextBox
        '
        Me.Requirement1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "Requirement1", True))
        Me.Requirement1TextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Requirement1TextBox.Location = New System.Drawing.Point(126, 1698)
        Me.Requirement1TextBox.MaxLength = 1
        Me.Requirement1TextBox.Name = "Requirement1TextBox"
        Me.Requirement1TextBox.Size = New System.Drawing.Size(44, 23)
        Me.Requirement1TextBox.TabIndex = 397
        Me.Requirement1TextBox.Visible = False
        '
        'Requirement2TextBox
        '
        Me.Requirement2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "Requirement2", True))
        Me.Requirement2TextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Requirement2TextBox.Location = New System.Drawing.Point(126, 1724)
        Me.Requirement2TextBox.MaxLength = 1
        Me.Requirement2TextBox.Name = "Requirement2TextBox"
        Me.Requirement2TextBox.Size = New System.Drawing.Size(44, 23)
        Me.Requirement2TextBox.TabIndex = 399
        Me.Requirement2TextBox.Visible = False
        '
        'Requirement3TextBox
        '
        Me.Requirement3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "Requirement3", True))
        Me.Requirement3TextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Requirement3TextBox.Location = New System.Drawing.Point(126, 1750)
        Me.Requirement3TextBox.MaxLength = 1
        Me.Requirement3TextBox.Name = "Requirement3TextBox"
        Me.Requirement3TextBox.Size = New System.Drawing.Size(44, 23)
        Me.Requirement3TextBox.TabIndex = 401
        Me.Requirement3TextBox.Visible = False
        '
        'Requirement4TextBox
        '
        Me.Requirement4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "Requirement4", True))
        Me.Requirement4TextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Requirement4TextBox.Location = New System.Drawing.Point(126, 1776)
        Me.Requirement4TextBox.MaxLength = 1
        Me.Requirement4TextBox.Name = "Requirement4TextBox"
        Me.Requirement4TextBox.Size = New System.Drawing.Size(44, 23)
        Me.Requirement4TextBox.TabIndex = 403
        Me.Requirement4TextBox.Visible = False
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(27, 935)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(19, 25)
        Me.Label63.TabIndex = 280
        Me.Label63.Text = "•"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(27, 887)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(19, 25)
        Me.Label62.TabIndex = 279
        Me.Label62.Text = "•"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(27, 861)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(19, 25)
        Me.Label61.TabIndex = 278
        Me.Label61.Text = "•"
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(41, 937)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(456, 48)
        Me.Label60.TabIndex = 277
        Me.Label60.Text = "Taken in the past seven (7) days prior to filing of online application"
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(42, 889)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(455, 48)
        Me.Label59.TabIndex = 276
        Me.Label59.Text = "Formal pose with collar and no eyeglasses or any accessories that may cover the f" &
    "acial features"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(42, 864)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(455, 22)
        Me.Label58.TabIndex = 275
        Me.Label58.Text = "2 x 2 inch, colored photo with white background"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(8, 829)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(193, 32)
        Me.Label57.TabIndex = 274
        Me.Label57.Text = "Student Photo"
        '
        'cmbCapture
        '
        Me.cmbCapture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbCapture.FormattingEnabled = True
        Me.cmbCapture.Location = New System.Drawing.Point(3, 6)
        Me.cmbCapture.Name = "cmbCapture"
        Me.cmbCapture.Size = New System.Drawing.Size(10, 20)
        Me.cmbCapture.TabIndex = 273
        Me.cmbCapture.Visible = False
        '
        'btnCapture
        '
        Me.btnCapture.BackColor = System.Drawing.Color.Navy
        Me.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCapture.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapture.ForeColor = System.Drawing.Color.White
        Me.btnCapture.Image = CType(resources.GetObject("btnCapture.Image"), System.Drawing.Image)
        Me.btnCapture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCapture.Location = New System.Drawing.Point(516, 1045)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(109, 30)
        Me.btnCapture.TabIndex = 25
        Me.btnCapture.Text = "&Capture"
        Me.btnCapture.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCapture.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureID)
        Me.GroupBox2.Location = New System.Drawing.Point(579, 821)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 218)
        Me.GroupBox2.TabIndex = 270
        Me.GroupBox2.TabStop = False
        '
        'PictureID
        '
        Me.PictureID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureID.Image = CType(resources.GetObject("PictureID.Image"), System.Drawing.Image)
        Me.PictureID.Location = New System.Drawing.Point(7, 11)
        Me.PictureID.Name = "PictureID"
        Me.PictureID.Size = New System.Drawing.Size(200, 200)
        Me.PictureID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureID.TabIndex = 11
        Me.PictureID.TabStop = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Maroon
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemove.Location = New System.Drawing.Point(746, 1045)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(109, 30)
        Me.btnRemove.TabIndex = 27
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.Green
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Image = CType(resources.GetObject("btnBrowse.Image"), System.Drawing.Image)
        Me.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBrowse.Location = New System.Drawing.Point(631, 1045)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(109, 30)
        Me.btnBrowse.TabIndex = 26
        Me.btnBrowse.Text = "&Browse  "
        Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Century Gothic", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(12, 1505)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(867, 38)
        Me.Label31.TabIndex = 266
        Me.Label31.Text = "Educational Background                                                    "
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Century Gothic", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(15, 1078)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(867, 38)
        Me.Label55.TabIndex = 265
        Me.Label55.Text = "Family Record                                                                    " &
    "  "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 502)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(862, 38)
        Me.Label7.TabIndex = 264
        Me.Label7.Text = "Personal Information                                                           "
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Maroon
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(752, 427)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(123, 38)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "    &Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(623, 427)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(123, 38)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "    &Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.Navy
        Me.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApprove.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.ForeColor = System.Drawing.Color.White
        Me.btnApprove.Image = CType(resources.GetObject("btnApprove.Image"), System.Drawing.Image)
        Me.btnApprove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApprove.Location = New System.Drawing.Point(494, 426)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(123, 38)
        Me.btnApprove.TabIndex = 2
        Me.btnApprove.Text = "     &Approve"
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(619, 393)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(211, 20)
        Me.lblTotal.TabIndex = 135
        Me.lblTotal.Text = "Total Student Pre-enrolled: 0"
        '
        'AdvancedDataGridView1
        '
        Me.AdvancedDataGridView1.AllowUserToAddRows = False
        Me.AdvancedDataGridView1.AllowUserToDeleteRows = False
        Me.AdvancedDataGridView1.AllowUserToOrderColumns = True
        Me.AdvancedDataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdvancedDataGridView1.AutoGenerateColumns = False
        Me.AdvancedDataGridView1.AutoGenerateContextFilters = True
        Me.AdvancedDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.AdvancedDataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AdvancedDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.AdvancedDataGridView1.ColumnHeadersHeight = 24
        Me.AdvancedDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentPictureDataGridViewImageColumn, Me.Approve, Me.EnrollmentNumberDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.StudentNumberDataGridViewTextBoxColumn, Me.IdentifierDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.MiddlenameDataGridViewTextBoxColumn, Me.GradeLevelDataGridViewTextBoxColumn, Me.StrandDataGridViewTextBoxColumn, Me.SemesterDataGridViewTextBoxColumn, Me.SchoolYearDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.POBDataGridViewTextBoxColumn, Me.NationalityDataGridViewTextBoxColumn, Me.ReligionDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.MobileNumberDataGridViewTextBoxColumn, Me.TelephoneNumberDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.FatherNameDataGridViewTextBoxColumn, Me.FatherOccupationDataGridViewTextBoxColumn, Me.FatherEmailDataGridViewTextBoxColumn, Me.FatherWorkAddressDataGridViewTextBoxColumn, Me.FatherContactNumberDataGridViewTextBoxColumn, Me.MotherNameDataGridViewTextBoxColumn, Me.MotherOccupationDataGridViewTextBoxColumn, Me.MotherEmailDataGridViewTextBoxColumn, Me.MotherWorkAddressDataGridViewTextBoxColumn, Me.MotherContactNumberDataGridViewTextBoxColumn, Me.NumberOfSiblingsDataGridViewTextBoxColumn, Me.PersonEmergencyDataGridViewTextBoxColumn, Me.GuardianNameDataGridViewTextBoxColumn, Me.GuardianRelationDataGridViewTextBoxColumn, Me.GuardianEmailDataGridViewTextBoxColumn, Me.GuardianWorkAddressDataGridViewTextBoxColumn, Me.GuardianContactNumberDataGridViewTextBoxColumn, Me.FetcherNameDataGridViewTextBoxColumn, Me.FetcherContactNumberDataGridViewTextBoxColumn, Me.SiblingsOfStudent1DataGridViewTextBoxColumn, Me.SiblingsOfStudent2DataGridViewTextBoxColumn, Me.SiblingsOfStudent3DataGridViewTextBoxColumn, Me.SiblingsOfStudentAge1DataGridViewTextBoxColumn, Me.SiblingsOfStudentAge2DataGridViewTextBoxColumn, Me.SiblingsOfStudentAge3DataGridViewTextBoxColumn, Me.SiblingsOfStudentSchool1DataGridViewTextBoxColumn, Me.SiblingsOfStudentSchool2DataGridViewTextBoxColumn, Me.SiblingsOfStudentSchool3DataGridViewTextBoxColumn, Me.SchoolLastAttended1DataGridViewTextBoxColumn, Me.SchoolLastAttended2DataGridViewTextBoxColumn, Me.SchoolLastAttended3DataGridViewTextBoxColumn, Me.AcademicYear1DataGridViewTextBoxColumn, Me.AcademicYear2DataGridViewTextBoxColumn, Me.AcademicYear3DataGridViewTextBoxColumn, Me.ReasonApplyingDataGridViewTextBoxColumn, Me.ConditionDataGridViewTextBoxColumn, Me.Requirement1DataGridViewTextBoxColumn, Me.Requirement2DataGridViewTextBoxColumn, Me.Requirement3DataGridViewTextBoxColumn, Me.Requirement4DataGridViewTextBoxColumn})
        Me.AdvancedDataGridView1.DataSource = Me.EnrollmentDataBindingSource
        Me.AdvancedDataGridView1.DateWithTime = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AdvancedDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.AdvancedDataGridView1.Location = New System.Drawing.Point(25, 65)
        Me.AdvancedDataGridView1.MultiSelect = False
        Me.AdvancedDataGridView1.Name = "AdvancedDataGridView1"
        Me.AdvancedDataGridView1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AdvancedDataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.AdvancedDataGridView1.Size = New System.Drawing.Size(850, 325)
        Me.AdvancedDataGridView1.TabIndex = 134
        Me.AdvancedDataGridView1.TimeFilter = False
        '
        'StudentPictureDataGridViewImageColumn
        '
        Me.StudentPictureDataGridViewImageColumn.DataPropertyName = "StudentPicture"
        Me.StudentPictureDataGridViewImageColumn.HeaderText = "StudentPicture"
        Me.StudentPictureDataGridViewImageColumn.MinimumWidth = 22
        Me.StudentPictureDataGridViewImageColumn.Name = "StudentPictureDataGridViewImageColumn"
        Me.StudentPictureDataGridViewImageColumn.ReadOnly = True
        Me.StudentPictureDataGridViewImageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.StudentPictureDataGridViewImageColumn.Visible = False
        Me.StudentPictureDataGridViewImageColumn.Width = 110
        '
        'Approve
        '
        Me.Approve.DataPropertyName = "Approve"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.NullValue = "Approve"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.Approve.DefaultCellStyle = DataGridViewCellStyle2
        Me.Approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Approve.HeaderText = "Approve"
        Me.Approve.MinimumWidth = 22
        Me.Approve.Name = "Approve"
        Me.Approve.ReadOnly = True
        Me.Approve.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Approve.Text = "Approve"
        Me.Approve.ToolTipText = "Approve"
        Me.Approve.Width = 78
        '
        'EnrollmentNumberDataGridViewTextBoxColumn
        '
        Me.EnrollmentNumberDataGridViewTextBoxColumn.DataPropertyName = "EnrollmentNumber"
        Me.EnrollmentNumberDataGridViewTextBoxColumn.HeaderText = "Enrollment Number"
        Me.EnrollmentNumberDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.EnrollmentNumberDataGridViewTextBoxColumn.Name = "EnrollmentNumberDataGridViewTextBoxColumn"
        Me.EnrollmentNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.EnrollmentNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.EnrollmentNumberDataGridViewTextBoxColumn.Visible = False
        Me.EnrollmentNumberDataGridViewTextBoxColumn.Width = 134
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.StatusDataGridViewTextBoxColumn.Width = 63
        '
        'StudentNumberDataGridViewTextBoxColumn
        '
        Me.StudentNumberDataGridViewTextBoxColumn.DataPropertyName = "StudentNumber"
        Me.StudentNumberDataGridViewTextBoxColumn.HeaderText = "Student Number"
        Me.StudentNumberDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.StudentNumberDataGridViewTextBoxColumn.Name = "StudentNumberDataGridViewTextBoxColumn"
        Me.StudentNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.StudentNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.StudentNumberDataGridViewTextBoxColumn.Width = 118
        '
        'IdentifierDataGridViewTextBoxColumn
        '
        Me.IdentifierDataGridViewTextBoxColumn.DataPropertyName = "Identifier"
        Me.IdentifierDataGridViewTextBoxColumn.HeaderText = "Identifier"
        Me.IdentifierDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.IdentifierDataGridViewTextBoxColumn.Name = "IdentifierDataGridViewTextBoxColumn"
        Me.IdentifierDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdentifierDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.IdentifierDataGridViewTextBoxColumn.Visible = False
        Me.IdentifierDataGridViewTextBoxColumn.Width = 78
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Last name"
        Me.LastnameDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastnameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.LastnameDataGridViewTextBoxColumn.Width = 85
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "First name"
        Me.FirstnameDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstnameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.FirstnameDataGridViewTextBoxColumn.Width = 86
        '
        'MiddlenameDataGridViewTextBoxColumn
        '
        Me.MiddlenameDataGridViewTextBoxColumn.DataPropertyName = "Middlename"
        Me.MiddlenameDataGridViewTextBoxColumn.HeaderText = "Middle name"
        Me.MiddlenameDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.MiddlenameDataGridViewTextBoxColumn.Name = "MiddlenameDataGridViewTextBoxColumn"
        Me.MiddlenameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MiddlenameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MiddlenameDataGridViewTextBoxColumn.Width = 102
        '
        'GradeLevelDataGridViewTextBoxColumn
        '
        Me.GradeLevelDataGridViewTextBoxColumn.DataPropertyName = "GradeLevel"
        Me.GradeLevelDataGridViewTextBoxColumn.HeaderText = "Grade Level"
        Me.GradeLevelDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.GradeLevelDataGridViewTextBoxColumn.Name = "GradeLevelDataGridViewTextBoxColumn"
        Me.GradeLevelDataGridViewTextBoxColumn.ReadOnly = True
        Me.GradeLevelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.GradeLevelDataGridViewTextBoxColumn.Width = 97
        '
        'StrandDataGridViewTextBoxColumn
        '
        Me.StrandDataGridViewTextBoxColumn.DataPropertyName = "Strand"
        Me.StrandDataGridViewTextBoxColumn.HeaderText = "Strand"
        Me.StrandDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.StrandDataGridViewTextBoxColumn.Name = "StrandDataGridViewTextBoxColumn"
        Me.StrandDataGridViewTextBoxColumn.ReadOnly = True
        Me.StrandDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.StrandDataGridViewTextBoxColumn.Width = 66
        '
        'SemesterDataGridViewTextBoxColumn
        '
        Me.SemesterDataGridViewTextBoxColumn.DataPropertyName = "Semester"
        Me.SemesterDataGridViewTextBoxColumn.HeaderText = "Semester"
        Me.SemesterDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.SemesterDataGridViewTextBoxColumn.Name = "SemesterDataGridViewTextBoxColumn"
        Me.SemesterDataGridViewTextBoxColumn.ReadOnly = True
        Me.SemesterDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.SemesterDataGridViewTextBoxColumn.Width = 80
        '
        'SchoolYearDataGridViewTextBoxColumn
        '
        Me.SchoolYearDataGridViewTextBoxColumn.DataPropertyName = "SchoolYear"
        Me.SchoolYearDataGridViewTextBoxColumn.HeaderText = "School Year"
        Me.SchoolYearDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.SchoolYearDataGridViewTextBoxColumn.Name = "SchoolYearDataGridViewTextBoxColumn"
        Me.SchoolYearDataGridViewTextBoxColumn.ReadOnly = True
        Me.SchoolYearDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.SchoolYearDataGridViewTextBoxColumn.Width = 97
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.ReadOnly = True
        Me.AgeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.AgeDataGridViewTextBoxColumn.Width = 54
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "Date of Birth"
        Me.DOBDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        Me.DOBDataGridViewTextBoxColumn.ReadOnly = True
        Me.DOBDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DOBDataGridViewTextBoxColumn.Width = 97
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        Me.SexDataGridViewTextBoxColumn.ReadOnly = True
        Me.SexDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.SexDataGridViewTextBoxColumn.Width = 51
        '
        'POBDataGridViewTextBoxColumn
        '
        Me.POBDataGridViewTextBoxColumn.DataPropertyName = "POB"
        Me.POBDataGridViewTextBoxColumn.HeaderText = "Place of Birth"
        Me.POBDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.POBDataGridViewTextBoxColumn.Name = "POBDataGridViewTextBoxColumn"
        Me.POBDataGridViewTextBoxColumn.ReadOnly = True
        Me.POBDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.POBDataGridViewTextBoxColumn.Width = 103
        '
        'NationalityDataGridViewTextBoxColumn
        '
        Me.NationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.HeaderText = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.NationalityDataGridViewTextBoxColumn.Name = "NationalityDataGridViewTextBoxColumn"
        Me.NationalityDataGridViewTextBoxColumn.ReadOnly = True
        Me.NationalityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.NationalityDataGridViewTextBoxColumn.Width = 90
        '
        'ReligionDataGridViewTextBoxColumn
        '
        Me.ReligionDataGridViewTextBoxColumn.DataPropertyName = "Religion"
        Me.ReligionDataGridViewTextBoxColumn.HeaderText = "Religion"
        Me.ReligionDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.ReligionDataGridViewTextBoxColumn.Name = "ReligionDataGridViewTextBoxColumn"
        Me.ReligionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReligionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.ReligionDataGridViewTextBoxColumn.Width = 76
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.EmailDataGridViewTextBoxColumn.Width = 60
        '
        'MobileNumberDataGridViewTextBoxColumn
        '
        Me.MobileNumberDataGridViewTextBoxColumn.DataPropertyName = "MobileNumber"
        Me.MobileNumberDataGridViewTextBoxColumn.HeaderText = "Mobile Number"
        Me.MobileNumberDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.MobileNumberDataGridViewTextBoxColumn.Name = "MobileNumberDataGridViewTextBoxColumn"
        Me.MobileNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.MobileNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MobileNumberDataGridViewTextBoxColumn.Width = 115
        '
        'TelephoneNumberDataGridViewTextBoxColumn
        '
        Me.TelephoneNumberDataGridViewTextBoxColumn.DataPropertyName = "TelephoneNumber"
        Me.TelephoneNumberDataGridViewTextBoxColumn.HeaderText = "Telephone Number"
        Me.TelephoneNumberDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.TelephoneNumberDataGridViewTextBoxColumn.Name = "TelephoneNumberDataGridViewTextBoxColumn"
        Me.TelephoneNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelephoneNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.TelephoneNumberDataGridViewTextBoxColumn.Width = 135
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.AddressDataGridViewTextBoxColumn.Width = 75
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        Me.CityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.CityDataGridViewTextBoxColumn.Width = 52
        '
        'FatherNameDataGridViewTextBoxColumn
        '
        Me.FatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName"
        Me.FatherNameDataGridViewTextBoxColumn.HeaderText = "Father Name"
        Me.FatherNameDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.FatherNameDataGridViewTextBoxColumn.Name = "FatherNameDataGridViewTextBoxColumn"
        Me.FatherNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FatherNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.FatherNameDataGridViewTextBoxColumn.Width = 101
        '
        'FatherOccupationDataGridViewTextBoxColumn
        '
        Me.FatherOccupationDataGridViewTextBoxColumn.DataPropertyName = "FatherOccupation"
        Me.FatherOccupationDataGridViewTextBoxColumn.HeaderText = "Father Occupation"
        Me.FatherOccupationDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.FatherOccupationDataGridViewTextBoxColumn.Name = "FatherOccupationDataGridViewTextBoxColumn"
        Me.FatherOccupationDataGridViewTextBoxColumn.ReadOnly = True
        Me.FatherOccupationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.FatherOccupationDataGridViewTextBoxColumn.Width = 133
        '
        'FatherEmailDataGridViewTextBoxColumn
        '
        Me.FatherEmailDataGridViewTextBoxColumn.DataPropertyName = "FatherEmail"
        Me.FatherEmailDataGridViewTextBoxColumn.HeaderText = "Father Email"
        Me.FatherEmailDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.FatherEmailDataGridViewTextBoxColumn.Name = "FatherEmailDataGridViewTextBoxColumn"
        Me.FatherEmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.FatherEmailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.FatherEmailDataGridViewTextBoxColumn.Width = 97
        '
        'FatherWorkAddressDataGridViewTextBoxColumn
        '
        Me.FatherWorkAddressDataGridViewTextBoxColumn.DataPropertyName = "FatherWorkAddress"
        Me.FatherWorkAddressDataGridViewTextBoxColumn.HeaderText = "Father Work Address"
        Me.FatherWorkAddressDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.FatherWorkAddressDataGridViewTextBoxColumn.Name = "FatherWorkAddressDataGridViewTextBoxColumn"
        Me.FatherWorkAddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.FatherWorkAddressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.FatherWorkAddressDataGridViewTextBoxColumn.Width = 142
        '
        'FatherContactNumberDataGridViewTextBoxColumn
        '
        Me.FatherContactNumberDataGridViewTextBoxColumn.DataPropertyName = "FatherContactNumber"
        Me.FatherContactNumberDataGridViewTextBoxColumn.HeaderText = "Father Contact Number"
        Me.FatherContactNumberDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.FatherContactNumberDataGridViewTextBoxColumn.Name = "FatherContactNumberDataGridViewTextBoxColumn"
        Me.FatherContactNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.FatherContactNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.FatherContactNumberDataGridViewTextBoxColumn.Width = 157
        '
        'MotherNameDataGridViewTextBoxColumn
        '
        Me.MotherNameDataGridViewTextBoxColumn.DataPropertyName = "MotherName"
        Me.MotherNameDataGridViewTextBoxColumn.HeaderText = "Mother Name"
        Me.MotherNameDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.MotherNameDataGridViewTextBoxColumn.Name = "MotherNameDataGridViewTextBoxColumn"
        Me.MotherNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MotherNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MotherNameDataGridViewTextBoxColumn.Width = 105
        '
        'MotherOccupationDataGridViewTextBoxColumn
        '
        Me.MotherOccupationDataGridViewTextBoxColumn.DataPropertyName = "MotherOccupation"
        Me.MotherOccupationDataGridViewTextBoxColumn.HeaderText = "Mother Occupation"
        Me.MotherOccupationDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.MotherOccupationDataGridViewTextBoxColumn.Name = "MotherOccupationDataGridViewTextBoxColumn"
        Me.MotherOccupationDataGridViewTextBoxColumn.ReadOnly = True
        Me.MotherOccupationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MotherOccupationDataGridViewTextBoxColumn.Width = 137
        '
        'MotherEmailDataGridViewTextBoxColumn
        '
        Me.MotherEmailDataGridViewTextBoxColumn.DataPropertyName = "MotherEmail"
        Me.MotherEmailDataGridViewTextBoxColumn.HeaderText = "Mother Email"
        Me.MotherEmailDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.MotherEmailDataGridViewTextBoxColumn.Name = "MotherEmailDataGridViewTextBoxColumn"
        Me.MotherEmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.MotherEmailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MotherEmailDataGridViewTextBoxColumn.Width = 101
        '
        'MotherWorkAddressDataGridViewTextBoxColumn
        '
        Me.MotherWorkAddressDataGridViewTextBoxColumn.DataPropertyName = "MotherWorkAddress"
        Me.MotherWorkAddressDataGridViewTextBoxColumn.HeaderText = "Mother Work Address"
        Me.MotherWorkAddressDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.MotherWorkAddressDataGridViewTextBoxColumn.Name = "MotherWorkAddressDataGridViewTextBoxColumn"
        Me.MotherWorkAddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.MotherWorkAddressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MotherWorkAddressDataGridViewTextBoxColumn.Width = 146
        '
        'MotherContactNumberDataGridViewTextBoxColumn
        '
        Me.MotherContactNumberDataGridViewTextBoxColumn.DataPropertyName = "MotherContactNumber"
        Me.MotherContactNumberDataGridViewTextBoxColumn.HeaderText = "Mother Contact Number"
        Me.MotherContactNumberDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.MotherContactNumberDataGridViewTextBoxColumn.Name = "MotherContactNumberDataGridViewTextBoxColumn"
        Me.MotherContactNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.MotherContactNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MotherContactNumberDataGridViewTextBoxColumn.Width = 161
        '
        'NumberOfSiblingsDataGridViewTextBoxColumn
        '
        Me.NumberOfSiblingsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfSiblings"
        Me.NumberOfSiblingsDataGridViewTextBoxColumn.HeaderText = "Number of Siblings"
        Me.NumberOfSiblingsDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.NumberOfSiblingsDataGridViewTextBoxColumn.Name = "NumberOfSiblingsDataGridViewTextBoxColumn"
        Me.NumberOfSiblingsDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumberOfSiblingsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.NumberOfSiblingsDataGridViewTextBoxColumn.Width = 132
        '
        'PersonEmergencyDataGridViewTextBoxColumn
        '
        Me.PersonEmergencyDataGridViewTextBoxColumn.DataPropertyName = "PersonEmergency"
        Me.PersonEmergencyDataGridViewTextBoxColumn.HeaderText = "Person if Emergency"
        Me.PersonEmergencyDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.PersonEmergencyDataGridViewTextBoxColumn.Name = "PersonEmergencyDataGridViewTextBoxColumn"
        Me.PersonEmergencyDataGridViewTextBoxColumn.ReadOnly = True
        Me.PersonEmergencyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.PersonEmergencyDataGridViewTextBoxColumn.Width = 141
        '
        'GuardianNameDataGridViewTextBoxColumn
        '
        Me.GuardianNameDataGridViewTextBoxColumn.DataPropertyName = "GuardianName"
        Me.GuardianNameDataGridViewTextBoxColumn.HeaderText = "Guardian Name"
        Me.GuardianNameDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.GuardianNameDataGridViewTextBoxColumn.Name = "GuardianNameDataGridViewTextBoxColumn"
        Me.GuardianNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.GuardianNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.GuardianNameDataGridViewTextBoxColumn.Width = 118
        '
        'GuardianRelationDataGridViewTextBoxColumn
        '
        Me.GuardianRelationDataGridViewTextBoxColumn.DataPropertyName = "GuardianRelation"
        Me.GuardianRelationDataGridViewTextBoxColumn.HeaderText = "Guardian Relation"
        Me.GuardianRelationDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.GuardianRelationDataGridViewTextBoxColumn.Name = "GuardianRelationDataGridViewTextBoxColumn"
        Me.GuardianRelationDataGridViewTextBoxColumn.ReadOnly = True
        Me.GuardianRelationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.GuardianRelationDataGridViewTextBoxColumn.Width = 130
        '
        'GuardianEmailDataGridViewTextBoxColumn
        '
        Me.GuardianEmailDataGridViewTextBoxColumn.DataPropertyName = "GuardianEmail"
        Me.GuardianEmailDataGridViewTextBoxColumn.HeaderText = "Guardian Email"
        Me.GuardianEmailDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.GuardianEmailDataGridViewTextBoxColumn.Name = "GuardianEmailDataGridViewTextBoxColumn"
        Me.GuardianEmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.GuardianEmailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.GuardianEmailDataGridViewTextBoxColumn.Width = 114
        '
        'GuardianWorkAddressDataGridViewTextBoxColumn
        '
        Me.GuardianWorkAddressDataGridViewTextBoxColumn.DataPropertyName = "GuardianWorkAddress"
        Me.GuardianWorkAddressDataGridViewTextBoxColumn.HeaderText = "Guardian Work Address"
        Me.GuardianWorkAddressDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.GuardianWorkAddressDataGridViewTextBoxColumn.Name = "GuardianWorkAddressDataGridViewTextBoxColumn"
        Me.GuardianWorkAddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.GuardianWorkAddressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.GuardianWorkAddressDataGridViewTextBoxColumn.Width = 159
        '
        'GuardianContactNumberDataGridViewTextBoxColumn
        '
        Me.GuardianContactNumberDataGridViewTextBoxColumn.DataPropertyName = "GuardianContactNumber"
        Me.GuardianContactNumberDataGridViewTextBoxColumn.HeaderText = "Guardian Contact Number"
        Me.GuardianContactNumberDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.GuardianContactNumberDataGridViewTextBoxColumn.Name = "GuardianContactNumberDataGridViewTextBoxColumn"
        Me.GuardianContactNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.GuardianContactNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.GuardianContactNumberDataGridViewTextBoxColumn.Width = 174
        '
        'FetcherNameDataGridViewTextBoxColumn
        '
        Me.FetcherNameDataGridViewTextBoxColumn.DataPropertyName = "FetcherName"
        Me.FetcherNameDataGridViewTextBoxColumn.HeaderText = "Fetcher Name"
        Me.FetcherNameDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.FetcherNameDataGridViewTextBoxColumn.Name = "FetcherNameDataGridViewTextBoxColumn"
        Me.FetcherNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FetcherNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.FetcherNameDataGridViewTextBoxColumn.Width = 108
        '
        'FetcherContactNumberDataGridViewTextBoxColumn
        '
        Me.FetcherContactNumberDataGridViewTextBoxColumn.DataPropertyName = "FetcherContactNumber"
        Me.FetcherContactNumberDataGridViewTextBoxColumn.HeaderText = "Fetcher Contact Number"
        Me.FetcherContactNumberDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.FetcherContactNumberDataGridViewTextBoxColumn.Name = "FetcherContactNumberDataGridViewTextBoxColumn"
        Me.FetcherContactNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.FetcherContactNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.FetcherContactNumberDataGridViewTextBoxColumn.Width = 164
        '
        'SiblingsOfStudent1DataGridViewTextBoxColumn
        '
        Me.SiblingsOfStudent1DataGridViewTextBoxColumn.DataPropertyName = "SiblingsOfStudent1"
        Me.SiblingsOfStudent1DataGridViewTextBoxColumn.HeaderText = "Siblings of Student 1"
        Me.SiblingsOfStudent1DataGridViewTextBoxColumn.MinimumWidth = 22
        Me.SiblingsOfStudent1DataGridViewTextBoxColumn.Name = "SiblingsOfStudent1DataGridViewTextBoxColumn"
        Me.SiblingsOfStudent1DataGridViewTextBoxColumn.ReadOnly = True
        Me.SiblingsOfStudent1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.SiblingsOfStudent1DataGridViewTextBoxColumn.Width = 138
        '
        'SiblingsOfStudent2DataGridViewTextBoxColumn
        '
        Me.SiblingsOfStudent2DataGridViewTextBoxColumn.DataPropertyName = "SiblingsOfStudent2"
        Me.SiblingsOfStudent2DataGridViewTextBoxColumn.HeaderText = "Siblings of Student 2"
        Me.SiblingsOfStudent2DataGridViewTextBoxColumn.MinimumWidth = 22
        Me.SiblingsOfStudent2DataGridViewTextBoxColumn.Name = "SiblingsOfStudent2DataGridViewTextBoxColumn"
        Me.SiblingsOfStudent2DataGridViewTextBoxColumn.ReadOnly = True
        Me.SiblingsOfStudent2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.SiblingsOfStudent2DataGridViewTextBoxColumn.Width = 138
        '
        'SiblingsOfStudent3DataGridViewTextBoxColumn
        '
        Me.SiblingsOfStudent3DataGridViewTextBoxColumn.DataPropertyName = "SiblingsOfStudent3"
        Me.SiblingsOfStudent3DataGridViewTextBoxColumn.HeaderText = "Siblings of Student 3"
        Me.SiblingsOfStudent3DataGridViewTextBoxColumn.MinimumWidth = 22
        Me.SiblingsOfStudent3DataGridViewTextBoxColumn.Name = "SiblingsOfStudent3DataGridViewTextBoxColumn"
        Me.SiblingsOfStudent3DataGridViewTextBoxColumn.ReadOnly = True
        Me.SiblingsOfStudent3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.SiblingsOfStudent3DataGridViewTextBoxColumn.Width = 138
        '
        'SiblingsOfStudentAge1DataGridViewTextBoxColumn
        '
        Me.SiblingsOfStudentAge1DataGridViewTextBoxColumn.DataPropertyName = "SiblingsOfStudentAge1"
        Me.SiblingsOfStudentAge1DataGridViewTextBoxColumn.HeaderText = "Siblings of Student Age 1"
        Me.SiblingsOfStudentAge1DataGridViewTextBoxColumn.MinimumWidth = 22
        Me.SiblingsOfStudentAge1DataGridViewTextBoxColumn.Name = "SiblingsOfStudentAge1DataGridViewTextBoxColumn"
        Me.SiblingsOfStudentAge1DataGridViewTextBoxColumn.ReadOnly = True
        Me.SiblingsOfStudentAge1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.SiblingsOfStudentAge1DataGridViewTextBoxColumn.Width = 163
        '
        'SiblingsOfStudentAge2DataGridViewTextBoxColumn
        '
        Me.SiblingsOfStudentAge2DataGridViewTextBoxColumn.DataPropertyName = "SiblingsOfStudentAge2"
        Me.SiblingsOfStudentAge2DataGridViewTextBoxColumn.HeaderText = "Siblings of Student Age 2"
        Me.SiblingsOfStudentAge2DataGridViewTextBoxColumn.MinimumWidth = 22
        Me.SiblingsOfStudentAge2DataGridViewTextBoxColumn.Name = "SiblingsOfStudentAge2DataGridViewTextBoxColumn"
        Me.SiblingsOfStudentAge2DataGridViewTextBoxColumn.ReadOnly = True
        Me.SiblingsOfStudentAge2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.SiblingsOfStudentAge2DataGridViewTextBoxColumn.Width = 163
        '
        'SiblingsOfStudentAge3DataGridViewTextBoxColumn
        '
        Me.SiblingsOfStudentAge3DataGridViewTextBoxColumn.DataPropertyName = "SiblingsOfStudentAge3"
        Me.SiblingsOfStudentAge3DataGridViewTextBoxColumn.HeaderText = "Siblings of Student Age 3"
        Me.SiblingsOfStudentAge3DataGridViewTextBoxColumn.MinimumWidth = 22
        Me.SiblingsOfStudentAge3DataGridViewTextBoxColumn.Name = "SiblingsOfStudentAge3DataGridViewTextBoxColumn"
        Me.SiblingsOfStudentAge3DataGridViewTextBoxColumn.ReadOnly = True
        Me.SiblingsOfStudentAge3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.SiblingsOfStudentAge3DataGridViewTextBoxColumn.Width = 163
        '
        'SiblingsOfStudentSchool1DataGridViewTextBoxColumn
        '
        Me.SiblingsOfStudentSchool1DataGridViewTextBoxColumn.DataPropertyName = "SiblingsOfStudentSchool1"
        Me.SiblingsOfStudentSchool1DataGridViewTextBoxColumn.HeaderText = "Siblings of Student School 1"
        Me.SiblingsOfStudentSchool1DataGridViewTextBoxColumn.MinimumWidth = 22
        Me.SiblingsOfStudentSchool1DataGridViewTextBoxColumn.Name = "SiblingsOfStudentSchool1DataGridViewTextBoxColumn"
        Me.SiblingsOfStudentSchool1DataGridViewTextBoxColumn.ReadOnly = True
        Me.SiblingsOfStudentSchool1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.SiblingsOfStudentSchool1DataGridViewTextBoxColumn.Width = 178
        '
        'SiblingsOfStudentSchool2DataGridViewTextBoxColumn
        '
        Me.SiblingsOfStudentSchool2DataGridViewTextBoxColumn.DataPropertyName = "SiblingsOfStudentSchool2"
        Me.SiblingsOfStudentSchool2DataGridViewTextBoxColumn.HeaderText = "Siblings of Student School 2"
        Me.SiblingsOfStudentSchool2DataGridViewTextBoxColumn.MinimumWidth = 22
        Me.SiblingsOfStudentSchool2DataGridViewTextBoxColumn.Name = "SiblingsOfStudentSchool2DataGridViewTextBoxColumn"
        Me.SiblingsOfStudentSchool2DataGridViewTextBoxColumn.ReadOnly = True
        Me.SiblingsOfStudentSchool2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.SiblingsOfStudentSchool2DataGridViewTextBoxColumn.Width = 178
        '
        'SiblingsOfStudentSchool3DataGridViewTextBoxColumn
        '
        Me.SiblingsOfStudentSchool3DataGridViewTextBoxColumn.DataPropertyName = "SiblingsOfStudentSchool3"
        Me.SiblingsOfStudentSchool3DataGridViewTextBoxColumn.HeaderText = "Siblings of Student School 3"
        Me.SiblingsOfStudentSchool3DataGridViewTextBoxColumn.MinimumWidth = 22
        Me.SiblingsOfStudentSchool3DataGridViewTextBoxColumn.Name = "SiblingsOfStudentSchool3DataGridViewTextBoxColumn"
        Me.SiblingsOfStudentSchool3DataGridViewTextBoxColumn.ReadOnly = True
        Me.SiblingsOfStudentSchool3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.SiblingsOfStudentSchool3DataGridViewTextBoxColumn.Width = 178
        '
        'SchoolLastAttended1DataGridViewTextBoxColumn
        '
        Me.SchoolLastAttended1DataGridViewTextBoxColumn.DataPropertyName = "SchoolLastAttended1"
        Me.SchoolLastAttended1DataGridViewTextBoxColumn.HeaderText = "School Last Attended 1"
        Me.SchoolLastAttended1DataGridViewTextBoxColumn.MinimumWidth = 22
        Me.SchoolLastAttended1DataGridViewTextBoxColumn.Name = "SchoolLastAttended1DataGridViewTextBoxColumn"
        Me.SchoolLastAttended1DataGridViewTextBoxColumn.ReadOnly = True
        Me.SchoolLastAttended1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.SchoolLastAttended1DataGridViewTextBoxColumn.Width = 153
        '
        'SchoolLastAttended2DataGridViewTextBoxColumn
        '
        Me.SchoolLastAttended2DataGridViewTextBoxColumn.DataPropertyName = "SchoolLastAttended2"
        Me.SchoolLastAttended2DataGridViewTextBoxColumn.HeaderText = "School Last Attended 2"
        Me.SchoolLastAttended2DataGridViewTextBoxColumn.MinimumWidth = 22
        Me.SchoolLastAttended2DataGridViewTextBoxColumn.Name = "SchoolLastAttended2DataGridViewTextBoxColumn"
        Me.SchoolLastAttended2DataGridViewTextBoxColumn.ReadOnly = True
        Me.SchoolLastAttended2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.SchoolLastAttended2DataGridViewTextBoxColumn.Width = 153
        '
        'SchoolLastAttended3DataGridViewTextBoxColumn
        '
        Me.SchoolLastAttended3DataGridViewTextBoxColumn.DataPropertyName = "SchoolLastAttended3"
        Me.SchoolLastAttended3DataGridViewTextBoxColumn.HeaderText = "School Last Attended 3"
        Me.SchoolLastAttended3DataGridViewTextBoxColumn.MinimumWidth = 22
        Me.SchoolLastAttended3DataGridViewTextBoxColumn.Name = "SchoolLastAttended3DataGridViewTextBoxColumn"
        Me.SchoolLastAttended3DataGridViewTextBoxColumn.ReadOnly = True
        Me.SchoolLastAttended3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.SchoolLastAttended3DataGridViewTextBoxColumn.Width = 153
        '
        'AcademicYear1DataGridViewTextBoxColumn
        '
        Me.AcademicYear1DataGridViewTextBoxColumn.DataPropertyName = "AcademicYear1"
        Me.AcademicYear1DataGridViewTextBoxColumn.HeaderText = "Academic Year 1"
        Me.AcademicYear1DataGridViewTextBoxColumn.MinimumWidth = 22
        Me.AcademicYear1DataGridViewTextBoxColumn.Name = "AcademicYear1DataGridViewTextBoxColumn"
        Me.AcademicYear1DataGridViewTextBoxColumn.ReadOnly = True
        Me.AcademicYear1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.AcademicYear1DataGridViewTextBoxColumn.Width = 124
        '
        'AcademicYear2DataGridViewTextBoxColumn
        '
        Me.AcademicYear2DataGridViewTextBoxColumn.DataPropertyName = "AcademicYear2"
        Me.AcademicYear2DataGridViewTextBoxColumn.HeaderText = "Academic Year 2"
        Me.AcademicYear2DataGridViewTextBoxColumn.MinimumWidth = 22
        Me.AcademicYear2DataGridViewTextBoxColumn.Name = "AcademicYear2DataGridViewTextBoxColumn"
        Me.AcademicYear2DataGridViewTextBoxColumn.ReadOnly = True
        Me.AcademicYear2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.AcademicYear2DataGridViewTextBoxColumn.Width = 124
        '
        'AcademicYear3DataGridViewTextBoxColumn
        '
        Me.AcademicYear3DataGridViewTextBoxColumn.DataPropertyName = "AcademicYear3"
        Me.AcademicYear3DataGridViewTextBoxColumn.HeaderText = "Academic Year 3"
        Me.AcademicYear3DataGridViewTextBoxColumn.MinimumWidth = 22
        Me.AcademicYear3DataGridViewTextBoxColumn.Name = "AcademicYear3DataGridViewTextBoxColumn"
        Me.AcademicYear3DataGridViewTextBoxColumn.ReadOnly = True
        Me.AcademicYear3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.AcademicYear3DataGridViewTextBoxColumn.Width = 124
        '
        'ReasonApplyingDataGridViewTextBoxColumn
        '
        Me.ReasonApplyingDataGridViewTextBoxColumn.DataPropertyName = "ReasonApplying"
        Me.ReasonApplyingDataGridViewTextBoxColumn.HeaderText = "Reason Applying"
        Me.ReasonApplyingDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.ReasonApplyingDataGridViewTextBoxColumn.Name = "ReasonApplyingDataGridViewTextBoxColumn"
        Me.ReasonApplyingDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReasonApplyingDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.ReasonApplyingDataGridViewTextBoxColumn.Visible = False
        Me.ReasonApplyingDataGridViewTextBoxColumn.Width = 123
        '
        'ConditionDataGridViewTextBoxColumn
        '
        Me.ConditionDataGridViewTextBoxColumn.DataPropertyName = "Condition"
        Me.ConditionDataGridViewTextBoxColumn.HeaderText = "Condition"
        Me.ConditionDataGridViewTextBoxColumn.MinimumWidth = 22
        Me.ConditionDataGridViewTextBoxColumn.Name = "ConditionDataGridViewTextBoxColumn"
        Me.ConditionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConditionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.ConditionDataGridViewTextBoxColumn.Visible = False
        Me.ConditionDataGridViewTextBoxColumn.Width = 84
        '
        'Requirement1DataGridViewTextBoxColumn
        '
        Me.Requirement1DataGridViewTextBoxColumn.DataPropertyName = "Requirement1"
        Me.Requirement1DataGridViewTextBoxColumn.HeaderText = "Requirement1"
        Me.Requirement1DataGridViewTextBoxColumn.MinimumWidth = 22
        Me.Requirement1DataGridViewTextBoxColumn.Name = "Requirement1DataGridViewTextBoxColumn"
        Me.Requirement1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Requirement1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Requirement1DataGridViewTextBoxColumn.Visible = False
        Me.Requirement1DataGridViewTextBoxColumn.Width = 106
        '
        'Requirement2DataGridViewTextBoxColumn
        '
        Me.Requirement2DataGridViewTextBoxColumn.DataPropertyName = "Requirement2"
        Me.Requirement2DataGridViewTextBoxColumn.HeaderText = "Requirement2"
        Me.Requirement2DataGridViewTextBoxColumn.MinimumWidth = 22
        Me.Requirement2DataGridViewTextBoxColumn.Name = "Requirement2DataGridViewTextBoxColumn"
        Me.Requirement2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Requirement2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Requirement2DataGridViewTextBoxColumn.Visible = False
        Me.Requirement2DataGridViewTextBoxColumn.Width = 106
        '
        'Requirement3DataGridViewTextBoxColumn
        '
        Me.Requirement3DataGridViewTextBoxColumn.DataPropertyName = "Requirement3"
        Me.Requirement3DataGridViewTextBoxColumn.HeaderText = "Requirement3"
        Me.Requirement3DataGridViewTextBoxColumn.MinimumWidth = 22
        Me.Requirement3DataGridViewTextBoxColumn.Name = "Requirement3DataGridViewTextBoxColumn"
        Me.Requirement3DataGridViewTextBoxColumn.ReadOnly = True
        Me.Requirement3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Requirement3DataGridViewTextBoxColumn.Visible = False
        Me.Requirement3DataGridViewTextBoxColumn.Width = 106
        '
        'Requirement4DataGridViewTextBoxColumn
        '
        Me.Requirement4DataGridViewTextBoxColumn.DataPropertyName = "Requirement4"
        Me.Requirement4DataGridViewTextBoxColumn.HeaderText = "Requirement4"
        Me.Requirement4DataGridViewTextBoxColumn.MinimumWidth = 22
        Me.Requirement4DataGridViewTextBoxColumn.Name = "Requirement4DataGridViewTextBoxColumn"
        Me.Requirement4DataGridViewTextBoxColumn.ReadOnly = True
        Me.Requirement4DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Requirement4DataGridViewTextBoxColumn.Visible = False
        Me.Requirement4DataGridViewTextBoxColumn.Width = 106
        '
        'IdentifierDateTimePicker
        '
        Me.IdentifierDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss tt"
        Me.IdentifierDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EnrollmentDataBindingSource, "Identifier", True))
        Me.IdentifierDateTimePicker.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdentifierDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.IdentifierDateTimePicker.Location = New System.Drawing.Point(656, 31)
        Me.IdentifierDateTimePicker.Name = "IdentifierDateTimePicker"
        Me.IdentifierDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.IdentifierDateTimePicker.TabIndex = 285
        Me.IdentifierDateTimePicker.Visible = False
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentDataBindingSource, "Status", True))
        Me.StatusTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusTextBox.Location = New System.Drawing.Point(656, 6)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 23)
        Me.StatusTextBox.TabIndex = 393
        Me.StatusTextBox.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(46, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(450, 70)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'EnrollmentDataTableAdapter
        '
        Me.EnrollmentDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminInfoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EnrollmentDataTableAdapter = Me.EnrollmentDataTableAdapter
        Me.TableAdapterManager.SchoolInfoTableAdapter = Nothing
        Me.TableAdapterManager.SubjectTableAdapter = Nothing
        Me.TableAdapterManager.TeacherInfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SchoolManagementSystem.Pre_enrollmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EnrollmentData
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(995, 642)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(IdentifierLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(Me.IdentifierDateTimePicker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EnrollmentData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EnrollmentData"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EnrollmentDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pre_enrollmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvancedDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AdvancedDataGridView1 As ADGV.AdvancedDataGridView
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnCapture As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureID As PictureBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents cmbCapture As ComboBox
    Friend WithEvents Label63 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Pre_enrollmentDataSet As Pre_enrollmentDataSet
    Friend WithEvents EnrollmentDataBindingSource As BindingSource
    Friend WithEvents EnrollmentDataTableAdapter As Pre_enrollmentDataSetTableAdapters.EnrollmentDataTableAdapter
    Friend WithEvents EnrollmentNumberTextBox1 As TextBox
    Friend WithEvents StudentNumberTextBox1 As TextBox
    Friend WithEvents IdentifierDateTimePicker As DateTimePicker
    Friend WithEvents GradeLevelTextBox1 As TextBox
    Friend WithEvents StrandTextBox1 As TextBox
    Friend WithEvents SemesterTextBox1 As TextBox
    Friend WithEvents SchoolYearTextBox1 As TextBox
    Friend WithEvents LastnameTextBox1 As TextBox
    Friend WithEvents FirstnameTextBox1 As TextBox
    Friend WithEvents MiddlenameTextBox1 As TextBox
    Friend WithEvents AgeTextBox1 As TextBox
    Friend WithEvents DOBDateTimePicker1 As DateTimePicker
    Friend WithEvents SexTextBox1 As TextBox
    Friend WithEvents POBTextBox1 As TextBox
    Friend WithEvents NationalityTextBox1 As TextBox
    Friend WithEvents ReligionTextBox1 As TextBox
    Friend WithEvents EmailTextBox1 As TextBox
    Friend WithEvents MobileNumberTextBox1 As TextBox
    Friend WithEvents TelephoneNumberTextBox1 As TextBox
    Friend WithEvents AddressTextBox1 As TextBox
    Friend WithEvents CityTextBox1 As TextBox
    Friend WithEvents FatherNameTextBox1 As TextBox
    Friend WithEvents FatherOccupationTextBox1 As TextBox
    Friend WithEvents FatherEmailTextBox1 As TextBox
    Friend WithEvents FatherWorkAddressTextBox1 As TextBox
    Friend WithEvents FatherContactNumberTextBox1 As TextBox
    Friend WithEvents MotherNameTextBox1 As TextBox
    Friend WithEvents MotherOccupationTextBox1 As TextBox
    Friend WithEvents MotherEmailTextBox1 As TextBox
    Friend WithEvents MotherWorkAddressTextBox1 As TextBox
    Friend WithEvents MotherContactNumberTextBox1 As TextBox
    Friend WithEvents NumberOfSiblingsTextBox1 As TextBox
    Friend WithEvents PersonEmergencyTextBox1 As TextBox
    Friend WithEvents GuardianNameTextBox1 As TextBox
    Friend WithEvents GuardianRelationTextBox1 As TextBox
    Friend WithEvents GuardianEmailTextBox1 As TextBox
    Friend WithEvents GuardianWorkAddressTextBox1 As TextBox
    Friend WithEvents GuardianContactNumberTextBox1 As TextBox
    Friend WithEvents FetcherNameTextBox1 As TextBox
    Friend WithEvents FetcherContactNumberTextBox1 As TextBox
    Friend WithEvents SiblingsOfStudent1TextBox1 As TextBox
    Friend WithEvents SiblingsOfStudent2TextBox1 As TextBox
    Friend WithEvents SiblingsOfStudent3TextBox1 As TextBox
    Friend WithEvents SiblingsOfStudentAge1TextBox1 As TextBox
    Friend WithEvents SiblingsOfStudentAge2TextBox1 As TextBox
    Friend WithEvents SiblingsOfStudentAge3TextBox1 As TextBox
    Friend WithEvents SiblingsOfStudentSchool1TextBox1 As TextBox
    Friend WithEvents SiblingsOfStudentSchool2TextBox1 As TextBox
    Friend WithEvents SiblingsOfStudentSchool3TextBox1 As TextBox
    Friend WithEvents SchoolLastAttended1TextBox1 As TextBox
    Friend WithEvents SchoolLastAttended2TextBox1 As TextBox
    Friend WithEvents SchoolLastAttended3TextBox1 As TextBox
    Friend WithEvents AcademicYear1TextBox1 As TextBox
    Friend WithEvents AcademicYear2TextBox1 As TextBox
    Friend WithEvents AcademicYear3TextBox1 As TextBox
    Friend WithEvents ReasonApplyingTextBox1 As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents ConditionTextBox As TextBox
    Friend WithEvents Requirement1TextBox As TextBox
    Friend WithEvents Requirement2TextBox As TextBox
    Friend WithEvents Requirement3TextBox As TextBox
    Friend WithEvents Requirement4TextBox As TextBox
    Friend WithEvents TableAdapterManager As Pre_enrollmentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnDenied As Button
    Friend WithEvents StudentPictureDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents Approve As DataGridViewButtonColumn
    Friend WithEvents EnrollmentNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdentifierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddlenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradeLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SemesterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SchoolYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NationalityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReligionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobileNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelephoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FatherNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FatherOccupationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FatherEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FatherWorkAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FatherContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotherNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotherOccupationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotherEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotherWorkAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotherContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumberOfSiblingsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonEmergencyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuardianNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuardianRelationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuardianEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuardianWorkAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuardianContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FetcherNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FetcherContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SiblingsOfStudent1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SiblingsOfStudent2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SiblingsOfStudent3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SiblingsOfStudentAge1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SiblingsOfStudentAge2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SiblingsOfStudentAge3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SiblingsOfStudentSchool1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SiblingsOfStudentSchool2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SiblingsOfStudentSchool3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SchoolLastAttended1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SchoolLastAttended2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SchoolLastAttended3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcademicYear1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcademicYear2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcademicYear3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReasonApplyingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConditionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Requirement1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Requirement2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Requirement3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Requirement4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnGenerateID As Button
    Friend WithEvents cmbStudentNum As ComboBox
End Class
