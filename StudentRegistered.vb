Public Class StudentRegistered

    Private Sub RoundButton(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 14)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnProceed.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()
        btnProceed.Region = New Region(Raduis)

    End Sub

    Private Sub StudentRegistered_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RoundButton(btnProceed)

        lblName.Text = StudentEnrollment.txtLastname.Text & ", " & StudentEnrollment.txtFirstname.Text & " " & StudentEnrollment.txtMiddlename.Text
        lblStatus.Text = "reserved"
        lblReferenceNumber.Text = "yasc" & StudentEnrollment.txtEnrollmentNo.Text
        lblDateExpire.Text = (StudentEnrollment.dtbIdentify.Value).AddDays(14).ToString(" MMM / d / yyyy")
        lblReferenceNumber2.Text = "'" & "yasc" & StudentEnrollment.txtEnrollmentNo.Text & "'"

    End Sub

    Private Sub BtnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click

        Dim yesno As Integer = MessageBox.Show("Do you really want to close? ", "Successfully Pre-enrolled", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If yesno = MsgBoxResult.No Then
            Return

        Else
            MsgBox("Thank you for choosing Young Achievers` School of Caloocan." & vbNewLine & "Please do not share the student's unique reference number", MsgBoxStyle.Information, "Successfully Pre-enrolled")
            StudentEnrollment.Panel1.Visible = True
            StudentEnrollment.PictureBox1.Visible = True
            StudentEnrollment.Clear()
            Hide()

        End If

    End Sub

End Class