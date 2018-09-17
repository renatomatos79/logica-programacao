using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int dia, mes, ano;
            decimal peso;
            bool casado;
            string nomeConjuge;
            DateTime nascimento;
            Console.WriteLine("Preecha o formulário abaixo!");
            Console.WriteLine("Nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Peso: Exemplo 80,25");
            peso = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Caso: Exemplo 'true' para Sim e 'false' para Não");
            casado = bool.Parse(Console.ReadLine());
            Console.WriteLine("Dia de nascimento:");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Mês de nascimento:");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ano de nascimento:");
            ano = int.Parse(Console.ReadLine());
            nascimento = new DateTime(ano, mes, dia);
            if (casado == true)
            {
                Console.WriteLine("Nome do seu cônjuge:");
                nomeConjuge = Console.ReadLine();
            }
            else
            {
                nomeConjuge = "Não informado";
            }
            Console.WriteLine("Confirme seus dados!");
            Console.WriteLine($"Nome......: {nome}");
            Console.WriteLine($"Peso......: {peso}");
            Console.WriteLine($"Nascimento: {nascimento.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Casado....: {casado}");
            Console.WriteLine($"Cônjuge...: {nomeConjuge}");
            Console.ReadKey();
        }
    }
}
