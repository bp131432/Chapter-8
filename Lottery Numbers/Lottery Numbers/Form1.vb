Public Class Form1

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Const intMAX_SUBSCRIPT As Integer = 4
        Dim intNumbers(intMAX_SUBSCRIPT) As Integer
        Dim intCount As Integer

        Dim rand As New Random

        For intCount = 0 To intMAX_SUBSCRIPT
            intNumbers(intCount) = rand.Next(100)
        Next

        lblFirst.Text = intNumbers(0).ToString
        lblSecond.Text = intNumbers(1).ToString
        lblThird.Text = intNumbers(2).ToString
        lblFourth.Text = intNumbers(3).ToString
        lblFifth.Text = intNumbers(4).ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
