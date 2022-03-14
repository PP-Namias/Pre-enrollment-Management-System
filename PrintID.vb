Public Class PrintID

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then

            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()

        End If

    End Sub

    Private Sub PrintID_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class