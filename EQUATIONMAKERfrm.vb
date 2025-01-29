Option Strict On
Public Class EQUATIONMAKERfrm
    Dim toSuperscript As Boolean = False
    Dim currentLabel As Label
    Private Sub EQUATIONMAKERfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentLabel = GraphTableExpressionlbl 'Set first label used for input as the graph/table one
        SolverCheck.Checked = False
        Cursorlbl.Location = New Point(GraphTableExpressionlbl.Location.X + 26, GraphTableExpressionlbl.Location.Y + 2) 'Set cursor to default position
        Cursorlbl.Font = New Font("Calibri", GraphTableExpressionlbl.Font.Size)
        KeyPreview = True
        Solvebtn.Hide() : LHSlbl.Hide() : RHSlbl.Hide() : Equalslbl.Hide() : LHSbtn.Hide() : RHSbtn.Hide() 'Hide all solving-related buttons and labels
    End Sub
    Private Sub EQUATIONMAKERfrm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar 'Compare the inputted character with valid characters
            Case "*"c : AddCharacter("×")
            Case "0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c, "/"c, "+"c, "-"c, "("c, ")"c, "."c : AddCharacter(e.KeyChar)
            Case "^"c
                If currentLabel.Text.Length > 0 Then
                    If Not toSuperscript Then
                        Cursorlbl.Font = New Font("Calibri", 20) 'Adjust cursor to superscript size
                    Else
                        Cursorlbl.Font = New Font("Calibri", GraphTableExpressionlbl.Font.Size) 'Adjust cursor to superscript location
                    End If
                    toSuperscript = Not toSuperscript
                End If
            Case ChrW(Keys.Back)
                Dim lengthToRemove As Integer = 1
                If currentLabel.Text.Length >= 3 Then 'Changing length of temporary string if there is a function
                    Select Case currentLabel.Text(currentLabel.Text.Length - 2)
                        Case "s"c, "ˢ"c, "n"c, "ⁿ"c : lengthToRemove = 4
                    End Select
                End If
                If currentLabel.Text.Length > 0 Then currentLabel.Text = currentLabel.Text.Substring(0, currentLabel.Text.Length - lengthToRemove) 'Show the contents of the screen without the last character(s)
                If Cursorlbl.Location.X > 60 Then 'Moving cursor back one place
                    Select Case toSuperscript
                        Case True : Cursorlbl.Location = New Point(Cursorlbl.Location.X - 17, Cursorlbl.Location.Y)
                        Case False : Cursorlbl.Location = New Point(Cursorlbl.Location.X - 24, Cursorlbl.Location.Y)
                    End Select
                End If
                If GraphTableExpressionlbl.Text.Length = 0 Then 'Adjusting cursor to appropriate size and position if screen empty or last character is now superscript
                    toSuperscript = False
                    Cursorlbl.Location = New Point(GraphTableExpressionlbl.Location.X + 26, GraphTableExpressionlbl.Location.Y + 2)
                    Cursorlbl.Font = New Font("Calibri", GraphTableExpressionlbl.Font.Size)
                ElseIf Not IsSuperscript(GraphTableExpressionlbl.Text(GraphTableExpressionlbl.Text.Length - 1)) And toSuperscript = True Then
                    toSuperscript = False
                    Cursorlbl.Font = New Font("Calibri", GraphTableExpressionlbl.Font.Size)
                ElseIf IsSuperscript(GraphTableExpressionlbl.Text(GraphTableExpressionlbl.Text.Length - 1)) And toSuperscript = False Then
                    toSuperscript = True
                    Cursorlbl.Font = New Font("Calibri", 20)
                End If
            Case "x"c, "X"c : AddCharacter("x")
        End Select
    End Sub
    Sub AddCharacter(ByVal character As String)
        Dim expressionLength As Integer = 10
        If currentLabel.Equals(GraphTableExpressionlbl) Then expressionLength += 20 'Increase length limit to the label if the user is typing to the graph/table equation
        For token = 0 To character.Length - 1
            If currentLabel.Text.Length < expressionLength Then
                Select Case toSuperscript 'Checking whether to add the character in superscript or normal form
                    Case True
                        currentLabel.Text &= Superscript(character(token))
                        calculation &= Superscript(character(token))
                    Case False
                        currentLabel.Text &= character(token)
                        calculation &= character(token)
                End Select
            End If
        Next
        Cursorlbl.Location = New Point(Cursorlbl.Location.X + (character.Length * 8), Cursorlbl.Location.Y) 'Adjusting cursor location
        Cursorlbl.Location = New Point(Cursorlbl.Location.X + (character.Length * 17), Cursorlbl.Location.Y)
    End Sub
    Private Sub Sinlbl_Click(sender As Object, e As EventArgs) Handles Sinlbl.Click, Coslbl.Click, Tanlbl.Click
        Dim labelClicked As Label = CType(sender, Label)
        AddCharacter(labelClicked.Text & "(")
    End Sub
    Private Sub xlbl_Click(sender As Object, e As EventArgs) Handles xlbl.Click
        AddCharacter("x")
    End Sub
    Private Sub SolverCheck_CheckedChanged(sender As Object, e As EventArgs) Handles SolverCheck.CheckedChanged
        If SolverCheck.Checked Then 'Hide all graph/table related buttons and labels if solver is checked
            GraphTablebtn.Hide() : fxlbl.Hide() : GraphTableExpressionlbl.Hide()
            Solvebtn.Show() : LHSlbl.Show() : RHSlbl.Show() : Equalslbl.Show() : LHSbtn.Show() : RHSbtn.Show()
            Cursorlbl.Hide()
            currentLabel = LHSlbl
        Else
            Solvebtn.Hide() : LHSlbl.Hide() : RHSlbl.Hide() : Equalslbl.Hide() : LHSbtn.Hide() : RHSbtn.Hide()
            GraphTablebtn.Show() : fxlbl.Show() : GraphTableExpressionlbl.Show()
            Cursorlbl.Show()
            Cursorlbl.Location = New Point(GraphTableExpressionlbl.Location.X + 26, GraphTableExpressionlbl.Location.Y + 2)
            currentLabel = GraphTableExpressionlbl
        End If
    End Sub
    Private Sub LHSbtn_Click(sender As Object, e As EventArgs) Handles LHSbtn.Click
        currentLabel = LHSlbl
    End Sub
    Private Sub RHSbtn_Click(sender As Object, e As EventArgs) Handles RHSbtn.Click
        currentLabel = RHSlbl
    End Sub
    Private Sub GraphTablebtn_Click(sender As Object, e As EventArgs) Handles GraphTablebtn.Click
        userEquation = GraphTableExpressionlbl.Text
        Try
            Dim calculationTest As String = Calculate(ReplaceX(userEquation, "1"))
            If calculationTest = "i" Then 'Displays appropriate error if calculation returns specified error
                MsgBox("MATH ERROR.",, "COOLCULATOR")
            ElseIf calculationTest = "s" Then
                MsgBox("SYNTAX ERROR.",, "COOLCULATOR")
            Else
                userEquation = GraphTableExpressionlbl.Text
                SESfrm.Show()
            End If
        Catch ex As Exception
            MsgBox("SYNTAX ERROR",, "COOLCULATOR")
        End Try
    End Sub
    Private Sub Solvebtn_Click(sender As Object, e As EventArgs) Handles Solvebtn.Click
        Try
            MsgBox(SolveEquation(LHSlbl.Text, RHSlbl.Text),, "COOLCULATOR") 'Attempt to solve the equation
        Catch ex As Exception
            MsgBox("CANNOT SOLVE.",, "COOLCULATOR") 'Display appropriate message if an error occurs in the solving
        End Try
    End Sub
    Function SolveEquation(LHS As String, RHS As String) As String
        Dim fx As String = "(" & LHS & ")-(" & RHS & ")"
        Dim dfx As String = Differentiate(ConvertToMaximaForm(fx)) 'Set dfx to the derivative
        Dim tolerance As Double = 0.0001
        Dim maxIterations As Integer = 1000
        Dim x As Double = 1
        Dim x1 As Double
        Dim i As Integer = 0
        Dim fxValue, dfxValue As Double
        Do Until i >= maxIterations 'Iterate x1 = x - (fx/dfx) according to the Newton-Raphson method
            fxValue = CDbl(Calculate(ReplaceX(fx, CStr(x))))
            dfxValue = CDbl(Calculate(ReplaceX(dfx, CStr(x))))
            x1 = x - (fxValue / dfxValue)
            If Math.Abs(x1 - x) < tolerance Then Return "x = " & x1 'Checking if the difference between them is less than the tolerence
            x = x1
            i += 1
        Loop
        Return "NO SOLUTION FOUND." 'Return appropriate message if a solution is not found
    End Function
End Class