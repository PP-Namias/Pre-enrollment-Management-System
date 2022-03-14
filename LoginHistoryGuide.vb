Imports System.ComponentModel

Public Class LoginHistoryGuide

    Private Sub LoginHistoryGuide_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginHistoryGuide_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        LoginHistory.picHelp1.Visible = True

    End Sub

End Class