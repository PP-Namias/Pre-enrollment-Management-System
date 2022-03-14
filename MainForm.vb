Imports System.Data.OleDb
Imports System.IO

Public Class MainForm

    Private currentForm As Form = Nothing
    Private Sub OpenChildForm(childForm As Form)

        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        childForm.BringToFront()
        childForm.Show()

    End Sub

    Private Sub RoundButton(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnStatus.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnStatus.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonEnrollmentPortal(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnEnrollmentPortal.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnEnrollmentPortal.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonEnrollmentDatabase(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnEnrollmentDatabase.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnEnrollmentDatabase.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonTeacherDatabase(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnTeacherDatabase.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnTeacherDatabase.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonSchoolDatabase(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnSchoolDatabase.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnSchoolDatabase.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonPrintID(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnPrintID.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnPrintID.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonLoginHistory(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnLoginHistory.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnLoginHistory.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonAboutMe(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnAboutMe.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnAboutMe.Region = New Region(Raduis)

    End Sub

    Public Sub UserData()

        UserInfo.Dispose()
        SchoolInfo.Dispose()
        GenarateID.Dispose()
        PrintID.Dispose()
        TeacherData.Dispose()
        StudentEnrollment.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        AboutMe.Dispose()
        LoginHistory.Dispose()
        AboutMe.Dispose()
        CapturePicture.Dispose()
        ChangeInfo.Dispose()
        ChangePassword.Dispose()
        ForgotPassword.Dispose()
        GenarateID.Dispose()
        LoginGuide.Dispose()
        MainFormGuide.Dispose()
        PrintID.Dispose()
        RegistrarInfo.Dispose()
        SchoolInfo.Dispose()
        SelectStudents.Dispose()
        StudentEnrollment.Dispose()
        StudentEnrollmentGuide.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        TeacherDataGuide.Dispose()
        UserInfo.Dispose()

        PictureBox1.Visible = False

        Dim User As New UserInfo
        Dispose()
        User.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        TimeToolStripStatusLabel.Text = Now.ToLongTimeString.ToString()
        TimeToolStripStatusLabel.ForeColor = Color.White

    End Sub

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If LoginForm.cmbFormState.Text = "" Then

            LoginForm.txtAdminUsername.Text = ""
            LoginForm.txtAdminPassword.Text = ""
            LoginForm.txtTeacherUsername.Text = ""
            LoginForm.txtTeacherPassword.Text = ""
            Dispose()
            LoginForm.Show()

            Return

        End If

        Try

            Dim DatabaseConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")
            If DatabaseConnection.State = ConnectionState.Open Then DatabaseConnection.Close()
            DatabaseConnection.Open()

            Dim DatabaseDataReader As OleDbDataReader
            Dim DatabaseCommand As New OleDbCommand

            'Admin
            If LoginForm.cmbFormState.Text = "Admin" Then

                DatabaseCommand.CommandText = "select [AdminID],[Username] from AdminInfo where AdminID = '" & LoginForm.txtAdminUsername.Text & "'"
                DatabaseCommand.Connection = DatabaseConnection

                DatabaseDataReader = DatabaseCommand.ExecuteReader
                If DatabaseDataReader.Read Then
                    Dim intResponse As Integer
                    intResponse = MessageBox.Show("Do you really want to logout?", "Response", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If intResponse = MsgBoxResult.No Then
                        e.Cancel = True
                        ' Exit Sub
                    Else
                        MsgBox("Thank you!! " & DatabaseDataReader("Username").ToString() & vbNewLine & "" & vbNewLine & " God Bless U...", MsgBoxStyle.Information, "Thank you...")
                        DatabaseConnection.Close()

                        Try

                            txtTimeOut.Text = Format(Now, "h:mm:ss tt")

                            Dim UpdateConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

                            If UpdateConnection.State = ConnectionState.Open Then UpdateConnection.Close()
                            UpdateConnection.Open()

                            Dim TeacherCommand As New OleDbCommand("Update LogHistory Set TimeOut=@TimeOut,Remark=@Remark Where (Username='" & LoginForm.txtUsername.Text.ToString & "' AND LoginDate=#" & LoginForm.dtpLoginDate.Text.ToString & "# AND TimeIn=#" & LoginForm.txtTimeIn.Text.ToString & "#)", UpdateConnection)

                            ' TimeOut
                            Dim TimeOut As New OleDbParameter("@TimeOut", OleDbType.VarWChar, 50) With {
                                .Value = txtTimeOut.Text.ToString()
                            }
                            TeacherCommand.Parameters.Add(TimeOut)

                            ' Remark
                            Dim Remark As New OleDbParameter("@Remark", OleDbType.VarWChar, 50) With {
                                .Value = txtRemark.Text.ToString()
                            }
                            TeacherCommand.Parameters.Add(Remark)

                            If TeacherCommand.ExecuteNonQuery() Then

                                UpdateConnection.Close()

                                Dispose()
                                LoginForm.Show()
                                LoginForm.txtAdminUsername.Text = ""
                                LoginForm.txtAdminPassword.Text = ""
                                LoginForm.txtTeacherUsername.Text = ""
                                LoginForm.txtTeacherPassword.Text = ""

                            Else

                                MsgBox("Your 'Log out' UPDATE has been failed" & vbNewLine & vbNewLine & "Please contact your coordinator and take a screenshot for evidence" & vbNewLine & vbNewLine & "but if your guest please ignore.", MsgBoxStyle.Critical, "Log Failed")
                                Return

                            End If

                        Catch ex As Exception

                            MessageBox.Show(ex.Message.ToString(), "Log Error")
                            Exit Sub

                        End Try

                    End If

                End If

            End If

            'Teacher
            If LoginForm.cmbFormState.Text = "Teacher" Then

                DatabaseCommand.CommandText = "select [TeacherID],[Username] from TeacherInfo where TeacherID = '" & LoginForm.txtTeacherUsername.Text & "'"
                DatabaseCommand.Connection = DatabaseConnection

                DatabaseDataReader = DatabaseCommand.ExecuteReader

                If DatabaseDataReader.Read Then

                    Dim intResponse As Integer
                    intResponse = MessageBox.Show("Do you really want to logout?", "Response", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If intResponse = MsgBoxResult.No Then

                        e.Cancel = True
                        ' Exit Sub

                    Else

                        MsgBox("Thank you!! " & DatabaseDataReader("Username").ToString() & vbNewLine & "" & vbNewLine & " God Bless U...", MsgBoxStyle.Information, "Thank you...")
                        DatabaseConnection.Close()

                        Try

                            txtTimeOut.Text = Format(Now, "h:mm:ss tt")

                            Dim UpdateConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

                            If UpdateConnection.State = ConnectionState.Open Then UpdateConnection.Close()
                            UpdateConnection.Open()

                            Dim TeacherCommand As New OleDbCommand("Update LogHistory Set TimeOut=@TimeOut,Remark=@Remark Where (Username='" & LoginForm.txtUsername.Text.ToString & "' AND LoginDate=#" & LoginForm.dtpLoginDate.Text.ToString & "# AND TimeIn=#" & LoginForm.txtTimeIn.Text.ToString & "#)", UpdateConnection)

                            ' TimeOut
                            Dim TimeOut As New OleDbParameter("@TimeOut", OleDbType.VarWChar, 50) With {
                                .Value = txtTimeOut.Text.ToString()
                            }
                            TeacherCommand.Parameters.Add(TimeOut)

                            ' Remark
                            Dim Remark As New OleDbParameter("@Remark", OleDbType.VarWChar, 50) With {
                                .Value = txtRemark.Text.ToString()
                            }
                            TeacherCommand.Parameters.Add(Remark)

                            If TeacherCommand.ExecuteNonQuery() Then

                                UpdateConnection.Close()

                                Dispose()
                                LoginForm.Show()
                                LoginForm.txtAdminUsername.Text = ""
                                LoginForm.txtAdminPassword.Text = ""
                                LoginForm.txtTeacherUsername.Text = ""
                                LoginForm.txtTeacherPassword.Text = ""

                            Else

                                MsgBox("Your 'Log out' UPDATE has been failed" & vbNewLine & vbNewLine & "Please contact your coordinator and take a screenshot for evidence" & vbNewLine & vbNewLine & "but if your guest please ignore.", MsgBoxStyle.Critical, "Log Failed")
                                Return

                            End If

                        Catch ex As Exception

                            MessageBox.Show(ex.Message.ToString(), "Log Error")
                            Exit Sub

                        End Try

                    End If

                End If

            End If

            'Guest
            If LoginForm.cmbFormState.Text = "Guest" Then
                Dim intResponse As Integer
                intResponse = MessageBox.Show("Do you really want to logout? ", "Response", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If intResponse = MsgBoxResult.No Then
                    e.Cancel = True
                    Exit Sub

                Else
                    MsgBox("Thank you, God Bless...", MsgBoxStyle.Information, "God Bless U...")
                    DatabaseConnection.Close()

                    Try

                        txtTimeOut.Text = Format(Now, "h:mm:ss tt")

                        Dim UpdateConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

                        If UpdateConnection.State = ConnectionState.Open Then UpdateConnection.Close()
                        UpdateConnection.Open()

                        Dim TeacherCommand As New OleDbCommand("Update LogHistory Set TimeOut=@TimeOut,Remark=@Remark Where (Username='" & LoginForm.txtUsername.Text.ToString & "' AND LoginDate=#" & LoginForm.dtpLoginDate.Text.ToString & "# AND TimeIn=#" & LoginForm.txtTimeIn.Text.ToString & "#)", UpdateConnection)

                        ' TimeOut
                        Dim TimeOut As New OleDbParameter("@TimeOut", OleDbType.VarWChar, 50) With {
                            .Value = txtTimeOut.Text.ToString()
                        }
                        TeacherCommand.Parameters.Add(TimeOut)

                        ' Remark
                        Dim Remark As New OleDbParameter("@Remark", OleDbType.VarWChar, 50) With {
                            .Value = txtRemark.Text.ToString()
                        }
                        TeacherCommand.Parameters.Add(Remark)

                        If TeacherCommand.ExecuteNonQuery() Then

                            UpdateConnection.Close()

                            Dispose()
                            LoginForm.Show()
                            LoginForm.txtAdminUsername.Text = ""
                            LoginForm.txtAdminPassword.Text = ""
                            LoginForm.txtTeacherUsername.Text = ""
                            LoginForm.txtTeacherPassword.Text = ""

                        Else

                            MsgBox("Your 'Log out' UPDATE has been failed" & vbNewLine & vbNewLine & "Please contact your coordinator and take a screenshot for evidence" & vbNewLine & vbNewLine & "but if your guest please ignore.", MsgBoxStyle.Critical, "Log Failed")
                            Return

                        End If

                    Catch ex As Exception

                        MessageBox.Show(ex.Message.ToString(), "Log Error")
                        Exit Sub

                    End Try

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error in closing data.")
            Exit Sub

        End Try

    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        RoundButton(btnStatus)
        RoundButtonEnrollmentPortal(btnEnrollmentPortal)
        RoundButtonEnrollmentDatabase(btnEnrollmentDatabase)
        RoundButtonTeacherDatabase(btnTeacherDatabase)
        RoundButtonSchoolDatabase(btnSchoolDatabase)
        RoundButtonPrintID(btnPrintID)
        RoundButtonLoginHistory(btnLoginHistory)
        RoundButtonAboutMe(btnAboutMe)

        txtTimeOut.Text = Format(Now, "h:mm:ss tt")

        PictureBox1.Visible = True

        DateToolStripStatusLabel.Text = DateTime.Now.ToString("MMM / dd / yyyy")
        DateToolStripStatusLabel.ForeColor = Color.White

        Try

            'Admin, Registrar, and Supervisors
            If LoginForm.cmbFormState.Text = "Admin" Then

                Dim AdminConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

                If AdminConnection.State = ConnectionState.Open Then AdminConnection.Close()
                AdminConnection.Open()

                Dim AdminDataReader As OleDbDataReader
                Dim AdminCommand As New OleDbCommand With {
                    .CommandText = "SELECT [AdminID],[Username],[Status],[AdminPic] FROM AdminInfo WHERE AdminID = '" & LoginForm.txtAdminUsername.Text & "'",
                    .Connection = AdminConnection
                }
                AdminDataReader = AdminCommand.ExecuteReader
                If AdminDataReader.Read Then
                    Username.Text = AdminDataReader(1).ToString()
                    UsernameToolStripStatusLabel.Text = AdminDataReader(1).ToString()
                    btnStatus.Text = AdminDataReader(2).ToString()
                    btnStatus.Enabled = True

                    Dim LoadPic As Byte() = AdminDataReader("AdminPic")
                    Dim Memory As New MemoryStream(LoadPic)
                    IDPicture.Image = Image.FromStream(Memory)

                    If (btnStatus.Text = "Registrar" Or btnStatus.Text = "Supervisor") = True Then

                        btnTeacherDatabase.Visible = False
                        btnSchoolDatabase.Visible = False
                        TeacherDatabaseToolStripMenuItem.Visible = False
                        SchoolDatabaseToolStripMenuItem.Visible = False
                        btnPrintID.Visible = True
                        AdminToolStripMenuItem1.Visible = True
                        btnEnrollmentDatabase.Visible = True
                        btnPrintID.Visible = False
                        btnLoginHistory.Visible = False

                        AdminToolStripMenuItem1.Visible = True
                        TeacherToolStripMenuItem2.Visible = False
                        GuestToolStripMenuItem3.Visible = False

                        UsernameToolStripStatusLabel.ForeColor = Color.DarkRed
                        TimeToolStripStatusLabel.ForeColor = Color.DarkRed

                    End If

                    If btnStatus.Text = "Super Admin" = True Then

                        btnTeacherDatabase.Visible = True
                        btnSchoolDatabase.Visible = True
                        TeacherDatabaseToolStripMenuItem.Visible = True
                        SchoolDatabaseToolStripMenuItem.Visible = True
                        btnPrintID.Visible = True
                        AdminToolStripMenuItem1.Visible = True
                        btnEnrollmentDatabase.Visible = True
                        btnPrintID.Visible = True
                        btnLoginHistory.Visible = True

                        AdminToolStripMenuItem1.Visible = True
                        TeacherToolStripMenuItem2.Visible = False
                        GuestToolStripMenuItem3.Visible = False

                        UsernameToolStripStatusLabel.ForeColor = Color.Purple
                        TimeToolStripStatusLabel.ForeColor = Color.Purple

                    End If

                End If

                AdminConnection.Close()
                AdminDataReader.Close()

                Return

            End If


            'Teachers
            If LoginForm.cmbFormState.Text = "Teacher" Then

                Dim TeacherConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

                If TeacherConnection.State = ConnectionState.Open Then TeacherConnection.Close()
                TeacherConnection.Open()

                Dim TeacherDataReader As OleDbDataReader
                Dim TeacherCommand As New OleDbCommand With {
                    .CommandText = "SELECT [TeacherID],[Username],[TeacherPic] FROM TeacherInfo WHERE TeacherID = '" & LoginForm.txtTeacherUsername.Text & "'",
                    .Connection = TeacherConnection
                }

                TeacherDataReader = TeacherCommand.ExecuteReader
                If TeacherDataReader.Read Then

                    Username.Text = TeacherDataReader(1).ToString()
                    UsernameToolStripStatusLabel.Text = TeacherDataReader(1).ToString()
                    btnStatus.Text = "Teacher"
                    btnStatus.Enabled = True

                    Dim LoadPic As Byte() = TeacherDataReader("TeacherPic")
                    Dim Memory As New MemoryStream(LoadPic)
                    IDPicture.Image = Image.FromStream(Memory)

                    AdministratorToolStripMenuItem.Visible = False

                    AdminToolStripMenuItem1.Visible = False
                    TeacherToolStripMenuItem2.Visible = True
                    GuestToolStripMenuItem3.Visible = False

                    btnTeacherDatabase.Visible = False
                    btnEnrollmentDatabase.Visible = False
                    btnSchoolDatabase.Visible = False
                    btnPrintID.Visible = False
                    btnLoginHistory.Visible = False

                    UsernameToolStripStatusLabel.ForeColor = Color.Green
                    TimeToolStripStatusLabel.ForeColor = Color.Green

                End If

                TeacherConnection.Close()
                TeacherDataReader.Close()

                Return

            End If

            'Guest
            If LoginForm.cmbFormState.Text = "Guest" Then

                Username.Text = "Guest"
                btnStatus.Text = "Guest"
                btnStatus.Enabled = False
                btnStatus.ForeColor = Color.White

                AdministratorToolStripMenuItem.Visible = False
                btnTeacherDatabase.Visible = False
                btnEnrollmentDatabase.Visible = False
                btnSchoolDatabase.Visible = False
                btnPrintID.Visible = False
                btnLoginHistory.Visible = False

                AdminToolStripMenuItem1.Visible = False
                TeacherToolStripMenuItem2.Visible = False
                GuestToolStripMenuItem3.Visible = True

                UsernameToolStripStatusLabel.ForeColor = Color.Black
                TimeToolStripStatusLabel.ForeColor = Color.Black

            End If

        Catch ex As Exception

            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Load Data Error")
            Exit Sub

        End Try

    End Sub

    Private Sub PicClose_Click(sender As Object, e As EventArgs) Handles picClose.Click

        Close()

    End Sub

    Private Sub PicMinimize_Click(sender As Object, e As EventArgs) Handles PicMinimize.Click

        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub EnrollmentPortalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnrollmentPortalToolStripMenuItem.Click

        PictureBox1.Visible = False

        StudentEnrollment.Show()

    End Sub
    Private Sub BtnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click

        UserData()

    End Sub

    Private Sub BtnEnrollment_Click(sender As Object, e As EventArgs) Handles btnEnrollmentPortal.Click

        PictureBox1.Visible = False

        StudentEnrollment.Show()

    End Sub

    Private Sub BtnTeacherDatabase_Click(sender As Object, e As EventArgs) Handles btnTeacherDatabase.Click

        PictureBox1.Visible = False
        UserInfo.Hide()
        SchoolInfo.Hide()
        GenarateID.Hide()
        PrintID.Hide()
        TeacherData.Hide()
        StudentEnrollment.Hide()
        StudentSubject.Hide()
        StudentRequirements.Hide()
        StudentRegistered.Hide()
        AboutMe.Hide()
        LoginHistory.Hide()

        UserInfo.Dispose()
        SchoolInfo.Dispose()
        GenarateID.Dispose()
        PrintID.Dispose()
        TeacherData.Dispose()
        StudentEnrollment.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        AboutMe.Dispose()
        LoginHistory.Dispose()
        AboutMe.Dispose()
        CapturePicture.Dispose()
        ChangeInfo.Dispose()
        ChangePassword.Dispose()
        ForgotPassword.Dispose()
        GenarateID.Dispose()
        LoginGuide.Dispose()
        MainFormGuide.Dispose()
        PrintID.Dispose()
        RegistrarInfo.Dispose()
        SchoolInfo.Dispose()
        SelectStudents.Dispose()
        StudentEnrollment.Dispose()
        StudentEnrollmentGuide.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        TeacherDataGuide.Dispose()
        UserInfo.Dispose()

        Dim newmdichild As New TeacherData With {
            .MdiParent = Me
        }
        newmdichild.Show()

        OpenChildForm(New TeacherData())

    End Sub

    Private Sub BtnEnrollmentDatabase_Click(sender As Object, e As EventArgs) Handles btnEnrollmentDatabase.Click

        PictureBox1.Visible = False
        UserInfo.Hide()
        SchoolInfo.Hide()
        GenarateID.Hide()
        PrintID.Hide()
        TeacherData.Hide()
        StudentEnrollment.Hide()
        StudentSubject.Hide()
        StudentRequirements.Hide()
        StudentRegistered.Hide()
        AboutMe.Hide()
        LoginHistory.Hide()

        UserInfo.Dispose()
        SchoolInfo.Dispose()
        GenarateID.Dispose()
        PrintID.Dispose()
        TeacherData.Dispose()
        StudentEnrollment.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        AboutMe.Dispose()
        LoginHistory.Dispose()
        AboutMe.Dispose()
        CapturePicture.Dispose()
        ChangeInfo.Dispose()
        ChangePassword.Dispose()
        ForgotPassword.Dispose()
        GenarateID.Dispose()
        LoginGuide.Dispose()
        MainFormGuide.Dispose()
        PrintID.Dispose()
        RegistrarInfo.Dispose()
        SchoolInfo.Dispose()
        SelectStudents.Dispose()
        StudentEnrollment.Dispose()
        StudentEnrollmentGuide.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        TeacherDataGuide.Dispose()
        UserInfo.Dispose()

        Dim newmdichild As New EnrollmentData With {
            .MdiParent = Me
        }
        newmdichild.Show()

        OpenChildForm(New EnrollmentData())

    End Sub

    Private Sub BtnSchoolDatabase_Click(sender As Object, e As EventArgs) Handles btnSchoolDatabase.Click

        PictureBox1.Visible = False
        UserInfo.Hide()
        SchoolInfo.Hide()
        GenarateID.Hide()
        PrintID.Hide()
        TeacherData.Hide()
        StudentEnrollment.Hide()
        StudentSubject.Hide()
        StudentRequirements.Hide()
        StudentRegistered.Hide()
        AboutMe.Hide()
        LoginHistory.Hide()

        UserInfo.Dispose()
        SchoolInfo.Dispose()
        GenarateID.Dispose()
        PrintID.Dispose()
        TeacherData.Dispose()
        StudentEnrollment.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        AboutMe.Dispose()
        LoginHistory.Dispose()
        AboutMe.Dispose()
        CapturePicture.Dispose()
        ChangeInfo.Dispose()
        ChangePassword.Dispose()
        ForgotPassword.Dispose()
        GenarateID.Dispose()
        LoginGuide.Dispose()
        MainFormGuide.Dispose()
        PrintID.Dispose()
        RegistrarInfo.Dispose()
        SchoolInfo.Dispose()
        SelectStudents.Dispose()
        StudentEnrollment.Dispose()
        StudentEnrollmentGuide.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        TeacherDataGuide.Dispose()
        UserInfo.Dispose()

        Dim newmdichild As New SchoolInfo With {
            .MdiParent = Me
        }
        newmdichild.Show()

        OpenChildForm(New SchoolInfo())

    End Sub

    Private Sub BtnPrintID_Click(sender As Object, e As EventArgs) Handles btnPrintID.Click

        PictureBox1.Visible = False

        GenarateID.Show()

    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles EnrollmentDataMenuItem10.Click

        PictureBox1.Visible = False
        UserInfo.Hide()
        SchoolInfo.Hide()
        GenarateID.Hide()
        PrintID.Hide()
        TeacherData.Hide()
        StudentEnrollment.Hide()
        StudentSubject.Hide()
        StudentRequirements.Hide()
        StudentRegistered.Hide()
        AboutMe.Hide()
        LoginHistory.Hide()

        UserInfo.Dispose()
        SchoolInfo.Dispose()
        GenarateID.Dispose()
        PrintID.Dispose()
        TeacherData.Dispose()
        StudentEnrollment.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        AboutMe.Dispose()
        LoginHistory.Dispose()
        AboutMe.Dispose()
        CapturePicture.Dispose()
        ChangeInfo.Dispose()
        ChangePassword.Dispose()
        ForgotPassword.Dispose()
        GenarateID.Dispose()
        LoginGuide.Dispose()
        MainFormGuide.Dispose()
        PrintID.Dispose()
        RegistrarInfo.Dispose()
        SchoolInfo.Dispose()
        SelectStudents.Dispose()
        StudentEnrollment.Dispose()
        StudentEnrollmentGuide.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        TeacherDataGuide.Dispose()
        UserInfo.Dispose()

        Dim newmdichild As New EnrollmentData With {
            .MdiParent = Me
        }
        newmdichild.Show()

        OpenChildForm(New EnrollmentData())

    End Sub

    Private Sub DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeacherDataMenuItem.Click

        PictureBox1.Visible = False
        UserInfo.Hide()
        SchoolInfo.Hide()
        GenarateID.Hide()
        PrintID.Hide()
        TeacherData.Hide()
        StudentEnrollment.Hide()
        StudentSubject.Hide()
        StudentRequirements.Hide()
        StudentRegistered.Hide()
        AboutMe.Hide()
        LoginHistory.Hide()

        UserInfo.Dispose()
        SchoolInfo.Dispose()
        GenarateID.Dispose()
        PrintID.Dispose()
        TeacherData.Dispose()
        StudentEnrollment.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        AboutMe.Dispose()
        LoginHistory.Dispose()
        AboutMe.Dispose()
        CapturePicture.Dispose()
        ChangeInfo.Dispose()
        ChangePassword.Dispose()
        ForgotPassword.Dispose()
        GenarateID.Dispose()
        LoginGuide.Dispose()
        MainFormGuide.Dispose()
        PrintID.Dispose()
        RegistrarInfo.Dispose()
        SchoolInfo.Dispose()
        SelectStudents.Dispose()
        StudentEnrollment.Dispose()
        StudentEnrollmentGuide.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        TeacherDataGuide.Dispose()
        UserInfo.Dispose()

        Dim newmdichild As New TeacherData With {
            .MdiParent = Me
        }
        newmdichild.Show()

        OpenChildForm(New TeacherData())

    End Sub

    Private Sub EnrollmentPortalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EnrollmentPortalToolStripMenuItem1.Click

        PictureBox1.Visible = False

        StudentEnrollment.Show()

    End Sub

    Private Sub EnrollmentDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnrollmentDatabaseToolStripMenuItem.Click

        PictureBox1.Visible = False
        UserInfo.Hide()
        SchoolInfo.Hide()
        GenarateID.Hide()
        PrintID.Hide()
        TeacherData.Hide()
        StudentEnrollment.Hide()
        StudentSubject.Hide()
        StudentRequirements.Hide()
        StudentRegistered.Hide()
        AboutMe.Hide()
        LoginHistory.Hide()

        UserInfo.Dispose()
        SchoolInfo.Dispose()
        GenarateID.Dispose()
        PrintID.Dispose()
        TeacherData.Dispose()
        StudentEnrollment.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        AboutMe.Dispose()
        LoginHistory.Dispose()
        AboutMe.Dispose()
        CapturePicture.Dispose()
        ChangeInfo.Dispose()
        ChangePassword.Dispose()
        ForgotPassword.Dispose()
        GenarateID.Dispose()
        LoginGuide.Dispose()
        MainFormGuide.Dispose()
        PrintID.Dispose()
        RegistrarInfo.Dispose()
        SchoolInfo.Dispose()
        SelectStudents.Dispose()
        StudentEnrollment.Dispose()
        StudentEnrollmentGuide.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        TeacherDataGuide.Dispose()
        UserInfo.Dispose()

        Dim newmdichild As New EnrollmentData With {
            .MdiParent = Me
        }
        newmdichild.Show()

        OpenChildForm(New EnrollmentData())

    End Sub

    Private Sub TeacherDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeacherDatabaseToolStripMenuItem.Click

        PictureBox1.Visible = False
        UserInfo.Hide()
        SchoolInfo.Hide()
        GenarateID.Hide()
        PrintID.Hide()
        TeacherData.Hide()
        StudentEnrollment.Hide()
        StudentSubject.Hide()
        StudentRequirements.Hide()
        StudentRegistered.Hide()
        AboutMe.Hide()
        LoginHistory.Hide()

        UserInfo.Dispose()
        SchoolInfo.Dispose()
        GenarateID.Dispose()
        PrintID.Dispose()
        TeacherData.Dispose()
        StudentEnrollment.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        AboutMe.Dispose()
        LoginHistory.Dispose()
        AboutMe.Dispose()
        CapturePicture.Dispose()
        ChangeInfo.Dispose()
        ChangePassword.Dispose()
        ForgotPassword.Dispose()
        GenarateID.Dispose()
        LoginGuide.Dispose()
        MainFormGuide.Dispose()
        PrintID.Dispose()
        RegistrarInfo.Dispose()
        SchoolInfo.Dispose()
        SelectStudents.Dispose()
        StudentEnrollment.Dispose()
        StudentEnrollmentGuide.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        TeacherDataGuide.Dispose()
        UserInfo.Dispose()

        Dim newmdichild As New TeacherData With {
            .MdiParent = Me
        }
        newmdichild.Show()

        OpenChildForm(New TeacherData())

    End Sub

    Private Sub SchoolDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchoolDatabaseToolStripMenuItem.Click

        PictureBox1.Visible = False
        UserInfo.Hide()
        SchoolInfo.Hide()
        GenarateID.Hide()
        PrintID.Hide()
        TeacherData.Hide()
        StudentEnrollment.Hide()
        StudentSubject.Hide()
        StudentRequirements.Hide()
        StudentRegistered.Hide()
        AboutMe.Hide()
        LoginHistory.Hide()

        UserInfo.Dispose()
        SchoolInfo.Dispose()
        GenarateID.Dispose()
        PrintID.Dispose()
        TeacherData.Dispose()
        StudentEnrollment.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        AboutMe.Dispose()
        LoginHistory.Dispose()
        AboutMe.Dispose()
        CapturePicture.Dispose()
        ChangeInfo.Dispose()
        ChangePassword.Dispose()
        ForgotPassword.Dispose()
        GenarateID.Dispose()
        LoginGuide.Dispose()
        MainFormGuide.Dispose()
        PrintID.Dispose()
        RegistrarInfo.Dispose()
        SchoolInfo.Dispose()
        SelectStudents.Dispose()
        StudentEnrollment.Dispose()
        StudentEnrollmentGuide.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        TeacherDataGuide.Dispose()
        UserInfo.Dispose()

        Dim newmdichild As New SchoolInfo With {
            .MdiParent = Me
        }
        newmdichild.Show()

        OpenChildForm(New SchoolInfo())

    End Sub

    Private Sub BtnAboutMe_Click(sender As Object, e As EventArgs) Handles btnAboutMe.Click

        PictureBox1.Visible = False
        UserInfo.Hide()
        SchoolInfo.Hide()
        GenarateID.Hide()
        PrintID.Hide()
        TeacherData.Hide()
        StudentEnrollment.Hide()
        StudentSubject.Hide()
        StudentRequirements.Hide()
        StudentRegistered.Hide()
        AboutMe.Hide()
        LoginHistory.Hide()

        UserInfo.Dispose()
        SchoolInfo.Dispose()
        GenarateID.Dispose()
        PrintID.Dispose()
        TeacherData.Dispose()
        StudentEnrollment.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        AboutMe.Dispose()
        LoginHistory.Dispose()
        AboutMe.Dispose()
        CapturePicture.Dispose()
        ChangeInfo.Dispose()
        ChangePassword.Dispose()
        ForgotPassword.Dispose()
        GenarateID.Dispose()
        LoginGuide.Dispose()
        MainFormGuide.Dispose()
        PrintID.Dispose()
        RegistrarInfo.Dispose()
        SchoolInfo.Dispose()
        SelectStudents.Dispose()
        StudentEnrollment.Dispose()
        StudentEnrollmentGuide.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        TeacherDataGuide.Dispose()
        UserInfo.Dispose()

        Dim newmdichild As New AboutMe With {
            .MdiParent = Me
        }
        newmdichild.Show()

        OpenChildForm(New AboutMe())

    End Sub

    Private Sub BtnLoginHistory_Click(sender As Object, e As EventArgs) Handles btnLoginHistory.Click

        PictureBox1.Visible = False
        UserInfo.Hide()
        SchoolInfo.Hide()
        GenarateID.Hide()
        PrintID.Hide()
        TeacherData.Hide()
        StudentEnrollment.Hide()
        StudentSubject.Hide()
        StudentRequirements.Hide()
        StudentRegistered.Hide()
        AboutMe.Hide()
        LoginHistory.Hide()

        UserInfo.Dispose()
        SchoolInfo.Dispose()
        GenarateID.Dispose()
        PrintID.Dispose()
        TeacherData.Dispose()
        StudentEnrollment.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        AboutMe.Dispose()
        LoginHistory.Dispose()
        AboutMe.Dispose()
        CapturePicture.Dispose()
        ChangeInfo.Dispose()
        ChangePassword.Dispose()
        ForgotPassword.Dispose()
        GenarateID.Dispose()
        LoginGuide.Dispose()
        MainFormGuide.Dispose()
        PrintID.Dispose()
        RegistrarInfo.Dispose()
        SchoolInfo.Dispose()
        SelectStudents.Dispose()
        StudentEnrollment.Dispose()
        StudentEnrollmentGuide.Dispose()
        StudentSubject.Dispose()
        StudentRequirements.Dispose()
        StudentRegistered.Dispose()
        TeacherDataGuide.Dispose()
        UserInfo.Dispose()

        Dim newmdichild As New LoginHistory With {
            .MdiParent = Me
        }
        newmdichild.Show()

        OpenChildForm(New LoginHistory())

    End Sub

    Private Sub PrintIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintIDToolStripMenuItem.Click

        PictureBox1.Visible = False

        GenarateID.Show()

    End Sub

    Private Sub EnrollmentPortalToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EnrollmentPortalToolStripMenuItem2.Click

        PictureBox1.Visible = False

        StudentEnrollment.Show()

    End Sub

    Private Sub EnrollmentPortalToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles EnrollmentPortalToolStripMenuItem3.Click

        PictureBox1.Visible = False

        StudentEnrollment.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        PictureBox1.Visible = False

        MainFormGuide.Show()

    End Sub

End Class