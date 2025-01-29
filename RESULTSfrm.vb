Option Strict On
Imports System.IO
Public Class RESULTSfrm
    Private Sub RESULTSfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor = Cursors.WaitCursor
        Try
            Download() 'Download the current text file
            Dim fileText As String() = File.ReadAllLines("Class.txt") 'Read the contents of the text file to an array
            If fileText.Length > 1 Then 'Checking if the file has at least one student (one student uses two lines of the file)
                VScrollBar.Hide()
                NamesListbox.Items.Clear()
                For token = 1 To fileText.Length - 1 'Add all names to the ListBox
                    If CDbl(token) Mod 2 = 1 Then NamesListbox.Items.Add(fileText(token))
                Next
                NamesListbox.SelectedIndex = 0 'Set result to the first student
            Else
                MsgBox("No results yet.",, "COOLCULATOR") 'Display appropriate message if class results are empty
                Close()
            End If
        Catch ex As Exception 'Catch any errors due to network issues
            MsgBox(ex.Message) 'Display appropriate message for the error
            Close()
        End Try
        Cursor = Cursors.Hand
    End Sub
    Private Sub NamesListbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NamesListbox.SelectedIndexChanged
        Calculationslbl.Text = ""
        Dim fileText As String() = File.ReadAllLines("Class.txt") 'Read contents of the text file to an array
        Dim token As Integer = 0
        Dim temporary As Integer = 0
        Do Until token >= fileText((2 * NamesListbox.SelectedIndex) + 2).Length - 2 'Add character by character from the line in the array
            Do Until fileText((2 * NamesListbox.SelectedIndex) + 2)(token) = " " 'Add until a space is reached
                Calculationslbl.Text &= fileText((2 * NamesListbox.SelectedIndex) + 2)(token)
                If (token - temporary) > 22 Then Calculationslbl.Text &= vbNewLine : temporary = token 'If the character has reached the end of the form then start a new line
                token += 1
            Loop
            Calculationslbl.Text &= vbNewLine 'Start a new line
            token += 1
            temporary = token 'Set the current character to the start of the line
        Loop
        If Calculationslbl.Size.Height > 319 Then
            VScrollBar.Show() 'Show the scroll bar if the calculations go off the screen vertically
        Else
            VScrollBar.Hide()
        End If
    End Sub
    Private Sub VScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar.Scroll
        Calculationslbl.Location = New Point(Calculationslbl.Location.X, CInt(25 - ((2 * Calculationslbl.Size.Height) / 319) * VScrollBar.Value))
    End Sub
End Class