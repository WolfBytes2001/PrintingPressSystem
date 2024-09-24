Module IDgenerator


    Function GenerateRequestNumber() As String
        ' Get current date
        Dim currentDate As Date = Date.Now
        ' Format the date as Day-Month
        Dim formattedDate As String = currentDate.ToString("dd-MM")

        ' Generate a unique order number (you can replace this logic with your own)
        Dim orderNumber As Integer = GetUniqueOrderNumber()

        ' Combine the components to create the PR number
        Dim requestID As String = $"PR-{formattedDate}-{orderNumber}"
        Return requestID
    End Function

    Function GetUniqueOrderNumber() As Integer
        ' Replace this logic with your own method to generate a unique order number
        ' For example, you can use a database sequence, random number generator, etc.
        Return New Random().Next(1000, 9999)
    End Function

    Function GeneratePOCode() As String
        ' Get current date
        Dim currentDate As Date = Date.Now
        ' Format the date as Day-Month
        Dim formattedDate As String = currentDate.ToString("dd-MM")

        ' Generate a unique order number (you can replace this logic with your own)
        Dim orderNumber As Integer = GetUniqueOrderNumber()

        ' Combine the components to create the PR number
        Dim requestID As String = $"PO-{formattedDate}-{orderNumber}"
        Return requestID
    End Function

    Function GenerateVendorID() As String
        ' Get current date
        Dim currentDate As Date = Date.Now
        ' Format the date as Day-Month
        Dim formattedDate As String = currentDate.ToString("dd-MM")

        ' Generate a unique order number (you can replace this logic with your own)
        Dim orderNumber As Integer = GetUniqueOrderNumber()

        ' Combine the components to create the PR number
        Dim requestID As String = $"V-{formattedDate}-{orderNumber}"
        Return requestID
    End Function

End Module
