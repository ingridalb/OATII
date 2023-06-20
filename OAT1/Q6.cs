using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATII
{
    internal class Q6
    {
        public Q6()
        {

            bool valor1, valor2;

            Console.WriteLine("QUESTÃO 06");
            Console.WriteLine("");

            Console.Write("Digite o primeiro valor booleano (True ou False): ");
            while (!bool.TryParse(Console.ReadLine(), out valor1))
            {
                Console.Clear();
                Console.WriteLine("Valor inválido. Digite True ou False.");
            }

            Console.Write("Digite o segundo valor booleano (True ou False): ");
            while (!bool.TryParse(Console.ReadLine(), out valor2))
            {
                Console.Clear();
                Console.WriteLine("Valor inválido. Digite True ou False.");
            }

            if (valor1 && valor2)
            {
                Console.WriteLine("Os dois valores são VERDADEIROS");

            }
            else if (!valor1 && !valor2)
            {
                Console.WriteLine("Os dois valores são FALSOS");
            }
            else
            {
                Console.WriteLine("Um ou os dois valores são FALSOS");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}
