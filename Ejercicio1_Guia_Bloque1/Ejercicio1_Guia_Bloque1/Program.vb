Imports System

Module Program
    Sub Main(args As String())
        Dim numero As Int16 = 1
        While numero <> 0
            Console.Write("Dime un numero: ")
            numero = Console.ReadLine()

            If (numero > 0) Then
                Console.WriteLine("El numero es positivo")
            ElseIf (numero < 0) Then
                Console.WriteLine("El numero es negativo")
            End If
        End While


    End Sub
End Module
