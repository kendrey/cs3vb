Public Class Form1
    Private Sub btnCalcAvg_Click(sender As Object, e As EventArgs) Handles btnCalcAvg.Click
        Dim testOne As Double
        Dim testTwo As Double
        Dim testThree As Double

        testOne = CDbl(txtTest1.Text)
        testTwo = CDbl(txtTest2.Text)
        testThree = CDbl(txtTest3.Text)

        Dim average As Double
        average = (testOne + testTwo + testThree) / 3
        lblAverage.Text = average

        If average >= 90 Then
            lblGrade.Text = "A"
        ElseIf average >= 80 Then
            lblGrade.Text = "B"
        ElseIf average >= 70 Then
            lblGrade.Text = "C"
        ElseIf average >= 60 Then
            lblGrade.Text = "D"
        Else
            lblGrade.Text = "F"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTest1.Clear()
        txtTest2.Clear()
        txtTest3.Clear()
        lblAverage.Text = ""
        lblGrade.Text = ""
    End Sub
End Class
