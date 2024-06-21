Imports Newtonsoft.Json.Linq
Imports System.Net.Http

Public Class CreateSubmissionForm

    Private stopwatchRunning As Boolean = False
    Private stopwatchTime As TimeSpan = TimeSpan.Zero
    Private stopwatchStart As DateTime

    Public Sub New()
        InitializeComponent()
        AddHandler Timer1.Tick, AddressOf Timer1_Tick
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        If stopwatchRunning Then
            Dim elapsed As TimeSpan = DateTime.Now - stopwatchStart
            stopwatchTime = stopwatchTime.Add(elapsed)
            lbStopwatchTime.Text = stopwatchTime.ToString("hh\:mm\:ss")
            stopwatchStart = DateTime.Now
        End If
    End Sub

    Private Async Function btnSubmit_ClickAsync(sender As Object, e As EventArgs) As Task Handles btnSubmit.Click
        Dim client As New HttpClient()
        Dim submission As New Dictionary(Of String, String) From {
        {"name", tbName.Text},
        {"email", tbEmail.Text},
        {"phone", tbPhone.Text},
        {"github_link", tbGithub.Text},
        {"stopwatch_time", lbStopwatchTime.Text}
    }
        Dim content As New FormUrlEncodedContent(submission)

        Try
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
            If response.IsSuccessStatusCode Then
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                Dim jsonResponse As JObject = JObject.Parse(responseBody)
                If jsonResponse("success").Value(Of Boolean)() Then
                    MessageBox.Show("Submission Successful!")
                    Me.Close()
                Else
                    MessageBox.Show("Submission Failed!")
                    Me.Close()
                End If
            Else
                MessageBox.Show("Submission Failed!")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
            Me.Close()
        End Try
    End Function


    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatchRunning Then
            ' Pause the stopwatch
            Timer1.Stop()
            stopwatchRunning = False
        Else
            ' Start or resume the stopwatch
            stopwatchStart = DateTime.Now
            Timer1.Start()
            stopwatchRunning = True
        End If
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.T
                    btnToggleStopwatch.PerformClick()
                Case Keys.S
                    btnSubmit.PerformClick()
            End Select
        End If
    End Sub


End Class