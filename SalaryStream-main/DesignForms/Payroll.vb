Imports System.Drawing.Drawing2D

Public Class Payroll

    Private headerPanel As New Panel()
    Private titleLabel As New Label()

    Private Sub Payroll_Load(sender As Object,
                             e As EventArgs) _
                             Handles MyBase.Load

        Me.TopLevel = False
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Dock = DockStyle.Fill

        Me.BackColor = Color.FromArgb(245, 247, 250)

        headerPanel.Dock = DockStyle.Top
        headerPanel.Height = 75
        headerPanel.BackColor = Color.FromArgb(245, 247, 250)
        headerPanel.Padding = New Padding(20, 0, 0, 0)
        Me.Controls.Add(headerPanel)

        titleLabel.Text = "Calculate Payroll"
        titleLabel.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        titleLabel.ForeColor = Color.Black
        titleLabel.AutoSize = True
        titleLabel.Location = New Point(10, 23)
        headerPanel.Controls.Add(titleLabel)

        LoadEmployeeNames()

    End Sub

    ' ─────────────────────────────────────────────
    ' POPULATE PAYROLLSEARCH FROM EMPLOYEE GRID
    ' ─────────────────────────────────────────────
    Public Sub LoadEmployeeNames()

        payrollsearch.Items.Clear()

        For Each row As DataGridViewRow In
            Dashboard.employeePage.DataGridView1.Rows

            If Not row.IsNewRow Then
                If row.Cells(0).Value IsNot Nothing Then
                    Dim name As String =
                        row.Cells(0).Value.ToString().Trim()
                    If name <> "" Then
                        payrollsearch.Items.Add(name)
                    End If
                End If
            End If

        Next

        payrollsearch.AutoCompleteMode =
            AutoCompleteMode.SuggestAppend

        payrollsearch.AutoCompleteSource =
            AutoCompleteSource.ListItems

    End Sub

    ' ─────────────────────────────────────────────
    ' FILL ALL LABELS FROM THE MATCHING GRID ROW
    ' ─────────────────────────────────────────────
    Private Sub FillEmployeeDetails(selectedName As String)

        For Each row As DataGridViewRow In
            Dashboard.employeePage.DataGridView1.Rows

            If Not row.IsNewRow Then

                If row.Cells(0).Value IsNot Nothing Then

                    Dim rowName As String =
                        row.Cells(0).Value.ToString().Trim()

                    If rowName.ToLower() = selectedName.ToLower() Then

                        ' ── COLUMN 0 : NAME ──────────────────────
                        nameprlbl.Text =
                            If(row.Cells(0).Value IsNot Nothing,
                               row.Cells(0).Value.ToString().Trim(), "—")

                        ' ── COLUMN 1 : POSITION ──────────────────
                        positionprlbl.Text =
                            If(row.Cells(1).Value IsNot Nothing,
                               row.Cells(1).Value.ToString().Trim(), "—")

                        ' ── COLUMN 2 : DAILY RATE ────────────────
                        Dim rateRaw As String =
                            If(row.Cells(2).Value IsNot Nothing,
                               row.Cells(2).Value.ToString().Trim(), "0")

                        dailyrateprlbl.Text = rateRaw

                        ' ── COLUMN 3 : DAYS WORKED ───────────────
                        daysworkedprlbl.Text =
                            If(row.Cells(3).Value IsNot Nothing,
                               row.Cells(3).Value.ToString().Trim(), "0")

                        ' ── COLUMN 4 : OVERTIME HOURS ────────────
                        Dim otRaw As String =
                            If(row.Cells(4).Value IsNot Nothing,
                               row.Cells(4).Value.ToString().Trim(), "0")

                        overtimeprlbl.Text = otRaw

                        ' ── PARSE VALUES ─────────────────────────
                        Dim dailyRate As Decimal = 0
                        Dim otHours As Decimal = 0

                        Decimal.TryParse(rateRaw,
                            System.Globalization.NumberStyles.Any,
                            System.Globalization.CultureInfo.InvariantCulture,
                            dailyRate)

                        Decimal.TryParse(otRaw,
                            System.Globalization.NumberStyles.Any,
                            System.Globalization.CultureInfo.InvariantCulture,
                            otHours)

                        ' ─────────────────────────────────────────
                        ' BASIC PAY = Daily Rate × 26
                        ' ─────────────────────────────────────────
                        Dim basicPay As Decimal = dailyRate * 26
                        basicpaylbl.Text = "₱" & basicPay.ToString("N2")

                        ' ─────────────────────────────────────────
                        ' OVERTIME PAY = (Daily Rate × 25%) × OT hrs
                        ' ─────────────────────────────────────────
                        Dim otRate As Decimal = dailyRate * 0.25D
                        Dim otPay As Decimal = otRate * otHours
                        overtimepayprlbl.Text = "₱" & otPay.ToString("N2")

                        ' ─────────────────────────────────────────
                        ' SSS = 15% of Basic Pay
                        ' ─────────────────────────────────────────
                        Dim sss As Decimal = basicPay * 0.15D
                        ssslbl.Text = "-₱" & sss.ToString("N2")

                        ' ─────────────────────────────────────────
                        ' PHILHEALTH = 5% of Basic Pay
                        ' ─────────────────────────────────────────
                        Dim philHealth As Decimal = basicPay * 0.05D
                        phlbl.Text = "-₱" & philHealth.ToString("N2")

                        ' ─────────────────────────────────────────
                        ' PAG-IBIG = 2% of Basic Pay
                        ' ─────────────────────────────────────────
                        Dim pagIbig As Decimal = basicPay * 0.02D
                        pilbl.Text = "-₱" & pagIbig.ToString("N2")

                        ' ─────────────────────────────────────────
                        ' TRAIN LAW TAX (MONTHLY BASIC PAY BASIS)
                        ' ─────────────────────────────────────────
                        Dim monthlyBasic As Decimal = basicPay
                        Dim tax As Decimal = 0

                        If monthlyBasic <= 20833 Then
                            tax = 0
                        ElseIf monthlyBasic <= 33333 Then
                            tax = (monthlyBasic - 20833) * 0.2D
                        ElseIf monthlyBasic <= 66667 Then
                            tax = 2500 + (monthlyBasic - 33333) * 0.25D
                        ElseIf monthlyBasic <= 166667 Then
                            tax = 10833 + (monthlyBasic - 66667) * 0.3D
                        ElseIf monthlyBasic <= 666667 Then
                            tax = 40833 + (monthlyBasic - 166667) * 0.32D
                        Else
                            tax = 200833 + (monthlyBasic - 666667) * 0.35D
                        End If

                        taxlbl.Text = "-₱" & tax.ToString("N2")

                        ' ─────────────────────────────────────────
                        ' TOTAL DEDUCTIONS
                        ' ─────────────────────────────────────────
                        Dim totalDed As Decimal =
                            sss + philHealth + pagIbig + tax

                        totaldedlbl.Text = "₱" & totalDed.ToString("N2")

                        ' ─────────────────────────────────────────
                        ' NET PAY = Basic Pay + OT Pay - Deductions
                        ' ─────────────────────────────────────────
                        Dim netPay As Decimal =
                            basicPay + otPay - totalDed

                        netlbl.Text = "₱" & netPay.ToString("N2")

                        Exit For

                    End If

                End If

            End If

        Next

    End Sub

    ' ─────────────────────────────────────────────
    ' TRIGGER ON DROPDOWN SELECTION
    ' ─────────────────────────────────────────────
    Private Sub payrollsearch_SelectedIndexChanged(
                    sender As Object, e As EventArgs) _
                    Handles payrollsearch.SelectedIndexChanged

        If payrollsearch.SelectedIndex >= 0 Then
            FillEmployeeDetails(payrollsearch.SelectedItem.ToString())
        End If

    End Sub

    ' ─────────────────────────────────────────────
    ' TRIGGER WHILE TYPING / AUTOCOMPLETE
    ' ─────────────────────────────────────────────
    Private Sub payrollsearch_TextChanged(
                    sender As Object, e As EventArgs) _
                    Handles payrollsearch.TextChanged

        If payrollsearch.SelectedIndex >= 0 Then
            FillEmployeeDetails(payrollsearch.SelectedItem.ToString())
        End If

    End Sub

    Private Sub Label6_Click(sender As Object,
                             e As EventArgs) _
                             Handles Label6.Click
    End Sub

    Private Sub Label2_Click(sender As Object,
                             e As EventArgs) _
                             Handles Label2.Click
    End Sub

    Private Sub Panel1_Paint(sender As Object,
                             e As PaintEventArgs) _
                             Handles Panel1.Paint
    End Sub

    Private Sub Panel2_Paint(sender As Object,
                             e As PaintEventArgs) _
                             Handles Panel2.Paint
    End Sub

    Private Sub Label20_Click(sender As Object,
                              e As EventArgs) _
                              Handles overtimeprlbl.Click
    End Sub

    Private Sub Label4_Click(sender As Object,
                             e As EventArgs) _
                             Handles Label4.Click
    End Sub

End Class