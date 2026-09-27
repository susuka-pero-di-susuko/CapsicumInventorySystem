Imports System.Text.RegularExpressions

Public Class Form1

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub loginbttn_Click(sender As Object, e As EventArgs)

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
            MessageBox.Show("Invalid username or password. Please ensure that both the username and password contain at least one uppercase letter, one number, and are at least 8 characters long.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub usernametxtbx_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub passwordtxtbx_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub showpasschcbx_CheckedChanged(sender As Object, e As EventArgs) Handles showpasschcbx.CheckedChanged

        If showpasschcbx.Checked = True Then
            passwordtxtbx.PasswordChar = ""
        Else
            passwordtxtbx.PasswordChar = "*"

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
