Public Class Themes

    Private Sub Normal_Click(sender As Object, e As EventArgs) Handles Normal.Click
        WordList.Clear()
        canvasColour = "LightCyan"
        textColour = "DarkBlue"
        wordListLoad("WordBanks\STD_WB.txt")
        pichang(0) = "Nope"
        pichang(1) = "Drawing\S_H\hs2.png"
        pichang(2) = "Drawing\S_H\hs3.png"
        pichang(3) = "Drawing\S_H\hs4.png"
        pichang(4) = "Drawing\S_H\hs5.png"
        pichang(5) = "Drawing\S_H\hs6.png"
        pichang(6) = "Drawing\S_H\hs7.png"
        pichang(7) = "Drawing\S_H\hs8.png"
        pichang(8) = "Drawing\S_H\hs9.png"
        pichang(9) = "Drawing\S_H\hs10.png"
        pichang(10) = "Drawing\S_H\hs11.png"
        pichang(11) = "Drawing\S_H\hs12.png"
        Me.Hide()

    End Sub

    Private Sub HarryPotter_Click(sender As Object, e As EventArgs) Handles HarryPotter.Click
        WordList.Clear()
        canvasColour = "DarkMagenta"
        textColour = "Gold"
        wordListLoad("WordBanks\HYPR_WB.txt")
        pichang(0) = "Nope"
        pichang(1) = "Drawing\HP\HP_1.png"
        pichang(2) = "Drawing\HP\HP_2.png"
        pichang(3) = "Drawing\HP\HP_3.png"
        pichang(4) = "Drawing\HP\HP_4.png"
        pichang(5) = "Drawing\HP\HP_5.png"
        pichang(6) = "Drawing\HP\HP_6.png"
        pichang(7) = "Drawing\HP\HP_7.png"
        pichang(8) = "Drawing\HP\HP_8.png"
        pichang(9) = "Drawing\HP\HP_9.png"
        pichang(10) = "Drawing\HP\HP_10.png"
        pichang(11) = "Drawing\HP\HP_11.png"
        Me.Hide()

    End Sub

    Private Sub Christmas_Click(sender As Object, e As EventArgs) Handles Christmas.Click
        WordList.Clear()
        canvasColour = "LimeGreen"
        textColour = "Crimson"
        wordListLoad("WordBanks\XMAS_WB.txt")
        pichang(0) = "Nope"
        pichang(1) = "Drawing\XMAS\XMAS_1.png"
        pichang(2) = "Drawing\XMAS\XMAS_2.png"
        pichang(3) = "Drawing\XMAS\XMAS_3.png"
        pichang(4) = "Drawing\XMAS\XMAS_4.png"
        pichang(5) = "Drawing\XMAS\XMAS_5.png"
        pichang(6) = "Drawing\XMAS\XMAS_6.png"
        pichang(7) = "Drawing\XMAS\XMAS_7.png"
        pichang(8) = "Drawing\XMAS\XMAS_8.png"
        pichang(9) = "Drawing\XMAS\XMAS_9.png"
        pichang(10) = "Drawing\XMAS\XMAS_10.png"
        pichang(11) = "Drawing\XMAS\XMAS_11.png"
        Me.Hide()

    End Sub

    Private Sub Halloween_Click(sender As Object, e As EventArgs) Handles Halloween.Click
        WordList.Clear()
        canvasColour = "DimGray"
        textColour = "DarkOrange"
        wordListLoad("WordBanks\HWN_WB.txt")
        pichang(0) = "Nope"
        pichang(1) = "Drawing\HWN\HWN_1.png"
        pichang(2) = "Drawing\HWN\HWN_2.png"
        pichang(3) = "Drawing\HWN\HWN_3.png"
        pichang(4) = "Drawing\HWN\HWN_4.png"
        pichang(5) = "Drawing\HWN\HWN_5.png"
        pichang(6) = "Drawing\HWN\HWN_6.png"
        pichang(7) = "Drawing\HWN\HWN_7.png"
        pichang(8) = "Drawing\HWN\HWN_8.png"
        pichang(9) = "Drawing\HWN\HWN_9.png"
        pichang(10) = "Drawing\HWN\HWN_10.png"
        pichang(11) = "Drawing\HWN\HWN_11.png"
        Me.Hide()

    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Dim form As New MainMenu
        form.Show()
        Me.Close()
    End Sub
End Class