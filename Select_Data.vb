Imports System.Data.OleDb

Public Class Select_Student

    Dim cn As New System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand
    Dim myDA As System.Data.OleDb.OleDbDataAdapter
    Dim myDataSet As System.Data.DataSet

    Sub DataSetFill()
        Try
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\BackUp\Database.Accdb;Persist Security Info=False;"
            If cn.State - System.Data.ConnectionState.Closed Then
                cn.Open()
            End If
            cmd = New System.Data.OleDb.OleDbCommand("SELECT (UserName)as [User Name],(DateOfBirth)as [Date Of Birth],(PlaceOfBirth) as [Place Of Birth],(EmailID)as [Email ID], (UserID) as [User ID], (Pass)as [Password] FROM UserInfo ", cn)
            myDA = New System.Data.OleDb.OleDbDataAdapter(cmd)
            myDataSet = New System.Data.DataSet
            myDA.Fill(myDataSet, "UserInfo")
            DataGridView1.DataSource = myDataSet.Tables("UserInfo").DefaultView
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Select_Student_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        FrmMain.Show()
    End Sub

    Private Sub Select_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DataSetFill()
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Try
            If MessageBox.Show("Do you really want to delete the record?", "Response", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\BackUp\Database.Accdb;Persist Security Info=False;")
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
                cn.Open()
                Dim temp As Integer = 0
                Dim cq As String = "delete from Userinfo where UserID=@DELETE1;"

                cmd = New OleDbCommand(cq)
                cmd.Connection = cn

                cmd.Parameters.Add(New OleDbParameter("@DELETE1", System.Data.OleDb.OleDbType.VarChar, 8, "UserID"))
                cmd.Parameters("@DELETE1").Value = DataGridView1.SelectedCells(4).Value.ToString()

                temp = cmd.ExecuteNonQuery()
                If temp > 0 Then
                    cn.Close()
                    Call DataSetFill()
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    Call DataSetFill()
                    MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class