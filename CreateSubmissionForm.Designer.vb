Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    'Required by the Windows Form Designer
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblGithub = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGithub = New System.Windows.Forms.TextBox()
        Me.btnStopwatch = New System.Windows.Forms.Button()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.tableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.tableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(80, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(455, 22)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Priya Panwar, Slidely Task 2 - Create Submission"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblName.Location = New System.Drawing.Point(5, 1)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(199, 37)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEmail.Location = New System.Drawing.Point(5, 39)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(199, 37)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Email:"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPhone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPhone.Location = New System.Drawing.Point(5, 77)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(199, 37)
        Me.lblPhone.TabIndex = 5
        Me.lblPhone.Text = "Phone Num:"
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGithub
        '
        Me.lblGithub.AutoSize = True
        Me.lblGithub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGithub.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGithub.Location = New System.Drawing.Point(5, 115)
        Me.lblGithub.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGithub.Name = "lblGithub"
        Me.lblGithub.Size = New System.Drawing.Size(199, 37)
        Me.lblGithub.TabIndex = 7
        Me.lblGithub.Text = "Github Link For Task 2:"
        Me.lblGithub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Location = New System.Drawing.Point(213, 5)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(262, 22)
        Me.txtName.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEmail.Location = New System.Drawing.Point(213, 43)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(262, 22)
        Me.txtEmail.TabIndex = 4
        '
        'txtPhone
        '
        Me.txtPhone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPhone.Location = New System.Drawing.Point(213, 81)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(262, 22)
        Me.txtPhone.TabIndex = 6
        '
        'txtGithub
        '
        Me.txtGithub.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGithub.Location = New System.Drawing.Point(213, 119)
        Me.txtGithub.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGithub.Name = "txtGithub"
        Me.txtGithub.Size = New System.Drawing.Size(262, 22)
        Me.txtGithub.TabIndex = 8
        '
        'btnStopwatch
        '
        Me.btnStopwatch.BackColor = System.Drawing.Color.Yellow
        Me.btnStopwatch.Location = New System.Drawing.Point(21, 206)
        Me.btnStopwatch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStopwatch.Name = "btnStopwatch"
        Me.btnStopwatch.Size = New System.Drawing.Size(200, 37)
        Me.btnStopwatch.TabIndex = 9
        Me.btnStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.btnStopwatch.UseVisualStyleBackColor = False
        '
        'lblStopwatch
        '
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.BackColor = System.Drawing.Color.DarkGray
        Me.lblStopwatch.Location = New System.Drawing.Point(349, 217)
        Me.lblStopwatch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(55, 16)
        Me.lblStopwatch.TabIndex = 10
        Me.lblStopwatch.Text = "00:00:00"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(187, 251)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(160, 37)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "SUBMIT (CTRL + S)"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'tableLayoutPanel
        '
        Me.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tableLayoutPanel.ColumnCount = 2
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.54167!))
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.45833!))
        Me.tableLayoutPanel.Controls.Add(Me.lblName, 0, 0)
        Me.tableLayoutPanel.Controls.Add(Me.txtName, 1, 0)
        Me.tableLayoutPanel.Controls.Add(Me.lblEmail, 0, 1)
        Me.tableLayoutPanel.Controls.Add(Me.txtEmail, 1, 1)
        Me.tableLayoutPanel.Controls.Add(Me.lblPhone, 0, 2)
        Me.tableLayoutPanel.Controls.Add(Me.txtPhone, 1, 2)
        Me.tableLayoutPanel.Controls.Add(Me.lblGithub, 0, 3)
        Me.tableLayoutPanel.Controls.Add(Me.txtGithub, 1, 3)
        Me.tableLayoutPanel.Location = New System.Drawing.Point(21, 52)
        Me.tableLayoutPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tableLayoutPanel.Name = "tableLayoutPanel"
        Me.tableLayoutPanel.RowCount = 4
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tableLayoutPanel.Size = New System.Drawing.Size(480, 148)
        Me.tableLayoutPanel.TabIndex = 1
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 308)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.btnStopwatch)
        Me.Controls.Add(Me.tableLayoutPanel)
        Me.Controls.Add(Me.lblTitle)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "Create Submission"
        Me.tableLayoutPanel.ResumeLayout(False)
        Me.tableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtName As System.Windows.Forms.TextBox
    Private WithEvents txtEmail As System.Windows.Forms.TextBox
    Private WithEvents txtPhone As System.Windows.Forms.TextBox
    Private WithEvents txtGithub As System.Windows.Forms.TextBox
    Private WithEvents btnStopwatch As System.Windows.Forms.Button
    Private WithEvents lblStopwatch As System.Windows.Forms.Label
    Private WithEvents btnSubmit As System.Windows.Forms.Button
    Private WithEvents lblTitle As System.Windows.Forms.Label
    Private WithEvents lblName As System.Windows.Forms.Label
    Private WithEvents lblEmail As System.Windows.Forms.Label
    Private WithEvents lblPhone As System.Windows.Forms.Label
    Private WithEvents lblGithub As System.Windows.Forms.Label
    Private WithEvents tableLayoutPanel As System.Windows.Forms.TableLayoutPanel
End Class
