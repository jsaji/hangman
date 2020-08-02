Public Class ResetForm
    Private Sub ResetForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If success = False And tries = 11 Then
            correctStreak = 0
            tries = 0
        End If

        Dim form As New PlayView
        form.Show()
        Me.Close()

    End Sub
End Class