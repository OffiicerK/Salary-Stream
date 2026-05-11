<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        pnlCard = New Panel()
        pnlRight = New Panel()
        lblSignIn = New Label()
        lblDescription = New Label()
        Label2 = New Label()
        pnlEmail = New Panel()
        TextBox1 = New TextBox()
        Label3 = New Label()
        pnlPassword = New Panel()
        TextBox2 = New TextBox()
        lblShow = New Label()
        btnLogin = New Button()
        pnlLeft = New Panel()
        PictureBox1 = New PictureBox()
        pnlCard.SuspendLayout()
        pnlRight.SuspendLayout()
        pnlEmail.SuspendLayout()
        pnlPassword.SuspendLayout()
        pnlLeft.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        ' CARD
        pnlCard.BackColor = Color.White
        pnlCard.Controls.Add(pnlRight)
        pnlCard.Location = New Point(12, 12)
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(923, 465)
        pnlCard.TabIndex = 1

        ' RIGHT
        pnlRight.BackColor = Color.White
        pnlRight.Controls.Add(lblSignIn)
        pnlRight.Controls.Add(lblDescription)
        pnlRight.Controls.Add(Label2)
        pnlRight.Controls.Add(pnlEmail)
        pnlRight.Controls.Add(Label3)
        pnlRight.Controls.Add(pnlPassword)
        pnlRight.Controls.Add(btnLogin)
        pnlRight.Location = New Point(272, 0)
        pnlRight.Name = "pnlRight"
        pnlRight.Size = New Size(652, 468)
        pnlRight.TabIndex = 0

        ' TITLE
        lblSignIn.AutoSize = True
        lblSignIn.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblSignIn.ForeColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        lblSignIn.Location = New Point(39, 76)
        lblSignIn.Name = "lblSignIn"
        lblSignIn.Size = New Size(104, 37)
        lblSignIn.TabIndex = 1
        lblSignIn.Text = "Sign in"

        ' TEXT
        lblDescription.AutoSize = True
        lblDescription.Font = New Font("Segoe UI", 9.5F)
        lblDescription.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        lblDescription.Location = New Point(41, 110)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(204, 17)
        lblDescription.TabIndex = 2
        lblDescription.Text = "Enter your credentials to continue"

        ' EMAIL
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F)
        Label2.ForeColor = Color.FromArgb(CByte(150), CByte(155), CByte(170))
        Label2.Location = New Point(39, 169)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 15)
        Label2.TabIndex = 3
        Label2.Text = "Email Address"

        ' EMAIL PANEL
        pnlEmail.BackColor = Color.FromArgb(CByte(242), CByte(243), CByte(247))
        pnlEmail.Controls.Add(TextBox1)
        pnlEmail.Location = New Point(39, 186)
        pnlEmail.Name = "pnlEmail"
        pnlEmail.Size = New Size(567, 44)
        pnlEmail.TabIndex = 4

        ' EMAIL BOX
        TextBox1.BackColor = Color.FromArgb(CByte(242), CByte(243), CByte(247))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 11.0F)
        TextBox1.ForeColor = Color.FromArgb(CByte(50), CByte(55), CByte(70))
        TextBox1.Location = New Point(12, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Email Address"
        TextBox1.Size = New Size(520, 20)
        TextBox1.TabIndex = 0

        ' PASSWORD
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.0F)
        Label3.ForeColor = Color.FromArgb(CByte(150), CByte(155), CByte(170))
        Label3.Location = New Point(39, 242)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 5
        Label3.Text = "Password"

        ' PASSWORD PANEL
        pnlPassword.BackColor = Color.FromArgb(CByte(242), CByte(243), CByte(247))
        pnlPassword.Controls.Add(TextBox2)
        pnlPassword.Controls.Add(lblShow)
        pnlPassword.Location = New Point(39, 259)
        pnlPassword.Name = "pnlPassword"
        pnlPassword.Size = New Size(567, 44)
        pnlPassword.TabIndex = 6

        ' PASSWORD BOX
        TextBox2.BackColor = Color.FromArgb(CByte(242), CByte(243), CByte(247))
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Segoe UI", 11.0F)
        TextBox2.ForeColor = Color.FromArgb(CByte(50), CByte(55), CByte(70))
        TextBox2.Location = New Point(12, 12)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Password"
        TextBox2.Size = New Size(470, 20)
        TextBox2.TabIndex = 0

        ' SHOW
        lblShow.AutoSize = True
        lblShow.Cursor = Cursors.Hand
        lblShow.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblShow.ForeColor = Color.Gray
        lblShow.Location = New Point(516, 16)
        lblShow.Name = "lblShow"
        lblShow.Size = New Size(38, 15)
        lblShow.TabIndex = 1
        lblShow.Text = "Show"

        ' BUTTON
        btnLogin.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(39, 337)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(567, 46)
        btnLogin.TabIndex = 7
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False

        ' LEFT
        pnlLeft.BackColor = Color.FromArgb(CByte(245), CByte(246), CByte(250))
        pnlLeft.Controls.Add(PictureBox1)
        pnlLeft.Location = New Point(12, 12)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Size = New Size(272, 465)
        pnlLeft.TabIndex = 0

        ' IMAGE
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(18, 76)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(76, 85)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False

        ' FORM
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(96.0F, 96.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(15), CByte(125), CByte(225))
        ClientSize = New Size(944, 489)
        Controls.Add(pnlLeft)
        Controls.Add(pnlCard)
        Font = New Font("Segoe UI", 9.0F)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Salary Stream"

        pnlCard.ResumeLayout(False)
        pnlRight.ResumeLayout(False)
        pnlRight.PerformLayout()
        pnlEmail.ResumeLayout(False)
        pnlEmail.PerformLayout()
        pnlPassword.ResumeLayout(False)
        pnlPassword.PerformLayout()
        pnlLeft.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCard As Panel
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents pnlRight As Panel

    Friend WithEvents lblSignIn As Label
    Friend WithEvents lblDescription As Label

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

    Friend WithEvents pnlEmail As Panel
    Friend WithEvents pnlPassword As Panel

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox

    Friend WithEvents lblShow As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class