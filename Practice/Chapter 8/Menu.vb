Public Class Menu

    Private Sub btnPlane_Click(sender As Object, e As EventArgs) Handles btnPlane.Click
        Dim box = New Plane
        box.Show()
    End Sub

    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles btnNumber.Click
        Dim box = New Number
        box.Show()
    End Sub

    Private Sub btnFriends_Click(sender As Object, e As EventArgs) Handles btnFriends.Click
        Dim box = New Friends
        box.Show()
    End Sub
End Class