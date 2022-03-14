Imports System.Data.OleDb
Imports System.IO

Public Class ChangeInfo

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

    Private Sub RoundButtonCapture(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnCapture.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnCapture.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonBrowse(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnBrowse.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnBrowse.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonRemove(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnRemove.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnRemove.Region = New Region(Raduis)

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        MainForm.Dispose()

        Dim User As New MainForm
        Hide()
        User.Show()

    End Sub

    Private Sub ChangeInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        MainForm.Dispose()

        Dim User As New MainForm
        Hide()
        User.Show()

    End Sub

    Private Function RequiredEntry() As Boolean

        If txtUserName.Text = "" Or txtPOB.Text = "" Or txtEmailID.Text = "" Then

            MsgBox("Please enter all information....", MsgBoxStyle.Critical, "Attention")

            Return True

            Exit Function

        End If

    End Function

    Private Sub ChangeInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RoundButtonUpdate(btnUpdate)
        RoundButtonClear(btnClear)
        RoundButtonClose(btnClose)
        RoundButtonCapture(btnCapture)
        RoundButtonBrowse(btnBrowse)
        RoundButtonRemove(btnRemove)

        Try
            Dim LoadConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

            Dim LoadDataReader As OleDbDataReader
            Dim LoadCommand As New OleDbCommand

            If LoginForm.cmbFormState.Text = "Teacher" Then

                If LoadConnection.State = ConnectionState.Open Then LoadConnection.Close()
                LoadConnection.Open()

                LoadCommand.CommandText = "select [TeacherID],[Username],[DateOfBirth],[PlaceOfBirth],[EmailID],[TeacherPic] from TeacherInfo where TeacherID = '" & LoginForm.txtTeacherUsername.Text & "'"
                LoadCommand.Connection = LoadConnection

                LoadDataReader = LoadCommand.ExecuteReader

                If LoadDataReader.Read Then

                    txtUserName.Text = LoadDataReader(1).ToString()
                    dtpDOB.Text = LoadDataReader(2).ToString()
                    txtPOB.Text = LoadDataReader(3).ToString()
                    txtEmailID.Text = LCase(LoadDataReader(4)).ToString()

                    Dim bytTeacher As Byte() = LoadDataReader("TeacherPic")
                    Dim msTeacher As New MemoryStream(bytTeacher)
                    IDPicture.Image = Image.FromStream(msTeacher)

                End If

                LoadConnection.Close()

                Return

            End If

            If LoginForm.cmbFormState.Text = "Admin" Then

                If LoadConnection.State = ConnectionState.Open Then LoadConnection.Close()
                LoadConnection.Open()

                LoadCommand.CommandText = "select [AdminID],[Username],[DateOfBirth],[PlaceOfBirth],[EmailID],[AdminPic] from AdminInfo where AdminID = '" & LoginForm.txtAdminUsername.Text & "'"
                LoadCommand.Connection = LoadConnection

                LoadDataReader = LoadCommand.ExecuteReader

                If LoadDataReader.Read Then

                    txtUserName.Text = LoadDataReader(1).ToString()
                    dtpDOB.Text = LoadDataReader(2).ToString()
                    txtPOB.Text = LoadDataReader(3).ToString()
                    txtEmailID.Text = LCase(LoadDataReader(4)).ToString()

                    Dim bytAdmin As Byte() = LoadDataReader("AdminPic")
                    Dim msAdmin As New MemoryStream(bytAdmin)
                    IDPicture.Image = Image.FromStream(msAdmin)

                End If

                LoadConnection.Close()

                Return

            End If

        Catch ex As Exception

            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
            Exit Try

        End Try

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtUserName.Clear()
        dtpDOB.Value = Today
        txtPOB.Clear()
        txtEmailID.Clear()
        IDPicture.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Image\personal.PNG")

    End Sub



    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If RequiredEntry() = True Then Return

        Try

            Dim UpdateConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

            'Teacher Data Update
            If LoginForm.cmbFormState.Text = "Teacher" Then

                If UpdateConnection.State = ConnectionState.Open Then UpdateConnection.Close()
                UpdateConnection.Open()

                Dim TeacherCommand As New OleDbCommand("Update TeacherInfo Set Username=@UName,DateOfBirth=@DOB,PlaceOfBirth=@POB,EmailID=@EmailID,TeacherPic=@Pic Where (TeacherID='" & LoginForm.txtTeacherUsername.Text & "')", UpdateConnection)

                ' User name
                Dim UserName As New OleDbParameter("@UName", OleDbType.VarWChar, 100) With {
                    .Value = txtUserName.Text.ToString()
                }
                TeacherCommand.Parameters.Add(UserName)

                'Date of Birth
                Dim DOB As New OleDbParameter("@DOB", OleDbType.Date, 25) With {
                    .Value = dtpDOB.Text.ToString()
                }
                TeacherCommand.Parameters.Add(DOB)

                'Place of Birth
                Dim POB As New OleDbParameter("@POB", OleDbType.VarWChar, 100) With {
                    .Value = txtPOB.Text.ToString()
                }
                TeacherCommand.Parameters.Add(POB)

                'Email ID
                Dim EmailID As New OleDbParameter("@EmailID", OleDbType.VarWChar, 100) With {
                    .Value = txtEmailID.Text.ToString()
                }
                TeacherCommand.Parameters.Add(EmailID)

                Dim TeacherMemStream As New MemoryStream
                Dim TeacherDataPic_Update As Byte()

                IDPicture.Image.Save(TeacherMemStream, Imaging.ImageFormat.Png)
                TeacherDataPic_Update = TeacherMemStream.GetBuffer()
                TeacherMemStream.Read(TeacherDataPic_Update, 0, TeacherMemStream.Length)

                ' Teacher ID Picture
                Dim TeacherPicture As New OleDbParameter("@Pic", SqlDbType.Image) With {
                    .Value = TeacherDataPic_Update
                }
                TeacherCommand.Parameters.Add(TeacherPicture)


                If TeacherCommand.ExecuteNonQuery() Then

                    UpdateConnection.Close()
                    MsgBox("Your data updated successfully.", MsgBoxStyle.Information, "Data Updated")
                    MainForm.Dispose()
                    Close()

                Else

                    MsgBox("Your data update failed.", MsgBoxStyle.Critical, "Update Failed")
                    Return

                End If

            End If

            'Admin Data Update
            If LoginForm.cmbFormState.Text = "Admin" Then

                If UpdateConnection.State = ConnectionState.Open Then UpdateConnection.Close()
                UpdateConnection.Open()

                Dim AdminCommand As New OleDbCommand("Update AdminInfo Set Username=@UserName,DateOfBirth=@DOB,PlaceOfBirth=@POB,EmailID=@EmailID,AdminPic=@Pic Where (AdminID='" & LoginForm.txtAdminUsername.Text & "') ", UpdateConnection)

                ' Admin name
                Dim AdminName As New OleDbParameter("@AdminName", OleDbType.VarWChar, 100) With {
                    .Value = txtUserName.Text.ToString()
                }
                AdminCommand.Parameters.Add(AdminName)

                ' Date of Birth
                Dim DOB As New OleDbParameter("@DOB", OleDbType.Date, 100) With {
                    .Value = dtpDOB.Text.ToString()
                }
                AdminCommand.Parameters.Add(DOB)

                ' Place of Birth
                Dim POB As New OleDbParameter("@POB", OleDbType.VarWChar, 100) With {
                    .Value = txtPOB.Text.ToString()
                }
                AdminCommand.Parameters.Add(POB)

                ' Email ID
                Dim EmailID As New OleDbParameter("@EmailID", OleDbType.VarWChar, 100) With {
                    .Value = txtEmailID.Text.ToString()
                }
                AdminCommand.Parameters.Add(EmailID)


                Dim AdminMemStream As New MemoryStream
                Dim AdminDataPic_Update As Byte()

                IDPicture.Image.Save(AdminMemStream, Imaging.ImageFormat.Png)
                AdminDataPic_Update = AdminMemStream.GetBuffer()
                AdminMemStream.Read(AdminDataPic_Update, 0, AdminMemStream.Length)

                ' Admin ID Picture
                Dim AdminPicture As New OleDbParameter("@Pic", SqlDbType.Image) With {
                    .Value = AdminDataPic_Update
                }
                AdminCommand.Parameters.Add(AdminPicture)


                If AdminCommand.ExecuteNonQuery() Then

                    UpdateConnection.Close()

                    MsgBox("Your data updated successfully.", MsgBoxStyle.Information, "Data Updated")

                    MainForm.Dispose()

                    Close()

                Else

                    MsgBox("Your data update failed.", MsgBoxStyle.Critical, "Update Failed")
                    Return

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
            Exit Sub

        End Try

    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        IDPicture.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Image\personal.PNG")

    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim OpenFile As New OpenFileDialog()

        Try

            With OpenFile

                .FileName = ""
                .Title = "Photo:"
                .Filter = "Image files: (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.Gif)|*.Gif|(*.bmp)|*.bmp| All Files (*.*)|*.*"

                If .ShowDialog = Windows.Forms.DialogResult.OK Then

                    IDPicture.Image = Image.FromFile(.FileName)

                End If

            End With

        Catch ex As Exception

            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
            Exit Sub

        End Try

    End Sub

    Private Sub BtnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click

        cmbCapture.Text = "ChangeInfo"
        CapturePicture.Show()

    End Sub

End Class