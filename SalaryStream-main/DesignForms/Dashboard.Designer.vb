<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Dashbaordbtn = New Button()
        Emplyoyeebtn = New Button()
        Payrollbtn = New Button()
        Panel1 = New Panel()
        Avgdailyratepnl = New Panel()
        avgdrlbl = New Label()
        Label4 = New Label()
        Employeepnl = New Panel()
        totalemplbl = New Label()
        totalemptextdesign = New Label()
        Overtimepnl = New Panel()
        Label5 = New Label()
        Label6 = New Label()
        Bydepartmentpnl = New Panel()
        Label8 = New Label()
        departmentfp = New FlowLayoutPanel()
        Panel4 = New Panel()
        profilelogo = New PictureBox()
        datelbl = New Label()
        Dashboardlbl = New Label()
        addempbtn = New Button()
        Panel2 = New Panel()
        logoutbtn = New Button()
        PictureBox7 = New PictureBox()
        Payrollpb = New PictureBox()
        Employeepb = New PictureBox()
        Dashboardpb = New PictureBox()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        Avgdailyratepnl.SuspendLayout()
        Employeepnl.SuspendLayout()
        Overtimepnl.SuspendLayout()
        Bydepartmentpnl.SuspendLayout()
        Panel4.SuspendLayout()
        CType(profilelogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(Payrollpb, ComponentModel.ISupportInitialize).BeginInit()
        CType(Employeepb, ComponentModel.ISupportInitialize).BeginInit()
        CType(Dashboardpb, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Dashbaordbtn
        ' 
        Dashbaordbtn.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Dashbaordbtn.Location = New Point(13, 4)
        Dashbaordbtn.Name = "Dashbaordbtn"
        Dashbaordbtn.Size = New Size(178, 36)
        Dashbaordbtn.TabIndex = 0
        Dashbaordbtn.Text = "Dashboard"
        Dashbaordbtn.UseVisualStyleBackColor = True
        ' 
        ' Emplyoyeebtn
        ' 
        Emplyoyeebtn.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Emplyoyeebtn.Location = New Point(13, 42)
        Emplyoyeebtn.Name = "Emplyoyeebtn"
        Emplyoyeebtn.Size = New Size(178, 36)
        Emplyoyeebtn.TabIndex = 1
        Emplyoyeebtn.Text = "Employees"
        Emplyoyeebtn.UseVisualStyleBackColor = True
        ' 
        ' Payrollbtn
        ' 
        Payrollbtn.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Payrollbtn.Location = New Point(13, 80)
        Payrollbtn.Name = "Payrollbtn"
        Payrollbtn.Size = New Size(178, 36)
        Payrollbtn.TabIndex = 2
        Payrollbtn.Text = "          Payroll"
        Payrollbtn.TextAlign = ContentAlignment.MiddleLeft
        Payrollbtn.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        Panel1.Controls.Add(Avgdailyratepnl)
        Panel1.Controls.Add(Employeepnl)
        Panel1.Controls.Add(Overtimepnl)
        Panel1.Controls.Add(Bydepartmentpnl)
        Panel1.Controls.Add(Panel4)
        Panel1.Location = New Point(190, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(724, 442)
        Panel1.TabIndex = 5
        ' 
        ' Avgdailyratepnl
        ' 
        Avgdailyratepnl.BackColor = SystemColors.ButtonFace
        Avgdailyratepnl.Controls.Add(avgdrlbl)
        Avgdailyratepnl.Controls.Add(Label4)
        Avgdailyratepnl.Location = New Point(254, 94)
        Avgdailyratepnl.Name = "Avgdailyratepnl"
        Avgdailyratepnl.Size = New Size(213, 103)
        Avgdailyratepnl.TabIndex = 0
        ' 
        ' avgdrlbl
        ' 
        avgdrlbl.AutoSize = True
        avgdrlbl.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        avgdrlbl.Location = New Point(7, 23)
        avgdrlbl.Name = "avgdrlbl"
        avgdrlbl.Size = New Size(34, 40)
        avgdrlbl.TabIndex = 5
        avgdrlbl.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.GrayText
        Label4.Location = New Point(7, 6)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 17)
        Label4.TabIndex = 4
        Label4.Text = "Average Daily Rate"
        ' 
        ' Employeepnl
        ' 
        Employeepnl.BackColor = SystemColors.ButtonFace
        Employeepnl.Controls.Add(totalemplbl)
        Employeepnl.Controls.Add(totalemptextdesign)
        Employeepnl.Location = New Point(22, 94)
        Employeepnl.Name = "Employeepnl"
        Employeepnl.Size = New Size(216, 103)
        Employeepnl.TabIndex = 2
        ' 
        ' totalemplbl
        ' 
        totalemplbl.AutoSize = True
        totalemplbl.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        totalemplbl.Location = New Point(7, 23)
        totalemplbl.Name = "totalemplbl"
        totalemplbl.Size = New Size(34, 40)
        totalemplbl.TabIndex = 1
        totalemplbl.Text = "0"
        ' 
        ' totalemptextdesign
        ' 
        totalemptextdesign.AutoSize = True
        totalemptextdesign.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        totalemptextdesign.ForeColor = SystemColors.GrayText
        totalemptextdesign.Location = New Point(7, 6)
        totalemptextdesign.Name = "totalemptextdesign"
        totalemptextdesign.Size = New Size(103, 17)
        totalemptextdesign.TabIndex = 0
        totalemptextdesign.Text = "Total Employees"
        ' 
        ' Overtimepnl
        ' 
        Overtimepnl.BackColor = SystemColors.ButtonFace
        Overtimepnl.Controls.Add(Label5)
        Overtimepnl.Controls.Add(Label6)
        Overtimepnl.Location = New Point(482, 94)
        Overtimepnl.Name = "Overtimepnl"
        Overtimepnl.Size = New Size(213, 103)
        Overtimepnl.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(7, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(34, 40)
        Label5.TabIndex = 5
        Label5.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.GrayText
        Label6.Location = New Point(7, 5)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 17)
        Label6.TabIndex = 4
        Label6.Text = "Overtime Hours"
        ' 
        ' Bydepartmentpnl
        ' 
        Bydepartmentpnl.BackColor = SystemColors.ButtonFace
        Bydepartmentpnl.Controls.Add(Label8)
        Bydepartmentpnl.Controls.Add(departmentfp)
        Bydepartmentpnl.Location = New Point(22, 216)
        Bydepartmentpnl.Name = "Bydepartmentpnl"
        Bydepartmentpnl.Size = New Size(676, 204)
        Bydepartmentpnl.TabIndex = 4
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(13, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(125, 21)
        Label8.TabIndex = 2
        Label8.Text = "By Department"
        ' 
        ' departmentfp
        ' 
        departmentfp.Location = New Point(13, 35)
        departmentfp.Name = "departmentfp"
        departmentfp.Size = New Size(643, 154)
        departmentfp.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(addempbtn)
        Panel4.Controls.Add(profilelogo)
        Panel4.Controls.Add(datelbl)
        Panel4.Controls.Add(Dashboardlbl)
        Panel4.Location = New Point(0, 1)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(722, 77)
        Panel4.TabIndex = 6
        ' 
        ' profilelogo
        ' 
        profilelogo.Image = My.Resources.Resources.Profile_Photo
        profilelogo.Location = New Point(659, 21)
        profilelogo.Name = "profilelogo"
        profilelogo.Size = New Size(36, 31)
        profilelogo.SizeMode = PictureBoxSizeMode.Zoom
        profilelogo.TabIndex = 0
        profilelogo.TabStop = False
        ' 
        ' datelbl
        ' 
        datelbl.AutoSize = True
        datelbl.Font = New Font("Segoe UI", 9.75F)
        datelbl.ForeColor = SystemColors.ActiveCaptionText
        datelbl.Location = New Point(595, 29)
        datelbl.Name = "datelbl"
        datelbl.Size = New Size(65, 17)
        datelbl.TabIndex = 1
        datelbl.Text = "May 2026"
        ' 
        ' Dashboardlbl
        ' 
        Dashboardlbl.AutoSize = True
        Dashboardlbl.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Dashboardlbl.Location = New Point(7, 26)
        Dashboardlbl.Name = "Dashboardlbl"
        Dashboardlbl.Size = New Size(109, 25)
        Dashboardlbl.TabIndex = 0
        Dashboardlbl.Text = "Dashboard"
        ' 
        ' addempbtn
        ' 
        addempbtn.Location = New Point(564, 20)
        addempbtn.Name = "addempbtn"
        addempbtn.Size = New Size(131, 36)
        addempbtn.TabIndex = 2
        addempbtn.Text = "+ Add Employee"
        addempbtn.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        Panel2.Controls.Add(logoutbtn)
        Panel2.Controls.Add(PictureBox7)
        Panel2.Controls.Add(Payrollpb)
        Panel2.Controls.Add(Employeepb)
        Panel2.Controls.Add(Dashboardpb)
        Panel2.Controls.Add(Payrollbtn)
        Panel2.Controls.Add(Emplyoyeebtn)
        Panel2.Controls.Add(Dashbaordbtn)
        Panel2.Location = New Point(0, 109)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(193, 331)
        Panel2.TabIndex = 6
        ' 
        ' logoutbtn
        ' 
        logoutbtn.ForeColor = SystemColors.ControlDarkDark
        logoutbtn.Location = New Point(46, 273)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(93, 36)
        logoutbtn.TabIndex = 0
        logoutbtn.Text = "Log Out"
        logoutbtn.TextAlign = ContentAlignment.MiddleLeft
        logoutbtn.UseVisualStyleBackColor = True
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.Log_Out
        PictureBox7.Location = New Point(11, 273)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(34, 36)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 1
        PictureBox7.TabStop = False
        ' 
        ' Payrollpb
        ' 
        Payrollpb.Image = My.Resources.Resources.Payroll
        Payrollpb.Location = New Point(13, 80)
        Payrollpb.Name = "Payrollpb"
        Payrollpb.Size = New Size(34, 36)
        Payrollpb.SizeMode = PictureBoxSizeMode.Zoom
        Payrollpb.TabIndex = 3
        Payrollpb.TabStop = False
        ' 
        ' Employeepb
        ' 
        Employeepb.Image = My.Resources.Resources.Employees
        Employeepb.Location = New Point(13, 42)
        Employeepb.Name = "Employeepb"
        Employeepb.Size = New Size(34, 36)
        Employeepb.SizeMode = PictureBoxSizeMode.Zoom
        Employeepb.TabIndex = 4
        Employeepb.TabStop = False
        ' 
        ' Dashboardpb
        ' 
        Dashboardpb.Image = My.Resources.Resources.Dashboard
        Dashboardpb.Location = New Point(13, 4)
        Dashboardpb.Name = "Dashboardpb"
        Dashboardpb.Size = New Size(34, 36)
        Dashboardpb.SizeMode = PictureBoxSizeMode.Zoom
        Dashboardpb.TabIndex = 5
        Dashboardpb.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        Panel3.Controls.Add(PictureBox2)
        Panel3.Location = New Point(-2, -2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(195, 114)
        Panel3.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(11, 13)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(173, 91)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(909, 440)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        Avgdailyratepnl.ResumeLayout(False)
        Avgdailyratepnl.PerformLayout()
        Employeepnl.ResumeLayout(False)
        Employeepnl.PerformLayout()
        Overtimepnl.ResumeLayout(False)
        Overtimepnl.PerformLayout()
        Bydepartmentpnl.ResumeLayout(False)
        Bydepartmentpnl.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(profilelogo, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(Payrollpb, ComponentModel.ISupportInitialize).EndInit()
        CType(Employeepb, ComponentModel.ISupportInitialize).EndInit()
        CType(Dashboardpb, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Dashbaordbtn As Button
    Friend WithEvents Emplyoyeebtn As Button
    Friend WithEvents Payrollbtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Bydepartmentpnl As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Avgdailyratepnl As Panel
    Friend WithEvents Employeepnl As Panel
    Friend WithEvents Overtimepnl As Panel
    Friend WithEvents profilelogo As PictureBox
    Friend WithEvents Payrollpb As PictureBox
    Friend WithEvents Employeepb As PictureBox
    Friend WithEvents Dashboardpb As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents logoutbtn As Button
    Friend WithEvents Dashboardlbl As Label
    Friend WithEvents datelbl As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents addempbtn As Button
    Friend WithEvents totalemplbl As Label
    Friend WithEvents totalemptextdesign As Label
    Friend WithEvents departmentfp As FlowLayoutPanel
    Friend WithEvents avgdrlbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label

End Class