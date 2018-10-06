using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            var desejaSair = false;
            while (desejaSair == false)
            {
                Console.Clear();
                Console.WriteLine("Criando um MENU");
                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine("[1] Imprimir números pares");
                Console.WriteLine("[2] Imprimir números ímpares");
                Console.WriteLine("[3] Sair");
                var opcao = Console.ReadLine();
                if (opcao == "1")
                {
                    Console.WriteLine("[1] Imprimir números pares");
                    for (var n = 1; n <= 100; n++)
                    {
                        if (n % 2 == 0)
                        {
                            Console.Write($"{n} ");
                        }
                    }
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();
                }
                if (opcao == "2")
                {
                    Console.WriteLine("[2] Imprimir números ímpares");
                    for (var n = 1; n <= 100; n++)
                    {
                        if (n % 2 != 0)
                        {
                            Console.Write($"{n} ");
                        }
                    }
                    Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();

                }
                else if (opcao == "3")
                {
                    desejaSair = true;
                }
            }
        }
    }
}
