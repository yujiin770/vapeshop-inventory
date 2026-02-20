<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdjustStockForm
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
        Me.cmbProduct = New System.Windows.Forms.ComboBox()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbAdd = New System.Windows.Forms.RadioButton()
        Me.rbReduce = New System.Windows.Forms.RadioButton()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnUserManagement = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReports = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNewAudit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdjustStock = New Guna.UI2.WinForms.Guna2Button()
        Me.btnProducts = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnstocks = New Guna.UI2.WinForms.Guna2Button()
        Me.lblStockStatus = New System.Windows.Forms.Label()
        Me.TimerColorReset = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbProduct
        '
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(596, 185)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(213, 24)
        Me.cmbProduct.TabIndex = 0
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(596, 259)
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(213, 22)
        Me.nudQuantity.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(456, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Product:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(456, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Quantity:"
        '
        'rbAdd
        '
        Me.rbAdd.AutoSize = True
        Me.rbAdd.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAdd.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rbAdd.Location = New System.Drawing.Point(532, 415)
        Me.rbAdd.Name = "rbAdd"
        Me.rbAdd.Size = New System.Drawing.Size(67, 24)
        Me.rbAdd.TabIndex = 4
        Me.rbAdd.TabStop = True
        Me.rbAdd.Text = "Add"
        Me.rbAdd.UseVisualStyleBackColor = True
        '
        'rbReduce
        '
        Me.rbReduce.AutoSize = True
        Me.rbReduce.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbReduce.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rbReduce.Location = New System.Drawing.Point(644, 415)
        Me.rbReduce.Name = "rbReduce"
        Me.rbReduce.Size = New System.Drawing.Size(99, 24)
        Me.rbReduce.TabIndex = 5
        Me.rbReduce.TabStop = True
        Me.rbReduce.Text = "Reduce"
        Me.rbReduce.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(596, 332)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(213, 39)
        Me.txtNotes.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(456, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 32)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Notes:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(493, 493)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(141, 44)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(876, 169)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(85, 34)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        Me.btnBack.Visible = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 12
        Me.Guna2Panel1.Controls.Add(Me.btnUserManagement)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.btnLogout)
        Me.Guna2Panel1.Controls.Add(Me.btnReports)
        Me.Guna2Panel1.Controls.Add(Me.btnNewAudit)
        Me.Guna2Panel1.Controls.Add(Me.btnAdjustStock)
        Me.Guna2Panel1.Controls.Add(Me.btnProducts)
        Me.Guna2Panel1.Controls.Add(Me.btnDashboard)
        Me.Guna2Panel1.Controls.Add(Me.lblWelcome)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(240, 656)
        Me.Guna2Panel1.TabIndex = 10
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
        Me.btnUserManagement.Location = New System.Drawing.Point(3, 498)
        Me.btnUserManagement.Name = "btnUserManagement"
        Me.btnUserManagement.ShadowDecoration.Parent = Me.btnUserManagement
        Me.btnUserManagement.Size = New System.Drawing.Size(231, 54)
        Me.btnUserManagement.TabIndex = 15
        Me.btnUserManagement.Tag = ""
        Me.btnUserManagement.Text = "User Management"
        Me.btnUserManagement.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(24, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 32)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "C  n C VapeShop"
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
        Me.btnLogout.Location = New System.Drawing.Point(8, 579)
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
        Me.btnReports.Location = New System.Drawing.Point(6, 435)
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
        Me.btnAdjustStock.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnAdjustStock.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdjustStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnAdjustStock.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnAdjustStock.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnAdjustStock.HoverState.Image = Global.VapeShopInventory.My.Resources.Resources.trend2
        Me.btnAdjustStock.HoverState.Parent = Me.btnAdjustStock
        Me.btnAdjustStock.Image = Global.VapeShopInventory.My.Resources.Resources.trend2
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
        Me.btnProducts.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnProducts.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProducts.ForeColor = System.Drawing.Color.White
        Me.btnProducts.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnProducts.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnProducts.HoverState.Image = Global.VapeShopInventory.My.Resources.Resources.product2
        Me.btnProducts.HoverState.Parent = Me.btnProducts
        Me.btnProducts.Image = Global.VapeShopInventory.My.Resources.Resources.product
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
        Me.btnDashboard.HoverState.Image = Global.VapeShopInventory.My.Resources.Resources.DashboardIcon2
        Me.btnDashboard.HoverState.Parent = Me.btnDashboard
        Me.btnDashboard.Image = Global.VapeShopInventory.My.Resources.Resources.DashboardIcon1
        Me.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnDashboard.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDashboard.Location = New System.Drawing.Point(4, 146)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.ShadowDecoration.Parent = Me.btnDashboard
        Me.btnDashboard.Size = New System.Drawing.Size(231, 54)
        Me.btnDashboard.TabIndex = 6
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextOffset = New System.Drawing.Point(5, 0)
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWelcome.Location = New System.Drawing.Point(35, 86)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(170, 35)
        Me.lblWelcome.TabIndex = 0
        '
        'btnstocks
        '
        Me.btnstocks.CheckedState.Parent = Me.btnstocks
        Me.btnstocks.CustomImages.Parent = Me.btnstocks
        Me.btnstocks.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnstocks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnstocks.ForeColor = System.Drawing.Color.White
        Me.btnstocks.HoverState.Parent = Me.btnstocks
        Me.btnstocks.Location = New System.Drawing.Point(699, 493)
        Me.btnstocks.Name = "btnstocks"
        Me.btnstocks.ShadowDecoration.Parent = Me.btnstocks
        Me.btnstocks.Size = New System.Drawing.Size(110, 44)
        Me.btnstocks.TabIndex = 11
        Me.btnstocks.Text = "Stocks"
        '
        'lblStockStatus
        '
        Me.lblStockStatus.AutoSize = True
        Me.lblStockStatus.Font = New System.Drawing.Font("Segoe UI", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblStockStatus.Location = New System.Drawing.Point(806, 116)
        Me.lblStockStatus.Name = "lblStockStatus"
        Me.lblStockStatus.Size = New System.Drawing.Size(0, 32)
        Me.lblStockStatus.TabIndex = 12
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(488, 18)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(198, 32)
        Me.lblTime.TabIndex = 13
        Me.lblTime.Text = "C  n C VapeShop"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(264, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 41)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Stocks"
        '
        'AdjustStockForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1032, 656)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblStockStatus)
        Me.Controls.Add(Me.btnstocks)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.rbReduce)
        Me.Controls.Add(Me.rbAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudQuantity)
        Me.Controls.Add(Me.cmbProduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdjustStockForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdjustStock"
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbAdd As System.Windows.Forms.RadioButton
    Friend WithEvents rbReduce As System.Windows.Forms.RadioButton
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnUserManagement As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReports As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNewAudit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdjustStock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnProducts As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnstocks As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblStockStatus As System.Windows.Forms.Label
    Friend WithEvents TimerColorReset As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
