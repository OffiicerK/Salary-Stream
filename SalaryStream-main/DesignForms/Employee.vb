Public Class EmployeePage

    Public selectedRowIndex As Integer = -1

    Private Sub employeePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = Color.FromArgb(245, 247, 250)

        ' DataGridView styling
        With DataGridView1
            .BorderStyle = BorderStyle.None
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .GridColor = Color.FromArgb(235, 235, 235)
            .BackgroundColor = Color.White
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToResizeRows = False
            .AllowUserToResizeColumns = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .EnableHeadersVisualStyles = False
            .ReadOnly = True
            .ScrollBars = ScrollBars.Vertical
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .RowTemplate.Height = 38

            ' Header style
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .ColumnHeadersDefaultCellStyle.BackColor = Color.White
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(150, 150, 150)
            .ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White
            .ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(150, 150, 150)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .ColumnHeadersDefaultCellStyle.Padding = New Padding(8, 0, 0, 0)
            .ColumnHeadersHeight = 30

            ' Column titles
            .Columns(0).HeaderText = "NAME"
            .Columns(1).HeaderText = "POSITION"
            .Columns(2).HeaderText = "DAILY RATE"
            .Columns(3).HeaderText = "ATTENDANCE"
            .Columns(4).HeaderText = "OVERTIME"

            ' Default cell style
            .DefaultCellStyle.Font = New Font("Segoe UI", 8.5, FontStyle.Regular)
            .DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40)
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.SelectionBackColor = Color.White
            .DefaultCellStyle.SelectionForeColor = Color.FromArgb(40, 40, 40)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .DefaultCellStyle.Padding = New Padding(8, 0, 0, 0)

            ' Name column style
            .Columns(0).DefaultCellStyle.Font = New Font("Segoe UI Semibold", 8.5, FontStyle.Bold)
            .Columns(0).DefaultCellStyle.ForeColor = Color.Black
            .Columns(0).DefaultCellStyle.SelectionBackColor = Color.White
            .Columns(0).DefaultCellStyle.SelectionForeColor = Color.Black
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            ' Column widths
            .Columns(0).FillWeight = 170
            .Columns(1).FillWeight = 130
            .Columns(2).FillWeight = 140
            .Columns(3).FillWeight = 120
            .Columns(4).FillWeight = 90
        End With

        ' Search bar styling
        searchbarcb.FlatStyle = FlatStyle.Flat
        searchbarcb.Font = New Font("Segoe UI", 11, FontStyle.Regular)
        searchbarcb.BackColor = Color.White
        searchbarcb.ForeColor = Color.FromArgb(60, 60, 60)

        ' Filter combobox styling
        filtercb.FlatStyle = FlatStyle.Flat
        filtercb.Font = New Font("Segoe UI", 11, FontStyle.Regular)
        filtercb.BackColor = Color.White
        filtercb.ForeColor = Color.FromArgb(40, 40, 40)

        ' Filter items
        filtercb.Items.Clear()
        filtercb.Items.Add("All")

        ' Executive / Management
        filtercb.Items.Add("CEO")
        filtercb.Items.Add("General Manager")
        filtercb.Items.Add("Manager")
        filtercb.Items.Add("Assistant Manager")
        filtercb.Items.Add("Supervisor")
        filtercb.Items.Add("Team Leader")

        ' Human Resources
        filtercb.Items.Add("HR Manager")
        filtercb.Items.Add("HR Officer")
        filtercb.Items.Add("Recruitment Officer")

        ' Finance / Accounting
        filtercb.Items.Add("Finance Manager")
        filtercb.Items.Add("Finance Officer")
        filtercb.Items.Add("Accountant")
        filtercb.Items.Add("Bookkeeper")
        filtercb.Items.Add("Payroll Officer")
        filtercb.Items.Add("Cashier")

        ' IT / Technology
        filtercb.Items.Add("IT Manager")
        filtercb.Items.Add("IT Officer")
        filtercb.Items.Add("System Administrator")
        filtercb.Items.Add("Programmer")
        filtercb.Items.Add("Technical Support")

        ' Operations
        filtercb.Items.Add("Operations Manager")
        filtercb.Items.Add("Operations Officer")
        filtercb.Items.Add("Operations Staff")
        filtercb.Items.Add("Logistics Officer")
        filtercb.Items.Add("Warehouse Staff")

        ' Administration
        filtercb.Items.Add("Admin Manager")
        filtercb.Items.Add("Admin Officer")
        filtercb.Items.Add("Admin Staff")
        filtercb.Items.Add("Executive Assistant")
        filtercb.Items.Add("Secretary")
        filtercb.Items.Add("Receptionist")
        filtercb.Items.Add("Office Clerk")
        filtercb.Items.Add("Data Encoder")

        ' Sales / Marketing
        filtercb.Items.Add("Sales Manager")
        filtercb.Items.Add("Sales Officer")
        filtercb.Items.Add("Sales Representative")
        filtercb.Items.Add("Sales Associate")
        filtercb.Items.Add("Marketing Manager")
        filtercb.Items.Add("Marketing Officer")
        filtercb.Items.Add("Customer Service Representative")

        ' Support Staff
        filtercb.Items.Add("Security Officer")
        filtercb.Items.Add("Security Guard")
        filtercb.Items.Add("Driver")
        filtercb.Items.Add("Messenger")
        filtercb.Items.Add("Janitor")
        filtercb.Items.Add("Maintenance Staff")
        filtercb.Items.Add("Utility Worker")

        filtercb.SelectedIndex = 0

        ' Search settings
        searchbarcb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        searchbarcb.AutoCompleteSource = AutoCompleteSource.ListItems
        searchbarcb.Text = ""

        ' Add Edit button column
        If DataGridView1.Columns("Edit") Is Nothing Then
            Dim editBtn As New DataGridViewButtonColumn()
            editBtn.Name = "Edit"
            editBtn.HeaderText = ""
            editBtn.Text = "✎ Edit"
            editBtn.UseColumnTextForButtonValue = True
            editBtn.FillWeight = 80
            DataGridView1.Columns.Add(editBtn)
        End If

        ' Add Delete button column
        If DataGridView1.Columns("Delete") Is Nothing Then
            Dim deleteBtn As New DataGridViewButtonColumn()
            deleteBtn.Name = "Delete"
            deleteBtn.HeaderText = ""
            deleteBtn.Text = "🗑 Delete"
            deleteBtn.UseColumnTextForButtonValue = True
            deleteBtn.FillWeight = 90
            DataGridView1.Columns.Add(deleteBtn)
        End If

    End Sub

    ' Rebuild search suggestions from current rows
    Public Sub UpdateSearchSuggestions()
        searchbarcb.Items.Clear()
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow AndAlso row.Cells(0).Value IsNot Nothing Then
                searchbarcb.Items.Add(row.Cells(0).Value.ToString())
            End If
        Next
    End Sub

    ' Filter rows by search text and selected position
    Private Sub ApplyFilters()
        Dim keyword As String = searchbarcb.Text.Trim().ToLower()
        Dim selectedPosition As String = filtercb.Text.Trim().ToLower()

        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim employeeName As String = row.Cells(0).Value.ToString().Trim().ToLower()
                Dim employeePosition As String = row.Cells(1).Value.ToString().Trim().ToLower()
                Dim matchesSearch As Boolean = employeeName.Contains(keyword)
                Dim matchesFilter As Boolean = (selectedPosition = "all" OrElse employeePosition = selectedPosition)
                row.Visible = (matchesSearch And matchesFilter)
            End If
        Next
    End Sub

    Private Sub searchbarcb_TextChanged(sender As Object, e As EventArgs) Handles searchbarcb.TextChanged
        ApplyFilters()
    End Sub

    Private Sub filtercb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filtercb.SelectedIndexChanged
        ApplyFilters()
    End Sub

    ' Custom cell painting for position tags and action buttons
    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        If e.RowIndex < 0 Then Exit Sub

        ' Position tag
        If e.ColumnIndex = 1 Then
            e.PaintBackground(e.CellBounds, True)

            Dim originalText As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()

            ' Shorten long position names for display
            Dim displayText As String = originalText
            Select Case originalText
                Case "Finance Manager" : displayText = "Fin Manager"
                Case "Assistant Manager" : displayText = "Asst Manager"
                Case "General Manager" : displayText = "Gen Manager"
                Case "Operations Manager" : displayText = "Ops Manager"
                Case "Operations Officer" : displayText = "Ops Officer"
                Case "Operations Staff" : displayText = "Ops Staff"
                Case "Human Resources" : displayText = "HR"
                Case "Technical Support" : displayText = "Tech Support"
                Case "System Administrator" : displayText = "Sys Admin"
                Case "Recruitment Officer" : displayText = "Recruit Officer"
                Case "Finance Officer" : displayText = "Fin Officer"
            End Select

            Dim backColor As Color = Color.LightGray
            Dim textColor As Color = Color.Black

            If originalText = "CEO" Then
                backColor = Color.FromArgb(255, 225, 225) : textColor = Color.FromArgb(220, 50, 50)
            End If
            If originalText.Contains("Operations") Then
                backColor = Color.FromArgb(220, 235, 255) : textColor = Color.FromArgb(45, 90, 200)
            End If
            If originalText.Contains("Finance") Then
                backColor = Color.FromArgb(255, 238, 200) : textColor = Color.FromArgb(190, 120, 20)
            End If
            If originalText.Contains("IT") Then
                backColor = Color.FromArgb(235, 225, 255) : textColor = Color.FromArgb(120, 70, 220)
            End If
            If originalText.Contains("HR") Or originalText.Contains("Human") Then
                backColor = Color.FromArgb(210, 245, 220) : textColor = Color.FromArgb(40, 150, 80)
            End If
            If originalText = "Manager" Then
                backColor = Color.FromArgb(255, 228, 210) : textColor = Color.FromArgb(210, 110, 40)
            End If
            If originalText = "Assistant Manager" Then
                backColor = Color.FromArgb(255, 220, 235) : textColor = Color.FromArgb(210, 70, 120)
            End If

            Dim tagRect As New Rectangle(e.CellBounds.X + 10, e.CellBounds.Y + 8, e.CellBounds.Width - 20, e.CellBounds.Height - 16)
            Dim path As New Drawing2D.GraphicsPath()
            Dim r As Integer = 12
            path.AddArc(tagRect.X, tagRect.Y, r, r, 180, 90)
            path.AddArc(tagRect.Right - r, tagRect.Y, r, r, 270, 90)
            path.AddArc(tagRect.Right - r, tagRect.Bottom - r, r, r, 0, 90)
            path.AddArc(tagRect.X, tagRect.Bottom - r, r, r, 90, 90)
            path.CloseFigure()

            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            e.Graphics.FillPath(New SolidBrush(backColor), path)
            TextRenderer.DrawText(e.Graphics, displayText, New Font("Segoe UI", 7.5, FontStyle.Regular), tagRect, textColor,
                TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter Or TextFormatFlags.EndEllipsis)
            e.Handled = True
        End If

        ' Edit button
        If e.ColumnIndex = DataGridView1.Columns("Edit").Index Then
            e.PaintBackground(e.CellBounds, True)
            Dim btnRect As New Rectangle(e.CellBounds.X + 6, e.CellBounds.Y + 6, e.CellBounds.Width - 12, e.CellBounds.Height - 12)
            Dim path As New Drawing2D.GraphicsPath()
            Dim r As Integer = 10
            path.AddArc(btnRect.X, btnRect.Y, r, r, 180, 90)
            path.AddArc(btnRect.Right - r, btnRect.Y, r, r, 270, 90)
            path.AddArc(btnRect.Right - r, btnRect.Bottom - r, r, r, 0, 90)
            path.AddArc(btnRect.X, btnRect.Bottom - r, r, r, 90, 90)
            path.CloseFigure()

            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            e.Graphics.FillPath(New SolidBrush(Color.FromArgb(245, 248, 255)), path)
            e.Graphics.DrawPath(New Pen(Color.FromArgb(200, 215, 255)), path)
            TextRenderer.DrawText(e.Graphics, "✎ Edit", New Font("Segoe UI", 8), btnRect, Color.FromArgb(55, 95, 190),
                TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
            e.Handled = True
        End If

        ' Delete button
        If e.ColumnIndex = DataGridView1.Columns("Delete").Index Then
            e.PaintBackground(e.CellBounds, True)
            Dim btnRect As New Rectangle(e.CellBounds.X + 6, e.CellBounds.Y + 6, e.CellBounds.Width - 12, e.CellBounds.Height - 12)
            Dim path As New Drawing2D.GraphicsPath()
            Dim r As Integer = 10
            path.AddArc(btnRect.X, btnRect.Y, r, r, 180, 90)
            path.AddArc(btnRect.Right - r, btnRect.Y, r, r, 270, 90)
            path.AddArc(btnRect.Right - r, btnRect.Bottom - r, r, r, 0, 90)
            path.AddArc(btnRect.X, btnRect.Bottom - r, r, r, 90, 90)
            path.CloseFigure()

            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            e.Graphics.FillPath(New SolidBrush(Color.FromArgb(255, 246, 246)), path)
            e.Graphics.DrawPath(New Pen(Color.FromArgb(255, 190, 190)), path)
            TextRenderer.DrawText(e.Graphics, "🗑 Delete", New Font("Segoe UI", 8), btnRect, Color.FromArgb(225, 70, 70),
                TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
            e.Handled = True
        End If

    End Sub

    ' Handle Edit and Delete button clicks
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        ' Edit: load selected row into Registration form
        If DataGridView1.Columns(e.ColumnIndex).Name = "Edit" Then
            selectedRowIndex = e.RowIndex
            Registration.nametxtb.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            Registration.positioncb.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            Registration.dailyratetxtb.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            Registration.attendancetxtb.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            Registration.overtimetxtb.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
            Registration.savebtn.Visible = True
            Registration.Button1.Visible = False
            Registration.Show()
            Registration.BringToFront()
        End If

        ' Delete: confirm then remove row and refresh dashboard count
        If DataGridView1.Columns(e.ColumnIndex).Name = "Delete" Then
            Dim result As DialogResult = MessageBox.Show("Delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                DataGridView1.Rows.RemoveAt(e.RowIndex)
                UpdateSearchSuggestions()
                Dashboard.RefreshEmployeeCount()
            End If
        End If

    End Sub

End Class