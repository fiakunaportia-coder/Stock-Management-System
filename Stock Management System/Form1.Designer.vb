<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabPageEntry = New System.Windows.Forms.TabPage()
        Me.grpProductDetails = New System.Windows.Forms.GroupBox()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.nudPrice = New System.Windows.Forms.NumericUpDown()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.tabPageManagement = New System.Windows.Forms.TabPage()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tabPageview = New System.Windows.Forms.TabPage()
        Me.lblStatus = New System.Windows.Forms.ToolStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.tabMain.SuspendLayout()
        Me.tabPageEntry.SuspendLayout()
        Me.grpProductDetails.SuspendLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageManagement.SuspendLayout()
        Me.tabPageview.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabPageEntry)
        Me.tabMain.Controls.Add(Me.tabPageManagement)
        Me.tabMain.Controls.Add(Me.tabPageview)
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.HotTrack = True
        Me.tabMain.ItemSize = New System.Drawing.Size(120, 30)
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(933, 588)
        Me.tabMain.TabIndex = 0
        '
        'tabPageEntry
        '
        Me.tabPageEntry.AllowDrop = True
        Me.tabPageEntry.BackColor = System.Drawing.Color.DarkTurquoise
        Me.tabPageEntry.BackgroundImage = Global.Stock_Management_System.My.Resources.Resources.WhatsApp_Image_2026_04_07_at_9_37_10_PM
        Me.tabPageEntry.Controls.Add(Me.grpProductDetails)
        Me.tabPageEntry.Controls.Add(Me.cmbCategory)
        Me.tabPageEntry.Location = New System.Drawing.Point(4, 34)
        Me.tabPageEntry.Name = "tabPageEntry"
        Me.tabPageEntry.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageEntry.Size = New System.Drawing.Size(925, 550)
        Me.tabPageEntry.TabIndex = 0
        Me.tabPageEntry.Text = "Product Entry"
        '
        'grpProductDetails
        '
        Me.grpProductDetails.BackColor = System.Drawing.Color.White
        Me.grpProductDetails.BackgroundImage = Global.Stock_Management_System.My.Resources.Resources.WhatsApp_Image_2026_04_07_at_9_35_22_PM__1_
        Me.grpProductDetails.Controls.Add(Me.nudQuantity)
        Me.grpProductDetails.Controls.Add(Me.lblQuantity)
        Me.grpProductDetails.Controls.Add(Me.nudPrice)
        Me.grpProductDetails.Controls.Add(Me.lblPrice)
        Me.grpProductDetails.Controls.Add(Me.lblCategory)
        Me.grpProductDetails.Controls.Add(Me.txtName)
        Me.grpProductDetails.Controls.Add(Me.lblName)
        Me.grpProductDetails.Controls.Add(Me.txtID)
        Me.grpProductDetails.Controls.Add(Me.lblID)
        Me.grpProductDetails.Location = New System.Drawing.Point(40, 40)
        Me.grpProductDetails.Name = "grpProductDetails"
        Me.grpProductDetails.Size = New System.Drawing.Size(600, 260)
        Me.grpProductDetails.TabIndex = 0
        Me.grpProductDetails.TabStop = False
        Me.grpProductDetails.Text = "Add/Edit Product Details"
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(180, 188)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(150, 25)
        Me.nudQuantity.TabIndex = 9
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(40, 190)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(56, 17)
        Me.lblQuantity.TabIndex = 8
        Me.lblQuantity.Text = "Quantity"
        '
        'nudPrice
        '
        Me.nudPrice.DecimalPlaces = 2
        Me.nudPrice.Location = New System.Drawing.Point(180, 148)
        Me.nudPrice.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudPrice.Name = "nudPrice"
        Me.nudPrice.Size = New System.Drawing.Size(150, 25)
        Me.nudPrice.TabIndex = 7
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(40, 150)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(36, 17)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "Price"
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Electronics", "Food & Beverages", "Clothing & Apparel", "Furniture & Home", "Stationery & Office Supplies", "Beauty & Personel Care", "Sports & Outdoors", "Toys & Games", "Books & Media", "Health & Wellness", "Automotive", "Others"})
        Me.cmbCategory.Location = New System.Drawing.Point(148, 0)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(250, 25)
        Me.cmbCategory.TabIndex = 5
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(40, 110)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(61, 17)
        Me.lblCategory.TabIndex = 4
        Me.lblCategory.Text = "Category"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(180, 68)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(380, 25)
        Me.txtName.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(40, 70)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(92, 17)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Product Name"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.LightGray
        Me.txtID.Location = New System.Drawing.Point(180, 28)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(150, 25)
        Me.txtID.TabIndex = 1
        Me.txtID.TabStop = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(40, 30)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(69, 17)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Product ID"
        '
        'tabPageManagement
        '
        Me.tabPageManagement.BackgroundImage = Global.Stock_Management_System.My.Resources.Resources.WhatsApp_Image_2026_04_07_at_9_25_07_PM
        Me.tabPageManagement.Controls.Add(Me.btnSearch)
        Me.tabPageManagement.Controls.Add(Me.txtSearch)
        Me.tabPageManagement.Controls.Add(Me.lblSearch)
        Me.tabPageManagement.Controls.Add(Me.btnRefresh)
        Me.tabPageManagement.Controls.Add(Me.btnClear)
        Me.tabPageManagement.Controls.Add(Me.btnDelete)
        Me.tabPageManagement.Controls.Add(Me.btnUpdate)
        Me.tabPageManagement.Controls.Add(Me.btnAdd)
        Me.tabPageManagement.Location = New System.Drawing.Point(4, 34)
        Me.tabPageManagement.Name = "tabPageManagement"
        Me.tabPageManagement.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageManagement.Size = New System.Drawing.Size(925, 550)
        Me.tabPageManagement.TabIndex = 1
        Me.tabPageManagement.Text = "Stock Management"
        Me.tabPageManagement.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Blue
        Me.btnSearch.Location = New System.Drawing.Point(829, 106)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 30)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(579, 106)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(220, 25)
        Me.txtSearch.TabIndex = 6
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(576, 80)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(96, 17)
        Me.lblSearch.TabIndex = 5
        Me.lblSearch.Text = "Search Product"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Orange
        Me.btnRefresh.Location = New System.Drawing.Point(240, 150)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(140, 45)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Firebrick
        Me.btnClear.Location = New System.Drawing.Point(80, 150)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(140, 45)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear Fields"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightCoral
        Me.btnDelete.Location = New System.Drawing.Point(400, 80)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(140, 45)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete Product"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.ForestGreen
        Me.btnUpdate.Location = New System.Drawing.Point(240, 80)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(140, 45)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update Product"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightGreen
        Me.btnAdd.Location = New System.Drawing.Point(80, 80)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(140, 45)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Product"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'tabPageview
        '
        Me.tabPageview.Controls.Add(Me.lblStatus)
        Me.tabPageview.Controls.Add(Me.StatusStrip1)
        Me.tabPageview.Controls.Add(Me.dgvInventory)
        Me.tabPageview.Location = New System.Drawing.Point(4, 34)
        Me.tabPageview.Name = "tabPageview"
        Me.tabPageview.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageview.Size = New System.Drawing.Size(925, 550)
        Me.tabPageview.TabIndex = 2
        Me.tabPageview.Text = "View Inventory"
        Me.tabPageview.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(3, 3)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(919, 25)
        Me.lblStatus.Stretch = True
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Total Products: 0"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 525)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(919, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro
        Me.dgvInventory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInventory.Location = New System.Drawing.Point(3, 3)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.Size = New System.Drawing.Size(919, 544)
        Me.dgvInventory.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 588)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tabMain.ResumeLayout(False)
        Me.tabPageEntry.ResumeLayout(False)
        Me.grpProductDetails.ResumeLayout(False)
        Me.grpProductDetails.PerformLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageManagement.ResumeLayout(False)
        Me.tabPageManagement.PerformLayout()
        Me.tabPageview.ResumeLayout(False)
        Me.tabPageview.PerformLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabPageEntry As TabPage
    Friend WithEvents tabPageManagement As TabPage
    Friend WithEvents tabPageview As TabPage
    Friend WithEvents grpProductDetails As GroupBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents nudPrice As NumericUpDown
    Friend WithEvents lblPrice As Label
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents lblQuantity As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents lblStatus As ToolStrip
    Friend WithEvents StatusStrip1 As StatusStrip
End Class
