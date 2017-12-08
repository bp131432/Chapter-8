Public Class Plane

    Private Sub btnDisplayPrice_Click(sender As Object, e As EventArgs) Handles btnDisplayPrice.Click
        Dim intRow, intCol As Integer

        Const intMAX_ROW As Integer = 5
        Const intMAX_Col As Integer = 3

        Dim decPrice(,) = {{450D, 450D, 450D, 450D},
                           {425D, 425D, 425D, 425D},
                           {400D, 400D, 400D, 400D},
                           {375D, 375D, 375D, 375D},
                           {375D, 375D, 375D, 375D},
                           {350D, 350D, 350D, 350D}}
        Try
            intRow = CInt(txtRow.Text)
            intCol = CInt(txtColumn.Text)

            If intRow >= 0 And intRow <= intMAX_ROW Then
                If intCol >= 0 And intCol <= intMAX_Col Then
                    lblPrice.Text = decPrice(intRow, intCol).ToString("c")
                Else
                    MessageBox.Show("Column must be 0 through" & intMAX_Col.ToString())
                End If
            Else
                MessageBox.Show("Row and columns must be integers")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class