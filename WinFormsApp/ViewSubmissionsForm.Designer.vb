<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnPrevious = New Button()
        btnNext = New Button()
        Label1 = New Label()
        lblName = New Label()
        lblEmail = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        btnDelete = New Button()
        btnEdit = New Button()
        btnUpdate = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnPrevious.BackColor = Color.LightSteelBlue
        btnPrevious.Cursor = Cursors.Hand
        btnPrevious.Location = New Point(29, 524)
        btnPrevious.Margin = New Padding(20, 20, 50, 20)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(149, 45)
        btnPrevious.TabIndex = 0
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnNext.BackColor = Color.CornflowerBlue
        btnNext.Cursor = Cursors.Hand
        btnNext.Location = New Point(284, 524)
        btnNext.Margin = New Padding(50, 20, 20, 20)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(149, 45)
        btnNext.TabIndex = 1
        btnNext.Text = "NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(438, 71)
        Label1.TabIndex = 2
        Label1.Text = "Sai Sri Chand Chintakayala, SlidelyAI Task 2 - View Submissions"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 10F)
        lblName.Location = New Point(79, 119)
        lblName.Name = "lblName"
        lblName.Size = New Size(45, 19)
        lblName.TabIndex = 3
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 10F)
        lblEmail.Location = New Point(79, 183)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(41, 19)
        lblEmail.TabIndex = 4
        lblEmail.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(79, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 19)
        Label4.TabIndex = 5
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.Location = New Point(76, 294)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 38)
        Label5.TabIndex = 6
        Label5.Text = "Github Link" & vbCrLf & "For Task 2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.Location = New Point(79, 360)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 38)
        Label6.TabIndex = 7
        Label6.Text = "Stop Watch" & vbCrLf & "Time"
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtName.BackColor = Color.Silver
        txtName.Cursor = Cursors.No
        txtName.Font = New Font("Segoe UI", 10F)
        txtName.Location = New Point(202, 119)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(211, 25)
        txtName.TabIndex = 8
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtEmail.BackColor = Color.Silver
        txtEmail.Cursor = Cursors.No
        txtEmail.Font = New Font("Segoe UI", 10F)
        txtEmail.Location = New Point(202, 179)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(211, 25)
        txtEmail.TabIndex = 9
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPhone
        ' 
        txtPhone.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtPhone.BackColor = Color.Silver
        txtPhone.Cursor = Cursors.No
        txtPhone.Font = New Font("Segoe UI", 10F)
        txtPhone.Location = New Point(202, 243)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(211, 25)
        txtPhone.TabIndex = 10
        txtPhone.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtGithubLink.BackColor = Color.Silver
        txtGithubLink.Cursor = Cursors.No
        txtGithubLink.Font = New Font("Segoe UI", 10F)
        txtGithubLink.Location = New Point(202, 309)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(211, 25)
        txtGithubLink.TabIndex = 11
        txtGithubLink.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtStopwatchTime.BackColor = Color.Silver
        txtStopwatchTime.Cursor = Cursors.No
        txtStopwatchTime.Font = New Font("Segoe UI", 10F)
        txtStopwatchTime.Location = New Point(202, 375)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(211, 25)
        txtStopwatchTime.TabIndex = 12
        txtStopwatchTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDelete.BackColor = SystemColors.ControlLight
        btnDelete.Cursor = Cursors.Hand
        btnDelete.Location = New Point(323, 454)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(90, 29)
        btnDelete.TabIndex = 13
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = SystemColors.ControlLight
        btnEdit.Cursor = Cursors.Hand
        btnEdit.Location = New Point(79, 454)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(90, 29)
        btnEdit.TabIndex = 14
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = SystemColors.ControlLight
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.Location = New Point(79, 454)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(90, 29)
        btnUpdate.TabIndex = 15
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.ControlLight
        btnCancel.Cursor = Cursors.Hand
        btnCancel.Location = New Point(323, 454)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(90, 29)
        btnCancel.TabIndex = 16
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(462, 598)
        Controls.Add(btnCancel)
        Controls.Add(btnUpdate)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(Label1)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Name = "ViewSubmissionsForm"
        Text = "View Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
End Class
