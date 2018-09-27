Public Class DigitLED
    Inherits Label

    Private _digit As Integer
    Private _max As Integer

    Public WriteOnly Property MaxDigit() As Integer
        Set(value As Integer)
            _max = value
        End Set
    End Property

    Public Property Digit() As Integer
        Get
            Return _digit
        End Get
        Set(value As Integer)
            If value >= _max Then
                _digit = 0
            Else
                _digit = Convert.ToInt32(value)
            End If
            Me.Text = Convert.ToString(_digit)
        End Set
    End Property

End Class
