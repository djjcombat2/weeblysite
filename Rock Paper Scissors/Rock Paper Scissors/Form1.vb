Public Class Form1
    'Dim compCount As Integer = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()

        Dim number As Integer

        Const Rock As Integer = 1
        Const Paper As Integer = 2
        Const Scissors As Integer = 3

        number = (3 * Rnd())

        If rockRadioButton.Checked And number = Rock Then
            resultLabel.Text = "Computer threw Rock. Draw!"
        ElseIf rockRadioButton.Checked And number = Paper Then
            resultLabel.Text = "Computer threw Paper. You Lose!"
        ElseIf rockRadioButton.Checked And number = Scissors Then
            resultLabel.Text = "Computer threw Scissors. You Win!"

        ElseIf paperRadioButton.Checked And number = Rock Then
            resultLabel.Text = "Computer threw Rock. You Win!"
        ElseIf paperRadioButton.Checked And number = Paper Then
            resultLabel.Text = "Computer threw Paper. Draw!"
        ElseIf paperRadioButton.Checked And number = Scissors Then
            resultLabel.Text = "Computer threw Scissors. You Lose!"

        ElseIf scissorsRadioButton.Checked And number = Rock Then
            resultLabel.Text = "Computer threw Rock. You Lose!"
        ElseIf scissorsRadioButton.Checked And number = Paper Then
            resultLabel.Text = "Computer threw Paper. You Win!"
        ElseIf scissorsRadioButton.Checked And number = Scissors Then
            resultLabel.Text = "Computer threw Scissors. Draw!"
        End If

    End Sub


End Class