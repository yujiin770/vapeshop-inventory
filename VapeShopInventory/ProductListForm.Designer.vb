<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductListForm
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
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnUserManagement = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReports = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNewAudit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdjustStock = New Guna.UI2.WinForms.Guna2Button()
        Me.btnProducts = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerColorReset = New System.Windows.Forms.Timer(Me.components)
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.EditBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.DeleteBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.RefreshBtn = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New System.Drawing.Point(253, 135)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowTemplate.Height = 24
        Me.dgvProducts.Size = New System.Drawing.Size(767, 423)
        Me.dgvProducts.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 12
        Me.Guna2Panel1.Controls.Add(Me.btnUserManagement)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.btnLogout)
        Me.Guna2Panel1.Controls.Add(Me.btnReports)
        Me.Guna2Panel1.Controls.Add(Me.btnNewAudit)
        Me.Guna2Panel1.Controls.Add(Me.btnAdjustStock)
        Me.Guna2Panel1.Controls.Add(Me.btnProducts)
        Me.Guna2Panel1.Controls.Add(Me.btnDashboard)
        Me.Guna2Panel1.Controls.Add(Me.lblWelcome)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(2, -2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(240, 656)
        Me.Guna2Panel1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(24, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 32)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "C  n C VapeShop"
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWelcome.Location = New System.Drawing.Point(4, 86)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(230, 35)
        Me.lblWelcome.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.Location = New System.Drawing.Point(253, 77)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search Products"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(755, 42)
        Me.txtSearch.TabIndex = 13
        '
        'btnUserManagement
        '
        Me.btnUserManagement.Animated = True
        Me.btnUserManagement.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnUserManagement.BorderRadius = 6
        Me.btnUserManagement.BorderThickness = 2
        Me.btnUserManagement.CheckedState.Parent = Me.btnUserManagement
        Me.btnUserManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserManagement.CustomImages.Parent = Me.btnUserManagement
        Me.btnUserManagement.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnUserManagement.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserManagement.ForeColor = System.Drawing.Color.White
        Me.btnUserManagement.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnUserManagement.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnUserManagement.HoverState.Image = Global.VapeShopInventory.My.Resources.Resources.user2
        Me.btnUserManagement.HoverState.Parent = Me.btnUserManagement
        Me.btnUserManagement.Image = Global.VapeShopInventory.My.Resources.Resources.user1
        Me.btnUserManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUserManagement.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnUserManagement.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnUserManagement.Location = New System.Drawing.Point(6, 506)
        Me.btnUserManagement.Name = "btnUserManagement"
        Me.btnUserManagement.ShadowDecoration.Parent = Me.btnUserManagement
        Me.btnUserManagement.Size = New System.Drawing.Size(231, 54)
        Me.btnUserManagement.TabIndex = 14
        Me.btnUserManagement.Tag = ""
        Me.btnUserManagement.Text = "User Management"
        Me.btnUserManagement.TextOffset = New System.Drawing.Point(8, 0)
        '
        'btnLogout
        '
        Me.btnLogout.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnLogout.BorderThickness = 2
        Me.btnLogout.CheckedState.Parent = Me.btnLogout
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.CustomImages.Parent = Me.btnLogout
        Me.btnLogout.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnLogout.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnLogout.HoverState.Parent = Me.btnLogout
        Me.btnLogout.Image = Global.VapeShopInventory.My.Resources.Resources.logout
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnLogout.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnLogout.Location = New System.Drawing.Point(9, 592)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.ShadowDecoration.Parent = Me.btnLogout
        Me.btnLogout.Size = New System.Drawing.Size(227, 54)
        Me.btnLogout.TabIndex = 13
        Me.btnLogout.Text = "Logout"
        '
        'btnReports
        '
        Me.btnReports.Animated = True
        Me.btnReports.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnReports.BorderRadius = 6
        Me.btnReports.BorderThickness = 2
        Me.btnReports.CheckedState.Parent = Me.btnReports
        Me.btnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReports.CustomImages.Parent = Me.btnReports
        Me.btnReports.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnReports.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnReports.HoverState.Image = Global.VapeShopInventory.My.Resources.Resources.reoirts2
        Me.btnReports.HoverState.Parent = Me.btnReports
        Me.btnReports.Image = Global.VapeShopInventory.My.Resources.Resources.report
        Me.btnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReports.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnReports.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnReports.Location = New System.Drawing.Point(6, 437)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.ShadowDecoration.Parent = Me.btnReports
        Me.btnReports.Size = New System.Drawing.Size(231, 54)
        Me.btnReports.TabIndex = 12
        Me.btnReports.Text = "Reports"
        '
        'btnNewAudit
        '
        Me.btnNewAudit.Animated = True
        Me.btnNewAudit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnNewAudit.BorderRadius = 6
        Me.btnNewAudit.BorderThickness = 2
        Me.btnNewAudit.CheckedState.Parent = Me.btnNewAudit
        Me.btnNewAudit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewAudit.CustomImages.Parent = Me.btnNewAudit
        Me.btnNewAudit.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnNewAudit.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewAudit.ForeColor = System.Drawing.Color.White
        Me.btnNewAudit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnNewAudit.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnNewAudit.HoverState.Parent = Me.btnNewAudit
        Me.btnNewAudit.Image = Global.VapeShopInventory.My.Resources.Resources.add_product
        Me.btnNewAudit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnNewAudit.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnNewAudit.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnNewAudit.Location = New System.Drawing.Point(6, 363)
        Me.btnNewAudit.Name = "btnNewAudit"
        Me.btnNewAudit.ShadowDecoration.Parent = Me.btnNewAudit
        Me.btnNewAudit.Size = New System.Drawing.Size(231, 54)
        Me.btnNewAudit.TabIndex = 11
        Me.btnNewAudit.Text = "New Audit"
        '
        'btnAdjustStock
        '
        Me.btnAdjustStock.Animated = True
        Me.btnAdjustStock.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnAdjustStock.BorderRadius = 6
        Me.btnAdjustStock.BorderThickness = 2
        Me.btnAdjustStock.CheckedState.Parent = Me.btnAdjustStock
        Me.btnAdjustStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdjustStock.CustomImages.Parent = Me.btnAdjustStock
        Me.btnAdjustStock.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnAdjustStock.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdjustStock.ForeColor = System.Drawing.Color.White
        Me.btnAdjustStock.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnAdjustStock.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnAdjustStock.HoverState.Image = Global.VapeShopInventory.My.Resources.Resources.trend2
        Me.btnAdjustStock.HoverState.Parent = Me.btnAdjustStock
        Me.btnAdjustStock.Image = Global.VapeShopInventory.My.Resources.Resources.trend
        Me.btnAdjustStock.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdjustStock.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnAdjustStock.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnAdjustStock.Location = New System.Drawing.Point(3, 293)
        Me.btnAdjustStock.Name = "btnAdjustStock"
        Me.btnAdjustStock.ShadowDecoration.Parent = Me.btnAdjustStock
        Me.btnAdjustStock.Size = New System.Drawing.Size(231, 54)
        Me.btnAdjustStock.TabIndex = 10
        Me.btnAdjustStock.Text = "Stocks"
        Me.btnAdjustStock.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btnProducts
        '
        Me.btnProducts.Animated = True
        Me.btnProducts.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnProducts.BorderRadius = 6
        Me.btnProducts.BorderThickness = 2
        Me.btnProducts.CheckedState.Parent = Me.btnProducts
        Me.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProducts.CustomImages.Parent = Me.btnProducts
        Me.btnProducts.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnProducts.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProducts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnProducts.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnProducts.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnProducts.HoverState.Image = Global.VapeShopInventory.My.Resources.Resources.product2
        Me.btnProducts.HoverState.Parent = Me.btnProducts
        Me.btnProducts.Image = Global.VapeShopInventory.My.Resources.Resources.product21
        Me.btnProducts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnProducts.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnProducts.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnProducts.Location = New System.Drawing.Point(3, 222)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.ShadowDecoration.Parent = Me.btnProducts
        Me.btnProducts.Size = New System.Drawing.Size(231, 54)
        Me.btnProducts.TabIndex = 8
        Me.btnProducts.Text = "Products"
        Me.btnProducts.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btnDashboard
        '
        Me.btnDashboard.Animated = True
        Me.btnDashboard.BorderRadius = 6
        Me.btnDashboard.CheckedState.Parent = Me.btnDashboard
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.CustomImages.Parent = Me.btnDashboard
        Me.btnDashboard.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnDashboard.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnDashboard.HoverState.Image = Global.VapeShopInventory.My.Resources.Resources.category
        Me.btnDashboard.HoverState.Parent = Me.btnDashboard
        Me.btnDashboard.Image = Global.VapeShopInventory.My.Resources.Resources.DashboardIcon1
        Me.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnDashboard.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDashboard.Location = New System.Drawing.Point(4, 147)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.ShadowDecoration.Parent = Me.btnDashboard
        Me.btnDashboard.Size = New System.Drawing.Size(231, 54)
        Me.btnDashboard.TabIndex = 6
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextOffset = New System.Drawing.Point(5, 0)
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lbltime.Location = New System.Drawing.Point(713, 27)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(137, 28)
        Me.lbltime.TabIndex = 23
        Me.lbltime.Text = "DASHBOARD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(257, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 41)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "PRODUCTS"
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
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogin.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnLogin.HoverState.Parent = Me.btnLogin
        Me.btnLogin.Location = New System.Drawing.Point(377, 578)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.ShadowDecoration.Parent = Me.btnLogin
        Me.btnLogin.Size = New System.Drawing.Size(105, 52)
        Me.btnLogin.TabIndex = 25
        Me.btnLogin.Text = "ADD"
        '
        'EditBtn
        '
        Me.EditBtn.Animated = True
        Me.EditBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EditBtn.BorderRadius = 12
        Me.EditBtn.BorderThickness = 2
        Me.EditBtn.CheckedState.Parent = Me.EditBtn
        Me.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditBtn.CustomImages.Parent = Me.EditBtn
        Me.EditBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.EditBtn.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EditBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EditBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.EditBtn.HoverState.Parent = Me.EditBtn
        Me.EditBtn.Location = New System.Drawing.Point(504, 578)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.ShadowDecoration.Parent = Me.EditBtn
        Me.EditBtn.Size = New System.Drawing.Size(105, 52)
        Me.EditBtn.TabIndex = 26
        Me.EditBtn.Text = "EDIT"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Animated = True
        Me.DeleteBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.DeleteBtn.BorderRadius = 12
        Me.DeleteBtn.BorderThickness = 2
        Me.DeleteBtn.CheckedState.Parent = Me.DeleteBtn
        Me.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteBtn.CustomImages.Parent = Me.DeleteBtn
        Me.DeleteBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.DeleteBtn.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.DeleteBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeleteBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.HoverState.Parent = Me.DeleteBtn
        Me.DeleteBtn.Location = New System.Drawing.Point(637, 578)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.ShadowDecoration.Parent = Me.DeleteBtn
        Me.DeleteBtn.Size = New System.Drawing.Size(105, 52)
        Me.DeleteBtn.TabIndex = 27
        Me.DeleteBtn.Text = "DELETE"
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Animated = True
        Me.RefreshBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RefreshBtn.BorderRadius = 12
        Me.RefreshBtn.BorderThickness = 2
        Me.RefreshBtn.CheckedState.Parent = Me.RefreshBtn
        Me.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RefreshBtn.CustomImages.Parent = Me.RefreshBtn
        Me.RefreshBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.RefreshBtn.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RefreshBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RefreshBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.RefreshBtn.HoverState.Parent = Me.RefreshBtn
        Me.RefreshBtn.Location = New System.Drawing.Point(765, 578)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.ShadowDecoration.Parent = Me.RefreshBtn
        Me.RefreshBtn.Size = New System.Drawing.Size(105, 52)
        Me.RefreshBtn.TabIndex = 28
        Me.RefreshBtn.Text = "REFRESH"
        '
        'ProductListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1032, 656)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.dgvProducts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProductListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProductListForm"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnReports As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNewAudit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdjustStock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnProducts As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnUserManagement As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TimerColorReset As System.Windows.Forms.Timer
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Private WithEvents EditBtn As Guna.UI2.WinForms.Guna2Button
    Private WithEvents DeleteBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Private WithEvents RefreshBtn As Guna.UI2.WinForms.Guna2Button
End Class
