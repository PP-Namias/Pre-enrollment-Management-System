Public Class AboutMe

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Process.Start("https://github.com/PP-Namias")

    End Sub

    Private Sub AboutMe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class