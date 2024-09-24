<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class requestForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(requestForm))
        Me.quantity = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.totalPrice = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.quantityBox = New System.Windows.Forms.TextBox()
        Me.fundBox = New System.Windows.Forms.TextBox()
        Me.itemPrice = New System.Windows.Forms.TextBox()
        Me.itemDescripBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rqOfficer = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.requestNumber = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.requestedBy = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.requestID = New System.Windows.Forms.Label()
        Me.unitOfMeasure = New System.Windows.Forms.ComboBox()
        Me.productType = New System.Windows.Forms.ComboBox()
        Me.purposeBox = New System.Windows.Forms.ComboBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'quantity
        '
        Me.quantity.AutoSize = True
        Me.quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity.ForeColor = System.Drawing.Color.Red
        Me.quantity.Location = New System.Drawing.Point(413, 64)
        Me.quantity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(116, 25)
        Me.quantity.TabIndex = 3
        Me.quantity.Text = "Total Price"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(2, 116)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(103, 24)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Item Price"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(313, 2)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 24)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Quantity"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(160, 2)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(156, 24)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Unit of Measure"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 2)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Item Description"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.purposeBox)
        Me.Panel2.Controls.Add(Me.productType)
        Me.Panel2.Controls.Add(Me.unitOfMeasure)
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Controls.Add(Me.totalPrice)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.quantityBox)
        Me.Panel2.Controls.Add(Me.fundBox)
        Me.Panel2.Controls.Add(Me.itemPrice)
        Me.Panel2.Controls.Add(Me.itemDescripBox)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.quantity)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(0, 57)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(650, 204)
        Me.Panel2.TabIndex = 5
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.Chartreuse
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(457, 129)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(146, 57)
        Me.SimpleButton1.TabIndex = 43
        Me.SimpleButton1.Text = "Confirm"
        '
        'totalPrice
        '
        Me.totalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalPrice.Location = New System.Drawing.Point(413, 92)
        Me.totalPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.Size = New System.Drawing.Size(228, 29)
        Me.totalPrice.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(181, 118)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(155, 24)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Source of Fund"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(414, 2)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 24)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Purpose"
        '
        'quantityBox
        '
        Me.quantityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.quantityBox.Location = New System.Drawing.Point(291, 26)
        Me.quantityBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.quantityBox.Name = "quantityBox"
        Me.quantityBox.Size = New System.Drawing.Size(106, 29)
        Me.quantityBox.TabIndex = 38
        '
        'fundBox
        '
        Me.fundBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fundBox.Location = New System.Drawing.Point(180, 143)
        Me.fundBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fundBox.Name = "fundBox"
        Me.fundBox.Size = New System.Drawing.Size(214, 29)
        Me.fundBox.TabIndex = 36
        '
        'itemPrice
        '
        Me.itemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.itemPrice.Location = New System.Drawing.Point(3, 142)
        Me.itemPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.itemPrice.Name = "itemPrice"
        Me.itemPrice.Size = New System.Drawing.Size(169, 29)
        Me.itemPrice.TabIndex = 35
        '
        'itemDescripBox
        '
        Me.itemDescripBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.itemDescripBox.Location = New System.Drawing.Point(6, 26)
        Me.itemDescripBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.itemDescripBox.Multiline = True
        Me.itemDescripBox.Name = "itemDescripBox"
        Me.itemDescripBox.Size = New System.Drawing.Size(168, 83)
        Me.itemDescripBox.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(177, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 24)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Product Type"
        '
        'rqOfficer
        '
        Me.rqOfficer.FormattingEnabled = True
        Me.rqOfficer.Location = New System.Drawing.Point(413, 12)
        Me.rqOfficer.Margin = New System.Windows.Forms.Padding(2)
        Me.rqOfficer.Name = "rqOfficer"
        Me.rqOfficer.Size = New System.Drawing.Size(204, 24)
        Me.rqOfficer.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(241, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Requesition Officer:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(2, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Request ID:"
        '
        'requestNumber
        '
        Me.requestNumber.AutoSize = True
        Me.requestNumber.BackColor = System.Drawing.Color.Transparent
        Me.requestNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.requestNumber.Location = New System.Drawing.Point(110, 14)
        Me.requestNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.requestNumber.Name = "requestNumber"
        Me.requestNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.requestNumber.Size = New System.Drawing.Size(43, 20)
        Me.requestNumber.TabIndex = 0
        Me.requestNumber.Text = "RQ-"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.rqOfficer)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.requestNumber)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(650, 57)
        Me.Panel1.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Controls.Add(Me.requestedBy)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.requestID)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(650, 57)
        Me.Panel5.TabIndex = 6
        '
        'requestedBy
        '
        Me.requestedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.requestedBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.requestedBy.FormattingEnabled = True
        Me.requestedBy.Location = New System.Drawing.Point(399, 15)
        Me.requestedBy.Margin = New System.Windows.Forms.Padding(2)
        Me.requestedBy.Name = "requestedBy"
        Me.requestedBy.Size = New System.Drawing.Size(242, 24)
        Me.requestedBy.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(268, 18)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Requested by:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(2, 18)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "ID:"
        '
        'requestID
        '
        Me.requestID.AutoSize = True
        Me.requestID.BackColor = System.Drawing.Color.Transparent
        Me.requestID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestID.ForeColor = System.Drawing.Color.Blue
        Me.requestID.Location = New System.Drawing.Point(37, 15)
        Me.requestID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.requestID.Name = "requestID"
        Me.requestID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.requestID.Size = New System.Drawing.Size(51, 25)
        Me.requestID.TabIndex = 0
        Me.requestID.Text = "RQ-"
        '
        'unitOfMeasure
        '
        Me.unitOfMeasure.FormattingEnabled = True
        Me.unitOfMeasure.Items.AddRange(New Object() {"unit", "piece", "box", "rim"})
        Me.unitOfMeasure.Location = New System.Drawing.Point(181, 23)
        Me.unitOfMeasure.Name = "unitOfMeasure"
        Me.unitOfMeasure.Size = New System.Drawing.Size(100, 32)
        Me.unitOfMeasure.TabIndex = 44
        '
        'productType
        '
        Me.productType.FormattingEnabled = True
        Me.productType.Items.AddRange(New Object() {"Supplies", "Equipment", "Furniture and Fixture", ""})
        Me.productType.Location = New System.Drawing.Point(180, 85)
        Me.productType.Name = "productType"
        Me.productType.Size = New System.Drawing.Size(213, 32)
        Me.productType.TabIndex = 45
        '
        'purposeBox
        '
        Me.purposeBox.FormattingEnabled = True
        Me.purposeBox.Items.AddRange(New Object() {"Restock", "Equipment purchase"})
        Me.purposeBox.Location = New System.Drawing.Point(413, 29)
        Me.purposeBox.Name = "purposeBox"
        Me.purposeBox.Size = New System.Drawing.Size(228, 32)
        Me.purposeBox.TabIndex = 46
        '
        'requestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 252)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "requestForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "requestForm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents quantity As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rqOfficer As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents requestNumber As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents fundBox As TextBox
    Friend WithEvents itemPrice As TextBox
    Friend WithEvents itemDescripBox As TextBox
    Friend WithEvents quantityBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents requestedBy As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents requestID As Label
    Friend WithEvents totalPrice As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents unitOfMeasure As ComboBox
    Friend WithEvents productType As ComboBox
    Friend WithEvents purposeBox As ComboBox
End Class
