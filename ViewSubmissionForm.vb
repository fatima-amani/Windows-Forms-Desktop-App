Imports System.Net
Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ViewSubmissionForm

    Private currentIndex As Integer = 0

    Public Sub New()
        InitializeComponent()
        LoadSubmissionAsync(currentIndex)
    End Sub

    Private Async Sub LoadSubmissionAsync(index As Integer)
        Dim submission As Submission = Await FetchSubmissionAsync(index)


        If submission IsNot Nothing Then
            tbUserName.Text = submission.Name
            tbUserEmail.Text = submission.Email
            tbUserPhone.Text = submission.Phone
            tbUserGithub.Text = submission.GithubLink
            tbUserStopwatch.Text = submission.StopwatchTime

            'MsgBox(submission.GithubLink)
            'MsgBox(submission.StopwatchTime)

        End If
    End Sub

    Private Async Function FetchSubmissionAsync(index As Integer) As Task(Of Submission)
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
                If response.IsSuccessStatusCode Then
                    Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                    ' Deserialize JSON response to Submission object
                    Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(responseBody)
                    Debug.WriteLine("Fetched submission: " & responseBody)
                    Return submission
                ElseIf response.StatusCode = HttpStatusCode.NotFound Then
                    Dim errorResponse As String = Await response.Content.ReadAsStringAsync()
                    Dim errorMessage As String = JsonConvert.DeserializeObject(Of JObject)(errorResponse).GetValue("error").ToString()
                    MessageBox.Show(errorMessage)
                Else
                    MessageBox.Show("Unexpected error occurred")
                End If
                Return Nothing
            Catch ex As HttpRequestException
                MessageBox.Show("Error fetching submission: " & ex.Message)
                Return Nothing
            End Try
        End Using
    End Function


    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmissionAsync(currentIndex)
        Else
            MessageBox.Show("This is the first submission.")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        LoadSubmissionAsync(currentIndex)

    End Sub

    Private Sub ViewSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.P
                    btnPrevious.PerformClick()
                Case Keys.N
                    btnNext.PerformClick()
            End Select
        End If
    End Sub

End Class


Public Class Submission
    <JsonProperty("name")>
    Public Property Name As String
    <JsonProperty("email")>
    Public Property Email As String
    <JsonProperty("phone")>
    Public Property Phone As String
    <JsonProperty("github_link")>
    Public Property GithubLink As String
    <JsonProperty("stopwatch_time")>
    Public Property StopwatchTime As String
End Class




