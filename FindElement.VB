'Find An element in an Array

Module ModuleFindElement

Sub Main()

Dim Arr() As Integer = {2, 55, 45, 886, 945, 2}
Dim element As Integer

element = findElement(Arr, 886, Arr.Length)

if(element <> -1) Then
  Console.WriteLine("The item was found at the position {1}.", "Hello", element)
End If
    Console.ReadLine()
End Sub

Function findElement(ByVal dataset() As Integer, ByVal target As Integer,  ByVal n As Integer) As Integer
 Dim found,possition,i As Integer
 found = 0
 possition = -1
 For i = 0 To n step 1
 If(found <> 1) Then
    If(target = dataset(i)) Then
        found = 1
        possition = i
    End if
 End If
 Next
 Return possition
End Function


End Module
