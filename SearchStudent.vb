Public Class SearchStudent

    Private Sub SearchStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ListView1.View = View.Details

        Me.filllistview()
    End Sub


    Sub filllistview()
        strsql_Namias = "select * from [NAMIAS]"
        Dim acsmd As New OleDb.OleDbCommand
        acsmd.CommandText = strsql_Namias
        acsmd.Connection = acsconn_ICT2Namias
        acsda_Namias.SelectCommand = acsmd
        acsdr_Namias = acsmd.ExecuteReader
        ListView1.Items.Clear()

        While (acsdr_Namias.Read())
            With ListView1.Items.Add(acsdr_Namias("LASTNAME").ToString)
                .SubItems.Add(acsdr_Namias("FIRSTNAME").ToString)
                .SubItems.Add(acsdr_Namias("MI").ToString)
                .SubItems.Add(acsdr_Namias("STUDENT_NO").ToString)
                .SubItems.Add(acsdr_Namias("LRN").ToString)
                .SubItems.Add(acsdr_Namias("STRAND_SECTION").ToString)
                .SubItems.Add(acsdr_Namias("GRADE_LEVEL").ToString)
            End With
        End While

        acsmd.Dispose()
        acsdr_Namias.Close()
    End Sub


 


    Sub SearchRecord1(ByVal searchword As String)

        strsql_Namias = "select * from NAMIAS where LRN like '" & txtSearchLRN.Text & "%'"

        Dim acsmd As New OleDb.OleDbCommand
        acsmd.CommandText = strsql_Namias
        acsmd.Connection = acsconn_ICT2Namias
        acsda_Namias.SelectCommand = acsmd
        acsdr_Namias = acsmd.ExecuteReader


        ListView1.Items.Clear()

        While (acsdr_Namias.Read())
            With ListView1.Items.Add(acsdr_Namias("LASTNAME").ToString)
                .SubItems.Add(acsdr_Namias("FIRSTNAME").ToString)
                .SubItems.Add(acsdr_Namias("MI").ToString)
                .SubItems.Add(acsdr_Namias("STUDENT_NO").ToString)
                .SubItems.Add(acsdr_Namias("LRN").ToString)
                .SubItems.Add(acsdr_Namias("STRAND_SECTION").ToString)
                .SubItems.Add(acsdr_Namias("GRADE_LEVEL").ToString)
            End With
        End While

        acsmd.Dispose()
        acsdr_Namias.Close()




    End Sub


    Private Sub txtSearchLRN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchLRN.TextChanged
        SearchRecord1(txtSearchLRN.Text)

    End Sub
End Class