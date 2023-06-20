using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATII
{
    internal class Q5
    {
        public Q5()
        {
            int num1, resultado;

            Console.WriteLine("QUESTÃO 05");
            Console.WriteLine();
 
            Console.WriteLine("Insira um número negativo ou positivo:");
            num1 = int.Parse(Console.ReadLine());
            Console.Clear();

            if (num1 > 0)
            {
                resultado = num1 * 2;
                Console.WriteLine($"O resultado é: {resultado}");
            }
            else
            {
                resultado = num1 * 3;
                Console.WriteLine($"O resultado é: {resultado}");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
