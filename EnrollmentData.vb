Imports System.Data.OleDb
Imports System.IO
Public Class EnrollmentData

    Private Sub RoundButtonApprove(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 12)

        Dim Raduis As New Drawing2D.GraphicsPath
        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnApprove.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnApprove.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonDenied(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 12)

        Dim Raduis As New Drawing2D.GraphicsPath
        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnDenied.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnDenied.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonSave(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 12)

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
        btn.Font = New Font("Century Gothic", 12)

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

    Private Sub RoundButtonGenerateID(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 12)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnGenerateID.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnGenerateID.Region = New Region(Raduis)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RoundButtonApprove(btnApprove)
        RoundButtonDenied(btnDenied)
        RoundButtonSave(btnSave)
        RoundButtonDelete(btnDelete)
        RoundButtonCapture(btnCapture)
        RoundButtonBrowse(btnBrowse)
        RoundButtonRemove(btnRemove)
        RoundButtonGenerateID(btnGenerateID)

        'TODO: This line of code loads data into the 'Pre_enrollmentDataSet.EnrollmentData' table. You can move, or remove it, as needed.
        Me.EnrollmentDataTableAdapter.Fill(Me.Pre_enrollmentDataSet.EnrollmentData)

        Try

            Dim x As Byte() = AdvancedDataGridView1.CurrentRow.Cells(0).Value
            Dim ms As New MemoryStream(x)
            PictureID.Image = Image.FromStream(ms)

            Dim Status As String = AdvancedDataGridView1.CurrentRow.Cells(3).Value
            StatusTextBox.Text = Status

            If StatusTextBox.Text = "enrolled" Then

                btnApprove.Visible = False
                btnGenerateID.Visible = True

            Else

                btnApprove.Visible = True
                btnGenerateID.Visible = False

            End If

            If StatusTextBox.Text = "denied" Then

                btnDenied.Visible = False

            Else

                btnDenied.Visible = True

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message.ToString(), "Load Picture ID failed!")
            Exit Sub

        End Try

    End Sub

    Private Sub AdvancedDataGridView1_SortStringChanged(sender As Object, e As EventArgs) Handles AdvancedDataGridView1.SortStringChanged

        EnrollmentDataBindingSource.Sort = AdvancedDataGridView1.SortString

    End Sub

    Private Sub AdvancedDataGridView1_FilterStringChanged(sender As Object, e As EventArgs) Handles AdvancedDataGridView1.FilterStringChanged

        EnrollmentDataBindingSource.Filter = AdvancedDataGridView1.FilterString

    End Sub

    Private Sub EnrollmentDataBindingSource_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles EnrollmentDataBindingSource.ListChanged

        lblTotal.Text = String.Format("Total Student Pre-enrolled: {0}", EnrollmentDataBindingSource.List.Count)

    End Sub

    Sub SaveData()

        Try

            Dim SaveDataConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

            If SaveDataConnection.State = ConnectionState.Open Then SaveDataConnection.Close()
            SaveDataConnection.Open()

            Dim SaveDataCommand As New OleDbCommand("Update EnrollmentData Set [StudentNumber]=@StudentNumber,[GradeLevel]=@GradeLevel,[Strand]=@Strand,[Semester]=@Semester,[SchoolYear]=@SchoolYear,[Lastname]=@Lastname,[Firstname]=@Firstname,[Middlename]=@Middlename,[Age]=@Age,DOB=@DOB,[Sex]=@Sex,[POB]=@POB,[Nationality]=@Nationality,[Religion]=@Religion,[Email]=@Email,[MobileNumber]=@MobileNumber,[TelephoneNumber]=@TelephoneNumber,[Address]=@Address,[City]=@City,[FatherName]=@FatherName,[FatherOccupation]=@FatherOccupation,[FatherEmail]=@FatherEmail,[FatherWorkAddress]=@FatherWorkAddress,[FatherContactNumber]=@FatherContactNumber,[MotherName]=@MotherName,[MotherOccupation]=@MotherOccupation,[MotherEmail]=@MotherEmail,[MotherWorkAddress]=@MotherWorkAddress,[MotherContactNumber]=@MotherContactNumber,[NumberOfSiblings]=@NumberOfSiblings,[PersonEmergency]=@PersonEmergency,[GuardianName]=@GuardianName,[GuardianRelation]=@GuardianRelation,[GuardianEmail]=@GuardianEmail,[GuardianWorkAddress]=@GuardianWorkAddress,[GuardianContactNumber]=@GuardianContactNumber,[FetcherName]=@FetcherName,[FetcherContactNumber]=@FetcherContactNumber,[SiblingsOfStudent1]=@SiblingsOfStudent1,[SiblingsOfStudent2]=@SiblingsOfStudent2,[SiblingsOfStudent3]=@SiblingsOfStudent3,[SiblingsOfStudentAge1]=@SiblingsOfStudentAge1,[SiblingsOfStudentAge2]=@SiblingsOfStudentAge2,[SiblingsOfStudentAge3]=@SiblingsOfStudentAge3,[SiblingsOfStudentSchool1]=@SiblingsOfStudentSchool1,[SiblingsOfStudentSchool2]=@SiblingsOfStudentSchool2,[SiblingsOfStudentSchool3]=@SiblingsOfStudentSchool3,[SchoolLastAttended1]=@SchoolLastAttended1,[SchoolLastAttended2]=@SchoolLastAttended2,[SchoolLastAttended3]=@SchoolLastAttended3,[AcademicYear1]=@AcademicYear1,[AcademicYear2]=@AcademicYear2,[AcademicYear3]=@AcademicYear3,[ReasonApplying]=@ReasonApplying,[Status]=@Status,StudentPicture=@StudentPicture Where (EnrollmentNumber=" & EnrollmentNumberTextBox1.Text & ")", SaveDataConnection)

            ' Student Number
            Dim StudentNumber As New OleDbParameter("@StudentNumber", OleDbType.VarWChar, 100) With {
                .Value = StudentNumberTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(StudentNumber)

            ' Grade Level
            Dim GradeLevel As New OleDbParameter("@GradeLevel", OleDbType.VarWChar, 100) With {
                .Value = GradeLevelTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(GradeLevel)

            ' Strand
            Dim Strand As New OleDbParameter("@Strand", OleDbType.VarWChar, 100) With {
                .Value = StrandTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(Strand)

            ' Semester
            Dim Semester As New OleDbParameter("@Semester", OleDbType.VarWChar, 100) With {
                .Value = SemesterTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(Semester)

            ' SchoolYear
            Dim SchoolYear As New OleDbParameter("@SchoolYear", OleDbType.VarWChar, 100) With {
                .Value = SchoolYearTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(SchoolYear)

            ' Lastname
            Dim Lastname As New OleDbParameter("@Lastname", OleDbType.VarWChar, 100) With {
                .Value = LastnameTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(Lastname)

            ' Firstname
            Dim Firstname As New OleDbParameter("@Firstname", OleDbType.VarWChar, 100) With {
                .Value = FirstnameTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(Firstname)

            ' Middlename
            Dim Middlename As New OleDbParameter("@Middlename", OleDbType.VarWChar, 100) With {
                .Value = MiddlenameTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(Middlename)

            ' Age
            Dim Age As New OleDbParameter("@Age", OleDbType.VarWChar, 100) With {
                .Value = AgeTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(Age)

            ' Date of Birth
            Dim DOB As New OleDbParameter("@DOB", OleDbType.Date, 100) With {
                .Value = DOBDateTimePicker1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(DOB)

            ' Sex
            Dim Sex As New OleDbParameter("@Sex", OleDbType.VarWChar, 100) With {
                .Value = SexTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(Sex)

            ' Place of Birth
            Dim POB As New OleDbParameter("@POB", OleDbType.VarWChar, 100) With {
                .Value = POBTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(POB)

            ' Nationality
            Dim Nationality As New OleDbParameter("@Nationality", OleDbType.VarWChar, 100) With {
                .Value = NationalityTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(Nationality)

            ' Religion
            Dim Religion As New OleDbParameter("@Religion", OleDbType.VarWChar, 100) With {
                .Value = ReligionTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(Religion)

            ' Email
            Dim Email As New OleDbParameter("@Email", OleDbType.VarWChar, 100) With {
                .Value = EmailTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(Email)

            ' Mobile Number
            Dim MobileNumber As New OleDbParameter("@MobileNumber", OleDbType.VarWChar, 100) With {
                .Value = MobileNumberTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(MobileNumber)

            ' TelephoneNumber
            Dim TelephoneNumber As New OleDbParameter("@TelephoneNumber", OleDbType.VarWChar, 100) With {
                .Value = TelephoneNumberTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(TelephoneNumber)

            ' Address
            Dim Address As New OleDbParameter("@Address", OleDbType.VarWChar, 100) With {
                .Value = AddressTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(Address)

            ' City
            Dim City As New OleDbParameter("@City", OleDbType.VarWChar, 100) With {
                .Value = CityTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(City)

            ' Father Name
            Dim FatherName As New OleDbParameter("@FatherName", OleDbType.VarWChar, 100) With {
                .Value = FatherNameTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(FatherName)

            ' Father Occupation
            Dim FatherOccupation As New OleDbParameter("@FatherOccupation", OleDbType.VarWChar, 100) With {
                .Value = FatherOccupationTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(FatherOccupation)

            ' Father Email
            Dim FatherEmail As New OleDbParameter("@FatherEmail", OleDbType.VarWChar, 100) With {
                .Value = FatherEmailTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(FatherEmail)

            ' Father Work Address
            Dim FatherWorkAddress As New OleDbParameter("@FatherWorkAddress", OleDbType.VarWChar, 100) With {
                .Value = FatherWorkAddressTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(FatherWorkAddress)

            ' Father Contact Number
            Dim FatherContactNumber As New OleDbParameter("@FatherContactNumber", OleDbType.VarWChar, 100) With {
                .Value = FatherContactNumberTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(FatherContactNumber)

            ' Mother Name
            Dim MotherName As New OleDbParameter("@MotherName", OleDbType.VarWChar, 100) With {
                .Value = MotherNameTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(MotherName)

            ' Mother Occupation
            Dim MotherOccupation As New OleDbParameter("@MotherOccupation", OleDbType.VarWChar, 100) With {
                .Value = MotherOccupationTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(MotherOccupation)

            ' Mother Email
            Dim MotherEmail As New OleDbParameter("@MotherEmail", OleDbType.VarWChar, 100) With {
                .Value = MotherEmailTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(MotherEmail)

            ' Mother Work Address
            Dim MotherWorkAddress As New OleDbParameter("@MotherWorkAddress", OleDbType.VarWChar, 100) With {
                .Value = MotherWorkAddressTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(MotherWorkAddress)

            ' Mother Contact Number
            Dim MotherContactNumber As New OleDbParameter("@MotherContactNumber", OleDbType.VarWChar, 100) With {
                .Value = MotherContactNumberTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(MotherContactNumber)

            ' Number of Siblings
            Dim NumberOfSiblings As New OleDbParameter("@NumberOfSiblings", OleDbType.VarWChar, 100) With {
                .Value = NumberOfSiblingsTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(NumberOfSiblings)

            ' Person in case of Emergency
            Dim PersonEmergency As New OleDbParameter("@PersonEmergency", OleDbType.VarWChar, 100) With {
                .Value = PersonEmergencyTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(PersonEmergency)

            ' Guardian Name
            Dim GuardianName As New OleDbParameter("@GuardianName", OleDbType.VarWChar, 100) With {
                .Value = GuardianNameTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(GuardianName)

            ' Guardian Relation
            Dim GuardianRelation As New OleDbParameter("@GuardianRelation", OleDbType.VarWChar, 100) With {
                .Value = GuardianRelationTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(GuardianRelation)

            ' Guardian Email
            Dim GuardianEmail As New OleDbParameter("@GuardianEmail", OleDbType.VarWChar, 100) With {
                .Value = GuardianEmailTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(GuardianEmail)

            ' Guardian Work Address
            Dim GuardianWorkAddress As New OleDbParameter("@GuardianWorkAddress", OleDbType.VarWChar, 100) With {
                .Value = GuardianWorkAddressTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(GuardianWorkAddress)

            ' Guardian Contact Number
            Dim GuardianContactNumber As New OleDbParameter("@GuardianContactNumber", OleDbType.VarWChar, 100) With {
                .Value = GuardianContactNumberTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(GuardianContactNumber)

            ' Fetcher Name
            Dim FetcherName As New OleDbParameter("@FetcherName", OleDbType.VarWChar, 100) With {
                .Value = FetcherNameTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(FetcherName)

            ' Fetcher Contact Number
            Dim FetcherContactNumber As New OleDbParameter("@FetcherContactNumber", OleDbType.VarWChar, 100) With {
                .Value = FetcherContactNumberTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(FetcherContactNumber)

            ' Siblings of Student 1
            Dim SiblingsOfStudent1 As New OleDbParameter("@SiblingsOfStudent1", OleDbType.VarWChar, 100) With {
                .Value = SiblingsOfStudent1TextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(SiblingsOfStudent1)

            ' Siblings of Student 2
            Dim SiblingsOfStudent2 As New OleDbParameter("@SiblingsOfStudent2", OleDbType.VarWChar, 100) With {
                .Value = SiblingsOfStudent2TextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(SiblingsOfStudent2)

            ' Siblings of Student 3
            Dim SiblingsOfStudent3 As New OleDbParameter("@SiblingsOfStudent3", OleDbType.VarWChar, 100) With {
                .Value = SiblingsOfStudent3TextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(SiblingsOfStudent3)

            ' Siblings of Student Age 1
            Dim SiblingsOfStudentAge1 As New OleDbParameter("@SiblingsOfStudentAge1", OleDbType.VarWChar, 100) With {
                .Value = SiblingsOfStudentAge1TextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(SiblingsOfStudentAge1)

            ' Siblings of Student Age 2
            Dim SiblingsOfStudentAge2 As New OleDbParameter("@SiblingsOfStudentAge2", OleDbType.VarWChar, 100) With {
                .Value = SiblingsOfStudentAge2TextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(SiblingsOfStudentAge2)

            ' Siblings of Student Age 3
            Dim SiblingsOfStudentAge3 As New OleDbParameter("@SiblingsOfStudentAge3", OleDbType.VarWChar, 100) With {
                .Value = SiblingsOfStudentAge3TextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(SiblingsOfStudentAge3)

            ' Siblings of Student School 1
            Dim SiblingsOfStudentSchool1 As New OleDbParameter("@SiblingsOfStudentSchool1", OleDbType.VarWChar, 100) With {
                .Value = SiblingsOfStudentSchool1TextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(SiblingsOfStudentSchool1)

            ' Siblings of Student School 2
            Dim SiblingsOfStudentSchool2 As New OleDbParameter("@SiblingsOfStudentSchool2", OleDbType.VarWChar, 100) With {
                .Value = SiblingsOfStudentSchool2TextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(SiblingsOfStudentSchool2)

            ' Siblings of Student School 3
            Dim SiblingsOfStudentSchool3 As New OleDbParameter("@SiblingsOfStudentSchool3", OleDbType.VarWChar, 100) With {
                .Value = SiblingsOfStudentSchool3TextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(SiblingsOfStudentSchool3)

            ' School Last Attended 1
            Dim SchoolLastAttended1 As New OleDbParameter("@SchoolLastAttended1", OleDbType.VarWChar, 100) With {
                .Value = SchoolLastAttended1TextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(SchoolLastAttended1)

            ' School Last Attended 2
            Dim SchoolLastAttended2 As New OleDbParameter("@SchoolLastAttended2", OleDbType.VarWChar, 100) With {
                .Value = SchoolLastAttended2TextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(SchoolLastAttended2)

            ' School Last Attended 3
            Dim SchoolLastAttended3 As New OleDbParameter("@SchoolLastAttended3", OleDbType.VarWChar, 100) With {
                .Value = SchoolLastAttended3TextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(SchoolLastAttended3)

            ' Academic Year 1
            Dim AcademicYear1 As New OleDbParameter("@AcademicYear1", OleDbType.VarWChar, 100) With {
                .Value = AcademicYear1TextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(AcademicYear1)

            ' AcademicYear2
            Dim AcademicYear2 As New OleDbParameter("@AcademicYear2", OleDbType.VarWChar, 100) With {
                .Value = AcademicYear2TextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(AcademicYear2)

            ' AcademicYear3
            Dim AcademicYear3 As New OleDbParameter("@AcademicYear3", OleDbType.VarWChar, 100) With {
                .Value = AcademicYear3TextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(AcademicYear3)

            ' Reason Applying
            Dim ReasonApplying As New OleDbParameter("@ReasonApplying", OleDbType.VarWChar, 550) With {
                .Value = ReasonApplyingTextBox1.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(ReasonApplying)

            ' Status
            Dim Status As New OleDbParameter("@Status", OleDbType.VarWChar, 100) With {
                .Value = StatusTextBox.Text.ToString()
            }
            SaveDataCommand.Parameters.Add(Status)

            Dim StudentMemStream As New MemoryStream
            Dim StudentDataPic_Update As Byte()

            PictureID.Image.Save(StudentMemStream, Imaging.ImageFormat.Png)
            StudentDataPic_Update = StudentMemStream.GetBuffer()
            StudentMemStream.Read(StudentDataPic_Update, 0, StudentMemStream.Length)

            ' Student ID Picture
            Dim TeacherPicture As New OleDbParameter("@StudentPicture", SqlDbType.Image) With {
                .Value = StudentDataPic_Update
            }
            SaveDataCommand.Parameters.Add(TeacherPicture)

            If SaveDataCommand.ExecuteNonQuery() Then

                SaveDataConnection.Close()
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

    Private Sub BtnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click

        Try

            Dim EnrollmentApproveConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

            If EnrollmentApproveConnection.State = ConnectionState.Open Then EnrollmentApproveConnection.Close()
            EnrollmentApproveConnection.Open()

            Dim EnrollmentApproveCommand As New OleDbCommand("Update EnrollmentData Set Status=@Status,StudentNumber=@StudentNumber Where EnrollmentNumber=" & AdvancedDataGridView1.CurrentRow.Cells(2).Value & "", EnrollmentApproveConnection)

            ' Status
            Dim Status As New OleDbParameter("@Status", OleDbType.VarChar, 100) With {
                .Value = "enrolled"
            }
            EnrollmentApproveCommand.Parameters.Add(Status)

            Dim year As String = AdvancedDataGridView1.CurrentRow.Cells(12).Value.ToString()
            Dim SplitPart = year.Split(" "c)
            Dim Sfinal As String = SplitPart(0).Trim
            Dim years As String = (String.Format("{0}", Sfinal)).ToString
            Dim SplitParts = years.Split("0"c)
            Dim finals As String = SplitParts(1).Trim
            Dim yearss As String = (String.Format("{0}", Sfinal)).ToString

            ' Student Number
            Dim StudentNumber As New OleDbParameter("@StudentNumber", OleDbType.VarChar, 100) With {
                .Value = (yearss.Remove(0, 2)).ToString & "-" & (String.Format("{0:000000}", AdvancedDataGridView1.CurrentRow.Cells(2).Value)).ToString
            }
            EnrollmentApproveCommand.Parameters.Add(StudentNumber)

            If EnrollmentApproveCommand.ExecuteNonQuery() Then

                EnrollmentApproveConnection.Close()
                MsgBox("Student approved successfully.", MsgBoxStyle.Information, "Student Approved!")

                Me.EnrollmentDataTableAdapter.Fill(Me.Pre_enrollmentDataSet.EnrollmentData)

            Else

                MsgBox("Your data update failed.", MsgBoxStyle.Critical, "Update Failed")
                Return

            End If

            If StatusTextBox.Text = "enrolled" Then

                btnApprove.Visible = False
                btnGenerateID.Visible = True

            Else

                btnApprove.Visible = True
                btnGenerateID.Visible = False

            End If

            If StatusTextBox.Text = "denied" Then

                btnDenied.Visible = False

            Else

                btnDenied.Visible = True

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message.ToString(), "Saving data failed!")
            Exit Sub

        End Try

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        SaveData()

        Me.EnrollmentDataTableAdapter.Fill(Me.Pre_enrollmentDataSet.EnrollmentData)

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Try

            If AdvancedDataGridView1.CurrentRow.Cells(2).Value.ToString <> "" Then

                If MsgBox("Are you sure to delete data of the student: " & AdvancedDataGridView1.CurrentRow.Cells(6).Value.ToString & ", " & AdvancedDataGridView1.CurrentRow.Cells(7).Value.ToString & " " & AdvancedDataGridView1.CurrentRow.Cells(8).Value.ToString & "?", MsgBoxStyle.OkCancel, "Delete confirm") = MsgBoxResult.Cancel Then

                    ' do nothing

                Else

                    Dim EnrollmentDeleteConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

                    If EnrollmentDeleteConnection.State = ConnectionState.Open Then EnrollmentDeleteConnection.Close()
                    EnrollmentDeleteConnection.Open()

                    Dim temp As Integer = 0
                    Dim query As String = "DELETE FROM EnrollmentData Where EnrollmentNumber=" & AdvancedDataGridView1.CurrentRow.Cells(2).Value & ""

                    Dim EnrollmentDeleteCommand As New OleDbCommand(query) With {
                        .Connection = EnrollmentDeleteConnection
                    }

                    temp = EnrollmentDeleteCommand.ExecuteNonQuery()
                    If temp > 0 Then

                        EnrollmentDeleteConnection.Close()

                        MessageBox.Show("Student enrollment data successfully deleted", "Successfully deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Me.EnrollmentDataTableAdapter.Fill(Me.Pre_enrollmentDataSet.EnrollmentData)

                    Else

                        MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If

                End If

            Else

                MsgBox("Can't 'delete' students data. Make sure to have proper enrollment number!", MsgBoxStyle.OkOnly, "Students Data")

            End If

        Catch ex As Exception

            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error 'DELETE' students data")
            Exit Sub

        End Try

    End Sub

    Private Sub BtnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click

        cmbCapture.Text = "EnrollmentData"
        CapturePicture.Show()

    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim OpenFile As New OpenFileDialog()

        Try

            With OpenFile

                .FileName = ""
                .Title = "Photo:"
                .Filter = "Image files: (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.Gif)|*.Gif|(*.bmp)|*.bmp| All Files (*.*)|*.*"

                If .ShowDialog = Windows.Forms.DialogResult.OK Then

                    PictureID.Image = Image.FromFile(.FileName)

                End If

            End With

        Catch ex As Exception

            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")

        End Try

    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        PictureID.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Image\personal.png")

    End Sub

    Private Sub AdvancedDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AdvancedDataGridView1.CellClick

        Try

            Dim x As Byte() = AdvancedDataGridView1.CurrentRow.Cells(0).Value
            Dim ms As New MemoryStream(x)
            PictureID.Image = Image.FromStream(ms)

            Dim Status As String = AdvancedDataGridView1.CurrentRow.Cells(3).Value
            StatusTextBox.Text = Status

            If StatusTextBox.Text = "enrolled" Then

                btnApprove.Visible = False
                btnGenerateID.Visible = True

            Else

                btnApprove.Visible = True
                btnGenerateID.Visible = False

            End If

            If StatusTextBox.Text = "denied" Then

                btnDenied.Visible = False

            Else

                btnDenied.Visible = True

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message.ToString(), "Load Picture ID failed!")
            Exit Sub

        End Try

    End Sub

    Private Sub AdvancedDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AdvancedDataGridView1.CellContentClick

        If AdvancedDataGridView1.Columns(e.ColumnIndex).Name = "Approve" Then

            btnApprove.PerformClick()

        End If

    End Sub

    Private Sub BtnDenied_Click(sender As Object, e As EventArgs) Handles btnDenied.Click

        Try

            Dim EnrollmentDeniedConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

            If EnrollmentDeniedConnection.State = ConnectionState.Open Then EnrollmentDeniedConnection.Close()
            EnrollmentDeniedConnection.Open()

            Dim EnrollmentDeniedCommand As New OleDbCommand("Update EnrollmentData Set Status=@Status,StudentNumber=@StudentNumber Where EnrollmentNumber=" & AdvancedDataGridView1.CurrentRow.Cells(2).Value & "", EnrollmentDeniedConnection)

            ' Status
            Dim Status As New OleDbParameter("@Status", OleDbType.VarChar, 100) With {
                .Value = "denied"
            }
            EnrollmentDeniedCommand.Parameters.Add(Status)

            ' Student Number
            Dim StudentNumber As New OleDbParameter("@StudentNumber", OleDbType.VarChar, 100) With {
                .Value = ""
            }
            EnrollmentDeniedCommand.Parameters.Add(StudentNumber)

            If EnrollmentDeniedCommand.ExecuteNonQuery() Then

                EnrollmentDeniedConnection.Close()

                MsgBox("Student denied successfully.", MsgBoxStyle.Information, "Student Denied!")

                Me.EnrollmentDataTableAdapter.Fill(Me.Pre_enrollmentDataSet.EnrollmentData)

            Else

                MsgBox("Your data update failed.", MsgBoxStyle.Critical, "Update Failed")
                Return

            End If

            If StatusTextBox.Text = "enrolled" Then

                btnApprove.Visible = False
                btnGenerateID.Visible = True

            Else

                btnApprove.Visible = True
                btnGenerateID.Visible = False

            End If

            If StatusTextBox.Text = "denied" Then

                btnDenied.Visible = False

            Else

                btnDenied.Visible = True

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message.ToString(), "Rejecting data failed!")
            Exit Sub

        End Try

    End Sub

    Private Sub GenerateID_Click(sender As Object, e As EventArgs) Handles btnGenerateID.Click

        cmbEnrollmentNum.Text = AdvancedDataGridView1.CurrentRow.Cells(2).Value.ToString

        GenarateID.Show()

    End Sub

    Private Sub EnrollmentNumberTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EnrollmentNumberTextBox1.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub StudentNumberTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StudentNumberTextBox1.KeyPress

        'Allowed Numbers and "-" only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 45 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub GradeLevelTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GradeLevelTextBox1.KeyPress

        'Allowed Numbers and "-" only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 45 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub StrandTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StrandTextBox1.KeyPress

        'Allowed letters numbers and ()
        If e.KeyChar <> ControlChars.Back = True Then

            If "~`@%^&+={[}]!:,;'><?/|\-.#+_$*".IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub SemesterTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SemesterTextBox1.KeyPress

        'Allowed Letters and Number only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = ".~`@#$%^&*()_-+={[}]:;',!><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub SchoolYearTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SchoolYearTextBox1.KeyPress

        'Allowed Numbers and "-" only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 45 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub LastnameTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LastnameTextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub FirstnameTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FirstnameTextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub MiddlenameTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MiddlenameTextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub AgeTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AgeTextBox1.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub DOBDateTimePicker1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DOBDateTimePicker1.KeyPress

        'Allowed all

    End Sub

    Private Sub SexTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SexTextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub EmailTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmailTextBox1.KeyPress

        'Allowed letters numbers and ( @ _ . )
        If e.KeyChar <> ControlChars.Back = True Then

            If "~`%^&+={[}]()!:,;'>$<?/|\-*#+".IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub MobileNumberTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MobileNumberTextBox1.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TelephoneNumberTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TelephoneNumberTextBox1.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub POBTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles POBTextBox1.KeyPress

        'Allowed Letters, Number and "." only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "~`@#$%^&*()_-+={[}]:;',!><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub NationalityTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NationalityTextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub ReligionTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ReligionTextBox1.KeyPress

        'Allowed Letters and ( / \ ) only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?|"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub AddressTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AddressTextBox1.KeyPress

        'Allowed Letters, Number and "." only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "~`@#$%^&*()_-+={[}]:;',!><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub CityTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CityTextBox1.KeyPress

        'Allowed Letters, Number and "." only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "~`@#$%^&*()_-+={[}]:;',!><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub FatherNameTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FatherNameTextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub FatherOccupationTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FatherOccupationTextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub FatherEmailTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FatherEmailTextBox1.KeyPress

        'Allowed letters numbers and ( _ @ )
        If e.KeyChar <> ControlChars.Back = True Then

            If "~`%^&+$*={[}]()!:,;'><?/|\-.#+".IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub FatherWorkAddressTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FatherWorkAddressTextBox1.KeyPress

        'Allowed Letters, Number and "." only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "~`@#$%^&*()_-+={[}]:;',!><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub FatherContactNumberTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FatherContactNumberTextBox1.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub MotherNameTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MotherNameTextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub MotherOccupationTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MotherOccupationTextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub MotherEmailTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MotherEmailTextBox1.KeyPress

        'Allowed letters numbers and ( _ @ )
        If e.KeyChar <> ControlChars.Back = True Then

            If "~`%^&+$*={[}]()!:,;'><?/|\-.#+".IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub MotherWorkAddressTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MotherWorkAddressTextBox1.KeyPress

        'Allowed Letters, Number and "." only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "~`@#$%^&*()_-+={[}]:;',!><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub MotherContactNumberTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MotherContactNumberTextBox1.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub PersonEmergencyTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PersonEmergencyTextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub GuardianNameTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GuardianNameTextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub GuardianRelationTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GuardianRelationTextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub GuardianEmailTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GuardianEmailTextBox1.KeyPress

        'Allowed letters numbers and ( _ @ )
        If e.KeyChar <> ControlChars.Back = True Then

            If "~`%^&+$*={[}]()!:,;'><?/|\-.#+".IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub GuardianWorkAddressTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GuardianWorkAddressTextBox1.KeyPress

        'Allowed Letters, Number and "." only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "~`@#$%^&*()_-+={[}]:;',!><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub GuardianContactNumberTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GuardianContactNumberTextBox1.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub FetcherNameTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FetcherNameTextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub FetcherContactNumberTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FetcherContactNumberTextBox1.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub NumberOfSiblingsTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumberOfSiblingsTextBox1.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If


    End Sub

    Private Sub SiblingsOfStudent1TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SiblingsOfStudent1TextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub SiblingsOfStudent2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SiblingsOfStudent2TextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub SiblingsOfStudent3TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SiblingsOfStudent3TextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub SiblingsOfStudentAge1TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SiblingsOfStudentAge1TextBox1.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If


    End Sub

    Private Sub SiblingsOfStudentAge2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SiblingsOfStudentAge2TextBox1.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If


    End Sub

    Private Sub SiblingsOfStudentAge3TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SiblingsOfStudentAge3TextBox1.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If


    End Sub

    Private Sub SiblingsOfStudentSchool1TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SiblingsOfStudentSchool1TextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub SiblingsOfStudentSchool2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SiblingsOfStudentSchool2TextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub SiblingsOfStudentSchool3TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SiblingsOfStudentSchool3TextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub SchoolLastAttended1TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SchoolLastAttended1TextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub SchoolLastAttended2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SchoolLastAttended2TextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub SchoolLastAttended3TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SchoolLastAttended3TextBox1.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub AcademicYear1TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AcademicYear1TextBox1.KeyPress

        'Allowed Numbers and "-" only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 45 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub AcademicYear2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AcademicYear2TextBox1.KeyPress

        'Allowed Numbers and "-" only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 45 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub AcademicYear3TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AcademicYear3TextBox1.KeyPress

        'Allowed Numbers and "-" only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 45 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub ReasonApplyingTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ReasonApplyingTextBox1.KeyPress

        'Allowed Letters, Number and "." only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "~`@#$%^&*()_-+={[}]:;',!><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub StatusTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StatusTextBox.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub IdentifierDateTimePicker_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IdentifierDateTimePicker.KeyPress

        'Allowed all

    End Sub

    Private Sub ConditionTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ConditionTextBox.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub Requirement1TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Requirement1TextBox.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub Requirement2TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Requirement2TextBox.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub Requirement3TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Requirement3TextBox.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub Requirement4TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Requirement4TextBox.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

End Class