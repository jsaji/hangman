Public Class PlayView
    Public tries As Integer = 0
    Public rightMessage(10) As Array
    Public lettersLeft As Integer
    Public triesLeft As Integer

    'Greys out keys after they're pressed
    Private Sub KeyButtonDisable(ByVal sender As Object, ByVal e As EventArgs) Handles Button_A.Click,
    Button_B.Click, Button_C.Click, Button_D.Click, Button_E.Click, Button_F.Click, Button_G.Click, Button_H.Click, Button_I.Click, Button_J.Click,
    Button_K.Click, Button_L.Click, Button_M.Click, Button_N.Click, Button_O.Click, Button_P.Click,
    Button_Q.Click, Button_R.Click, Button_S.Click, Button_T.Click, Button_U.Click, Button_V.Click,
    Button_W.Click, Button_X.Click, Button_Y.Click, Button_Z.Click
        Dim butt As Button = DirectCast(sender, Button)
        butt.Enabled = False
        butt.BackColor = Color.BlueViolet
        Dim userInput As String

        If tries < 11 Then
            userInput = butt.Text
            ' Verifies user input
            Dim convert As Integer
            convert = 0
            For k = 0 To hangWord.Count - 1
                If hangWord(k) = userInput Then
                    Me.Controls("Letter" & k).Text = userInput
                    convert = convert + 1
                End If
            Next
            If convert = 0 Then
                tries = tries + 1
                wrongLetterBox.Text = (wrongLetterBox.Text + " " + userInput)
            End If
            lettersLeft = 0
            For i = 0 To hangWord.Count - 1
                If Me.Controls("Letter" & i).Visible = True Then
                    If Me.Controls("Letter" & i).Text = "__" Then
                        lettersLeft = lettersLeft + 1
                    End If
                End If
            Next

            'Gamewin
            If lettersLeft = 0 Then
                correctStreak = correctStreak + 1
                ContinuePlay.Visible = True
                winDeem.Visible = True
                winDeem.Text = "You got it!"
                success = True
            End If
        End If

        triesLeft = 11 - tries
        If success = False Then
            If triesLeft = 1 Then
                triesDisplay.Text = CStr(triesLeft) + " try left"
            ElseIf triesLeft > 1 Or triesLeft = 0 Then
                triesDisplay.Text = CStr(triesLeft) + " tries left"
            End If
        End If

        'Gameover
        If success = False And tries < 11 And tries > 0 Then
            Hangman.Image = System.Drawing.Bitmap.FromFile(IO.Path.Combine(Application.StartupPath, pichang(tries)))
        ElseIf tries = 11 And success = False Then
            ContinuePlay.Visible = True
            winDeem.Visible = True
            winDeem.Text = "Darn! It was:"
            success = False
            correctStreak = 0
            Hangman.Image = System.Drawing.Bitmap.FromFile(IO.Path.Combine(Application.StartupPath, pichang(tries)))
            For k = 0 To hangWord.Count - 1
                If hangWord(k) = " " Then
                    Continue For
                End If
                Me.Controls("Letter" & k).Text = hangWord(k)
            Next
        End If

    End Sub

    Private Sub WordGen(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromName(canvasColour)
        wrongLetterBox.ForeColor = Color.FromName(textColour)
        streakCount.ForeColor = Color.FromName(textColour)
        winDeem.ForeColor = Color.FromName(textColour)
        triesDisplay.ForeColor = Color.FromName(textColour)

        streakCount.Text = "Streak: " + CStr(correctStreak)

        'Enables underscores of the letters, and ignores " "
        hangWord = WordList(playWord)
        For k = 0 To hangWord.Count - 1
            If hangWord(k) = " " Then
                Continue For
            End If
            Me.Controls("Letter" & k).Visible = True
            Me.Controls("Letter" & k).ForeColor = Color.FromName(textColour)
        Next

        ' Centres the underscores
        Dim centre As Integer
        If Integer.TryParse(hangWord.Count / 2, 0) = True Then 'Tests that the length of the word is even
            centre = hangWord.Count / 2 'Halves it
            Me.Controls("Letter" & centre).Location = New Point((640), 498)
            Dim shift As Integer = 1
            Dim labelNo As Integer = centre - 1
            While labelNo >= 0
                Me.Controls("Letter" & labelNo).Location = New Point((640 - shift * 58), 498)
                shift = shift + 1
                labelNo = labelNo - 1
            End While
            shift = 1
            labelNo = centre + 1
            While labelNo <= hangWord.Count
                Me.Controls("Letter" & labelNo).Location = New Point((640 + shift * 58), 498)
                shift = shift + 1
                labelNo = labelNo + 1
            End While
        Else
            centre = ((hangWord.Count + 1) / 2) 'Since the word is odd)
            Me.Controls("Letter" & centre).Location = New Point((640 + 29), 498)
            Dim shift As Integer = 1
            Dim labelNo As Integer = centre - 1
            While labelNo >= 0
                Me.Controls("Letter" & labelNo).Location = New Point((640 - (shift * 58) + 29), 498)
                shift = shift + 1
                labelNo = labelNo - 1
            End While
            shift = 2
            labelNo = centre + 1
            While labelNo <= hangWord.Count
                Me.Controls("Letter" & labelNo).Location = New Point((640 + (shift * 58) - 29), 498)
                shift = shift + 1
                labelNo = labelNo + 1
            End While
        End If
    End Sub

    Private Sub BeginningDefine(sender As Object, e As EventArgs) Handles MyBase.Load
        triesLeft = 11 - tries
        triesDisplay.Text = CStr(triesLeft) + " tries left"
    End Sub

    Private Sub ReturnHome(sender As Object, e As EventArgs) Handles HomeButton.Click
        success = False
        playWord = 0
        WordList.Clear()
        Dim form As New MainMenu
        form.Show()
        Me.Close()
    End Sub

    Private Sub ContinuePlay_Click(sender As Object, e As EventArgs) Handles ContinuePlay.Click
        success = False
        playWord = playWord + 1
        lettersLeft = 0
        Dim form As New ResetForm
        form.Show()
        Me.Hide()
    End Sub
End Class