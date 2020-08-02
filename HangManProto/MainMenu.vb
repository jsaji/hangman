Public Class MainMenu

    Private Sub QuitButton_MouseClick(sender As Object, e As MouseEventArgs) Handles QuitButton.MouseClick
        Close()
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        Dim form As New Themes
        form.Show()
        Me.Hide()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Box1.Image = System.Drawing.Bitmap.FromFile(IO.Path.Combine(Application.StartupPath, "Drawing\Box1_IMG.png"))
        Box2.Image = System.Drawing.Bitmap.FromFile(IO.Path.Combine(Application.StartupPath, "Drawing\\Box2_IMG.png"))
        Box3.Image = System.Drawing.Bitmap.FromFile(IO.Path.Combine(Application.StartupPath, "Drawing\\Box3_IMG.png"))
    End Sub
End Class