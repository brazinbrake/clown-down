Public Class formMain
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Application.Exit()
   End Sub

   Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
      clownDown.myFormMain.Hide()
      clownDown.myFormGame.Show()
      clownDown.myFormGame.BringToFront()

   End Sub

   Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

   End Sub
End Class