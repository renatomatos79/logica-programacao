using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06
{
    class Program
    {
        enum FormacaoAcademica { NaoInformado, PrimeiroGrau, SegundoGrau, Superior }

        static void Main(string[] args)
        {
            FormacaoAcademica formacaoAcademica = FormacaoAcademica.NaoInformado;
            double salario = 0.0;
            Console.WriteLine("Informe sua formacao: primeiro grau, segundo grau ou superior");
            var formacao = Console.ReadLine();
            if (formacao == "primeiro grau")
            {
                formacaoAcademica = FormacaoAcademica.PrimeiroGrau;
            }
            else if (formacao == "segundo grau")
            {
                formacaoAcademica = FormacaoAcademica.SegundoGrau;
            }
            else
            {
                formacaoAcademica = FormacaoAcademica.Superior;
            }


            switch (formacaoAcademica)
            {
                case FormacaoAcademica.PrimeiroGrau:
                    {
                        salario = 500.50;
                        break;
                    }
                case FormacaoAcademica.SegundoGrau:
                    {
                        salario = 700.50;
                        break;
                    }
                default:
                    {
                        salario = 1200.12;
                        break;
                    }
            }
            Console.WriteLine($"Formação: {formacaoAcademica}");
            Console.WriteLine($"Salário.: {salario}");
            Console.ReadLine();
        }
    }
}
