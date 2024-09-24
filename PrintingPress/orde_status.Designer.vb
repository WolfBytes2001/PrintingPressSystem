<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orde_status
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
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.onProcessTable = New System.Windows.Forms.DataGridView()
        Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.DeliveredTable = New System.Windows.Forms.DataGridView()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.TabNavigationPage1.SuspendLayout()
        CType(Me.onProcessTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage2.SuspendLayout()
        CType(Me.DeliveredTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPane1
        '
        Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage2)
        Me.TabPane1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPane1.Location = New System.Drawing.Point(0, 0)
        Me.TabPane1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2})
        Me.TabPane1.RegularSize = New System.Drawing.Size(672, 537)
        Me.TabPane1.SelectedPage = Me.TabNavigationPage1
        Me.TabPane1.Size = New System.Drawing.Size(672, 537)
        Me.TabPane1.TabIndex = 0
        Me.TabPane1.Text = "TabPane1"
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Caption = "On Process"
        Me.TabNavigationPage1.Controls.Add(Me.onProcessTable)
        Me.TabNavigationPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.Size = New System.Drawing.Size(672, 502)
        '
        'onProcessTable
        '
        Me.onProcessTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.onProcessTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.onProcessTable.Location = New System.Drawing.Point(0, 0)
        Me.onProcessTable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.onProcessTable.Name = "onProcessTable"
        Me.onProcessTable.RowHeadersWidth = 51
        Me.onProcessTable.Size = New System.Drawing.Size(672, 502)
        Me.onProcessTable.TabIndex = 0
        '
        'TabNavigationPage2
        '
        Me.TabNavigationPage2.Caption = "Delivered"
        Me.TabNavigationPage2.Controls.Add(Me.DeliveredTable)
        Me.TabNavigationPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabNavigationPage2.Name = "TabNavigationPage2"
        Me.TabNavigationPage2.Size = New System.Drawing.Size(672, 501)
        '
        'DeliveredTable
        '
        Me.DeliveredTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DeliveredTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeliveredTable.Location = New System.Drawing.Point(0, 0)
        Me.DeliveredTable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DeliveredTable.Name = "DeliveredTable"
        Me.DeliveredTable.RowHeadersWidth = 51
        Me.DeliveredTable.Size = New System.Drawing.Size(672, 501)
        Me.DeliveredTable.TabIndex = 0
        '
        'orde_status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabPane1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "orde_status"
        Me.Size = New System.Drawing.Size(672, 537)
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.TabNavigationPage1.ResumeLayout(False)
        CType(Me.onProcessTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage2.ResumeLayout(False)
        CType(Me.DeliveredTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents onProcessTable As DataGridView
    Friend WithEvents DeliveredTable As DataGridView
End Class
