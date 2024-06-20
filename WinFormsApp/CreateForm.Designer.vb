<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateForm
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        btnSubmit = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        btnToggle = New Button()
        Timer1 = New Timer(components)
        txtStopwatchTime = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(436, 57)
        Label1.TabIndex = 0
        Label1.Text = "Sai Sri Chand Chintakayala, SlidelyAI Task 2 - Create Submission"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnSubmit.BackColor = Color.CornflowerBlue
        btnSubmit.Cursor = Cursors.Hand
        btnSubmit.Location = New Point(39, 430)
        btnSubmit.Margin = New Padding(30)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(382, 39)
        btnSubmit.TabIndex = 1
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(39, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 2
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(39, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 3
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(39, 218)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 4
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(39, 271)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 30)
        Label5.TabIndex = 5
        Label5.Text = "Github Link " & vbCrLf & "For Task 2"
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtName.BackColor = SystemColors.Window
        txtName.Font = New Font("Segoe UI", 10F)
        txtName.Location = New Point(139, 91)
        txtName.Name = "txtName"
        txtName.Size = New Size(299, 25)
        txtName.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtEmail.BackColor = SystemColors.Window
        txtEmail.Font = New Font("Segoe UI", 10F)
        txtEmail.Location = New Point(139, 146)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(299, 25)
        txtEmail.TabIndex = 7
        ' 
        ' txtPhone
        ' 
        txtPhone.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtPhone.Font = New Font("Segoe UI", 10F)
        txtPhone.Location = New Point(139, 208)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(299, 25)
        txtPhone.TabIndex = 8
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtGithubLink.Font = New Font("Segoe UI", 10F)
        txtGithubLink.Location = New Point(139, 266)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(299, 25)
        txtGithubLink.TabIndex = 9
        ' 
        ' btnToggle
        ' 
        btnToggle.BackColor = Color.Goldenrod
        btnToggle.Font = New Font("Segoe UI", 9F)
        btnToggle.Location = New Point(39, 345)
        btnToggle.Name = "btnToggle"
        btnToggle.Size = New Size(207, 31)
        btnToggle.TabIndex = 10
        btnToggle.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnToggle.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.BackColor = SystemColors.ActiveBorder
        txtStopwatchTime.Cursor = Cursors.No
        txtStopwatchTime.Font = New Font("Segoe UI", 10F)
        txtStopwatchTime.Location = New Point(265, 348)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(173, 25)
        txtStopwatchTime.TabIndex = 11
        txtStopwatchTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' CreateForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(460, 508)
        Controls.Add(txtStopwatchTime)
        Controls.Add(btnToggle)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnSubmit)
        Controls.Add(Label1)
        Name = "CreateForm"
        Text = "Create Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents btnToggle As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtStopwatchTime As TextBox
End Class
