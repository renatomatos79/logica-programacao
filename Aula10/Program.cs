using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    class Program
    {
        const string FORCA = "COOPJOVEM";
        const int MAX_ERROS = 3;
        static void Main(string[] args)
        {
            int erros = 0;
            string palavra = "_";
            while (palavra.Length < FORCA.Length)
            {
                palavra += "_";
            }
            while ((erros < MAX_ERROS) && palavra.Contains("_"))
            {
                Console.Clear();
                Console.WriteLine("JOGO DA FORCA!");
                Console.WriteLine($"A palavra contém apenas {FORCA.Length} caracteres!");
                Console.WriteLine($"Informe uma letra!");
                var letra = Console.ReadLine();
                if (FORCA.Contains(letra) == true)
                {
                    for (var contador = 0; contador < FORCA.Length; contador++)
                    {
                        if (FORCA[contador] == letra[0])
                        {
                            palavra = palavra.Remove(contador, 1).Insert(contador, letra);
                        }
                    }
                }
                else
                {
                    erros++;
                }
                Console.WriteLine("");
                Console.WriteLine($"Palavra: {palavra}");
                Console.WriteLine($"ERROS: {erros}");
                Console.ReadLine();
            }
            Console.WriteLine("");
            Console.WriteLine("Fim!");
            Console.ReadLine();

        }
    }
}
