<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.showpasschcbx = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.passwordtxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.usernametxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.loginbttn = New Guna.UI2.WinForms.Guna2Button()
        Me.logopctbox = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.logopctbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.showpasschcbx)
        Me.Panel1.Controls.Add(Me.passwordtxtbx)
        Me.Panel1.Controls.Add(Me.usernametxtbx)
        Me.Panel1.Controls.Add(Me.loginbttn)
        Me.Panel1.Controls.Add(Me.logopctbox)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 0
        '
        'showpasschcbx
        '
        Me.showpasschcbx.AutoSize = True
        Me.showpasschcbx.BackColor = System.Drawing.Color.Transparent
        Me.showpasschcbx.Checked = True
        Me.showpasschcbx.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.showpasschcbx.CheckedState.BorderRadius = 0
        Me.showpasschcbx.CheckedState.BorderThickness = 0
        Me.showpasschcbx.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.showpasschcbx.CheckState = System.Windows.Forms.CheckState.Checked
        Me.showpasschcbx.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showpasschcbx.Location = New System.Drawing.Point(470, 269)
        Me.showpasschcbx.Name = "showpasschcbx"
        Me.showpasschcbx.Size = New System.Drawing.Size(159, 23)
        Me.showpasschcbx.TabIndex = 11
        Me.showpasschcbx.Text = "Show password"
        Me.showpasschcbx.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.showpasschcbx.UncheckedState.BorderRadius = 0
        Me.showpasschcbx.UncheckedState.BorderThickness = 0
        Me.showpasschcbx.UncheckedState.FillColor = System.Drawing.Color.Sienna
        Me.showpasschcbx.UseVisualStyleBackColor = False
        '
        'passwordtxtbx
        '
        Me.passwordtxtbx.AutoRoundedCorners = True
        Me.passwordtxtbx.BackColor = System.Drawing.Color.Transparent
        Me.passwordtxtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordtxtbx.DefaultText = ""
        Me.passwordtxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.passwordtxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.passwordtxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordtxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordtxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordtxtbx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.passwordtxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordtxtbx.Location = New System.Drawing.Point(461, 220)
        Me.passwordtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.passwordtxtbx.Name = "passwordtxtbx"
        Me.passwordtxtbx.PlaceholderText = "Pssword"
        Me.passwordtxtbx.SelectedText = ""
        Me.passwordtxtbx.Size = New System.Drawing.Size(286, 41)
        Me.passwordtxtbx.TabIndex = 10
        '
        'usernametxtbx
        '
        Me.usernametxtbx.AutoRoundedCorners = True
        Me.usernametxtbx.BackColor = System.Drawing.Color.Transparent
        Me.usernametxtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernametxtbx.DefaultText = ""
        Me.usernametxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.usernametxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.usernametxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernametxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernametxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usernametxtbx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usernametxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usernametxtbx.Location = New System.Drawing.Point(461, 158)
        Me.usernametxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.usernametxtbx.Name = "usernametxtbx"
        Me.usernametxtbx.PlaceholderText = "Username"
        Me.usernametxtbx.SelectedText = ""
        Me.usernametxtbx.Size = New System.Drawing.Size(286, 41)
        Me.usernametxtbx.TabIndex = 9
        '
        'loginbttn
        '
        Me.loginbttn.AutoRoundedCorners = True
        Me.loginbttn.BackColor = System.Drawing.Color.Transparent
        Me.loginbttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.loginbttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.loginbttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.loginbttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.loginbttn.FillColor = System.Drawing.Color.White
        Me.loginbttn.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbttn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.loginbttn.Location = New System.Drawing.Point(517, 311)
        Me.loginbttn.Name = "loginbttn"
        Me.loginbttn.Size = New System.Drawing.Size(159, 45)
        Me.loginbttn.TabIndex = 8
        Me.loginbttn.Text = "Login"
        '
        'logopctbox
        '
        Me.logopctbox.BackColor = System.Drawing.Color.Transparent
        Me.logopctbox.BackgroundImage = CType(resources.GetObject("logopctbox.BackgroundImage"), System.Drawing.Image)
        Me.logopctbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logopctbox.Location = New System.Drawing.Point(548, 12)
        Me.logopctbox.Name = "logopctbox"
        Me.logopctbox.Size = New System.Drawing.Size(128, 97)
        Me.logopctbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.logopctbox.TabIndex = 7
        Me.logopctbox.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(586, 402)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(126, 19)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Create Account"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(457, 402)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "New aacount ?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(536, 359)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "_____  or  _____"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(498, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please Login your account"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.logopctbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents logopctbox As PictureBox
    Friend WithEvents loginbttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents passwordtxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents usernametxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents showpasschcbx As Guna.UI2.WinForms.Guna2CheckBox
End Class
