Public Class formSuccess
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Application.Exit()

   End Sub

   Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
      clownDown.myFormSuccess.Hide()
      clownDown.myFormMain.Show()
      clownDown.myFormMain.BringToFront()
   End Sub
End Class