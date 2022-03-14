Imports System.Data.OleDb
Imports Microsoft.Office.Interop

Public Class LoginHistory

    Dim constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb"

    Sub Clear()

        LogIDTextBox.Text = ""
        UsernameTextBox.Text = ""
        PositionTextBox.Text = ""
        LoginDateDateTimePicker.Value = Now
        TimeInTextBox.Text = ""
        TimeOutTextBox.Text = ""
        RemarkTextBox.Text = ""

    End Sub


    Private Function Load_Logs(ByVal sSQL As String)

        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        Try

            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            cmd.CommandText = sSQL
            da.SelectCommand = cmd
            da.Fill(dt)

            DataGridView1.DataSource = dt
            If dt.Rows.Count = 0 Then

            Else

                lblLogs.Text = "Number of logs: " & DataGridView1.RowCount

            End If

        Catch ex As Exception

            MsgBox(ErrorToString)

        Finally

            conn.Close()

        End Try

    End Function

    Sub FilterLogs()

        If rdoAllDates.Checked Then

            Load_Logs("SELECT * FROM LogHistory order by LoginDate DESC")

            MonthCalendar1.Enabled = False
            PanelSearchUsername.Visible = False

            If DataGridView1.CurrentRow Is Nothing Then

                Clear()

            ElseIf DataGridView1.CurrentRow IsNot DBNull.Value Then

                Try

                    Dim LogID As String = DataGridView1.CurrentRow.Cells(0).Value
                    LogIDTextBox.Text = LogID

                    Dim Username As String = DataGridView1.CurrentRow.Cells(1).Value
                    UsernameTextBox.Text = Username

                    Dim Position As String = DataGridView1.CurrentRow.Cells(2).Value
                    PositionTextBox.Text = Position

                    Dim LoginDate As String = DataGridView1.CurrentRow.Cells(3).Value
                    LoginDateDateTimePicker.Value = LoginDate

                    Dim TimeIn As String = DataGridView1.CurrentRow.Cells(4).Value
                    TimeInTextBox.Text = TimeIn

                    Dim TimeOut As String = DataGridView1.CurrentRow.Cells(5).Value
                    TimeOutTextBox.Text = TimeOut

                    Dim Remark As String = DataGridView1.CurrentRow.Cells(6).Value
                    RemarkTextBox.Text = Remark

                    LogIDTextBox.BackColor = Color.White
                    UsernameTextBox.BackColor = Color.White
                    PositionTextBox.BackColor = Color.White
                    LoginDateDateTimePicker.BackColor = Color.White
                    TimeInTextBox.BackColor = Color.White
                    TimeOutTextBox.BackColor = Color.White
                    RemarkTextBox.BackColor = Color.White

                    lblLogs.Text = "Number of logs: " & DataGridView1.RowCount

                Catch ex As Exception

                    MessageBox.Show(ex.Message.ToString(), "Failed to Load 'Login Data'")
                    Exit Sub

                End Try

            End If

        ElseIf rdoSelectedDates.Checked Then

            Load_Logs("SELECT * FROM LogHistory WHERE LoginDate>=#" & MonthCalendar1.SelectionStart & "# AND LoginDate<=#" & MonthCalendar1.SelectionEnd & "#" & " order by LoginDate DESC")

            MonthCalendar1.Enabled = True
            PanelSearchUsername.Visible = False


            If DataGridView1.CurrentRow Is Nothing Then

                Clear()

            ElseIf DataGridView1.CurrentRow IsNot DBNull.Value Then

                Try

                    Dim LogID As String = DataGridView1.CurrentRow.Cells(0).Value
                    LogIDTextBox.Text = LogID

                    Dim Username As String = DataGridView1.CurrentRow.Cells(1).Value
                    UsernameTextBox.Text = Username

                    Dim Position As String = DataGridView1.CurrentRow.Cells(2).Value
                    PositionTextBox.Text = Position

                    Dim LoginDate As String = DataGridView1.CurrentRow.Cells(3).Value
                    LoginDateDateTimePicker.Value = LoginDate

                    Dim TimeIn As String = DataGridView1.CurrentRow.Cells(4).Value
                    TimeInTextBox.Text = TimeIn

                    Dim TimeOut As String = DataGridView1.CurrentRow.Cells(5).Value
                    TimeOutTextBox.Text = TimeOut

                    Dim Remark As String = DataGridView1.CurrentRow.Cells(6).Value
                    RemarkTextBox.Text = Remark

                    LogIDTextBox.BackColor = Color.White
                    UsernameTextBox.BackColor = Color.White
                    PositionTextBox.BackColor = Color.White
                    LoginDateDateTimePicker.BackColor = Color.White
                    TimeInTextBox.BackColor = Color.White
                    TimeOutTextBox.BackColor = Color.White
                    RemarkTextBox.BackColor = Color.White

                    lblLogs.Text = "Number of logs: " & DataGridView1.RowCount

                Catch ex As Exception

                    MessageBox.Show(ex.Message.ToString(), "Failed to Load 'Login Data'")
                    Exit Sub

                End Try

            End If

        ElseIf rdoUsername.Checked Then

            txtSearchUsername.Focus()

            Load_Logs("SELECT * FROM LogHistory WHERE Username='" & txtSearchUsername.Text & "' order by LoginDate DESC")

            MonthCalendar1.Enabled = False
            PanelSearchUsername.Visible = True

            If DataGridView1.CurrentRow Is Nothing Then

                Clear()

            ElseIf DataGridView1.CurrentRow IsNot DBNull.Value Then

                Try

                    Dim LogID As String = DataGridView1.CurrentRow.Cells(0).Value
                    LogIDTextBox.Text = LogID

                    Dim Username As String = DataGridView1.CurrentRow.Cells(1).Value
                    UsernameTextBox.Text = Username

                    Dim Position As String = DataGridView1.CurrentRow.Cells(2).Value
                    PositionTextBox.Text = Position

                    Dim LoginDate As String = DataGridView1.CurrentRow.Cells(3).Value
                    LoginDateDateTimePicker.Value = LoginDate

                    Dim TimeIn As String = DataGridView1.CurrentRow.Cells(4).Value
                    TimeInTextBox.Text = TimeIn

                    Dim TimeOut As String = DataGridView1.CurrentRow.Cells(5).Value
                    TimeOutTextBox.Text = TimeOut

                    Dim Remark As String = DataGridView1.CurrentRow.Cells(6).Value
                    RemarkTextBox.Text = Remark

                    LogIDTextBox.BackColor = Color.White
                    UsernameTextBox.BackColor = Color.White
                    PositionTextBox.BackColor = Color.White
                    LoginDateDateTimePicker.BackColor = Color.White
                    TimeInTextBox.BackColor = Color.White
                    TimeOutTextBox.BackColor = Color.White
                    RemarkTextBox.BackColor = Color.White

                    lblLogs.Text = "Number of logs: " & DataGridView1.RowCount

                Catch ex As Exception

                    MessageBox.Show(ex.Message.ToString(), "Failed to Load 'Login Data'")
                    Exit Sub

                End Try

            End If

        End If

    End Sub


    Private Sub RoundButtonDeleteAll(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 12)

        Dim Raduis As New Drawing2D.GraphicsPath
        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnDeleteAll.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnDeleteAll.Region = New Region(Raduis)

    End Sub

    Private Sub RoundButtonExport(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 12)

        Dim Raduis As New Drawing2D.GraphicsPath
        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnExport.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()

        btnExport.Region = New Region(Raduis)

    End Sub

    Private Sub LogHistoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LogHistoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LogHistoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Pre_enrollmentDataSet1)

    End Sub

    Private Sub LoginHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Pre_enrollmentDataSet1.LogHistory' table. You can move, or remove it, as needed.
        Me.LogHistoryTableAdapter.Fill(Me._Pre_enrollmentDataSet1.LogHistory)

        MonthCalendar1.TodayDate = Now
        MonthCalendar1.MaxDate = Now

        RoundButtonDeleteAll(btnDeleteAll)
        RoundButtonExport(btnExport)

        If DataGridView1.CurrentRow Is Nothing Then

            Clear()

        ElseIf DataGridView1.CurrentRow IsNot DBNull.Value Then

            Try

                Dim LogID As String = DataGridView1.CurrentRow.Cells(0).Value
                LogIDTextBox.Text = LogID

                Dim Username As String = DataGridView1.CurrentRow.Cells(1).Value
                UsernameTextBox.Text = Username

                Dim Position As String = DataGridView1.CurrentRow.Cells(2).Value
                PositionTextBox.Text = Position

                Dim LoginDate As String = DataGridView1.CurrentRow.Cells(3).Value
                LoginDateDateTimePicker.Value = LoginDate

                Dim TimeIn As String = DataGridView1.CurrentRow.Cells(4).Value
                TimeInTextBox.Text = TimeIn

                Dim TimeOut As String = DataGridView1.CurrentRow.Cells(5).Value
                TimeOutTextBox.Text = TimeOut

                Dim Remark As String = DataGridView1.CurrentRow.Cells(6).Value
                RemarkTextBox.Text = Remark

                LogIDTextBox.BackColor = Color.White
                UsernameTextBox.BackColor = Color.White
                PositionTextBox.BackColor = Color.White
                LoginDateDateTimePicker.BackColor = Color.White
                TimeInTextBox.BackColor = Color.White
                TimeOutTextBox.BackColor = Color.White
                RemarkTextBox.BackColor = Color.White

                lblLogs.Text = "Number of logs: " & DataGridView1.RowCount

            Catch ex As Exception

                MessageBox.Show(ex.Message.ToString(), "Failed to Load 'Login Data'")
                Exit Sub

            End Try

        End If

        ' Auto Completion Search Username
        Dim SearchUsernameConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database\Pre-enrollment.accdb")
        If SearchUsernameConnection.State = ConnectionState.Open Then SearchUsernameConnection.Close()
        SearchUsernameConnection.Open()

        Dim SearchUsernameCommand As New OleDbCommand("Select Username from LogHistory", SearchUsernameConnection)
        Dim SearchUsernameDataAdapter As New OleDbDataAdapter(SearchUsernameCommand)
        Dim SearchUsernameDataSet As New DataSet
        SearchUsernameDataAdapter.Fill(SearchUsernameDataSet)
        Dim SearchUsernameColumn As New AutoCompleteStringCollection
        Dim j As Integer
        For j = 0 To SearchUsernameDataSet.Tables(0).Rows.Count - 1
            SearchUsernameColumn.Add(SearchUsernameDataSet.Tables(0).Rows(j)("Username").ToString())
        Next
        txtSearchUsername.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtSearchUsername.AutoCompleteCustomSource = SearchUsernameColumn
        txtSearchUsername.AutoCompleteMode = AutoCompleteMode.SuggestAppend

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

        If rdoSelectedDates.Checked Then

            Load_Logs("SELECT * FROM LogHistory WHERE LoginDate>=#" & MonthCalendar1.SelectionStart & "# AND LoginDate<=#" & MonthCalendar1.SelectionEnd & "#")

            lblLogs.Text = String.Format("Number of logs: {0}", DataGridView1.RowCount)

        End If

    End Sub

    Private Sub TxtSearchUsername_TextChanged(sender As Object, e As EventArgs) Handles txtSearchUsername.TextChanged

        Load_Logs("SELECT * FROM LogHistory WHERE Username='" & txtSearchUsername.Text & "' order by LoginDate DESC")

        lblLogs.Text = String.Format("Number of logs: {0}", DataGridView1.RowCount)

        If DataGridView1.CurrentRow Is Nothing Then

            Clear()

        ElseIf DataGridView1.CurrentRow IsNot DBNull.Value Then

            Try

                Dim LogID As String = DataGridView1.CurrentRow.Cells(0).Value
                LogIDTextBox.Text = LogID

                Dim Username As String = DataGridView1.CurrentRow.Cells(1).Value
                UsernameTextBox.Text = Username

                Dim Position As String = DataGridView1.CurrentRow.Cells(2).Value
                PositionTextBox.Text = Position

                Dim LoginDate As String = DataGridView1.CurrentRow.Cells(3).Value
                LoginDateDateTimePicker.Value = LoginDate

                Dim TimeIn As String = DataGridView1.CurrentRow.Cells(4).Value
                TimeInTextBox.Text = TimeIn

                Dim TimeOut As String = DataGridView1.CurrentRow.Cells(5).Value
                TimeOutTextBox.Text = TimeOut

                Dim Remark As String = DataGridView1.CurrentRow.Cells(6).Value
                RemarkTextBox.Text = Remark

                LogIDTextBox.BackColor = Color.White
                UsernameTextBox.BackColor = Color.White
                PositionTextBox.BackColor = Color.White
                LoginDateDateTimePicker.BackColor = Color.White
                TimeInTextBox.BackColor = Color.White
                TimeOutTextBox.BackColor = Color.White
                RemarkTextBox.BackColor = Color.White

                lblLogs.Text = "Number of logs: " & DataGridView1.RowCount

            Catch ex As Exception

                MessageBox.Show(ex.Message.ToString(), "Failed to Load 'Login Data'")
                Exit Sub

            End Try

        End If

    End Sub

    Private Sub LogHistoryBindingSource_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles LogHistoryBindingSource.ListChanged

        lblLogs.Text = String.Format("Number of logs: {0}", DataGridView1.RowCount)

    End Sub

    Private Sub RdoAllDates_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAllDates.CheckedChanged

        FilterLogs()

        lblLogs.Text = String.Format("Number of logs: {0}", DataGridView1.RowCount)

    End Sub

    Private Sub RdoSelectedDates_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSelectedDates.CheckedChanged

        FilterLogs()

        lblLogs.Text = String.Format("Number of logs: {0}", DataGridView1.RowCount)

    End Sub

    Private Sub RdoUsername_CheckedChanged(sender As Object, e As EventArgs) Handles rdoUsername.CheckedChanged

        FilterLogs()

        lblLogs.Text = String.Format("Number of logs: {0}", DataGridView1.RowCount)

        txtSearchUsername.Text = ""

    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If DataGridView1.RowCount = Nothing Then

            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Exit Sub

        End If

        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        Cursor.Current = Cursors.WaitCursor
        Dim xlApp As New Excel.Application

        Try

            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = DataGridView1.RowCount
            colsTotal = DataGridView1.Columns.Count - 1

            With excelWorksheet

                .Cells.Select()
                .Cells.Delete()

                For iC = 0 To colsTotal

                    .Cells(1, iC + 1).Value = DataGridView1.Columns(iC).HeaderText

                Next

                For I = 0 To rowsTotal - 1

                    For j = 0 To colsTotal

                        .Cells(I + 2, j + 1).value = DataGridView1.Rows(I).Cells(j).Value

                    Next j

                Next I

                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()

            End With

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error on 'Export Excel'", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        Finally

            Cursor.Current = Cursors.Default
            xlApp = Nothing

        End Try

    End Sub

    Private Sub BtnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click

        Try

            If DataGridView1.Rows.Count > 0 Then

                If MessageBox.Show("Are you sure want to delete all logs?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

                    Using conn As New OleDbConnection(constring)

                        conn.Open()
                        Dim command As New OleDbCommand("DELETE * from LogHistory", conn)
                        command.ExecuteNonQuery()
                        command.Dispose()
                        conn.Close()

                    End Using

                    Load_Logs("SELECT * FROM LogHistory order by LoginDate DESC")

                End If

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error on 'Delete All'", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try

            Dim LogID As String = DataGridView1.CurrentRow.Cells(0).Value
            LogIDTextBox.Text = LogID

            Dim Username As String = DataGridView1.CurrentRow.Cells(1).Value
            UsernameTextBox.Text = Username

            Dim Position As String = DataGridView1.CurrentRow.Cells(2).Value
            PositionTextBox.Text = Position

            Dim LoginDate As String = DataGridView1.CurrentRow.Cells(3).Value
            LoginDateDateTimePicker.Value = LoginDate

            Dim TimeIn As String = DataGridView1.CurrentRow.Cells(4).Value
            TimeInTextBox.Text = TimeIn

            Dim TimeOut As String = DataGridView1.CurrentRow.Cells(5).Value
            TimeOutTextBox.Text = TimeOut

            Dim Remark As String = DataGridView1.CurrentRow.Cells(6).Value
            RemarkTextBox.Text = Remark

            LogIDTextBox.BackColor = Color.White
            UsernameTextBox.BackColor = Color.White
            PositionTextBox.BackColor = Color.White
            LoginDateDateTimePicker.BackColor = Color.White
            TimeInTextBox.BackColor = Color.White
            TimeOutTextBox.BackColor = Color.White
            RemarkTextBox.BackColor = Color.White

        Catch ex As Exception

            MessageBox.Show(ex.Message.ToString(), "Failed to Load 'Login Data'")
            Exit Sub

        End Try

    End Sub

    Private Sub TxtSearchUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchUsername.KeyPress

        'Allowed letters numbers and ( _ $ *)
        If e.KeyChar <> ControlChars.Back = True Then

            If "~`@%^&+={[}]()!:,;'><?/|\-.#+".IndexOf(e.KeyChar) = -1 = False Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub PicHelp1_Click(sender As Object, e As EventArgs) Handles picHelp1.Click

        LoginHistoryGuide.Show()

        picHelp1.Visible = False

    End Sub

End Class