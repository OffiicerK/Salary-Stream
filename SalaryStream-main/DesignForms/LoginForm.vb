Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class LoginForm

    Private isShowingPassword As Boolean = False

    Private Sub Form1_Load(sender As Object,
                           e As EventArgs) Handles MyBase.Load

        ' RENDER
        Me.SetStyle(
            ControlStyles.AllPaintingInWmPaint Or
            ControlStyles.UserPaint Or
            ControlStyles.DoubleBuffer,
            True)

        ' FORM
        Me.BackColor =
            Color.FromArgb(240, 242, 245)

        Me.FormBorderStyle =
            FormBorderStyle.FixedSingle

        Me.MaximizeBox = False

        ' PANELS
        pnlCard.Region = Nothing
        pnlLeft.Region = Nothing
        pnlEmail.Region = Nothing
        pnlPassword.Region = Nothing
        btnLogin.Region = Nothing

        pnlLeft.BackColor = Color.Transparent
        pnlRight.BackColor = Color.White

        ' INPUTS
        pnlEmail.BackColor =
            Color.FromArgb(242, 243, 247)

        pnlPassword.BackColor =
            Color.FromArgb(242, 243, 247)

        ' TEXTBOX
        TextBox1.BorderStyle = BorderStyle.None
        TextBox2.BorderStyle = BorderStyle.None

        TextBox1.BackColor = pnlEmail.BackColor
        TextBox2.BackColor = pnlPassword.BackColor

        TextBox1.ForeColor =
            Color.FromArgb(40, 40, 40)

        TextBox2.ForeColor =
            Color.FromArgb(40, 40, 40)

        TextBox2.UseSystemPasswordChar = True

        ' LABELS
        lblSignIn.ForeColor =
            Color.FromArgb(25, 25, 25)

        lblDescription.ForeColor =
            Color.FromArgb(130, 130, 130)

        Label2.ForeColor =
            Color.FromArgb(120, 120, 120)

        Label3.ForeColor =
            Color.FromArgb(120, 120, 120)

        lblShow.ForeColor =
            Color.FromArgb(120, 120, 120)

        ' BUTTON
        btnLogin.BackColor =
            Color.FromArgb(24, 119, 242)

        btnLogin.FlatAppearance.BorderSize = 0

    End Sub

    ' BACKGROUND
    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        MyBase.OnPaint(e)

        Dim g As Graphics = e.Graphics

        g.SmoothingMode =
            SmoothingMode.AntiAlias

        Using br As New SolidBrush(
            Color.FromArgb(240, 242, 245))

            g.FillRectangle(br,
                            Me.ClientRectangle)

        End Using

    End Sub

    ' LEFT PANEL
    Private Sub pnlLeft_Paint(sender As Object,
                              e As PaintEventArgs) _
                              Handles pnlLeft.Paint

        Dim g As Graphics = e.Graphics

        g.SmoothingMode =
            SmoothingMode.AntiAlias

        Dim rect As Rectangle =
            pnlLeft.ClientRectangle

        ' BLUE
        Using br As New SolidBrush(
            Color.FromArgb(24, 119, 242))

            g.FillRectangle(br, rect)

        End Using

        ' TOP
        Using br As New SolidBrush(
            Color.FromArgb(35, 255, 255, 255))

            g.FillEllipse(br,
                          rect.Width - 100,
                          -55,
                          170,
                          170)

        End Using

        ' BOTTOM
        Using br As New SolidBrush(
            Color.FromArgb(28, 255, 255, 255))

            g.FillEllipse(br,
                          -55,
                          rect.Height - 90,
                          110,
                          110)

        End Using

        ' TITLE
        Using titleFont As New Font(
            "Segoe UI",
            18,
            FontStyle.Bold)

            g.DrawString(
                "Welcome!",
                titleFont,
                Brushes.White,
                22,
                165)

        End Using

        ' SUBTITLE
        Using subFont As New Font(
            "Segoe UI",
            9,
            FontStyle.Regular)

            g.DrawString(
                "SalaryStream Payroll",
                subFont,
                Brushes.White,
                24,
                200)

        End Using

        ' TEXT
        Using descFont As New Font(
            "Segoe UI",
            8.5,
            FontStyle.Regular)

            g.DrawString(
                "" &
                vbCrLf &
                "" &
                vbCrLf &
                "Automate. Accurate. Always.",
                descFont,
                New SolidBrush(
                    Color.FromArgb(220, Color.White)),
                22,
                360)

        End Using

    End Sub

    ' PASSWORD
    Private Sub lblShow_MouseDown(sender As Object,
                                  e As MouseEventArgs) _
                                  Handles lblShow.MouseDown

        isShowingPassword = True

        TextBox2.UseSystemPasswordChar = False

        lblShow.Text = "Hide"

    End Sub

    Private Sub lblShow_MouseUp(sender As Object,
                                e As MouseEventArgs) _
                                Handles lblShow.MouseUp

        isShowingPassword = False

        TextBox2.UseSystemPasswordChar = True

        lblShow.Text = "Show"

        TextBox2.Focus()

        TextBox2.SelectionStart =
            TextBox2.TextLength

    End Sub

    ' EFFECTS
    Private Sub TextBox1_Enter(sender As Object,
                               e As EventArgs) _
                               Handles TextBox1.Enter

        pnlEmail.BackColor =
            Color.FromArgb(225, 235, 255)

        TextBox1.BackColor =
            Color.FromArgb(225, 235, 255)

    End Sub

    Private Sub TextBox1_Leave(sender As Object,
                               e As EventArgs) _
                               Handles TextBox1.Leave

        pnlEmail.BackColor =
            Color.FromArgb(242, 243, 247)

        TextBox1.BackColor =
            Color.FromArgb(242, 243, 247)

    End Sub

    Private Sub TextBox2_Enter(sender As Object,
                               e As EventArgs) _
                               Handles TextBox2.Enter

        pnlPassword.BackColor =
            Color.FromArgb(225, 235, 255)

        TextBox2.BackColor =
            Color.FromArgb(225, 235, 255)

    End Sub

    Private Sub TextBox2_Leave(sender As Object,
                               e As EventArgs) _
                               Handles TextBox2.Leave

        pnlPassword.BackColor =
            Color.FromArgb(242, 243, 247)

        TextBox2.BackColor =
            Color.FromArgb(242, 243, 247)

        If Not isShowingPassword Then

            TextBox2.UseSystemPasswordChar = True

            lblShow.Text = "Show"

        End If

    End Sub

    ' LOGIN
    Private Sub btnLogin_Click(sender As Object,
                               e As EventArgs) _
                               Handles btnLogin.Click

        Dim username As String = "admin"
        Dim password As String = "admin"

        If TextBox1.Text = username And
           TextBox2.Text = password Then

            MessageBox.Show(
                "Login Successful!",
                "Salary Stream",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            ' DASHBOARD
            Dashboard.Show()

            Me.Hide()

        Else

            MessageBox.Show(
                "Invalid Username or Password!",
                "Login Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub Label1_Click(sender As Object,
                             e As EventArgs)

    End Sub

End Class