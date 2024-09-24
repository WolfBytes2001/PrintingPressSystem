<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.AccordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.AccordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement4 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement5 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement6 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement8 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement9 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement3 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.FluentDesignFormControl1 = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.FluentFormDefaultManager1 = New DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.Bar5 = New DevExpress.XtraBars.Bar()
        Me.DashPanel = New System.Windows.Forms.Panel()
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FluentFormDefaultManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccordionControl1
        '
        Me.AccordionControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.AccordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement1, Me.AccordionControlElement2, Me.AccordionControlElement3})
        Me.AccordionControl1.Location = New System.Drawing.Point(0, 34)
        Me.AccordionControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AccordionControl1.Name = "AccordionControl1"
        Me.AccordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer
        Me.AccordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch
        Me.AccordionControl1.Size = New System.Drawing.Size(303, 540)
        Me.AccordionControl1.TabIndex = 1
        '
        'AccordionControlElement1
        '
        Me.AccordionControlElement1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement4, Me.AccordionControlElement5, Me.AccordionControlElement6, Me.AccordionControlElement8, Me.AccordionControlElement9})
        Me.AccordionControlElement1.Expanded = True
        Me.AccordionControlElement1.ImageOptions.SvgImage = CType(resources.GetObject("AccordionControlElement1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.AccordionControlElement1.Name = "AccordionControlElement1"
        Me.AccordionControlElement1.Text = "INVENTORY"
        '
        'AccordionControlElement4
        '
        Me.AccordionControlElement4.Name = "AccordionControlElement4"
        Me.AccordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement4.Text = "Purchase Request"
        '
        'AccordionControlElement5
        '
        Me.AccordionControlElement5.Name = "AccordionControlElement5"
        Me.AccordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement5.Text = "Approval"
        '
        'AccordionControlElement6
        '
        Me.AccordionControlElement6.Name = "AccordionControlElement6"
        Me.AccordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement6.Text = "Purchase Order"
        '
        'AccordionControlElement8
        '
        Me.AccordionControlElement8.Name = "AccordionControlElement8"
        Me.AccordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement8.Text = "Order Status"
        '
        'AccordionControlElement9
        '
        Me.AccordionControlElement9.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)})
        Me.AccordionControlElement9.Name = "AccordionControlElement9"
        Me.AccordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement9.Text = "Recieve Item"
        '
        'AccordionControlElement2
        '
        Me.AccordionControlElement2.Expanded = True
        Me.AccordionControlElement2.ImageOptions.SvgImage = CType(resources.GetObject("AccordionControlElement2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.AccordionControlElement2.Name = "AccordionControlElement2"
        Me.AccordionControlElement2.Text = "SALES"
        '
        'AccordionControlElement3
        '
        Me.AccordionControlElement3.Expanded = True
        Me.AccordionControlElement3.ImageOptions.SvgImage = CType(resources.GetObject("AccordionControlElement3.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.AccordionControlElement3.Name = "AccordionControlElement3"
        Me.AccordionControlElement3.Text = "USERS"
        '
        'FluentDesignFormControl1
        '
        Me.FluentDesignFormControl1.FluentDesignForm = Me
        Me.FluentDesignFormControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1})
        Me.FluentDesignFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.FluentDesignFormControl1.Manager = Me.FluentFormDefaultManager1
        Me.FluentDesignFormControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FluentDesignFormControl1.Name = "FluentDesignFormControl1"
        Me.FluentDesignFormControl1.Size = New System.Drawing.Size(891, 34)
        Me.FluentDesignFormControl1.TabIndex = 2
        Me.FluentDesignFormControl1.TabStop = False
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'FluentFormDefaultManager1
        '
        Me.FluentFormDefaultManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2, Me.Bar3, Me.Bar4, Me.Bar5})
        Me.FluentFormDefaultManager1.Form = Me
        Me.FluentFormDefaultManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1})
        Me.FluentFormDefaultManager1.MainMenu = Me.Bar4
        Me.FluentFormDefaultManager1.MaxItemId = 1
        Me.FluentFormDefaultManager1.StatusBar = Me.Bar5
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 1"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(947, 354)
        Me.Bar1.FloatSize = New System.Drawing.Size(46, 22)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.Bar1.Text = "Custom 1"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.Text = "Custom 3"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Custom 4"
        Me.Bar3.DockCol = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar3.Text = "Custom 4"
        '
        'Bar4
        '
        Me.Bar4.BarName = "Custom 5"
        Me.Bar4.DockCol = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar4.OptionsBar.MultiLine = True
        Me.Bar4.OptionsBar.UseWholeRow = True
        Me.Bar4.Text = "Custom 5"
        '
        'Bar5
        '
        Me.Bar5.BarName = "Custom 6"
        Me.Bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar5.DockCol = 0
        Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar5.OptionsBar.AllowQuickCustomization = False
        Me.Bar5.OptionsBar.DrawDragBorder = False
        Me.Bar5.OptionsBar.UseWholeRow = True
        Me.Bar5.Text = "Custom 6"
        '
        'DashPanel
        '
        Me.DashPanel.AutoSize = True
        Me.DashPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashPanel.Location = New System.Drawing.Point(303, 34)
        Me.DashPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DashPanel.Name = "DashPanel"
        Me.DashPanel.Size = New System.Drawing.Size(588, 540)
        Me.DashPanel.TabIndex = 3
        '
        'Dashboard
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 574)
        Me.Controls.Add(Me.DashPanel)
        Me.Controls.Add(Me.AccordionControl1)
        Me.Controls.Add(Me.FluentDesignFormControl1)
        Me.FluentDesignFormControl = Me.FluentDesignFormControl1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Dashboard"
        Me.NavigationControl = Me.AccordionControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Dashboard"
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FluentFormDefaultManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AccordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents AccordionControlElement1 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents FluentDesignFormControl1 As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl
    Friend WithEvents FluentFormDefaultManager1 As DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager
    Friend WithEvents AccordionControlElement2 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement3 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement4 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement5 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement6 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement8 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement9 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
    Friend WithEvents DashPanel As Panel
End Class
