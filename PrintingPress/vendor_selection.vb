Imports DevExpress.XtraGrid.Views
Imports Google.Protobuf.WellKnownTypes
Imports System.Threading.Tasks
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Ocsp
Imports Org.BouncyCastle.Asn1.Ocsp

Public Class vendor_selection
    Public vendorPO As String
    Public vendorPR As String
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub vendor_selection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadVendorTable()
    End Sub

    Sub loadVendorTable()

        If Connect() Then
            Try
                Dim query As String = "SELECT * FROM vendors"
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, con)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                vendorsTable.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub placeOrderButton_Click(sender As Object, e As EventArgs) Handles placeOrderButton.Click
        Dim name As String = suppName.Text
        Dim brand As String = ProdBrand.Text
        Dim courier As String = OrderCourier.Text
        Dim method As String = shippingMeth.Text
        Dim date1 As String = deliveryDate.Text
        vendorPO = vendorPOID.Text
        vendorPR = prVendorID.Text

        If Connect() Then
            If String.IsNullOrEmpty(name) OrElse
             String.IsNullOrEmpty(brand) OrElse
             String.IsNullOrEmpty(courier) OrElse
             String.IsNullOrEmpty(method) OrElse
             String.IsNullOrEmpty(date1) Then
                MessageBox.Show("One or more fields have not been completed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                Try
                    Dim query As String = $"INSERT INTO purchase_order(po_id,pr_id,supplier_name,shipping_method,brand,courier,delivery_date) VALUES('{vendorPO}','{vendorPR}','{name}','{method}','{brand}','{courier}','{date1}')"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show(" Order Placed Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub
End Class
