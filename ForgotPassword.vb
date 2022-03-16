Imports System.Data.OleDb
Imports System.Text

Public Class ForgotPassword

    Private Sub RoundButtonCheck(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnCheck.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnCheck.Region = New Region(Raduis)

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


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub FrmForgetPass_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dispose()

        LoginForm.Show()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        Dispose()

        LoginForm.Show()

    End Sub
    Sub Clear()

        txtUserName.Clear()
        dtpDOB.Value = Today
        txtPOB.Clear()
        txtUserID.Clear()

    End Sub
    Private Function RequiredEntry() As Boolean

        If txtUserName.Text = "" Or txtPOB.Text = "" Or txtUserID.Text = "" Then

            MsgBox("Please enter all information", MsgBoxStyle.Critical, "Attention")

            Return True

            Exit Function

        End If

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        If RequiredEntry() = True Then Return

        Try

            If LoginForm.cmbFormState.Text = "Teacher" Then

                Dim TeacherConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

                If TeacherConnection.State = ConnectionState.Open Then TeacherConnection.Close()
                TeacherConnection.Open()

                Dim TeacherDataReader As OleDbDataReader
                Dim TeacherCommand As New OleDbCommand With {
                    .CommandText = "select [TeacherID],[Username],[DateOfBirth],[PlaceOfBirth],[Password] from TeacherInfo where TeacherID = '" & txtUserID.Text & "'",
                    .Connection = TeacherConnection
                }

                If TeacherConnection.State = ConnectionState.Closed Then TeacherConnection.Open()
                TeacherDataReader = TeacherCommand.ExecuteReader

                If TeacherDataReader.Read Then

                    If UCase(TeacherDataReader(1)) = UCase(txtUserName.Text) And UCase(TeacherDataReader(2)) = UCase(dtpDOB.Text) And UCase(TeacherDataReader(3)) = UCase(txtPOB.Text) Then

                        MessageBox.Show("Your password is  .:{ '" & Decrypt(TeacherDataReader(4).ToString()) & "' ]:. ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LinkLabel2.Visible = True
                        TeacherConnection.Close()

                    Else

                        MessageBox.Show("Incorect input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TeacherConnection.Close()

                    End If

                Else

                    MessageBox.Show("UserID is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TeacherConnection.Close()

                End If

            End If

            If LoginForm.cmbFormState.Text = "Admin" Then

                Dim AdminConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

                Dim AdminDataReader As OleDbDataReader
                Dim AdminCommand As New OleDbCommand

                If AdminConnection.State = ConnectionState.Open Then AdminConnection.Close()
                AdminConnection.Open()

                AdminCommand.CommandText = "select [AdminID],[Username],[DateOfBirth],[PlaceOfBirth],[Password] from AdminInfo where AdminID = '" & txtUserID.Text & "'"
                AdminCommand.Connection = AdminConnection
                AdminDataReader = AdminCommand.ExecuteReader

                If AdminDataReader.Read Then

                    If UCase(AdminDataReader("Username")) = UCase(txtUserName.Text) And UCase(AdminDataReader("DateOfBirth")) = UCase(dtpDOB.Text) And UCase(AdminDataReader("PlaceOfBirth")) = UCase(txtPOB.Text) Then

                        MessageBox.Show("Your password is  .:{ '" & Decrypt(AdminDataReader(4).ToString()) & "' }:. ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LinkLabel2.Visible = True
                        AdminConnection.Close()

                    Else

                        MessageBox.Show("Incorect input!!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        AdminConnection.Close()

                    End If

                Else

                    MessageBox.Show("UserID is wrong!!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    AdminConnection.Close()

                End If

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message.ToString(), "Data Error")
            Exit Sub

        End Try

    End Sub

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

    Private Sub FrmForgetPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RoundButtonCheck(btnCheck)
        RoundButtonClear(btnClear)
        RoundButtonClose(btnClose)

        dtpDOB.Value = Today

    End Sub

End Class