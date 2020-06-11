Public Class Form1
    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim rand As New Random() '  Random Number
        Dim die1 As Integer = rand.Next(1, 6) '  Int 1-6
        Dim die2 As Integer = rand.Next(1, 6) '  Int 1-6
        Dim die1Image, die2Image As String    '  Makes Images into Strings
        die1Image = DisplayDieFace(die1)
        pbDie1.Image = Image.FromFile(die1Image)
        die2Image = DisplayDieFace(die2)
        pbDie2.Image = Image.FromFile(die2Image)





    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() '  Close the Program
    End Sub

    Function DisplayDieFace(ByVal intDie As Integer)
        Dim strImage As String = ""
        Select Case intDie
            Case 1
                strImage = "die1.bmp"
            Case 2
                strImage = "die2.bmp"
            Case 3
                strImage = "die3.bmp"
            Case 4
                strImage = "die4.bmp"
            Case 5
                strImage = "die5.bmp"
            Case 6
                strImage = "die6.bmp"
        End Select
        Return strImage
    End Function
End Class