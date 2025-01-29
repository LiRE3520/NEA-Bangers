Option Strict On
Imports System.Windows.Forms.DataVisualization.Charting.SeriesChartType
Public Class GRAPHINGfrm
    Private Sub GRAPHINGfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        COOLCULATORFfrm.Hide()
        Tangentbtn.Show() : Tangentupdown.Show() : Tangentxlbl.Show()
        Try
            Dim test As Double = CDbl(Calculate(ReplaceX(Differentiate(ConvertToMaximaForm(userEquation)), CStr(startValue))))
        Catch ex As Exception
            Tangentbtn.Hide() : Tangentupdown.Hide() : Tangentxlbl.Hide() 'Hiding all tangent related controls if the derivative cannot be found
        End Try
        Graph.Titles.Add("Your line:") 'Dynamically editing the graph
        Graph.ChartAreas.Clear()
        Graph.ChartAreas.Add("Default") 'Dynamically creating a chart area
        With Graph.ChartAreas("Default").AxisX
            .MajorGrid.Enabled = False
            .MinorGrid.Enabled = False
            .Crossing = 0
        End With
        With Graph.ChartAreas("Default").AxisY
            .MajorGrid.Enabled = False
            .MinorGrid.Enabled = False
            .Crossing = 0
        End With
        With Graph 'Dynamically creating a series on the graph for the plot
            .Series.Clear()
            .Series.Add("Plot")
            .Series("Plot").Color = Color.RoyalBlue
            .Series("Plot").ChartType = Line
            .Series("Plot").IsVisibleInLegend = False
        End With
        Dim y As String
        Dim previousX, previousY, gradient As Double
        Dim currentSeriesIndex As Integer = 2
        If HasTrigFunction(userEquation) Then
            stepvalue = ((endValue - startValue) / 1000) * piValue 'If a trig function is involved, the step value is in phase with pi 
        Else
            stepvalue = ((endValue - startValue) / 1000)
        End If
        For x = startValue To endValue Step stepvalue
            y = Calculate(ReplaceX(userEquation, RemoveE(CStr(x)))) 'Calculating the y by subsituting the x in the user's equation
            If y <> "i" Then gradient = (CDbl(y) - previousY) / (x - previousX) 'Does not calculate the gradient if the result is a math error
            With Graph
                If y <> "i" AndAlso (gradient < 100000 And gradient > -100000) Then 'Ignores the point if it is a math error
                    .Series(.Series.Count - 1).Points.AddXY(x, y) 'Add the point
                ElseIf y <> "i" Then 'Dynamically creating a new series if the gradient is too high, most likely meaning an asymptote
                    .Series.Add("Plot" & currentSeriesIndex)
                    .Series("Plot" & currentSeriesIndex).Color = Color.RoyalBlue
                    .Series("Plot" & currentSeriesIndex).ChartType = Line
                    .Series("Plot" & currentSeriesIndex).IsVisibleInLegend = False
                    currentSeriesIndex += 1
                End If
            End With
            If y <> "i" Then
                previousX = x
                previousY = CDbl(y)
            End If
            Graph.ChartAreas("Default").AxisX.RoundAxisValues()
            Graph.ChartAreas("Default").AxisY.RoundAxisValues()
        Next
    End Sub
    Private Sub Tangentbtn_Click(sender As Object, e As EventArgs) Handles Tangentbtn.Click
        Dim tangentX As Double = Tangentupdown.Value 'Setting the x value of the tangent to the user's input
        Dim tangentY As Double = CDbl(Calculate(ReplaceX(userEquation, RemoveE(CStr(tangentX))))) 'Calculating the y by subsituting the x in the user's equation
        Dim gradient, previousX, previousY, y As Double
        gradient = CDbl(Calculate(ReplaceX(Differentiate(ConvertToMaximaForm(userEquation)), CStr(tangentX)))) 'Calculating the gradient by subsituting the x in the derivative of the equation
        With Graph
            Try
                .Series.Add("Tangent")
            Catch ex As Exception
                .Series.RemoveAt(1) 'If there is already a tangent series, it is removed and a new one is added and created dynamically
                .Series.Add("Tangent")
            End Try
            .Series("Tangent").Color = Color.Red
            .Series("Tangent").ChartType = Line
            .Series("Tangent").IsVisibleInLegend = True
            .Series("Plot").IsVisibleInLegend = True
            .ChartAreas("Default").AxisY.CustomLabels.Clear()
            .ChartAreas("Default").AxisX.CustomLabels.Clear()
        End With
        For x = startValue To endValue Step ((endValue - startValue) / 100)
            y = (gradient * (x - tangentX)) + tangentY 'Calculating the y at each point using the mathematical formula: y-y1=m(x-x1)
            Graph.Series("Tangent").Points.AddXY(x, y) 'Add the point to the series
            If (x > 0 And previousX < 0) Or (x < 0 And previousX > 0) Then 'If the line has crossed the y axis, a label at that point is added
                Graph.ChartAreas("Default").AxisY.CustomLabels.Add(previousY, y, CStr(Math.Round((previousY + y) / 2, 3)))
            End If
            If (y > 0 And previousY < 0) Or (y < 0 And previousY > 0) Then 'If the line has crossed the x axis, a label at that point is added
                Graph.ChartAreas("Default").AxisX.CustomLabels.Add(previousX, x, CStr(Math.Round((previousX + x) / 2, 3)))
            End If
            previousY = y
            previousX = x
        Next
        Graph.ChartAreas("Default").AxisX.RoundAxisValues()
        Graph.ChartAreas("Default").AxisY.RoundAxisValues()
    End Sub
    Sub GRAPHINGfrm_Closed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        COOLCULATORFfrm.Show()
    End Sub
    Function HasTrigFunction(ByVal userEquation As String) As Boolean
        If userEquation.Contains("sin") Or userEquation.Contains("cos") Or userEquation.Contains("tan") Then 'Checking for normal trig function
            Return True
        ElseIf userEquation.Contains("ˢⁱⁿ") Or userEquation.Contains("ᶜᵒˢ") Or userEquation.Contains("ᵗᵃⁿ") Then 'Checking for a superscript trig function
            Return True
        Else
            Return False
        End If
    End Function
End Class