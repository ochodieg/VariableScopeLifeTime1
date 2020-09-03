Option Explicit On
Option Strict On
Option Compare Binary

Module VariableScopeLifetime

    Dim y As Integer

    Sub Main()
        Dim x As Integer
        Console.WriteLine(x)

        Console.ReadLine()

        y = 4
    End Sub

    Sub TestX()

        X = 5
        y = 71

    End Sub

End Module
