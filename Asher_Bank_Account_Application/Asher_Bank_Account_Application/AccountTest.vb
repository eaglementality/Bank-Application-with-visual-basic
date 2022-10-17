Public Class AccountTest
    Private account As New Account()
    Private Sub AccountTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim AaccountBalanceValueLabel As Object = Nothing
        accountBalanceValueTextBox.Text = String.Format("{0:C}", account.Balance)
    End Sub


    Private Sub depositButton_Click(sender As Object, e As EventArgs) Handles depositButton.Click
        Try
            '(inputTextBox.Text = "") Then
            '                MessageBox.Show("Enter Deposit Amount", "Error", MessageBoxButtons.OK,
            'MessageBoxIcon.Error)
            '                inputTextBox.Focus()

            If (inputTextBox.Text = "" Or inputTextBox.Text = ".") Then
                MessageBox.Show("Enter amount to deposit.", "Deposit Alert", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

                inputTextBox.Focus()

            ElseIf (inputTextBox.Text.Contains("Q") Or inputTextBox.Text.Contains("q") Or inputTextBox.Text.Contains("W") Or inputTextBox.Text.Contains("w") Or
                inputTextBox.Text.Contains("E") Or inputTextBox.Text.Contains("e") Or inputTextBox.Text.Contains("R") Or inputTextBox.Text.Contains("r") Or
                inputTextBox.Text.Contains("T") Or inputTextBox.Text.Contains("t") Or inputTextBox.Text.Contains("Y") Or inputTextBox.Text.Contains("y") Or
                inputTextBox.Text.Contains("U") Or inputTextBox.Text.Contains("u") Or inputTextBox.Text.Contains("I") Or inputTextBox.Text.Contains("i") Or
                inputTextBox.Text.Contains("O") Or inputTextBox.Text.Contains("o") Or inputTextBox.Text.Contains("P") Or inputTextBox.Text.Contains("p") Or
                inputTextBox.Text.Contains("A") Or inputTextBox.Text.Contains("a") Or inputTextBox.Text.Contains("S") Or inputTextBox.Text.Contains("s") Or
                inputTextBox.Text.Contains("D") Or inputTextBox.Text.Contains("d") Or inputTextBox.Text.Contains("F") Or inputTextBox.Text.Contains("f") Or
                inputTextBox.Text.Contains("G") Or inputTextBox.Text.Contains("g") Or inputTextBox.Text.Contains("H") Or inputTextBox.Text.Contains("h") Or
                inputTextBox.Text.Contains("J") Or inputTextBox.Text.Contains("j") Or inputTextBox.Text.Contains("K") Or inputTextBox.Text.Contains("k") Or
                inputTextBox.Text.Contains("L") Or inputTextBox.Text.Contains("l") Or inputTextBox.Text.Contains("Z") Or inputTextBox.Text.Contains("z") Or
                inputTextBox.Text.Contains("X") Or inputTextBox.Text.Contains("x") Or inputTextBox.Text.Contains("C") Or inputTextBox.Text.Contains("c") Or
                inputTextBox.Text.Contains("V") Or inputTextBox.Text.Contains("v") Or inputTextBox.Text.Contains("B") Or inputTextBox.Text.Contains("b") Or
                inputTextBox.Text.Contains("N") Or inputTextBox.Text.Contains("n") Or inputTextBox.Text.Contains("M") Or inputTextBox.Text.Contains("m") Or
                inputTextBox.Text.Contains("!") Or inputTextBox.Text.Contains("@") Or inputTextBox.Text.Contains("#") Or inputTextBox.Text.Contains("$") Or
                inputTextBox.Text.Contains("%") Or inputTextBox.Text.Contains("=") Or inputTextBox.Text.Contains("^") Or inputTextBox.Text.Contains("+") Or
                inputTextBox.Text.Contains("&") Or inputTextBox.Text.Contains("{") Or inputTextBox.Text.Contains("*") Or inputTextBox.Text.Contains("}") Or
                inputTextBox.Text.Contains("(") Or inputTextBox.Text.Contains("[") Or inputTextBox.Text.Contains(")") Or inputTextBox.Text.Contains("]") Or
                inputTextBox.Text.Contains("_") Or inputTextBox.Text.Contains("\") Or inputTextBox.Text.Contains("-") Or inputTextBox.Text.Contains("|") Or
                inputTextBox.Text.Contains(";") Or inputTextBox.Text.Contains(":") Or inputTextBox.Text.Contains(",") Or inputTextBox.Text.Contains("'") Or
                inputTextBox.Text.Contains("?") Or inputTextBox.Text.Contains(">") Or inputTextBox.Text.Contains("<") Or inputTextBox.Text.Contains("/")
                ) Then
                MessageBox.Show("Invalid input!. Enter amount to deposit", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

                inputTextBox.Clear()
                inputTextBox.Focus()

            Else
                Dim depositAmount As Decimal = Convert.ToDecimal(inputTextBox.Text)
                account.Deposit(depositAmount)
                'accountBalanceValueTextBox.Text
                accountBalanceValueTextBox.Text = String.Format("{0:C}", account.Balance)
            End If


            'Dim depositAmount As Decimal = Convert.ToDecimal(inputTextBox.Text)
            'account.Deposit(depositAmount)
            ''accountBalanceValueTextBox.Text
            'accountBalanceValueTextBox.Text = String.Format("{0:C}", account.Balance)
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("Deposite amount must be positive.", "Error", MessageBoxButtons.OK,
MessageBoxIcon.Error)

        End Try
        inputTextBox.Clear()
        inputTextBox.Focus()
    End Sub

    Private Sub withdrawButton_Click(sender As Object, e As EventArgs) Handles withdrawButton.Click
        Try
            If (inputTextBox.Text = "" Or inputTextBox.Text = ".") Then
                MessageBox.Show("Enter amount to withdraw.", "Withdrawal Alert", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

                inputTextBox.Focus()
            ElseIf (inputTextBox.Text.Contains("Q") Or inputTextBox.Text.Contains("q") Or inputTextBox.Text.Contains("W") Or inputTextBox.Text.Contains("w") Or
                inputTextBox.Text.Contains("E") Or inputTextBox.Text.Contains("e") Or inputTextBox.Text.Contains("R") Or inputTextBox.Text.Contains("r") Or
                inputTextBox.Text.Contains("T") Or inputTextBox.Text.Contains("t") Or inputTextBox.Text.Contains("Y") Or inputTextBox.Text.Contains("y") Or
                inputTextBox.Text.Contains("U") Or inputTextBox.Text.Contains("u") Or inputTextBox.Text.Contains("I") Or inputTextBox.Text.Contains("i") Or
                inputTextBox.Text.Contains("O") Or inputTextBox.Text.Contains("o") Or inputTextBox.Text.Contains("P") Or inputTextBox.Text.Contains("p") Or
                inputTextBox.Text.Contains("A") Or inputTextBox.Text.Contains("a") Or inputTextBox.Text.Contains("S") Or inputTextBox.Text.Contains("s") Or
                inputTextBox.Text.Contains("D") Or inputTextBox.Text.Contains("d") Or inputTextBox.Text.Contains("F") Or inputTextBox.Text.Contains("f") Or
                inputTextBox.Text.Contains("G") Or inputTextBox.Text.Contains("g") Or inputTextBox.Text.Contains("H") Or inputTextBox.Text.Contains("h") Or
                inputTextBox.Text.Contains("J") Or inputTextBox.Text.Contains("j") Or inputTextBox.Text.Contains("K") Or inputTextBox.Text.Contains("k") Or
                inputTextBox.Text.Contains("L") Or inputTextBox.Text.Contains("l") Or inputTextBox.Text.Contains("Z") Or inputTextBox.Text.Contains("z") Or
                inputTextBox.Text.Contains("X") Or inputTextBox.Text.Contains("x") Or inputTextBox.Text.Contains("C") Or inputTextBox.Text.Contains("c") Or
                inputTextBox.Text.Contains("V") Or inputTextBox.Text.Contains("v") Or inputTextBox.Text.Contains("B") Or inputTextBox.Text.Contains("b") Or
                inputTextBox.Text.Contains("N") Or inputTextBox.Text.Contains("n") Or inputTextBox.Text.Contains("M") Or inputTextBox.Text.Contains("m") Or
                inputTextBox.Text.Contains("!") Or inputTextBox.Text.Contains("@") Or inputTextBox.Text.Contains("#") Or inputTextBox.Text.Contains("$") Or
                inputTextBox.Text.Contains("%") Or inputTextBox.Text.Contains("=") Or inputTextBox.Text.Contains("^") Or inputTextBox.Text.Contains("+") Or
                inputTextBox.Text.Contains("&") Or inputTextBox.Text.Contains("{") Or inputTextBox.Text.Contains("*") Or inputTextBox.Text.Contains("}") Or
                inputTextBox.Text.Contains("(") Or inputTextBox.Text.Contains("[") Or inputTextBox.Text.Contains(")") Or inputTextBox.Text.Contains("]") Or
                inputTextBox.Text.Contains("_") Or inputTextBox.Text.Contains("\") Or inputTextBox.Text.Contains("-") Or inputTextBox.Text.Contains("|") Or
                inputTextBox.Text.Contains(";") Or inputTextBox.Text.Contains(":") Or inputTextBox.Text.Contains(",") Or inputTextBox.Text.Contains("'") Or
                inputTextBox.Text.Contains("?") Or inputTextBox.Text.Contains(">") Or inputTextBox.Text.Contains("<") Or inputTextBox.Text.Contains("/")
                ) Then
                MessageBox.Show("Invalid input!. Enter amount to deposit", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

                inputTextBox.Clear()
                inputTextBox.Focus()

            Else
                Dim depositAmount As Decimal = Convert.ToDecimal(inputTextBox.Text)
                account.Withdrawal(depositAmount)
                'accountBalanceValueTextBox.Text
                accountBalanceValueTextBox.Text = String.Format("{0:C}", account.Balance)
            End If
            'Dim withdrawalAmount As Decimal = Convert.ToDecimal(inputTextBox.Text)
            'account.Withdrawal(withdrawalAmount)
            'accountBalanceValueTextBox.Text = String.Format("{0:C}", account.Balance)
        Catch ex As ArgumentOutOfRangeException

            MessageBox.Show("Withdrawal amount must be greater than 0 " & "and less than 
or qual to the account balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        inputTextBox.Clear()
        inputTextBox.Focus()
    End Sub
End Class