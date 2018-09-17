using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int numeros;
            Console.WriteLine("Quantos números deseja imprimir?");
            numeros = int.Parse(Console.ReadLine());
            while (contador <= numeros)
            {
                Console.WriteLine($"O valor do contador é {contador}");
                contador = contador + 1;
            }
            Console.ReadLine();
        }
    }
}
