Imports MySql.Data.MySqlClient

Public Class request_approval
    Private Sub request_approval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTableRequestApproval(forApprovalTable)
    End Sub

    Sub loadTableRequestApproval(table As DataGridView)
        If Connect() Then
            Try
                Dim query As String = "CALL displayApproval()"
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, con)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                table.DataSource = dataTable
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class