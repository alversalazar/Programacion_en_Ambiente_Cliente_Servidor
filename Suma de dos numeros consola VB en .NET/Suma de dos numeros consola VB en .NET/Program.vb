Imports System

Module Program
    Sub Main(args As String())

        ' Solicitar al usuario dos n�meros para sumar
        Console.Write("Ingresa el primer n�mero: ")
        Dim numero1 As Double = Convert.ToDouble(Console.ReadLine())

        Console.Write("Ingresa el segundo n�mero: ")
        Dim numero2 As Double = Convert.ToDouble(Console.ReadLine())

        ' Realizar la suma
        Dim resultado As Double = numero1 + numero2

        ' Mostrar el resultado
        Console.WriteLine($"El resultado de la suma es: {resultado}")
        Console.ReadKey()



    End Sub
End Module
