Public Class frmCurrencyConverter
    Dim euros As Double = 0.82
    Dim canadian As Double = 1.2
    Dim yen As Double = 109.55



    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Dim amount As Double = Convert.ToDouble(txtAmount.Text)
        Dim convertedEuro As Double = amount * euros
        Dim convertedCanadian As Double = amount * canadian
        Dim convertedYen As Double = amount * yen

        Label2.Text = txtAmount.Text & " dollars in Euros is " & convertedEuro & " Euros."
        Label3.Text = txtAmount.Text & " dollars in Canadian Dollars is " & convertedCanadian & " dollars."
        Label4.Text = txtAmount.Text & " dollars in Japanese Yen is " & convertedYen & " yen."

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
