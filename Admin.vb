Public Class Admin
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim admincntrl As New Admincntrl

        Guna2Panel5.Controls.Clear()
        admincntrl.Dock = DockStyle.Fill
        Guna2Panel5.Controls.Add(admincntrl)
    End Sub
End Class
