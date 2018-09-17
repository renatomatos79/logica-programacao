using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o seu endereço:");
            string endereco = Console.ReadLine();
            Console.WriteLine($"Ola {nome}! Seu endereço é {endereco}");
            Console.ReadLine();
        }
    }
}
