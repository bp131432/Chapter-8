Public Class Friends
    Private lstNames As New List(Of String)

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim strName As String
        lstFriends.Items.Clear()

        For Each strName In lstNames
            lstFriends.Items.Add(strName)
        Next
    End Sub
End Class
Public Class 
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstNames.add(txtName.text)
        txtName.clear()
        txtName.Focus()
    End Sub
End Class