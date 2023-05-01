'MIS 322
'Damanbir Singh
'LAP 4
'11/1/2022

Option Explicit On
Option Strict On


Public Class CheckoutForm

    Private Sub CheckoutForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'set backcolor and show proper text

        Dim pickupPrice As Double
        Dim deliveryPrice As Double
        Dim eatAtStorePrice As Double
        Dim pickUpTax As Double
        Dim deliveryTax As Double
        Dim atStoreTax As Double


        BackColor = Color.LightPink
        pizzaOrderText.Clear()
        submitButton.Select()

        pickUpTax = totalPrice * 0.087
        deliveryTax = (totalPrice + 5.0) * 0.087
        atStoreTax = totalPrice * 0.087
        pickupPrice = totalPrice + pickUpTax
        deliveryPrice = totalPrice + deliveryTax + 5.0
        eatAtStorePrice = totalPrice + atStoreTax

        pickupLabel.Text = pickupPrice.ToString("C2")
        deliveryLabel.Text = deliveryPrice.ToString("C2")
        eatAtStoreLabel.Text = eatAtStorePrice.ToString("C2")
        pizzaOrderText.Text = orderText


    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        'submit order

        Dim message As String

        If pickupButton.Checked Then
            message = "You have selected Pickup. Pizza will be ready in 30 minutes"
            MessageBox.Show(message, "Order Confirmed")
            Close()
        ElseIf deliveryButton.Checked Then
            Message = "You have selected Delivery. Pizza will be delivered in 45 minutes"
            MessageBox.Show(message, "Order Confirmed")
            Close()
        ElseIf eatAtStoreButton.Checked Then
            Message = "You have selected Eat In. See you soon!"
            MessageBox.Show(message, "Order Confirmed")
            Close()
        Else
            message = "Please select 1 of the 3 options"
            MessageBox.Show(message)
            Exit Sub
        End If

    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        'close form

        Close()

    End Sub
End Class