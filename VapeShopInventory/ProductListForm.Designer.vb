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
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReports = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNewAudit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdjustStock = New Guna.UI2.WinForms.Guna2Button()
        Me.btnProducts = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New System.Drawing.Point(253, 117)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowTemplate.Height = 24
        Me.dgvProducts.Size = New System.Drawing.Size(767, 423)
        Me.dgvProducts.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(432, 560)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 40)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(527, 560)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(89, 40)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(622, 560)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 40)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(717, 560)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(89, 40)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 12
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
        Me.txtSearch.Location = New System.Drawing.Point(253, 48)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search Products"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(533, 42)
        Me.txtSearch.TabIndex = 13
        '
        'ProductListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1032, 656)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvProducts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProductListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProductListForm"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReports As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNewAudit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdjustStock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnProducts As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
End Class
