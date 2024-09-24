<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RequestApprovalControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.incharge = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.forApprovalTable = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.forApprovalTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PURCHASE REQUEST APPROVAL"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(518, 51)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.SimpleButton2)
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Controls.Add(Me.incharge)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(518, 61)
        Me.Panel2.TabIndex = 3
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(399, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(90, 35)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "Decline"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(293, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(90, 35)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "Approve"
        '
        'incharge
        '
        Me.incharge.AutoSize = True
        Me.incharge.Location = New System.Drawing.Point(75, 23)
        Me.incharge.Name = "incharge"
        Me.incharge.Size = New System.Drawing.Size(55, 13)
        Me.incharge.TabIndex = 1
        Me.incharge.Text = "In charge:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "In charge:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.forApprovalTable)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 112)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(518, 288)
        Me.Panel3.TabIndex = 4
        '
        'forApprovalTable
        '
        Me.forApprovalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.forApprovalTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.forApprovalTable.Location = New System.Drawing.Point(0, 0)
        Me.forApprovalTable.Name = "forApprovalTable"
        Me.forApprovalTable.Size = New System.Drawing.Size(518, 288)
        Me.forApprovalTable.TabIndex = 0
        '
        'RequestApprovalControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RequestApprovalControl"
        Me.Size = New System.Drawing.Size(518, 440)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.forApprovalTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents incharge As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents forApprovalTable As DataGridView
End Class
