Public Class TimePanel


    Public Sub New()

        InitializeComponent()

        MOnes.Digit = 0
        MTens.Digit = 0
        HOnes.Digit = 0
        HTens.Digit = 0

        MOnes.MaxDigit = 10
        MTens.MaxDigit = 6
        HOnes.MaxDigit = 10
        HTens.MaxDigit = 2

    End Sub

    Private Sub Reset()
        MOnes.Digit = 0
        MTens.Digit = 0
        HOnes.Digit = 0
        HTens.Digit = 0
    End Sub

    Private Sub RESET_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Me.Time = Date.Now
    End Sub

    Private Sub SetButton_Click(sender As Object, e As EventArgs) Handles SetButton.Click
        Me.Time = #00:00:00#
    End Sub

    Public Property Time() As Date
        Get
            Dim test = #07:04:23#
            Return test
        End Get
        Set(value As Date)
            Console.WriteLine(value)
            Dim hour, minute, mer
            hour = value.Hour
            minute = value.Minute
            mer = value.ToString("tt")
            If hour > 12 Then
                hour = hour - 12
            End If
            If hour > 9 Then
                HTens.Digit = 1
                HOnes.Digit = hour Mod 10
            Else
                HTens.Digit = 0
                HOnes.Digit = hour
            End If
            MTens.Digit = minute \ 10
            MOnes.Digit = minute Mod 10
            If mer.Equals("AM") Then
                AMButton.Checked = True
            Else
                PMButton.Checked = True
            End If
        End Set
    End Property
End Class
