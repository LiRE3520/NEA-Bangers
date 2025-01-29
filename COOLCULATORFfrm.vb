Option Strict On
Public Class COOLCULATORFfrm
    Dim previousAnswer As String
    Dim toSuperscript As Boolean = False
    Private Sub COOLCULATORfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursorlbl.Location = New Point(Screenlbl.Location.X + 26, Screenlbl.Location.Y + 2)
        Cursorlbl.Font = New Font("Calibri", Screenlbl.Font.Size)
        KeyPreview = True
        Classlbl.Hide()
    End Sub
    Private Sub COOLCULATORfrm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar 'Comparing the inputting character with available valid characters
            Case "*"c, "x"c, "X"c : AddCharacter("×")
            Case "0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c, "/"c, "+"c, "-"c, "("c, ")"c, "."c : AddCharacter(e.KeyChar)
            Case "^"c : SuperscriptClick()
            Case "="c, ChrW(Keys.Enter) : DisplayAns()
            Case "C"c, "c"c : Clear()
            Case "A"c, "a"c : AddCharacter("(" & previousAnswer & ")")
            Case "e"c, "E"c : AddCharacter("e")
            Case ChrW(Keys.Back)
                Dim lengthToRemove As Integer = 1
                If Screenlbl.Text.Length >= 3 Then 'Changing length of temporary string if there is a function
                    Select Case Screenlbl.Text(Screenlbl.Text.Length - 2)
                        Case "s"c, "ˢ"c, "ᵍ"c, "g"c : lengthToRemove = 4
                        Case "n"c, "ⁿ"c
                            If Screenlbl.Text(Screenlbl.Text.Length - 3) = "l" Then
                                lengthToRemove = 3
                            Else
                                lengthToRemove = 4
                            End If
                    End Select
                End If
                If Screenlbl.Text.Length > 0 Then Screenlbl.Text = Screenlbl.Text.Substring(0, Screenlbl.Text.Length - lengthToRemove) 'Show the contents of the screen without the last character(s)
                If Cursorlbl.Location.X > 60 Then 'Moving cursor back one place
                    Select Case toSuperscript
                        Case True : Cursorlbl.Location = New Point(Cursorlbl.Location.X - 17, Cursorlbl.Location.Y)
                        Case False : Cursorlbl.Location = New Point(Cursorlbl.Location.X - 24, Cursorlbl.Location.Y)
                    End Select
                End If
                If Screenlbl.Text.Length = 0 Then 'Adjusting cursor to appropriate size and position if screen empty or last character is now superscript
                    toSuperscript = False
                    Cursorlbl.Location = New Point(Screenlbl.Location.X + 26, Screenlbl.Location.Y + 2)
                    Cursorlbl.Font = New Font("Calibri", Screenlbl.Font.Size)
                ElseIf Not IsSuperscript(Screenlbl.Text(Screenlbl.Text.Length - 1)) And toSuperscript = True Then
                    toSuperscript = False
                    Cursorlbl.Font = New Font("Calibri", Screenlbl.Font.Size)
                ElseIf IsSuperscript(Screenlbl.Text(Screenlbl.Text.Length - 1)) And toSuperscript = False Then
                    toSuperscript = True
                    Cursorlbl.Font = New Font("Calibri", 20)
                End If
        End Select
    End Sub
    Sub AddCharacter(ByVal character As String)
        Classlbl.Hide()
        For token = 0 To character.Length - 1 'Adding each character of the input
            If Screenlbl.Text.Length < 30 Then
                Select Case toSuperscript 'Checking whether to add the character in superscript or normal form
                    Case True
                        Screenlbl.Text &= Superscript(character(token))
                    Case False
                        Screenlbl.Text &= character(token)
                End Select
            End If
        Next
        Cursorlbl.Location = New Point(Cursorlbl.Location.X + (character.Length * 8), Cursorlbl.Location.Y) 'Adjusting cursor to correct position
        Cursorlbl.Location = New Point(Cursorlbl.Location.X + (character.Length * 17), Cursorlbl.Location.Y)
    End Sub
    Private Sub Nlbl_Click(sender As Object, e As EventArgs) Handles N0lbl.Click, N1lbl.Click, N2lbl.Click, N3lbl.Click, N4lbl.Click, N5lbl.Click, N6lbl.Click, N7lbl.Click, N8lbl.Click, N9lbl.Click, pilbl.Click, elbl.Click, Decimallbl.Click, Dividelbl.Click, Addlbl.Click, Multiplylbl.Click, Minuslbl.Click, CloseBracketlbl.Click, OpenBracketlbl.Click
        Dim labelClicked As Label = CType(sender, Label)
        AddCharacter(labelClicked.Text)
    End Sub
    Private Sub Funclbl_Click(sender As Object, e As EventArgs) Handles Sinlbl.Click, Coslbl.Click, Tanlbl.Click, lnlbl.Click, loglbl.Click
        Dim labelclicked As Label = CType(sender, Label)
        AddCharacter(labelclicked.Text & "(")
    End Sub
    Private Sub Sqrtlbl_Click(sender As Object, e As EventArgs) Handles Sqrtlbl.Click
        toSuperscript = False
        Cursorlbl.Font = New Font("Calibri", Screenlbl.Font.Size)
        AddCharacter("√(")
    End Sub
    Private Sub ANSlbl_Click(sender As Object, e As EventArgs) Handles ANSlbl.Click
        AddCharacter("(" & previousAnswer & ")")
    End Sub
    Private Sub Equalslbl_Click(sender As Object, e As EventArgs) Handles Equalslbl.Click
        DisplayAns()
    End Sub
    Private Sub Clearlbl_Click(sender As Object, e As EventArgs) Handles Clearlbl.Click
        Clear()
    End Sub
    Private Sub Powerlbl_Click(sender As Object, e As EventArgs) Handles Powerlbl.Click
        SuperscriptClick()
    End Sub
    Sub Clear()
        Screenlbl.Text = ""
        calculation = ""
        Cursorlbl.Location = New Point(Screenlbl.Location.X + 26, Screenlbl.Location.Y + 2) 'Resetting cursor postion
        Cursorlbl.Font = New Font("Calibri", Screenlbl.Font.Size) 'Resetting cursor size
        toSuperscript = False
        Classlbl.Hide()
    End Sub
    Sub DisplayAns()
        calculation &= Screenlbl.Text 'Stores calculation for sharing
        Dim result As String
        Try
            result = RemoveE(Calculate(Screenlbl.Text))
            If result = "i" Then 'Displays appropriate error if calculation returns specified error
                MsgBox("MATH ERROR.",, "COOLCULATOR")
                calculation = calculation.Substring(0, calculation.Length - Screenlbl.Text.Length)
            ElseIf result = "s" Then
                MsgBox("SYNTAX ERROR.",, "COOLCULATOR")
                calculation = calculation.Substring(0, calculation.Length - Screenlbl.Text.Length)
            Else
                Screenlbl.Text = result
                calculation &= "=" & Screenlbl.Text & " " 'Stores answer for sharing
                previousAnswer = Screenlbl.Text
                Cursorlbl.Location = New Point(Screenlbl.Location.X + 26 + (Screenlbl.Text.Length * 24), Screenlbl.Location.Y + 2) 'Resetting cursor postition
                Cursorlbl.Font = New Font("Calibri", Screenlbl.Font.Size) 'Resetting cursor size
                toSuperscript = False
                Classlbl.Show()
            End If
        Catch ex As Exception
            MsgBox("SYNTAX ERROR.",, "COOLCULATOR") 'Returns appropriate error if calculation fails
            calculation = calculation.Substring(0, calculation.Length - Screenlbl.Text.Length) 'Removing calculation for sharing as it resulted in an error
        End Try
    End Sub
    Sub SuperscriptClick()
        If Screenlbl.Text.Length > 0 Then
            If Not toSuperscript Then 'Adjusting cursor size to the current superscript state
                Cursorlbl.Font = New Font("Calibri", 20)
            Else
                Cursorlbl.Font = New Font("Calibri", Screenlbl.Font.Size)
            End If
            toSuperscript = Not toSuperscript
        End If
    End Sub
    Private Sub Classlbl_Click(sender As Object, e As EventArgs) Handles Classlbl.Click
        CLASSfrm.Show()
    End Sub
    Private Sub Equationlbl_Click(sender As Object, e As EventArgs) Handles Equationlbl.Click
        EQUATIONMAKERfrm.Show()
    End Sub
    Private Sub Simplelbl_Click(sender As Object, e As EventArgs) Handles Simplelbl.Click
        Hide()
        SIMPLEfrm.Show()
    End Sub
    Sub COOLCULATORfrm_Close(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        SIMPLEfrm.Close()
    End Sub
End Class