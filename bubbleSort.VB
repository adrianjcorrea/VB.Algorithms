Module VBModule
 
    
Sub Main()

Dim arr() As Integer = {0, 110, 12, 23, 1, 21, 12, 12, 32, 45, 3, 5}
bubbleSort(arr, arr.Length)
Dim i As Integer
Console.Write(arr.Length)


For i = 0 To arr.Length - 1
Console.Write("{0,10}", arr(i))

Next
Console.Write(arr.Length)

Console.ReadLine()

End Sub

Public Function bubbleSort(ByVal dataset() As Integer, ByVal n As Integer)
    Dim i, j As Integer

    For i = 0 To n Step 1
      For j = n - 1 To i + 1 Step -1
        If (dataset(j) < dataset(j - 1) ) Then
          Dim temp As Integer = dataset(j)
          dataset(j) = dataset(j - 1)
          dataset(j - 1) = temp
        
        End If
      Next
    Next
End Function


End Module