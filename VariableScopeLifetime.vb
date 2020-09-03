Option Explicit On
Option Strict On
Option Compare Binary

Module VariableScopeLifetime

    Dim y As Integer
    'dont use globals all the time as that is wasted memory
    'read book "CLEAN CODE"

    Sub Main()
        Dim x As Integer
        Console.WriteLine("y = " & CStr(y))
        Console.WriteLine("y = " & CStr(x))
        x = 5
        y = 4I
        Console.WriteLine("y = " & CStr(y))
        Console.WriteLine("y = " & CStr(x))
        TestX()
        Console.WriteLine("y = " & CStr(y))
        Console.WriteLine("y = " & CStr(x))
        Console.ReadLine()

    End Sub

    Sub TestX()
        Dim X As Integer
        X = 42I
        y = 7I

        Console.WriteLine("y = " & CStr(y))
        Console.WriteLine("y = " & CStr(X))

        ' Console.WriteLine(y)

    End Sub

End Module
