Module Module1

   Sub Main()
     Dim d = DateTime.Parse("10-5-9993")
     If IsDate(d) Then
        Console.WriteLine("It is a date value.")
     Else
        Console.WriteLine("It is not a date value.")
     End If
     Console.Read()

   End Sub
End Module