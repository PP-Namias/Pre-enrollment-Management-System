<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TeacherData
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim EmailIDLabel As System.Windows.Forms.Label
        Dim PlaceOfBirthLabel As System.Windows.Forms.Label
        Dim DateOfBirthLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim TeacherIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeacherData))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TeacherInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pre_enrollmentDataSet = New SchoolManagementSystem.Pre_enrollmentDataSet()
        Me.TeacherInfoTableAdapter = New SchoolManagementSystem.Pre_enrollmentDataSetTableAdapters.TeacherInfoTableAdapter()
        Me.TableAdapterManager = New SchoolManagementSystem.Pre_enrollmentDataSetTableAdapters.TableAdapterManager()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TeacherInfoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TeacherInfoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtUncrypticPassword = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.TeacherIDTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.DateOfBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PlaceOfBirthTextBox = New System.Windows.Forms.TextBox()
        Me.EmailIDTextBox = New System.Windows.Forms.TextBox()
        Me.txtSearchUsername = New System.Windows.Forms.TextBox()
        Me.cmbCapture = New System.Windows.Forms.ComboBox()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureID = New System.Windows.Forms.PictureBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtSearchTeacherID = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TeacherIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlaceOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeacherPicDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.picHelp1 = New System.Windows.Forms.PictureBox()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        EmailIDLabel = New System.Windows.Forms.Label()
        PlaceOfBirthLabel = New System.Windows.Forms.Label()
        DateOfBirthLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        TeacherIDLabel = New System.Windows.Forms.Label()
        CType(Me.TeacherInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pre_enrollmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherInfoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TeacherInfoBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHelp1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(22, 68)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(145, 17)
        Label1.TabIndex = 15
        Label1.Text = "Search by Teacher ID:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(18, 25)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(478, 37)
        Label3.TabIndex = 18
        Label3.Text = "Teacher Information Database"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(450, 68)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(145, 17)
        Label4.TabIndex = 122
        Label4.Text = "Search by User name:"
        '
        'EmailIDLabel
        '
        EmailIDLabel.AutoSize = True
        EmailIDLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailIDLabel.Location = New System.Drawing.Point(21, 384)
        EmailIDLabel.Name = "EmailIDLabel"
        EmailIDLabel.Size = New System.Drawing.Size(70, 20)
        EmailIDLabel.TabIndex = 132
        EmailIDLabel.Text = "Email ID:"
        '
        'PlaceOfBirthLabel
        '
        PlaceOfBirthLabel.AutoSize = True
        PlaceOfBirthLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PlaceOfBirthLabel.Location = New System.Drawing.Point(21, 358)
        PlaceOfBirthLabel.Name = "PlaceOfBirthLabel"
        PlaceOfBirthLabel.Size = New System.Drawing.Size(109, 20)
        PlaceOfBirthLabel.TabIndex = 130
        PlaceOfBirthLabel.Text = "Place of Birth:"
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateOfBirthLabel.Location = New System.Drawing.Point(21, 333)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(103, 20)
        DateOfBirthLabel.TabIndex = 128
        DateOfBirthLabel.Text = "Date of Birth:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.Location = New System.Drawing.Point(21, 306)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(87, 20)
        UsernameLabel.TabIndex = 126
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.Location = New System.Drawing.Point(21, 280)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(83, 20)
        PasswordLabel.TabIndex = 124
        PasswordLabel.Text = "Password:"
        '
        'TeacherIDLabel
        '
        TeacherIDLabel.AutoSize = True
        TeacherIDLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TeacherIDLabel.Location = New System.Drawing.Point(21, 254)
        TeacherIDLabel.Name = "TeacherIDLabel"
        TeacherIDLabel.Size = New System.Drawing.Size(92, 20)
        TeacherIDLabel.TabIndex = 122
        TeacherIDLabel.Text = "Teacher ID:"
        '
        'TeacherInfoBindingSource
        '
        Me.TeacherInfoBindingSource.DataMember = "TeacherInfo"
        Me.TeacherInfoBindingSource.DataSource = Me.Pre_enrollmentDataSet
        '
        'Pre_enrollmentDataSet
        '
        Me.Pre_enrollmentDataSet.DataSetName = "Pre_enrollmentDataSet"
        Me.Pre_enrollmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TeacherInfoTableAdapter
        '
        Me.TeacherInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminInfoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EnrollmentDataTableAdapter = Nothing
        Me.TableAdapterManager.SchoolInfoTableAdapter = Nothing
        Me.TableAdapterManager.SubjectTableAdapter = Nothing
        Me.TableAdapterManager.TeacherInfoTableAdapter = Me.TeacherInfoTableAdapter
        Me.TableAdapterManager.UpdateOrder = SchoolManagementSystem.Pre_enrollmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TeacherInfoBindingNavigatorSaveItem
        '
        Me.TeacherInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TeacherInfoBindingNavigatorSaveItem.Image = CType(resources.GetObject("TeacherInfoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TeacherInfoBindingNavigatorSaveItem.Name = "TeacherInfoBindingNavigatorSaveItem"
        Me.TeacherInfoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TeacherInfoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TeacherInfoBindingNavigator
        '
        Me.TeacherInfoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TeacherInfoBindingNavigator.BindingSource = Me.TeacherInfoBindingSource
        Me.TeacherInfoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TeacherInfoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TeacherInfoBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TeacherInfoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TeacherInfoBindingNavigatorSaveItem})
        Me.TeacherInfoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TeacherInfoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TeacherInfoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TeacherInfoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TeacherInfoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TeacherInfoBindingNavigator.Name = "TeacherInfoBindingNavigator"
        Me.TeacherInfoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TeacherInfoBindingNavigator.Size = New System.Drawing.Size(992, 25)
        Me.TeacherInfoBindingNavigator.TabIndex = 0
        Me.TeacherInfoBindingNavigator.Text = "BindingNavigator1"
        Me.TeacherInfoBindingNavigator.Visible = False
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtUncrypticPassword)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(TeacherIDLabel)
        Me.Panel1.Controls.Add(Me.TeacherIDTextBox)
        Me.Panel1.Controls.Add(PasswordLabel)
        Me.Panel1.Controls.Add(Me.PasswordTextBox)
        Me.Panel1.Controls.Add(UsernameLabel)
        Me.Panel1.Controls.Add(Me.UsernameTextBox)
        Me.Panel1.Controls.Add(DateOfBirthLabel)
        Me.Panel1.Controls.Add(Me.DateOfBirthDateTimePicker)
        Me.Panel1.Controls.Add(PlaceOfBirthLabel)
        Me.Panel1.Controls.Add(Me.PlaceOfBirthTextBox)
        Me.Panel1.Controls.Add(EmailIDLabel)
        Me.Panel1.Controls.Add(Me.EmailIDTextBox)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Me.txtSearchUsername)
        Me.Panel1.Controls.Add(Me.cmbCapture)
        Me.Panel1.Controls.Add(Me.btnCapture)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnRemove)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.btnBrowse)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Me.txtSearchTeacherID)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(46, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 476)
        Me.Panel1.TabIndex = 0
        '
        'txtUncrypticPassword
        '
        Me.txtUncrypticPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeacherInfoBindingSource, "Password", True))
        Me.txtUncrypticPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUncrypticPassword.Location = New System.Drawing.Point(139, 277)
        Me.txtUncrypticPassword.Name = "txtUncrypticPassword"
        Me.txtUncrypticPassword.Size = New System.Drawing.Size(250, 23)
        Me.txtUncrypticPassword.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Purple
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(225, 417)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 32)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'TeacherIDTextBox
        '
        Me.TeacherIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeacherInfoBindingSource, "TeacherID", True))
        Me.TeacherIDTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherIDTextBox.Location = New System.Drawing.Point(139, 251)
        Me.TeacherIDTextBox.Name = "TeacherIDTextBox"
        Me.TeacherIDTextBox.Size = New System.Drawing.Size(250, 23)
        Me.TeacherIDTextBox.TabIndex = 0
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeacherInfoBindingSource, "Password", True))
        Me.PasswordTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(390, 277)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(10, 23)
        Me.PasswordTextBox.TabIndex = 125
        Me.PasswordTextBox.Visible = False
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeacherInfoBindingSource, "Username", True))
        Me.UsernameTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(139, 303)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(250, 23)
        Me.UsernameTextBox.TabIndex = 2
        '
        'DateOfBirthDateTimePicker
        '
        Me.DateOfBirthDateTimePicker.CustomFormat = "MMMM / d / yyyy"
        Me.DateOfBirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TeacherInfoBindingSource, "DateOfBirth", True))
        Me.DateOfBirthDateTimePicker.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfBirthDateTimePicker.Location = New System.Drawing.Point(139, 329)
        Me.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        Me.DateOfBirthDateTimePicker.Size = New System.Drawing.Size(250, 23)
        Me.DateOfBirthDateTimePicker.TabIndex = 3
        '
        'PlaceOfBirthTextBox
        '
        Me.PlaceOfBirthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeacherInfoBindingSource, "PlaceOfBirth", True))
        Me.PlaceOfBirthTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaceOfBirthTextBox.Location = New System.Drawing.Point(139, 355)
        Me.PlaceOfBirthTextBox.Name = "PlaceOfBirthTextBox"
        Me.PlaceOfBirthTextBox.Size = New System.Drawing.Size(250, 23)
        Me.PlaceOfBirthTextBox.TabIndex = 4
        '
        'EmailIDTextBox
        '
        Me.EmailIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeacherInfoBindingSource, "EmailID", True))
        Me.EmailIDTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailIDTextBox.Location = New System.Drawing.Point(139, 381)
        Me.EmailIDTextBox.Name = "EmailIDTextBox"
        Me.EmailIDTextBox.Size = New System.Drawing.Size(250, 23)
        Me.EmailIDTextBox.TabIndex = 5
        '
        'txtSearchUsername
        '
        Me.txtSearchUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchUsername.Location = New System.Drawing.Point(597, 65)
        Me.txtSearchUsername.Name = "txtSearchUsername"
        Me.txtSearchUsername.Size = New System.Drawing.Size(200, 22)
        Me.txtSearchUsername.TabIndex = 14
        '
        'cmbCapture
        '
        Me.cmbCapture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbCapture.Enabled = False
        Me.cmbCapture.FormattingEnabled = True
        Me.cmbCapture.Location = New System.Drawing.Point(3, 6)
        Me.cmbCapture.Name = "cmbCapture"
        Me.cmbCapture.Size = New System.Drawing.Size(10, 21)
        Me.cmbCapture.TabIndex = 120
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
        Me.btnCapture.Location = New System.Drawing.Point(517, 422)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(109, 30)
        Me.btnCapture.TabIndex = 10
        Me.btnCapture.Text = "&Capture"
        Me.btnCapture.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCapture.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureID)
        Me.GroupBox2.Location = New System.Drawing.Point(597, 249)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(160, 167)
        Me.GroupBox2.TabIndex = 119
        Me.GroupBox2.TabStop = False
        '
        'PictureID
        '
        Me.PictureID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureID.Image = CType(resources.GetObject("PictureID.Image"), System.Drawing.Image)
        Me.PictureID.Location = New System.Drawing.Point(5, 11)
        Me.PictureID.Name = "PictureID"
        Me.PictureID.Size = New System.Drawing.Size(150, 150)
        Me.PictureID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureID.TabIndex = 11
        Me.PictureID.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Maroon
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(325, 417)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 32)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(125, 417)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 32)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Maroon
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemove.Location = New System.Drawing.Point(747, 422)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(109, 30)
        Me.btnRemove.TabIndex = 12
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Navy
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(25, 417)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 32)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.Green
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Image = CType(resources.GetObject("btnBrowse.Image"), System.Drawing.Image)
        Me.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBrowse.Location = New System.Drawing.Point(632, 422)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(109, 30)
        Me.btnBrowse.TabIndex = 11
        Me.btnBrowse.Text = "&Browse  "
        Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'txtSearchTeacherID
        '
        Me.txtSearchTeacherID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchTeacherID.Location = New System.Drawing.Point(170, 65)
        Me.txtSearchTeacherID.Name = "txtSearchTeacherID"
        Me.txtSearchTeacherID.Size = New System.Drawing.Size(200, 22)
        Me.txtSearchTeacherID.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TeacherIDDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.PlaceOfBirthDataGridViewTextBoxColumn, Me.EmailIDDataGridViewTextBoxColumn, Me.TeacherPicDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.TeacherInfoBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(25, 93)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(850, 150)
        Me.DataGridView1.TabIndex = 13
        '
        'TeacherIDDataGridViewTextBoxColumn
        '
        Me.TeacherIDDataGridViewTextBoxColumn.DataPropertyName = "TeacherID"
        Me.TeacherIDDataGridViewTextBoxColumn.HeaderText = "Teacher ID"
        Me.TeacherIDDataGridViewTextBoxColumn.Name = "TeacherIDDataGridViewTextBoxColumn"
        Me.TeacherIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date of Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        Me.DateOfBirthDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PlaceOfBirthDataGridViewTextBoxColumn
        '
        Me.PlaceOfBirthDataGridViewTextBoxColumn.DataPropertyName = "PlaceOfBirth"
        Me.PlaceOfBirthDataGridViewTextBoxColumn.HeaderText = "Place of Birth"
        Me.PlaceOfBirthDataGridViewTextBoxColumn.Name = "PlaceOfBirthDataGridViewTextBoxColumn"
        Me.PlaceOfBirthDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailIDDataGridViewTextBoxColumn
        '
        Me.EmailIDDataGridViewTextBoxColumn.DataPropertyName = "EmailID"
        Me.EmailIDDataGridViewTextBoxColumn.HeaderText = "Email ID"
        Me.EmailIDDataGridViewTextBoxColumn.Name = "EmailIDDataGridViewTextBoxColumn"
        Me.EmailIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TeacherPicDataGridViewImageColumn
        '
        Me.TeacherPicDataGridViewImageColumn.DataPropertyName = "TeacherPic"
        Me.TeacherPicDataGridViewImageColumn.HeaderText = "TeacherPic"
        Me.TeacherPicDataGridViewImageColumn.Name = "TeacherPicDataGridViewImageColumn"
        Me.TeacherPicDataGridViewImageColumn.ReadOnly = True
        Me.TeacherPicDataGridViewImageColumn.Visible = False
        '
        'picHelp1
        '
        Me.picHelp1.BackColor = System.Drawing.Color.Transparent
        Me.picHelp1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picHelp1.Image = CType(resources.GetObject("picHelp1.Image"), System.Drawing.Image)
        Me.picHelp1.Location = New System.Drawing.Point(953, 12)
        Me.picHelp1.Name = "picHelp1"
        Me.picHelp1.Size = New System.Drawing.Size(30, 30)
        Me.picHelp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHelp1.TabIndex = 22
        Me.picHelp1.TabStop = False
        '
        'TeacherData
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(995, 642)
        Me.Controls.Add(Me.picHelp1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TeacherInfoBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TeacherData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.TeacherInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pre_enrollmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherInfoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TeacherInfoBindingNavigator.ResumeLayout(False)
        Me.TeacherInfoBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHelp1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pre_enrollmentDataSet As Pre_enrollmentDataSet
    Friend WithEvents TeacherInfoBindingSource As BindingSource
    Friend WithEvents TeacherInfoTableAdapter As Pre_enrollmentDataSetTableAdapters.TeacherInfoTableAdapter
    Friend WithEvents TableAdapterManager As Pre_enrollmentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents TeacherInfoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TeacherInfoBindingNavigator As BindingNavigator
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtUncrypticPassword As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents TeacherIDTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents DateOfBirthDateTimePicker As DateTimePicker
    Friend WithEvents PlaceOfBirthTextBox As TextBox
    Friend WithEvents EmailIDTextBox As TextBox
    Friend WithEvents txtSearchUsername As TextBox
    Friend WithEvents cmbCapture As ComboBox
    Friend WithEvents btnCapture As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureID As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtSearchTeacherID As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TeacherIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlaceOfBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeacherPicDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents picHelp1 As PictureBox
End Class
