Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class CreateForm

    Private stopwatch As New Stopwatch()

    Private Sub CreateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000 ' Set the timer interval to 1 second
        Timer1.Enabled = False ' Initially disable the timer
        txtStopwatchTime.Text = "00:00:00"
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            Timer1.Enabled = False
        Else
            stopwatch.Start()
            Timer1.Enabled = True
        End If
        btnToggle.Text = If(stopwatch.IsRunning, "PAUSE", "START")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    ' Main logic starts here
    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Collect form data
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim githubLink As String = txtGithubLink.Text
        Dim stopwatchTime As String = txtStopwatchTime.Text

        ' Validate form data
        If String.IsNullOrEmpty(name) OrElse
           String.IsNullOrEmpty(email) OrElse
           String.IsNullOrEmpty(phone) OrElse
           String.IsNullOrEmpty(githubLink) OrElse
           String.IsNullOrEmpty(stopwatchTime) Then

            MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not IsNumeric(phone) OrElse phone.Length <> 10 Then
            MessageBox.Show("Phone number must be a 10-digit numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Create a submission object
        Dim submission As New Submission With {
            .Name = name,
            .Email = email,
            .Phone = phone,
            .GitHubLink = githubLink,
            .StopwatchTime = stopwatchTime
        }

        ' Convert the submission object to JSON
        Dim json As String = JsonConvert.SerializeObject(submission)

        ' Send a POST request to the backend to submit the form data
        Using client As New HttpClient()
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Try
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission successful!")
                Else
                    MessageBox.Show("Submission failed: " & response.ReasonPhrase)
                End If
            Catch ex As Exception
                MessageBox.Show("Submission failed: " & ex.Message)
            End Try
        End Using

        ' Reset form
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtGithubLink.Clear()
        stopwatch.Reset()
        Timer1.Enabled = False
        txtStopwatchTime.Clear()
        btnToggle.Text = "TOGGLE STOPWATCH (CTRL + T)"
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.S) Then
            btnSubmit.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.T) Then
            btnToggle.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHubLink As String
    Public Property StopwatchTime As String
End Class
