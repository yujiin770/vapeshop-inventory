<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLowStockAlert = New System.Windows.Forms.Label()
        Me.lblTotalProducts = New System.Windows.Forms.Label()
        Me.lblTotalStock = New System.Windows.Forms.Label()
        Me.lblOverstockCount = New System.Windows.Forms.Label()
        Me.dgvRecentActivity = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.dgvInventoryStatus = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnUserManagement = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReports = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNewAudit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdjustStock = New Guna.UI2.WinForms.Guna2Button()
        Me.btnProducts = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.dgvRecentActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInventoryStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Guna2Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(240, 656)
        Me.Guna2Panel1.TabIndex = 7
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
        'lblLowStockAlert
        '
        Me.lblLowStockAlert.AutoSize = True
        Me.lblLowStockAlert.Font = New System.Drawing.Font("Segoe UI", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowStockAlert.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblLowStockAlert.Location = New System.Drawing.Point(685, 567)
        Me.lblLowStockAlert.Name = "lblLowStockAlert"
        Me.lblLowStockAlert.Size = New System.Drawing.Size(179, 32)
        Me.lblLowStockAlert.TabIndex = 9
        Me.lblLowStockAlert.Text = "Loading Alerts"
        Me.lblLowStockAlert.Visible = False
        '
        'lblTotalProducts
        '
        Me.lblTotalProducts.AutoSize = True
        Me.lblTotalProducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.lblTotalProducts.Font = New System.Drawing.Font("Segoe UI", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalProducts.ForeColor = System.Drawing.Color.White
        Me.lblTotalProducts.Location = New System.Drawing.Point(82, 34)
        Me.lblTotalProducts.Name = "lblTotalProducts"
        Me.lblTotalProducts.Size = New System.Drawing.Size(179, 32)
        Me.lblTotalProducts.TabIndex = 10
        Me.lblTotalProducts.Text = "Loading Alerts"
        Me.lblTotalProducts.Visible = False
        '
        'lblTotalStock
        '
        Me.lblTotalStock.AutoSize = True
        Me.lblTotalStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.lblTotalStock.Font = New System.Drawing.Font("Segoe UI", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStock.ForeColor = System.Drawing.Color.White
        Me.lblTotalStock.Location = New System.Drawing.Point(96, 31)
        Me.lblTotalStock.Name = "lblTotalStock"
        Me.lblTotalStock.Size = New System.Drawing.Size(179, 32)
        Me.lblTotalStock.TabIndex = 11
        Me.lblTotalStock.Text = "Loading Alerts"
        Me.lblTotalStock.Visible = False
        '
        'lblOverstockCount
        '
        Me.lblOverstockCount.AutoSize = True
        Me.lblOverstockCount.Font = New System.Drawing.Font("Segoe UI", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverstockCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblOverstockCount.Location = New System.Drawing.Point(373, 567)
        Me.lblOverstockCount.Name = "lblOverstockCount"
        Me.lblOverstockCount.Size = New System.Drawing.Size(179, 32)
        Me.lblOverstockCount.TabIndex = 12
        Me.lblOverstockCount.Text = "Loading Alerts"
        Me.lblOverstockCount.Visible = False
        '
        'dgvRecentActivity
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.dgvRecentActivity.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvRecentActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecentActivity.BackgroundColor = System.Drawing.Color.White
        Me.dgvRecentActivity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRecentActivity.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRecentActivity.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecentActivity.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvRecentActivity.ColumnHeadersHeight = 4
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRecentActivity.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvRecentActivity.EnableHeadersVisualStyles = False
        Me.dgvRecentActivity.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRecentActivity.Location = New System.Drawing.Point(273, 250)
        Me.dgvRecentActivity.Name = "dgvRecentActivity"
        Me.dgvRecentActivity.RowHeadersVisible = False
        Me.dgvRecentActivity.RowTemplate.Height = 24
        Me.dgvRecentActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecentActivity.Size = New System.Drawing.Size(703, 173)
        Me.dgvRecentActivity.TabIndex = 13
        Me.dgvRecentActivity.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvRecentActivity.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRecentActivity.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvRecentActivity.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvRecentActivity.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvRecentActivity.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvRecentActivity.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvRecentActivity.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRecentActivity.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRecentActivity.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvRecentActivity.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvRecentActivity.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRecentActivity.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvRecentActivity.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvRecentActivity.ThemeStyle.ReadOnly = False
        Me.dgvRecentActivity.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRecentActivity.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRecentActivity.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvRecentActivity.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvRecentActivity.ThemeStyle.RowsStyle.Height = 24
        Me.dgvRecentActivity.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRecentActivity.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'dgvInventoryStatus
        '
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        Me.dgvInventoryStatus.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvInventoryStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInventoryStatus.BackgroundColor = System.Drawing.Color.White
        Me.dgvInventoryStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvInventoryStatus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvInventoryStatus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventoryStatus.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvInventoryStatus.ColumnHeadersHeight = 4
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInventoryStatus.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvInventoryStatus.EnableHeadersVisualStyles = False
        Me.dgvInventoryStatus.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvInventoryStatus.Location = New System.Drawing.Point(273, 461)
        Me.dgvInventoryStatus.Name = "dgvInventoryStatus"
        Me.dgvInventoryStatus.RowHeadersVisible = False
        Me.dgvInventoryStatus.RowTemplate.Height = 24
        Me.dgvInventoryStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventoryStatus.Size = New System.Drawing.Size(703, 173)
        Me.dgvInventoryStatus.TabIndex = 14
        Me.dgvInventoryStatus.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvInventoryStatus.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvInventoryStatus.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvInventoryStatus.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvInventoryStatus.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvInventoryStatus.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvInventoryStatus.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvInventoryStatus.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvInventoryStatus.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvInventoryStatus.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvInventoryStatus.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvInventoryStatus.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvInventoryStatus.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvInventoryStatus.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvInventoryStatus.ThemeStyle.ReadOnly = False
        Me.dgvInventoryStatus.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvInventoryStatus.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvInventoryStatus.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvInventoryStatus.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvInventoryStatus.ThemeStyle.RowsStyle.Height = 24
        Me.dgvInventoryStatus.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvInventoryStatus.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(267, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 32)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Recent Activity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(267, 426)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 32)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Lowstock and Overstock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(266, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 41)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "DASHBOARD"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderRadius = 14
        Me.Guna2Panel2.Controls.Add(Me.lblTotalProducts)
        Me.Guna2Panel2.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(273, 109)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(334, 92)
        Me.Guna2Panel2.TabIndex = 20
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderRadius = 12
        Me.Guna2Panel3.Controls.Add(Me.lblTotalStock)
        Me.Guna2Panel3.Controls.Add(Me.PictureBox2)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(664, 109)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(312, 92)
        Me.Guna2Panel3.TabIndex = 21
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lbltime.Location = New System.Drawing.Point(593, 30)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(137, 28)
        Me.lbltime.TabIndex = 22
        Me.lbltime.Text = "DASHBOARD"
        '
        'Timer1
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.PictureBox2.Image = Global.VapeShopInventory.My.Resources.Resources.trend
        Me.PictureBox2.Location = New System.Drawing.Point(37, 29)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.PictureBox1.Image = Global.VapeShopInventory.My.Resources.Resources.product
        Me.PictureBox1.Location = New System.Drawing.Point(13, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
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
        Me.btnDashboard.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnDashboard.HoverState.Parent = Me.btnDashboard
        Me.btnDashboard.Image = Global.VapeShopInventory.My.Resources.Resources.DashboardIcon2
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
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1032, 656)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvInventoryStatus)
        Me.Controls.Add(Me.dgvRecentActivity)
        Me.Controls.Add(Me.lblOverstockCount)
        Me.Controls.Add(Me.lblLowStockAlert)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DashboardForm"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.dgvRecentActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInventoryStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnProducts As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdjustStock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNewAudit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReports As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblLowStockAlert As System.Windows.Forms.Label
    Friend WithEvents lblTotalProducts As System.Windows.Forms.Label
    Friend WithEvents lblTotalStock As System.Windows.Forms.Label
    Friend WithEvents lblOverstockCount As System.Windows.Forms.Label
    Friend WithEvents dgvRecentActivity As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnUserManagement As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvInventoryStatus As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
