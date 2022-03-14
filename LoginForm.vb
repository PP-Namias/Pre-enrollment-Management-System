Imports System.Data.OleDb
Imports System.Text

Public Class LoginForm

    Dim cmd As OleDbCommand = Nothing

    Private Sub RoundCorners(obj As Form)

        obj.FormBorderStyle = FormBorderStyle.None

        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()

        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)


    End Sub

    'Admin, Registrar, and Supervisors
    Private Sub BtnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click

        If Len(Trim(txtAdminUsername.Text)) = 0 Then

            MessageBox.Show("Please enter username", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAdminUsername.Focus()
            Exit Sub

        End If

        If Len(Trim(txtAdminPassword.Text)) = 0 Then

            MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAdminPassword.Focus()
            Exit Sub

        End If

        Try

            Dim AdminConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

            If AdminConnection.State = ConnectionState.Open Then AdminConnection.Close()
            AdminConnection.Open()

            Dim AdminDataReader As OleDbDataReader
            Dim AdminCommand As New OleDbCommand With {
                .CommandText = "SELECT [AdminID],[Password] FROM AdminInfo WHERE AdminID = @AdminID"
            }

            ' UserName
            Dim AdminUsername As New OleDbParameter("@AdminID", OleDbType.VarWChar, 45) With {
                .Value = txtAdminUsername.Text.ToString()
            }
            AdminCommand.Parameters.Add(AdminUsername)

            AdminCommand.Connection = AdminConnection

            AdminDataReader = AdminCommand.ExecuteReader

            If AdminDataReader.Read Then

                If Not AdminDataReader("Password") = Encrypt(txtAdminPassword.Text) Then

                    MessageBox.Show("Password is wrong", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    AdminConnection.Close()

                    AdminForgetPassword.Visible = True

                    AdminForgetPassword.Text = "Forget Password"

                    txtAdminPassword.Focus()

                    Return

                Else

                    Try

                        AdminConnection.Close()

                        Dim NameConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")
                        Dim NameDataReader As OleDbDataReader
                        Dim NameCommand As New OleDbCommand

                        If NameConnection.State = ConnectionState.Open Then NameConnection.Close()
                        NameConnection.Open()

                        NameCommand.CommandText = "SELECT [UserName],[Status] FROM AdminInfo WHERE AdminID = '" & txtAdminUsername.Text & "'"
                        NameCommand.Connection = NameConnection
                        NameDataReader = NameCommand.ExecuteReader

                        If NameDataReader.Read Then

                            txtUsername.Text = NameDataReader("UserName").ToString
                            txtPosition.Text = NameDataReader("Status").ToString

                            AdminConnection.Close()

                            Try

                                dtpLoginDate.Value = Now
                                txtTimeIn.Text = Format(Now, "h:mm:ss tt")

                                Dim LogConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

                                If LogConnection.State = ConnectionState.Open Then LogConnection.Close()
                                LogConnection.Open()

                                Dim LogString As String = "INSERT INTO LogHistory ([Username],[Position],[LoginDate],[TimeIn],[TimeOut],[Remark]) VALUES ('" & txtUsername.Text.ToString() & "', '" & txtPosition.Text.ToString() & "', #" & dtpLoginDate.Text.ToString() & "# ,#" & txtTimeIn.Text.ToString() & "#, ' ', '" & txtRemark.Text.ToString() & "')"
                                Dim LogCommand As New OleDbCommand(LogString, LogConnection)

                                If LogCommand.ExecuteNonQuery() Then

                                    LogConnection.Close()

                                    cmbFormState.Text = "Admin"

                                    Dim obj As New MainForm
                                    Hide()
                                    obj.Show()

                                Else

                                    MsgBox("Log History Insert failed", MsgBoxStyle.Critical, "Log History failed")
                                    Return

                                End If

                            Catch ex As Exception

                                MessageBox.Show(ex.Message, "Error Admin Log History", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub

                            End Try

                        End If

                        NameConnection.Close()
                        NameDataReader.Close()

                        Return

                    Catch ex As Exception

                        MessageBox.Show(ex.Message.ToString(), "Load data error")
                        Exit Sub

                    End Try

                End If

            Else

                MessageBox.Show("Username is wrong", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                AdminConnection.Close()

                txtAdminUsername.Focus()

                Return

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error Admin Login Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End Try

    End Sub

    'Teachers
    Private Sub BtnTeacherLogin_Click(sender As Object, e As EventArgs) Handles btnTeacherLogin.Click

        If Len(Trim(txtTeacherUsername.Text)) = 0 Then

            MessageBox.Show("Please enter username", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTeacherUsername.Focus()
            Exit Sub

        End If

        If Len(Trim(txtTeacherPassword.Text)) = 0 Then

            MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTeacherPassword.Focus()
            Exit Sub

        End If

        Try

            Dim TeacherConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

            If TeacherConnection.State = ConnectionState.Open Then TeacherConnection.Close()
            TeacherConnection.Open()

            Dim TeacherDataReader As OleDbDataReader
            Dim TeacherCommand As New OleDbCommand With {
                .CommandText = "SELECT [TeacherID],[Password] FROM TeacherInfo WHERE TeacherID = @TeacherID"
            }

            ' Username
            Dim TeacherUsername As New OleDbParameter("@TeacherID", OleDbType.VarWChar, 45) With {
                .Value = txtTeacherUsername.Text.ToString()
            }
            TeacherCommand.Parameters.Add(TeacherUsername)

            TeacherCommand.Connection = TeacherConnection

            TeacherDataReader = TeacherCommand.ExecuteReader

            If TeacherDataReader.Read Then

                If Not TeacherDataReader("Password") = Encrypt(txtTeacherPassword.Text) Then

                    MessageBox.Show("Password is wrong", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    TeacherConnection.Close()

                    TeacherForgetPassword.Visible = True

                    TeacherForgetPassword.Text = "Forget Password"

                    txtTeacherPassword.Focus()

                    Return

                Else

                    Try

                        Dim NameConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")
                        Dim NameDataReader As OleDbDataReader
                        Dim NameCommand As New OleDbCommand

                        If NameConnection.State = ConnectionState.Open Then NameConnection.Close()
                        NameConnection.Open()

                        NameCommand.CommandText = "SELECT [UserName] FROM TeacherInfo WHERE TeacherID = '" & txtTeacherUsername.Text & "'"
                        NameCommand.Connection = NameConnection
                        NameDataReader = NameCommand.ExecuteReader

                        If NameDataReader.Read Then

                            txtUsername.Text = NameDataReader("UserName")
                            txtPosition.Text = "Teacher"

                            Try

                                dtpLoginDate.Value = Now
                                txtTimeIn.Text = Format(Now, "h:mm:ss tt")

                                Dim LogConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

                                If LogConnection.State = ConnectionState.Open Then LogConnection.Close()
                                LogConnection.Open()

                                Dim LogString As String = "INSERT INTO LogHistory ([Username],[Position],[LoginDate],[TimeIn],[TimeOut],[Remark]) VALUES ('" & txtUsername.Text.ToString() & "', '" & txtPosition.Text.ToString() & "', #" & dtpLoginDate.Text.ToString() & "# ,#" & txtTimeIn.Text.ToString() & "#, ' ', '" & txtRemark.Text.ToString() & "')"
                                Dim LogCommand As New OleDbCommand(LogString, LogConnection)

                                If LogCommand.ExecuteNonQuery() Then

                                    LogConnection.Close()

                                    cmbFormState.Text = "Teacher"

                                    Dim main As New MainForm
                                    Hide()
                                    main.Show()

                                Else

                                    MsgBox("Log History Insert failed", MsgBoxStyle.Critical, "Log History failed")
                                    Return

                                End If

                            Catch ex As Exception

                                MessageBox.Show(ex.Message, "Error Teacher Log History", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub

                            End Try

                        End If

                        NameConnection.Close()
                        NameDataReader.Close()

                        Return

                    Catch ex As Exception

                        MessageBox.Show(ex.Message.ToString(), "Load data error")
                        Exit Sub

                    End Try

                End If

            Else

                MessageBox.Show("Username is wrong", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                TeacherConnection.Close()

                txtTeacherUsername.Focus()

                Return

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error Teacher Login Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End Try

    End Sub

    'Guest
    Private Sub BtnEnterAsGuest_Click(sender As Object, e As EventArgs) Handles btnEnterAsGuest.Click

        txtUsername.Text = "Guest"
        txtPosition.Text = "Guest"

        Try

            dtpLoginDate.Value = Now
            txtTimeIn.Text = Format(Now, "h:mm:ss tt")

            Dim LogConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

            If LogConnection.State = ConnectionState.Open Then LogConnection.Close()
            LogConnection.Open()

            Dim LogString As String = "INSERT INTO LogHistory ([Username],[Position],[LoginDate],[TimeIn],[TimeOut],[Remark]) VALUES ('" & txtUsername.Text.ToString() & "', '" & txtPosition.Text.ToString() & "', #" & dtpLoginDate.Text.ToString() & "# ,#" & txtTimeIn.Text.ToString() & "#, ' ', '" & txtRemark.Text.ToString() & "')"
            Dim LogCommand As New OleDbCommand(LogString, LogConnection)

            If LogCommand.ExecuteNonQuery() Then

                LogConnection.Close()

                cmbFormState.Text = "Guest"

                Dim Guest As New MainForm
                Hide()
                Guest.Show()

            Else

                MsgBox("Log History Insert failed", MsgBoxStyle.Critical, "Log History failed")
                Return

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error Guest Log History", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End Try

    End Sub

    'Admin Cancel
    Private Sub BtnAdminCancel_Click(sender As Object, e As EventArgs) Handles btnAdminCancel.Click

        End

    End Sub

    'Teacher Cancel
    Private Sub BtnTeacherCancel_Click(sender As Object, e As EventArgs) Handles btnTeacherCancel.Click

        End

    End Sub

    'Admin Forget Password
    Private Sub AdminForgetPassword_Click(sender As Object, e As EventArgs) Handles AdminForgetPassword.Click

        Hide()

        txtAdminUsername.Text = ""
        txtAdminPassword.Text = ""
        txtTeacherUsername.Text = ""
        txtTeacherPassword.Text = ""

        AdminForgetPassword.Visible = False
        TeacherForgetPassword.Visible = False

        cmbFormState.Text = "Admin"

        ForgotPassword.Show()

    End Sub

    'Teacher Forget Password
    Private Sub TeacherForgetPassword_Click(sender As Object, e As EventArgs) Handles TeacherForgetPassword.Click

        Hide()

        txtAdminUsername.Text = ""
        txtAdminPassword.Text = ""
        txtTeacherUsername.Text = ""
        txtTeacherPassword.Text = ""

        AdminForgetPassword.Visible = False
        TeacherForgetPassword.Visible = False

        cmbFormState.Text = "Teacher"

        ForgotPassword.Show()

    End Sub

    Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        End

    End Sub

    Private Sub TxtAdminUserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdminUsername.KeyPress

        'Allowed letters numbers and ( _ $ *)
        If e.KeyChar <> ControlChars.Back = True Then

            If "~`@%^&+={[}]()!:,;'><?/|\-.#+".IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtAdminPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdminPassword.KeyPress

        'Allowed letters numbers and ( _ $ *)
        If e.KeyChar <> ControlChars.Back = True Then

            If "~`@%^&+={[}]()!:,;'><?/|\-.#+".IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtTeacherUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTeacherUsername.KeyPress

        'Allowed letters numbers and ( _ $ *)
        If e.KeyChar <> ControlChars.Back = True Then

            If "~`@%^&+={[}]()!:,;'><?/|\-.#+".IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtTeacherPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTeacherPassword.KeyPress

        'Allowed letters numbers and ( _ $ *)
        If e.KeyChar <> ControlChars.Back = True Then

            If "~`@%^&+={[}]()!:,;'><?/|\-.#+".IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click

        txtAdminUsername.Text = ""
        txtAdminPassword.Text = ""
        txtTeacherUsername.Text = ""
        txtTeacherPassword.Text = ""

    End Sub

    Private Sub RoundButtonGuest(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 18)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnEnterAsGuest.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnEnterAsGuest.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonAdminLogin(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 14)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnAdminLogin.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnAdminLogin.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonAdminCancel(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 14)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnAdminCancel.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnAdminCancel.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonTeacherLogin(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 14)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnTeacherLogin.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnTeacherLogin.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonTeacherCancel(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 14)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnTeacherCancel.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnTeacherCancel.Region = New Region(Raduis)

    End Sub
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtTimeIn.Text = Format(Now, "h:mm:ss tt")

        RoundCorners(Me)

        RoundButtonAdminLogin(btnAdminLogin)
        RoundButtonAdminCancel(btnAdminCancel)
        RoundButtonTeacherLogin(btnTeacherLogin)
        RoundButtonTeacherCancel(btnTeacherCancel)
        RoundButtonGuest(btnEnterAsGuest)

    End Sub

    Private Sub PicHelp1_Click(sender As Object, e As EventArgs) Handles picHelp1.Click

        LoginGuide.Show()

        picHelp1.Visible = False
        picHelp2.Visible = False
        picHelp3.Visible = False

    End Sub

    Private Sub PicHelp2_Click(sender As Object, e As EventArgs) Handles picHelp2.Click

        LoginGuide.Show()

        picHelp1.Visible = False
        picHelp2.Visible = False
        picHelp3.Visible = False

    End Sub

    Private Sub PicHelp3_Click(sender As Object, e As EventArgs) Handles picHelp3.Click

        LoginGuide.Show()

        picHelp1.Visible = False
        picHelp2.Visible = False
        picHelp3.Visible = False

    End Sub

    'Encryption
    Public Function Encrypt(Encryption As String) As String

        Dim encode As Byte() = New Byte(Encryption.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(Encryption)
        Dim msg As String = Convert.ToBase64String(encode)
        Return msg

    End Function

    'Decryption
    Public Function Decrypt(Decryption As String) As String

        Dim encodedtext As New UTF8Encoding
        Dim decode As Decoder = encodedtext.GetDecoder
        Dim code_byte As Byte() = Convert.FromBase64String(Decryption)
        Dim charcount As Integer = decode.GetCharCount(code_byte, 0, code_byte.Length)
        Dim decode_char As Char() = New Char(charcount - 1) {}
        decode.GetChars(code_byte, 0, code_byte.Length, decode_char, 0)
        Dim decryptext As New String(decode_char)
        Return decryptext

    End Function

End Class