Imports System.Data.OleDb

Public Class StudentSubject
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        StudentRequirements.Hide()
        StudentRegistered.Hide()
        StudentEnrollment.Panel1.Visible = True
        StudentEnrollment.PictureBox1.Visible = True
        Hide()

    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        Hide()
        StudentEnrollment.Requirements()

    End Sub

    Private Sub RoundButtonBack(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 14)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnBack.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnBack.Region = New Region(Raduis)

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

    Private Sub ClassSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RoundButtonBack(btnBack)
        RoundButtonNext(btnNext)


        lblName.Text = StudentEnrollment.txtLastname.Text & ", " & StudentEnrollment.txtFirstname.Text & " " & StudentEnrollment.txtMiddlename.Text

        If StudentEnrollment.cmbGradeLevel.Text = "Nursery - Pre-School" Then
            lblGrade.Text = "Nursery"

            'Kinder
        ElseIf StudentEnrollment.cmbGradeLevel.Text = "Kinder 1 - Pre-School" Then
            lblGrade.Text = "Kinder 1"
        ElseIf StudentEnrollment.cmbGradeLevel.Text = "Kinder 2 - Pre-School" Then
            lblGrade.Text = "Kinder 2"

            'Elementary
        ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 1 - Elementary" Then
            lblGrade.Text = "Grade 1"
        ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 2 - Elementary" Then
            lblGrade.Text = "Grade 2"
        ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 3 - Elementary" Then
            lblGrade.Text = "Grade 3"
        ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 4 - Elementary" Then
            lblGrade.Text = "Grade 4"
        ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 5 - Elementary" Then
            lblGrade.Text = "Grade 5"
        ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 6 - Elementary" Then
            lblGrade.Text = "Grade 6"
        ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 7 - Junior High School" Then
            lblGrade.Text = "Grade 7"
        ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 8 - Junior High School" Then
            lblGrade.Text = "Grade 8"
        ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 9 - Junior High School" Then
            lblGrade.Text = "Grade 9"
        ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 10 - Junior High School" Then
            lblGrade.Text = "Grade 10"

            'GRADE 11 Senior High School
        ElseIf (StudentEnrollment.cmbGradeLevel.Text = "Grade 11 - Senior High School" And StudentEnrollment.cmbStrand.Text = "Academic - Accountancy, Business and Management (ABM)") Then
            lblGrade.Text = "Grade 11 - ABM"
        ElseIf (StudentEnrollment.cmbGradeLevel.Text = "Grade 11 - Senior High School" And StudentEnrollment.cmbStrand.Text = "Academic - General Academic Strand (GAS)") Then
            lblGrade.Text = "Grade 11 - GAS"
        ElseIf (StudentEnrollment.cmbGradeLevel.Text = "Grade 11 - Senior High School" And StudentEnrollment.cmbStrand.Text = "Academic - Humanities and Social Sciences (HUMSS)") Then
            lblGrade.Text = "Grade 11 - HUMSS"
        ElseIf (StudentEnrollment.cmbGradeLevel.Text = "Grade 11 - Senior High School" And StudentEnrollment.cmbStrand.Text = "Academic - Science, Technology, Engineering and Mathematics (STEM)") Then
            lblGrade.Text = "Grade 11 - STEM"
        ElseIf (StudentEnrollment.cmbGradeLevel.Text = "Grade 11 - Senior High School" And StudentEnrollment.cmbStrand.Text = "TVL - Home Economics (HE)") Then
            lblGrade.Text = "Grade 11 - HE"
        ElseIf (StudentEnrollment.cmbGradeLevel.Text = "Grade 11 - Senior High School" And StudentEnrollment.cmbStrand.Text = "TVL - Information and Communications Technology (ICT)") Then
            lblGrade.Text = "Grade 11 - ICT"
        ElseIf (StudentEnrollment.cmbGradeLevel.Text = "Grade 11 - Senior High School" And StudentEnrollment.cmbStrand.Text = "TVL Tracks - Industrial Arts (IA)") Then
            lblGrade.Text = "Grade 11 - IA"

            'GRADE 12 Senior High School
        ElseIf (StudentEnrollment.cmbGradeLevel.Text = "Grade 12 - Senior High School" And StudentEnrollment.cmbStrand.Text = "Academic - Accountancy, Business and Management (ABM)") Then
            lblGrade.Text = "Grade 12 - ABM"
        ElseIf (StudentEnrollment.cmbGradeLevel.Text = "Grade 12 - Senior High School" And StudentEnrollment.cmbStrand.Text = "Academic - General Academic Strand (GAS)") Then
            lblGrade.Text = "Grade 12 - GAS"
        ElseIf (StudentEnrollment.cmbGradeLevel.Text = "Grade 12 - Senior High School" And StudentEnrollment.cmbStrand.Text = "Academic - Humanities and Social Sciences (HUMSS)") Then
            lblGrade.Text = "Grade 12 - HUMSS"
        ElseIf (StudentEnrollment.cmbGradeLevel.Text = "Grade 12 - Senior High School" And StudentEnrollment.cmbStrand.Text = "Academic - Science, Technology, Engineering and Mathematics (STEM)") Then
            lblGrade.Text = "Grade 12 - STEM"
        ElseIf (StudentEnrollment.cmbGradeLevel.Text = "Grade 12 - Senior High School" And StudentEnrollment.cmbStrand.Text = "TVL - Home Economics (HE)") Then
            lblGrade.Text = "Grade 12 - HE"
        ElseIf (StudentEnrollment.cmbGradeLevel.Text = "Grade 12 - Senior High School" And StudentEnrollment.cmbStrand.Text = "TVL - Information and Communications Technology (ICT)") Then
            lblGrade.Text = "Grade 12 - ICT"
        ElseIf (StudentEnrollment.cmbGradeLevel.Text = "Grade 12 - Senior High School" And StudentEnrollment.cmbStrand.Text = "TVL Tracks - Industrial Arts (IA)") Then
            lblGrade.Text = "Grade 12 - IA"
        End If

        Try

            Dim SubjectConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")
            If SubjectConnection.State = ConnectionState.Open Then SubjectConnection.Close()
            SubjectConnection.Open()

            'from EnrollmentData where StudentNumber = '" & txtStudentNumber.Text & "'"
            If StudentEnrollment.cmbGradeLevel.Text = "Nursery - Pre-School" Then
                Dim query As String = "SELECT NurseryCode,NurserySubject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()

            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Kinder 1 - Pre-School" Then
                Dim query As String = "SELECT Kinder1Code,Kinder1Subject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Kinder 2 - Pre-School" Then
                Dim query As String = "SELECT Kinder2Code,Kinder2Subject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()

                'Elementray
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 1 - Elementary" Then
                Dim query As String = "SELECT Grade1Code,Grade1Subject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 2 - Elementary" Then
                Dim query As String = "SELECT Grade2Code,Grade2Subject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 3 - Elementary" Then
                Dim query As String = "SELECT Grade3Code,Grade3Subject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 4 - Elementary" Then
                Dim query As String = "SELECT Grade4Code,Grade4Subject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 5 - Elementary" Then
                Dim query As String = "SELECT Grade5Code,Grade5Subject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 6 - Elementary" Then
                Dim query As String = "SELECT Grade6Code,Grade6Subject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 7 - Junior High School" Then
                Dim query As String = "SELECT Grade7Code,Grade7Subject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 8 - Junior High School" Then
                Dim query As String = "SELECT Grade8Code,Grade8Subject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 9 - Junior High School" Then
                Dim query As String = "SELECT Grade9Code,Grade9Subject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 10 - Junior High School" Then
                Dim query As String = "SELECT Grade10Code,Grade10Subject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()

                'Grade 11
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 11 - Senior High School" And StudentEnrollment.cmbStrand.Text = "Academic - Accountancy, Business And Management(ABM)" Then
                Dim query As String = "SELECT Grade11ABMCode,Grade11ABMSubject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 11 - Senior High School" And StudentEnrollment.cmbStrand.Text = "Academic - General Academic Strand (GAS)" Then
                Dim query As String = "SELECT Grade11GASCode,Grade11GASSubject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 11 - Senior High School" And StudentEnrollment.cmbStrand.Text = "Academic - Humanities And Social Sciences (HUMSS)" Then
                Dim query As String = "SELECT Grade11HUMSSCode,Grade11HUMSSSubject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 11 - Senior High School" And StudentEnrollment.cmbStrand.Text = "Academic - Science, Technology, Engineering And Mathematics(STEM)" Then
                Dim query As String = "SELECT Grade11STEMCode,Grade11STEMSubject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 11 - Senior High School" And StudentEnrollment.cmbStrand.Text = "TVL - Home Economics (HE)" Then
                Dim query As String = "SELECT Grade11HECode,Grade11HESubject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 11 - Senior High School" And StudentEnrollment.cmbStrand.Text = "TVL - Information And Communications Technology (ICT)" Then
                Dim query As String = "SELECT Grade11ICTCode,Grade11ICTSubject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 11 - Senior High School" And StudentEnrollment.cmbStrand.Text = "TVL Tracks - Industrial Arts (IA)" Then
                Dim query As String = "SELECT Grade11IACode,Grade11IASubject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
                'Grade 12
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 12 - Senior High School" And StudentEnrollment.cmbStrand.Text = "Academic - Accountancy, Business And Management(ABM)" Then
                Dim query As String = "SELECT Grade12ABMCode,Grade12ABMSubject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 12 - Senior High School" And StudentEnrollment.cmbStrand.Text = "Academic - General Academic Strand (GAS)" Then
                Dim query As String = "SELECT Grade12GASCode,Grade12GASSubject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 12 - Senior High School" And StudentEnrollment.cmbStrand.Text = "Academic - Humanities And Social Sciences (HUMSS)" Then
                Dim query As String = "SELECT Grade12HUMSSCode,Grade12HUMSSSubject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 12 - Senior High School" And StudentEnrollment.cmbStrand.Text = "Academic - Science, Technology, Engineering And Mathematics(STEM)" Then
                Dim query As String = "SELECT Grade12STEMCode,Grade12STEMSubject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 12 - Senior High School" And StudentEnrollment.cmbStrand.Text = "TVL - Home Economics (HE)" Then
                Dim query As String = "SELECT Grade12HECode,Grade12HESubject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 12 - Senior High School" And StudentEnrollment.cmbStrand.Text = "TVL - Information And Communications Technology (ICT)" Then
                Dim query As String = "SELECT Grade12ICTCode,Grade12ICTSubject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            ElseIf StudentEnrollment.cmbGradeLevel.Text = "Grade 12 - Senior High School" And StudentEnrollment.cmbStrand.Text = "TVL Tracks - Industrial Arts (IA)" Then
                Dim query As String = "SELECT Grade12IACode,Grade12IASubject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                    .CommandText = query,
                    .Connection = SubjectConnection
                }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()

            Else
                Dim query As String = "SELECT Grade11ICTCode,Grade11ICTSubject FROM Subject"
                Dim dbDataReader As OleDbDataReader
                Dim dbDataAdapter As New OleDbDataAdapter
                Dim dbCommand As New OleDbCommand With {
                        .CommandText = query,
                        .Connection = SubjectConnection
                    }
                dbDataAdapter.SelectCommand = dbCommand
                dbDataReader = dbCommand.ExecuteReader
                ListView1.Items.Clear()

                If dbDataReader.HasRows Then
                    While dbDataReader.Read()
                        With ListView1.Items.Add(dbDataReader(0).ToString)
                            .SubItems.Add(dbDataReader(1).ToString)
                        End With
                    End While
                End If

                dbCommand.Dispose()
                dbDataReader.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
            Exit Try

        End Try

    End Sub

End Class