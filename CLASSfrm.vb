Option Strict On
Imports System.IO
Public Class CLASSfrm
    Private Sub CLASSfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sharelbl.Text = "SHARE YOUR ANSWER" : NewClasslbl.Text = "CLICK FOR NEW CLASS"
    End Sub
    Private Sub Sharelbl_Click(sender As Object, e As EventArgs) Handles Sharelbl.Click
        SHAREfrm.Show()
    End Sub
    Private Sub NewClasslbl_Click(sender As Object, e As EventArgs) Handles NewClasslbl.Click
        NewClasslbl.Cursor = Cursors.WaitCursor
        If NewClasslbl.Text = "CLICK FOR NEW CLASS" Then
            Try
                File.WriteAllText("Class.txt", " ") 'Erase all contents of text file
                Upload() 'Upload empty text file
                NewClasslbl.Text = "NEW CLASS CREATED."
                Sharelbl.Text = "SHARE YOUR ANSWER"
            Catch ex As Exception 'Catch errors due to network issues
                NewClasslbl.Text = "CLICK FOR NEW CLASS"
                Sharelbl.Text = "ANSWER SHARED."
                MsgBox(ex.Message) 'Display appropriate message for the error
            End Try
        End If
        NewClasslbl.Cursor = Cursors.Hand
    End Sub
    Private Sub Resultslbl_Click(sender As Object, e As EventArgs) Handles Resultslbl.Click
        RESULTSfrm.Show()
    End Sub
End Class