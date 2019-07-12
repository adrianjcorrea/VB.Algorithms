'Simple Next loop

Module ModuleLoops
    Sub Main()
        Dim i As Integer
        'By default step will be at 1 if not especified.
        For i = 1 To 9
            Console.WriteLine("Count is: " &  i)
        Next
        Console.ReadLine()
    End Sub
End Module

'Nested Looping
Module ModuleNestedLoop
    Sub Main()
        Dim i As Integer
        Dim j As Integer

        For i = 0 To 9
            For j = 0 To i
                Console.WriteLine(i)
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub
End Module