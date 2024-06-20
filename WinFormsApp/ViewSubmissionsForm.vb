Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text

Public Class ViewSubmissionsForm

    Private currentIndex As Integer = 0
    Private isEditing As Boolean = False
    Private submissions As List(Of Submission)

    Private Async Sub ViewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmissions()
        DisplaySubmission()
        ' Initially hide the update and cancel buttons
        btnUpdate.Visible = False
        btnCancel.Visible = False
    End Sub

    Private Async Function LoadSubmissions() As Task
        Using client As New HttpClient()
            Try
                ' Get the submissions
                Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/read")
                If response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                    submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(jsonResponse)
                    If submissions.Count = 0 Then
                        MessageBox.Show("No submissions available to display.")
                        ClearFields()
                    End If
                Else
                    MessageBox.Show("Failed to load submissions: " & response.ReasonPhrase)
                End If
            Catch ex As Exception
                MessageBox.Show("Failed to load submissions: " & ex.Message)
            End Try
        End Using
    End Function

    'to display the current form, by default displays the first form in database
    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Dim submission As Submission = submissions(currentIndex)
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhone.Text = submission.Phone
            txtGithubLink.Text = submission.GitHubLink
            txtStopwatchTime.Text = submission.StopwatchTime
        Else
            MessageBox.Show("No submissions available to display.")
            ClearFields()
        End If
    End Sub

    Private Sub ClearFields()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtGithubLink.Clear()
        txtStopwatchTime.Clear()
    End Sub

    'Logic for previous button
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    'Logic for next button
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub

    'Logic for delete button
    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Using client As New HttpClient()
                    Try
                        Dim response As HttpResponseMessage = Await client.DeleteAsync($"http://localhost:3000/delete/{currentIndex}")
                        If response.IsSuccessStatusCode Then
                            MessageBox.Show("Deletion successful!")
                            submissions.RemoveAt(currentIndex)
                            If currentIndex >= submissions.Count Then
                                currentIndex = submissions.Count - 1
                            End If
                            DisplaySubmission()
                        Else
                            MessageBox.Show("Failed to delete submission: " & response.ReasonPhrase)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Failed to delete submission: " & ex.Message)
                    End Try
                End Using
            End If
        End If
    End Sub

    ' Logic for edit button
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ToggleEditMode(True)
    End Sub

    ' Logic for cancel button
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ToggleEditMode(False)
        DisplaySubmission()
    End Sub

    'Logic for update button
    Private Async Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        ' Validate form data
        If String.IsNullOrEmpty(txtName.Text) OrElse
           String.IsNullOrEmpty(txtEmail.Text) OrElse
           String.IsNullOrEmpty(txtPhone.Text) OrElse
           String.IsNullOrEmpty(txtGithubLink.Text) OrElse
           String.IsNullOrEmpty(txtStopwatchTime.Text) Then

            MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not IsNumeric(txtPhone.Text) OrElse txtPhone.Text.Length <> 10 Then
            MessageBox.Show("Phone number must be a 10-digit numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim updatedSubmission As New Submission With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .GitHubLink = txtGithubLink.Text,
            .StopwatchTime = txtStopwatchTime.Text
        }

        Using client As New HttpClient()
            Dim json As String = JsonConvert.SerializeObject(updatedSubmission)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Try
                Dim response As HttpResponseMessage = Await client.PutAsync("http://localhost:3000/update/" & currentIndex, content)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Update successful!")
                    submissions(currentIndex) = updatedSubmission
                    ToggleEditMode(False)
                Else
                    MessageBox.Show("Failed to update submission: " & response.ReasonPhrase)
                End If
            Catch ex As Exception
                MessageBox.Show("Failed to update submission: " & ex.Message)
            End Try
        End Using
    End Sub

    'This is the custom function for shortcut key
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.N) Then
            btnNext.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.P) Then
            btnPrevious.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    ' Toggle between view and edit mode
    Private Sub ToggleEditMode(isEditMode As Boolean)
        isEditing = isEditMode
        txtName.ReadOnly = Not isEditMode
        txtEmail.ReadOnly = Not isEditMode
        txtPhone.ReadOnly = Not isEditMode
        txtGithubLink.ReadOnly = Not isEditMode
        txtStopwatchTime.ReadOnly = Not isEditMode

        btnEdit.Visible = Not isEditMode
        btnPrevious.Visible = Not isEditMode
        btnNext.Visible = Not isEditMode
        btnDelete.Visible = Not isEditMode

        btnUpdate.Visible = isEditMode
        btnCancel.Visible = isEditMode

        Dim editColor As Color = Color.White
        Dim readOnlyColor As Color = Color.Silver
        Dim editCursor As Cursor = Cursors.IBeam
        Dim readOnlyCursor As Cursor = Cursors.No

        If isEditMode Then
            txtName.BackColor = editColor
            txtEmail.BackColor = editColor
            txtPhone.BackColor = editColor
            txtGithubLink.BackColor = editColor
            txtStopwatchTime.BackColor = editColor

            txtName.Cursor = editCursor
            txtEmail.Cursor = editCursor
            txtPhone.Cursor = editCursor
            txtGithubLink.Cursor = editCursor
            txtStopwatchTime.Cursor = editCursor


        Else
            txtName.BackColor = readOnlyColor
            txtEmail.BackColor = readOnlyColor
            txtPhone.BackColor = readOnlyColor
            txtGithubLink.BackColor = readOnlyColor
            txtStopwatchTime.BackColor = readOnlyColor

            txtName.Cursor = readOnlyCursor
            txtEmail.Cursor = readOnlyCursor
            txtPhone.Cursor = readOnlyCursor
            txtGithubLink.Cursor = readOnlyCursor
            txtStopwatchTime.Cursor = readOnlyCursor
        End If
    End Sub

End Class