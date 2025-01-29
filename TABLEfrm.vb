Option Strict On
Public Class TABLEfrm
    Dim RowArray(CInt((endValue - startValue) / stepvalue)) As Row
    Dim isDescending As Boolean = False
    Structure Row
        Dim xValue As Double
        Dim fxValue As String
        Dim originalIndex As Integer
    End Structure
    Private Sub TABLEfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SESfrm.Hide()
        CreateRowArray()
    End Sub
    Private Sub xlistbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles xlistbox.SelectedIndexChanged
        Select Case isDescending 'Selecting the index from the start or end of the table depends on if it is in descending order
            Case True : Contentslbl.Text = RowArray(RowArray.Length - 1 - xlistbox.SelectedIndex).fxValue
            Case False : Contentslbl.Text = RowArray(xlistbox.SelectedIndex).fxValue
        End Select
    End Sub
    Private Sub Sort_Click(sender As Object, e As EventArgs) Handles AscArrlbl.Click, DescArrlbl.Click, Originallbl.Click
        Dim labelClicked As Label = CType(sender, Label)
        QuickSort(RowArray, 0, RowArray.Length - 1) 'Sort the table for the binary search
        xlistbox.Items.Clear() 'Empty ListBox for reinputting
        If labelClicked.Text = "↓" Then 'For ascending, sorted values are added in order
            For y = 0 To RowArray.Length - 1
                xlistbox.Items.Add(RowArray(y).xValue)
            Next
            isDescending = False
        ElseIf labelClicked.Text = "↑" Then 'For descending, sorted values are added in reverse
            For y = RowArray.Length - 1 To 0 Step -1
                xlistbox.Items.Add(RowArray(y).xValue)
            Next
            isDescending = True
        Else
            CreateRowArray() 'For original sort, the original values are created again
        End If
        xlistbox.SelectedIndex = 0 'Reset to first index of the ListBox
    End Sub
    Sub QuickSort(ByRef RowArr() As Row, ByRef left As Integer, ByRef right As Integer)
        Dim newBound As Integer = Partition(RowArr, left, right) 'Setting the new end to the list to be sorted in an integer
        If left < newBound - 1 Then QuickSort(RowArr, left, newBound - 1) 'Recall the quick sort with the adjusted list using the new bound
        If newBound < right Then QuickSort(RowArr, newBound, right)
    End Sub
    Function Partition(ByRef RowArr() As Row, ByRef left As Integer, ByRef right As Integer) As Integer
        Dim i As Integer = left
        Dim j As Integer = right
        Dim temporary As Row
        Dim pivot As Double = CDbl(RowArr(CInt(Math.Truncate((i + j) / 2))).fxValue)
        While i <= j
            While CDbl(RowArr(i).fxValue) < pivot 'Searching for a row smaller than the pivot
                i += 1
            End While
            While CDbl(RowArr(j).fxValue) > pivot 'Searching for a row greater than the pivot
                j -= 1
            End While
            If i <= j Then
                temporary = RowArr(i) 'Swapping the rows when the row below the pivot is greater than one above the pivot
                RowArr(i) = RowArr(j)
                RowArr(j) = temporary
                i += 1
                j -= 1
            End If
        End While
        Return i 'Return where the rows were swapped
    End Function
    Sub CreateRowArray()
        Dim rowIndex As Integer = 0
        Dim calculationResult As String
        For x = startValue To endValue Step stepvalue
            With RowArray(rowIndex)
                .xValue = Math.Round(x, 7) 'Set the x value to each x
                calculationResult = Calculate(ReplaceX(userEquation, RemoveE(CStr(x))))
                If calculationResult <> "i" Then
                    .fxValue = CStr(Math.Round(CDbl(calculationResult), 9)) 'Set the fx to the calculation of with the x
                Else
                    .fxValue = "NaN"
                End If
            End With
            rowIndex += 1
        Next
        xlistbox.Items.Clear() 'Empty the ListBox
        For rowIndex = 0 To RowArray.Length - 1
            xlistbox.Items.Add(RowArray(rowIndex).xValue) 'Add each row's x to the ListBox
        Next
        xlistbox.SelectedIndex = 0 'Reset to the first index
        isDescending = False 'It is now in the orginal order and not descending
    End Sub
    Function BinarySearch(target As Double) As String
        Dim left As Integer = 0
        Dim sortedRowArray As Row() = CType(RowArray.Clone, Row()) 'Cloning the row array into a new array
        For n = 0 To sortedRowArray.Length - 1
            sortedRowArray(n).originalIndex = n 'Setting the current index as an original index before sorting
        Next
        QuickSort(sortedRowArray, 0, sortedRowArray.Length - 1) 'Sort the array
        Dim right As Integer = sortedRowArray.Length - 1
        Dim middle As Integer
        While left <= right
            middle = (left + right) \ 2 'Find the middle value
            If CDbl(sortedRowArray(middle).fxValue) = target Then 'If the value has been found then return its original index
                Select Case isDescending
                    Case False : Return CStr(sortedRowArray(middle).originalIndex) 'Returning the orginal index will select the correct position in the unsorted array
                    Case True : Return CStr(sortedRowArray.Length - 1 - sortedRowArray(middle).originalIndex)
                End Select
            ElseIf CDbl(sortedRowArray(middle).fxValue) < target Then 'If the target has not been found, adjust the left and right bounds for the next iteration
                left = middle + 1
            Else
                right = middle - 1
            End If
        End While
        MsgBox("NOT FOUND.",, "COOLCULATOR")
        Return "NOT FOUND." 'If a value was not found, an appropriate message is returned
    End Function
    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        Dim searchResult As String = BinarySearch(CDbl(Searchtxt.Text))
        If IsNumeric(searchResult) Then 'If a correct value was found, select the correct corresponding row index in the table
            xlistbox.SelectedIndex = CInt(searchResult)
        End If
    End Sub
End Class