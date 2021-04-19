
Public Class Form1
    Shared random As New Random()
    Dim a As Integer = 1

    Function disable_panels()

        Panel1.Enabled = False
        Panel2.Enabled = False
        Panel3.Enabled = False
        Panel4.Enabled = False
        Panel5.Enabled = False
        Panel6.Enabled = False
        Panel7.Enabled = False
        Panel8.Enabled = False
        Panel9.Enabled = False

    End Function

    Function randomInt()

        Dim i As Integer

        For i = 0 To 0

            Dim RandInt As Integer = Convert.ToString(random.Next(1, 9))
            Return RandInt

        Next


    End Function


    Function win_status()

        'horizontal win
        If Panel1.BackColor = Color.LightSalmon And Panel2.BackColor = Color.LightSalmon And Panel3.BackColor = Color.LightSalmon Then
            lblWinner.Text = "Player 1 Wins (X)"
            disable_panels()
        ElseIf Panel1.BackColor = Color.LightCyan And Panel2.BackColor = Color.LightCyan And Panel3.BackColor = Color.LightCyan Then
            lblWinner.Text = "Player 2 Wins (O)"
            disable_panels()

        ElseIf Panel4.BackColor = Color.LightSalmon And Panel5.BackColor = Color.LightSalmon And Panel6.BackColor = Color.LightSalmon Then
            lblWinner.Text = "Player 1 Wins (X)"
            disable_panels()
        ElseIf Panel4.BackColor = Color.LightCyan And Panel5.BackColor = Color.LightCyan And Panel6.BackColor = Color.LightCyan Then
            lblWinner.Text = "Player 2 Wins (O)"
            disable_panels()

        ElseIf Panel7.BackColor = Color.LightSalmon And Panel8.BackColor = Color.LightSalmon And Panel9.BackColor = Color.LightSalmon Then
            lblWinner.Text = "Player 1 Wins (X)"
            disable_panels()
        ElseIf Panel7.BackColor = Color.LightCyan And Panel8.BackColor = Color.LightCyan And Panel9.BackColor = Color.LightCyan Then
            lblWinner.Text = "Player 2 Wins (O)"
            disable_panels()
            'vertical win
        ElseIf Panel1.BackColor = Color.LightSalmon And Panel4.BackColor = Color.LightSalmon And Panel7.BackColor = Color.LightSalmon Then
            lblWinner.Text = "Player 1 Wins (X)"
            disable_panels()
        ElseIf Panel1.BackColor = Color.LightCyan And Panel4.BackColor = Color.LightCyan And Panel7.BackColor = Color.LightCyan Then
            lblWinner.Text = "Player 2 Wins (O)"
            disable_panels()

        ElseIf Panel2.BackColor = Color.LightSalmon And Panel5.BackColor = Color.LightSalmon And Panel8.BackColor = Color.LightSalmon Then
            lblWinner.Text = "Player 1 Wins (X)"
            disable_panels()
        ElseIf Panel2.BackColor = Color.LightCyan And Panel5.BackColor = Color.LightCyan And Panel8.BackColor = Color.LightCyan Then
            lblWinner.Text = "Player 2 Wins (O)"
            disable_panels()

        ElseIf Panel3.BackColor = Color.LightSalmon And Panel6.BackColor = Color.LightSalmon And Panel9.BackColor = Color.LightSalmon Then
            lblWinner.Text = "Player 1 Wins (X)"
            disable_panels()
        ElseIf Panel3.BackColor = Color.LightCyan And Panel6.BackColor = Color.LightCyan And Panel9.BackColor = Color.LightCyan Then
            lblWinner.Text = "Player 2 Wins (O)"
            disable_panels()
            'diagonal win
        ElseIf Panel1.BackColor = Color.LightSalmon And Panel5.BackColor = Color.LightSalmon And Panel9.BackColor = Color.LightSalmon Then
            lblWinner.Text = "Player 1 Wins (X)"
            disable_panels()
        ElseIf Panel1.BackColor = Color.LightCyan And Panel5.BackColor = Color.LightCyan And Panel9.BackColor = Color.LightCyan Then
            lblWinner.Text = "Player 2 Wins (O)"
            disable_panels()

        ElseIf Panel3.BackColor = Color.LightSalmon And Panel5.BackColor = Color.LightSalmon And Panel7.BackColor = Color.LightSalmon Then
            lblWinner.Text = "Player 1 Wins (X)"
            disable_panels()
        ElseIf Panel3.BackColor = Color.LightCyan And Panel5.BackColor = Color.LightCyan And Panel7.BackColor = Color.LightCyan Then
            lblWinner.Text = "Player 2 Wins (O)"
            disable_panels()

        ElseIf a = 10 And lblWinner.Text = "------------------------" Then
            lblWinner.Text = "Round Tied"
            disable_panels()
        End If

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Button1.Hide()

        'Panel1.BackgroundImage = My.Resources.ticcircle
        Label2.Hide()
        Label1.Show()
        'Label2.Enabled = False


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub



    Private Sub Panel1_Click(sender As Object, e As EventArgs)



    End Sub



    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        If a Mod 2 <> 0 Then
            Panel2.BackgroundImage = My.Resources.ticcross
            Label2.Show()
            Label1.Hide()
            Panel2.BackColor = Color.LightSalmon
        ElseIf a Mod 2 = 0 Then
            Panel2.BackgroundImage = My.Resources.ticcircle
            Label2.Hide()
            Label1.Show()
            Panel2.BackColor = Color.LightCyan
        End If
        a = a + 1
        Panel2.Enabled = False
        win_status()

    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        If a Mod 2 <> 0 Then
            Panel3.BackgroundImage = My.Resources.ticcross
            Label2.Show()
            Label1.Hide()
            Panel3.BackColor = Color.LightSalmon
        ElseIf a Mod 2 = 0 Then
            Panel3.BackgroundImage = My.Resources.ticcircle
            Label2.Hide()
            Label1.Show()
            Panel3.BackColor = Color.LightCyan
        End If
        a = a + 1
        Panel3.Enabled = False
        win_status()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        If a Mod 2 <> 0 Then
            Panel4.BackgroundImage = My.Resources.ticcross
            Label2.Show()
            Label1.Hide()
            Panel4.BackColor = Color.LightSalmon
        ElseIf a Mod 2 = 0 Then
            Panel4.BackgroundImage = My.Resources.ticcircle
            Label2.Hide()
            Label1.Show()
            Panel4.BackColor = Color.LightCyan
        End If
        a = a + 1
        Panel4.Enabled = False
        win_status()
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        If a Mod 2 <> 0 Then
            Panel5.BackgroundImage = My.Resources.ticcross
            Label2.Show()
            Label1.Hide()
            Panel5.BackColor = Color.LightSalmon
        ElseIf a Mod 2 = 0 Then
            Panel5.BackgroundImage = My.Resources.ticcircle
            Label2.Hide()
            Label1.Show()
            Panel5.BackColor = Color.LightCyan
        End If
        a = a + 1
        Panel5.Enabled = False
        win_status()
    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        If a Mod 2 <> 0 Then
            Panel6.BackgroundImage = My.Resources.ticcross
            Label2.Show()
            Label1.Hide()
            Panel6.BackColor = Color.LightSalmon
        ElseIf a Mod 2 = 0 Then
            Panel6.BackgroundImage = My.Resources.ticcircle
            Label2.Hide()
            Label1.Show()
            Panel6.BackColor = Color.LightCyan
        End If
        a = a + 1
        Panel6.Enabled = False
        win_status()
    End Sub

    Private Sub Panel7_Click(sender As Object, e As EventArgs) Handles Panel7.Click
        If a Mod 2 <> 0 Then
            Panel7.BackgroundImage = My.Resources.ticcross
            Label2.Show()
            Label1.Hide()
            Panel7.BackColor = Color.LightSalmon
        ElseIf a Mod 2 = 0 Then
            Panel7.BackgroundImage = My.Resources.ticcircle
            Label2.Hide()
            Label1.Show()
            Panel7.BackColor = Color.LightCyan
        End If
        a = a + 1
        Panel7.Enabled = False
        win_status()
    End Sub

    Private Sub Panel8_Click(sender As Object, e As EventArgs) Handles Panel8.Click
        If a Mod 2 <> 0 Then
            Panel8.BackgroundImage = My.Resources.ticcross
            Label2.Show()
            Label1.Hide()
            Panel8.BackColor = Color.LightSalmon
        ElseIf a Mod 2 = 0 Then
            Panel8.BackgroundImage = My.Resources.ticcircle
            Label2.Hide()
            Label1.Show()
            Panel8.BackColor = Color.LightCyan
        End If
        a = a + 1
        Panel8.Enabled = False
        win_status()
    End Sub

    Private Sub Panel9_Click(sender As Object, e As EventArgs) Handles Panel9.Click
        If a Mod 2 <> 0 Then
            Panel9.BackgroundImage = My.Resources.ticcross
            Label2.Show()
            Label1.Hide()
            Panel9.BackColor = Color.LightSalmon
        ElseIf a Mod 2 = 0 Then
            Panel9.BackgroundImage = My.Resources.ticcircle
            Label2.Hide()
            Label1.Show()
            Panel9.BackColor = Color.LightCyan
        End If
        a = a + 1
        Panel9.Enabled = False
        win_status()
    End Sub

    Private Sub Panel1_Click_1(sender As Object, e As EventArgs) Handles Panel1.Click
        If a Mod 2 <> 0 Then
            Panel1.BackgroundImage = My.Resources.ticcross
            Label2.Show()
            Label1.Hide()
            Panel1.BackColor = Color.LightSalmon
        ElseIf a Mod 2 = 0 Then
            Panel1.BackgroundImage = My.Resources.ticcircle
            Label2.Hide()
            Label1.Show()
            Panel1.BackColor = Color.LightCyan
        End If
        a = a + 1
        Panel1.Enabled = False
        win_status()

    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub btnRetry_Click(sender As Object, e As EventArgs) Handles btnRetry.Click
        Panel1.Enabled = True
        Panel2.Enabled = True
        Panel3.Enabled = True
        Panel4.Enabled = True
        Panel5.Enabled = True
        Panel6.Enabled = True
        Panel7.Enabled = True
        Panel8.Enabled = True
        Panel9.Enabled = True
        Panel1.BackgroundImage = Nothing
        Panel2.BackgroundImage = Nothing
        Panel3.BackgroundImage = Nothing
        Panel4.BackgroundImage = Nothing
        Panel5.BackgroundImage = Nothing
        Panel6.BackgroundImage = Nothing
        Panel7.BackgroundImage = Nothing
        Panel8.BackgroundImage = Nothing
        Panel9.BackgroundImage = Nothing
        Panel1.BackColor = Nothing
        Panel2.BackColor = Nothing
        Panel3.BackColor = Nothing
        Panel4.BackColor = Nothing
        Panel5.BackColor = Nothing
        Panel6.BackColor = Nothing
        Panel7.BackColor = Nothing
        Panel8.BackColor = Nothing
        Panel9.BackColor = Nothing
        Label2.Hide()
        Label1.Show()
        lblWinner.Text = "------------------------"
        a = 1
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        MessageBox.Show("Made By Dimuth De Zoysa aka GHOSTHACKER", "Creator", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    'Dim RDINT As Integer = randomInt()
    'End Sub
End Class
