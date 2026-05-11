Public Class Registration

    ' Last Position
    Private previousIndex As Integer = 0

    Private Sub Registration_Load(sender As Object,
                                  e As EventArgs) _
                                  Handles MyBase.Load

        ' Positions
        positioncb.Items.Clear()

        ' Default
        positioncb.Items.Add("Select Position")

        ' Management
        positioncb.Items.Add("── EXECUTIVE / MANAGEMENT ──")
        positioncb.Items.Add("CEO")
        positioncb.Items.Add("General Manager")
        positioncb.Items.Add("Manager")
        positioncb.Items.Add("Assistant Manager")
        positioncb.Items.Add("Supervisor")
        positioncb.Items.Add("Team Leader")

        ' HR
        positioncb.Items.Add("── HUMAN RESOURCES ──")
        positioncb.Items.Add("HR Manager")
        positioncb.Items.Add("HR Officer")
        positioncb.Items.Add("Recruitment Officer")

        ' Finance
        positioncb.Items.Add("── FINANCE / ACCOUNTING ──")
        positioncb.Items.Add("Finance Manager")
        positioncb.Items.Add("Finance Officer")
        positioncb.Items.Add("Accountant")
        positioncb.Items.Add("Bookkeeper")
        positioncb.Items.Add("Payroll Officer")
        positioncb.Items.Add("Cashier")

        ' IT
        positioncb.Items.Add("── IT / TECHNOLOGY ──")
        positioncb.Items.Add("IT Manager")
        positioncb.Items.Add("IT Officer")
        positioncb.Items.Add("System Administrator")
        positioncb.Items.Add("Programmer")
        positioncb.Items.Add("Technical Support")

        ' Operations
        positioncb.Items.Add("── OPERATIONS ──")
        positioncb.Items.Add("Operations Manager")
        positioncb.Items.Add("Operations Officer")
        positioncb.Items.Add("Operations Staff")
        positioncb.Items.Add("Logistics Officer")
        positioncb.Items.Add("Warehouse Staff")

        ' Admin
        positioncb.Items.Add("── ADMINISTRATION ──")
        positioncb.Items.Add("Admin Manager")
        positioncb.Items.Add("Admin Officer")
        positioncb.Items.Add("Admin Staff")
        positioncb.Items.Add("Executive Assistant")
        positioncb.Items.Add("Secretary")
        positioncb.Items.Add("Receptionist")
        positioncb.Items.Add("Office Clerk")
        positioncb.Items.Add("Data Encoder")

        ' Sales
        positioncb.Items.Add("── SALES / MARKETING ──")
        positioncb.Items.Add("Sales Manager")
        positioncb.Items.Add("Sales Officer")
        positioncb.Items.Add("Sales Representative")
        positioncb.Items.Add("Sales Associate")
        positioncb.Items.Add("Marketing Manager")
        positioncb.Items.Add("Marketing Officer")
        positioncb.Items.Add("Customer Service Representative")

        ' Support
        positioncb.Items.Add("── SUPPORT STAFF ──")
        positioncb.Items.Add("Security Officer")
        positioncb.Items.Add("Security Guard")
        positioncb.Items.Add("Driver")
        positioncb.Items.Add("Messenger")
        positioncb.Items.Add("Janitor")
        positioncb.Items.Add("Maintenance Staff")
        positioncb.Items.Add("Utility Worker")

        ' ComboBox
        positioncb.DropDownStyle =
            ComboBoxStyle.DropDownList

        positioncb.SelectedIndex = 0

    End Sub

    ' Prevent Header Select
    Private Sub positioncb_SelectedIndexChanged(sender As Object,
                                                e As EventArgs) _
                                                Handles positioncb.SelectedIndexChanged

        If positioncb.Text.Contains("──") Then

            MessageBox.Show(
                "Category headers cannot be selected.",
                "Invalid Selection",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            positioncb.SelectedIndex = previousIndex

        Else

            previousIndex = positioncb.SelectedIndex

        End If

    End Sub

    ' Form Show
    Private Sub Registration_Shown(sender As Object,
                                   e As EventArgs) _
                                   Handles Me.Shown

        If Dashboard.employeePage.selectedRowIndex = -1 Then

            savebtn.Visible = False
            Button1.Visible = True

        End If

    End Sub

    ' Add Employee
    Private Sub Button1_Click(sender As Object,
                              e As EventArgs) _
                              Handles Button1.Click

        ' Empty Check
        If nametxtb.Text = "" Or
           positioncb.Text = "" Or
           dailyratetxtb.Text = "" Or
           attendancetxtb.Text = "" Or
           overtimetxtb.Text = "" Then

            MessageBox.Show(
                "Please fill all fields.",
                "Missing Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            Exit Sub

        End If

        ' Position Check
        If positioncb.Text.Contains("──") Or
           positioncb.Text = "Select Position" Then

            MessageBox.Show(
                "Please select a valid position.",
                "Invalid Position",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            Exit Sub

        End If

        ' Add Data
        Dashboard.employeePage.DataGridView1.Rows.Add(
            nametxtb.Text,
            positioncb.Text,
            dailyratetxtb.Text,
            attendancetxtb.Text,
            overtimetxtb.Text)

        ' Update Search
        Dashboard.employeePage.UpdateSearchSuggestions()

        ' Clear
        ClearFields()

        MessageBox.Show(
            "Employee added successfully.",
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

    End Sub

    ' Save
    Private Sub savebtn_Click(sender As Object,
                              e As EventArgs) _
                              Handles savebtn.Click

        Dim rowIndex =
            Dashboard.employeePage.selectedRowIndex

        If rowIndex >= 0 Then

            With Dashboard.employeePage.DataGridView1.Rows(rowIndex)

                .Cells(0).Value = nametxtb.Text
                .Cells(1).Value = positioncb.Text
                .Cells(2).Value = dailyratetxtb.Text
                .Cells(3).Value = attendancetxtb.Text
                .Cells(4).Value = overtimetxtb.Text

            End With

            Dashboard.employeePage.UpdateSearchSuggestions()

            MessageBox.Show(
                "Employee updated successfully.",
                "Updated",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

        End If

        ' Reset
        Dashboard.employeePage.selectedRowIndex = -1

        savebtn.Visible = False
        Button1.Visible = True

        ClearFields()

        Hide()

    End Sub

    ' Clear Button
    Private Sub clearbtn_Click(sender As Object,
                               e As EventArgs) _
                               Handles clearbtn.Click

        Dim result As DialogResult

        result = MessageBox.Show(
            "Clear all input fields?",
            "Clear Fields",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            ClearFields()

        End If

    End Sub

    ' Clear Fields
    Private Sub ClearFields()

        nametxtb.Clear()

        positioncb.SelectedIndex = 0

        dailyratetxtb.Clear()

        attendancetxtb.Clear()

        overtimetxtb.Clear()

        nametxtb.Focus()

    End Sub

    ' Back
    Private Sub backbtn_Click(sender As Object,
                              e As EventArgs) _
                              Handles backbtn.Click

        Dashboard.employeePage.selectedRowIndex = -1

        ClearFields()

        Me.Hide()

    End Sub

    ' Prevent Close
    Private Sub Registration_FormClosing(sender As Object,
                                         e As FormClosingEventArgs) _
                                         Handles Me.FormClosing

        e.Cancel = True

        Me.Hide()

    End Sub

    Private Sub dailyratetxtb_TextChanged(sender As Object,
                                          e As EventArgs) _
                                          Handles dailyratetxtb.TextChanged

    End Sub

End Class