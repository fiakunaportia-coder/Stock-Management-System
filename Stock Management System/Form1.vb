Imports System.Data

Public Class Form1

    ' ==============================================
    '   GLOBAL VARIABLES
    ' ==============================================
    Dim dtInventory As New DataTable()
    Dim nextID As Integer = 1001

    ' ==============================================
    '   FORM LOAD
    ' ==============================================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create columns for DataTable
        dtInventory.Columns.Add("ID", GetType(Integer))
        dtInventory.Columns.Add("Name", GetType(String))
        dtInventory.Columns.Add("Category", GetType(String))
        dtInventory.Columns.Add("Price", GetType(Decimal))
        dtInventory.Columns.Add("Quantity", GetType(Integer))
        dtInventory.Columns.Add("DateAdded", GetType(DateTime))

        dgvInventory.DataSource = dtInventory

        ' Format columns
        dgvInventory.Columns("Price").DefaultCellStyle.Format = "C2"
        dgvInventory.Columns("DateAdded").DefaultCellStyle.Format = "dd-MMM-yyyy"
        dgvInventory.Columns("ID").Width = 70
        dgvInventory.Columns("Name").Width = 200
        dgvInventory.Columns("Quantity").Width = 100

        ' Add sample categories
        cmbCategory.Items.AddRange({"Electronics", "Food & Beverages", "Clothing & Apparel",
                                    "Furniture & Home", "Stationery", "Beauty & Personal Care",
                                    "Sports & Outdoors", "Others"})
    End Sub

    ' ==============================================
    '   HELPER METHODS
    ' ==============================================
    Private Sub ClearFields()
        txtID.Clear()
        txtName.Clear()
        cmbCategory.SelectedIndex = -1
        nudPrice.Value = 0
        nudQuantity.Value = 0
    End Sub

    Private Sub RefreshGrid()
        dgvInventory.DataSource = dtInventory
    End Sub

    ' ==============================================
    '   BUTTON EVENTS
    ' ==============================================

    ' Add Product
    ' ====================== ADD PRODUCT ======================
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Product Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbCategory.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Category!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Add the product
        Dim row As DataRow = dtInventory.NewRow()
        row("ID") = nextID
        row("Name") = txtName.Text.Trim()
        row("Category") = cmbCategory.Text
        row("Price") = nudPrice.Value
        row("Quantity") = CInt(nudQuantity.Value)
        row("DateAdded") = DateTime.Now

        dtInventory.Rows.Add(row)
        nextID += 1

        MessageBox.Show("Product Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ClearFields()

        ' ==================== AUTO SWITCH TO VIEW INVENTORY ====================
        tabMain.SelectedTab = tabPageview     ' Switches to View Inventory tab

        RefreshGrid()
    End Sub
    ' Update Product
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvInventory.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a product from the grid!", "Select Product")
            Return
        End If

        Dim rowIndex As Integer = dgvInventory.CurrentRow.Index
        Dim row As DataRow = dtInventory.Rows(rowIndex)

        row("Name") = txtName.Text.Trim()
        row("Category") = cmbCategory.Text
        row("Price") = nudPrice.Value
        row("Quantity") = CInt(nudQuantity.Value)

        MessageBox.Show("Product Updated Successfully!")
        RefreshGrid()
    End Sub

    ' Delete Product
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvInventory.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a product to delete!")
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim rowIndex As Integer = dgvInventory.CurrentRow.Index
            dtInventory.Rows.RemoveAt(rowIndex)
            MessageBox.Show("Product Deleted Successfully!")
            ClearFields()
        End If
    End Sub

    ' Clear Fields
    ' ====================== CLEAR FIELDS BUTTON ======================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear input fields (TextBoxes, ComboBoxes, etc.)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            ElseIf TypeOf ctrl Is ComboBox Then
                DirectCast(ctrl, ComboBox).SelectedIndex = -1
            End If
        Next

        ' Clear the inventory grid safely
        dgvInventory.DataSource = Nothing          ' Best if data-bound
        dgvInventory.Rows.Clear()                  ' Use only if NOT data-bound

        ' Optional: Switch back to Product Entry tab
        tabMain.SelectedIndex = 0

        MessageBox.Show("All fields have been cleared.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)
    End Sub



    ' Refresh
    ' ====================== REFRESH BUTTON ======================
    ' ====================== REFRESH BUTTON ======================
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshGrid()

        ' Switch to View Inventory tab
        tabMain.SelectedIndex = 2

        ' Correct way to show message
        MessageBox.Show("Inventory list has been refreshed.", "Refreshed",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    ' Search
    ' ====================== SEARCH PRODUCT (Fixed Version) ======================
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim keyword As String = txtSearch.Text.Trim()

        ' If search box is empty, show all products
        If String.IsNullOrWhiteSpace(keyword) Then
            dgvInventory.DataSource = dtInventory
            Return
        End If

        ' Create filtered view
        Dim dv As New DataView(dtInventory)

        ' Better search: Ignore case and special characters
        dv.RowFilter = String.Format("Name LIKE '%{0}%' OR Category LIKE '%{0}%'",
                                     keyword.Replace("'", "''"))

        dgvInventory.DataSource = dv

        ' Show friendly message if nothing found
        If dv.Count = 0 Then
            MessageBox.Show("No product found matching '" & keyword & "'",
                            "Search Result",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            ' Optional: Show how many results found
            MessageBox.Show(dv.Count & " product(s) found matching '" & keyword & "'",
                            "Search Result",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub

    ' Grid Cell Click - Load data to fields
    Private Sub dgvInventory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvInventory.Rows(e.RowIndex)

            txtID.Text = row.Cells("ID").Value.ToString()
            txtName.Text = row.Cells("Name").Value.ToString()
            cmbCategory.Text = row.Cells("Category").Value.ToString()
            nudPrice.Value = CDec(row.Cells("Price").Value)
            nudQuantity.Value = CInt(row.Cells("Quantity").Value)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' ====================== SUBMIT BUTTON (Product Entry Tab) ======================

        ' Validation
        If String.IsNullOrWhiteSpace(txtName.Text.Trim()) Then
            MessageBox.Show("Product Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbCategory.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Category!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Add the product
        Dim row As DataRow = dtInventory.NewRow()
        row("ID") = nextID
        row("Name") = txtName.Text.Trim()
        row("Category") = cmbCategory.Text
        row("Price") = nudPrice.Value
        row("Quantity") = CInt(nudQuantity.Value)
        row("DateAdded") = DateTime.Now

        dtInventory.Rows.Add(row)
        nextID += 1

        MessageBox.Show("Product Submitted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ClearFields()

        ' Automatically switch to Stock Management tab
        tabMain.SelectedIndex = 1        ' 1 = Stock Management Tab
    End Sub
End Class