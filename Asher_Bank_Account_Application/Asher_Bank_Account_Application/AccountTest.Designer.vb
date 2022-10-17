<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountTest
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
        Me.inputTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.depositButton = New System.Windows.Forms.Button()
        Me.withdrawButton = New System.Windows.Forms.Button()
        Me.accountBalanceValueLabel = New System.Windows.Forms.Label()
        Me.accountBalanceValueTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'inputTextBox
        '
        Me.inputTextBox.Location = New System.Drawing.Point(290, 66)
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.Size = New System.Drawing.Size(100, 23)
        Me.inputTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter deposit or withdrawal amount:"
        '
        'depositButton
        '
        Me.depositButton.Location = New System.Drawing.Point(66, 117)
        Me.depositButton.Name = "depositButton"
        Me.depositButton.Size = New System.Drawing.Size(75, 23)
        Me.depositButton.TabIndex = 2
        Me.depositButton.Text = "Deposit"
        Me.depositButton.UseVisualStyleBackColor = True
        '
        'withdrawButton
        '
        Me.withdrawButton.Location = New System.Drawing.Point(196, 117)
        Me.withdrawButton.Name = "withdrawButton"
        Me.withdrawButton.Size = New System.Drawing.Size(75, 23)
        Me.withdrawButton.TabIndex = 3
        Me.withdrawButton.Text = "Withdraw"
        Me.withdrawButton.UseVisualStyleBackColor = True
        '
        'accountBalanceValueLabel
        '
        Me.accountBalanceValueLabel.AutoSize = True
        Me.accountBalanceValueLabel.Location = New System.Drawing.Point(175, 193)
        Me.accountBalanceValueLabel.Name = "accountBalanceValueLabel"
        Me.accountBalanceValueLabel.Size = New System.Drawing.Size(99, 15)
        Me.accountBalanceValueLabel.TabIndex = 4
        Me.accountBalanceValueLabel.Text = "Account Balance:"
        '
        'accountBalanceValueTextBox
        '
        Me.accountBalanceValueTextBox.Enabled = False
        Me.accountBalanceValueTextBox.Location = New System.Drawing.Point(290, 185)
        Me.accountBalanceValueTextBox.Name = "accountBalanceValueTextBox"
        Me.accountBalanceValueTextBox.Size = New System.Drawing.Size(100, 23)
        Me.accountBalanceValueTextBox.TabIndex = 5
        '
        'AccountTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 231)
        Me.Controls.Add(Me.accountBalanceValueTextBox)
        Me.Controls.Add(Me.accountBalanceValueLabel)
        Me.Controls.Add(Me.withdrawButton)
        Me.Controls.Add(Me.depositButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inputTextBox)
        Me.Name = "AccountTest"
        Me.Text = "AccountTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inputTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents depositButton As Button
    Friend WithEvents withdrawButton As Button
    Friend WithEvents accountBalanceValueLabel As Label
    Friend WithEvents accountBalanceValueTextBox As TextBox
End Class
