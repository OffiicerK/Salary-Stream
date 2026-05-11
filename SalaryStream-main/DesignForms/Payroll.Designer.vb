<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Payroll
    Inherits System.Windows.Forms.Form

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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        employee = New Panel()
        nameprlbl = New Label()
        Label1 = New Label()
        Label16 = New Label()
        dailyrate = New Panel()
        Label3 = New Label()
        dailyrateprlbl = New Label()
        overtime = New Panel()
        overtimeprlbl = New Label()
        Label5 = New Label()
        daysworked = New Panel()
        daysworkedprlbl = New Label()
        Label4 = New Label()
        position = New Panel()
        positionprlbl = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        taxlbl = New Label()
        Label18 = New Label()
        totaldedlbl = New Label()
        netlbl = New Label()
        pilbl = New Label()
        phlbl = New Label()
        ssslbl = New Label()
        overtimepayprlbl = New Label()
        basicpaylbl = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        Panel2 = New Panel()
        payrollsearch = New ComboBox()
        employee.SuspendLayout()
        dailyrate.SuspendLayout()
        overtime.SuspendLayout()
        daysworked.SuspendLayout()
        position.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' employee
        ' 
        employee.Controls.Add(nameprlbl)
        employee.Controls.Add(Label1)
        employee.Controls.Add(Label16)
        employee.Location = New Point(12, 134)
        employee.Name = "employee"
        employee.Size = New Size(292, 49)
        employee.TabIndex = 0
        ' 
        ' nameprlbl
        ' 
        nameprlbl.AutoSize = True
        nameprlbl.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        nameprlbl.ForeColor = Color.Black
        nameprlbl.Location = New Point(2, 20)
        nameprlbl.Name = "nameprlbl"
        nameprlbl.Size = New Size(64, 25)
        nameprlbl.TabIndex = 3
        nameprlbl.Text = "Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.0F)
        Label1.ForeColor = Color.Gray
        Label1.Location = New Point(4, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 0
        Label1.Text = "Employee"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label16.ForeColor = Color.Black
        Label16.Location = New Point(3, 42)
        Label16.Name = "Label16"
        Label16.Size = New Size(0, 25)
        Label16.TabIndex = 1
        ' 
        ' dailyrate
        ' 
        dailyrate.Controls.Add(Label3)
        dailyrate.Controls.Add(dailyrateprlbl)
        dailyrate.Location = New Point(0, 112)
        dailyrate.Name = "dailyrate"
        dailyrate.Size = New Size(292, 53)
        dailyrate.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.0F)
        Label3.ForeColor = Color.Gray
        Label3.Location = New Point(4, 5)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 15)
        Label3.TabIndex = 1
        Label3.Text = "Daily Rate (₱)"
        ' 
        ' dailyrateprlbl
        ' 
        dailyrateprlbl.AutoSize = True
        dailyrateprlbl.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        dailyrateprlbl.ForeColor = Color.Black
        dailyrateprlbl.Location = New Point(4, 20)
        dailyrateprlbl.Name = "dailyrateprlbl"
        dailyrateprlbl.Size = New Size(62, 25)
        dailyrateprlbl.TabIndex = 2
        dailyrateprlbl.Text = "₱0.00"
        ' 
        ' overtime
        ' 
        overtime.Controls.Add(overtimeprlbl)
        overtime.Controls.Add(Label5)
        overtime.Location = New Point(0, 230)
        overtime.Name = "overtime"
        overtime.Size = New Size(292, 53)
        overtime.TabIndex = 2
        ' 
        ' overtimeprlbl
        ' 
        overtimeprlbl.AutoSize = True
        overtimeprlbl.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        overtimeprlbl.ForeColor = Color.Black
        overtimeprlbl.Location = New Point(7, 20)
        overtimeprlbl.Name = "overtimeprlbl"
        overtimeprlbl.Size = New Size(23, 25)
        overtimeprlbl.TabIndex = 5
        overtimeprlbl.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.0F)
        Label5.ForeColor = Color.Gray
        Label5.Location = New Point(7, 5)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 15)
        Label5.TabIndex = 3
        Label5.Text = "Overtime (hrs)"
        ' 
        ' daysworked
        ' 
        daysworked.Controls.Add(daysworkedprlbl)
        daysworked.Controls.Add(Label4)
        daysworked.Location = New Point(0, 171)
        daysworked.Name = "daysworked"
        daysworked.Size = New Size(292, 53)
        daysworked.TabIndex = 4
        ' 
        ' daysworkedprlbl
        ' 
        daysworkedprlbl.AutoSize = True
        daysworkedprlbl.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        daysworkedprlbl.ForeColor = Color.Black
        daysworkedprlbl.Location = New Point(7, 20)
        daysworkedprlbl.Name = "daysworkedprlbl"
        daysworkedprlbl.Size = New Size(23, 25)
        daysworkedprlbl.TabIndex = 3
        daysworkedprlbl.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.0F)
        Label4.ForeColor = Color.Gray
        Label4.Location = New Point(4, 5)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 15)
        Label4.TabIndex = 2
        Label4.Text = "Days Worked"
        ' 
        ' position
        ' 
        position.Controls.Add(positionprlbl)
        position.Controls.Add(Label2)
        position.Location = New Point(0, 55)
        position.Name = "position"
        position.Size = New Size(292, 51)
        position.TabIndex = 3
        ' 
        ' positionprlbl
        ' 
        positionprlbl.AutoSize = True
        positionprlbl.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        positionprlbl.ForeColor = Color.Black
        positionprlbl.Location = New Point(4, 20)
        positionprlbl.Name = "positionprlbl"
        positionprlbl.Size = New Size(84, 25)
        positionprlbl.TabIndex = 3
        positionprlbl.Text = "Position"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F)
        Label2.ForeColor = Color.Gray
        Label2.Location = New Point(4, 5)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 15)
        Label2.TabIndex = 1
        Label2.Text = "Position"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(taxlbl)
        Panel1.Controls.Add(Label18)
        Panel1.Controls.Add(totaldedlbl)
        Panel1.Controls.Add(netlbl)
        Panel1.Controls.Add(pilbl)
        Panel1.Controls.Add(phlbl)
        Panel1.Controls.Add(ssslbl)
        Panel1.Controls.Add(overtimepayprlbl)
        Panel1.Controls.Add(basicpaylbl)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label7)
        Panel1.Location = New Point(313, 134)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(351, 310)
        Panel1.TabIndex = 6
        ' 
        ' taxlbl
        ' 
        taxlbl.AutoSize = True
        taxlbl.Font = New Font("Segoe UI", 9.0F)
        taxlbl.ForeColor = Color.Red
        taxlbl.ImageAlign = ContentAlignment.MiddleRight
        taxlbl.Location = New Point(249, 171)
        taxlbl.Name = "taxlbl"
        taxlbl.Size = New Size(25, 15)
        taxlbl.TabIndex = 22
        taxlbl.Text = "-₱0"
        taxlbl.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 9.0F)
        Label18.ForeColor = Color.Gray
        Label18.Location = New Point(13, 171)
        Label18.Name = "Label18"
        Label18.Size = New Size(24, 15)
        Label18.TabIndex = 21
        Label18.Text = "Tax"
        ' 
        ' totaldedlbl
        ' 
        totaldedlbl.AutoSize = True
        totaldedlbl.Font = New Font("Segoe UI", 9.0F)
        totaldedlbl.ForeColor = Color.Red
        totaldedlbl.ImageAlign = ContentAlignment.MiddleRight
        totaldedlbl.Location = New Point(254, 200)
        totaldedlbl.Name = "totaldedlbl"
        totaldedlbl.Size = New Size(20, 15)
        totaldedlbl.TabIndex = 20
        totaldedlbl.Text = "₱0"
        ' 
        ' netlbl
        ' 
        netlbl.AutoSize = True
        netlbl.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        netlbl.ForeColor = Color.Green
        netlbl.ImageAlign = ContentAlignment.MiddleRight
        netlbl.Location = New Point(245, 239)
        netlbl.Name = "netlbl"
        netlbl.Size = New Size(29, 21)
        netlbl.TabIndex = 18
        netlbl.Text = "₱0"
        ' 
        ' pilbl
        ' 
        pilbl.AutoSize = True
        pilbl.Font = New Font("Segoe UI", 9.0F)
        pilbl.ForeColor = Color.Red
        pilbl.ImageAlign = ContentAlignment.MiddleRight
        pilbl.Location = New Point(249, 148)
        pilbl.Name = "pilbl"
        pilbl.Size = New Size(25, 15)
        pilbl.TabIndex = 15
        pilbl.Text = "-₱0"
        pilbl.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' phlbl
        ' 
        phlbl.AutoSize = True
        phlbl.Font = New Font("Segoe UI", 9.0F)
        phlbl.ForeColor = Color.Red
        phlbl.ImageAlign = ContentAlignment.MiddleRight
        phlbl.Location = New Point(249, 124)
        phlbl.Name = "phlbl"
        phlbl.Size = New Size(25, 15)
        phlbl.TabIndex = 14
        phlbl.Text = "-₱0"
        phlbl.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ssslbl
        ' 
        ssslbl.AutoSize = True
        ssslbl.Font = New Font("Segoe UI", 9.0F)
        ssslbl.ForeColor = Color.Red
        ssslbl.ImageAlign = ContentAlignment.MiddleRight
        ssslbl.Location = New Point(249, 101)
        ssslbl.Name = "ssslbl"
        ssslbl.Size = New Size(25, 15)
        ssslbl.TabIndex = 13
        ssslbl.Text = "-₱0"
        ssslbl.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' overtimepayprlbl
        ' 
        overtimepayprlbl.AutoSize = True
        overtimepayprlbl.Font = New Font("Segoe UI", 9.0F)
        overtimepayprlbl.ForeColor = Color.Gray
        overtimepayprlbl.ImageAlign = ContentAlignment.MiddleRight
        overtimepayprlbl.Location = New Point(254, 67)
        overtimepayprlbl.Name = "overtimepayprlbl"
        overtimepayprlbl.Size = New Size(20, 15)
        overtimepayprlbl.TabIndex = 12
        overtimepayprlbl.Text = "₱0"
        ' 
        ' basicpaylbl
        ' 
        basicpaylbl.AutoSize = True
        basicpaylbl.Font = New Font("Segoe UI", 9.0F)
        basicpaylbl.ForeColor = Color.Gray
        basicpaylbl.ImageAlign = ContentAlignment.MiddleRight
        basicpaylbl.Location = New Point(254, 43)
        basicpaylbl.Name = "basicpaylbl"
        basicpaylbl.Size = New Size(20, 15)
        basicpaylbl.TabIndex = 11
        basicpaylbl.Text = "₱0"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(13, 239)
        Label15.Name = "Label15"
        Label15.Size = New Size(85, 21)
        Label15.TabIndex = 10
        Label15.Text = "Net Salary"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9.0F)
        Label14.ForeColor = Color.Gray
        Label14.Location = New Point(28, 200)
        Label14.Name = "Label14"
        Label14.Size = New Size(95, 15)
        Label14.TabIndex = 9
        Label14.Text = "Total Deductions"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9.0F)
        Label12.ForeColor = Color.Gray
        Label12.Location = New Point(13, 148)
        Label12.Name = "Label12"
        Label12.Size = New Size(53, 15)
        Label12.TabIndex = 7
        Label12.Text = "Pag-IBIG"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.0F)
        Label11.ForeColor = Color.Gray
        Label11.Location = New Point(13, 124)
        Label11.Name = "Label11"
        Label11.Size = New Size(62, 15)
        Label11.TabIndex = 6
        Label11.Text = "PhilHealth"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.0F)
        Label10.ForeColor = Color.Gray
        Label10.Location = New Point(13, 101)
        Label10.Name = "Label10"
        Label10.Size = New Size(25, 15)
        Label10.TabIndex = 5
        Label10.Text = "SSS"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.0F)
        Label9.ForeColor = Color.Gray
        Label9.Location = New Point(13, 67)
        Label9.Name = "Label9"
        Label9.Size = New Size(137, 15)
        Label9.TabIndex = 4
        Label9.Text = "Overtime  (6h × ₱115.00)"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.0F)
        Label8.ForeColor = Color.Gray
        Label8.Location = New Point(13, 43)
        Label8.Name = "Label8"
        Label8.Size = New Size(136, 15)
        Label8.TabIndex = 3
        Label8.Text = "Basic Pay  (26 × ₱920.00)"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Payslip_Preview
        PictureBox1.Location = New Point(13, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(17, 15)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(28, 2)
        Label7.Name = "Label7"
        Label7.Size = New Size(173, 25)
        Label7.TabIndex = 1
        Label7.Text = "PAYSLIP PREVIEW"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(daysworked)
        Panel2.Controls.Add(dailyrate)
        Panel2.Controls.Add(position)
        Panel2.Controls.Add(overtime)
        Panel2.Location = New Point(12, 134)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(295, 310)
        Panel2.TabIndex = 7
        ' 
        ' payrollsearch
        ' 
        payrollsearch.Font = New Font("Segoe UI Semilight", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        payrollsearch.ForeColor = SystemColors.GrayText
        payrollsearch.FormattingEnabled = True
        payrollsearch.Location = New Point(12, 93)
        payrollsearch.Name = "payrollsearch"
        payrollsearch.Size = New Size(652, 23)
        payrollsearch.TabIndex = 12
        payrollsearch.Text = "Search name"
        ' 
        ' Payroll
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(709, 462)
        Controls.Add(payrollsearch)
        Controls.Add(Panel1)
        Controls.Add(employee)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Payroll"
        Text = "Payroll"
        employee.ResumeLayout(False)
        employee.PerformLayout()
        dailyrate.ResumeLayout(False)
        dailyrate.PerformLayout()
        overtime.ResumeLayout(False)
        overtime.PerformLayout()
        daysworked.ResumeLayout(False)
        daysworked.PerformLayout()
        position.ResumeLayout(False)
        position.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents employee As Panel
    Friend WithEvents dailyrate As Panel
    Friend WithEvents overtime As Panel
    Friend WithEvents daysworked As Panel
    Friend WithEvents position As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents absences As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents dailyrateprlbl As Label
    Friend WithEvents overtimeprlbl As Label
    Friend WithEvents daysworkedprlbl As Label
    Friend WithEvents netlbl As Label
    Friend WithEvents pilbl As Label
    Friend WithEvents phlbl As Label
    Friend WithEvents ssslbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents basicpaylbl As Label
    Friend WithEvents totaldedlbl As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents nameprlbl As Label
    Friend WithEvents payrollsearch As ComboBox
    Friend WithEvents positionprlbl As Label
    Friend WithEvents overtimepayprlbl As Label
    Friend WithEvents taxlbl As Label
    Friend WithEvents Label18 As Label

End Class