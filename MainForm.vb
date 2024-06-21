Public Class MainForm
    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim CreateSubmissionForm As New CreateSubmissionForm()

        CreateSubmissionForm.Show()
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewSubmissionsForm As New ViewSubmissionForm()

        ViewSubmissionForm.Show()
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.V
                    btnViewSubmissions.PerformClick()
                Case Keys.N
                    btnCreateSubmission.PerformClick()
            End Select
        End If
    End Sub
End Class
