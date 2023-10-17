using System;

namespace Suma_de_dos_numeros
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Solicitar al usuario dos números para sumar
            Console.Write("Ingresa el primer número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            // Realizar la suma
            double resultado = numero1 + numero2;

            // Mostrar el resultado
            Console.WriteLine($"El resultado de la suma es: {resultado}");
            Console.ReadKey();
        }
    }
}
