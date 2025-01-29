Option Strict On
Public Class SIMPLEfrm
    Dim previousAnswer As String
    Structure [Operator]
        Dim character As Char
        Dim priority As Integer
    End Structure
    Private Sub SIMPLEfrm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar 'Comparing the inputting character with available valid characters
            Case "0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c, "."c, "+"c, "-"c : AddCharacter(e.KeyChar)
            Case "X"c, "x"c, "*"c : AddCharacter("×")
            Case "/"c : AddCharacter("÷")
            Case "C"c, "c"c : SimpleScreenlbl.Text = ""
            Case "A"c, "a"c : AddCharacter(previousAnswer)
            Case "="c, ChrW(Keys.Enter) : DisplayAns()
            Case ChrW(Keys.Back)
                If SimpleScreenlbl.Text.Length > 0 Then
                    SimpleScreenlbl.Text = SimpleScreenlbl.Text.Substring(0, SimpleScreenlbl.Text.Length - 1)
                End If
        End Select
    End Sub
    Private Sub Nlbl_Click(sender As Object, e As EventArgs) Handles N0lbl.Click, N1lbl.Click, N2lbl.Click, N3lbl.Click, N4lbl.Click, N5lbl.Click, N6lbl.Click, N7lbl.Click, N8lbl.Click, N9lbl.Click, Decimallbl.Click, Dividelbl.Click, Addlbl.Click, Multiplylbl.Click, Minuslbl.Click
        Dim labelClicked As Label = CType(sender, Label)
        AddCharacter(labelClicked.Text)
    End Sub
    Private Sub ANSlbl_Click(sender As Object, e As EventArgs) Handles ANSlbl.Click
        AddCharacter(previousAnswer)
    End Sub
    Sub AddCharacter(ByVal character As String)
        If SimpleScreenlbl.Text.Length <= 10 Then 'Checking if the character will fit on the screen
            SimpleScreenlbl.Text &= character
        End If
    End Sub
    Private Sub Clearlbl_Click(sender As Object, e As EventArgs) Handles Clearlbl.Click
        SimpleScreenlbl.Text = ""
    End Sub
    Private Sub Scientificlbl_Click(sender As Object, e As EventArgs) Handles Scientificlbl.Click
        COOLCULATORFfrm.Show()
        Hide()
    End Sub
    Private Sub Equalslbl_Click(sender As Object, e As EventArgs) Handles Equalslbl.Click
        DisplayAns()
    End Sub
    Sub DisplayAns()
        Dim result As String
        Try
            result = CalculateRPN(SimpleScreenlbl.Text)
            If result = "∞" Then
                MsgBox("MATH ERROR.",, "COOLCULATOR")
            Else
                SimpleScreenlbl.Text = result
                previousAnswer = SimpleScreenlbl.Text
            End If
        Catch ex As Exception
            MsgBox("SYTNAX ERROR.",, "COOLCULATOR") 'Display appropriate error if calculation of the user's expression fails
        End Try
    End Sub
    Function CreateRPN(ByVal expression As String) As String
        Dim operatorStack As New Stack(Of [Operator])
        Dim RPNExpression As String = ""
        Dim currentNumber As String = ""
        Dim currentOperator As [Operator]
        Dim token As Integer = 0
        Do Until token >= expression.Length
            If IsNumber(expression(token)) Then
                currentNumber &= expression(token) 'Adding every number to the current number
            ElseIf IsOperator(expression(token)) Then
                RPNExpression &= currentNumber & " " 'Seperating each entry to the final expression with a space
                currentNumber = ""
                currentOperator = CreateOperator(expression(token))
                While operatorStack.Count > 0 AndAlso (operatorStack.Peek.priority <= currentOperator.priority) 'Checking if operators in the stack need to be popped first
                    RPNExpression &= operatorStack.Pop.character 'Empty all operators with less or the same priority
                End While
                operatorStack.Push(currentOperator)
            End If
            token += 1
        Loop
        RPNExpression &= currentNumber & " " 'Add last number to final expression
        For y = 1 To operatorStack.Count
            RPNExpression &= operatorStack.Pop.character & " " 'Add any remaining operators
        Next
        Return RPNExpression.Substring(0, RPNExpression.Length - 1) 'Returning expression without final space character
    End Function
    Function CalculateRPN(ByVal expression As String) As String
        Dim RPNExpression As String = CreateRPN(expression)
        Dim token As Integer = 0
        Dim currentNumber As String = ""
        Dim numStack As New Stack(Of String)
        Dim number1, number2 As String
        Do Until token = RPNExpression.Length
            If IsNumber(RPNExpression(token)) Then
                currentNumber &= RPNExpression(token) 'Storing numbers in a temporary string
            ElseIf RPNExpression(token) = " " And currentNumber <> "" Then
                numStack.Push(currentNumber) 'Pushes the temporary number to the stack
                currentNumber = ""
            ElseIf IsOperator(RPNExpression(token)) Then
                number2 = numStack.Pop() 'Pop the top two numbers on the stack
                number1 = numStack.Pop()
                numStack.Push(GetAnswer(number1, number2, RPNExpression(token))) 'Push the result of the calculation onto the number stack
            End If
            token += 1
        Loop
        Return numStack.Pop()
    End Function
    Function GetAnswer(ByVal number1 As String, ByVal number2 As String, ByVal [operator] As Char) As String
        Select Case [operator] 'Returning the result of the calculation with the given operator and operands
            Case "+"c : Return CStr(CDbl(number1) + CDbl(number2))
            Case "-"c : Return CStr(CDbl(number1) - CDbl(number2))
            Case "×"c : Return CStr(CDbl(number1) * CDbl(number2))
            Case "÷"c : Return CStr(CDbl(number1) / CDbl(number2))
            Case Else : Return "s"
        End Select
    End Function
    Function CreateOperator(ByVal token As Char) As [Operator]
        Dim [operator] As [Operator]
        [operator].character = token
        Select Case token
            Case "+"c, "-"c
                [operator].priority = 2 'Assigns priority depending on the character
            Case Else
                [operator].priority = 1
        End Select
        Return [operator]
    End Function
    Function IsOperator(ByVal token As String) As Boolean
        Select Case token
            Case "+"c, "-"c, "÷"c, "×"c : Return True
        End Select
        Return False
    End Function
End Class