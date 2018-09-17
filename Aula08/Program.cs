using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros;
            Console.WriteLine("Quantos números deseja imprimir?");
            numeros = int.Parse(Console.ReadLine());
            Console.WriteLine("Listagem crescente...");
            for (int contador = 1; contador <= numeros; contador++)
            {
                Console.WriteLine($"O valor do contador é {contador}");
            }
            Console.WriteLine("Listagem decrescente...");
            for (int contador = numeros; contador >= 1; contador--)
            {
                Console.WriteLine($"O valor do contador é {contador}");
            }
            Console.ReadLine();
        }
    }
}
