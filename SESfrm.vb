Option Strict On
Public Class SESfrm
    Private Sub SESfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EQUATIONMAKERfrm.Hide()
        startValue = 0
        endValue = 0
    End Sub
    Private Sub Startupdown_ValueChanged(sender As Object, e As EventArgs) Handles Startupdown.ValueChanged
        startValue = Startupdown.Value
    End Sub
    Private Sub Endupdown_ValueChanged(sender As Object, e As EventArgs) Handles Endupdown.ValueChanged
        endValue = Endupdown.Value
    End Sub
    Private Sub stepupdown_ValueChanged(sender As Object, e As EventArgs) Handles stepupdown.ValueChanged
        stepvalue = stepupdown.Value
    End Sub
    Private Sub Graphbtn_Click(sender As Object, e As EventArgs) Handles Graphbtn.Click
        If startValue < endValue Then 'The start value must be less than the end value
            Try
                Hide()
                GRAPHINGfrm.Show()
            Catch ex As Exception
                MsgBox("GRAPHING ERROR.")
            End Try
        Else
            MsgBox("Start value must be less than End value.",, "COOLCULATOR") 'Ask the user to reinput the start and end values
        End If
    End Sub
    Private Sub Tableitbtn_Click(sender As Object, e As EventArgs) Handles Tableitbtn.Click
        If startValue < endValue And stepvalue > 0 Then
            Hide()
            TABLEfrm.Show()
        ElseIf startValue >= endValue Then
            MsgBox("Start value must be less than End value.",, "COOLCULATOR") 'Ask the user to reinput the start and end values
        ElseIf stepvalue = 0 Then
            MsgBox("Step value must be more than zero for a table.",, "COOLCULATOR") 'Ask the user to input a step value
        End If
    End Sub
End Class