Class MainWindow
    Private currentInput As String = ""
    Private operand1 As Double = 0
    Private operand2 As Double = 0
    Private operation As String = ""

    ' Handles number and decimal button clicks
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim button As Button = CType(sender, Button)
        currentInput &= button.Content.ToString()
        Display.Text = currentInput
    End Sub

    ' Handles operator buttons (+, -, *, /)
    Private Sub OperatorButton_Click(sender As Object, e As RoutedEventArgs)
        Dim button As Button = CType(sender, Button)
        If currentInput <> "" Then
            operand1 = Double.Parse(currentInput)
        End If
        operation = button.Content.ToString()
        currentInput = ""
    End Sub

    ' Handles the Equal button
    Private Sub EqualButton_Click(sender As Object, e As RoutedEventArgs)
        If currentInput <> "" Then
            operand2 = Double.Parse(currentInput)
        End If

        Select Case operation
            Case "+"
                Display.Text = (operand1 + operand2).ToString()
            Case "-"
                Display.Text = (operand1 - operand2).ToString()
            Case "*"
                Display.Text = (operand1 * operand2).ToString()
            Case "/"
                If operand2 <> 0 Then
                    Display.Text = (operand1 / operand2).ToString()
                Else
                    Display.Text = "Error"
                End If
        End Select
        currentInput = ""
    End Sub

    ' Handles the Clear button
    Private Sub ClearButton_Click(sender As Object, e As RoutedEventArgs)
        currentInput = ""
        operand1 = 0
        operand2 = 0
        operation = ""
        Display.Text = ""
    End Sub
End Class
