Imports System.Text.RegularExpressions

Public Class loginform




    Private Sub showpasschcbx_CheckedChanged(sender As Object, e As EventArgs) Handles showpasschcbx.CheckedChanged

        If showpasschcbx.Checked = True Then
            passwordtxtbx.PasswordChar = ""
        Else
            passwordtxtbx.PasswordChar = "*"

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub loginbttn_Click_1(sender As Object, e As EventArgs) Handles loginbttn.Click

        If usernametxtbx.Text = "" AndAlso passwordtxtbx.Text = "" Then
            MsgBox("Username and Password cannot be blank")
        ElseIf usernametxtbx.Text = "" Then
            MsgBox("Username cannot be blank")
        ElseIf passwordtxtbx.Text = "" Then
            MsgBox("Password cannot be blank")
        ElseIf usernametxtbx.Text.Length < 6 AndAlso
            passwordtxtbx.Text.Length < 6 Then
            MsgBox("Atleast have 6 characters")

        End If


        If Regex.IsMatch(usernametxtbx.Text, "[A-Z]") AndAlso
          Regex.IsMatch(usernametxtbx.Text, "[0-9]") AndAlso
          Regex.IsMatch(usernametxtbx.Text, ".{6}") AndAlso
          Regex.IsMatch(passwordtxtbx.Text, "[A-Z]") AndAlso
          Regex.IsMatch(passwordtxtbx.Text, "[0-9]") Then

            MsgBox("Login successfully")
        Else
            MessageBox.Show("Invalid username or password. Please ensure that both the username and password contain at least one uppercase letter,
            one number, and are at least 8 characters long.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub createaccntlinklb_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles createaccntlinklb.LinkClicked
        CreateAccount.Show() 'show create account form'
        Me.Hide() 'purpose is to hide the login form'
    End Sub
End Class
