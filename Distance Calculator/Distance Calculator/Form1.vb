Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim intTotal As Integer = 0 ' Loop Counter 
        Dim intDistance As Integer = 0 ' Distance 
        Dim decSpeed As Decimal = 0 ' Speed  
        Dim decTime As Decimal = 0 ' Time Driving
        Dim decTotal As Decimal = 0 ' Total Distance 
        Dim strSpeedInput As String ' Input For Speed 
        Dim strTimeInput As String ' Input For Time 

        ' Input Speed
        strSpeedInput = InputBox("Enter the speed (in miles per hour) of the vehicle:")

        ' Convert to decimal 
        If Decimal.TryParse(strSpeedInput, decSpeed) Then
            ' Get time  
            strTimeInput = InputBox("Enter the time (in hours) that the vehicle is traveling:")
            ' Convert to decimal
            If Decimal.TryParse(strTimeInput, decTime) Then
                ' Calculate distance 
                decTotal = decTime * decSpeed

                '  display the speed 
                strSpeedInput = "Vehicle Speed: " & decSpeed.ToString() & " MPH"
                lstDistance.Items.Add(strSpeedInput)

                '  display time traveled 
                lstDistance.Items.Add("Time Traveled: " & decTime.ToString() & " Hours")

                '  adds hours and distance traveled columns 
                lstDistance.Items.Add("Hours Distance   Traveled")

                '  shows gap seperation
                lstDistance.Items.Add("-------------------")

                For intTotal = 1 To 7
                    '  Calculate Distance 
                    intDistance = CInt(intTotal * decSpeed)
                    lstDistance.Items.Add(intTotal.ToString & "     " & intDistance.ToString)  'puts more space between hours and disatnace
                Next

                '  Adding in Total
                lstDistance.Items.Add("Total Distance:  " & decTotal.ToString)
            Else
                '  Error Message
                MessageBox.Show("Error Enter a numeric value for Time.")
            End If
        Else
            '  Error Message
            MessageBox.Show("Error: Enter a numeric value For Speed.")
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close Program
        Me.Close()
    End Sub
End Class
