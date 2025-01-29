Option Strict On
Imports System.Net.WebRequestMethods.Ftp
Imports System.IO
Imports System.Net
Public Module PublicInfo
    Public calculation As String = ""
    Public userEquation As String
    Public startValue, endValue, stepvalue As Double
    Public Const eValue As Double = 2.7182818284590451
    Public Const piValue As Double = 3.1415926535897931
    Const SuperscriptCharacters As String = "⁰¹²³⁴⁵⁶⁷⁸⁹⁺⁻˟ᐟ⁽⁾ᐢᵉˣˢⁱⁿᵃᵒᵗᶜˡᵍ·"
    Const NormalCharacters As String = "0123456789+-×/()πexsinaotclg."
    Structure Power
        Dim value As String
        Dim position As Integer
    End Structure
    Public Sub Upload()
        Dim ftpRequest As FtpWebRequest = DirectCast(WebRequest.Create("ftp://ftp.drivehq.com/Class.txt"), FtpWebRequest) 'Creating the web request
        ftpRequest.Credentials = New NetworkCredential("16ReedLew", "COOLCULATORS") 'Setting the username and password for the request
        ftpRequest.Method = UploadFile 'Setting the method of the request
        Dim ftpFile() As Byte = File.ReadAllBytes("Class.txt") 'Putting contents of text file into an array of bytes
        Dim ftpStream As Stream = ftpRequest.GetRequestStream() 'Creating the ftp stream
        ftpStream.Write(ftpFile, 0, ftpFile.Length) 'Writing the array of bytes to the stream
        ftpStream.Close() 'Closing the stream
        ftpStream.Dispose() 'Disposing of the stream
    End Sub
    Public Sub Download()
        Dim ftpOutput As Stream 'Creating the output stream
        Dim bytesIn As Integer
        Dim buffer(1023) As Byte
        Dim ftpRequest As FtpWebRequest = DirectCast(WebRequest.Create("ftp://ftp.drivehq.com/Class.txt"), FtpWebRequest) 'Creating the web request
        ftpRequest.Credentials = New NetworkCredential("16ReedLew", "COOLCULATORS") 'Setting the username and password for the request
        ftpRequest.Method = DownloadFile 'Setting the method for the request
        Dim ftpStream As Stream = ftpRequest.GetResponse.GetResponseStream() 'Creating the ftp stream
        ftpOutput = File.Create("Class.txt") 'Setting the output stream to the text file
        bytesIn = 1
        Do Until bytesIn < 1
            bytesIn = ftpStream.Read(buffer, 0, 1024) 'Reading and counting the bytes from the ftp stream into the buffer
            If bytesIn > 0 Then ftpOutput.Write(buffer, 0, bytesIn) 'Writing the contents of the buffer to the text file
        Loop
        ftpOutput.Close() 'Closing the output stream
        ftpStream.Close() 'Closing the ftp stream
    End Sub
    Public Function Calculate(ByVal expression As String) As String
        Dim operandQueue, operatorQueue As New Queue(Of String)
        Dim token As Integer = 0
        Dim currentNumber As String = ""
        Dim isDivide As Boolean
        Do Until token >= expression.Length 'Parsing each character
            If IsNumber(expression(token)) Then
                NumberCharacter(expression, currentNumber, token)
            ElseIf expression(token) = "×" Or expression(token) = "/" Then
                MultiplicationCharacter(expression, token, currentNumber, isDivide)
            ElseIf expression(token) = "+" Or expression(token) = "-" Then 'If + or -
                AdditionCharacter(expression, token, currentNumber, operandQueue, operatorQueue)
            ElseIf expression(token) = "(" Then 'If open bracket
                OpenBracketCharacter(expression, token, currentNumber, isDivide)
            ElseIf expression(token) = "s" Or expression(token) = "c" Or expression(token) = "t" Then 'if trig
                TrigCharacter(expression, token, currentNumber, isDivide)
            ElseIf expression(token) = "√" Then
                SquareRootCharacter(expression, token, currentNumber, isDivide)
            ElseIf expression(token) = "l" Then
                LogCharacter(expression, token, currentNumber, isDivide)
            ElseIf expression(token) = "π" Or expression(token) = "e" Then
                ConstantCharacter(expression, token, currentNumber, isDivide)
            ElseIf IsSuperscript(expression(token)) Then ' If indices
                SuperscriptCharacter(expression, token, currentNumber)
            Else
                Return "s" 'Return an appropriate error if invalid character is found
            End If
            token += 1
        Loop
        If currentNumber <> "" Then operandQueue.Enqueue(currentNumber) 'Enqueueing the last number
        Dim answer As String = operandQueue.Dequeue() 'Setting the answer to the first number
        For x = 1 To operatorQueue.Count 'Dequeueing and evaluating the numbers with each operator
            Select Case operatorQueue.Dequeue()
                Case "+" : answer = CStr(CDbl(answer) + CDbl(operandQueue.Dequeue()))
                Case "-" : answer = CStr(CDbl(answer) - CDbl(operandQueue.Dequeue()))
            End Select
        Next
        If answer = "∞" Or answer = "NaN" Then answer = "i" 'Returning appropriate error if calculation is mathematically invalid
        Return answer
    End Function
    Sub NumberCharacter(ByRef expression As String, ByRef currentNumber As String, ByRef token As Integer)
        If token > 0 AndAlso expression(token - 1) = ")" Then
            expression = expression.Insert(token, "×")
            token -= 1
        Else
            currentNumber &= expression(token) 'Adding the numerical character to the current number
        End If
    End Sub
    Sub MultiplicationCharacter(ByRef expression As String, ByRef token As Integer, ByRef currentNumber As String, ByRef isDivide As Boolean)
        Select Case expression(token) 'Setting the multiplication to the appropriate function
            Case "×"c : isDivide = False
            Case "/"c : isDivide = True
        End Select
        If IsNumeric(expression(token + 1)) Then  'Checking if the next character is a number
            Dim temporaryQueue As String = ""
            Dim temporaryToken As Integer = token + 1
            Do Until temporaryToken = expression.Length OrElse Not IsNumber(expression(temporaryToken)) And Not IsSuperscript(expression(temporaryToken))
                temporaryQueue &= expression(temporaryToken) 'Building the queue
                temporaryToken += 1
            Loop
            Select Case expression(token) 'Evaluating the multiplication function
                Case "×"c : currentNumber = CStr(CDbl(currentNumber) * CDbl(Calculate(temporaryQueue)))
                Case "/"c : currentNumber = CStr(CDbl(currentNumber) / CDbl(Calculate(temporaryQueue)))
            End Select
            token += temporaryQueue.Length
        End If
    End Sub
    Sub AdditionCharacter(ByRef expression As String, ByRef token As Integer, ByRef currentNumber As String, ByRef operandQueue As Queue(Of String), ByRef operatorQueue As Queue(Of String))
        If IsMinus(expression, token) Then
            currentNumber = "-"
        Else
            operandQueue.Enqueue(currentNumber) 'Enqueueing the current number to the number queue
            currentNumber = ""
            operatorQueue.Enqueue(expression(token)) 'Enqueueing the current operator to the operator queue
        End If
    End Sub
    Sub OpenBracketCharacter(ByRef expression As String, ByRef token As Integer, ByRef currentNumber As String, ByRef isDivide As Boolean)
        Dim temporaryQueue As String = ""
        Dim temporaryToken As Integer = token + 1
        Dim bracketCount As Integer = 1
        CountBrackets(expression, temporaryToken, bracketCount)
        temporaryToken = token + 1
        BuildQueue(expression, temporaryToken, bracketCount, temporaryQueue)
        token += temporaryQueue.Length + 1
        If temporaryToken < expression.Length AndAlso IsSuperscript(expression(temporaryToken)) Then 'Check if there is a power to the contents of the brackets
            Dim superscriptQueue As String = ""
            BuildSuperscriptQueue(expression, superscriptQueue, temporaryToken, token)
            temporaryQueue = CStr(CDbl(Calculate(temporaryQueue)) ^ CDbl(Calculate(superscriptQueue))) 'Evaluating the brackets with its power
        Else
            temporaryQueue = Calculate(temporaryQueue)
        End If
        EvaluateCurrentNumber(currentNumber, temporaryQueue, isDivide)
    End Sub
    Sub TrigCharacter(ByRef expression As String, ByRef token As Integer, ByRef currentNumber As String, ByRef isDivide As Boolean)
        Dim trigFunction As String = expression(token)
        Dim temporaryQueue As String = ""
        token += 4
        Dim temporaryToken As Integer = token
        Dim bracketCount As Integer = 1
        CountBrackets(expression, temporaryToken, bracketCount)
        temporaryToken = token
        BuildQueue(expression, temporaryToken, bracketCount, temporaryQueue)
        token += temporaryQueue.Length
        If temporaryToken < expression.Length AndAlso IsSuperscript(expression(temporaryToken)) Then 'Check if there is a power to the trig function
            Dim superscriptQueue As String = ""
            BuildSuperscriptQueue(expression, superscriptQueue, temporaryToken, token)
            temporaryQueue = CStr(CDbl(CalculateTrig(temporaryQueue, trigFunction)) ^ CDbl(Calculate(superscriptQueue))) 'Evaluating the trig function with its power
        Else
            temporaryQueue = CalculateTrig(temporaryQueue, trigFunction)
        End If
        EvaluateCurrentNumber(currentNumber, temporaryQueue, isDivide)
    End Sub
    Sub SquareRootCharacter(ByRef expression As String, ByRef token As Integer, ByRef currentNumber As String, ByRef isDivide As Boolean)
        Dim temporaryQueue As String = ""
        Dim temporaryToken As Integer = token + 2
        Dim bracketCount As Integer = 1
        CountBrackets(expression, temporaryToken, bracketCount)
        temporaryToken = token + 2
        BuildQueue(expression, temporaryToken, bracketCount, temporaryQueue)
        token += temporaryQueue.Length + 3
        If temporaryToken < expression.Length AndAlso IsSuperscript(expression(temporaryToken)) Then 'Check if there is a power to the squareroot function
            Dim superscriptQueue As String = ""
            BuildSuperscriptQueue(expression, superscriptQueue, temporaryToken, token)
            temporaryQueue = CStr(Math.Sqrt(CDbl(Calculate(temporaryQueue))) ^ CDbl(superscriptQueue)) 'Evaluating the squareroot function with its power
        Else
            temporaryQueue = CStr(Math.Sqrt(CDbl(Calculate(temporaryQueue))))
        End If
        EvaluateCurrentNumber(currentNumber, temporaryQueue, isDivide)
    End Sub
    Sub LogCharacter(ByRef expression As String, ByRef token As Integer, ByRef currentNumber As String, ByRef isDivide As Boolean)
        Dim isLn As Boolean
        Select Case expression(token + 1) 'Setting the appropriate base to the log function
            Case "n"c : isLn = True
            Case "o"c : isLn = False
        End Select
        Dim temporaryQueue As String = ""
        Dim bracketCount As Integer = 1
        Dim temporaryToken As Integer = token + 3
        If isLn = False Then temporaryToken += 1
        CountBrackets(expression, temporaryToken, bracketCount)
        temporaryToken = token + 3
        If isLn = False Then temporaryToken += 1
        token = temporaryToken
        BuildQueue(expression, temporaryToken, bracketCount, temporaryQueue)
        token += temporaryQueue.Length
        If temporaryToken < expression.Length AndAlso IsSuperscript(expression(temporaryToken)) Then 'Checking if there is a power to the log function
            Dim superscriptQueue As String = ""
            BuildSuperscriptQueue(expression, superscriptQueue, temporaryToken, token)
            temporaryQueue = CStr(CDbl(CalculateLog(temporaryQueue, isLn)) ^ CDbl(Calculate(superscriptQueue))) 'Evaluating the log function with its power
        Else
            temporaryQueue = CalculateLog(temporaryQueue, isLn)
        End If
        EvaluateCurrentNumber(currentNumber, temporaryQueue, isDivide)
    End Sub
    Sub ConstantCharacter(ByRef expression As String, ByRef token As Integer, ByRef currentNumber As String, ByRef isDivide As Boolean)
        Dim temporaryQueue As String = ""
        Select Case expression(token) 'Setting the appropriate constant value
            Case "π"c : temporaryQueue = CStr(piValue)
            Case "e"c : temporaryQueue = CStr(eValue)
        End Select
        Dim temporaryToken As Integer = token + 1
        If temporaryToken < expression.Length AndAlso IsSuperscript(expression(temporaryToken)) Then 'Checking if the constant has a power
            Dim superscriptQueue As String = ""
            BuildSuperscriptQueue(expression, superscriptQueue, temporaryToken, token)
            temporaryQueue = CStr(CDbl(temporaryQueue) ^ CDbl(Calculate(superscriptQueue))) 'Evaluating the constant with its power
        End If
        EvaluateCurrentNumber(currentNumber, temporaryQueue, isDivide)
    End Sub
    Sub SuperscriptCharacter(ByRef expression As String, ByRef token As Integer, ByRef currentNumber As String)
        Dim superscriptQueue As String = ""
        Dim temporaryToken As Integer = token
        Do Until temporaryToken = expression.Length OrElse Not IsSuperscript(expression(temporaryToken))
            superscriptQueue &= ReverseSuperscript(expression(temporaryToken)) 'Building the queue for the power
            temporaryToken += 1
        Loop
        currentNumber = CStr(CDbl(currentNumber) ^ CDbl(Calculate(superscriptQueue))) 'Evaluating the current number with its power
        token += superscriptQueue.Length - 1
    End Sub
    Sub CountBrackets(ByRef expression As String, ByRef temporaryToken As Integer, ByRef bracketCount As Integer)
        Dim closeBracketCount As Integer = 0
        Do Until closeBracketCount = bracketCount 'Counting the brackets until they equal
            If expression(temporaryToken) = "(" Then bracketCount += 1
            If expression(temporaryToken) = ")" Then closeBracketCount += 1
            temporaryToken += 1
        Loop
    End Sub
    Sub BuildQueue(ByRef expression As String, ByRef temporaryToken As Integer, ByRef bracketCount As Integer, ByRef temporaryQueue As String)
        For x = 1 To bracketCount 'Building the queue until the last bracket has reached
            Do Until expression(temporaryToken) = ")"
                temporaryQueue &= expression(temporaryToken)
                temporaryToken += 1
            Loop
            If x < bracketCount Then temporaryQueue &= ")" 'Checking if the last bracket is reached
            temporaryToken += 1
        Next
    End Sub
    Sub BuildSuperscriptQueue(ByRef expression As String, ByRef superscriptQueue As String, ByRef temporaryToken As Integer, ByRef token As Integer)
        Do Until temporaryToken = expression.Length OrElse Not IsSuperscript(expression(temporaryToken))
            superscriptQueue &= ReverseSuperscript(expression(temporaryToken)) 'Adding the characters to the power queue
            temporaryToken += 1
        Loop
        token += superscriptQueue.Length
    End Sub
    Sub EvaluateCurrentNumber(ByRef currentNumber As String, ByRef temporaryQueue As String, ByRef isDivide As Boolean)
        If currentNumber <> "" Then 'Checking if there is a current number
            Select Case currentNumber
                Case "-" : currentNumber = CStr(-1 * CDbl(temporaryQueue)) 'Checking if the current number is a minus sign
                Case Else
                    Select Case isDivide 'Evaluating the queue with the current number with the appropriate multiplication function
                        Case False : currentNumber = CStr(CDbl(currentNumber) * CDbl(temporaryQueue))
                        Case True : currentNumber = CStr(CDbl(currentNumber) / CDbl(temporaryQueue))
                    End Select
            End Select
        Else
            currentNumber = temporaryQueue
        End If
    End Sub
    Function CalculateLog(ByVal temporaryQueue As String, ByVal isLn As Boolean) As String
        Select Case isLn 'Evaluating the log function with the appropriate base
            Case True : Return CStr(Math.Log(CDbl(Calculate(temporaryQueue))))
            Case Else : Return CStr(Math.Log10(CDbl(Calculate(temporaryQueue))))
        End Select
    End Function
    Function CalculateTrig(ByVal temporaryQueue As String, ByVal trigFunction As String) As String
        Select Case trigFunction 'Evaluating the appropriate trig function
            Case "s" : Return CStr(Math.Sin(CDbl(Calculate(temporaryQueue))))
            Case "c" : Return CStr(Math.Cos(CDbl(Calculate(temporaryQueue))))
            Case "t" : Return CStr(Math.Tan(CDbl(Calculate(temporaryQueue))))
            Case Else : Return "i"
        End Select
    End Function
    Function IsNumber(ByVal digit As String) As Boolean
        Select Case digit
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "." : Return True
        End Select
        Return False
    End Function
    Function IsMinus(ByVal expression As String, ByVal token As Integer) As Boolean
        If token = 0 And expression(token) = "-" Then 'Checking if the first character is a minus sign
            Return True
        ElseIf (Not IsNumber(expression(token - 1)) And Not IsNumber(ReverseSuperscript(expression(token - 1)))) And expression(token - 1) <> ")" And expression(token) = "-" Then 'Checking if the previous character is numerical
            Return True
        Else
            Return False
        End If
    End Function
    Function RemoveE(ByVal number As String) As String
        If number.Contains("E") Then
            Dim token As Integer = 0
            Dim finalNumber As String = ""
            Do Until number(token) = "E"
                finalNumber &= number(token) 'Building the final number until an E is reached
                token += 1
            Loop
            finalNumber &= "×10" 'Replacing the E with x10
            token += 1
            If number(token) = "+" Then 'Checking if the power is positive
                token += 1
            Else
                finalNumber &= "⁻"
                token += 1
            End If
            Do Until token = number.Length
                finalNumber &= Superscript(number(token)) 'Adding the power in superscript characters
                token += 1
            Loop
            Return finalNumber
        Else
            Return number
        End If
    End Function
    Function ReplaceX(ByVal expression As String, ByVal value As String) As String
        Dim token As Integer = 0
        Dim finalExpression As String = ""
        Do Until token = expression.Length OrElse (expression(token) = "x" Or expression(token) = "ˣ")
            finalExpression &= expression(token) 'Build the result until an x is reached
            token += 1
        Loop
        If finalExpression = expression Then Return expression 'Return the result if there was no x
        If expression(token) = "ˣ" Then
            finalExpression &= "⁽"
            For temporaryToken = 0 To value.Length - 1
                finalExpression &= Superscript(value(temporaryToken)) 'Add the value's characters in superscript to the result
            Next
            finalExpression &= "⁾"
        Else
            finalExpression &= "(" & value & ")" 'Add the value in brackets to the result
        End If
        token += 1
        Do Until token = expression.Length
            finalExpression &= expression(token) 'Add the rest of the expression to the result
            token += 1
        Loop
        If finalExpression.Contains("x") Or finalExpression.Contains("ˣ") Then finalExpression = ReplaceX(finalExpression, value) 'If there is still an x then recall the function
        Return finalExpression
    End Function
    Function Superscript(ByVal digit As String) As String
        If digit = "-" Then Return "⁻"
        If NormalCharacters.Contains(digit) Then
            Return SuperscriptCharacters(NormalCharacters.IndexOf(digit)) 'Return the corresponding index of the superscript characters string
        Else
            Return digit
        End If
    End Function
    Function ReverseSuperscript(ByVal digit As String) As String
        If digit = "⁻" Then Return "-"
        If SuperscriptCharacters.Contains(digit) Then
            Return NormalCharacters(SuperscriptCharacters.IndexOf(digit)) 'Return the corresponding index of the normal characters string
        Else
            Return digit
        End If
    End Function
    Function IsSuperscript(ByVal digit As String) As Boolean
        If SuperscriptCharacters.Contains(digit) Then 'Check if the character is in the superscript characters string
            Return True
        Else
            Return False
        End If
    End Function
    Function Differentiate(ByVal expression As String) As String
        expression = "diff(" & expression & ",x);"
        Dim outputArray As String() = GetOutputArray(expression)
        If outputArray(1)(2) = "i" Then
            Return RemoveSpaces(outputArray(0))
        Else
            Return ParseIndices(outputArray)
        End If
    End Function
    Function RemoveSpaces(ByVal expression As String) As String
        Dim finalExpression As String = ""
        Dim token As Integer = 5
        Do Until token = expression.Length
            If expression(token) <> " " Then finalExpression &= expression(token) 'Ignore space characters
            token += 1
        Loop
        If finalExpression.Contains("log") Then finalExpression = finalExpression.Replace("log", "ln")
        Return finalExpression
    End Function
    Function ConvertToMaximaForm(ByVal expression As String) As String
        Dim token As Integer = 0
        Dim finalExpression As String = ""
        Dim temporaryQueue As String = ""
        Do Until token >= expression.Length
            If token > 0 Then
                Select Case expression(token) 'Checks if a * needs to be added
                    Case "x"c, "("c, "s"c, "c"c, "t"c : If IsNumber(expression(token - 1)) Or expression(token - 1) = ")" Or expression(token - 1) = "x" Then finalExpression &= "*"
                End Select
            End If
            If IsSuperscript(expression(token)) Then 'Checks if a ^ needs to be added
                finalExpression &= "^("
                Do Until token >= expression.Length OrElse (Not IsSuperscript(expression(token)))
                    temporaryQueue &= ReverseSuperscript(expression(token)) 'Build the queue of the power
                    token += 1
                Loop
                finalExpression &= ConvertToMaximaForm(temporaryQueue) & ")" 'Recall the function for the power queue
                temporaryQueue = ""
            End If
            If token < expression.Length AndAlso expression(token) = "×" Then
                finalExpression &= "*" 'Replacing the times symbol with a *
            ElseIf token < expression.Length Then
                finalExpression &= expression(token) 'Add the rest of the characters to the result
            End If
            token += 1
        Loop
        Return finalExpression
    End Function
    Function GetOutputArray(ByVal expression As String) As String()
        Dim maxima As New Process()
        Dim output As String
        With maxima
            .StartInfo.FileName = "maxima-5.46.0\bin\maxima.bat" 'Loading the maxima software
            .StartInfo.UseShellExecute = False
            .StartInfo.RedirectStandardInput = True
            .StartInfo.RedirectStandardOutput = True
            .Start()
            .StandardInput.Write(expression) 'Write to the software
            .StandardInput.Close()
            output = .StandardOutput.ReadToEnd() 'Read from the software
            .WaitForExit()
        End With
        Dim outputArray(2) As String
        Dim token As Integer = 244 'Read from the first output line
        Dim lineNumber As Integer = 0
        Do Until token = output.Length OrElse (output(token) = vbLf And lineNumber = 1)
            If Not output(token) = vbLf Then
                outputArray(lineNumber) &= output(token) 'Build the output array with each line of the output
            Else
                lineNumber = 1 'Change to the second output line
            End If
            token += 1
        Loop
        Return outputArray
    End Function
    Function ParseIndices(ByVal outputArray As String()) As String
        Dim powerQueue As New Queue(Of Power)
        Dim temporaryPower As Power
        temporaryPower.value = ""
        Dim token As Integer = 0
        Dim finalExpression As String = ""
        Dim expression As String = outputArray(1)
        Do Until token = outputArray(0).Length
            Do Until outputArray(0)(token) <> " " 'Ignore initial spaces on the output line
                token += 1
            Loop
            temporaryPower.position = token 'Set power position to the current index
            Do Until token = outputArray(0).Length OrElse outputArray(0)(token) = " "
                temporaryPower.value &= outputArray(0)(token) 'Build the value of the power
                token += 1
            Loop
            powerQueue.Enqueue(temporaryPower) 'Enqueue the built power
            temporaryPower.value = ""
        Loop
        token = 0
        Dim powerValue As String
        For x = 0 To powerQueue.Count
            Do Until token = expression.Length
                finalExpression &= expression(token) 'Build final expression
                If expression(token) <> " " Then 'Check if there could be a power
                    If powerQueue.Count <> 0 AndAlso token = powerQueue.Peek.position - 1 Then 'Check if the position matches the position of the next power in the queue
                        powerValue = powerQueue.Dequeue.value
                        For y = 0 To powerValue.Length - 1
                            finalExpression &= Superscript(powerValue(y)) 'Add power to the expression in superscript characters
                        Next
                    End If
                End If
                token += 1
            Loop
        Next
        Return RemoveSpaces(finalExpression)
    End Function
End Module