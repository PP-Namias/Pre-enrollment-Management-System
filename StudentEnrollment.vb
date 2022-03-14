Imports System.Data.OleDb
Imports System.IO

Public Class StudentEnrollment

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


    Public Sub Subject()

        StudentRequirements.Hide()
        StudentRegistered.Hide()

        Dim newmdichild As New StudentSubject With {
            .MdiParent = Me
        }
        newmdichild.Show()

        OpenChildForm(New StudentSubject())

    End Sub

    Public Sub Requirements()

        StudentSubject.Dispose()
        StudentRegistered.Dispose()

        Dim newmdichild As New StudentRequirements With {
            .MdiParent = Me
        }
        newmdichild.Show()

        OpenChildForm(New StudentRequirements())

    End Sub

    Public Sub Registered()

        StudentSubject.Dispose()
        StudentRequirements.Dispose()

        Dim newmdichild As New StudentRegistered With {
            .MdiParent = Me
        }
        newmdichild.Show()

        OpenChildForm(New StudentRegistered())

    End Sub

    Private Sub CmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged

        If cmbStatus.Text = "Old Student" Then

            pnlOldStudent.Visible = True

        Else

            pnlOldStudent.Visible = False
            txtStudentNumber.Text = ""
            btnNext.Text = "Next"
            btnNext.BackColor = Color.Blue
            Clear()

            cmbGradeLevel.Enabled = True
            cmbStrand.Enabled = True
            cmbSemester.Enabled = True
            cmbSchoolYear.Enabled = True
            txtLastname.Enabled = True
            txtFirstname.Enabled = True
            txtMiddlename.Enabled = True
            txtAge.Enabled = True
            dtpDOB.Enabled = True
            rdoMale.Enabled = True
            rdoFemale.Enabled = True
            txtPOB.Enabled = True
            txtNationality.Enabled = True
            txtReligion.Enabled = True
            txtMobileNo.Enabled = True
            txtStudentAddress1.Enabled = True
            txtStudentAddress2.Enabled = True
            txtFatherName.Enabled = True
            txtMotherName.Enabled = True
            rdoFather.Enabled = True
            rdoMother.Enabled = True
            rdoOthers.Enabled = True
            txtGuardianName.Enabled = True
            txtGuardianContactNo.Enabled = True
            rdoMale.Checked = True
            rdoFather.Checked = True

        End If

    End Sub

    Private Sub CmbGradeLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGradeLevel.SelectedIndexChanged

        If cmbGradeLevel.Text = "Grade 11 - Senior High School" Or cmbGradeLevel.Text = "Grade 12 - Senior High School" Then

            pnlSHS.Visible = True

        Else

            pnlSHS.Visible = False

        End If

    End Sub

    Private Function RequiredEntry() As Boolean

        Try

            If cmbStatus.Text = "Old Student" Then

                If Len(Trim(txtStudentNumber.Text)) = 0 Then

                    MessageBox.Show("Please enter Student Number.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtStudentNumber.Focus()
                    Return True
                    Exit Function

                End If

            End If

            If cmbGradeLevel.Text = "Grade 11 - Senior High School" Or cmbGradeLevel.Text = "Grade 12 - Senior High School" Then

                If (Len(Trim(cmbStrand.Text)) Or Len(Trim(cmbSemester.Text))) = 0 Then

                    If Len(Trim(cmbStrand.Text)) = 0 Then

                        MessageBox.Show("Please choose a preferred strand.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        cmbStrand.Focus()
                        Return True
                        Exit Function

                    ElseIf Len(Trim(cmbSemester.Text)) = 0 Then

                        MessageBox.Show("Please choose a semester.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        cmbSemester.Focus()
                        Return True
                        Exit Function

                    End If

                End If

            End If

            If (Len(Trim(cmbStatus.Text)) Or Len(Trim(cmbGradeLevel.Text)) Or Len(Trim(cmbSchoolYear.Text)) Or Len(Trim(txtLastname.Text)) Or Len(Trim(txtFirstname.Text)) Or Len(Trim(txtAge.Text)) Or Len(Trim(txtPOB.Text)) Or Len(Trim(txtNationality.Text)) Or Len(Trim(txtReligion.Text)) Or Len(Trim(txtMobileNo.Text)) Or Len(Trim(txtStudentAddress1.Text)) Or Len(Trim(txtStudentAddress2.Text)) Or Len(Trim(txtFatherName.Text)) Or Len(Trim(txtMotherName.Text)) Or Len(Trim(txtGuardianName.Text)) Or Len(Trim(txtGuardianContactNo.Text))) = 0 Then

                MessageBox.Show("Please enter all required information.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return True
                Exit Function

            End If

        Catch ex As Exception

            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Require entry error")
            Exit Function

        End Try

    End Function

    Sub Clear()

        txtEnrollmentNo.Text = ""
        pnlOldStudent.Visible = False
        pnlSHS.Visible = False
        txtStudentNumber.Text = ""
        cmbStatus.Text = ""
        cmbStatus.Text = "New Student"
        cmbGradeLevel.Text = ""
        cmbGradeLevel.Text = "Nursery - Pre-School"
        cmbStrand.Text = ""
        cmbSemester.Text = ""
        txtLastname.Text = ""
        txtFirstname.Text = ""
        txtMiddlename.Text = ""
        txtAge.Text = ""
        rdoMale.Checked = False
        rdoFemale.Checked = False
        txtPOB.Text = ""
        txtNationality.Text = ""
        txtReligion.Text = ""
        txtEmail.Text = ""
        txtMobileNo.Text = ""
        txtTelephoneNo.Text = ""
        txtStudentAddress1.Text = ""
        txtStudentAddress2.Text = ""
        StudentPic.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Image\personal.png")
        txtFatherName.Text = ""
        txtFatherOccupation.Text = ""
        txtFatherEmail.Text = ""
        txtFatherWorkAddress.Text = ""
        txtFatherContactNo.Text = ""
        txtMotherName.Text = ""
        txtMotherOccupation.Text = ""
        txtMotherEmail.Text = ""
        txtMotherWorkAddress.Text = ""
        txtMotherContactNo.Text = ""
        txtNoOfSiblings.Text = ""
        rdoFather.Checked = False
        rdoMother.Checked = False
        rdoOthers.Checked = False
        txtGuardianName.Text = ""
        txtGuardianRelation.Text = ""
        txtGuardianEmail.Text = ""
        txtGuardianWorkAddress.Text = ""
        txtGuardianContactNo.Text = ""
        txtFetcherName.Text = ""
        txtFetcherContactNo.Text = ""
        txtSiblingsofStudent1.Text = ""
        txtSiblingsofStudent2.Text = ""
        txtSiblingsofStudent3.Text = ""
        txtSiblingsAge1.Text = ""
        txtSiblingsAge2.Text = ""
        txtSiblingsAge3.Text = ""
        txtSiblingsSchool1.Text = ""
        txtSiblingsSchool2.Text = ""
        txtSiblingsSchool3.Text = ""
        txtSchoolLastAttended1.Text = ""
        txtSchoolLastAttended2.Text = ""
        txtSchoolLastAttended3.Text = ""
        txtAcademicYear1.Text = ""
        txtAcademicYear2.Text = ""
        txtAcademicYear3.Text = ""
        txtReasonApplying.Text = ""
        rdoMale.Checked = True
        rdoFather.Checked = True

    End Sub

    Private Sub RoundButtonCheck(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 14)

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

    Private Sub RoundButtonNext(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 14)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnNext.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnNext.Region = New Region(Raduis)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox2.Visible = True

        Clear()

        If LoginForm.cmbFormState.Text <> "Admin" Then cmbStatus.Items.RemoveAt(1)

        dtpDOB.MaxDate = Today
        dtpDOB.Value = Today
        dtbIdentify.Value = Now

        rdoMale.Checked = True
        rdoFather.Checked = True

        RoundButtonCheck(btnCheck)
        RoundButtonCapture(btnCapture)
        RoundButtonBrowse(btnBrowse)
        RoundButtonRemove(btnRemove)
        RoundButtonNext(btnNext)

    End Sub

    Private Sub BtnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click

        CapturePicture.Show()
        cmbEnrollment.Text = "Enrollment"

    End Sub


    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim OpenFile As New OpenFileDialog()

        Try
            With OpenFile
                .FileName = ""
                .Title = "Photo:"
                .Filter = "Image files: (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.Gif)|*.Gif|(*.bmp)|*.bmp| All Files (*.*)|*.*"

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    StudentPic.Image = Image.FromFile(.FileName)
                End If

            End With

        Catch ex As Exception

            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
            Exit Sub

        End Try

    End Sub
    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        StudentPic.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Image\personal.png")

    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        Try

            dtbIdentify.Value = Now

            If RequiredEntry() Then Return

            If btnNext.Text = "Change" Then

                Dim ChangeConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

                If ChangeConnection.State = ConnectionState.Open Then ChangeConnection.Close()

                ChangeConnection.Open()

                Dim ChangeCommand As New OleDbCommand("Update EnrollmentData Set StudentNumber=@SNum,GradeLevel=@SGrade,Strand=@Strand,Semester=@Semester,SchoolYear=@SchoolYear,Lastname=@Lastname,Firstname=@Firstname,Middlename=@Middlename,Age=@Age,DOB=@DOB,Sex=@Sex,POB=@POB,Nationality=@Nationality,Religion=@Religion,Email=@Email,MobileNumber=@MobileNumber,TelephoneNumber=@TelephoneNumber,Address=@Address,City=@City,FatherName=@FName,FatherOccupation=@FOccupation,FatherEmail=@FEmail,FatherWorkAddress=@FWorkAddress,FatherContactNumber=@FContactNumber,MotherName=@MName,MotherOccupation=@MOccupation,MotherEmail=@MEmail,MotherWorkAddress=@MWorkAddress,MotherContactNumber=@MContactNumber,NumberOfSiblings=@NumOfSiblings,PersonEmergency=@PersonEmergency,GuardianName=@GName,GuardianRelation=@GRelation,GuardianEmail=@GEmail,GuardianWorkAddress=@GWorkAddress,GuardianContactNumber=@GContactNumber,FetcherName=@FetcherName,FetcherContactNumber=@FetcherContactNumber,SiblingsOfStudent1=@SiblingsOfStudent1,SiblingsOfStudent2=@SiblingsOfStudent2,SiblingsOfStudent3=@SiblingsOfStudent3,SiblingsOfStudentAge1=@SiblingsOfStudentAge1,SiblingsOfStudentAge2=@SiblingsOfStudentAge2,SiblingsOfStudentAge3=@SiblingsOfStudentAge3,SiblingsOfStudentSchool1=@SiblingsOfStudentSchool1,SiblingsOfStudentSchool2=@SiblingsOfStudentSchool2,SiblingsOfStudentSchool3=@SiblingsOfStudentSchool3,SchoolLastAttended1=@SchoolLastAttended1,SchoolLastAttended2=@SchoolLastAttended2,SchoolLastAttended3=@SchoolLastAttended3,AcademicYear1=@AYear1,AcademicYear2=@AYear2,AcademicYear3=@AYear3,ReasonApplying=@ReasonApplying,StudentPicture=@SPic Where (StudentNumber='" & txtStudentNumber.Text & "') ", ChangeConnection)

                ' Student Number
                Dim StudentNumber As New OleDbParameter("@SNum", OleDbType.VarWChar, 25) With {
                    .Value = txtStudentNumber.Text.ToString()
                }
                ChangeCommand.Parameters.Add(StudentNumber)

                ' Grade Level
                Dim GradeLevel As New OleDbParameter("@SGrade", OleDbType.VarWChar, 30) With {
                    .Value = cmbGradeLevel.Text.ToString()
                }
                ChangeCommand.Parameters.Add(GradeLevel)

                ' Strand
                Dim Strand As New OleDbParameter("@Strand", OleDbType.VarWChar, 70) With {
                    .Value = cmbStrand.Text.ToString()
                }
                ChangeCommand.Parameters.Add(Strand)

                ' Semester
                Dim Semester As New OleDbParameter("@Semester", OleDbType.VarWChar, 30) With {
                    .Value = cmbSemester.Text.ToString()
                }
                ChangeCommand.Parameters.Add(Semester)

                ' School Year
                Dim SchoolYear As New OleDbParameter("@SchoolYear", OleDbType.VarWChar, 30) With {
                    .Value = cmbSchoolYear.Text.ToString()
                }
                ChangeCommand.Parameters.Add(SchoolYear)

                ' Lastname
                Dim Lastname As New OleDbParameter("@Lastname", OleDbType.VarWChar, 30) With {
                    .Value = txtLastname.Text.ToString()
                }
                ChangeCommand.Parameters.Add(Lastname)

                ' Firstname
                Dim Firstname As New OleDbParameter("@Firstname", OleDbType.VarWChar, 30) With {
                    .Value = txtFirstname.Text.ToString()
                }
                ChangeCommand.Parameters.Add(Firstname)

                ' Middlename
                Dim Middlename As New OleDbParameter("@Middlename", OleDbType.VarWChar, 30) With {
                    .Value = txtMiddlename.Text.ToString()
                }
                ChangeCommand.Parameters.Add(Middlename)

                ' Age
                Dim Age As New OleDbParameter("@Age", OleDbType.VarWChar, 10) With {
                    .Value = txtAge.Text.ToString()
                }
                ChangeCommand.Parameters.Add(Age)

                ' Date of Birth
                Dim DOB As New OleDbParameter("@DOB", OleDbType.Date, 15) With {
                    .Value = dtpDOB.Text.ToString()
                }
                ChangeCommand.Parameters.Add(DOB)

                ' Sex
                Dim Sex As New OleDbParameter("@Sex", OleDbType.VarWChar, 15)
                If rdoMale.Checked Then
                    Sex.Value = rdoMale.Text.ToString()

                ElseIf rdoFemale.Checked Then
                    Sex.Value = rdoFemale.Text.ToString()

                End If
                ChangeCommand.Parameters.Add(Sex)

                ' Place of Birth
                Dim POB As New OleDbParameter("@POB", OleDbType.VarWChar, 30) With {
                    .Value = txtPOB.Text.ToString()
                }
                ChangeCommand.Parameters.Add(POB)

                ' Nationality
                Dim Nationality As New OleDbParameter("@Nationality", OleDbType.VarWChar, 30) With {
                    .Value = txtNationality.Text.ToString()
                }
                ChangeCommand.Parameters.Add(Nationality)

                ' Religion
                Dim Religion As New OleDbParameter("@Religion", OleDbType.VarWChar, 30) With {
                    .Value = txtReligion.Text.ToString()
                }
                ChangeCommand.Parameters.Add(Religion)

                ' Email
                Dim Email As New OleDbParameter("@Email", OleDbType.VarWChar, 40) With {
                    .Value = txtEmail.Text.ToString()
                }
                ChangeCommand.Parameters.Add(Email)

                ' Mobile Number
                Dim MobileNumber As New OleDbParameter("@MobileNumber", OleDbType.VarWChar, 20) With {
                    .Value = txtMobileNo.Text.ToString()
                }
                ChangeCommand.Parameters.Add(MobileNumber)

                ' Telephone Number
                Dim TelephoneNumber As New OleDbParameter("@TelephoneNumber", OleDbType.VarWChar, 20) With {
                    .Value = txtTelephoneNo.Text.ToString()
                }
                ChangeCommand.Parameters.Add(TelephoneNumber)

                ' Address
                Dim Address As New OleDbParameter("@Address", OleDbType.VarWChar, 50) With {
                    .Value = txtStudentAddress1.Text.ToString()
                }
                ChangeCommand.Parameters.Add(Address)

                ' City
                Dim City As New OleDbParameter("@City", OleDbType.VarWChar, 50) With {
                    .Value = txtStudentAddress2.Text.ToString()
                }
                ChangeCommand.Parameters.Add(City)

                ' Father Name
                Dim FatherName As New OleDbParameter("@FName", OleDbType.VarWChar, 50) With {
                    .Value = txtFatherName.Text.ToString()
                }
                ChangeCommand.Parameters.Add(FatherName)

                ' Father Occupation
                Dim Fatheroccupation As New OleDbParameter("@FOccupation", OleDbType.VarWChar, 30) With {
                    .Value = txtFatherOccupation.Text.ToString()
                }
                ChangeCommand.Parameters.Add(Fatheroccupation)

                ' Father Email
                Dim FatherEmail As New OleDbParameter("@FEmail", OleDbType.VarWChar, 40) With {
                    .Value = txtFatherEmail.Text.ToString()
                }
                ChangeCommand.Parameters.Add(FatherEmail)

                ' Father Work Address
                Dim FatherWorkAddress As New OleDbParameter("@FWorkAddress", OleDbType.VarWChar, 50) With {
                    .Value = txtFatherWorkAddress.Text.ToString()
                }
                ChangeCommand.Parameters.Add(FatherWorkAddress)

                ' Father Contact Number
                Dim FatherContactNumber As New OleDbParameter("@FContactNumber", OleDbType.VarWChar, 20) With {
                    .Value = String.Format("{0:(0#) ##-###-####}", txtFatherContactNo.Text).ToString
                }
                ChangeCommand.Parameters.Add(FatherContactNumber)

                ' Mother Name
                Dim MotherName As New OleDbParameter("@MName", OleDbType.VarWChar, 50) With {
                    .Value = txtMotherName.Text.ToString()
                }
                ChangeCommand.Parameters.Add(MotherName)

                ' Mother Occupation
                Dim Motheroccupation As New OleDbParameter("@MOccupation", OleDbType.VarWChar, 30) With {
                    .Value = txtMotherOccupation.Text.ToString()
                }
                ChangeCommand.Parameters.Add(Motheroccupation)

                ' Mother Email
                Dim MotherEmail As New OleDbParameter("@MEmail", OleDbType.VarWChar, 30) With {
                    .Value = txtMotherEmail.Text.ToString()
                }
                ChangeCommand.Parameters.Add(MotherEmail)

                ' Mother Work Address
                Dim MotherWorkAddress As New OleDbParameter("@MWorkAddress", OleDbType.VarWChar, 40) With {
                    .Value = txtMotherWorkAddress.Text.ToString()
                }
                ChangeCommand.Parameters.Add(MotherWorkAddress)

                ' Mother Contact Number
                Dim MotherContactNumber As New OleDbParameter("@MContactNumber", OleDbType.VarWChar, 20) With {
                    .Value = String.Format("{0:(0#) ##-###-####}", txtMotherContactNo.Text).ToString
                }
                ChangeCommand.Parameters.Add(MotherContactNumber)

                ' Number of Siblings
                Dim NumberOfSiblings As New OleDbParameter("@NumOfSiblings", OleDbType.VarWChar, 10) With {
                    .Value = txtNoOfSiblings.Text.ToString()
                }
                ChangeCommand.Parameters.Add(NumberOfSiblings)

                ' Person in case of Emergency
                Dim PersonEmergency As New OleDbParameter("@PersonEmergency", OleDbType.VarWChar, 15)
                If rdoFather.Checked Then
                    PersonEmergency.Value = rdoFather.Text.ToString()

                ElseIf rdoMother.Checked Then
                    PersonEmergency.Value = rdoMother.Text.ToString()

                ElseIf rdoOthers.Checked Then
                    PersonEmergency.Value = rdoOthers.Text.ToString()

                End If
                ChangeCommand.Parameters.Add(PersonEmergency)

                ' Guardian Name
                Dim GuardianName As New OleDbParameter("@GName", OleDbType.VarWChar, 50) With {
                    .Value = txtGuardianName.Text.ToString()
                }
                ChangeCommand.Parameters.Add(GuardianName)

                ' Guardian Relation
                Dim GuardianRelation As New OleDbParameter("@GRelation", OleDbType.VarWChar, 25) With {
                    .Value = txtGuardianRelation.Text.ToString()
                }
                ChangeCommand.Parameters.Add(GuardianRelation)

                ' Guardian Email
                Dim GuardianEmail As New OleDbParameter("@GEmail", OleDbType.VarWChar, 30) With {
                    .Value = txtGuardianEmail.Text.ToString()
                }
                ChangeCommand.Parameters.Add(GuardianEmail)

                ' Guardian Work Address
                Dim GuardianWorkAddress As New OleDbParameter("@GWorkAddress", OleDbType.VarWChar, 40) With {
                    .Value = txtGuardianWorkAddress.Text.ToString()
                }
                ChangeCommand.Parameters.Add(GuardianWorkAddress)

                ' Guardian Contact Number
                Dim GuardianContactNumber As New OleDbParameter("@GContactNumber", OleDbType.VarWChar, 20) With {
                    .Value = String.Format("{0:(0#) ##-###-####}", txtGuardianContactNo.Text).ToString
                }
                ChangeCommand.Parameters.Add(GuardianContactNumber)

                ' Fetcher Name
                Dim FetcherName As New OleDbParameter("@FetcherName", OleDbType.VarWChar, 50) With {
                    .Value = txtFetcherName.Text.ToString()
                }
                ChangeCommand.Parameters.Add(FetcherName)

                ' Fetcher Contact Number
                Dim FetcherContactNumber As New OleDbParameter("@FetcherContactNumber", OleDbType.VarWChar, 20) With {
                    .Value = String.Format("{0:(0#) ##-###-####}", txtFetcherContactNo.Text).ToString
                }
                ChangeCommand.Parameters.Add(FetcherContactNumber)

                ' Siblings of Student1
                Dim SiblingsOfStudent1 As New OleDbParameter("@SiblingsOfStudent1", OleDbType.VarWChar, 50) With {
                    .Value = txtSiblingsofStudent1.Text.ToString()
                }
                ChangeCommand.Parameters.Add(SiblingsOfStudent1)

                ' Siblings of Student2
                Dim SiblingsOfStudent2 As New OleDbParameter("@SiblingsOfStudent2", OleDbType.VarWChar, 50) With {
                    .Value = txtSiblingsofStudent1.Text.ToString()
                }
                ChangeCommand.Parameters.Add(SiblingsOfStudent2)

                ' Siblings of Student3
                Dim SiblingsOfStudent3 As New OleDbParameter("@dSiblingsOfStudent340", OleDbType.VarWChar, 50) With {
                    .Value = txtSiblingsofStudent1.Text.ToString()
                }
                ChangeCommand.Parameters.Add(SiblingsOfStudent3)

                ' Siblings of StudentAge1
                Dim SiblingsOfStudentAge1 As New OleDbParameter("@SiblingsOfStudentAge1", OleDbType.VarWChar, 10) With {
                .Value = txtSiblingsAge1.Text.ToString()
                }
                ChangeCommand.Parameters.Add(SiblingsOfStudentAge1)

                ' Siblings of StudentAge2
                Dim SiblingsOfStudentAge2 As New OleDbParameter("@SiblingsOfStudentAge2", OleDbType.VarWChar, 10) With {
                    .Value = txtSiblingsAge2.Text.ToString()
                }
                ChangeCommand.Parameters.Add(SiblingsOfStudentAge2)

                ' Siblings of StudentAge3
                Dim SiblingsOfStudentAge3 As New OleDbParameter("@SiblingsOfStudentAge3", OleDbType.VarWChar, 10) With {
                    .Value = txtSiblingsAge3.Text.ToString()
                }
                ChangeCommand.Parameters.Add(SiblingsOfStudentAge3)

                ' Siblings of StudentSchool1
                Dim SiblingsOfStudentSchool1 As New OleDbParameter("@SiblingsOfStudentSchool1", OleDbType.VarWChar, 40) With {
                    .Value = txtSiblingsSchool1.Text.ToString()
                }
                ChangeCommand.Parameters.Add(SiblingsOfStudentSchool1)

                ' Siblings of StudentSchool2
                Dim SiblingsOfStudentSchool2 As New OleDbParameter("@SiblingsOfStudentSchool2", OleDbType.VarWChar, 40) With {
                    .Value = txtSiblingsSchool2.Text.ToString()
                }
                ChangeCommand.Parameters.Add(SiblingsOfStudentSchool2)

                ' Siblings of StudentSchool3
                Dim SiblingsOfStudentSchool3 As New OleDbParameter("@SiblingsOfStudentSchool3", OleDbType.VarWChar, 40) With {
                    .Value = txtSiblingsSchool3.Text.ToString()
                }
                ChangeCommand.Parameters.Add(SiblingsOfStudentSchool3)

                ' School Last Attended1
                Dim SchoolLastAttended1 As New OleDbParameter("@SchoolLastAttended1", OleDbType.VarWChar, 50) With {
                    .Value = txtSchoolLastAttended1.Text.ToString()
                }
                ChangeCommand.Parameters.Add(SchoolLastAttended1)

                ' School Last Attended2
                Dim SchoolLastAttended2 As New OleDbParameter("@SchoolLastAttended2", OleDbType.VarWChar, 50) With {
                    .Value = txtSchoolLastAttended2.Text.ToString()
                }
                ChangeCommand.Parameters.Add(SchoolLastAttended2)

                ' School Last Attended3
                Dim SchoolLastAttended3 As New OleDbParameter("@SchoolLastAttended3", OleDbType.VarWChar, 50) With {
                    .Value = txtSchoolLastAttended3.Text.ToString()
                }
                ChangeCommand.Parameters.Add(SchoolLastAttended3)

                ' Academic Year1
                Dim AcademicYear1 As New OleDbParameter("@AcademicYear1", OleDbType.VarWChar, 20) With {
                    .Value = txtAcademicYear1.Text.ToString()
                }
                ChangeCommand.Parameters.Add(AcademicYear1)

                ' Academic Year2
                Dim AcademicYear2 As New OleDbParameter("@AcademicYear2", OleDbType.VarWChar, 20) With {
                    .Value = txtAcademicYear2.Text.ToString()
                }
                ChangeCommand.Parameters.Add(AcademicYear2)

                ' Academic Year3
                Dim AcademicYear3 As New OleDbParameter("@AcademicYear3", OleDbType.VarWChar, 20) With {
                    .Value = txtAcademicYear3.Text.ToString()
                }
                ChangeCommand.Parameters.Add(AcademicYear3)

                ' Reason for Applying
                Dim ReasonApplying As New OleDbParameter("@ReasonApplying", OleDbType.VarWChar, 500) With {
                    .Value = txtReasonApplying.Text.ToString()
                }
                ChangeCommand.Parameters.Add(ReasonApplying)

                Dim MemStream As New MemoryStream
                Dim StudentPic_Update As Byte()

                StudentPic.Image.Save(MemStream, Imaging.ImageFormat.Png)
                StudentPic_Update = MemStream.GetBuffer()
                MemStream.Read(StudentPic_Update, 0, MemStream.Length)

                ' image content
                Dim StudentIDPic As New OleDbParameter("@SPic", SqlDbType.Image) With {
                    .Value = StudentPic_Update
                }
                ChangeCommand.Parameters.Add(StudentIDPic)


                If ChangeCommand.ExecuteNonQuery() Then

                    ChangeConnection.Close()

                    MsgBox("Your info updated successfully... ", MsgBoxStyle.Information, "Record Updated")

                    PictureBox1.Visible = False
                    Panel1.Visible = False
                    PictureBox2.Visible = False
                    btnNext.Text = " Change "
                    Subject()

                Else

                    MsgBox("Your info modification failed ", MsgBoxStyle.Critical, "Change Failed")
                    Return

                End If

            ElseIf btnNext.Text = "Next" Then

                Dim NextConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

                If NextConnection.State = ConnectionState.Open Then NextConnection.Close()

                NextConnection.Open()

                Dim NextString As String = "insert into EnrollmentData(StudentNumber,GradeLevel,Strand,Semester,SchoolYear,Lastname,Firstname,Middlename,Age,DOB,Sex,POB,Nationality,Religion,Email,MobileNumber,TelephoneNumber,Address,City,FatherName,FatherOccupation,FatherEmail,FatherWorkAddress,FatherContactNumber,MotherName,MotherOccupation,MotherEmail,MotherWorkAddress,MotherContactNumber,NumberOfSiblings,PersonEmergency,GuardianName,GuardianRelation,GuardianEmail,GuardianWorkAddress,GuardianContactNumber,FetcherName,FetcherContactNumber,SiblingsOfStudent1,SiblingsOfStudent2,SiblingsOfStudent3,SiblingsOfStudentAge1,SiblingsOfStudentAge2,SiblingsOfStudentAge3,SiblingsOfStudentSchool1,SiblingsOfStudentSchool2,SiblingsOfStudentSchool3,SchoolLastAttended1,SchoolLastAttended2,SchoolLastAttended3,AcademicYear1,AcademicYear2,AcademicYear3,ReasonApplying,Identifier,StudentPicture,Status) values(@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16,@d17,@d18,@d19,@d20,@d21,@d22,@d23,@d24,@d25,@d26,@d27,@d28,@d29,@d30,@d31,@d32,@d33,@d34,@d35,@d36,@d37,@d38,@d39,@d40,@d41,@d42,@d43,@d44,@d45,@d46,@d47,@d48,@d49,@d50,@d51,@d52,@d53,@d54,@d55,@d56,@d57)"
                Dim NextCommand As New OleDbCommand(NextString, NextConnection)

                ' Student Number  
                Dim StudentNumber As New OleDbParameter("@d1", OleDbType.VarWChar, 30) With {
                    .Value = txtStudentNumber.Text.ToString()
                }
                NextCommand.Parameters.Add(StudentNumber)

                ' Grade Level
                Dim GradeLevel As New OleDbParameter("@d2", OleDbType.VarWChar, 30) With {
                    .Value = cmbGradeLevel.Text.ToString()
                }
                NextCommand.Parameters.Add(GradeLevel)

                ' Strand
                Dim Strand As New OleDbParameter("@d3", OleDbType.VarWChar, 70) With {
                    .Value = cmbStrand.Text.ToString()
                }
                NextCommand.Parameters.Add(Strand)

                ' Semester
                Dim Semester As New OleDbParameter("@d4", OleDbType.VarWChar, 30) With {
                    .Value = cmbSemester.Text.ToString()
                }
                NextCommand.Parameters.Add(Semester)

                ' School Year
                Dim SchoolYear As New OleDbParameter("@d5", OleDbType.VarWChar, 30) With {
                    .Value = cmbSchoolYear.Text.ToString()
                }
                NextCommand.Parameters.Add(SchoolYear)

                ' Lastname
                Dim Lastname As New OleDbParameter("@d6", OleDbType.VarWChar, 30) With {
                    .Value = txtLastname.Text.ToString()
                }
                NextCommand.Parameters.Add(Lastname)

                ' Firstname
                Dim Firstname As New OleDbParameter("@d7", OleDbType.VarWChar, 30) With {
                    .Value = txtFirstname.Text.ToString()
                }
                NextCommand.Parameters.Add(Firstname)

                ' Middlename
                Dim Middlename As New OleDbParameter("@d8", OleDbType.VarWChar, 30) With {
                    .Value = txtMiddlename.Text.ToString()
                }
                NextCommand.Parameters.Add(Middlename)

                ' Age
                Dim Age As New OleDbParameter("@d9", OleDbType.VarWChar, 10) With {
                    .Value = txtAge.Text.ToString()
                }
                NextCommand.Parameters.Add(Age)

                ' Date of Birth
                Dim DOB As New OleDbParameter("@d10", OleDbType.Date, 15) With {
                    .Value = dtpDOB.Text.ToString()
                }
                NextCommand.Parameters.Add(DOB)

                ' Sex
                Dim Sex As New OleDbParameter("@d11", OleDbType.VarWChar, 15)
                If rdoMale.Checked Then
                    Sex.Value = rdoMale.Text.ToString()

                ElseIf rdoFemale.Checked Then
                    Sex.Value = rdoFemale.Text.ToString()

                End If
                NextCommand.Parameters.Add(Sex)

                ' Place of Birth
                Dim POB As New OleDbParameter("@d12", OleDbType.VarWChar, 30) With {
                    .Value = txtPOB.Text.ToString()
                }
                NextCommand.Parameters.Add(POB)

                ' Nationality
                Dim Nationality As New OleDbParameter("@d13", OleDbType.VarWChar, 30) With {
                    .Value = txtNationality.Text.ToString()
                }
                NextCommand.Parameters.Add(Nationality)

                ' Religion
                Dim Religion As New OleDbParameter("@d14", OleDbType.VarWChar, 30) With {
                    .Value = txtReligion.Text.ToString()
                }
                NextCommand.Parameters.Add(Religion)

                ' Email
                Dim Email As New OleDbParameter("@d15", OleDbType.VarWChar, 40) With {
                    .Value = txtEmail.Text.ToString()
                }
                NextCommand.Parameters.Add(Email)

                ' Mobile Number
                Dim MobileNumber As New OleDbParameter("@d16", OleDbType.VarWChar, 20) With {
                    .Value = String.Format("{0:(0#) ##-###-####}", txtMobileNo.Text).ToString
                }
                NextCommand.Parameters.Add(MobileNumber)

                ' Telephone Number
                Dim TelephoneNumber As New OleDbParameter("@d17", OleDbType.VarWChar, 20) With {
                    .Value = txtTelephoneNo.Text.ToString()
                }
                NextCommand.Parameters.Add(TelephoneNumber)

                ' Address
                Dim Address As New OleDbParameter("@d18", OleDbType.VarWChar, 50) With {
                    .Value = txtStudentAddress1.Text.ToString()
                }
                NextCommand.Parameters.Add(Address)

                ' City
                Dim City As New OleDbParameter("@d19", OleDbType.VarWChar, 50) With {
                    .Value = txtStudentAddress2.Text.ToString()
                }
                NextCommand.Parameters.Add(City)

                ' Father Name
                Dim FatherName As New OleDbParameter("@d20", OleDbType.VarWChar, 50) With {
                    .Value = txtFatherName.Text.ToString()
                }
                NextCommand.Parameters.Add(FatherName)

                ' Father Occupation
                Dim Fatheroccupation As New OleDbParameter("@d21", OleDbType.VarWChar, 30) With {
                    .Value = txtFatherOccupation.Text.ToString()
                }
                NextCommand.Parameters.Add(Fatheroccupation)

                ' Father Email
                Dim FatherEmail As New OleDbParameter("@d22", OleDbType.VarWChar, 40) With {
                    .Value = txtFatherEmail.Text.ToString()
                }
                NextCommand.Parameters.Add(FatherEmail)

                ' Father Work Address
                Dim FatherWorkAddress As New OleDbParameter("@d23", OleDbType.VarWChar, 50) With {
                    .Value = txtFatherWorkAddress.Text.ToString()
                }
                NextCommand.Parameters.Add(FatherWorkAddress)

                ' Father Contact Number
                Dim FatherContactNumber As New OleDbParameter("@d24", OleDbType.VarWChar, 20) With {
                    .Value = String.Format("{0:(0#) ##-###-####}", txtFatherContactNo.Text).ToString
                }
                NextCommand.Parameters.Add(FatherContactNumber)

                ' Mother Name
                Dim MotherName As New OleDbParameter("@d25", OleDbType.VarWChar, 50) With {
                    .Value = txtMotherName.Text.ToString()
                }
                NextCommand.Parameters.Add(MotherName)

                ' Mother Occupation
                Dim Motheroccupation As New OleDbParameter("@d26", OleDbType.VarWChar, 30) With {
                    .Value = txtMotherOccupation.Text.ToString()
                }
                NextCommand.Parameters.Add(Motheroccupation)

                ' Mother Email
                Dim MotherEmail As New OleDbParameter("@d27", OleDbType.VarWChar, 30) With {
                    .Value = txtMotherEmail.Text.ToString()
                }
                NextCommand.Parameters.Add(MotherEmail)

                ' Mother Work Address
                Dim MotherWorkAddress As New OleDbParameter("@d28", OleDbType.VarWChar, 40) With {
                    .Value = txtMotherWorkAddress.Text.ToString()
                }
                NextCommand.Parameters.Add(MotherWorkAddress)

                ' Mother Contact Number
                Dim MotherContactNumber As New OleDbParameter("@d29", OleDbType.VarWChar, 20) With {
                    .Value = String.Format("{0:(0#) ##-###-####}", txtMotherContactNo.Text).ToString
                }
                NextCommand.Parameters.Add(MotherContactNumber)

                ' Number of Siblings
                Dim NumberOfSiblings As New OleDbParameter("@d30", OleDbType.VarWChar, 10) With {
                    .Value = txtNoOfSiblings.Text.ToString()
                }
                NextCommand.Parameters.Add(NumberOfSiblings)

                ' Person in case of Emergency
                Dim PersonEmergency As New OleDbParameter("@d31", OleDbType.VarWChar, 15)
                If rdoFather.Checked Then
                    PersonEmergency.Value = rdoFather.Text.ToString()

                ElseIf rdoMother.Checked Then
                    PersonEmergency.Value = rdoMother.Text.ToString()

                ElseIf rdoOthers.Checked Then
                    PersonEmergency.Value = rdoOthers.Text.ToString()

                End If
                NextCommand.Parameters.Add(PersonEmergency)

                ' Guardian Name
                Dim GuardianName As New OleDbParameter("@d32", OleDbType.VarWChar, 50) With {
                    .Value = txtGuardianName.Text.ToString()
                }
                NextCommand.Parameters.Add(GuardianName)

                ' Guardian Relation
                Dim GuardianRelation As New OleDbParameter("@d33", OleDbType.VarWChar, 25) With {
                    .Value = txtGuardianRelation.Text.ToString()
                }
                NextCommand.Parameters.Add(GuardianRelation)

                ' Guardian Email
                Dim GuardianEmail As New OleDbParameter("@d34", OleDbType.VarWChar, 30) With {
                    .Value = txtGuardianEmail.Text.ToString()
                }
                NextCommand.Parameters.Add(GuardianEmail)

                ' Guardian Work Address
                Dim GuardianWorkAddress As New OleDbParameter("@d35", OleDbType.VarWChar, 40) With {
                    .Value = txtGuardianWorkAddress.Text.ToString()
                }
                NextCommand.Parameters.Add(GuardianWorkAddress)

                ' Guardian Contact Number
                Dim GuardianContactNumber As New OleDbParameter("@d36", OleDbType.VarWChar, 20) With {
                    .Value = String.Format("{0:(0#) ##-###-####}", txtGuardianContactNo.Text).ToString
                }
                NextCommand.Parameters.Add(GuardianContactNumber)

                ' Fetcher Name
                Dim FetcherName As New OleDbParameter("@d37", OleDbType.VarWChar, 50) With {
                    .Value = txtFetcherName.Text.ToString()
                }
                NextCommand.Parameters.Add(FetcherName)

                ' Fetcher Contact Number
                Dim FetcherContactNumber As New OleDbParameter("@d38", OleDbType.VarWChar, 20) With {
                    .Value = String.Format("{0:(0#) ##-###-####}", txtFetcherContactNo.Text).ToString
                }
                NextCommand.Parameters.Add(FetcherContactNumber)

                ' Siblings of Student 1
                Dim SiblingsOfStudent1 As New OleDbParameter("@d39", OleDbType.VarWChar, 50) With {
                    .Value = txtSiblingsofStudent1.Text.ToString()
                }
                NextCommand.Parameters.Add(SiblingsOfStudent1)

                ' Siblings of Student 2
                Dim SiblingsOfStudent2 As New OleDbParameter("@d40", OleDbType.VarWChar, 50) With {
                    .Value = txtSiblingsofStudent1.Text.ToString()
                }
                NextCommand.Parameters.Add(SiblingsOfStudent2)

                ' Siblings of Student 3
                Dim SiblingsOfStudent3 As New OleDbParameter("@d41", OleDbType.VarWChar, 50) With {
                    .Value = txtSiblingsofStudent1.Text.ToString()
                }
                NextCommand.Parameters.Add(SiblingsOfStudent3)

                ' Siblings of StudentAge 1
                Dim SiblingsOfStudentAge1 As New OleDbParameter("@d42", OleDbType.VarWChar, 10) With {
                    .Value = txtSiblingsAge1.Text.ToString()
                }
                NextCommand.Parameters.Add(SiblingsOfStudentAge1)

                ' Siblings of StudentAge 2
                Dim SiblingsOfStudentAge2 As New OleDbParameter("@d43", OleDbType.VarWChar, 10) With {
                    .Value = txtSiblingsAge2.Text.ToString()
                }
                NextCommand.Parameters.Add(SiblingsOfStudentAge2)

                ' Siblings of StudentAge 3
                Dim SiblingsOfStudentAge3 As New OleDbParameter("@d44", OleDbType.VarWChar, 10) With {
                    .Value = txtSiblingsAge3.Text.ToString()
                }
                NextCommand.Parameters.Add(SiblingsOfStudentAge3)

                ' Siblings of StudentSchool 1
                Dim SiblingsOfStudentSchool1 As New OleDbParameter("@d45", OleDbType.VarWChar, 40) With {
                    .Value = txtSiblingsSchool1.Text.ToString()
                }
                NextCommand.Parameters.Add(SiblingsOfStudentSchool1)

                ' Siblings of StudentSchool 2
                Dim SiblingsOfStudentSchool2 As New OleDbParameter("@d46", OleDbType.VarWChar, 40) With {
                    .Value = txtSiblingsSchool2.Text.ToString()
                }
                NextCommand.Parameters.Add(SiblingsOfStudentSchool2)

                ' Siblings of StudentSchool 3
                Dim SiblingsOfStudentSchool3 As New OleDbParameter("@d47", OleDbType.VarWChar, 40) With {
                    .Value = txtSiblingsSchool3.Text.ToString()
                }
                NextCommand.Parameters.Add(SiblingsOfStudentSchool3)

                ' School Last Attended 1
                Dim SchoolLastAttended1 As New OleDbParameter("@d48", OleDbType.VarWChar, 50) With {
                    .Value = txtSchoolLastAttended1.Text.ToString()
                }
                NextCommand.Parameters.Add(SchoolLastAttended1)

                ' School Last Attended 2
                Dim SchoolLastAttended2 As New OleDbParameter("@d49", OleDbType.VarWChar, 50) With {
                    .Value = txtSchoolLastAttended2.Text.ToString()
                }
                NextCommand.Parameters.Add(SchoolLastAttended2)

                ' School Last Attended 3
                Dim SchoolLastAttended3 As New OleDbParameter("@d50", OleDbType.VarWChar, 50) With {
                    .Value = txtSchoolLastAttended3.Text.ToString()
                }
                NextCommand.Parameters.Add(SchoolLastAttended3)

                ' Academic Year 1
                Dim AcademicYear1 As New OleDbParameter("@d51", OleDbType.VarWChar, 20) With {
                    .Value = txtAcademicYear1.Text.ToString()
                }
                NextCommand.Parameters.Add(AcademicYear1)

                ' Academic Year 2
                Dim AcademicYear2 As New OleDbParameter("@d52", OleDbType.VarWChar, 20) With {
                    .Value = txtAcademicYear2.Text.ToString()
                }
                NextCommand.Parameters.Add(AcademicYear2)

                ' Academic Year 3 
                Dim AcademicYear3 As New OleDbParameter("@d53", OleDbType.VarWChar, 20) With {
                    .Value = txtAcademicYear3.Text.ToString()
                }
                NextCommand.Parameters.Add(AcademicYear3)

                ' Reason for Applying
                Dim ReasonApplying As New OleDbParameter("@d54", OleDbType.VarWChar, 500) With {
                    .Value = txtReasonApplying.Text.ToString()
                }
                NextCommand.Parameters.Add(ReasonApplying)

                'Identifier (for sequencial forms)
                Dim Identifier As New OleDbParameter("@d55", OleDbType.Date, 45) With {
                     .Value = dtbIdentify.Text.ToString()
                }
                NextCommand.Parameters.Add(Identifier)

                Dim MemStream As New MemoryStream
                Dim StudentPic_Upload As Byte()

                StudentPic.Image.Save(MemStream, Imaging.ImageFormat.Png)
                StudentPic_Upload = MemStream.GetBuffer()
                MemStream.Read(StudentPic_Upload, 0, MemStream.Length)

                ' Student ID Picture
                Dim StudentPicture As New OleDbParameter("@d56", SqlDbType.Image) With {
                    .Value = StudentPic_Upload
                }
                NextCommand.Parameters.Add(StudentPicture)

                ' Status
                Dim Status As New OleDbParameter("@d57", OleDbType.VarWChar, 30) With {
                    .Value = "reserved"
                }
                NextCommand.Parameters.Add(Status)

                If NextCommand.ExecuteNonQuery() Then

                    Try

                        NextConnection.Close()
                        MsgBox("New student pre-enrolled successfully.", MsgBoxStyle.Information, "Successfully pre-enrolled!")

                        Dim NameConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")
                        Dim NameDataReader As OleDbDataReader
                        Dim NameCommand As New OleDbCommand

                        If NameConnection.State = ConnectionState.Open Then NameConnection.Close()
                        NameConnection.Open()

                        NameCommand.CommandText = "SELECT [Lastname],[Firstname],[Middlename],[EnrollmentNumber] FROM EnrollmentData WHERE Lastname = '" & txtLastname.Text & "' AND Firstname = '" & txtFirstname.Text & "' AND Middlename = '" & txtMiddlename.Text & "'"
                        NameCommand.Connection = NameConnection
                        NameDataReader = NameCommand.ExecuteReader

                        If NameDataReader.Read Then

                            txtEnrollmentNo.Text = NameDataReader("EnrollmentNumber")

                            PictureBox1.Visible = False
                            Panel1.Visible = False
                            PictureBox2.Visible = False

                            btnNext.Text = " Change "

                            Subject()

                        End If

                        NameConnection.Close()
                        NameDataReader.Close()

                        Return

                    Catch ex As Exception

                        MessageBox.Show(ex.Message.ToString(), "Data Error")
                        Exit Sub

                    End Try

                Else

                    MsgBox("New Student enrollment failed.", MsgBoxStyle.Critical, "Enrollment failed")
                    Return

                End If


            ElseIf btnNext.Text = " Next " Then

                StudentSubject.Dispose()
                Subject()

            ElseIf btnNext.Text = " Change " Then

                StudentSubject.Dispose()
                Subject()

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message.ToString(), "Enrollment Error")
            Exit Sub

        End Try

    End Sub

    Private Sub TxtStudentNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudentNumber.KeyPress

        'Allowed Numbers and "-" only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 45 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtLastname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastname.KeyPress

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtFirstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstname.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtMiddlename_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMiddlename.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtPOB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPOB.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtNationality_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNationality.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtReligion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReligion.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtMobileNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMobileNo.KeyPress
        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtTelephoneNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelephoneNo.KeyPress
        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtStudentAddress1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudentAddress1.KeyPress

        'Allowed Letters, Number and "." only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "~`@#$%^&*()_-+={[}]:;',!><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtStudentAddress2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudentAddress2.KeyPress

        'Allowed Letters, Number and "." only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "~`@#$%^&*()_-+={[}]:;',!><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtFatherName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFatherName.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtFatherOccupation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFatherOccupation.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtFatherEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFatherEmail.KeyPress

        'Allowed all

    End Sub

    Private Sub TxtFatherWorkAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFatherWorkAddress.KeyPress

        'Allowed Letters, Number and "." only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "~`@#$%^&*()_-+={[}]:;',!><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtFatherContactNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFatherContactNo.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtMotherName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMotherName.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtMotherOccupation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMotherOccupation.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtMotherEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMotherEmail.KeyPress

        'Allowed all

    End Sub

    Private Sub TxtMotherWorkAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMotherWorkAddress.KeyPress

        'Allowed Letters, Number and "." only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "~`@#$%^&*()_-+={[}]:;',!><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtMotherContactNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMotherContactNo.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtNoOfSiblings_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoOfSiblings.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtGuardianName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGuardianName.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtGuardianRelation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGuardianRelation.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtGuardianEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGuardianEmail.KeyPress

        'Allowed all

    End Sub

    Private Sub TxtGuardianWorkAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGuardianWorkAddress.KeyPress

        'Allowed Letters, Number and "." only
        If e.KeyChar <> ControlChars.Back Then

            Dim NotAllowed As String = "~`@#$%^&*()_-+={[}]:;',!><?/|\"
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtGuardianContactNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGuardianContactNo.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtFetcherName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFetcherName.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtFetcherContactNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFetcherContactNo.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtSiblingsofStudent1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSiblingsofStudent1.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtSiblingsofStudent2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSiblingsofStudent2.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtSiblingsofStudent3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSiblingsofStudent3.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtSiblingsAge1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSiblingsAge1.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtSiblingsAge2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSiblingsAge2.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtSiblingsAge3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSiblingsAge3.KeyPress

        'Allowed Numbers only
        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtSiblingsSchool1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSiblingsSchool1.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtSiblingsSchool2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSiblingsSchool2.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtSiblingsSchool3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSiblingsSchool3.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtSchoolLastAttended1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSchoolLastAttended1.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtSchoolLastAttended2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSchoolLastAttended2.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtSchoolLastAttended3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSchoolLastAttended3.KeyPress

        'Allowed Letters only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtAcademicYear1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAcademicYear1.KeyPress

        'Allowed Numbers and "-" only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 45 And Asc(e.KeyChar) <> 32 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtAcademicYear2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAcademicYear2.KeyPress

        'Allowed Numbers and "-" only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 45 And Asc(e.KeyChar) <> 32 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtAcademicYear3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAcademicYear3.KeyPress

        'Allowed Numbers and "-" only
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 45 And Asc(e.KeyChar) <> 32 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub TxtReasonApplying_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReasonApplying.KeyPress

        'Allowed all

    End Sub

    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        Try

            Dim dbConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")
            Dim dbDataReader As OleDbDataReader
            Dim dbCommand As New OleDbCommand

            btnNext.Text = "Change"
            btnNext.BackColor = Color.Green

            If dbConnection.State = ConnectionState.Open Then dbConnection.Close()

            dbConnection.Open()
            dbCommand.CommandText = "select [StudentPicture],[StudentNumber],[GradeLevel],[Strand],[Semester],[Lastname],[Firstname],[Middlename],[Age],[DOB],[Sex],[POB],[Nationality],[Religion],[Email],[MobileNumber],[TelephoneNumber],[Address],[City],[FatherName],[FatherOccupation],[FatherEmail],[FatherWorkAddress],[FatherContactNumber],[MotherName],[MotherOccupation],[MotherEmail],[MotherWorkAddress],[MotherContactNumber],[NumberOfSiblings],[PersonEmergency],[GuardianName],[GuardianRelation],[GuardianEmail],[GuardianWorkAddress],[GuardianContactNumber],[FetcherName],[FetcherContactNumber],[SiblingsOfStudent1],[SiblingsOfStudent2],[SiblingsOfStudent3],[SiblingsOfStudentAge1],[SiblingsOfStudentAge2],[SiblingsOfStudentAge3],[SiblingsOfStudentSchool1],[SiblingsOfStudentSchool2],[SiblingsOfStudentSchool3],[SchoolLastAttended1],[SchoolLastAttended2],[SchoolLastAttended3],[AcademicYear1],[AcademicYear2],[AcademicYear3],[SchoolYear],[ReasonApplying] from EnrollmentData where StudentNumber = '" & txtStudentNumber.Text & "'"
            dbCommand.Connection = dbConnection
            dbDataReader = dbCommand.ExecuteReader

            If dbDataReader.Read Then

                Dim x As Byte() = dbDataReader(0)
                Dim ms As New MemoryStream(x)
                StudentPic.Image = Image.FromStream(ms)
                txtStudentNumber.Text = dbDataReader(1).ToString()
                cmbGradeLevel.Text = dbDataReader(2).ToString()
                cmbStrand.Text = dbDataReader(3).ToString()
                cmbSemester.Text = dbDataReader(4).ToString()
                txtLastname.Text = dbDataReader(5).ToString()
                txtFirstname.Text = dbDataReader(6).ToString()
                txtMiddlename.Text = dbDataReader(7).ToString()
                txtAge.Text = dbDataReader(8).ToString()
                dtpDOB.Value = dbDataReader(9).ToString()
                If dbDataReader(10).ToString() = "Male" Then
                    rdoMale.Checked = True

                ElseIf dbDataReader(10).ToString() = "Female" Then
                    rdoFemale.Checked = True

                End If
                txtPOB.Text = dbDataReader(11).ToString()
                txtNationality.Text = dbDataReader(12).ToString()
                txtReligion.Text = dbDataReader(13).ToString()
                txtEmail.Text = dbDataReader(14).ToString()
                txtMobileNo.Text = dbDataReader(15).ToString()
                txtTelephoneNo.Text = dbDataReader(16).ToString()
                txtStudentAddress1.Text = dbDataReader(17).ToString()
                txtStudentAddress2.Text = dbDataReader(18).ToString()
                txtFatherName.Text = dbDataReader(19).ToString()
                txtFatherOccupation.Text = dbDataReader(20).ToString()
                txtFatherEmail.Text = dbDataReader(21).ToString()
                txtFatherWorkAddress.Text = dbDataReader(22).ToString()
                txtFatherContactNo.Text = dbDataReader(23).ToString()
                txtMotherName.Text = dbDataReader(24).ToString()
                txtMotherOccupation.Text = dbDataReader(25).ToString()
                txtMotherEmail.Text = dbDataReader(26).ToString()
                txtMotherWorkAddress.Text = dbDataReader(27).ToString()
                txtMotherContactNo.Text = dbDataReader(28).ToString()
                txtNoOfSiblings.Text = dbDataReader(29).ToString()
                If dbDataReader(30).ToString() = "Father" Then
                    rdoFather.Checked = True

                ElseIf dbDataReader(30).ToString() = "Mother" Then
                    rdoMother.Checked = True

                ElseIf dbDataReader(30).ToString() = "Others" Then
                    rdoOthers.Checked = True

                End If
                txtGuardianName.Text = dbDataReader(31).ToString()
                txtGuardianRelation.Text = dbDataReader(32).ToString()
                txtGuardianEmail.Text = dbDataReader(33).ToString()
                txtGuardianWorkAddress.Text = dbDataReader(34).ToString()
                txtGuardianContactNo.Text = dbDataReader(35).ToString()
                txtFetcherName.Text = dbDataReader(36).ToString()
                txtFetcherContactNo.Text = dbDataReader(37).ToString()
                txtSiblingsofStudent1.Text = dbDataReader(38).ToString()
                txtSiblingsofStudent2.Text = dbDataReader(39).ToString()
                txtSiblingsofStudent3.Text = dbDataReader(40).ToString()
                txtSiblingsAge1.Text = dbDataReader(41).ToString()
                txtSiblingsAge2.Text = dbDataReader(42).ToString()
                txtSiblingsAge3.Text = dbDataReader(43).ToString()
                txtSiblingsSchool1.Text = dbDataReader(44).ToString()
                txtSiblingsSchool2.Text = dbDataReader(45).ToString()
                txtSiblingsSchool3.Text = dbDataReader(46).ToString()
                txtSchoolLastAttended1.Text = dbDataReader(47).ToString()
                txtSchoolLastAttended2.Text = dbDataReader(48).ToString()
                txtSchoolLastAttended3.Text = dbDataReader(49).ToString()
                txtAcademicYear1.Text = dbDataReader(50).ToString()
                txtAcademicYear2.Text = dbDataReader(51).ToString()
                txtAcademicYear3.Text = dbDataReader(52).ToString()
                cmbSchoolYear.Text = dbDataReader(53).ToString()
                txtReasonApplying.Text = dbDataReader(54).ToString()

                cmbGradeLevel.Enabled = False
                cmbStrand.Enabled = False
                cmbSemester.Enabled = False
                cmbSchoolYear.Enabled = False
                txtLastname.Enabled = False
                txtFirstname.Enabled = False
                txtMiddlename.Enabled = False
                txtAge.Enabled = False
                dtpDOB.Enabled = False
                rdoMale.Enabled = False
                rdoFemale.Enabled = False
                txtPOB.Enabled = False
                txtNationality.Enabled = False
                txtReligion.Enabled = False
                txtMobileNo.Enabled = False
                txtStudentAddress1.Enabled = False
                txtStudentAddress2.Enabled = False
                txtFatherName.Enabled = False
                txtMotherName.Enabled = False
                rdoFather.Enabled = False
                rdoMother.Enabled = False
                rdoOthers.Enabled = False
                txtGuardianName.Enabled = False
                txtGuardianContactNo.Enabled = False

                cmbGradeLevel.BackColor = Color.White
                cmbStrand.BackColor = Color.White
                cmbSemester.BackColor = Color.White
                cmbSchoolYear.BackColor = Color.White
                txtLastname.BackColor = Color.White
                txtFirstname.BackColor = Color.White
                txtMiddlename.BackColor = Color.White
                txtAge.BackColor = Color.White
                dtpDOB.BackColor = Color.White
                rdoMale.BackColor = Color.White
                rdoFemale.BackColor = Color.White
                txtPOB.BackColor = Color.White
                txtNationality.BackColor = Color.White
                txtReligion.BackColor = Color.White
                txtMobileNo.BackColor = Color.White
                txtStudentAddress1.BackColor = Color.White
                txtStudentAddress2.BackColor = Color.White
                txtFatherName.BackColor = Color.White
                txtMotherName.BackColor = Color.White
                rdoFather.BackColor = Color.White
                rdoMother.BackColor = Color.White
                rdoOthers.BackColor = Color.White
                txtGuardianName.BackColor = Color.White
                txtGuardianContactNo.BackColor = Color.White

            End If

            dbConnection.Close()

            Return

        Catch ex As Exception

            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
            Exit Try

        End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        StudentEnrollmentGuide.Show()

        PictureBox2.Visible = False

    End Sub

End Class