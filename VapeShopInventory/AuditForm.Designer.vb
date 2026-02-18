<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuditForm
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
        Me.btnPerformNewAudit = New System.Windows.Forms.Button()
        Me.btnShowAuditHistory = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnShowProductsForAudit = New System.Windows.Forms.Button()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New System.Drawing.Point(82, 77)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowTemplate.Height = 24
        Me.dgvProducts.Size = New System.Drawing.Size(297, 170)
        Me.dgvProducts.TabIndex = 0
        '
        'btnPerformNewAudit
        '
        Me.btnPerformNewAudit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerformNewAudit.Location = New System.Drawing.Point(38, 280)
        Me.btnPerformNewAudit.Name = "btnPerformNewAudit"
        Me.btnPerformNewAudit.Size = New System.Drawing.Size(106, 50)
        Me.btnPerformNewAudit.TabIndex = 1
        Me.btnPerformNewAudit.Text = "Audit"
        Me.btnPerformNewAudit.UseVisualStyleBackColor = True
        '
        'btnShowAuditHistory
        '
        Me.btnShowAuditHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAuditHistory.Location = New System.Drawing.Point(311, 295)
        Me.btnShowAuditHistory.Name = "btnShowAuditHistory"
        Me.btnShowAuditHistory.Size = New System.Drawing.Size(106, 50)
        Me.btnShowAuditHistory.TabIndex = 2
        Me.btnShowAuditHistory.Text = "Reports"
        Me.btnShowAuditHistory.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(365, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 34)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnShowProductsForAudit
        '
        Me.btnShowProductsForAudit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowProductsForAudit.Location = New System.Drawing.Point(175, 280)
        Me.btnShowProductsForAudit.Name = "btnShowProductsForAudit"
        Me.btnShowProductsForAudit.Size = New System.Drawing.Size(106, 50)
        Me.btnShowProductsForAudit.TabIndex = 11
        Me.btnShowProductsForAudit.Text = "Products for Audit"
        Me.btnShowProductsForAudit.UseVisualStyleBackColor = True
        '
        'AuditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(479, 357)
        Me.Controls.Add(Me.btnShowProductsForAudit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnShowAuditHistory)
        Me.Controls.Add(Me.btnPerformNewAudit)
        Me.Controls.Add(Me.dgvProducts)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AuditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AuditForm"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents btnPerformNewAudit As System.Windows.Forms.Button
    Friend WithEvents btnShowAuditHistory As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnShowProductsForAudit As System.Windows.Forms.Button
End Class
