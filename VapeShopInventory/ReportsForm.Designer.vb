<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsForm
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
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.btnOverstock = New System.Windows.Forms.Button()
        Me.btnUnderstock = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvReport
        '
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Location = New System.Drawing.Point(13, 69)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.RowTemplate.Height = 24
        Me.dgvReport.Size = New System.Drawing.Size(589, 204)
        Me.dgvReport.TabIndex = 0
        '
        'btnOverstock
        '
        Me.btnOverstock.Location = New System.Drawing.Point(132, 294)
        Me.btnOverstock.Name = "btnOverstock"
        Me.btnOverstock.Size = New System.Drawing.Size(99, 47)
        Me.btnOverstock.TabIndex = 1
        Me.btnOverstock.Text = "Overstock"
        Me.btnOverstock.UseVisualStyleBackColor = True
        '
        'btnUnderstock
        '
        Me.btnUnderstock.Location = New System.Drawing.Point(319, 294)
        Me.btnUnderstock.Name = "btnUnderstock"
        Me.btnUnderstock.Size = New System.Drawing.Size(99, 47)
        Me.btnUnderstock.TabIndex = 2
        Me.btnUnderstock.Text = "Understock"
        Me.btnUnderstock.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(527, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(614, 365)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnUnderstock)
        Me.Controls.Add(Me.btnOverstock)
        Me.Controls.Add(Me.dgvReport)
        Me.Name = "ReportsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportsForm"
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvReport As System.Windows.Forms.DataGridView
    Friend WithEvents btnOverstock As System.Windows.Forms.Button
    Friend WithEvents btnUnderstock As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
