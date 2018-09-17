using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    class Program
    {
        const int VALORES = 3;
        const int MAX = 10;
        static void Main(string[] args)
        {
            int[] valores = new int[VALORES];
            int numero = 0;
            bool achou = false;
            var randon = new Random(0);
            Console.WriteLine("Informe um numero:");
            numero = int.Parse(Console.ReadLine());
            for (int contador = 0; contador < VALORES; contador++)
            {
                valores[contador] = randon.Next(1, MAX);
                if (valores[contador] == numero)
                {
                    achou = true;
                    break;
                }
            }
            if (achou)
            {
                Console.WriteLine($"O número {numero} existe na lista!");
            }
            else
            {
                Console.WriteLine($"O número {numero} Não existe na lista!");
                Console.WriteLine("Elementos da lista!");
                for (int contador = 0; contador < VALORES; contador++)
                {
                    Console.WriteLine(valores[contador].ToString());
                }
            }
            Console.ReadLine();
        }
    }
}
