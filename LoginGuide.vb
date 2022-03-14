Imports System.ComponentModel

Public Class LoginGuide

    Private Sub LoginGuide_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginGuide_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        LoginForm.picHelp1.Visible = True
        LoginForm.picHelp2.Visible = True
        LoginForm.picHelp3.Visible = True

    End Sub

End Class