Imports System.Data.OleDb
Imports System.IO

Public Class SchoolInfo
    Dim databaseConnection As New OleDbConnection
    Dim databaseCommand As OleDbCommand
    Dim myDataAdapter As OleDbDataAdapter
    Dim myDataSet As DataSet

    Sub DataSetFill()

        Try

            databaseConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\BackUp\Database.Accdb;Persist Security Info=False;"

            If databaseConnection.State - ConnectionState.Closed Then

                databaseConnection.Open()

            End If

            databaseCommand = New OleDbCommand("SELECT (RegistrarName)as [Registrar Name],(GradeLevel)as [Grade Level],(DOB) as [Date of Birth] FROM SchoolInfo ", databaseConnection)
            myDataAdapter = New OleDbDataAdapter(databaseCommand)
            myDataSet = New DataSet
            myDataAdapter.Fill(myDataSet, "SchoolInfo")
            DataGridView1.DataSource = myDataSet.Tables("SchoolInfo").DefaultView
            databaseConnection.Close()

        Catch ex As Exception

            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
            Exit Sub

        End Try

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click

        Try

            If MessageBox.Show("Do you really want to delete the record?", "Response", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim DataConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\BackUp\Database.Accdb;Persist Security Info=False;")

                If DataConnection.State = ConnectionState.Open Then

                    DataConnection.Close()

                End If

                DataConnection.Open()
                Dim temp As Integer = 0
                Dim delete As String = "delete from SchoolInfo where RegistrarName=@DELETE1;"

                databaseCommand = New OleDbCommand(delete) With {
                    .Connection = DataConnection
                }

                databaseCommand.Parameters.Add(New OleDbParameter("@DELETE1", OleDbType.VarChar, 45, "RegistrarName"))
                databaseCommand.Parameters("@DELETE1").Value = DataGridView1.SelectedCells(2).Value.ToString()

                temp = databaseCommand.ExecuteNonQuery()

                If temp > 0 Then

                    DataConnection.Close()
                    Call DataSetFill()
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    Call DataSetFill()
                    MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
            Exit Sub

        End Try

    End Sub

    Private Function RequiredEntry() As Boolean

        If txtRegistrarName.Text = "" Or cmbGradeLevel.Text = "" Then

            MsgBox("Please enter all information....", MsgBoxStyle.Critical, "Attention")
            Return True
            Exit Function

        End If

    End Function

    Private Sub SchoolInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call DataSetFill()

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowsePic.Click

        Dim OpenFile As New OpenFileDialog()

        Try

            With OpenFile
                .FileName = ""
                .Title = "Photo:"
                .Filter = "Image files: (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.Gif)|*.Gif|(*.bmp)|*.bmp| All Files (*.*)|*.*"

                If .ShowDialog = Windows.Forms.DialogResult.OK Then

                    RegistrarPic.Image = Image.FromFile(.FileName)

                End If

            End With

        Catch ex As Exception

            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
            Exit Sub

        End Try

    End Sub

    Private Sub btnRemovePic_Click(sender As Object, e As EventArgs) Handles btnRemovePic.Click

        RegistrarPic.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Image\personal.png")

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If RequiredEntry() = True Then

            Return

        End If

        Try

            Dim RegisterConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\BackUp\Database.accdb;Persist Security Info=False;")
            If RegisterConnection.State = ConnectionState.Open Then

                RegisterConnection.Close()

            End If

            RegisterConnection.Open()

            Dim RegisterCommand As New OleDbCommand("insert into SchoolInfo (RegistrarName,GradeLevel,DOB,Picture,Signature) values(@d1,@d2,@d3,@d4,@d5)", RegisterConnection)

            ' Registrar Name 
            Dim RegistrarName As New OleDbParameter("@d1", OleDbType.VarWChar, 30) With {
                    .Value = txtRegistrarName.Text.ToString().ToUpper
                }
            RegisterCommand.Parameters.Add(RegistrarName)

            ' Grade Level
            Dim GradeLevel As New OleDbParameter("@d2", OleDbType.VarWChar, 30) With {
                    .Value = cmbGradeLevel.Text.ToString().ToUpper
                }
            RegisterCommand.Parameters.Add(GradeLevel)

            'Date of Birth
            Dim DOB As New OleDbParameter("@d3", OleDbType.Date, 15) With {
                .Value = dtpDOB.Text.ToString()
            }
            RegisterCommand.Parameters.Add(DOB)

            'Registrar Picture
            Dim RegistrarMemStream As New MemoryStream
            Dim RegistrarPicture As Byte()

            RegistrarPic.Image.Save(RegistrarMemStream,
                                    Imaging.ImageFormat.Png)
            RegistrarPicture = RegistrarMemStream.GetBuffer()
            RegistrarMemStream.Read(RegistrarPicture, 0, RegistrarMemStream.Length)

            Dim Photo As New OleDbParameter("@d4", SqlDbType.Image) With {
                .Value = RegistrarPicture
            }
            RegisterCommand.Parameters.Add(Photo)

            'Signature Picture 
            Dim SignatureMemStream As New MemoryStream
            Dim SignaturePic_Update As Byte()

            SignaturePic.Image.Save(SignatureMemStream,
                                    Imaging.ImageFormat.Png)
            SignaturePic_Update = SignatureMemStream.GetBuffer()
            SignatureMemStream.Read(SignaturePic_Update, 0, SignatureMemStream.Length)

            Dim SinaturePhoto As New OleDbParameter("@d5", SqlDbType.Image) With {
                .Value = SignaturePic_Update
            }
            RegisterCommand.Parameters.Add(SinaturePhoto)

            If RegisterCommand.ExecuteNonQuery() Then

                RegisterConnection.Close()
                MsgBox("New registrar registered successfully... ", MsgBoxStyle.Information, "Record Saved")
                DataSetFill()

            Else

                MsgBox("New registrar registration failed... ", MsgBoxStyle.Critical, "Registration failed")
                Return

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message.ToString(), "Data Error")
            Exit Sub

        End Try
    End Sub

    Private Sub btnBrowseSignature_Click(sender As Object, e As EventArgs) Handles btnBrowseSignature.Click

        Dim OpenFile As New OpenFileDialog()

        Try

            With OpenFile
                .FileName = ""
                .Title = "Photo:"
                .Filter = "Image files: (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.Gif)|*.Gif|(*.bmp)|*.bmp| All Files (*.*)|*.*"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    RegistrarPic.Image = Image.FromFile(.FileName)
                End If
            End With

        Catch ex As Exception

            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
            Exit Sub

        End Try

    End Sub

    Private Sub btnRemoveSignature_Click(sender As Object, e As EventArgs) Handles btnRemoveSignature.Click

        SignaturePic.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Image\signature.png")

    End Sub

End Class