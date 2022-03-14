Imports System.Data.OleDb
Imports System.IO

Public Class UserInfo

    Private Sub UserInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        MainForm.Show()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked


        Dim User As New ChangeInfo
        Hide()
        User.Show()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Hide()
        ChangePassword.Show()

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked

        Hide()
        GenarateID.Show()

    End Sub

    Private Sub UserInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim dbConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")

            If dbConnection.State = ConnectionState.Open Then dbConnection.Close()
            dbConnection.Open()

            Dim dbDataReader As OleDbDataReader
            Dim dbCommand As New OleDbCommand

            If LoginForm.cmbFormState.Text = "Admin" Then

                dbCommand.CommandText = "select [AdminID],[Username],[DateOfBirth],[PlaceOfBirth],[EmailID],[Status],[AdminPic] from AdminInfo where AdminID = '" & LoginForm.txtAdminUsername.Text & "'"
                dbCommand.Connection = dbConnection
                dbDataReader = dbCommand.ExecuteReader

                If dbDataReader.Read Then

                    Username.Text = dbDataReader(1).ToString()
                    Dim DOB As String = dbDataReader(2).ToString()
                    Dim SplitPart = DOB.Split(" "c)
                    Dim final As String = SplitPart(0).Trim
                    DateOfBirth.Text = (String.Format("{0}", final)).ToString
                    PlaceOfBirth.Text = dbDataReader(3).ToString()
                    EmailID.Text = LCase(dbDataReader(4)).ToString()
                    Status.Text = dbDataReader(5).ToString()
                    Dim LoadPic As Byte() = dbDataReader("AdminPic")
                    Dim Memory As New MemoryStream(LoadPic)
                    PicID.Image = Image.FromStream(Memory)

                End If

                dbConnection.Close()
                dbDataReader.Close()

                Return

            End If

            If LoginForm.cmbFormState.Text = "Teacher" Then

                dbCommand.CommandText = "Select [TeacherID], [Username], [DateOfBirth], [PlaceOfBirth], [EmailID], [TeacherPic] from TeacherInfo where TeacherID = '" & LoginForm.txtTeacherUsername.Text & "'"
                dbCommand.Connection = dbConnection
                dbDataReader = dbCommand.ExecuteReader

                If dbDataReader.Read Then

                    Username.Text = dbDataReader(1).ToString()
                    Dim DOB As String = dbDataReader(2).ToString()
                    Dim SplitPart = DOB.Split(" "c)
                    Dim final As String = SplitPart(0).Trim
                    DateOfBirth.Text = (String.Format("{0}", final)).ToString
                    PlaceOfBirth.Text = dbDataReader(3).ToString()
                    EmailID.Text = LCase(dbDataReader(4)).ToString()
                    Label5.Visible = False
                    Status.Visible = False
                    Dim LoadPic As Byte() = dbDataReader("TeacherPic")
                    Dim Memory As New MemoryStream(LoadPic)
                    PicID.Image = Image.FromStream(Memory)

                End If

                dbConnection.Close()
                dbDataReader.Close()

                Return

            End If

        Catch ex As Exception

            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
            Exit Try

        End Try

    End Sub

End Class