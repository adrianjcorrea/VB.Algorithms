Imports System.Text.RegularExpressions
Module Module1

   Sub Main()
     Dim email As String
     Console.WriteLine("Enter your an e-mail address:")
     email = "Adrianjcorrea007@gmail.com"
     Dim m = Regex.Match(email, "(.+)[@](.+)[.](.+)")
     If m.Success Then
        Console.WriteLine("Valid email!")
     Else
        Console.WriteLine("Invalid email!")
     End If
     Console.Read()

   End Sub
End Module