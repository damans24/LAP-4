<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckoutForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.eatAtStoreLabel = New System.Windows.Forms.Label()
        Me.deliveryLabel = New System.Windows.Forms.Label()
        Me.pickupLabel = New System.Windows.Forms.Label()
        Me.eatAtStoreButton = New System.Windows.Forms.RadioButton()
        Me.deliveryButton = New System.Windows.Forms.RadioButton()
        Me.pickupButton = New System.Windows.Forms.RadioButton()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.pizzaOrderText = New System.Windows.Forms.TextBox()
        Me.pizzaOrderLabel = New System.Windows.Forms.Label()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.groupBox4.SuspendLayout()
        Me.groupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.eatAtStoreLabel)
        Me.groupBox4.Controls.Add(Me.deliveryLabel)
        Me.groupBox4.Controls.Add(Me.pickupLabel)
        Me.groupBox4.Controls.Add(Me.eatAtStoreButton)
        Me.groupBox4.Controls.Add(Me.deliveryButton)
        Me.groupBox4.Controls.Add(Me.pickupButton)
        Me.groupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox4.Location = New System.Drawing.Point(47, 51)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(393, 299)
        Me.groupBox4.TabIndex = 0
        Me.groupBox4.TabStop = False
        '
        'eatAtStoreLabel
        '
        Me.eatAtStoreLabel.Location = New System.Drawing.Point(253, 195)
        Me.eatAtStoreLabel.Name = "eatAtStoreLabel"
        Me.eatAtStoreLabel.Size = New System.Drawing.Size(108, 31)
        Me.eatAtStoreLabel.TabIndex = 5
        Me.eatAtStoreLabel.Text = "$0.00"
        '
        'deliveryLabel
        '
        Me.deliveryLabel.Location = New System.Drawing.Point(253, 123)
        Me.deliveryLabel.Name = "deliveryLabel"
        Me.deliveryLabel.Size = New System.Drawing.Size(108, 31)
        Me.deliveryLabel.TabIndex = 4
        Me.deliveryLabel.Text = "$0.00"
        '
        'pickupLabel
        '
        Me.pickupLabel.Location = New System.Drawing.Point(253, 55)
        Me.pickupLabel.Name = "pickupLabel"
        Me.pickupLabel.Size = New System.Drawing.Size(108, 31)
        Me.pickupLabel.TabIndex = 3
        Me.pickupLabel.Text = "$0.00"
        '
        'eatAtStoreButton
        '
        Me.eatAtStoreButton.AutoSize = True
        Me.eatAtStoreButton.Location = New System.Drawing.Point(41, 193)
        Me.eatAtStoreButton.Name = "eatAtStoreButton"
        Me.eatAtStoreButton.Size = New System.Drawing.Size(168, 33)
        Me.eatAtStoreButton.TabIndex = 2
        Me.eatAtStoreButton.TabStop = True
        Me.eatAtStoreButton.Text = "Eat at Store:"
        Me.eatAtStoreButton.UseVisualStyleBackColor = True
        '
        'deliveryButton
        '
        Me.deliveryButton.AutoSize = True
        Me.deliveryButton.Location = New System.Drawing.Point(41, 121)
        Me.deliveryButton.Name = "deliveryButton"
        Me.deliveryButton.Size = New System.Drawing.Size(174, 33)
        Me.deliveryButton.TabIndex = 1
        Me.deliveryButton.TabStop = True
        Me.deliveryButton.Text = "For Delivery:"
        Me.deliveryButton.UseVisualStyleBackColor = True
        '
        'pickupButton
        '
        Me.pickupButton.AutoSize = True
        Me.pickupButton.Location = New System.Drawing.Point(41, 53)
        Me.pickupButton.Name = "pickupButton"
        Me.pickupButton.Size = New System.Drawing.Size(206, 33)
        Me.pickupButton.TabIndex = 0
        Me.pickupButton.TabStop = True
        Me.pickupButton.Text = "Pickup at Store:"
        Me.pickupButton.UseVisualStyleBackColor = True
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.pizzaOrderText)
        Me.groupBox5.Controls.Add(Me.pizzaOrderLabel)
        Me.groupBox5.Location = New System.Drawing.Point(472, 51)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(426, 299)
        Me.groupBox5.TabIndex = 1
        Me.groupBox5.TabStop = False
        '
        'pizzaOrderText
        '
        Me.pizzaOrderText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pizzaOrderText.Location = New System.Drawing.Point(24, 69)
        Me.pizzaOrderText.Multiline = True
        Me.pizzaOrderText.Name = "pizzaOrderText"
        Me.pizzaOrderText.ReadOnly = True
        Me.pizzaOrderText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.pizzaOrderText.Size = New System.Drawing.Size(367, 205)
        Me.pizzaOrderText.TabIndex = 1
        '
        'pizzaOrderLabel
        '
        Me.pizzaOrderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pizzaOrderLabel.Location = New System.Drawing.Point(19, 22)
        Me.pizzaOrderLabel.Name = "pizzaOrderLabel"
        Me.pizzaOrderLabel.Size = New System.Drawing.Size(197, 44)
        Me.pizzaOrderLabel.TabIndex = 0
        Me.pizzaOrderLabel.Text = "Pizza Order"
        '
        'submitButton
        '
        Me.submitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitButton.Location = New System.Drawing.Point(431, 376)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(217, 52)
        Me.submitButton.TabIndex = 2
        Me.submitButton.Text = "Submit Order"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.Location = New System.Drawing.Point(681, 376)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(217, 52)
        Me.deleteButton.TabIndex = 3
        Me.deleteButton.Text = "Delete Order"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'CheckoutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 450)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.groupBox5)
        Me.Controls.Add(Me.groupBox4)
        Me.Name = "CheckoutForm"
        Me.Text = "CheckoutForm"
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents groupBox4 As GroupBox
    Friend WithEvents eatAtStoreLabel As Label
    Friend WithEvents deliveryLabel As Label
    Friend WithEvents pickupLabel As Label
    Friend WithEvents eatAtStoreButton As RadioButton
    Friend WithEvents deliveryButton As RadioButton
    Friend WithEvents pickupButton As RadioButton
    Friend WithEvents groupBox5 As GroupBox
    Friend WithEvents pizzaOrderText As TextBox
    Friend WithEvents pizzaOrderLabel As Label
    Friend WithEvents submitButton As Button
    Friend WithEvents deleteButton As Button
End Class
