Public Class Form1
    Dim euros As Double = 0.82
    Dim canadian As Double = 1.2
    Dim yen As Double = 109.55



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim amount As Double = Convert.ToDouble(TextBox1.Text)
        Dim convertedEuro As Double = amount * euros
        Dim convertedCanadian As Double = amount * canadian
        Dim convertedYen As Double = amount * yen

        Label2.Text = TextBox1.Text & " in Euros is " & convertedEuro
        Label3.Text = TextBox1.Text & " in Canadian Dollars is " & convertedCanadian
        Label4.Text = TextBox1.Text & " in Japanese Yen is " & convertedYen

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
