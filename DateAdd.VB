'DeteInterval set to year and will add 10 years to your current date.
Module Module1

   Sub Main()
     Dim dt = DateAdd(DateInterval.Year, 10, Now)
     Console.WriteLine("The date calculated 10 years from now is: " + dt)

     Console.Read()

   End Sub
End Module

'DeteInterval set to Days and will add 10 days to your current date.
Module Module1

   Sub Main()
     Dim dt = DateAdd(DateInterval.Day, 10, Now)
     Console.WriteLine("The date calculated 10 years from now is: " + dt)

     Console.Read()

   End Sub
End Module
