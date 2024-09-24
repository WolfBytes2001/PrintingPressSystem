Imports System.Globalization
Imports System.Reflection.Emit
Imports System.Security.Cryptography
Imports DevExpress
Imports MySql.Data.MySqlClient

Public Class requestForm

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim reqNum As String = requestID.Text
        Dim reqBy As String = requestedBy.Text
        Dim itemDes As String = itemDescripBox.Text
        Dim price As String = itemPrice.Text
        Dim measure As String = unitOfMeasure.Text
        Dim quantity As String = quantityBox.Text
        Dim prodType As String = ProductType.Text
        Dim source As String = fundBox.Text
        Dim purpose As String = purposeBox.Text
        Dim total As String = totalPrice.Text

        If Connect() Then
            If String.IsNullOrEmpty(reqNum) OrElse
              String.IsNullOrEmpty(reqBy) OrElse
              String.IsNullOrEmpty(itemDes) OrElse
              String.IsNullOrEmpty(price) OrElse
              String.IsNullOrEmpty(measure) OrElse
              String.IsNullOrEmpty(quantity) OrElse
              String.IsNullOrEmpty(prodType) OrElse
              String.IsNullOrEmpty(source) OrElse
              String.IsNullOrEmpty(purpose) OrElse
              String.IsNullOrEmpty(total) Then
                MessageBox.Show("One or more fields have not been completed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Try
                    Dim query As String = $"INSERT INTO request_form (request_id,request_by,item_description,price,measure,quantity,product_type,source_of_fund,purpose,total_amount) VALUES('{reqNum}','{reqBy}','{itemDes}','{price}','{measure}','{quantity}','{prodType}', '{source}', '{purpose}','{total}')"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Purchase Request Saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearRequestForm()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If

        End If

    End Sub

    Private Sub requestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        requestID.Text = GenerateRequestNumber()
    End Sub


    Sub clearRequestForm()

        requestID.Text = ""
        requestedBy.Text = ""
        itemDescripBox.Text = ""
        unitOfMeasure.Text = ""
        quantityBox.Text = ""
        productType.Text = ""
        itemPrice.Text = ""
        fundBox.Text = ""
        purposeBox.Text = ""
        totalPrice.Text = ""

    End Sub

    Private Sub requestedBy_Click(sender As Object, e As EventArgs) Handles requestedBy.Click
        comboBoxLoadItems("employee", requestedBy, "fullname")
    End Sub

    Private Sub itemPrice_TextChanged(sender As Object, e As EventArgs) Handles itemPrice.TextChanged
        Dim amount As Decimal
        If Decimal.TryParse(itemPrice.Text.Replace(",", ""), NumberStyles.Currency, CultureInfo.CurrentCulture, amount) Then
            ' Format the number with commas
            itemPrice.Text = amount.ToString("N0")
            ' Set the cursor position to the end
            itemPrice.SelectionStart = itemPrice.Text.Length
        End If

        itemPrice.Text = itemPrice.Text

        Dim quantity As Integer
        Dim price As Double

        ' Convert text to integer for quantity
        If Integer.TryParse(quantityBox.Text, quantity) Then
            ' Text is a valid integer, proceed
            If Double.TryParse(itemPrice.Text, price) Then
                ' Text is a valid double, proceed
                totalPrice.Text = (quantity * price).ToString()
            Else
                ' Text in itemPriceBox is not a valid double
                totalPrice.Text = "Invalid Price"
            End If
        Else
            ' Text in quantityBox is not a valid integer
            totalPrice.Text = "Invalid Quantity"
        End If
    End Sub

    Private Sub quantityBox_TextChanged(sender As Object, e As EventArgs) Handles quantityBox.TextChanged

        Dim quantity As Integer
        Dim price As Double

        ' Convert text to integer for quantity
        If Integer.TryParse(quantityBox.Text, quantity) Then
            ' Text is a valid integer, proceed
            If Double.TryParse(itemPrice.Text, price) Then
                ' Text is a valid double, proceed
                totalPrice.Text = (quantity * price).ToString()
            Else
                ' Text in itemPriceBox is not a valid double
                totalPrice.Text = "Invalid Price"
            End If
        Else
            ' Text in quantityBox is not a valid integer
            totalPrice.Text = "Invalid Quantity"
        End If
    End Sub
End Class