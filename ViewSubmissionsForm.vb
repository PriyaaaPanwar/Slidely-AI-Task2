Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private Const baseUrl As String = "http://localhost:3000"

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Function LoadSubmission(index As Integer) As Task
        Dim submission = Await GetSubmissionFromAPI(index)
        If submission IsNot Nothing Then
            DisplaySubmission(submission)
        Else
            MessageBox.Show("No more submissions available.")
        End If
    End Function

    Private Sub DisplaySubmission(submission As Submission)
        txtName.Text = submission.Name
        txtEmail.Text = submission.Email
        txtPhone.Text = submission.Phone
        txtGithub.Text = submission.GithubLink
        txtStopwatchTime.Text = submission.StopwatchTime
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await LoadSubmission(currentIndex)
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub

    Private Async Function GetSubmissionFromAPI(index As Integer) As Task(Of Submission)
        Try
            Using client As New HttpClient()
                Dim response = Await client.GetAsync($"{baseUrl}/read?index={index}")
                If response.IsSuccessStatusCode Then
                    Dim json = Await response.Content.ReadAsStringAsync()
                    Return JsonConvert.DeserializeObject(Of Submission)(json)
                Else
                    MessageBox.Show($"Error: {response.ReasonPhrase}")
                    Return Nothing
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Exception: {ex.Message}")
            Return Nothing
        End Try
    End Function
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String
End Class
