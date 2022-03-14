Imports System.ComponentModel

Public Class StudentEnrollmentGuide

    Private Sub StudentEnrollmentGuide_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub StudentEnrollmentGuide_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        StudentEnrollment.PictureBox2.Visible = True

    End Sub

End Class