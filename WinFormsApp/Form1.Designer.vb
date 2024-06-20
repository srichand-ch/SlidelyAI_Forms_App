<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        btnCreateSubmission = New Button()
        btnViewSubmissions = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(488, 69)
        Label1.TabIndex = 0
        Label1.Text = "Sai Sri Chand Chintakayala, SlidelyAI Task 2 - Slidely Form App"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnCreateSubmission.BackColor = Color.DeepSkyBlue
        btnCreateSubmission.Cursor = Cursors.Hand
        btnCreateSubmission.Location = New Point(12, 169)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(488, 50)
        btnCreateSubmission.TabIndex = 1
        btnCreateSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        btnCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnViewSubmissions.BackColor = Color.LimeGreen
        btnViewSubmissions.Cursor = Cursors.Hand
        btnViewSubmissions.Location = New Point(12, 241)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(488, 51)
        btnViewSubmissions.TabIndex = 2
        btnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(512, 334)
        Controls.Add(btnViewSubmissions)
        Controls.Add(btnCreateSubmission)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "SlidelyAI Forms App"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents btnViewSubmissions As Button

End Class
