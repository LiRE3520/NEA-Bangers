Option Strict On
Imports System.IO
Imports System.Text.RegularExpressions.Regex
Public Class SHAREfrm
    Private Sub Sharebtn_Click(sender As Object, e As EventArgs) Handles Sharebtn.Click
        If Nametxt.Text <> "" And Match(Nametxt.Text, "^\d\d[A-Z][a-z]+[A-Z][a-z][a-z]$").Success Then 'Check if the username is in the form 16ReedLew
            Sharebtn.Cursor = Cursors.WaitCursor
            Try
                Download() 'Download the text file
                Dim fileText As String() = File.ReadAllLines("Class.txt") 'Read the contents of the text file into an array
                Array.Resize(fileText, fileText.Length + 2) 'Add two lines to the results
                fileText(fileText.Length - 2) = Nametxt.Text 'Set the first line to the username
                fileText(fileText.Length - 1) = calculation 'Set the second name to their calculation
                File.WriteAllLines("Class.txt", fileText) 'Write the whole array to the text file
                Try
                    Upload() 'Upload the new text file
                    CLASSfrm.Sharelbl.Text = "ANSWER SHARED."
                Catch ex As Exception 'Catch any erros due to network issues
                    CLASSfrm.Sharelbl.Text = "SHARE YOUR ANSWER"
                    MsgBox(ex.Message,, "COOLCULATORS") 'Display appropriate message for the error
                End Try
                CLASSfrm.NewClasslbl.Text = "CLICK FOR NEW CLASS"
                Sharebtn.Cursor = Cursors.Hand
                Close() 'Close form after sharing is complete
            Catch ex As Exception 'Catch any erros due to network issues
                MsgBox(ex.Message,, "COOLCULATOR") 'Display appropriate message for the error
            End Try
        Else
            MsgBox("Please enter your school username.",, "COOLCULATOR") 'Ask user to change the format of their username
        End If
    End Sub
End Class