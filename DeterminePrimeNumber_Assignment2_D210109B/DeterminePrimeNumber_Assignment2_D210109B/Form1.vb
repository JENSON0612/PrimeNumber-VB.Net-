Public Class Form1
    Private Sub CalPrimeNumber_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CalButton.Click
        answerBox.Items.Clear()
        Dim n1 As Integer = number1.Text
        Dim n2 As Integer = number2.Text
        Dim checkprime As Integer = 1
        Dim i As Integer
        Dim primenumber As Integer

        For primenumber = number1.Text To number2.Text
            For i = 2 To primenumber - 1
                If primenumber Mod i = 0 Then
                    checkprime = 0 ' the number is not a prime number
                    Exit For
                Else
                    checkprime = 1 ' the number is a prime number
                End If
            Next
            If checkprime = 1 Then
                answerBox.Items.Add(primenumber)
            End If
        Next
    End Sub

    Private Sub answerBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles answerBox.SelectedIndexChanged

    End Sub
End Class
