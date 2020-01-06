Public Class formGameOver
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Application.Exit()

   End Sub

    Private Sub btnRetry_Click(sender As Object, e As EventArgs) Handles btnRetry.Click

        'Try
        '    For Each x In clownDown.myFormGame.Controls
        '        If TypeOf x Is PictureBox Then
        '            clownDown.myFormGame.Controls.Remove(x)
        '        End If
        '    Next x

        '    clownDown.myFormGame.Refresh()
        'Catch
        'End Try


        clownDown.myFormGameOver.Hide()
        clownDown.myFormGame.Show()
        clownDown.myFormGame.BringToFront()






    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
      clownDown.myFormGameOver.Hide()
      clownDown.myFormMain.Show()
      clownDown.myFormMain.BringToFront()
   End Sub
End Class