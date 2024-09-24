Imports MySql.Data.MySqlClient

Public Class poList
    Public request_IDPOform As String
    Private Sub poList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
    End Sub

    Sub loadTable()

        If Connect() Then
            Try
                Dim query As String = "SELECT * FROM approved_request WHERE status = 'Pending'"
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, con)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                poListTable.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


    Sub confirmPO()
        Dim tableName As String = "request_id"

        If poListTable.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = poListTable.SelectedCells(0).RowIndex
            request_IDPOform = poListTable.Rows(selectedRowIndex).Cells(tableName).Value?.ToString()

            Dim result As DialogResult = MessageBox.Show($"Proceed to generate Purchase order for Request ID: {request_IDPOform}?", "APPROVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

            If result = DialogResult.OK Then
                loadPurchaseOrder()
                Me.Close()
            Else
                MessageBox.Show("Operation cancelled by user.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Only approved requests are allowed to be generated")
        End If
    End Sub

    'Private Sub XtraTabControl1_Click(sender As Object, e As EventArgs) Handles TABCONTROL1.Click
    '    loadApproveTable()
    'End Sub

    Public Sub loadPurchaseOrder()

        Dim purchaseOrder As New purchase_order()

        purchaseOrder.Dock = DockStyle.Fill
        'If MainDashboard.DashboardContainer.Controls.Count >= 0 Then
        '    Dim existingForm = TryCast(MainDashboard.DashboardContainer.Controls(0), Form)
        '    If existingForm IsNot Nothing Then
        '        existingForm.Dispose()
        '    End If
        'End If
        Dashboard.DashPanel.Controls.Clear()
        Dashboard.DashPanel.Controls.Add(purchaseOrder)
        purchaseOrder.Show()


        If Connect() Then
            Try
                Dim sql = $"SELECT * FROM request_form WHERE request_id = '{request_IDPOform}' "

                Using cmd As New MySqlCommand(sql, con)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()


                    If reader.HasRows Then
                        While reader.Read()
                            purchaseOrder.PRID.Text = reader("request_id").ToString()
                            purchaseOrder.POrequestedBy.Text = reader("request_by").ToString()
                            purchaseOrder.poItemDes.Text = reader("item_description").ToString()
                            purchaseOrder.POitemPrice.Text = reader("price").ToString()
                            purchaseOrder.poUnitOfMeas.Text = reader("measure").ToString()
                            purchaseOrder.POquantityBox.Text = reader("quantity").ToString()
                            purchaseOrder.POProductType.Text = reader("product_type").ToString()
                            purchaseOrder.POfundBox.Text = reader("source_of_fund").ToString()
                            purchaseOrder.POpurposeBox.Text = reader("purpose").ToString()
                            purchaseOrder.POtotalPrice.Text = reader("total_amount").ToString()

                        End While

                    Else
                        'MessageBox.Show("Invalid username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                    End If

                    reader.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading purchase order: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Connection error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub poListTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles poListTable.CellContentClick
        confirmPO()
    End Sub
End Class