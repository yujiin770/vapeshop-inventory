<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation6 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Dim Animation7 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim Animation10 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim Animation8 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim Animation9 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2MouseStateHandler1 = New Guna.UI2.WinForms.Guna2MouseStateHandler(Me.components)
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.pictureboxTransition = New Guna.UI2.WinForms.Guna2Transition()
        Me.labeltransition = New Guna.UI2.WinForms.Guna2Transition()
        Me.textboxtransition = New Guna.UI2.WinForms.Guna2Transition()
        Me.buttontransition = New Guna.UI2.WinForms.Guna2Transition()
        Me.chkShowHidePassword = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Showpasswordtransition = New Guna.UI2.WinForms.Guna2Transition()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.pictureboxTransition.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.labeltransition.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.buttontransition.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Showpasswordtransition.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.textboxtransition.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(635, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 47)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username:"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.pictureboxTransition.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.labeltransition.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.buttontransition.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Showpasswordtransition.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.textboxtransition.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(635, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 44)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password:"
        Me.Label2.Visible = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.pictureboxTransition.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.labeltransition.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.buttontransition.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Showpasswordtransition.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.textboxtransition.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(108, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(263, 50)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "C  n C VapeShop"
        '
        'txtUsername
        '
        Me.txtUsername.BorderRadius = 7
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Showpasswordtransition.SetDecoration(Me.txtUsername, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.textboxtransition.SetDecoration(Me.txtUsername, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.labeltransition.SetDecoration(Me.txtUsername, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.buttontransition.SetDecoration(Me.txtUsername, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pictureboxTransition.SetDecoration(Me.txtUsername, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.Parent = Me.txtUsername
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.FocusedState.Parent = Me.txtUsername
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.HoverState.Parent = Me.txtUsername
        Me.txtUsername.Location = New System.Drawing.Point(639, 292)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = "Enter your Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.ShadowDecoration.Parent = Me.txtUsername
        Me.txtUsername.Size = New System.Drawing.Size(317, 34)
        Me.txtUsername.TabIndex = 6
        Me.txtUsername.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.BorderRadius = 7
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Showpasswordtransition.SetDecoration(Me.txtPassword, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.textboxtransition.SetDecoration(Me.txtPassword, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.labeltransition.SetDecoration(Me.txtPassword, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.buttontransition.SetDecoration(Me.txtPassword, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pictureboxTransition.SetDecoration(Me.txtPassword, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.Parent = Me.txtPassword
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.FocusedState.Parent = Me.txtPassword
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.HoverState.Parent = Me.txtPassword
        Me.txtPassword.Location = New System.Drawing.Point(639, 380)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderText = "Enter your Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.ShadowDecoration.Parent = Me.txtPassword
        Me.txtPassword.Size = New System.Drawing.Size(317, 34)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.Visible = False
        '
        'PictureBox1
        '
        Me.labeltransition.SetDecoration(Me.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Showpasswordtransition.SetDecoration(Me.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pictureboxTransition.SetDecoration(Me.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.textboxtransition.SetDecoration(Me.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.buttontransition.SetDecoration(Me.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = Global.VapeShopInventory.My.Resources.Resources.logovape
        Me.PictureBox1.Location = New System.Drawing.Point(0, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(533, 738)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.Animated = True
        Me.btnLogin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogin.BorderRadius = 12
        Me.btnLogin.BorderThickness = 2
        Me.btnLogin.CheckedState.Parent = Me.btnLogin
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.CustomImages.Parent = Me.btnLogin
        Me.textboxtransition.SetDecoration(Me.btnLogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Showpasswordtransition.SetDecoration(Me.btnLogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.labeltransition.SetDecoration(Me.btnLogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pictureboxTransition.SetDecoration(Me.btnLogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.buttontransition.SetDecoration(Me.btnLogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogin.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnLogin.HoverState.Parent = Me.btnLogin
        Me.btnLogin.Location = New System.Drawing.Point(639, 471)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.ShadowDecoration.Parent = Me.btnLogin
        Me.btnLogin.Size = New System.Drawing.Size(317, 52)
        Me.btnLogin.TabIndex = 9
        Me.btnLogin.Text = "Login"
        Me.btnLogin.Visible = False
        '
        'pictureboxTransition
        '
        Me.pictureboxTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        Me.pictureboxTransition.Cursor = Nothing
        Animation6.AnimateOnlyDifferences = True
        Animation6.BlindCoeff = CType(resources.GetObject("Animation6.BlindCoeff"), System.Drawing.PointF)
        Animation6.LeafCoeff = 0.0!
        Animation6.MaxTime = 1.0!
        Animation6.MinTime = 0.0!
        Animation6.MosaicCoeff = CType(resources.GetObject("Animation6.MosaicCoeff"), System.Drawing.PointF)
        Animation6.MosaicShift = CType(resources.GetObject("Animation6.MosaicShift"), System.Drawing.PointF)
        Animation6.MosaicSize = 0
        Animation6.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation6.RotateCoeff = 0.0!
        Animation6.RotateLimit = 0.0!
        Animation6.ScaleCoeff = CType(resources.GetObject("Animation6.ScaleCoeff"), System.Drawing.PointF)
        Animation6.SlideCoeff = CType(resources.GetObject("Animation6.SlideCoeff"), System.Drawing.PointF)
        Animation6.TimeCoeff = 0.0!
        Animation6.TransparencyCoeff = 0.0!
        Me.pictureboxTransition.DefaultAnimation = Animation6
        '
        'labeltransition
        '
        Me.labeltransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale
        Me.labeltransition.Cursor = Nothing
        Animation7.AnimateOnlyDifferences = True
        Animation7.BlindCoeff = CType(resources.GetObject("Animation7.BlindCoeff"), System.Drawing.PointF)
        Animation7.LeafCoeff = 0.0!
        Animation7.MaxTime = 1.0!
        Animation7.MinTime = 0.0!
        Animation7.MosaicCoeff = CType(resources.GetObject("Animation7.MosaicCoeff"), System.Drawing.PointF)
        Animation7.MosaicShift = CType(resources.GetObject("Animation7.MosaicShift"), System.Drawing.PointF)
        Animation7.MosaicSize = 0
        Animation7.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation7.RotateCoeff = 0.0!
        Animation7.RotateLimit = 0.0!
        Animation7.ScaleCoeff = CType(resources.GetObject("Animation7.ScaleCoeff"), System.Drawing.PointF)
        Animation7.SlideCoeff = CType(resources.GetObject("Animation7.SlideCoeff"), System.Drawing.PointF)
        Animation7.TimeCoeff = 0.0!
        Animation7.TransparencyCoeff = 0.0!
        Me.labeltransition.DefaultAnimation = Animation7
        '
        'textboxtransition
        '
        Me.textboxtransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale
        Me.textboxtransition.Cursor = Nothing
        Animation10.AnimateOnlyDifferences = True
        Animation10.BlindCoeff = CType(resources.GetObject("Animation10.BlindCoeff"), System.Drawing.PointF)
        Animation10.LeafCoeff = 0.0!
        Animation10.MaxTime = 1.0!
        Animation10.MinTime = 0.0!
        Animation10.MosaicCoeff = CType(resources.GetObject("Animation10.MosaicCoeff"), System.Drawing.PointF)
        Animation10.MosaicShift = CType(resources.GetObject("Animation10.MosaicShift"), System.Drawing.PointF)
        Animation10.MosaicSize = 0
        Animation10.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation10.RotateCoeff = 0.0!
        Animation10.RotateLimit = 0.0!
        Animation10.ScaleCoeff = CType(resources.GetObject("Animation10.ScaleCoeff"), System.Drawing.PointF)
        Animation10.SlideCoeff = CType(resources.GetObject("Animation10.SlideCoeff"), System.Drawing.PointF)
        Animation10.TimeCoeff = 0.0!
        Animation10.TransparencyCoeff = 0.0!
        Me.textboxtransition.DefaultAnimation = Animation10
        '
        'buttontransition
        '
        Me.buttontransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.buttontransition.Cursor = Nothing
        Animation8.AnimateOnlyDifferences = True
        Animation8.BlindCoeff = CType(resources.GetObject("Animation8.BlindCoeff"), System.Drawing.PointF)
        Animation8.LeafCoeff = 0.0!
        Animation8.MaxTime = 1.0!
        Animation8.MinTime = 0.0!
        Animation8.MosaicCoeff = CType(resources.GetObject("Animation8.MosaicCoeff"), System.Drawing.PointF)
        Animation8.MosaicShift = CType(resources.GetObject("Animation8.MosaicShift"), System.Drawing.PointF)
        Animation8.MosaicSize = 0
        Animation8.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation8.RotateCoeff = 0.0!
        Animation8.RotateLimit = 0.0!
        Animation8.ScaleCoeff = CType(resources.GetObject("Animation8.ScaleCoeff"), System.Drawing.PointF)
        Animation8.SlideCoeff = CType(resources.GetObject("Animation8.SlideCoeff"), System.Drawing.PointF)
        Animation8.TimeCoeff = 0.0!
        Animation8.TransparencyCoeff = 1.0!
        Me.buttontransition.DefaultAnimation = Animation8
        '
        'chkShowHidePassword
        '
        Me.chkShowHidePassword.AutoSize = True
        Me.chkShowHidePassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkShowHidePassword.CheckedState.BorderRadius = 2
        Me.chkShowHidePassword.CheckedState.BorderThickness = 0
        Me.chkShowHidePassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textboxtransition.SetDecoration(Me.chkShowHidePassword, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Showpasswordtransition.SetDecoration(Me.chkShowHidePassword, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.buttontransition.SetDecoration(Me.chkShowHidePassword, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.labeltransition.SetDecoration(Me.chkShowHidePassword, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pictureboxTransition.SetDecoration(Me.chkShowHidePassword, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.chkShowHidePassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowHidePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkShowHidePassword.Location = New System.Drawing.Point(639, 431)
        Me.chkShowHidePassword.Name = "chkShowHidePassword"
        Me.chkShowHidePassword.Size = New System.Drawing.Size(140, 24)
        Me.chkShowHidePassword.TabIndex = 11
        Me.chkShowHidePassword.Text = "Show Password"
        Me.chkShowHidePassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkShowHidePassword.UncheckedState.BorderRadius = 2
        Me.chkShowHidePassword.UncheckedState.BorderThickness = 0
        Me.chkShowHidePassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkShowHidePassword.UseVisualStyleBackColor = True
        Me.chkShowHidePassword.Visible = False
        '
        'Showpasswordtransition
        '
        Me.Showpasswordtransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale
        Me.Showpasswordtransition.Cursor = Nothing
        Animation9.AnimateOnlyDifferences = True
        Animation9.BlindCoeff = CType(resources.GetObject("Animation9.BlindCoeff"), System.Drawing.PointF)
        Animation9.LeafCoeff = 0.0!
        Animation9.MaxTime = 1.0!
        Animation9.MinTime = 0.0!
        Animation9.MosaicCoeff = CType(resources.GetObject("Animation9.MosaicCoeff"), System.Drawing.PointF)
        Animation9.MosaicShift = CType(resources.GetObject("Animation9.MosaicShift"), System.Drawing.PointF)
        Animation9.MosaicSize = 0
        Animation9.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation9.RotateCoeff = 0.0!
        Animation9.RotateLimit = 0.0!
        Animation9.ScaleCoeff = CType(resources.GetObject("Animation9.ScaleCoeff"), System.Drawing.PointF)
        Animation9.SlideCoeff = CType(resources.GetObject("Animation9.SlideCoeff"), System.Drawing.PointF)
        Animation9.TimeCoeff = 0.0!
        Animation9.TransparencyCoeff = 0.0!
        Me.Showpasswordtransition.DefaultAnimation = Animation9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.pictureboxTransition.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.labeltransition.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.buttontransition.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Showpasswordtransition.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.textboxtransition.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(647, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(309, 51)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Welcome Back!"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.Visible = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1050, 703)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkShowHidePassword)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.textboxtransition.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Showpasswordtransition.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.labeltransition.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.buttontransition.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pictureboxTransition.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Guna2MouseStateHandler1 As Guna.UI2.WinForms.Guna2MouseStateHandler
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pictureboxTransition As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents labeltransition As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents textboxtransition As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents buttontransition As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents chkShowHidePassword As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Showpasswordtransition As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
