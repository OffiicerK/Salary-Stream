<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registration
    Inherits System.Windows.Forms.Form

    ' Dispose
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)

        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

        Finally
            MyBase.Dispose(disposing)

        End Try

    End Sub

    Private components As System.ComponentModel.IContainer

    ' Initialize
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()

        nametxtb = New TextBox()
        overtimetxtb = New TextBox()
        dailyratetxtb = New TextBox()
        attendancetxtb = New TextBox()

        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label3 = New Label()

        Button1 = New Button()

        positioncb = New ComboBox()

        backbtn = New Button()
        savebtn = New Button()

        Label6 = New Label()

        Panel1 = New Panel()

        Label9 = New Label()
        Label8 = New Label()

        clearbtn = New Button()

        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()

        Panel5 = New Panel()

        Label10 = New Label()

        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()

        SuspendLayout()

        ' Name
        nametxtb.Font = New Font("Segoe UI Semilight", 9.0F)
        nametxtb.ForeColor = SystemColors.WindowFrame
        nametxtb.Location = New Point(29, 44)
        nametxtb.Name = "nametxtb"
        nametxtb.Size = New Size(620, 23)
        nametxtb.TabIndex = 0
        nametxtb.Text = "Enter full name"

        ' Overtime
        overtimetxtb.Font = New Font("Segoe UI Semilight", 9.0F)
        overtimetxtb.ForeColor = SystemColors.WindowFrame
        overtimetxtb.Location = New Point(29, 147)
        overtimetxtb.Name = "overtimetxtb"
        overtimetxtb.Size = New Size(620, 23)
        overtimetxtb.TabIndex = 2
        overtimetxtb.Text = "0"

        ' Daily Rate
        dailyratetxtb.Font = New Font("Segoe UI Semilight", 9.0F)
        dailyratetxtb.ForeColor = SystemColors.WindowFrame
        dailyratetxtb.Location = New Point(29, 50)
        dailyratetxtb.Name = "dailyratetxtb"
        dailyratetxtb.Size = New Size(620, 23)
        dailyratetxtb.TabIndex = 3
        dailyratetxtb.Text = "₱ 0.00"

        ' Attendance
        attendancetxtb.Font = New Font("Segoe UI Semilight", 9.0F)
        attendancetxtb.ForeColor = SystemColors.WindowFrame
        attendancetxtb.Location = New Point(29, 98)
        attendancetxtb.Name = "attendancetxtb"
        attendancetxtb.Size = New Size(620, 23)
        attendancetxtb.TabIndex = 4
        attendancetxtb.Text = "0"

        ' Label Name
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semilight", 9.75F)
        Label1.Location = New Point(26, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 17)
        Label1.TabIndex = 5
        Label1.Text = "Name:"

        ' Label Position
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semilight", 9.75F)
        Label2.Location = New Point(29, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 17)
        Label2.TabIndex = 6
        Label2.Text = "Position:"

        ' Label Attendance
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semilight", 9.75F)
        Label4.Location = New Point(29, 81)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 17)
        Label4.TabIndex = 8
        Label4.Text = "Attendance:"

        ' Label Overtime
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semilight", 9.75F)
        Label5.Location = New Point(29, 130)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 17)
        Label5.TabIndex = 9
        Label5.Text = "Overtime:"

        ' Label Daily Rate
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semilight", 9.75F)
        Label3.Location = New Point(29, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 17)
        Label3.TabIndex = 7
        Label3.Text = "Daily Rate:"

        ' Add Button
        Button1.BackColor = Color.DodgerBlue
        Button1.ForeColor = Color.White
        Button1.Location = New Point(439, 184)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 32)
        Button1.TabIndex = 11
        Button1.Text = "+ Add Employee"
        Button1.UseVisualStyleBackColor = False

        ' Position
        positioncb.Font = New Font("Segoe UI Semilight", 9.0F)
        positioncb.ForeColor = SystemColors.WindowFrame
        positioncb.FormattingEnabled = True
        positioncb.Location = New Point(29, 94)
        positioncb.Name = "positioncb"
        positioncb.Size = New Size(620, 23)
        positioncb.TabIndex = 12
        positioncb.Text = "Select position"

        ' Back Button
        backbtn.BackColor = Color.DodgerBlue
        backbtn.Font = New Font("Microsoft Sans Serif", 8.25F)
        backbtn.ForeColor = Color.White
        backbtn.Location = New Point(570, 11)
        backbtn.Name = "backbtn"
        backbtn.Size = New Size(79, 32)
        backbtn.TabIndex = 13
        backbtn.Text = "Back"
        backbtn.UseVisualStyleBackColor = False

        ' Save Button
        savebtn.BackColor = Color.DodgerBlue
        savebtn.Font = New Font("Microsoft Sans Serif", 8.25F)
        savebtn.ForeColor = Color.White
        savebtn.Location = New Point(485, 11)
        savebtn.Name = "savebtn"
        savebtn.Size = New Size(79, 32)
        savebtn.TabIndex = 14
        savebtn.Text = "Save"
        savebtn.UseVisualStyleBackColor = False

        ' Employee Info
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F,
                                FontStyle.Bold,
                                GraphicsUnit.Point,
                                CByte(0))

        Label6.Location = New Point(26, 3)
        Label6.Name = "Label6"
        Label6.Size = New Size(169, 17)
        Label6.TabIndex = 15
        Label6.Text = "EMPLOYEE INFORMATION"

        ' Top Panel
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(savebtn)
        Panel1.Controls.Add(backbtn)

        Panel1.Location = New Point(0, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(683, 62)
        Panel1.TabIndex = 17

        ' Description
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semilight",
                                9.75F,
                                FontStyle.Regular,
                                GraphicsUnit.Point,
                                CByte(0))

        Label9.ForeColor = SystemColors.GrayText
        Label9.Location = New Point(26, 32)
        Label9.Name = "Label9"
        Label9.Size = New Size(195, 17)
        Label9.TabIndex = 19
        Label9.Text = "Fill in the employee details below"

        ' Title
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI",
                                14.25F,
                                FontStyle.Bold,
                                GraphicsUnit.Point,
                                CByte(0))

        Label8.Location = New Point(23, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(140, 25)
        Label8.TabIndex = 18
        Label8.Text = "Add Employee"

        ' Clear Button
        clearbtn.BackColor = Color.DodgerBlue
        clearbtn.ForeColor = Color.White
        clearbtn.Location = New Point(570, 184)
        clearbtn.Name = "clearbtn"
        clearbtn.Size = New Size(79, 32)
        clearbtn.TabIndex = 20
        clearbtn.Text = "Clear"
        clearbtn.UseVisualStyleBackColor = False

        ' Info Panel
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(nametxtb)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(positioncb)
        Panel2.Controls.Add(Panel4)

        Panel2.Location = New Point(0, 64)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(683, 125)
        Panel2.TabIndex = 21

        ' Panel3
        Panel3.Location = New Point(0, 179)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(200, 100)
        Panel3.TabIndex = 22

        ' Panel4
        Panel4.Location = New Point(0, 177)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(200, 100)
        Panel4.TabIndex = 22

        ' Pay Panel
        Panel5.Controls.Add(clearbtn)
        Panel5.Controls.Add(Button1)
        Panel5.Controls.Add(Label10)
        Panel5.Controls.Add(Label3)
        Panel5.Controls.Add(dailyratetxtb)
        Panel5.Controls.Add(overtimetxtb)
        Panel5.Controls.Add(Label5)
        Panel5.Controls.Add(Label4)
        Panel5.Controls.Add(attendancetxtb)

        Panel5.Location = New Point(0, 188)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(683, 229)
        Panel5.TabIndex = 22

        ' Pay Details
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI",
                                 9.75F,
                                 FontStyle.Bold,
                                 GraphicsUnit.Point,
                                 CByte(0))

        Label10.Location = New Point(29, 9)
        Label10.Name = "Label10"
        Label10.Size = New Size(86, 17)
        Label10.TabIndex = 23
        Label10.Text = "PAY DETAILS"

        ' Form
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)

        AutoScaleMode = AutoScaleMode.Font

        ClientSize = New Size(684, 416)

        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Panel5)

        Name = "Registration"
        Text = "Registration"

        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()

        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()

        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()

        ResumeLayout(False)

    End Sub

    Friend WithEvents nametxtb As TextBox
    Friend WithEvents overtimetxtb As TextBox
    Friend WithEvents dailyratetxtb As TextBox
    Friend WithEvents attendancetxtb As TextBox

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label

    Friend WithEvents Button1 As Button
    Friend WithEvents positioncb As ComboBox

    Friend WithEvents backbtn As Button
    Friend WithEvents savebtn As Button

    Friend WithEvents Label6 As Label

    Friend WithEvents Panel1 As Panel

    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label

    Friend WithEvents clearbtn As Button

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel

    Friend WithEvents Panel5 As Panel

    Friend WithEvents Label10 As Label

End Class