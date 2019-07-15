
Module Module1

   Sub Main()
     Dim x() As Integer = {1, 3, 4, 23, 22} ' five-element array
     For Each i In x ' print array elements
        Console.WriteLine(i)
     Next
     ReDim Preserve x(6) 'extend to seven-element array
     x(5) = 30 'add more values to the array
     x(6) = 25
     Console.WriteLine("........................")
     For Each i In x ' print array elements again
        Console.WriteLine(i)
     Next
     
     Console.Read()

   End Sub
End Module
