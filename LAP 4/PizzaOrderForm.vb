'MIS 322
'Damanbir Singh
'LAP 4
'11/1/2022

Option Explicit On
Option Strict On


Public Class Form1
    Private Sub PizzaOrderForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'set backcolor

        BackColor = Color.LightPink

        checkoutButton.Select()

    End Sub

    Private Sub checkoutButton_Click(sender As Object, e As EventArgs) Handles checkoutButton.Click
        'make the proper selections and open checkout form

        Dim message As String

        If smallButton.Checked And thinButton.Checked Then
            totalPrice = smallSize + thinCrust
            orderText = "Size: Small" & vbNewLine & "Crust: Thin" & vbNewLine & "Toppings:" & vbNewLine
        ElseIf smallButton.Checked And thickButton.Checked Then
            totalPrice = smallSize + thickCrust
            orderText = "Size: Small" & vbNewLine & "Crust: Thick" & vbNewLine & "Toppings:" & vbNewLine
        ElseIf smallButton.Checked And stuffedButton.Checked Then
            totalPrice = smallSize + stuffedCrust
            orderText = "Size: Small" & vbNewLine & "Crust: Stuffed" & vbNewLine & "Toppings:" & vbNewLine
        ElseIf mediumButton.Checked And thinButton.Checked Then
            totalPrice = mediumSize + thinCrust
            orderText = "Size: Medium" & vbNewLine & "Crust: Thin" & vbNewLine & "Toppings:" & vbNewLine
        ElseIf mediumButton.Checked And thickButton.Checked Then
            totalPrice = mediumSize + thickCrust
            orderText = "Size: Medium" & vbNewLine & "Crust: Thick" & vbNewLine & "Toppings:" & vbNewLine
        ElseIf mediumButton.Checked And stuffedButton.Checked Then
            totalPrice = mediumSize + stuffedCrust
            orderText = "Size: Medium" & vbNewLine & "Crust: Stuffed" & vbNewLine & "Toppings:" & vbNewLine
        ElseIf largeButton.Checked And thinButton.Checked Then
            totalPrice = largeSize + thinCrust
            orderText = "Size: Large" & vbNewLine & "Crust: Thin" & vbNewLine & "Toppings:" & vbNewLine
        ElseIf largeButton.Checked And thickButton.Checked Then
            totalPrice = largeSize + thickCrust
            orderText = "Size: Large" & vbNewLine & "Crust: Thick" & vbNewLine & "Toppings:" & vbNewLine
        ElseIf largeButton.Checked And stuffedButton.Checked Then
            totalPrice = largeSize + stuffedCrust
            orderText = "Size: Large" & vbNewLine & "Crust: Stuffed" & vbNewLine & "Toppings:" & vbNewLine
        Else
            message = "Please select 1 size and 1 crust"
            MessageBox.Show(message)
            Exit Sub
        End If
        If pepperoniButton.Checked Then
            orderText = orderText & "+ Pepperoni" & vbNewLine
        End If
        If sausageButton.Checked Then
            orderText = orderText & "+ Sausage" & vbNewLine
        End If
        If hamButton.Checked Then
            orderText = orderText & "+ Ham" & vbNewLine
        End If
        If olivesButton.Checked Then
            orderText = orderText & "+ Black Olives" & vbNewLine
        End If
        If pineappleButton.Checked Then
            orderText = orderText & "+ Pineapple" & vbNewLine
        End If
        If onionsButton.Checked Then
            orderText = orderText & "+ Onions" & vbNewLine
        End If
        If pepperoniButton.Checked Then
            orderText = orderText & "+ Green Peppers" & vbNewLine
        End If
        If mushroomsButton.Checked Then
            orderText = orderText & "+ Mushrooms" & vbNewLine
        End If
        CheckoutForm.ShowDialog()

    End Sub

    Private Sub allToppingsButton_Click(sender As Object, e As EventArgs) Handles allToppingsButton.Click
        'check all toppings

        pepperoniButton.Checked = True
        sausageButton.Checked = True
        hamButton.Checked = True
        olivesButton.Checked = True
        pineappleButton.Checked = True
        peppersButton.Checked = True
        onionsButton.Checked = True
        mushroomsButton.Checked = True

    End Sub

    Private Sub clearToppingsButton_Click(sender As Object, e As EventArgs) Handles clearToppingsButton.Click
        'uncheck all toppings

        pepperoniButton.Checked = False
        sausageButton.Checked = False
        hamButton.Checked = False
        olivesButton.Checked = False
        pineappleButton.Checked = False
        peppersButton.Checked = False
        onionsButton.Checked = False
        mushroomsButton.Checked = False
    End Sub

End Class