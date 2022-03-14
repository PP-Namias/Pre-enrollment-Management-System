Imports System.Data.OleDb
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text

Public Class TeacherData

    Sub Clear()

        TeacherIDTextBox.Text = ""
        PasswordTextBox.Text = ""
        UsernameTextBox.Text = ""
        DateOfBirthDateTimePicker.Value = Now
        PlaceOfBirthTextBox.Text = ""
        EmailIDTextBox.Text = ""
        PictureID.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Image\personal.png")

    End Sub

    Private Sub RoundButtonAdd(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 14)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnAdd.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnAdd.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonClear(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 14)

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

    Private Sub RoundButtonSave(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 14)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnSave.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnSave.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonDelete(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 14)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnDelete.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnDelete.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonCapture(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 12)

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
        btn.Font = New Font("Century Gothic", 12)

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
        btn.Font = New Font("Century Gothic", 12)

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

    Private Sub TeacherInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TeacherInfoBindingNavigatorSaveItem.Click

        If MessageBox.Show("Do you want to countinue save?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Validate()
            TeacherInfoBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Pre_enrollmentDataSet)

        End If

        MessageBox.Show("Save successful", "Record saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'Pre_enrollmentDataSet.TeacherInfo' table. You can move, or remove it, as needed.
        Me.TeacherInfoTableAdapter.Fill(Me.Pre_enrollmentDataSet.TeacherInfo)

        RoundButtonAdd(btnAdd)
        RoundButtonClear(btnClear)
        RoundButtonSave(btnSave)
        RoundButtonDelete(btnDelete)
        RoundButtonCapture(btnCapture)
        RoundButtonBrowse(btnBrowse)
        RoundButtonRemove(btnRemove)

        Try

            txtSearchTeacherID.Text = " "
            txtSearchTeacherID.Text = ""

            Dim TeacherID As String = DataGridView1.CurrentRow.Cells(0).Value
            TeacherIDTextBox.Text = TeacherID

            Dim Password As String = DataGridView1.CurrentRow.Cells(1).Value
            txtUncrypticPassword.Text = Decrypt(Password.ToString)

            Dim Username As String = DataGridView1.CurrentRow.Cells(2).Value
            UsernameTextBox.Text = Username

            Dim DOB As String = DataGridView1.CurrentRow.Cells(3).Value
            DateOfBirthDateTimePicker.Value = DOB

            Dim POB As String = DataGridView1.CurrentRow.Cells(4).Value
            PlaceOfBirthTextBox.Text = POB

            Dim EmailID As String = DataGridView1.CurrentRow.Cells(5).Value
            EmailIDTextBox.Text = EmailID

            Dim PictureValue As Byte() = DataGridView1.CurrentRow.Cells(6).Value
            Dim msPicture As New MemoryStream(PictureValue)
            PictureID.Image = Image.FromStream(msPicture)

            ' Auto Completion Search TeacherID
            Dim SearchTeacherIDConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")
            If SearchTeacherIDConnection.State = ConnectionState.Open Then SearchTeacherIDConnection.Close()
            SearchTeacherIDConnection.Open()

            Dim SearchTeacherIDCommand As New OleDbCommand("Select TeacherID from TeacherInfo", SearchTeacherIDConnection)
            Dim SearchTeacherIDDataAdapter As New OleDbDataAdapter(SearchTeacherIDCommand)
            Dim SearchTeacherIDDataSet As New DataSet
            SearchTeacherIDDataAdapter.Fill(SearchTeacherIDDataSet)
            Dim SearchTeacherIDColumn As New AutoCompleteStringCollection
            Dim i As Integer
            For i = 0 To SearchTeacherIDDataSet.Tables(0).Rows.Count - 1
                SearchTeacherIDColumn.Add(SearchTeacherIDDataSet.Tables(0).Rows(i)("TeacherID").ToString())
            Next
            txtSearchTeacherID.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtSearchTeacherID.AutoCompleteCustomSource = SearchTeacherIDColumn
            txtSearchTeacherID.AutoCompleteMode = AutoCompleteMode.SuggestAppend

            ' Auto Completion Search Username
            Dim SearchUsernameConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")
            If SearchUsernameConnection.State = ConnectionState.Open Then SearchUsernameConnection.Close()
            SearchUsernameConnection.Open()

            Dim SearchUsernameCommand As New OleDbCommand("Select Username from TeacherInfo", SearchUsernameConnection)
            Dim SearchUsernameDataAdapter As New OleDbDataAdapter(SearchUsernameCommand)
            Dim SearchUsernameDataSet As New DataSet
            SearchUsernameDataAdapter.Fill(SearchUsernameDataSet)
            Dim SearchUsernameColumn As New AutoCompleteStringCollection
            Dim j As Integer
            For j = 0 To SearchUsernameDataSet.Tables(0).Rows.Count - 1
                SearchUsernameColumn.Add(SearchUsernameDataSet.Tables(0).Rows(j)("Username").ToString())
            Next
            txtSearchUsername.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtSearchUsername.AutoCompleteCustomSource = SearchUsernameColumn
            txtSearchUsername.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Catch ex As Exception
            Clear()
            PictureID.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Image\personal.png")
            MessageBox.Show(ex.Message.ToString(), "Failed to Load Picture Id! (If adding a new teacher its normal)")
            Exit Sub

        End Try

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Clear()

    End Sub
    Private Sub BtnAddTeacher_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            AddTeacher()

            Me.TeacherInfoTableAdapter.Fill(Me.Pre_enrollmentDataSet.TeacherInfo)
            txtSearchTeacherID.Text = "1"
            txtSearchTeacherID.Text = ""

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error INSERT New Teacher", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End Try
    End Sub

    Sub AddTeacher()
        Try

            Dim NextConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

            If NextConnection.State = ConnectionState.Open Then NextConnection.Close()

            NextConnection.Open()

            Dim NextString As String = "INSERT INTO TeacherInfo([TeacherID],[Password],[Username],DateOfBirth,[PlaceOfBirth],[EmailID],TeacherPic) values(@d1,@d2,@d3,@d4,@d5,@d6,@d7)"
            Dim NextCommand As New OleDbCommand(NextString, NextConnection)

            ' Teacher ID
            Dim TeacherID As New OleDbParameter("@d1", OleDbType.VarWChar, 30) With {
                .Value = TeacherIDTextBox.Text.ToString().ToUpper
            }
            NextCommand.Parameters.Add(TeacherID)

            ' Password 
            Dim Password As New OleDbParameter("@d2", OleDbType.VarWChar, 30) With {
                .Value = Encrypt(txtUncrypticPassword.Text.ToString())
            }
            NextCommand.Parameters.Add(Password)

            ' Username
            Dim Username As New OleDbParameter("@d3", OleDbType.VarWChar, 30) With {
                .Value = UsernameTextBox.Text.ToString()
            }
            NextCommand.Parameters.Add(Username)

            ' Date of Birth
            Dim DOB As New OleDbParameter("@d4", OleDbType.Date, 15) With {
                .Value = DateOfBirthDateTimePicker.Text.ToString()
            }
            NextCommand.Parameters.Add(DOB)

            ' Place of Birth
            Dim PlaceOfBirth As New OleDbParameter("@d5", OleDbType.VarWChar, 30) With {
                .Value = PlaceOfBirthTextBox.Text.ToString()
            }
            NextCommand.Parameters.Add(PlaceOfBirth)

            ' EmailID
            Dim EmailID As New OleDbParameter("@d6", OleDbType.VarWChar, 30) With {
                .Value = EmailIDTextBox.Text.ToString()
            }
            NextCommand.Parameters.Add(EmailID)

            Dim MemStream As New MemoryStream
            Dim PictureID_Upload As Byte()

            PictureID.Image.Save(MemStream, ImageFormat.Png)
            PictureID_Upload = MemStream.GetBuffer()
            MemStream.Read(PictureID_Upload, 0, MemStream.Length)

            ' Teacher ID Picture
            Dim TeacherPicture As New OleDbParameter("@d7", SqlDbType.Image) With {
                .Value = PictureID_Upload
            }
            NextCommand.Parameters.Add(TeacherPicture)

            If NextCommand.ExecuteNonQuery() Then

                NextConnection.Close()

            Else

                MsgBox("New Teacher 'INSERT' failed.", MsgBoxStyle.Critical, "Adding new teacher failed")
                Return

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error 'INSERT' New Teacher", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End Try

    End Sub

    Sub SaveData()

        Try

            Dim UpdateConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

            If UpdateConnection.State = ConnectionState.Open Then UpdateConnection.Close()
            UpdateConnection.Open()

            Dim TeacherCommand As New OleDbCommand("Update TeacherInfo Set [Password]=@Password,[Username]=@Username,DateOfBirth=@DateOfBirth,[PlaceOfBirth]=@PlaceOfBirth,[EmailID]=@EmailID,TeacherPic=@Pic Where (TeacherID='" & TeacherIDTextBox.Text & "')", UpdateConnection)

            ' Password
            Dim Password As New OleDbParameter("@Password", OleDbType.VarWChar, 50) With {
                .Value = Encrypt(txtUncrypticPassword.Text.ToString())
            }
            TeacherCommand.Parameters.Add(Password)

            ' Username
            Dim Username As New OleDbParameter("@Username", OleDbType.VarWChar, 50) With {
                .Value = UsernameTextBox.Text.ToString()
            }
            TeacherCommand.Parameters.Add(Username)

            ' DateOfBirth
            Dim DateOfBirth As New OleDbParameter("@DateOfBirth", OleDbType.Date, 50) With {
                .Value = DateOfBirthDateTimePicker.Text.ToString()
            }
            TeacherCommand.Parameters.Add(DateOfBirth)

            ' PlaceOfBirth
            Dim PlaceOfBirth As New OleDbParameter("@PlaceOfBirth", OleDbType.VarWChar, 50) With {
                .Value = PlaceOfBirthTextBox.Text.ToString()
            }
            TeacherCommand.Parameters.Add(PlaceOfBirth)

            ' EmailID
            Dim EmailID As New OleDbParameter("@EmailID", OleDbType.VarWChar, 50) With {
                .Value = EmailIDTextBox.Text.ToString()
            }
            TeacherCommand.Parameters.Add(EmailID)

            Dim TeacherMemStream As New MemoryStream
            Dim TeacherDataPic_Update As Byte()

            PictureID.Image.Save(TeacherMemStream, Imaging.ImageFormat.Png)
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

            Else
                MsgBox("Your data update failed.", MsgBoxStyle.Critical, "Update Failed")
                Return

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Saving data failed!")
            Exit Sub

        End Try

    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtUncrypticPassword.Text = "" Then
            MessageBox.Show("Please enter a password", "Password empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        Else
            If MessageBox.Show("Do you want to countinue save?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                SaveData()
                Me.TeacherInfoTableAdapter.Fill(Me.Pre_enrollmentDataSet.TeacherInfo)
                txtSearchTeacherID.Text = "1"
                txtSearchTeacherID.Text = ""
            End If
        End If

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If TeacherIDTextBox.Text <> "" Then
                If MsgBox("Are you sure to delete data with Teacher Id: " & TeacherIDTextBox.Text & " ?", MsgBoxStyle.OkCancel, "Delete confirm") = MsgBoxResult.Cancel Then
                    ' do nothing
                Else
                    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")
                    If cn.State = ConnectionState.Open Then cn.Close()
                    cn.Open()

                    Dim temp As Integer = 0
                    Dim query As String = "DELETE FROM TeacherInfo WHERE TeacherID ='" & TeacherIDTextBox.Text & "'"

                    Dim cmd As New OleDbCommand(query) With {
                        .Connection = cn
                    }

                    temp = cmd.ExecuteNonQuery()
                    If temp > 0 Then
                        cn.Close()
                        'Call DataSetFill()
                        MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Me.TeacherInfoTableAdapter.Fill(Me.Pre_enrollmentDataSet.TeacherInfo)
                        txtSearchTeacherID.Text = "1"
                        txtSearchTeacherID.Text = ""
                    Else
                        'Call DataSetFill()
                        MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                End If
            Else
                MsgBox("Fill Teacher Id on Id textbox which Teacher to delete!!", MsgBoxStyle.OkOnly, "Info Data")
            End If


        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
        End Try

    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try

            Dim TeacherID As String = DataGridView1.CurrentRow.Cells(0).Value
            TeacherIDTextBox.Text = TeacherID

            Dim Password As String = DataGridView1.CurrentRow.Cells(1).Value
            txtUncrypticPassword.Text = Decrypt(Password.ToString)

            Dim Username As String = DataGridView1.CurrentRow.Cells(2).Value
            UsernameTextBox.Text = Username

            Dim DOB As String = DataGridView1.CurrentRow.Cells(3).Value
            DateOfBirthDateTimePicker.Value = DOB

            Dim POB As String = DataGridView1.CurrentRow.Cells(4).Value
            PlaceOfBirthTextBox.Text = POB

            Dim EmailID As String = DataGridView1.CurrentRow.Cells(5).Value
            EmailIDTextBox.Text = EmailID

            Dim PictureValue As Byte() = DataGridView1.CurrentRow.Cells(6).Value
            Dim msPicture As New MemoryStream(PictureValue)
            PictureID.Image = Image.FromStream(msPicture)

        Catch ex As Exception
            Clear()
            DateOfBirthDateTimePicker.Value = Now
            PictureID.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Image\personal.png")
            MessageBox.Show(ex.Message.ToString(), "Failed to Load Picture Id! (If adding a new teacher its normal)")
            Exit Sub

        End Try

    End Sub

    Private Sub BtnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click

        cmbCapture.Text = "TeacherData"
        CapturePicture.Show()

    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim OpenFile As New OpenFileDialog()

        Try
            With OpenFile
                .FileName = ""
                .Title = "Select ID Picture:"
                .Filter = "Image files: (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.Gif)|*.Gif|(*.bmp)|*.bmp| All Files (*.*)|*.*"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    PictureID.Image = Image.FromFile(.FileName)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
            Exit Sub

        End Try

    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        PictureID.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Image\personal.png")

    End Sub
    Private Sub TxtSearchTeacherID_TextChanged(sender As Object, e As EventArgs) Handles txtSearchTeacherID.TextChanged

        Try

            Dim SearchTeacherIDConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

            If SearchTeacherIDConnection.State = ConnectionState.Open Then SearchTeacherIDConnection.Close()
            SearchTeacherIDConnection.Open()

            Dim SearchTeacherIDCommand As New OleDbCommand("SELECT * FROM TeacherInfo WHERE TeacherID LIKE '%" & txtSearchTeacherID.Text & "%' AND Username LIKE '%" & txtSearchUsername.Text & "%'", SearchTeacherIDConnection)
            Dim SearchTeacherIDDataAdapter As New OleDbDataAdapter
            Dim SearchTeacherIDDataTable As New DataTable

            SearchTeacherIDDataAdapter.SelectCommand = SearchTeacherIDCommand
            SearchTeacherIDDataTable.Clear()
            SearchTeacherIDDataAdapter.Fill(SearchTeacherIDDataTable)
            DataGridView1.DataSource = SearchTeacherIDDataTable
            SearchTeacherIDConnection.Close()

            If DataGridView1.CurrentRow Is Nothing Then

                Clear()

            ElseIf DataGridView1.CurrentRow IsNot DBNull.Value Then
                Dim TeacherID As String = DataGridView1.CurrentRow.Cells(0).Value
                TeacherIDTextBox.Text = TeacherID

                Dim Password As String = DataGridView1.CurrentRow.Cells(1).Value
                txtUncrypticPassword.Text = Decrypt(Password.ToString)

                Dim Username As String = DataGridView1.CurrentRow.Cells(2).Value
                UsernameTextBox.Text = Username

                Dim DOB As String = DataGridView1.CurrentRow.Cells(3).Value
                DateOfBirthDateTimePicker.Value = DOB

                Dim POB As String = DataGridView1.CurrentRow.Cells(4).Value
                PlaceOfBirthTextBox.Text = POB

                Dim EmailID As String = DataGridView1.CurrentRow.Cells(5).Value
                EmailIDTextBox.Text = EmailID

                Dim PictureValue As Byte() = DataGridView1.CurrentRow.Cells(6).Value
                Dim msPicture As New MemoryStream(PictureValue)
                PictureID.Image = Image.FromStream(msPicture)

            End If

        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error Search Teacher ID")
            Exit Sub

        End Try

    End Sub

    Private Sub TxtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtSearchUsername.TextChanged

        Try

            Dim SearchUsernameConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

            If SearchUsernameConnection.State = ConnectionState.Open Then SearchUsernameConnection.Close()
            SearchUsernameConnection.Open()

            Dim SearchUsernameCommand As New OleDbCommand("SELECT * FROM TeacherInfo WHERE Username LIKE '%" & txtSearchUsername.Text & "%' AND TeacherID LIKE '%" & txtSearchTeacherID.Text & "%'", SearchUsernameConnection)
            Dim SearchUsernameDataAdapter As New OleDbDataAdapter
            Dim SearchUsernameDataTable As New DataTable

            SearchUsernameDataAdapter.SelectCommand = SearchUsernameCommand
            SearchUsernameDataTable.Clear()
            SearchUsernameDataAdapter.Fill(SearchUsernameDataTable)
            DataGridView1.DataSource = SearchUsernameDataTable
            SearchUsernameConnection.Close()

            If DataGridView1.CurrentRow Is Nothing Then

                Clear()

            ElseIf DataGridView1.CurrentRow IsNot DBNull.Value Then
                Dim TeacherID As String = DataGridView1.CurrentRow.Cells(0).Value
                TeacherIDTextBox.Text = TeacherID

                Dim Password As String = DataGridView1.CurrentRow.Cells(1).Value
                txtUncrypticPassword.Text = Decrypt(Password.ToString)

                Dim Username As String = DataGridView1.CurrentRow.Cells(2).Value
                UsernameTextBox.Text = Username

                Dim DOB As String = DataGridView1.CurrentRow.Cells(3).Value
                DateOfBirthDateTimePicker.Value = DOB

                Dim POB As String = DataGridView1.CurrentRow.Cells(4).Value
                PlaceOfBirthTextBox.Text = POB

                Dim EmailID As String = DataGridView1.CurrentRow.Cells(5).Value
                EmailIDTextBox.Text = EmailID

                Dim PictureValue As Byte() = DataGridView1.CurrentRow.Cells(6).Value
                Dim msPicture As New MemoryStream(PictureValue)
                PictureID.Image = Image.FromStream(msPicture)

            End If

        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error Search Username")
            Exit Sub

        End Try

    End Sub

    Private Sub TxtUncrypticPassword_TextChanged(sender As Object, e As EventArgs) Handles txtUncrypticPassword.TextChanged

        PasswordTextBox.Text = Encrypt(txtUncrypticPassword.Text)

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

        txtUncrypticPassword.Text = Decrypt(PasswordTextBox.Text)

    End Sub

    'Encryption
    Public Function Encrypt(Encryption As String) As String

        Try

            Dim encode As Byte() = New Byte(Encryption.Length - 1) {}
            encode = Encoding.UTF8.GetBytes(Encryption)
            Dim msg As String = Convert.ToBase64String(encode)
            Return msg

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Encrypting data failed!")

        End Try

    End Function

    'Decryption
    Public Function Decrypt(Decryption As String) As String

        Try

            Dim encodedtext As New UTF8Encoding
            Dim decode As Decoder = encodedtext.GetDecoder
            Dim code_byte As Byte() = Convert.FromBase64String(Decryption)
            Dim charcount As Integer = decode.GetCharCount(code_byte, 0, code_byte.Length)
            Dim decode_char As Char() = New Char(charcount - 1) {}
            decode.GetChars(code_byte, 0, code_byte.Length, decode_char, 0)
            Dim decryptext As New String(decode_char)
            Return decryptext


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Decrypting data failed!")

        End Try

    End Function

    Private Sub picHelp1_Click(sender As Object, e As EventArgs) Handles picHelp1.Click

        TeacherDataGuide.Show()

        picHelp1.Visible = False

    End Sub

End Class