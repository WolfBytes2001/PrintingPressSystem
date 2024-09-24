<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vendor_selection
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.prVendorID = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.vendorPOID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.vendorsTable = New System.Windows.Forms.DataGridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.addVendorButton = New DevExpress.XtraEditors.SimpleButton()
        Me.addLoc = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.addSuppID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.addContact = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.addType = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.addSuppName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.suppName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ProdBrand = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.shippingMeth = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OrderCourier = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.deliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.placeOrderButton = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.vendorsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.prVendorID)
        Me.Panel1.Controls.Add(Me.label12)
        Me.Panel1.Controls.Add(Me.vendorPOID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(518, 86)
        Me.Panel1.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(286, 53)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Request ID:"
        '
        'prVendorID
        '
        Me.prVendorID.AutoSize = True
        Me.prVendorID.BackColor = System.Drawing.Color.Transparent
        Me.prVendorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prVendorID.ForeColor = System.Drawing.Color.Blue
        Me.prVendorID.Location = New System.Drawing.Point(378, 50)
        Me.prVendorID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.prVendorID.Name = "prVendorID"
        Me.prVendorID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.prVendorID.Size = New System.Drawing.Size(41, 20)
        Me.prVendorID.TabIndex = 6
        Me.prVendorID.Text = "RQ-"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label12.Location = New System.Drawing.Point(12, 52)
        Me.label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(138, 16)
        Me.label12.TabIndex = 5
        Me.label12.Text = "Purchase Order ID:"
        '
        'vendorPOID
        '
        Me.vendorPOID.AutoSize = True
        Me.vendorPOID.BackColor = System.Drawing.Color.Transparent
        Me.vendorPOID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vendorPOID.ForeColor = System.Drawing.Color.Blue
        Me.vendorPOID.Location = New System.Drawing.Point(154, 49)
        Me.vendorPOID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.vendorPOID.Name = "vendorPOID"
        Me.vendorPOID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.vendorPOID.Size = New System.Drawing.Size(41, 20)
        Me.vendorPOID.TabIndex = 4
        Me.vendorPOID.Text = "RQ-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ORDER PLACEMENT"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 264)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(515, 175)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.vendorsTable)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(509, 147)
        Me.XtraTabPage1.Text = "Vendors"
        '
        'vendorsTable
        '
        Me.vendorsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.vendorsTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vendorsTable.Location = New System.Drawing.Point(0, 0)
        Me.vendorsTable.Name = "vendorsTable"
        Me.vendorsTable.Size = New System.Drawing.Size(509, 147)
        Me.vendorsTable.TabIndex = 0
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.addVendorButton)
        Me.XtraTabPage2.Controls.Add(Me.addLoc)
        Me.XtraTabPage2.Controls.Add(Me.Label13)
        Me.XtraTabPage2.Controls.Add(Me.addSuppID)
        Me.XtraTabPage2.Controls.Add(Me.Label11)
        Me.XtraTabPage2.Controls.Add(Me.addContact)
        Me.XtraTabPage2.Controls.Add(Me.Label10)
        Me.XtraTabPage2.Controls.Add(Me.addType)
        Me.XtraTabPage2.Controls.Add(Me.Label9)
        Me.XtraTabPage2.Controls.Add(Me.addSuppName)
        Me.XtraTabPage2.Controls.Add(Me.Label7)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(509, 147)
        Me.XtraTabPage2.Text = "Add Vendor"
        '
        'addVendorButton
        '
        Me.addVendorButton.Appearance.BackColor = System.Drawing.Color.Lime
        Me.addVendorButton.Appearance.Options.UseBackColor = True
        Me.addVendorButton.Location = New System.Drawing.Point(433, 72)
        Me.addVendorButton.Name = "addVendorButton"
        Me.addVendorButton.Size = New System.Drawing.Size(77, 27)
        Me.addVendorButton.TabIndex = 59
        Me.addVendorButton.Text = "ADD"
        '
        'addLoc
        '
        Me.addLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addLoc.Location = New System.Drawing.Point(244, 78)
        Me.addLoc.Multiline = True
        Me.addLoc.Name = "addLoc"
        Me.addLoc.ReadOnly = True
        Me.addLoc.Size = New System.Drawing.Size(183, 63)
        Me.addLoc.TabIndex = 58
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(241, 57)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 18)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Location"
        '
        'addSuppID
        '
        Me.addSuppID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addSuppID.Location = New System.Drawing.Point(244, 33)
        Me.addSuppID.Name = "addSuppID"
        Me.addSuppID.ReadOnly = True
        Me.addSuppID.Size = New System.Drawing.Size(183, 21)
        Me.addSuppID.TabIndex = 56
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(241, 12)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 18)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Supplier ID"
        '
        'addContact
        '
        Me.addContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addContact.Location = New System.Drawing.Point(12, 123)
        Me.addContact.Name = "addContact"
        Me.addContact.ReadOnly = True
        Me.addContact.Size = New System.Drawing.Size(183, 21)
        Me.addContact.TabIndex = 54
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(9, 102)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 18)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Contact"
        '
        'addType
        '
        Me.addType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addType.Location = New System.Drawing.Point(12, 78)
        Me.addType.Name = "addType"
        Me.addType.ReadOnly = True
        Me.addType.Size = New System.Drawing.Size(183, 21)
        Me.addType.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(9, 57)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 18)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Type"
        '
        'addSuppName
        '
        Me.addSuppName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addSuppName.Location = New System.Drawing.Point(12, 33)
        Me.addSuppName.Name = "addSuppName"
        Me.addSuppName.ReadOnly = True
        Me.addSuppName.Size = New System.Drawing.Size(183, 21)
        Me.addSuppName.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(9, 12)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 18)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Supplier Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Order Information"
        '
        'suppName
        '
        Me.suppName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.suppName.Location = New System.Drawing.Point(39, 134)
        Me.suppName.Name = "suppName"
        Me.suppName.Size = New System.Drawing.Size(183, 20)
        Me.suppName.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(36, 113)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 18)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Supplier Name"
        '
        'ProdBrand
        '
        Me.ProdBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdBrand.Location = New System.Drawing.Point(41, 178)
        Me.ProdBrand.Name = "ProdBrand"
        Me.ProdBrand.Size = New System.Drawing.Size(183, 20)
        Me.ProdBrand.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(38, 157)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 18)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Product Brand"
        '
        'shippingMeth
        '
        Me.shippingMeth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shippingMeth.Location = New System.Drawing.Point(247, 134)
        Me.shippingMeth.Name = "shippingMeth"
        Me.shippingMeth.Size = New System.Drawing.Size(183, 20)
        Me.shippingMeth.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(244, 113)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 18)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Shipping Method"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(244, 157)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 18)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Delivery Date"
        '
        'OrderCourier
        '
        Me.OrderCourier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OrderCourier.Location = New System.Drawing.Point(41, 222)
        Me.OrderCourier.Name = "OrderCourier"
        Me.OrderCourier.Size = New System.Drawing.Size(183, 20)
        Me.OrderCourier.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(38, 201)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 18)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Courier"
        '
        'deliveryDate
        '
        Me.deliveryDate.Location = New System.Drawing.Point(251, 179)
        Me.deliveryDate.Name = "deliveryDate"
        Me.deliveryDate.Size = New System.Drawing.Size(178, 20)
        Me.deliveryDate.TabIndex = 48
        '
        'placeOrderButton
        '
        Me.placeOrderButton.Appearance.BackColor = System.Drawing.Color.Lime
        Me.placeOrderButton.Appearance.Options.UseBackColor = True
        Me.placeOrderButton.Location = New System.Drawing.Point(289, 220)
        Me.placeOrderButton.Name = "placeOrderButton"
        Me.placeOrderButton.Size = New System.Drawing.Size(88, 38)
        Me.placeOrderButton.TabIndex = 60
        Me.placeOrderButton.Text = "Place Order"
        '
        'vendor_selection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.placeOrderButton)
        Me.Controls.Add(Me.deliveryDate)
        Me.Controls.Add(Me.OrderCourier)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.shippingMeth)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ProdBrand)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.suppName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "vendor_selection"
        Me.Size = New System.Drawing.Size(518, 440)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.vendorsTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents label12 As Label
    Friend WithEvents vendorPOID As Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents suppName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ProdBrand As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents shippingMeth As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OrderCourier As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents deliveryDate As DateTimePicker
    Friend WithEvents addSuppName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents vendorsTable As DataGridView
    Friend WithEvents addVendorButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents addLoc As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents addSuppID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents addContact As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents addType As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents placeOrderButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label14 As Label
    Friend WithEvents prVendorID As Label
End Class
