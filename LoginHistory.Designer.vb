<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginHistory
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
        Dim Label3 As System.Windows.Forms.Label
        Dim LogIDLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim LoginDateLabel As System.Windows.Forms.Label
        Dim TimeInLabel As System.Windows.Forms.Label
        Dim TimeOutLabel As System.Windows.Forms.Label
        Dim RemarkLabel As System.Windows.Forms.Label
        Dim lblSearchUsername As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginHistory))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblLogs = New System.Windows.Forms.Label()
        Me.btnDeleteAll = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelSearchUsername = New System.Windows.Forms.Panel()
        Me.txtSearchUsername = New System.Windows.Forms.TextBox()
        Me.rdoUsername = New System.Windows.Forms.RadioButton()
        Me.rdoSelectedDates = New System.Windows.Forms.RadioButton()
        Me.rdoAllDates = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.LogIDTextBox = New System.Windows.Forms.TextBox()
        Me.LogHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Pre_enrollmentDataSet1 = New SchoolManagementSystem._Pre_enrollmentDataSet1()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.LoginDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TimeInTextBox = New System.Windows.Forms.TextBox()
        Me.TimeOutTextBox = New System.Windows.Forms.TextBox()
        Me.RemarkTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LogIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeOutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogHistoryTableAdapter = New SchoolManagementSystem._Pre_enrollmentDataSet1TableAdapters.LogHistoryTableAdapter()
        Me.TableAdapterManager = New SchoolManagementSystem._Pre_enrollmentDataSet1TableAdapters.TableAdapterManager()
        Me.LogHistoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogHistoryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picHelp1 = New System.Windows.Forms.PictureBox()
        Label3 = New System.Windows.Forms.Label()
        LogIDLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        LoginDateLabel = New System.Windows.Forms.Label()
        TimeInLabel = New System.Windows.Forms.Label()
        TimeOutLabel = New System.Windows.Forms.Label()
        RemarkLabel = New System.Windows.Forms.Label()
        lblSearchUsername = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelSearchUsername.SuspendLayout()
        CType(Me.LogHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Pre_enrollmentDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogHistoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LogHistoryBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHelp1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(18, 25)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(372, 37)
        Label3.TabIndex = 18
        Label3.Text = "Login History Database"
        '
        'LogIDLabel
        '
        LogIDLabel.AutoSize = True
        LogIDLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LogIDLabel.Location = New System.Drawing.Point(21, 277)
        LogIDLabel.Name = "LogIDLabel"
        LogIDLabel.Size = New System.Drawing.Size(63, 21)
        LogIDLabel.TabIndex = 134
        LogIDLabel.Text = "Log ID:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.Location = New System.Drawing.Point(21, 303)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(92, 21)
        UsernameLabel.TabIndex = 136
        UsernameLabel.Text = "Username:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PositionLabel.Location = New System.Drawing.Point(21, 329)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(72, 21)
        PositionLabel.TabIndex = 138
        PositionLabel.Text = "Position:"
        '
        'LoginDateLabel
        '
        LoginDateLabel.AutoSize = True
        LoginDateLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LoginDateLabel.Location = New System.Drawing.Point(21, 356)
        LoginDateLabel.Name = "LoginDateLabel"
        LoginDateLabel.Size = New System.Drawing.Size(99, 21)
        LoginDateLabel.TabIndex = 140
        LoginDateLabel.Text = "Login Date:"
        '
        'TimeInLabel
        '
        TimeInLabel.AutoSize = True
        TimeInLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TimeInLabel.Location = New System.Drawing.Point(21, 381)
        TimeInLabel.Name = "TimeInLabel"
        TimeInLabel.Size = New System.Drawing.Size(69, 21)
        TimeInLabel.TabIndex = 142
        TimeInLabel.Text = "Time In:"
        '
        'TimeOutLabel
        '
        TimeOutLabel.AutoSize = True
        TimeOutLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TimeOutLabel.Location = New System.Drawing.Point(21, 407)
        TimeOutLabel.Name = "TimeOutLabel"
        TimeOutLabel.Size = New System.Drawing.Size(85, 21)
        TimeOutLabel.TabIndex = 144
        TimeOutLabel.Text = "Time Out:"
        '
        'RemarkLabel
        '
        RemarkLabel.AutoSize = True
        RemarkLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RemarkLabel.Location = New System.Drawing.Point(21, 433)
        RemarkLabel.Name = "RemarkLabel"
        RemarkLabel.Size = New System.Drawing.Size(73, 21)
        RemarkLabel.TabIndex = 146
        RemarkLabel.Text = "Remark:"
        '
        'lblSearchUsername
        '
        lblSearchUsername.AutoSize = True
        lblSearchUsername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblSearchUsername.Location = New System.Drawing.Point(3, 9)
        lblSearchUsername.Name = "lblSearchUsername"
        lblSearchUsername.Size = New System.Drawing.Size(173, 21)
        lblSearchUsername.TabIndex = 15
        lblSearchUsername.Text = "Search by Username:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblLogs)
        Me.Panel1.Controls.Add(Me.btnDeleteAll)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Panel1.Controls.Add(Me.btnExport)
        Me.Panel1.Controls.Add(LogIDLabel)
        Me.Panel1.Controls.Add(Me.LogIDTextBox)
        Me.Panel1.Controls.Add(UsernameLabel)
        Me.Panel1.Controls.Add(Me.UsernameTextBox)
        Me.Panel1.Controls.Add(PositionLabel)
        Me.Panel1.Controls.Add(Me.PositionTextBox)
        Me.Panel1.Controls.Add(LoginDateLabel)
        Me.Panel1.Controls.Add(Me.LoginDateDateTimePicker)
        Me.Panel1.Controls.Add(TimeInLabel)
        Me.Panel1.Controls.Add(Me.TimeInTextBox)
        Me.Panel1.Controls.Add(TimeOutLabel)
        Me.Panel1.Controls.Add(Me.TimeOutTextBox)
        Me.Panel1.Controls.Add(RemarkLabel)
        Me.Panel1.Controls.Add(Me.RemarkTextBox)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(46, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 490)
        Me.Panel1.TabIndex = 15
        '
        'lblLogs
        '
        Me.lblLogs.AutoSize = True
        Me.lblLogs.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogs.Location = New System.Drawing.Point(638, 37)
        Me.lblLogs.Name = "lblLogs"
        Me.lblLogs.Size = New System.Drawing.Size(156, 21)
        Me.lblLogs.TabIndex = 143
        Me.lblLogs.Text = "Number of logs: {0}"
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.BackColor = System.Drawing.Color.Maroon
        Me.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAll.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAll.ForeColor = System.Drawing.Color.White
        Me.btnDeleteAll.Image = CType(resources.GetObject("btnDeleteAll.Image"), System.Drawing.Image)
        Me.btnDeleteAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteAll.Location = New System.Drawing.Point(637, 440)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(116, 30)
        Me.btnDeleteAll.TabIndex = 151
        Me.btnDeleteAll.Text = "&Delete All"
        Me.btnDeleteAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteAll.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PanelSearchUsername)
        Me.Panel2.Controls.Add(Me.rdoUsername)
        Me.Panel2.Controls.Add(Me.rdoSelectedDates)
        Me.Panel2.Controls.Add(Me.rdoAllDates)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(382, 277)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(249, 193)
        Me.Panel2.TabIndex = 149
        '
        'PanelSearchUsername
        '
        Me.PanelSearchUsername.Controls.Add(lblSearchUsername)
        Me.PanelSearchUsername.Controls.Add(Me.txtSearchUsername)
        Me.PanelSearchUsername.Location = New System.Drawing.Point(16, 110)
        Me.PanelSearchUsername.Name = "PanelSearchUsername"
        Me.PanelSearchUsername.Size = New System.Drawing.Size(218, 67)
        Me.PanelSearchUsername.TabIndex = 16
        '
        'txtSearchUsername
        '
        Me.txtSearchUsername.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchUsername.Location = New System.Drawing.Point(7, 33)
        Me.txtSearchUsername.Name = "txtSearchUsername"
        Me.txtSearchUsername.Size = New System.Drawing.Size(200, 23)
        Me.txtSearchUsername.TabIndex = 0
        '
        'rdoUsername
        '
        Me.rdoUsername.AutoSize = True
        Me.rdoUsername.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoUsername.Location = New System.Drawing.Point(41, 88)
        Me.rdoUsername.Name = "rdoUsername"
        Me.rdoUsername.Size = New System.Drawing.Size(193, 21)
        Me.rdoUsername.TabIndex = 3
        Me.rdoUsername.Text = "Username inputted below"
        Me.rdoUsername.UseVisualStyleBackColor = True
        '
        'rdoSelectedDates
        '
        Me.rdoSelectedDates.AutoSize = True
        Me.rdoSelectedDates.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSelectedDates.Location = New System.Drawing.Point(41, 61)
        Me.rdoSelectedDates.Name = "rdoSelectedDates"
        Me.rdoSelectedDates.Size = New System.Drawing.Size(130, 21)
        Me.rdoSelectedDates.TabIndex = 2
        Me.rdoSelectedDates.Text = "Date(s) selected"
        Me.rdoSelectedDates.UseVisualStyleBackColor = True
        '
        'rdoAllDates
        '
        Me.rdoAllDates.AutoSize = True
        Me.rdoAllDates.Checked = True
        Me.rdoAllDates.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAllDates.Location = New System.Drawing.Point(41, 34)
        Me.rdoAllDates.Name = "rdoAllDates"
        Me.rdoAllDates.Size = New System.Drawing.Size(82, 21)
        Me.rdoAllDates.TabIndex = 1
        Me.rdoAllDates.TabStop = True
        Me.rdoAllDates.Text = "All Dates"
        Me.rdoAllDates.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Filter modes:"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(642, 277)
        Me.MonthCalendar1.MaxSelectionCount = 14
        Me.MonthCalendar1.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 148
        Me.MonthCalendar1.TrailingForeColor = System.Drawing.SystemColors.MenuHighlight
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.Green
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExport.Location = New System.Drawing.Point(759, 440)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(116, 30)
        Me.btnExport.TabIndex = 150
        Me.btnExport.Text = "&Export  "
        Me.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'LogIDTextBox
        '
        Me.LogIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LogHistoryBindingSource, "LogID", True))
        Me.LogIDTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogIDTextBox.Location = New System.Drawing.Point(126, 276)
        Me.LogIDTextBox.Name = "LogIDTextBox"
        Me.LogIDTextBox.ReadOnly = True
        Me.LogIDTextBox.Size = New System.Drawing.Size(250, 23)
        Me.LogIDTextBox.TabIndex = 135
        '
        'LogHistoryBindingSource
        '
        Me.LogHistoryBindingSource.DataMember = "LogHistory"
        Me.LogHistoryBindingSource.DataSource = Me._Pre_enrollmentDataSet1
        '
        '_Pre_enrollmentDataSet1
        '
        Me._Pre_enrollmentDataSet1.DataSetName = "_Pre_enrollmentDataSet1"
        Me._Pre_enrollmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LogHistoryBindingSource, "Username", True))
        Me.UsernameTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(126, 302)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.ReadOnly = True
        Me.UsernameTextBox.Size = New System.Drawing.Size(250, 23)
        Me.UsernameTextBox.TabIndex = 137
        '
        'PositionTextBox
        '
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LogHistoryBindingSource, "Position", True))
        Me.PositionTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PositionTextBox.Location = New System.Drawing.Point(126, 328)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.ReadOnly = True
        Me.PositionTextBox.Size = New System.Drawing.Size(250, 23)
        Me.PositionTextBox.TabIndex = 139
        '
        'LoginDateDateTimePicker
        '
        Me.LoginDateDateTimePicker.CustomFormat = "   MMM / d / yyyy"
        Me.LoginDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LogHistoryBindingSource, "LoginDate", True))
        Me.LoginDateDateTimePicker.Enabled = False
        Me.LoginDateDateTimePicker.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LoginDateDateTimePicker.Location = New System.Drawing.Point(126, 354)
        Me.LoginDateDateTimePicker.Name = "LoginDateDateTimePicker"
        Me.LoginDateDateTimePicker.Size = New System.Drawing.Size(250, 23)
        Me.LoginDateDateTimePicker.TabIndex = 141
        '
        'TimeInTextBox
        '
        Me.TimeInTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LogHistoryBindingSource, "TimeIn", True))
        Me.TimeInTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeInTextBox.Location = New System.Drawing.Point(126, 380)
        Me.TimeInTextBox.Name = "TimeInTextBox"
        Me.TimeInTextBox.ReadOnly = True
        Me.TimeInTextBox.Size = New System.Drawing.Size(250, 23)
        Me.TimeInTextBox.TabIndex = 143
        '
        'TimeOutTextBox
        '
        Me.TimeOutTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LogHistoryBindingSource, "TimeOut", True))
        Me.TimeOutTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeOutTextBox.Location = New System.Drawing.Point(126, 406)
        Me.TimeOutTextBox.Name = "TimeOutTextBox"
        Me.TimeOutTextBox.ReadOnly = True
        Me.TimeOutTextBox.Size = New System.Drawing.Size(250, 23)
        Me.TimeOutTextBox.TabIndex = 145
        '
        'RemarkTextBox
        '
        Me.RemarkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LogHistoryBindingSource, "Remark", True))
        Me.RemarkTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemarkTextBox.Location = New System.Drawing.Point(126, 432)
        Me.RemarkTextBox.Name = "RemarkTextBox"
        Me.RemarkTextBox.ReadOnly = True
        Me.RemarkTextBox.Size = New System.Drawing.Size(250, 23)
        Me.RemarkTextBox.TabIndex = 147
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LogIDDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.LoginDateDataGridViewTextBoxColumn, Me.TimeInDataGridViewTextBoxColumn, Me.TimeOutDataGridViewTextBoxColumn, Me.RemarkDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LogHistoryBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(25, 65)
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
        Me.DataGridView1.Size = New System.Drawing.Size(850, 200)
        Me.DataGridView1.TabIndex = 13
        '
        'LogIDDataGridViewTextBoxColumn
        '
        Me.LogIDDataGridViewTextBoxColumn.DataPropertyName = "LogID"
        Me.LogIDDataGridViewTextBoxColumn.HeaderText = "Log ID"
        Me.LogIDDataGridViewTextBoxColumn.Name = "LogIDDataGridViewTextBoxColumn"
        Me.LogIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "Position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        Me.PositionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LoginDateDataGridViewTextBoxColumn
        '
        Me.LoginDateDataGridViewTextBoxColumn.DataPropertyName = "LoginDate"
        Me.LoginDateDataGridViewTextBoxColumn.HeaderText = "Login Date"
        Me.LoginDateDataGridViewTextBoxColumn.Name = "LoginDateDataGridViewTextBoxColumn"
        Me.LoginDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimeInDataGridViewTextBoxColumn
        '
        Me.TimeInDataGridViewTextBoxColumn.DataPropertyName = "TimeIn"
        Me.TimeInDataGridViewTextBoxColumn.HeaderText = "Time In"
        Me.TimeInDataGridViewTextBoxColumn.Name = "TimeInDataGridViewTextBoxColumn"
        Me.TimeInDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimeOutDataGridViewTextBoxColumn
        '
        Me.TimeOutDataGridViewTextBoxColumn.DataPropertyName = "TimeOut"
        Me.TimeOutDataGridViewTextBoxColumn.HeaderText = "Time Out"
        Me.TimeOutDataGridViewTextBoxColumn.Name = "TimeOutDataGridViewTextBoxColumn"
        Me.TimeOutDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemarkDataGridViewTextBoxColumn
        '
        Me.RemarkDataGridViewTextBoxColumn.DataPropertyName = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.HeaderText = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.Name = "RemarkDataGridViewTextBoxColumn"
        Me.RemarkDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LogHistoryTableAdapter
        '
        Me.LogHistoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminInfoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EnrollmentDataTableAdapter = Nothing
        Me.TableAdapterManager.LogHistoryTableAdapter = Me.LogHistoryTableAdapter
        Me.TableAdapterManager.SchoolInfoTableAdapter = Nothing
        Me.TableAdapterManager.SubjectTableAdapter = Nothing
        Me.TableAdapterManager.TeacherInfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SchoolManagementSystem._Pre_enrollmentDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LogHistoryBindingNavigator
        '
        Me.LogHistoryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LogHistoryBindingNavigator.BindingSource = Me.LogHistoryBindingSource
        Me.LogHistoryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LogHistoryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LogHistoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LogHistoryBindingNavigatorSaveItem})
        Me.LogHistoryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LogHistoryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LogHistoryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LogHistoryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LogHistoryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LogHistoryBindingNavigator.Name = "LogHistoryBindingNavigator"
        Me.LogHistoryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LogHistoryBindingNavigator.Size = New System.Drawing.Size(995, 25)
        Me.LogHistoryBindingNavigator.TabIndex = 16
        Me.LogHistoryBindingNavigator.Text = "BindingNavigator1"
        Me.LogHistoryBindingNavigator.Visible = False
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'LogHistoryBindingNavigatorSaveItem
        '
        Me.LogHistoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LogHistoryBindingNavigatorSaveItem.Image = CType(resources.GetObject("LogHistoryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LogHistoryBindingNavigatorSaveItem.Name = "LogHistoryBindingNavigatorSaveItem"
        Me.LogHistoryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LogHistoryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(46, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(450, 70)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
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
        Me.picHelp1.TabIndex = 23
        Me.picHelp1.TabStop = False
        '
        'LoginHistory
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.SchoolManagementSystem.My.Resources.Resources.background_blured
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(995, 642)
        Me.Controls.Add(Me.picHelp1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LogHistoryBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login History"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelSearchUsername.ResumeLayout(False)
        Me.PanelSearchUsername.PerformLayout()
        CType(Me.LogHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Pre_enrollmentDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogHistoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LogHistoryBindingNavigator.ResumeLayout(False)
        Me.LogHistoryBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHelp1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents _Pre_enrollmentDataSet1 As _Pre_enrollmentDataSet1
    Friend WithEvents LogHistoryBindingSource As BindingSource
    Friend WithEvents LogHistoryTableAdapter As _Pre_enrollmentDataSet1TableAdapters.LogHistoryTableAdapter
    Friend WithEvents TableAdapterManager As _Pre_enrollmentDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents LogHistoryBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents LogHistoryBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents LogIDTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents LoginDateDateTimePicker As DateTimePicker
    Friend WithEvents TimeInTextBox As TextBox
    Friend WithEvents TimeOutTextBox As TextBox
    Friend WithEvents RemarkTextBox As TextBox
    Friend WithEvents btnDeleteAll As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelSearchUsername As Panel
    Friend WithEvents txtSearchUsername As TextBox
    Friend WithEvents rdoUsername As RadioButton
    Friend WithEvents rdoSelectedDates As RadioButton
    Friend WithEvents rdoAllDates As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents btnExport As Button
    Friend WithEvents lblLogs As Label
    Friend WithEvents LogIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoginDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeInDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeOutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemarkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picHelp1 As PictureBox
End Class
