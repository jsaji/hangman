Module PublicVars
    Public hangWord As String
    Public WordList As New List(Of String)
    Public playWord As Integer
    Public correctStreak As Integer = 0
    Public lettersLeft As Integer
    Public canvasColour As String
    Public textColour As String
    Public success As Boolean = False
    Public pichang(11) As String
    Public tries As Integer

    Public Sub wordListLoad(file)
        Dim fStream As New System.IO.FileStream(IO.Path.Combine(Application.StartupPath, file), IO.FileMode.Open)
        Dim sReader As New System.IO.StreamReader(fStream)
        Do While sReader.Peek >= 0
            WordList.Add(sReader.ReadLine)
        Loop
        sReader.Close()   'Closes the .txt file so as to prevent clashes
        Dim r As Random = New Random()
        For i = 0 To WordList.Count - 1
            Dim index As Integer = r.Next(i, WordList.Count)
            If i <> index Then
                Dim temp = WordList(i)
                WordList(i) = WordList(index)
                WordList(index) = temp
            End If
        Next
        'Shuffles words^

        playWord = 0
        Dim form As New PlayView
        form.Show()
    End Sub

End Module