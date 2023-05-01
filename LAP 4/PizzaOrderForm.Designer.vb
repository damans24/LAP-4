<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.title = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.largeButton = New System.Windows.Forms.RadioButton()
        Me.mediumButton = New System.Windows.Forms.RadioButton()
        Me.smallButton = New System.Windows.Forms.RadioButton()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.stuffedButton = New System.Windows.Forms.RadioButton()
        Me.thickButton = New System.Windows.Forms.RadioButton()
        Me.thinButton = New System.Windows.Forms.RadioButton()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.mushroomsButton = New System.Windows.Forms.CheckBox()
        Me.peppersButton = New System.Windows.Forms.CheckBox()
        Me.onionsButton = New System.Windows.Forms.CheckBox()
        Me.pineappleButton = New System.Windows.Forms.CheckBox()
        Me.olivesButton = New System.Windows.Forms.CheckBox()
        Me.hamButton = New System.Windows.Forms.CheckBox()
        Me.sausageButton = New System.Windows.Forms.CheckBox()
        Me.pepperoniButton = New System.Windows.Forms.CheckBox()
        Me.checkoutButton = New System.Windows.Forms.Button()
        Me.allToppingsButton = New System.Windows.Forms.Button()
        Me.clearToppingsButton = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(25, 24)
        Me.title.Multiline = True
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(528, 54)
        Me.title.TabIndex = 0
        Me.title.Text = "Starving Students Pizza"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.largeButton)
        Me.groupBox1.Controls.Add(Me.mediumButton)
        Me.groupBox1.Controls.Add(Me.smallButton)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(25, 146)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(258, 212)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Size"
        '
        'largeButton
        '
        Me.largeButton.AutoSize = True
        Me.largeButton.Location = New System.Drawing.Point(30, 124)
        Me.largeButton.Name = "largeButton"
        Me.largeButton.Size = New System.Drawing.Size(137, 24)
        Me.largeButton.TabIndex = 2
        Me.largeButton.TabStop = True
        Me.largeButton.Text = "Large - $12.99"
        Me.largeButton.UseVisualStyleBackColor = True
        '
        'mediumButton
        '
        Me.mediumButton.AutoSize = True
        Me.mediumButton.Location = New System.Drawing.Point(30, 83)
        Me.mediumButton.Name = "mediumButton"
        Me.mediumButton.Size = New System.Drawing.Size(143, 24)
        Me.mediumButton.TabIndex = 1
        Me.mediumButton.TabStop = True
        Me.mediumButton.Text = "Medium - $9.99"
        Me.mediumButton.UseVisualStyleBackColor = True
        '
        'smallButton
        '
        Me.smallButton.AutoSize = True
        Me.smallButton.Location = New System.Drawing.Point(30, 39)
        Me.smallButton.Name = "smallButton"
        Me.smallButton.Size = New System.Drawing.Size(126, 24)
        Me.smallButton.TabIndex = 0
        Me.smallButton.TabStop = True
        Me.smallButton.Text = "Small - $7.99"
        Me.smallButton.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.stuffedButton)
        Me.groupBox2.Controls.Add(Me.thickButton)
        Me.groupBox2.Controls.Add(Me.thinButton)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(314, 146)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(277, 212)
        Me.groupBox2.TabIndex = 2
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Crust"
        '
        'stuffedButton
        '
        Me.stuffedButton.AutoSize = True
        Me.stuffedButton.Location = New System.Drawing.Point(25, 124)
        Me.stuffedButton.Name = "stuffedButton"
        Me.stuffedButton.Size = New System.Drawing.Size(174, 24)
        Me.stuffedButton.TabIndex = 3
        Me.stuffedButton.TabStop = True
        Me.stuffedButton.Text = "Stuffed (Add $2.00)"
        Me.stuffedButton.UseVisualStyleBackColor = True
        '
        'thickButton
        '
        Me.thickButton.AutoSize = True
        Me.thickButton.Location = New System.Drawing.Point(25, 83)
        Me.thickButton.Name = "thickButton"
        Me.thickButton.Size = New System.Drawing.Size(71, 24)
        Me.thickButton.TabIndex = 2
        Me.thickButton.TabStop = True
        Me.thickButton.Text = "Thick"
        Me.thickButton.UseVisualStyleBackColor = True
        '
        'thinButton
        '
        Me.thinButton.AutoSize = True
        Me.thinButton.Location = New System.Drawing.Point(25, 39)
        Me.thinButton.Name = "thinButton"
        Me.thinButton.Size = New System.Drawing.Size(64, 24)
        Me.thinButton.TabIndex = 1
        Me.thinButton.TabStop = True
        Me.thinButton.Text = "Thin"
        Me.thinButton.UseVisualStyleBackColor = True
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.mushroomsButton)
        Me.groupBox3.Controls.Add(Me.peppersButton)
        Me.groupBox3.Controls.Add(Me.onionsButton)
        Me.groupBox3.Controls.Add(Me.pineappleButton)
        Me.groupBox3.Controls.Add(Me.olivesButton)
        Me.groupBox3.Controls.Add(Me.hamButton)
        Me.groupBox3.Controls.Add(Me.sausageButton)
        Me.groupBox3.Controls.Add(Me.pepperoniButton)
        Me.groupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox3.Location = New System.Drawing.Point(616, 146)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(421, 212)
        Me.groupBox3.TabIndex = 3
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Toppings"
        '
        'mushroomsButton
        '
        Me.mushroomsButton.AutoSize = True
        Me.mushroomsButton.Location = New System.Drawing.Point(232, 166)
        Me.mushroomsButton.Name = "mushroomsButton"
        Me.mushroomsButton.Size = New System.Drawing.Size(118, 24)
        Me.mushroomsButton.TabIndex = 7
        Me.mushroomsButton.Text = "Mushrooms"
        Me.mushroomsButton.UseVisualStyleBackColor = True
        '
        'peppersButton
        '
        Me.peppersButton.AutoSize = True
        Me.peppersButton.Location = New System.Drawing.Point(232, 124)
        Me.peppersButton.Name = "peppersButton"
        Me.peppersButton.Size = New System.Drawing.Size(143, 24)
        Me.peppersButton.TabIndex = 6
        Me.peppersButton.Text = "Green Peppers"
        Me.peppersButton.UseVisualStyleBackColor = True
        '
        'onionsButton
        '
        Me.onionsButton.AutoSize = True
        Me.onionsButton.Location = New System.Drawing.Point(232, 83)
        Me.onionsButton.Name = "onionsButton"
        Me.onionsButton.Size = New System.Drawing.Size(85, 24)
        Me.onionsButton.TabIndex = 5
        Me.onionsButton.Text = "Onions"
        Me.onionsButton.UseVisualStyleBackColor = True
        '
        'pineappleButton
        '
        Me.pineappleButton.AutoSize = True
        Me.pineappleButton.Location = New System.Drawing.Point(232, 39)
        Me.pineappleButton.Name = "pineappleButton"
        Me.pineappleButton.Size = New System.Drawing.Size(105, 24)
        Me.pineappleButton.TabIndex = 4
        Me.pineappleButton.Text = "Pineapple"
        Me.pineappleButton.UseVisualStyleBackColor = True
        '
        'olivesButton
        '
        Me.olivesButton.AutoSize = True
        Me.olivesButton.Location = New System.Drawing.Point(39, 166)
        Me.olivesButton.Name = "olivesButton"
        Me.olivesButton.Size = New System.Drawing.Size(120, 24)
        Me.olivesButton.TabIndex = 3
        Me.olivesButton.Text = "Black Olives"
        Me.olivesButton.UseVisualStyleBackColor = True
        '
        'hamButton
        '
        Me.hamButton.AutoSize = True
        Me.hamButton.Location = New System.Drawing.Point(39, 125)
        Me.hamButton.Name = "hamButton"
        Me.hamButton.Size = New System.Drawing.Size(69, 24)
        Me.hamButton.TabIndex = 2
        Me.hamButton.Text = "Ham"
        Me.hamButton.UseVisualStyleBackColor = True
        '
        'sausageButton
        '
        Me.sausageButton.AutoSize = True
        Me.sausageButton.Location = New System.Drawing.Point(39, 84)
        Me.sausageButton.Name = "sausageButton"
        Me.sausageButton.Size = New System.Drawing.Size(99, 24)
        Me.sausageButton.TabIndex = 1
        Me.sausageButton.Text = "Sausage"
        Me.sausageButton.UseVisualStyleBackColor = True
        '
        'pepperoniButton
        '
        Me.pepperoniButton.AutoSize = True
        Me.pepperoniButton.Location = New System.Drawing.Point(39, 39)
        Me.pepperoniButton.Name = "pepperoniButton"
        Me.pepperoniButton.Size = New System.Drawing.Size(107, 24)
        Me.pepperoniButton.TabIndex = 0
        Me.pepperoniButton.Text = "Pepperoni"
        Me.pepperoniButton.UseVisualStyleBackColor = True
        '
        'checkoutButton
        '
        Me.checkoutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkoutButton.Location = New System.Drawing.Point(55, 377)
        Me.checkoutButton.Name = "checkoutButton"
        Me.checkoutButton.Size = New System.Drawing.Size(186, 46)
        Me.checkoutButton.TabIndex = 4
        Me.checkoutButton.Text = "Checkout"
        Me.checkoutButton.UseVisualStyleBackColor = True
        '
        'allToppingsButton
        '
        Me.allToppingsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allToppingsButton.Location = New System.Drawing.Point(616, 377)
        Me.allToppingsButton.Name = "allToppingsButton"
        Me.allToppingsButton.Size = New System.Drawing.Size(207, 46)
        Me.allToppingsButton.TabIndex = 5
        Me.allToppingsButton.Text = "Add All Toppings"
        Me.allToppingsButton.UseVisualStyleBackColor = True
        '
        'clearToppingsButton
        '
        Me.clearToppingsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearToppingsButton.Location = New System.Drawing.Point(848, 377)
        Me.clearToppingsButton.Name = "clearToppingsButton"
        Me.clearToppingsButton.Size = New System.Drawing.Size(189, 46)
        Me.clearToppingsButton.TabIndex = 6
        Me.clearToppingsButton.Text = "Clear Toppings"
        Me.clearToppingsButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 450)
        Me.Controls.Add(Me.clearToppingsButton)
        Me.Controls.Add(Me.allToppingsButton)
        Me.Controls.Add(Me.checkoutButton)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.title)
        Me.Name = "Form1"
        Me.Text = "LAP 4 - Starving Students Pizza"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title As TextBox
    Friend WithEvents groupBox1 As GroupBox
    Friend WithEvents largeButton As RadioButton
    Friend WithEvents mediumButton As RadioButton
    Friend WithEvents smallButton As RadioButton
    Friend WithEvents groupBox2 As GroupBox
    Friend WithEvents stuffedButton As RadioButton
    Friend WithEvents thickButton As RadioButton
    Friend WithEvents thinButton As RadioButton
    Friend WithEvents groupBox3 As GroupBox
    Friend WithEvents mushroomsButton As CheckBox
    Friend WithEvents peppersButton As CheckBox
    Friend WithEvents onionsButton As CheckBox
    Friend WithEvents pineappleButton As CheckBox
    Friend WithEvents olivesButton As CheckBox
    Friend WithEvents hamButton As CheckBox
    Friend WithEvents sausageButton As CheckBox
    Friend WithEvents pepperoniButton As CheckBox
    Friend WithEvents checkoutButton As Button
    Friend WithEvents allToppingsButton As Button
    Friend WithEvents clearToppingsButton As Button
End Class
