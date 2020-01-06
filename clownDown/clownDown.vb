Public Class clownDown
   Friend Shared myFormGame As formGame
   Friend Shared myFormGameOver As formGameOver
   Friend Shared myFormMain As formMain
   Friend Shared myFormSuccess As formSuccess

   Public Shared Sub main()
      myFormGame = New formGame
      myFormGameOver = New formGameOver
      myFormMain = New formMain
      myFormSuccess = New formSuccess

      Application.Run(myFormMain)
   End Sub

End Class
