Public Class Account
    Private balanceValue As Decimal
    Public Sub New(Optional initialBalance As Decimal = 0D)
        If initialBalance < 0D Then
            Throw New ArgumentOutOfRangeException(
                "Initial balance must be >= 0")
        End If

        balanceValue = initialBalance
    End Sub

    Public Sub Deposit(depositAmount As Decimal)
        If depositAmount <= 0D Then
            Throw New ArgumentOutOfRangeException(
                "Deposit must be > 0")
        End If

        balanceValue += depositAmount
    End Sub

    Public ReadOnly Property Balance As Decimal
        Get
            Return balanceValue
        End Get
    End Property

    Public Sub Withdrawal(withdrawalAmount As Decimal)
        If withdrawalAmount > Balance Then
            Throw New ArgumentOutOfRangeException(
                "Withdrawal amount must be <= Balance")
        ElseIf withdrawalAmount <= 0D Then
            Throw New ArgumentOutOfRangeException(
                "Withdrawal amount must be > 0")
        End If
        balanceValue -= withdrawalAmount
    End Sub
End Class
