<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeePage
    Inherits System.Windows.Forms.UserControl

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

        components = New ComponentModel.Container()

        ContextMenuStrip1 = New ContextMenuStrip(components)

        DataGridView1 = New DataGridView()

        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()

        filtercb = New ComboBox()
        header = New Panel()
        searchbarcb = New ComboBox()

        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()

        header.SuspendLayout()

        SuspendLayout()

        ' Context Menu
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)

        ' Table
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

        DataGridView1.Columns.AddRange(New DataGridViewColumn() {
            Column1,
            Column2,
            Column3,
            Column4,
            Column5
        })

        DataGridView1.Location = New Point(27, 79)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(655, 224)
        DataGridView1.TabIndex = 12

        ' Name
        Column1.HeaderText = "Name"
        Column1.Name = "Column1"

        ' Position
        Column2.HeaderText = "Position"
        Column2.Name = "Column2"

        ' Daily Rate
        Column3.HeaderText = "Daily Rate"
        Column3.Name = "Column3"

        ' Attendance
        Column4.HeaderText = "Attendance"
        Column4.Name = "Column4"

        ' Overtime
        Column5.HeaderText = "Overtime"
        Column5.Name = "Column5"

        ' Filter
        filtercb.Font = New Font("Segoe UI", 9.0F,
                                 FontStyle.Regular,
                                 GraphicsUnit.Point,
                                 CByte(0))

        filtercb.FormattingEnabled = True
        filtercb.Location = New Point(549, 28)
        filtercb.Name = "filtercb"
        filtercb.Size = New Size(133, 23)
        filtercb.TabIndex = 10
        filtercb.Text = "Filter"

        ' Header
        header.Controls.Add(searchbarcb)
        header.Controls.Add(filtercb)

        header.Location = New Point(0, 1)
        header.Name = "header"
        header.Size = New Size(704, 72)
        header.TabIndex = 11

        ' Search
        searchbarcb.Font = New Font("Segoe UI Semilight",
                                    9.0F,
                                    FontStyle.Regular,
                                    GraphicsUnit.Point,
                                    CByte(0))

        searchbarcb.ForeColor = SystemColors.GrayText
        searchbarcb.FormattingEnabled = True

        searchbarcb.Location = New Point(27, 28)
        searchbarcb.Name = "searchbarcb"
        searchbarcb.Size = New Size(504, 23)
        searchbarcb.TabIndex = 11
        searchbarcb.Text = "Search by name or position ..."

        ' Employee Page
        BackColor = Color.FromArgb(CByte(245),
                                   CByte(247),
                                   CByte(250))

        Controls.Add(DataGridView1)
        Controls.Add(header)

        Name = "EmployeePage"
        Size = New Size(738, 445)

        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()

        header.ResumeLayout(False)

        ResumeLayout(False)

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents filtercb As ComboBox
    Friend WithEvents header As Panel
    Friend WithEvents searchbarcb As ComboBox

    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn

End Class