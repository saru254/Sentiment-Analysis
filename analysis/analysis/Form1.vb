Public Class Form1
    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

    End Sub

    Private Sub btnAnalyze_Click(sender As Object, e As EventArgs) Handles btnAnalyze.Click
        Dim inputText As String = txtInput.Text
        Dim sentiment As String = AnalyzeSentiment(inputText)
        lblResult.Text = "Sentiment: " & sentiment
    End Sub

    Private Function AnalyzeSentiment(inputText As String) As String
        If Text.Contains("happy") Then
            Return "Positive"
        ElseIf Text.Contains("sad") Then
            Return "Ngative"
        Else
            Return "Neutral"
        End If
        Throw New NotImplementedException()
    End Function

    Private Sub lblResult_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub
End Class
