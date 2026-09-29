<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateAccount))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.registerpanel = New System.Windows.Forms.Panel()
        Me.alreadyHacclb = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.registerbttn = New Guna.UI2.WinForms.Guna2Button()
        Me.genderlb = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.gendercmbbx = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.birthdatelb = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.birthdatecmbbx = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.usertypelb = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.usetypecmbbx = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.confirmpasswtxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.passwtxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.usernametxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lastnametxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.fnametxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Registerlb = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.createacclb = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.loginlinklb = New System.Windows.Forms.LinkLabel()
        Me.registerpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(22, 343)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Already have an account ?"
        '
        'registerpanel
        '
        Me.registerpanel.BackgroundImage = CType(resources.GetObject("registerpanel.BackgroundImage"), System.Drawing.Image)
        Me.registerpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.registerpanel.Controls.Add(Me.loginlinklb)
        Me.registerpanel.Controls.Add(Me.alreadyHacclb)
        Me.registerpanel.Controls.Add(Me.registerbttn)
        Me.registerpanel.Controls.Add(Me.genderlb)
        Me.registerpanel.Controls.Add(Me.gendercmbbx)
        Me.registerpanel.Controls.Add(Me.birthdatelb)
        Me.registerpanel.Controls.Add(Me.birthdatecmbbx)
        Me.registerpanel.Controls.Add(Me.usertypelb)
        Me.registerpanel.Controls.Add(Me.usetypecmbbx)
        Me.registerpanel.Controls.Add(Me.confirmpasswtxtbx)
        Me.registerpanel.Controls.Add(Me.passwtxtbx)
        Me.registerpanel.Controls.Add(Me.usernametxtbx)
        Me.registerpanel.Controls.Add(Me.lastnametxtbx)
        Me.registerpanel.Controls.Add(Me.fnametxtbx)
        Me.registerpanel.Controls.Add(Me.Registerlb)
        Me.registerpanel.Controls.Add(Me.createacclb)
        Me.registerpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.registerpanel.Location = New System.Drawing.Point(0, 0)
        Me.registerpanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.registerpanel.MaximumSize = New System.Drawing.Size(684, 307)
        Me.registerpanel.Name = "registerpanel"
        Me.registerpanel.Size = New System.Drawing.Size(684, 307)
        Me.registerpanel.TabIndex = 12
        '
        'alreadyHacclb
        '
        Me.alreadyHacclb.BackColor = System.Drawing.Color.Transparent
        Me.alreadyHacclb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.alreadyHacclb.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alreadyHacclb.ForeColor = System.Drawing.Color.White
        Me.alreadyHacclb.Location = New System.Drawing.Point(386, 284)
        Me.alreadyHacclb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.alreadyHacclb.Name = "alreadyHacclb"
        Me.alreadyHacclb.Size = New System.Drawing.Size(152, 17)
        Me.alreadyHacclb.TabIndex = 15
        Me.alreadyHacclb.Text = "Already have an account ?"
        '
        'registerbttn
        '
        Me.registerbttn.AutoRoundedCorners = True
        Me.registerbttn.BackColor = System.Drawing.Color.Transparent
        Me.registerbttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.registerbttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.registerbttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.registerbttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.registerbttn.FillColor = System.Drawing.Color.SaddleBrown
        Me.registerbttn.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.registerbttn.ForeColor = System.Drawing.Color.White
        Me.registerbttn.Location = New System.Drawing.Point(415, 240)
        Me.registerbttn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.registerbttn.Name = "registerbttn"
        Me.registerbttn.Size = New System.Drawing.Size(169, 29)
        Me.registerbttn.TabIndex = 14
        Me.registerbttn.Text = "Register"
        '
        'genderlb
        '
        Me.genderlb.BackColor = System.Drawing.Color.Transparent
        Me.genderlb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.genderlb.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderlb.ForeColor = System.Drawing.Color.White
        Me.genderlb.Location = New System.Drawing.Point(514, 179)
        Me.genderlb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.genderlb.Name = "genderlb"
        Me.genderlb.Size = New System.Drawing.Size(42, 17)
        Me.genderlb.TabIndex = 12
        Me.genderlb.Text = "Gender"
        '
        'gendercmbbx
        '
        Me.gendercmbbx.AutoRoundedCorners = True
        Me.gendercmbbx.BackColor = System.Drawing.Color.Transparent
        Me.gendercmbbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.gendercmbbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gendercmbbx.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gendercmbbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gendercmbbx.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.gendercmbbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.gendercmbbx.ItemHeight = 30
        Me.gendercmbbx.Items.AddRange(New Object() {"Male", "Female"})
        Me.gendercmbbx.Location = New System.Drawing.Point(504, 197)
        Me.gendercmbbx.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gendercmbbx.Name = "gendercmbbx"
        Me.gendercmbbx.Size = New System.Drawing.Size(122, 36)
        Me.gendercmbbx.TabIndex = 11
        '
        'birthdatelb
        '
        Me.birthdatelb.BackColor = System.Drawing.Color.Transparent
        Me.birthdatelb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.birthdatelb.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthdatelb.ForeColor = System.Drawing.Color.White
        Me.birthdatelb.Location = New System.Drawing.Point(331, 179)
        Me.birthdatelb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.birthdatelb.Name = "birthdatelb"
        Me.birthdatelb.Size = New System.Drawing.Size(53, 17)
        Me.birthdatelb.TabIndex = 10
        Me.birthdatelb.Text = "Birthdate"
        '
        'birthdatecmbbx
        '
        Me.birthdatecmbbx.AutoRoundedCorners = True
        Me.birthdatecmbbx.BackColor = System.Drawing.Color.Transparent
        Me.birthdatecmbbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.birthdatecmbbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.birthdatecmbbx.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.birthdatecmbbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.birthdatecmbbx.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.birthdatecmbbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.birthdatecmbbx.ItemHeight = 30
        Me.birthdatecmbbx.Location = New System.Drawing.Point(323, 197)
        Me.birthdatecmbbx.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.birthdatecmbbx.Name = "birthdatecmbbx"
        Me.birthdatecmbbx.Size = New System.Drawing.Size(164, 36)
        Me.birthdatecmbbx.TabIndex = 9
        '
        'usertypelb
        '
        Me.usertypelb.BackColor = System.Drawing.Color.Transparent
        Me.usertypelb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.usertypelb.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usertypelb.ForeColor = System.Drawing.Color.White
        Me.usertypelb.Location = New System.Drawing.Point(514, 123)
        Me.usertypelb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.usertypelb.Name = "usertypelb"
        Me.usertypelb.Size = New System.Drawing.Size(56, 17)
        Me.usertypelb.TabIndex = 8
        Me.usertypelb.Text = "User Type"
        '
        'usetypecmbbx
        '
        Me.usetypecmbbx.AutoRoundedCorners = True
        Me.usetypecmbbx.BackColor = System.Drawing.Color.Transparent
        Me.usetypecmbbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.usetypecmbbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.usetypecmbbx.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usetypecmbbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usetypecmbbx.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.usetypecmbbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.usetypecmbbx.ItemHeight = 30
        Me.usetypecmbbx.Items.AddRange(New Object() {"Admin", "Owner", "staff"})
        Me.usetypecmbbx.Location = New System.Drawing.Point(504, 145)
        Me.usetypecmbbx.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.usetypecmbbx.Name = "usetypecmbbx"
        Me.usetypecmbbx.Size = New System.Drawing.Size(122, 36)
        Me.usetypecmbbx.TabIndex = 7
        '
        'confirmpasswtxtbx
        '
        Me.confirmpasswtxtbx.AutoRoundedCorners = True
        Me.confirmpasswtxtbx.BackColor = System.Drawing.Color.Transparent
        Me.confirmpasswtxtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.confirmpasswtxtbx.DefaultText = ""
        Me.confirmpasswtxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.confirmpasswtxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.confirmpasswtxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmpasswtxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmpasswtxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmpasswtxtbx.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.confirmpasswtxtbx.ForeColor = System.Drawing.Color.Black
        Me.confirmpasswtxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmpasswtxtbx.Location = New System.Drawing.Point(504, 92)
        Me.confirmpasswtxtbx.Name = "confirmpasswtxtbx"
        Me.confirmpasswtxtbx.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.confirmpasswtxtbx.PlaceholderText = "Confirm Password"
        Me.confirmpasswtxtbx.SelectedText = ""
        Me.confirmpasswtxtbx.Size = New System.Drawing.Size(163, 27)
        Me.confirmpasswtxtbx.TabIndex = 6
        '
        'passwtxtbx
        '
        Me.passwtxtbx.AutoRoundedCorners = True
        Me.passwtxtbx.BackColor = System.Drawing.Color.Transparent
        Me.passwtxtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwtxtbx.DefaultText = ""
        Me.passwtxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.passwtxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.passwtxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwtxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwtxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwtxtbx.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.passwtxtbx.ForeColor = System.Drawing.Color.Black
        Me.passwtxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwtxtbx.Location = New System.Drawing.Point(504, 47)
        Me.passwtxtbx.Name = "passwtxtbx"
        Me.passwtxtbx.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.passwtxtbx.PlaceholderText = "Password"
        Me.passwtxtbx.SelectedText = ""
        Me.passwtxtbx.Size = New System.Drawing.Size(163, 27)
        Me.passwtxtbx.TabIndex = 5
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
        Me.usernametxtbx.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.usernametxtbx.ForeColor = System.Drawing.Color.Black
        Me.usernametxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usernametxtbx.Location = New System.Drawing.Point(323, 142)
        Me.usernametxtbx.Name = "usernametxtbx"
        Me.usernametxtbx.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.usernametxtbx.PlaceholderText = "User Name"
        Me.usernametxtbx.SelectedText = ""
        Me.usernametxtbx.Size = New System.Drawing.Size(163, 27)
        Me.usernametxtbx.TabIndex = 4
        '
        'lastnametxtbx
        '
        Me.lastnametxtbx.AutoRoundedCorners = True
        Me.lastnametxtbx.BackColor = System.Drawing.Color.Transparent
        Me.lastnametxtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lastnametxtbx.DefaultText = ""
        Me.lastnametxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lastnametxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lastnametxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lastnametxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lastnametxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lastnametxtbx.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.lastnametxtbx.ForeColor = System.Drawing.Color.Black
        Me.lastnametxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lastnametxtbx.Location = New System.Drawing.Point(323, 92)
        Me.lastnametxtbx.Name = "lastnametxtbx"
        Me.lastnametxtbx.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.lastnametxtbx.PlaceholderText = "Last Name"
        Me.lastnametxtbx.SelectedText = ""
        Me.lastnametxtbx.Size = New System.Drawing.Size(163, 27)
        Me.lastnametxtbx.TabIndex = 3
        '
        'fnametxtbx
        '
        Me.fnametxtbx.AutoRoundedCorners = True
        Me.fnametxtbx.BackColor = System.Drawing.Color.Transparent
        Me.fnametxtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fnametxtbx.DefaultText = ""
        Me.fnametxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fnametxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fnametxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fnametxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fnametxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fnametxtbx.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fnametxtbx.ForeColor = System.Drawing.Color.Black
        Me.fnametxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fnametxtbx.Location = New System.Drawing.Point(323, 47)
        Me.fnametxtbx.Name = "fnametxtbx"
        Me.fnametxtbx.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.fnametxtbx.PlaceholderText = "First Name"
        Me.fnametxtbx.SelectedText = ""
        Me.fnametxtbx.Size = New System.Drawing.Size(163, 27)
        Me.fnametxtbx.TabIndex = 2
        '
        'Registerlb
        '
        Me.Registerlb.BackColor = System.Drawing.Color.Transparent
        Me.Registerlb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Registerlb.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registerlb.ForeColor = System.Drawing.Color.White
        Me.Registerlb.Location = New System.Drawing.Point(437, 8)
        Me.Registerlb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Registerlb.Name = "Registerlb"
        Me.Registerlb.Size = New System.Drawing.Size(157, 26)
        Me.Registerlb.TabIndex = 1
        Me.Registerlb.Text = "Register Account"
        '
        'createacclb
        '
        Me.createacclb.BackColor = System.Drawing.Color.Transparent
        Me.createacclb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.createacclb.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createacclb.ForeColor = System.Drawing.Color.White
        Me.createacclb.Location = New System.Drawing.Point(209, 80)
        Me.createacclb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.createacclb.Name = "createacclb"
        Me.createacclb.Size = New System.Drawing.Size(90, 17)
        Me.createacclb.TabIndex = 0
        Me.createacclb.Text = "Create account"
        '
        'loginlinklb
        '
        Me.loginlinklb.AutoSize = True
        Me.loginlinklb.BackColor = System.Drawing.Color.Transparent
        Me.loginlinklb.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginlinklb.LinkColor = System.Drawing.Color.White
        Me.loginlinklb.Location = New System.Drawing.Point(547, 284)
        Me.loginlinklb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.loginlinklb.Name = "loginlinklb"
        Me.loginlinklb.Size = New System.Drawing.Size(41, 14)
        Me.loginlinklb.TabIndex = 16
        Me.loginlinklb.TabStop = True
        Me.loginlinklb.Text = "Log In"
        '
        'CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(686, 307)
        Me.Controls.Add(Me.registerpanel)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(706, 357)
        Me.Name = "CreateAccount"
        Me.Text = "CreateAccount"
        Me.registerpanel.ResumeLayout(False)
        Me.registerpanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents registerpanel As Panel
    Friend WithEvents createacclb As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents fnametxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Registerlb As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lastnametxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents usernametxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents confirmpasswtxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents passwtxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents usetypecmbbx As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents usertypelb As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents birthdatelb As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents birthdatecmbbx As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents genderlb As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents gendercmbbx As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents registerbttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents alreadyHacclb As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents loginlinklb As LinkLabel
End Class
