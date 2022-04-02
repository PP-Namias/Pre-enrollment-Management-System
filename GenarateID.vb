Imports System.Data.OleDb
Imports System.IO

Public Class GenarateID

    Sub FillDataID()
        Try
            Dim FillDataIDConnection As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")
            If FillDataIDConnection.State = ConnectionState.Open Then FillDataIDConnection.Close()
            FillDataIDConnection.Open()

            Dim FillDataIDDataReader As OleDbDataReader

            Dim FillDataIDCommand As New OleDbCommand("Select [StudentPicture], [StudentNumber], [Firstname], [Middlename], [Lastname], [GradeLevel], [Strand], [PersonEmergency], [GuardianName], [GuardianContactNumber], [Address], [City] FROM EnrollmentData WHERE EnrollmentNumber = 8", FillDataIDConnection)

            FillDataIDDataReader = FillDataIDCommand.ExecuteReader

            If FillDataIDDataReader.Read Then
                Dim x As Byte() = FillDataIDDataReader(0)
                Dim ms As New MemoryStream(x)
                PicID.Image = Image.FromStream(ms)

                Dim strGrade As String
                If UCase(FillDataIDDataReader(5)).ToString() = "NURSERY - PRE-SCHOOL" Then
                    strGrade = "Nursery"

                    StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                    NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                    GradeID.Text = "Grade: " & strGrade
                    'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                    SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                    PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                    FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                    FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                    Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                    City.Text = UCase(FillDataIDDataReader(12)).ToString()

                    FillDataIDConnection.Close()
                    FillDataIDDataReader.Close()
                    Return

                ElseIf UCase(FillDataIDDataReader(5)).ToString() = "KINDER 1 - PRE-SCHOOL" Then
                    strGrade = "Kinder 1"

                    StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                    NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                    GradeID.Text = "Grade: " & strGrade
                    'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                    SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                    PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                    FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                    FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                    Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                    City.Text = UCase(FillDataIDDataReader(12)).ToString()

                    FillDataIDConnection.Close()
                    FillDataIDDataReader.Close()
                    Return

                ElseIf UCase(FillDataIDDataReader(5)).ToString() = "KINDER 2 - PRE-SCHOOL" Then
                    strGrade = "Kinder 2"

                    StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                    NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                    GradeID.Text = "Grade: " & strGrade
                    'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                    SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                    PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                    FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                    FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                    Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                    City.Text = UCase(FillDataIDDataReader(12)).ToString()

                    FillDataIDConnection.Close()
                    FillDataIDDataReader.Close()
                    Return

                ElseIf UCase(FillDataIDDataReader(5)).ToString() = "GRADE 1 - ELEMENTARY" Then
                    strGrade = "Grade 1"

                    StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                    NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                    GradeID.Text = "Grade: " & strGrade
                    'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                    SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                    PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                    FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                    FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                    Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                    City.Text = UCase(FillDataIDDataReader(12)).ToString()

                    FillDataIDConnection.Close()
                    FillDataIDDataReader.Close()
                    Return

                ElseIf UCase(FillDataIDDataReader(5)).ToString() = "GRADE 2 - ELEMENTARY" Then
                    strGrade = "Grade 2"

                    StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                    NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                    GradeID.Text = "Grade: " & strGrade
                    'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                    SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                    PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                    FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                    FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                    Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                    City.Text = UCase(FillDataIDDataReader(12)).ToString()

                    FillDataIDConnection.Close()
                    FillDataIDDataReader.Close()
                    Return

                ElseIf UCase(FillDataIDDataReader(5)).ToString() = "GRADE 3 - ELEMENTARY" Then
                    strGrade = "Grade 3"

                    StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                    NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                    GradeID.Text = "Grade: " & strGrade
                    'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                    SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                    PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                    FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                    FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                    Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                    City.Text = UCase(FillDataIDDataReader(12)).ToString()

                    FillDataIDConnection.Close()
                    FillDataIDDataReader.Close()
                    Return

                ElseIf UCase(FillDataIDDataReader(5)).ToString() = "GRADE 4 - ELEMENTARY" Then
                    strGrade = "Grade 4"

                    StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                    NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                    GradeID.Text = "Grade: " & strGrade
                    'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                    SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                    PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                    FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                    FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                    Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                    City.Text = UCase(FillDataIDDataReader(12)).ToString()

                    FillDataIDConnection.Close()
                    FillDataIDDataReader.Close()
                    Return

                ElseIf UCase(FillDataIDDataReader(5)).ToString() = "GRADE 5 - ELEMENTARY" Then
                    strGrade = "Grade 5"

                    StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                    NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                    GradeID.Text = "Grade: " & strGrade
                    'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                    SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                    PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                    FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                    FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                    Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                    City.Text = UCase(FillDataIDDataReader(12)).ToString()

                    FillDataIDConnection.Close()
                    FillDataIDDataReader.Close()
                    Return

                ElseIf UCase(FillDataIDDataReader(5)).ToString() = "GRADE 6 - ELEMENTARY" Then
                    strGrade = "Grade 6"

                    StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                    NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                    GradeID.Text = "Grade: " & strGrade
                    'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                    SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                    PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                    FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                    FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                    Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                    City.Text = UCase(FillDataIDDataReader(12)).ToString()

                    FillDataIDConnection.Close()
                    FillDataIDDataReader.Close()
                    Return

                ElseIf UCase(FillDataIDDataReader(5)).ToString() = "GRADE 7 - JUNIOR HIGH SCHOOL" Then
                    strGrade = "Grade 7"

                    StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                    NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                    GradeID.Text = "Grade: " & strGrade
                    'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                    SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                    PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                    FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                    FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                    Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                    City.Text = UCase(FillDataIDDataReader(12)).ToString()

                    FillDataIDConnection.Close()
                    FillDataIDDataReader.Close()
                    Return

                ElseIf UCase(FillDataIDDataReader(5)).ToString() = "GRADE 8 - JUNIOR HIGH SCHOOL" Then
                    strGrade = "Grade 8"
                    StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                    NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                    GradeID.Text = "Grade: " & strGrade
                    'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                    SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                    PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                    FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                    FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                    Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                    City.Text = UCase(FillDataIDDataReader(12)).ToString()

                    FillDataIDConnection.Close()
                    FillDataIDDataReader.Close()
                    Return

                ElseIf UCase(FillDataIDDataReader(5)).ToString() = "GRADE 9 - JUNIOR HIGH SCHOOL" Then
                    strGrade = "Grade 9"

                    StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                    NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                    GradeID.Text = "Grade: " & strGrade
                    'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                    SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                    PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                    FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                    FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                    Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                    City.Text = UCase(FillDataIDDataReader(12)).ToString()

                    FillDataIDConnection.Close()
                    FillDataIDDataReader.Close()
                    Return

                ElseIf UCase(FillDataIDDataReader(5)).ToString() = "GRADE 10 - JUNIOR HIGH SCHOOL" Then
                    strGrade = "Grade 10"

                    StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                    NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                    GradeID.Text = "Grade: " & strGrade
                    'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                    SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                    PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                    FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                    FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                    Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                    City.Text = UCase(FillDataIDDataReader(12)).ToString()

                    FillDataIDConnection.Close()
                    FillDataIDDataReader.Close()
                    Return

                ElseIf UCase(FillDataIDDataReader(5)).ToString() = "GRADE 11 - SENIOR HIGH SCHOOL" Then
                    strGrade = "Grade 11"

                    Dim strStrand As String
                    If UCase(FillDataIDDataReader(6)).ToString() = "ACADEMIC - ACCOUNTANCY, BUSINESS AND MANAGEMENT (ABM)" Then
                        strStrand = "ABM"

                        StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                        NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                        GradeID.Text = "Grade: " & strGrade & " " & strStrand
                        'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                        SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                        PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                        FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                        FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                        Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                        City.Text = UCase(FillDataIDDataReader(12)).ToString()

                        FillDataIDConnection.Close()
                        FillDataIDDataReader.Close()
                        Return

                    ElseIf UCase(FillDataIDDataReader(6)).ToString() = "ACADEMIC - GENERAL ACADEMIC STRAND (GAS)" Then
                        strStrand = "GAS"

                        StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                        NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                        GradeID.Text = "Grade: " & strGrade & " " & strStrand
                        'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                        SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                        PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                        FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                        FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                        Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                        City.Text = UCase(FillDataIDDataReader(12)).ToString()

                        FillDataIDConnection.Close()
                        FillDataIDDataReader.Close()
                        Return

                    ElseIf UCase(FillDataIDDataReader(6)).ToString() = "ACADEMIC - HUMANITIES AND SOCIAL SCIENCES (HUMSS)" Then
                        strStrand = "HUMSS"

                        StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                        NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                        GradeID.Text = "Grade: " & strGrade & " " & strStrand
                        'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                        SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                        PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                        FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                        FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                        Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                        City.Text = UCase(FillDataIDDataReader(12)).ToString()

                        FillDataIDConnection.Close()
                        FillDataIDDataReader.Close()
                        Return

                    ElseIf UCase(FillDataIDDataReader(6)).ToString() = "ACADEMIC - SCIENCE, TECHNOLOGY, ENGINEERING AND MATHEMATICS (STEM)" Then
                        strStrand = "STEM"

                        StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                        NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                        GradeID.Text = "Grade: " & strGrade & " " & strStrand
                        'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                        SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                        PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                        FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                        FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                        Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                        City.Text = UCase(FillDataIDDataReader(12)).ToString()

                        FillDataIDConnection.Close()
                        FillDataIDDataReader.Close()
                        Return

                    ElseIf UCase(FillDataIDDataReader(6)).ToString() = "TVL - HOME ECONOMICS (HE)" Then
                        strStrand = "HE"

                        StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                        NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                        GradeID.Text = "Grade: " & strGrade & " " & strStrand
                        'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                        SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                        PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                        FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                        FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                        Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                        City.Text = UCase(FillDataIDDataReader(12)).ToString()

                        FillDataIDConnection.Close()
                        FillDataIDDataReader.Close()
                        Return

                    ElseIf UCase(FillDataIDDataReader(6)).ToString() = "TVL - INFORMATION AND COMMUNICATIONS TECHNOLOGY (ICT)" Then
                        strStrand = "ICT"

                        StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                        NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                        GradeID.Text = "Grade: " & strGrade & " " & strStrand
                        'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                        SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                        PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                        FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                        FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                        Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                        City.Text = UCase(FillDataIDDataReader(12)).ToString()

                        FillDataIDConnection.Close()
                        FillDataIDDataReader.Close()
                        Return

                    ElseIf UCase(FillDataIDDataReader(6)).ToString() = "TVL TRACKS - INDUSTRIAL ARTS (IA)" Then
                        strStrand = "IA"

                        StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                        NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                        GradeID.Text = "Grade: " & strGrade & " " & strStrand
                        'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                        SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                        PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                        FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                        FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                        Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                        City.Text = UCase(FillDataIDDataReader(12)).ToString()

                        FillDataIDConnection.Close()
                        FillDataIDDataReader.Close()
                        Return
                    Else
                        strStrand = ""

                        StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                        NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                        GradeID.Text = "Grade: " & strGrade & " " & strStrand
                        'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                        SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                        PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                        FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                        FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                        Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                        City.Text = UCase(FillDataIDDataReader(12)).ToString()

                        FillDataIDConnection.Close()
                        FillDataIDDataReader.Close()
                        Return

                    End If

                ElseIf UCase(FillDataIDDataReader(5)).ToString() = "GRADE 12 - SENIOR HIGH SCHOOL" Then
                    strGrade = "Grade 12"

                    Dim strStrand As String
                    If UCase(FillDataIDDataReader(6)).ToString() = "ACADEMIC - ACCOUNTANCY, BUSINESS AND MANAGEMENT (ABM)" Then
                        strStrand = "ABM"

                        StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                        NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                        GradeID.Text = "Grade: " & strGrade & " " & strStrand
                        'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                        SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                        PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                        FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                        FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                        Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                        City.Text = UCase(FillDataIDDataReader(12)).ToString()

                        FillDataIDConnection.Close()
                        FillDataIDDataReader.Close()
                        Return

                    ElseIf UCase(FillDataIDDataReader(6)).ToString() = "ACADEMIC - GENERAL ACADEMIC STRAND (GAS)" Then
                        strStrand = "GAS"

                        StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                        NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                        GradeID.Text = "Grade: " & strGrade & " " & strStrand
                        'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                        SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                        PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                        FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                        FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                        Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                        City.Text = UCase(FillDataIDDataReader(12)).ToString()

                        FillDataIDConnection.Close()
                        FillDataIDDataReader.Close()
                        Return

                    ElseIf UCase(FillDataIDDataReader(6)).ToString() = "ACADEMIC - HUMANITIES AND SOCIAL SCIENCES (HUMSS)" Then
                        strStrand = "HUMSS"

                        StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                        NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                        GradeID.Text = "Grade: " & strGrade & " " & strStrand
                        'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                        SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                        PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                        FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                        FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                        Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                        City.Text = UCase(FillDataIDDataReader(12)).ToString()

                        FillDataIDConnection.Close()
                        FillDataIDDataReader.Close()
                        Return

                    ElseIf UCase(FillDataIDDataReader(6)).ToString() = "ACADEMIC - SCIENCE, TECHNOLOGY, ENGINEERING AND MATHEMATICS (STEM)" Then
                        strStrand = "STEM"

                        StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                        NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                        GradeID.Text = "Grade: " & strGrade & " " & strStrand
                        'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                        SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                        PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                        FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                        FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                        Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                        City.Text = UCase(FillDataIDDataReader(12)).ToString()

                        FillDataIDConnection.Close()
                        FillDataIDDataReader.Close()
                        Return

                    ElseIf UCase(FillDataIDDataReader(6)).ToString() = "TVL - HOME ECONOMICS (HE)" Then
                        strStrand = "HE"

                        StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                        NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                        GradeID.Text = "Grade: " & strGrade & " " & strStrand
                        'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                        SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                        PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                        FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                        FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                        Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                        City.Text = UCase(FillDataIDDataReader(12)).ToString()

                        FillDataIDConnection.Close()
                        FillDataIDDataReader.Close()
                        Return

                    ElseIf UCase(FillDataIDDataReader(6)).ToString() = "TVL - INFORMATION AND COMMUNICATIONS TECHNOLOGY (ICT)" Then
                        strStrand = "ICT"

                        StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                        NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                        GradeID.Text = "Grade: " & strGrade & " " & strStrand
                        'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(13)).ToString()
                        SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                        PersonEmergency.Text = UCase(FillDataIDDataReader(7)).ToString()
                        FetcherName.Text = UCase(FillDataIDDataReader(8)).ToString()
                        FetcherContact.Text = UCase(FillDataIDDataReader(9)).ToString()
                        Address.Text = UCase(FillDataIDDataReader(10)).ToString()
                        City.Text = UCase(FillDataIDDataReader(11)).ToString()

                        FillDataIDConnection.Close()
                        FillDataIDDataReader.Close()
                        Return

                    ElseIf UCase(FillDataIDDataReader(6)).ToString() = "TVL TRACKS - INDUSTRIAL ARTS (IA)" Then
                        strStrand = "IA"

                        StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                        NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                        GradeID.Text = "Grade: " & strGrade & " " & strStrand
                        'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                        LRN.Text = "LRN: 136812090393" '& UCase(FillDataIDDataReader(7)).ToString()
                        SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                        PersonEmergency.Text = UCase(FillDataIDDataReader(8)).ToString()
                        FetcherName.Text = UCase(FillDataIDDataReader(9)).ToString()
                        FetcherContact.Text = UCase(FillDataIDDataReader(10)).ToString()
                        Address.Text = UCase(FillDataIDDataReader(11)).ToString()
                        City.Text = UCase(FillDataIDDataReader(12)).ToString()

                        FillDataIDConnection.Close()
                        FillDataIDDataReader.Close()
                        Return

                    Else
                        strStrand = ""

                        StudentNumber.Text = "'" & UCase(FillDataIDDataReader(1)).ToString() & "'"
                        NameID.Text = UCase(FillDataIDDataReader(2)).ToString() & " " & UCase(FillDataIDDataReader(3)).ToString().Substring(0, 1) & ". " & UCase(FillDataIDDataReader(4)).ToString()
                        GradeID.Text = "Grade: " & strGrade & " " & strStrand
                        'LRN.Text = "LRN: " & UCase(FillDataIDDataReader(7)).ToString()
                        SY.Text = Date.Today.Year & " - " & (Date.Today.Year + 1)
                        PersonEmergency.Text = UCase(FillDataIDDataReader(7)).ToString()
                        FetcherName.Text = UCase(FillDataIDDataReader(8)).ToString()
                        FetcherContact.Text = UCase(FillDataIDDataReader(9)).ToString()
                        Address.Text = UCase(FillDataIDDataReader(10)).ToString()
                        City.Text = UCase(FillDataIDDataReader(11)).ToString()

                        FillDataIDConnection.Close()
                        FillDataIDDataReader.Close()
                        Return

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error Student Data.")
            Exit Sub

        End Try

        Try
            Dim RegistrarConnection As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

            If RegistrarConnection.State = ConnectionState.Open Then RegistrarConnection.Close()
            RegistrarConnection.Open()

            Dim RegistrarDataReader As OleDbDataReader
            Dim RegistrarCommand As New OleDbCommand With {
                .CommandText = "select [RegistrarName],[Signature],[Suffix],[GradeLevel] from SchoolInfo where GradeLevel = 'GRADE 12 - SENIOR HIGH SCHOOL'",
                .Connection = RegistrarConnection
            }
            RegistrarDataReader = RegistrarCommand.ExecuteReader

            If RegistrarDataReader.Read Then
                RegistrarName.Text = UCase(RegistrarDataReader(2)).ToString() & UCase(RegistrarDataReader(0)).ToString()
                Dim byt As Byte() = RegistrarDataReader(1)
                Dim ms As New MemoryStream(byt)
                PicSignature.Image = Image.FromStream(ms)
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error Registrar Data.")
            Exit Sub

        End Try

    End Sub

    Private Sub GenarateID_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FillDataID()

        PrintID.Show()

    End Sub

End Class