Public Class Dashboard
    Private Sub AccordionControlElement2_Click(sender As Object, e As EventArgs) Handles AccordionControlElement2.Click

    End Sub

    Private Sub AccordionControlElement3_Click(sender As Object, e As EventArgs) Handles AccordionControlElement3.Click

    End Sub

    Private Sub AccordionControlElement4_Click(sender As Object, e As EventArgs) Handles AccordionControlElement4.Click
        Dim requestForm As New requestForm
        'requestForm.TopLevel = False
        'requestForm.Dock = DockStyle.Fill
        'Container.Controls.Clear()
        'Container.Controls.Add(requestForm)
        requestForm.Show()
    End Sub

    Private Sub AccordionControlElement6_Click(sender As Object, e As EventArgs) Handles AccordionControlElement6.Click
        Dim po As New poList
        po.Show()
    End Sub

    Private Sub AccordionControlElement5_Click(sender As Object, e As EventArgs) Handles AccordionControlElement5.Click
        Dim auth As New approvalAuth
        auth.Show()
    End Sub

    Private Sub AccordionControlElement7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AccordionControlElement8_Click(sender As Object, e As EventArgs) Handles AccordionControlElement8.Click
        Dim orderStat As New orde_status
        orderStat.Dock = DockStyle.Fill
        DashPanel.Controls.Clear()
        DashPanel.Controls.Add(orderStat)
        orderStat.Show()
    End Sub

    Private Sub AccordionControlElement9_Click(sender As Object, e As EventArgs) Handles AccordionControlElement9.Click
        Dim recieved As New itemRecieved
        recieved.Dock = DockStyle.Fill
        DashPanel.Controls.Clear()
        DashPanel.Controls.Add(recieved)
        recieved.Show()
    End Sub
End Class
