Public Class CreateAccount
    Private Sub registerpanel_Paint(sender As Object, e As PaintEventArgs) Handles registerpanel.Paint

    End Sub

    Private Sub loginlinklb_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles loginlinklb.LinkClicked
        loginform.Show() 'show login form'
        Me.Hide() 'purpose is to hide the create account form'
    End Sub


End Class