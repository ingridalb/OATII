using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATII
{
    internal class Q2
    {
        public Q2()
        {
            string nome, sexo, estadoCivil;
            int tempoCasada;

            Console.WriteLine("QUESTÃO 02");
            Console.WriteLine("");

            Console.WriteLine("Insira o seu nome:");
            nome = (Console.ReadLine());

            Console.WriteLine("Insira seu sexo: (F ou M)");
            sexo = Console.ReadLine();

            Console.WriteLine("Insira seu estado civil: (Solteira, Namorando, Noivo(a), Casado(a))");
            estadoCivil = Console.ReadLine();
            Console.Clear();

            if (sexo == "F" || sexo == "F" && estadoCivil == "Casada" || estadoCivil == "casada" || estadoCivil == "CASADA")
            {
                Console.Write("Há quanto tempo você é casada? ");
                tempoCasada = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine($"A usuária {nome} é do sexo {sexo}, e é {estadoCivil} há {tempoCasada}.");
            }
            else
            {
                Console.WriteLine($"O usuário {nome} é do sexo {sexo} e é {estadoCivil}.");

            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
