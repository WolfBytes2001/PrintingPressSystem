<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class purchase_order
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(purchase_order))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.POrequestedBy = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PRID = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.POID = New System.Windows.Forms.Label()
        Me.itemDescripBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.POitemPrice = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.POtotalPrice = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.POpurposeBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.POquantityBox = New System.Windows.Forms.TextBox()
        Me.POProductType = New System.Windows.Forms.TextBox()
        Me.POfundBox = New System.Windows.Forms.TextBox()
        Me.poUnitOfMeas = New System.Windows.Forms.TextBox()
        Me.poItemDes = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.quantity = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(164, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PURCHASE ORDER"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.POrequestedBy)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PRID)
        Me.Panel1.Controls.Add(Me.label12)
        Me.Panel1.Controls.Add(Me.POID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(518, 101)
        Me.Panel1.TabIndex = 3
        '
        'POrequestedBy
        '
        Me.POrequestedBy.AutoSize = True
        Me.POrequestedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POrequestedBy.ForeColor = System.Drawing.Color.Blue
        Me.POrequestedBy.Location = New System.Drawing.Point(125, 70)
        Me.POrequestedBy.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.POrequestedBy.Name = "POrequestedBy"
        Me.POrequestedBy.Size = New System.Drawing.Size(108, 16)
        Me.POrequestedBy.TabIndex = 7
        Me.POrequestedBy.Text = "Requested by:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(13, 70)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Requested by:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(321, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PR ID:"
        '
        'PRID
        '
        Me.PRID.AutoSize = True
        Me.PRID.BackColor = System.Drawing.Color.Transparent
        Me.PRID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRID.ForeColor = System.Drawing.Color.Blue
        Me.PRID.Location = New System.Drawing.Point(376, 41)
        Me.PRID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PRID.Name = "PRID"
        Me.PRID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PRID.Size = New System.Drawing.Size(41, 20)
        Me.PRID.TabIndex = 4
        Me.PRID.Text = "RQ-"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label12.Location = New System.Drawing.Point(12, 44)
        Me.label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(138, 16)
        Me.label12.TabIndex = 3
        Me.label12.Text = "Purchase Order ID:"
        '
        'POID
        '
        Me.POID.AutoSize = True
        Me.POID.BackColor = System.Drawing.Color.Transparent
        Me.POID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POID.ForeColor = System.Drawing.Color.Blue
        Me.POID.Location = New System.Drawing.Point(154, 40)
        Me.POID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.POID.Name = "POID"
        Me.POID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.POID.Size = New System.Drawing.Size(41, 20)
        Me.POID.TabIndex = 2
        Me.POID.Text = "RQ-"
        '
        'itemDescripBox
        '
        Me.itemDescripBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.itemDescripBox.Location = New System.Drawing.Point(12, 164)
        Me.itemDescripBox.Multiline = True
        Me.itemDescripBox.Name = "itemDescripBox"
        Me.itemDescripBox.Size = New System.Drawing.Size(144, 68)
        Me.itemDescripBox.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 143)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 18)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Item Description"
        '
        'POitemPrice
        '
        Me.POitemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.POitemPrice.Location = New System.Drawing.Point(3, 116)
        Me.POitemPrice.Name = "POitemPrice"
        Me.POitemPrice.ReadOnly = True
        Me.POitemPrice.Size = New System.Drawing.Size(145, 24)
        Me.POitemPrice.TabIndex = 35
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(2, 94)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 18)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Item Price"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.POtotalPrice)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.POpurposeBox)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.POquantityBox)
        Me.Panel2.Controls.Add(Me.POProductType)
        Me.Panel2.Controls.Add(Me.POfundBox)
        Me.Panel2.Controls.Add(Me.POitemPrice)
        Me.Panel2.Controls.Add(Me.poUnitOfMeas)
        Me.Panel2.Controls.Add(Me.poItemDes)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.quantity)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(0, 101)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(518, 155)
        Me.Panel2.TabIndex = 35
        '
        'POtotalPrice
        '
        Me.POtotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.POtotalPrice.Location = New System.Drawing.Point(354, 69)
        Me.POtotalPrice.Multiline = True
        Me.POtotalPrice.Name = "POtotalPrice"
        Me.POtotalPrice.ReadOnly = True
        Me.POtotalPrice.Size = New System.Drawing.Size(161, 62)
        Me.POtotalPrice.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(155, 96)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 18)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Source of Fund"
        '
        'POpurposeBox
        '
        Me.POpurposeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.POpurposeBox.Location = New System.Drawing.Point(354, 19)
        Me.POpurposeBox.Name = "POpurposeBox"
        Me.POpurposeBox.ReadOnly = True
        Me.POpurposeBox.Size = New System.Drawing.Size(161, 24)
        Me.POpurposeBox.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(355, 2)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 18)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Purpose"
        '
        'POquantityBox
        '
        Me.POquantityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.POquantityBox.Location = New System.Drawing.Point(259, 19)
        Me.POquantityBox.Name = "POquantityBox"
        Me.POquantityBox.ReadOnly = True
        Me.POquantityBox.Size = New System.Drawing.Size(82, 24)
        Me.POquantityBox.TabIndex = 38
        '
        'POProductType
        '
        Me.POProductType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.POProductType.Location = New System.Drawing.Point(155, 67)
        Me.POProductType.Name = "POProductType"
        Me.POProductType.ReadOnly = True
        Me.POProductType.Size = New System.Drawing.Size(183, 24)
        Me.POProductType.TabIndex = 37
        '
        'POfundBox
        '
        Me.POfundBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.POfundBox.Location = New System.Drawing.Point(154, 116)
        Me.POfundBox.Name = "POfundBox"
        Me.POfundBox.ReadOnly = True
        Me.POfundBox.Size = New System.Drawing.Size(184, 24)
        Me.POfundBox.TabIndex = 36
        '
        'poUnitOfMeas
        '
        Me.poUnitOfMeas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.poUnitOfMeas.Location = New System.Drawing.Point(154, 19)
        Me.poUnitOfMeas.Name = "poUnitOfMeas"
        Me.poUnitOfMeas.ReadOnly = True
        Me.poUnitOfMeas.Size = New System.Drawing.Size(92, 24)
        Me.poUnitOfMeas.TabIndex = 33
        '
        'poItemDes
        '
        Me.poItemDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.poItemDes.Location = New System.Drawing.Point(5, 23)
        Me.poItemDes.Multiline = True
        Me.poItemDes.Name = "poItemDes"
        Me.poItemDes.ReadOnly = True
        Me.poItemDes.Size = New System.Drawing.Size(144, 68)
        Me.poItemDes.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(152, 46)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 18)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Product Type"
        '
        'quantity
        '
        Me.quantity.AutoSize = True
        Me.quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity.ForeColor = System.Drawing.Color.Red
        Me.quantity.Location = New System.Drawing.Point(354, 46)
        Me.quantity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(94, 20)
        Me.quantity.TabIndex = 3
        Me.quantity.Text = "Total Price"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(2, 2)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 18)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Item Description"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(137, 2)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 18)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Unit of Measure"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(268, 2)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 18)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Quantity"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(184, 261)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(154, 53)
        Me.SimpleButton1.TabIndex = 36
        Me.SimpleButton1.Text = "Issue Purchase Order"
        '
        'purchase_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.itemDescripBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "purchase_order"
        Me.Size = New System.Drawing.Size(518, 352)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents label12 As Label
    Friend WithEvents POID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PRID As Label
    Friend WithEvents POrequestedBy As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents itemDescripBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents POitemPrice As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents POtotalPrice As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents POpurposeBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents POquantityBox As TextBox
    Friend WithEvents POProductType As TextBox
    Friend WithEvents POfundBox As TextBox
    Friend WithEvents poUnitOfMeas As TextBox
    Friend WithEvents poItemDes As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents quantity As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
