Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class CapturePicture

    Dim gbCamera As VideoCaptureDevice
    Dim bmp As Bitmap

    Private Sub RoundButtonStartCamera(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnStartCamera.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnStartCamera.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonCapture(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnCapture.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnCapture.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonSavePicture(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnSavePicture.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnSavePicture.Region = New Region(Raduis)

    End Sub

    Private Sub Captures(sender As Object, eventArgs As NewFrameEventArgs)

        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)

    End Sub

    Private Sub CapturePicture_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Try

            If TeacherData.cmbCapture.Text = "TeacherInfo" Then

                TeacherData.cmbCapture.Text = ""

            ElseIf StudentEnrollment.cmbEnrollment.Text = "Enrollment" Then

                StudentEnrollment.cmbEnrollment.Text = ""

            ElseIf EnrollmentData.cmbCapture.Text = "EnrollmentData" Then

                EnrollmentData.cmbCapture.Text = ""

            ElseIf ChangeInfo.cmbCapture.Text = "ChangeInfo" Then

                ChangeInfo.cmbCapture.Text = ""

            End If

            If gbCamera Is Nothing Then

                'do nothing

            Else

                gbCamera.Stop()

            End If

        Catch ex As Exception

            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Camera error")
            Exit Sub

        End Try

    End Sub

    Private Sub BtnStartCamera_Click(sender As Object, e As EventArgs) Handles btnStartCamera.Click

        Try

            Dim camera As New VideoCaptureDeviceForm

            If camera.ShowDialog() = Windows.Forms.DialogResult.OK Then

                gbCamera = camera.VideoDevice
                AddHandler gbCamera.NewFrame, New NewFrameEventHandler(AddressOf Captures)
                gbCamera.Start()

            End If

        Catch ex As Exception

            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Camera error")
            Exit Sub

        End Try

    End Sub

    Private Sub BtnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click

        PictureBox2.Image = PictureBox1.Image

        If TeacherData.cmbCapture.Text = "TeacherData" Then

            TeacherData.PictureID.Image = PictureBox1.Image

        ElseIf EnrollmentData.cmbCapture.Text = "EnrollmentData" Then

            EnrollmentData.PictureID.Image = PictureBox1.Image

        ElseIf StudentEnrollment.cmbEnrollment.Text = "Enrollment" Then

            StudentEnrollment.StudentPic.Image = PictureBox1.Image

        ElseIf ChangeInfo.cmbCapture.Text = "ChangeInfo" Then

            ChangeInfo.IDPicture.Image = PictureBox1.Image

        End If

    End Sub

    Private Sub BtnSavePicture_Click(sender As Object, e As EventArgs) Handles btnSavePicture.Click

        SaveFileDialog1.DefaultExt = ".jpg"

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            PictureBox2.Image.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)

        End If

    End Sub

    Private Sub CapturePicture_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RoundButtonStartCamera(btnStartCamera)
        RoundButtonCapture(btnCapture)
        RoundButtonSavePicture(btnSavePicture)

    End Sub

End Class