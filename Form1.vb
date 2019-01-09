Public Class Form1
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim intMPG As Double 'Your car's personal Miles Per Gallon. If you don't know it, might develop more.
        Dim intGallons As Double 'Gallons of gas you bought. If you don't know, then might develop
        Dim getNumbers As Double 'Miles per Gallon and Gallons of gas multiplied.
        Dim getAnswer As Double 'Multiplied value divided by price of gas which tells you your mileage. 


        intMPG = CInt(txtMPG.Text)
        intGallons = CInt(txtGallonsOfGas.Text)

        'Math in the form. 
        getNumbers = intMPG * intGallons
        getAnswer = getNumbers / 1.85
        lblAmount.Text = getAnswer.ToString("")

    End Sub
End Class
