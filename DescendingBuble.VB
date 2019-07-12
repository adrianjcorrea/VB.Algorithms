
Module ModuleDescendingBubble
    Sub Main()
        Dim Arr() As Integer = {2, 23, 444, 67, 22, 6, 92, 2}
        bubbleSort(Arr, Arr.Length)
        Dim i as Integer

        For i = 0 To Arr.Length - 1
            Console.WriteLine("{0, 4}", Arr(i))
        Next
        Console.ReadLine()
    End Sub

    Public Function bubbleSort(ByVal dataset() As integer, ByVal n As Integer ) 
        Dim i, j As Integer
        For i = 0 To n
            For j = n - 1 To i + 1 Step -1
                If (dataset(j) > dataset(j - 1)) Then
                    Dim temp As Integer = dataset(j)
                    dataset(j) = dataset(j - 1)
                    dataset(j - 1) = temp
                
                End If

            Next
        Next
    End Function
End Module