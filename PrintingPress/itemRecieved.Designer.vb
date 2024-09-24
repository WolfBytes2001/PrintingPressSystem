<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class itemRecieved
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.recPOID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.personnelDe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.vehicleType = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.InspectedBy = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.condition = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.recieveOn = New System.Windows.Forms.DateTimePicker()
        Me.recieveButton = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(545, 75)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ORDER RECIEVED"
        '
        'recPOID
        '
        Me.recPOID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.recPOID.Location = New System.Drawing.Point(46, 159)
        Me.recPOID.Name = "recPOID"
        Me.recPOID.Size = New System.Drawing.Size(183, 20)
        Me.recPOID.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(43, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "PO ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(188, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 18)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Delivery Details"
        '
        'personnelDe
        '
        Me.personnelDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.personnelDe.Location = New System.Drawing.Point(46, 203)
        Me.personnelDe.Name = "personnelDe"
        Me.personnelDe.Size = New System.Drawing.Size(183, 20)
        Me.personnelDe.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(43, 182)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 18)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Delivery Personnel"
        '
        'vehicleType
        '
        Me.vehicleType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vehicleType.Location = New System.Drawing.Point(288, 159)
        Me.vehicleType.Name = "vehicleType"
        Me.vehicleType.Size = New System.Drawing.Size(183, 20)
        Me.vehicleType.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(285, 138)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 18)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Vehicle Type"
        '
        'InspectedBy
        '
        Me.InspectedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InspectedBy.Location = New System.Drawing.Point(288, 203)
        Me.InspectedBy.Name = "InspectedBy"
        Me.InspectedBy.Size = New System.Drawing.Size(183, 20)
        Me.InspectedBy.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(285, 182)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 18)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Inspected By"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(43, 231)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Condition"
        '
        'condition
        '
        Me.condition.FormattingEnabled = True
        Me.condition.Items.AddRange(New Object() {"Good"})
        Me.condition.Location = New System.Drawing.Point(46, 252)
        Me.condition.Name = "condition"
        Me.condition.Size = New System.Drawing.Size(181, 21)
        Me.condition.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(284, 231)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 18)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Recieved on"
        '
        'recieveOn
        '
        Me.recieveOn.Location = New System.Drawing.Point(289, 253)
        Me.recieveOn.Name = "recieveOn"
        Me.recieveOn.Size = New System.Drawing.Size(181, 20)
        Me.recieveOn.TabIndex = 56
        '
        'recieveButton
        '
        Me.recieveButton.Location = New System.Drawing.Point(200, 307)
        Me.recieveButton.Name = "recieveButton"
        Me.recieveButton.Size = New System.Drawing.Size(122, 32)
        Me.recieveButton.TabIndex = 57
        Me.recieveButton.Text = "Recieve"
        '
        'itemRecieved
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.recieveButton)
        Me.Controls.Add(Me.recieveOn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.condition)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.InspectedBy)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.vehicleType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.personnelDe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.recPOID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "itemRecieved"
        Me.Size = New System.Drawing.Size(545, 436)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents recPOID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents personnelDe As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents vehicleType As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents InspectedBy As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents condition As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents recieveOn As DateTimePicker
    Friend WithEvents recieveButton As DevExpress.XtraEditors.SimpleButton
End Class
