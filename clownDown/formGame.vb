Public Class formGame
    Const MAX_CLOWNS = 10
    Private alarmTime As Date
    Public Clowns(MAX_CLOWNS) As PictureBox

    Private Sub formGame_Click(sender As Object, e As EventArgs) Handles MyBase.Click

    End Sub



    Private Sub countdownTimer_Tick(sender As Object, e As EventArgs) Handles countdownTimer.Tick


        If alarmTime < Date.Now Then
            Me.countdownTimer.Stop()

            Try
                For i = 1 To MAX_CLOWNS
                    Controls.Remove(Clowns(i))
                Next
            Catch
            End Try

            clownDown.myFormGame.Hide()
            clownDown.myFormGameOver.Show()
            clownDown.myFormGameOver.BringToFront()

        Else
            Me.countdownTimer.Start()
            Dim remainingTime As TimeSpan = Me.alarmTime.Subtract(Date.Now)


            txtTimer.Text = String.Format("{0}:{1:d2}:{2:d2}",
                                           remainingTime.Hours,
                                           remainingTime.Minutes,
                                           remainingTime.Seconds)


        End If

    End Sub

    Private Sub formGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        txtClownValue.Text = 0
        txtTimer.Text = "00:00:00"


    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Try
            Dim clownNumber = Convert.ToInt32(txtClownValue.Text.Trim)

            If clownNumber > MAX_CLOWNS Or clownNumber < 1 Then
                MessageBox.Show("Please enter number between 1 and 10", "Clown Down", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Exit Sub
            End If
        Catch ex As Exception

        End Try


        lblInstruct.Visible = False
        btnStart.Enabled = False
        Me.Cursor = Cursors.Cross

        countdownTimer.Enabled = True
        growTimer.Enabled = True

        Me.countdownTimer.Start()

        Try

            Dim clownNumber = Convert.ToInt32(txtClownValue.Text.Trim)


            Dim i As Integer


            Me.alarmTime = Date.Now.AddSeconds(2 * clownNumber)

            txtClowns.Text = clownNumber
            txtClowns.Visible = True
            lblClowns.Visible = True


            For i = 1 To clownNumber Step 1


                Randomize()
                Dim randomNumberW As Integer = Int(Rnd() * 660) + 1

                Clowns(i) = New PictureBox
                Clowns(i).Image = Image.FromFile("C:\Temp\imgClown.jpg")
                Clowns(i).Location = New Point(randomNumberW, 175)
                Clowns(i).Size = New Size(93, 179)

                Controls.Add(Clowns(i))

                AddHandler Clowns(i).Click, AddressOf clown_Click


            Next




        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try





    End Sub

    Private Sub clown_Click(sender As Object, e As EventArgs)
        Dim pb As PictureBox = sender

        playShotgunSound()

        playDeathSound()

        Controls.Remove(pb)

        txtClowns.Text = txtClowns.Text - 1

        If txtClowns.Text.Trim = 0 Then
            clownDown.myFormGame.Hide()
            clownDown.myFormSuccess.Show()
            clownDown.myFormSuccess.BringToFront()

            countdownTimer.Enabled = False
            growTimer.Enabled = False


        End If

    End Sub

    Private Sub playDeathSound()
        My.Computer.Audio.Play("c:\Temp\sndDeath.wav")
    End Sub

    Private Sub playShotgunSound()
        My.Computer.Audio.Play("c:\Temp\sndShotgun.wav", AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub


    Private Sub formGame_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtTimer.Text = "00:00:00"
        btnStart.Enabled = True
        txtClowns.Visible = False
        lblClowns.Visible = False




    End Sub

    Private Sub formGame_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        playShotgunSound()
    End Sub

    Private Sub growTimer_Tick(sender As Object, e As EventArgs) Handles growTimer.Tick
        Try
            For i = 1 To MAX_CLOWNS


                Clowns(i).SizeMode = PictureBoxSizeMode.StretchImage

                Clowns(i).Height = Clowns(i).Height * 1.05
                Clowns(i).Width = Clowns(i).Width * 1.05

            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub formGame_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnStart.PerformClick()
        End If
    End Sub

    Private Sub txtClownValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClownValue.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Back)

            Case "0" To "9"

            Case "A" To "Z"
                Beep()
                e.Handled = True
            Case "a" To "z"
                Beep()
                e.Handled = True
            Case Else
                Beep()
                e.Handled = True
        End Select
    End Sub
End Class