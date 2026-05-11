Imports System.Drawing.Drawing2D
Imports System.Globalization

Public Class Dashboard

    ' Shared employee page
    Public Shared employeePage As New EmployeePage

    ' Shared payroll page
    Public Shared payrollPage As New Payroll

    ' Registration form instance
    Dim registerForm As New Registration

    ' Track active navigation button
    Dim activeButton As Button = Nothing

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set background colors
        Me.BackColor = Color.FromArgb(245, 247, 250)
        Panel1.BackColor = Color.FromArgb(245, 247, 250)
        Panel2.BackColor = Color.FromArgb(245, 247, 250)
        Panel3.BackColor = Color.FromArgb(245, 247, 250)
        Panel4.BackColor = Color.FromArgb(245, 247, 250)
        Avgdailyratepnl.BackColor = Color.FromArgb(245, 247, 250)
        Employeepnl.BackColor = Color.FromArgb(245, 247, 250)
        Overtimepnl.BackColor = Color.FromArgb(245, 247, 250)
        Bydepartmentpnl.BackColor = Color.FromArgb(245, 247, 250)
        Dashboardlbl.BackColor = Color.FromArgb(245, 247, 250)
        datelbl.BackColor = Color.FromArgb(245, 247, 250)

        ' Configure PictureBox sizing
        Dashboardpb.SizeMode = PictureBoxSizeMode.Zoom
        Employeepb.SizeMode = PictureBoxSizeMode.Zoom
        Payrollpb.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        profilelogo.SizeMode = PictureBoxSizeMode.Zoom

        ' Apply panel styling
        styleBorderPanel(Employeepnl)
        styleBorderPanel(Avgdailyratepnl)
        styleBorderPanel(Overtimepnl)
        styleBorderPanel(Bydepartmentpnl)
        styleOutlinePanel(Panel1)
        styleOutlinePanel(Panel2)
        styleOutlinePanel(Panel3)
        styleOutlinePanel(Panel4)

        ' Style navigation buttons
        makeTransparentButton(Dashbaordbtn)
        makeTransparentButton(Emplyoyeebtn)
        makeTransparentButton(Payrollbtn)
        makeTransparentButton(logoutbtn)

        ' Style action buttons
        makeBlueRoundedButton(addempbtn)

        ' Configure employee page
        employeePage.Location = New Point(0, 75)
        employeePage.Size = New Size(Panel1.Width, Panel1.Height - 75)
        employeePage.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.Controls.Add(employeePage)
        employeePage.Hide()

        ' Configure payroll page
        payrollPage.TopLevel = False
        payrollPage.FormBorderStyle = FormBorderStyle.None
        payrollPage.Location = New Point(0, 75)
        payrollPage.Size = New Size(Panel1.Width, Panel1.Height - 75)
        payrollPage.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.Controls.Add(payrollPage)
        payrollPage.Hide()

        ' Hide action buttons on startup
        addempbtn.Hide()

        ' Set default active button
        setActiveButton(Dashbaordbtn)

        ' Configure department FlowLayoutPanel
        With departmentfp
            .FlowDirection = FlowDirection.TopDown
            .WrapContents = False
            .AutoScroll = True
            .BackColor = Color.Transparent
            .Padding = New Padding(0)
        End With

        ' Initialize dashboard statistics
        RefreshEmployeeCount()

    End Sub

    ' Apply blue rounded button style
    Private Sub makeBlueRoundedButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn.BackColor = Color.Transparent
        btn.ForeColor = Color.White
        btn.Font = New Font("Segoe UI Semibold", 10)
        btn.Cursor = Cursors.Hand

        AddHandler btn.Paint, Sub(s As Object, e As PaintEventArgs)
                                  Dim b As Button = CType(s, Button)
                                  Dim g As Graphics = e.Graphics
                                  g.SmoothingMode = SmoothingMode.AntiAlias

                                  Dim rect As New Rectangle(0, 0, b.Width - 1, b.Height - 1)
                                  Dim radius As Integer = 10
                                  Dim path As New GraphicsPath()

                                  path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
                                  path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
                                  path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
                                  path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
                                  path.CloseFigure()

                                  g.FillPath(New SolidBrush(Color.FromArgb(0, 120, 215)), path)
                                  TextRenderer.DrawText(g, b.Text, New Font("Segoe UI Semibold", 10), rect, Color.White, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
                              End Sub
    End Sub

    ' Refresh all dashboard statistics
    Public Sub RefreshEmployeeCount()
        Dim count As Integer = 0
        For Each row As DataGridViewRow In employeePage.DataGridView1.Rows
            If Not row.IsNewRow Then count += 1
        Next
        totalemplbl.Text = count.ToString()

        UpdateAverageDailyRate()
        UpdateAverageOvertimeHours()
        DrawPositionStats()
    End Sub

    ' Calculate and display average daily rate from column 2
    Public Sub UpdateAverageDailyRate()
        Dim totalRate As Decimal = 0
        Dim empCount As Integer = 0

        For Each row As DataGridViewRow In employeePage.DataGridView1.Rows
            If Not row.IsNewRow AndAlso row.Cells(2).Value IsNot Nothing Then
                Dim raw As String = row.Cells(2).Value.ToString().Trim()
                Dim rate As Decimal = 0
                If Decimal.TryParse(raw, NumberStyles.Any, CultureInfo.InvariantCulture, rate) Then
                    totalRate += rate
                    empCount += 1
                End If
            End If
        Next

        avgdrlbl.Text = If(empCount > 0, (totalRate / empCount).ToString("N2"), "0")
    End Sub

    ' Calculate and display average overtime hours from column 4
    Public Sub UpdateAverageOvertimeHours()
        Dim totalOT As Decimal = 0
        Dim empCount As Integer = 0

        For Each row As DataGridViewRow In employeePage.DataGridView1.Rows
            If Not row.IsNewRow AndAlso row.Cells(4).Value IsNot Nothing Then
                Dim raw As String = row.Cells(4).Value.ToString().Trim()
                Dim hours As Decimal = 0
                If Decimal.TryParse(raw, NumberStyles.Any, CultureInfo.InvariantCulture, hours) Then
                    totalOT += hours
                    empCount += 1
                End If
            End If
        Next

        Dim otLabel As Label = DirectCast(Overtimepnl.Controls("Label5"), Label)
        otLabel.Text = If(empCount > 0, (totalOT / empCount).ToString("N2"), "0")
    End Sub

    ' Draw position statistics in department panel
    Public Sub DrawPositionStats()
        ' Count employees by position
        Dim positionCounts As New Dictionary(Of String, Integer)(StringComparer.OrdinalIgnoreCase)

        For Each row As DataGridViewRow In employeePage.DataGridView1.Rows
            If Not row.IsNewRow AndAlso row.Cells(1).Value IsNot Nothing Then
                Dim pos As String = row.Cells(1).Value.ToString().Trim()
                If pos <> "" Then
                    If positionCounts.ContainsKey(pos) Then
                        positionCounts(pos) += 1
                    Else
                        positionCounts(pos) = 1
                    End If
                End If
            End If
        Next

        ' Clear existing controls
        departmentfp.Controls.Clear()
        departmentfp.VerticalScroll.Value = 0
        departmentfp.AutoScrollPosition = New Point(0, 0)

        ' Show empty message if no employees
        If positionCounts.Count = 0 Then
            Dim emptyLbl As New Label()
            emptyLbl.Text = "No employees added yet."
            emptyLbl.Font = New Font("Segoe UI", 8.5, FontStyle.Regular)
            emptyLbl.ForeColor = Color.FromArgb(180, 180, 180)
            emptyLbl.AutoSize = False
            emptyLbl.Size = New Size(departmentfp.Width - 10, 36)
            emptyLbl.TextAlign = ContentAlignment.MiddleCenter
            emptyLbl.BackColor = Color.Transparent
            departmentfp.Controls.Add(emptyLbl)
            Return
        End If

        ' Define position color mappings
        Dim bgMap As New Dictionary(Of String, Color)(StringComparer.OrdinalIgnoreCase)
        Dim fgMap As New Dictionary(Of String, Color)(StringComparer.OrdinalIgnoreCase)

        ' Executive positions (red)
        For Each p As String In {"CEO", "General Manager", "Manager", "Assistant Manager", "Supervisor", "Team Leader"}
            bgMap(p) = Color.FromArgb(255, 225, 225)
            fgMap(p) = Color.FromArgb(200, 50, 50)
        Next

        ' HR positions (green)
        For Each p As String In {"HR Manager", "HR Officer", "Recruitment Officer", "Human Resources"}
            bgMap(p) = Color.FromArgb(210, 245, 220)
            fgMap(p) = Color.FromArgb(40, 150, 80)
        Next

        ' Finance positions (orange)
        For Each p As String In {"Finance Manager", "Finance Officer", "Accountant", "Bookkeeper", "Payroll Officer", "Cashier"}
            bgMap(p) = Color.FromArgb(255, 238, 200)
            fgMap(p) = Color.FromArgb(190, 120, 20)
        Next

        ' IT positions (purple)
        For Each p As String In {"IT Manager", "IT Officer", "System Administrator", "Programmer", "Technical Support"}
            bgMap(p) = Color.FromArgb(235, 225, 255)
            fgMap(p) = Color.FromArgb(120, 70, 220)
        Next

        ' Operations positions (blue)
        For Each p As String In {"Operations Manager", "Operations Officer", "Operations Staff", "Logistics Officer", "Warehouse Staff"}
            bgMap(p) = Color.FromArgb(220, 235, 255)
            fgMap(p) = Color.FromArgb(45, 90, 200)
        Next

        ' Admin positions (light blue)
        For Each p As String In {"Admin Manager", "Admin Officer", "Admin Staff", "Executive Assistant", "Secretary", "Receptionist", "Office Clerk", "Data Encoder"}
            bgMap(p) = Color.FromArgb(225, 245, 255)
            fgMap(p) = Color.FromArgb(30, 120, 180)
        Next

        ' Sales & Marketing positions (pink)
        For Each p As String In {"Sales Manager", "Sales Officer", "Sales Representative", "Sales Associate", "Marketing Manager", "Marketing Officer", "Customer Service Representative"}
            bgMap(p) = Color.FromArgb(255, 230, 245)
            fgMap(p) = Color.FromArgb(190, 50, 130)
        Next

        ' Support positions (gray)
        For Each p As String In {"Security Officer", "Security Guard", "Driver", "Messenger", "Janitor", "Maintenance Staff", "Utility Worker"}
            bgMap(p) = Color.FromArgb(235, 235, 235)
            fgMap(p) = Color.FromArgb(90, 90, 90)
        Next

        ' Create position row for each position type
        For Each kvp As KeyValuePair(Of String, Integer) In positionCounts
            Dim capBgColor As Color = If(bgMap.ContainsKey(kvp.Key), bgMap(kvp.Key), Color.FromArgb(220, 230, 255))
            Dim capFgColor As Color = If(fgMap.ContainsKey(kvp.Key), fgMap(kvp.Key), Color.FromArgb(55, 95, 190))
            Dim capName As String = kvp.Key
            Dim capCount As Integer = kvp.Value

            Dim rowPnl As New Panel()
            rowPnl.Size = New Size(departmentfp.Width - 10, 38)
            rowPnl.BackColor = Color.White
            rowPnl.Margin = New Padding(0, 0, 0, 5)
            rowPnl.Cursor = Cursors.Default

            AddHandler rowPnl.Paint, Sub(sender As Object, e As PaintEventArgs)
                                         Dim pnl As Panel = CType(sender, Panel)
                                         Dim g As Graphics = e.Graphics
                                         g.SmoothingMode = SmoothingMode.AntiAlias

                                         ' Draw rounded panel background
                                         Dim rect As New Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1)
                                         Dim path As New GraphicsPath()
                                         Dim rad As Integer = 10

                                         path.AddArc(rect.X, rect.Y, rad, rad, 180, 90)
                                         path.AddArc(rect.Right - rad, rect.Y, rad, rad, 270, 90)
                                         path.AddArc(rect.Right - rad, rect.Bottom - rad, rad, rad, 0, 90)
                                         path.AddArc(rect.X, rect.Bottom - rad, rad, rad, 90, 90)
                                         path.CloseFigure()

                                         g.FillPath(New SolidBrush(Color.White), path)
                                         g.DrawPath(New Pen(Color.FromArgb(230, 232, 238), 1), path)

                                         ' Draw position name
                                         TextRenderer.DrawText(g, capName, New Font("Segoe UI", 8.5, FontStyle.Regular), New Rectangle(14, 0, pnl.Width - 68, pnl.Height), Color.FromArgb(50, 50, 50), TextFormatFlags.VerticalCenter Or TextFormatFlags.Left Or TextFormatFlags.EndEllipsis)

                                         ' Draw count badge
                                         Dim badgeW As Integer = 32
                                         Dim badgeH As Integer = 22
                                         Dim badgeX As Integer = pnl.Width - badgeW - 10
                                         Dim badgeY As Integer = (pnl.Height - badgeH) \ 2
                                         Dim badgeRect As New Rectangle(badgeX, badgeY, badgeW, badgeH)
                                         Dim badgePath As New GraphicsPath()
                                         Dim br As Integer = 11

                                         badgePath.AddArc(badgeRect.X, badgeRect.Y, br, br, 180, 90)
                                         badgePath.AddArc(badgeRect.Right - br, badgeRect.Y, br, br, 270, 90)
                                         badgePath.AddArc(badgeRect.Right - br, badgeRect.Bottom - br, br, br, 0, 90)
                                         badgePath.AddArc(badgeRect.X, badgeRect.Bottom - br, br, br, 90, 90)
                                         badgePath.CloseFigure()

                                         g.FillPath(New SolidBrush(capBgColor), badgePath)
                                         TextRenderer.DrawText(g, capCount.ToString(), New Font("Segoe UI Semibold", 8, FontStyle.Bold), badgeRect, capFgColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
                                     End Sub

            departmentfp.Controls.Add(rowPnl)
        Next

        departmentfp.PerformLayout()
    End Sub

    ' Set the active navigation button
    Private Sub setActiveButton(btn As Button)
        If activeButton IsNot Nothing Then
            activeButton.BackColor = Color.Transparent
            activeButton.ForeColor = Color.FromArgb(70, 70, 70)
            activeButton.Font = New Font(activeButton.Font, FontStyle.Regular)
        End If

        btn.BackColor = Color.Transparent
        btn.ForeColor = Color.FromArgb(70, 130, 220)
        btn.Font = New Font(btn.Font, FontStyle.Bold)
        activeButton = btn
    End Sub

    ' Apply border styling to panel
    Private Sub styleBorderPanel(pnl As Panel)
        AddHandler pnl.Paint, AddressOf borderPanelPaint
    End Sub

    Private Sub borderPanelPaint(sender As Object, e As PaintEventArgs)
        Dim pnl As Panel = CType(sender, Panel)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.HighQuality
        g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality

        Dim radius As Integer = 12
        Dim rect As New Rectangle(2, 2, pnl.Width - 5, pnl.Height - 5)

        Using path As New GraphicsPath()
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
            path.CloseFigure()

            Using pen As New Pen(Color.FromArgb(235, 235, 235), 0.1F)
                g.DrawPath(pen, path)
            End Using
        End Using
    End Sub

    ' Apply outline styling to panel
    Private Sub styleOutlinePanel(pnl As Panel)
        AddHandler pnl.Paint, AddressOf outlinePanelPaint
    End Sub

    Private Sub outlinePanelPaint(sender As Object, e As PaintEventArgs)
        Dim pnl As Panel = CType(sender, Panel)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        Using pen As New Pen(Color.FromArgb(225, 228, 235), 1.0F)
            g.DrawRectangle(pen, 0, 0, pnl.Width - 1, pnl.Height - 1)
        End Using
    End Sub

    ' Apply transparent button styling
    Private Sub makeTransparentButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn.BackColor = Color.Transparent
        btn.ForeColor = Color.FromArgb(70, 70, 70)
        btn.Cursor = Cursors.Hand
    End Sub

    ' Dashboard button click handler
    Private Sub Dashbaordbtn_Click(sender As Object, e As EventArgs) Handles Dashbaordbtn.Click
        setActiveButton(Dashbaordbtn)
        employeePage.Hide()
        payrollPage.Hide()
        Employeepnl.Show()
        Avgdailyratepnl.Show()
        Overtimepnl.Show()
        Bydepartmentpnl.Show()
        datelbl.Show()
        profilelogo.Show()
        addempbtn.Hide()
        Dashboardlbl.Text = "Dashboard"
        RefreshEmployeeCount()
    End Sub

    ' Employee button click handler
    Private Sub Emplyoyeebtn_Click(sender As Object, e As EventArgs) Handles Emplyoyeebtn.Click
        setActiveButton(Emplyoyeebtn)
        Employeepnl.Hide()
        Avgdailyratepnl.Hide()
        Overtimepnl.Hide()
        Bydepartmentpnl.Hide()
        payrollPage.Hide()
        employeePage.Show()
        datelbl.Hide()
        profilelogo.Hide()
        addempbtn.Show()
        Dashboardlbl.Text = "Employees"
    End Sub

    ' Payroll button click handler
    Private Sub Payrollbtn_Click(sender As Object, e As EventArgs) Handles Payrollbtn.Click
        setActiveButton(Payrollbtn)
        Employeepnl.Hide()
        Avgdailyratepnl.Hide()
        Overtimepnl.Hide()
        Bydepartmentpnl.Hide()
        employeePage.Hide()
        payrollPage.Show()
        datelbl.Hide()
        profilelogo.Hide()
        addempbtn.Hide()
        payrollPage.LoadEmployeeNames()
        Dashboardlbl.Text = "Payroll"
    End Sub

    ' Add employee button click handler
    Private Sub addempbtn_Click(sender As Object, e As EventArgs) Handles addempbtn.Click
        registerForm.Show()
        registerForm.BringToFront()
    End Sub

    ' Logout button click handler
    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            ' Remove shared pages from panel before closing
            If Panel1.Controls.Contains(employeePage) Then Panel1.Controls.Remove(employeePage)
            If Panel1.Controls.Contains(payrollPage) Then Panel1.Controls.Remove(payrollPage)

            Dim login As New LoginForm
            login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub totalemptextdesign_Click(sender As Object, e As EventArgs) Handles totalemptextdesign.Click
    End Sub

    Private Sub totalemplbl_Click(sender As Object, e As EventArgs) Handles totalemplbl.Click
    End Sub

End Class