
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, suma = 0, iterador = 0;
            do
            {
                Console.WriteLine("Escribe un numero: ");
                num = int.Parse(Console.ReadLine());
                iterador++;
                suma += num;
            } while (num != 0);
            Console.WriteLine("Tu promedio es: " + suma / (iterador - 1));
            Console.ReadKey();
        }
    }
}