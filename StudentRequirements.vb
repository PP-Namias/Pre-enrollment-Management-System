Imports System.Data.OleDb
Imports Word = Microsoft.Office.Interop.Word

Public Class StudentRequirements

    Private Sub RoundButton(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 14)

        Dim Raduis As New Drawing2D.GraphicsPath
        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnConfirm.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnConfirm.Region = New Region(Raduis)

    End Sub

    Private Sub StudentRequirements_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RoundButton(btnConfirm)

        Dim readonly1 As Object = True
        Dim visible As Object = True
        Dim save As Object = True
        Dim filename As Object = $"{My.Application.Info.DirectoryPath}\Data Privacy Office.docx"
        Dim missing As Object = Type.Missing
        Dim template As Object = False
        Dim typedoc As Object = 0

        Dim doc1 As Word.Document = Nothing
        Dim word1 As New Word.Application() With {
           .Visible = False
        }
        doc1 = word1.Documents.Open(filename,
             readonly1,
             visible)
        doc1.ActiveWindow.Selection.WholeStory()
        doc1.ActiveWindow.Selection.Copy()
        Dim data1 As IDataObject = Clipboard.GetDataObject
        RichTextBox1.Rtf = data1.GetData(DataFormats.Rtf).ToString
        word1.Quit(missing)

        RichTextBox1.BackColor = Color.White

    End Sub

    Private Sub ChbConfirm_CheckedChanged(sender As Object, e As EventArgs) Handles chbConfirm.CheckedChanged

        If chbConfirm.Checked = True Then
            btnConfirm.Enabled = True
            btnConfirm.BackColor = Color.Green
            btnConfirm.ForeColor = Color.White

        ElseIf chbConfirm.Checked = False Then
            btnConfirm.Enabled = False
            btnConfirm.BackColor = Color.Gray
            btnConfirm.ForeColor = Color.Black

        End If

    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Try
            'deletion
            Dim ChangeConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

            If ChangeConnection.State = ConnectionState.Open Then ChangeConnection.Close()

            ChangeConnection.Open()

            Dim ChangeCommand As New OleDbCommand("Update EnrollmentData Set StudentNumber=@SNum,GradeLevel=@SGrade,Strand=@Strand,Semester=@Semester,SchoolYear=@SchoolYear,Lastname=@Lastname,Firstname=@Firstname,Middlename=@Middlename,Age=@Age,DOB=@DOB,Sex=@Sex,POB=@POB,Nationality=@Nationality,Religion=@Religion,Email=@Email,MobileNumber=@MobileNumber,TelephoneNumber=@TelephoneNumber,Address=@Address,City=@City,FatherName=@FName,FatherOccupation=@FOccupation,FatherEmail=@FEmail,FatherWorkAddress=@FWorkAddress,FatherContactNumber=@FContactNumber,MotherName=@MName,MotherOccupation=@MOccupation,MotherEmail=@MEmail,MotherWorkAddress=@MWorkAddress,MotherContactNumber=@MContactNumber,NumberOfSiblings=@NumOfSiblings,PersonEmergency=@PersonEmergency,GuardianName=@GName,GuardianRelation=@GRelation,GuardianEmail=@GEmail,GuardianWorkAddress=@GWorkAddress,GuardianContactNumber=@GContactNumber,FetcherName=@FetcherName,FetcherContactNumber=@FetcherContactNumber,SiblingsOfStudent1=@SiblingsOfStudent1,SiblingsOfStudent2=@SiblingsOfStudent2,SiblingsOfStudent3=@SiblingsOfStudent3,SiblingsOfStudentAge1=@SiblingsOfStudentAge1,SiblingsOfStudentAge2=@SiblingsOfStudentAge2,SiblingsOfStudentAge3=@SiblingsOfStudentAge3,SiblingsOfStudentSchool1=@SiblingsOfStudentSchool1,SiblingsOfStudentSchool2=@SiblingsOfStudentSchool2,SiblingsOfStudentSchool3=@SiblingsOfStudentSchool3,SchoolLastAttended1=@SchoolLastAttended1,SchoolLastAttended2=@SchoolLastAttended2,SchoolLastAttended3=@SchoolLastAttended3,AcademicYear1=@AYear1,AcademicYear2=@AYear2,AcademicYear3=@AYear3,ReasonApplying=@ReasonApplying,StudentPicture=@SPic Where (StudentNumber='" & StudentEnrollment.txtStudentNumber.Text & "') ", ChangeConnection)

            ' Student Number
            Dim StudentNumber As New OleDbParameter("@SNum", OleDbType.VarWChar, 25) With {
                    .Value = StudentEnrollment.txtStudentNumber.Text.ToString()
                }
            ChangeCommand.Parameters.Add(StudentNumber)
            'deletion

            Dim ConditionConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

            If ConditionConnection.State = ConnectionState.Open Then ConditionConnection.Close()
            ConditionConnection.Open()
            'StudentEnrollment.cmbGradeLevel.Text = "Grade 12 - Senior High School"
            Dim query As String = "INSERT INTO EnrollmentData [Condition],[Requirement1],[Requirement2],[Requirement3],[Requirement4],[Status] values(@d1,@d2,@d3,@d4,@d5,@d6)  WHERE Identifier = '" & StudentEnrollment.dtbIdentify.Text & "'"
            Dim ConditionCommand As New OleDbCommand(query, ConditionConnection)

            ' Special Arrangements and Conditions  
            Dim Conditions As New OleDbParameter("@d1", OleDbType.VarWChar, 10)

            If rdoCondition1.Checked Then
                Conditions.Value = "1"
                ConditionCommand.Parameters.Add(Conditions)
            ElseIf rdoCondition2.Checked Then
                Conditions.Value = "2"
                ConditionCommand.Parameters.Add(Conditions)
            ElseIf rdoCondition3.Checked Then
                Conditions.Value = "3"
                ConditionCommand.Parameters.Add(Conditions)
            ElseIf rdoCondition4.Checked Then
                Conditions.Value = "4"
                ConditionCommand.Parameters.Add(Conditions)
            ElseIf rdoCondition5.Checked Then
                Conditions.Value = "5"
                ConditionCommand.Parameters.Add(Conditions)
            Else
                Conditions.Value = "0"

            End If

            ' Birth Certificate (Original) PSA Copy   
            Dim Requirement1 As New OleDbParameter("@d2", OleDbType.VarWChar, 10) With {
                .Value = chbRequirement1.Text.ToString()
            }
            ConditionCommand.Parameters.Add(Requirement1)

            ' Good Moral Certificate 
            Dim Requirement2 As New OleDbParameter("@d3", OleDbType.VarWChar, 10) With {
                .Value = chbRequirement2.Text.ToString()
            }
            ConditionCommand.Parameters.Add(Requirement2)

            ' SF10  
            Dim Requirement3 As New OleDbParameter("@d4", OleDbType.VarWChar, 10) With {
                .Value = chbRequirement3.Text.ToString()
            }
            ConditionCommand.Parameters.Add(Requirement3)

            ' 1 x 1 Picture   
            Dim Requirement4 As New OleDbParameter("@d5", OleDbType.VarWChar, 10) With {
                .Value = chbRequirement4.Text.ToString()
            }
            ConditionCommand.Parameters.Add(Requirement4)

            ' Status
            Dim Status As New OleDbParameter("@d6", OleDbType.VarWChar, 10) With {
                .Value = "reserved"
            }
            ConditionCommand.Parameters.Add(Status)

            If (rdoCondition1.Checked = False And rdoCondition2.Checked = False And rdoCondition3.Checked = False And rdoCondition4.Checked = False And rdoCondition5.Checked = False) Then
                MsgBox("Please fill the Special Arrangements and Conditions!", MsgBoxStyle.Information, "Special Arrangements and Conditions Missing")
                Return

            Else
                Dim okcancel As Integer = MessageBox.Show("I have read the conditions stated herein and I have full understanding of my responsibilities and liabilities with Young Achievers` School of Caloocan, Inc.. I agree with all of the legal constraints and repercussions. Young Achievers` School of Caloocan, Inc. may hold against me should I violate any of the above-mentioned conditions. I understand that I am in contract with Young Achievers` School of Caloocan, Inc. and that I subject myself under its implementing rules and regulations, and terms and conditions.", "Young Achievers School of Caloocan", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

                If okcancel = vbCancel Then
                    Return

                Else

                    Dispose()
                    StudentEnrollment.Registered()

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
            Exit Sub

        End Try

    End Sub

End Class