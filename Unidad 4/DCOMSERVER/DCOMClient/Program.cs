using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCOMSERVER;


namespace DCOMClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce un numero");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double sumar = Operaciones.Sumar(numero1, numero2);
            double restar = Operaciones.Restar(numero1, numero2);
            Console.WriteLine("Resultado de Suma : " + sumar);
            Console.WriteLine("Resultado de Resta : " + restar);
            Console.ReadLine();
        }
    }
}
