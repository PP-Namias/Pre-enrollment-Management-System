Imports System.ComponentModel

Public Class TeacherDataGuide

    Private Sub TeacherDataGuide_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TeacherDataGuide_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        TeacherData.picHelp1.Visible = True

    End Sub

End Class