Imports System.Data.OleDb
Imports System.Text

Public Class ChangePassword

    Private Sub RoundButtonUpdate(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnUpdate.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnUpdate.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonClear(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnClear.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnClear.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonClose(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnClose.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnClose.Region = New Region(Raduis)

    End Sub

    'Encryption
    Public Function Encrypt(Encryption As String) As String

        Dim encode As Byte() = New Byte(Encryption.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(Encryption)
        Dim msg As String = Convert.ToBase64String(encode)
        Return msg

    End Function

    Private Function RequiredEntry() As Boolean

        If txtOldPass.Text = "" Or TxtNewPass.Text = "" Or txtConformPass.Text = "" Then

            MsgBox("Please enter all information....", MsgBoxStyle.Critical, "Attention...")

            txtOldPass.Focus()

            Return True

            Exit Function

        End If

    End Function

    Private Sub CmdClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtOldPass.Clear()
        TxtNewPass.Clear()
        txtConformPass.Clear()
        txtOldPass.Focus()

    End Sub

    Private Sub CmdEdit_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If RequiredEntry() = True Then Return

        Try

            Dim okcancel As Integer = MessageBox.Show("Do you really want to update this record?", "Change Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If okcancel = vbCancel Then

                Return

            Else

                Dim SelectConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

                Dim SelectDataReader As OleDbDataReader
                Dim SelectCommand As New OleDbCommand

                If LoginForm.cmbFormState.Text = "Teacher" Then

                    If SelectConnection.State = ConnectionState.Open Then SelectConnection.Close()
                    SelectConnection.Open()

                    SelectCommand.CommandText = "SELECT [TeacherID],[Password] FROM TeacherInfo WHERE TeacherID = '" & LoginForm.txtTeacherUsername.Text & "'"
                    SelectCommand.Connection = SelectConnection
                    SelectDataReader = SelectCommand.ExecuteReader

                    If SelectDataReader.Read Then

                        If SelectDataReader("Password") = Encrypt(txtOldPass.Text) Then

                            If TxtNewPass.Text = txtConformPass.Text Then

                                Try

                                    Dim UpdateConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

                                    ' Teacher Data Update
                                    If UpdateConnection.State = ConnectionState.Open Then UpdateConnection.Close()
                                    UpdateConnection.Open()

                                    Dim TeacherCommand As New OleDbCommand("Update TeacherInfo Set [Password]=@Password Where (TeacherID='" & SelectDataReader("TeacherID") & "')", UpdateConnection)

                                    ' Password
                                    Dim Password As New OleDbParameter("@Password", OleDbType.VarWChar, 200) With {
                                        .Value = Encrypt(TxtNewPass.Text).ToString
                                    }
                                    TeacherCommand.Parameters.Add(Password)

                                    If TeacherCommand.ExecuteNonQuery() Then

                                        UpdateConnection.Close()

                                        MsgBox("Your password update successfully...", MsgBoxStyle.Information, "Password Updated")

                                        btnClear.PerformClick()

                                        MainForm.Dispose()

                                        Close()

                                    Else

                                        MsgBox("Password updation failed ", MsgBoxStyle.Critical, "Updation Failed")
                                        Return

                                    End If

                                Catch ex As Exception

                                    MessageBox.Show(ex.Message.ToString(), "Password 'UPDATE' error")
                                    Exit Sub

                                End Try

                            Else

                                MessageBox.Show("Password & conform password does not match", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            End If

                        Else

                            MsgBox("Old password is Wrong!!!", MsgBoxStyle.Critical, "Password Wrong")

                        End If

                    End If

                    Return

                End If

                If LoginForm.cmbFormState.Text = "Admin" Then

                    If SelectConnection.State = ConnectionState.Open Then SelectConnection.Close()
                    SelectConnection.Open()

                    SelectCommand.CommandText = "SELECT [AdminID],[Password] FROM AdminInfo WHERE AdminID = '" & LoginForm.txtAdminUsername.Text & "'"
                    SelectCommand.Connection = SelectConnection
                    SelectDataReader = SelectCommand.ExecuteReader

                    If SelectDataReader.Read Then

                        If SelectDataReader("Password") = Encrypt(txtOldPass.Text) Then

                            If TxtNewPass.Text = txtConformPass.Text Then

                                Try

                                    Dim UpdateConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

                                    ' Admin Data Update
                                    If UpdateConnection.State = ConnectionState.Open Then UpdateConnection.Close()
                                    UpdateConnection.Open()

                                    Dim TeacherCommand As New OleDbCommand("Update AdminInfo Set [Password]=@Password Where (AdminID    ='" & SelectDataReader("AdminID") & "')", UpdateConnection)

                                    ' Password
                                    Dim Password As New OleDbParameter("@Password", OleDbType.VarWChar, 200) With {
                                        .Value = Encrypt(TxtNewPass.Text).ToString
                                    }
                                    TeacherCommand.Parameters.Add(Password)

                                    If TeacherCommand.ExecuteNonQuery() Then

                                        UpdateConnection.Close()

                                        MsgBox("Your password update successfully...", MsgBoxStyle.Information, "Password Updated")

                                        btnClear.PerformClick()

                                        MainForm.Dispose()

                                        Close()

                                    Else

                                        MsgBox("Password updation failed ", MsgBoxStyle.Critical, "Updation Failed")
                                        Return

                                    End If


                                Catch ex As Exception

                                    MessageBox.Show(ex.Message.ToString(), "Password 'UPDATE' error")
                                    Exit Sub

                                End Try

                            Else

                                MessageBox.Show("Password & Conform password does not match", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            End If

                        Else

                            MsgBox("Old password is Wrong!!!", MsgBoxStyle.Critical, "Password Wrong")
                            Return

                        End If

                    End If

                    Return

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error Changing Password")
            Exit Sub

        End Try

    End Sub

    Private Sub ChangePassword_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        MainForm.Dispose()

        Dim User As New MainForm
        Hide()
        User.Show()

    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub TxtNewPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNewPass.KeyPress

        Dim NotAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"

        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then

            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtOldPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOldPass.KeyPress

        Dim NotAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"

        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then

            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtConformPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConformPass.KeyPress

        Dim NotAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"

        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then

            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnClear.PerformClick()

        txtOldPass.Focus()

        RoundButtonUpdate(btnUpdate)
        RoundButtonClear(btnClear)
        RoundButtonClose(btnClose)

    End Sub

End Class