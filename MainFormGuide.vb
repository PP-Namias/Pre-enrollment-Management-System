Imports System.ComponentModel

Public Class MainFormGuide

    Private Sub MainFormGuide_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MainFormGuide_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        MainForm.PictureBox1.Visible = True

    End Sub

End Class