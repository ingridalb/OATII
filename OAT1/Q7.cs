using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATII
{
    internal class Q7
    {
        public Q7()
        {
            int num;

            Console.WriteLine("QUESTÃO 07");
            Console.WriteLine();

            Console.WriteLine("Insira um número:");
            num = int.Parse(Console.ReadLine());
            Console.Clear();

            if (num % 2 == 0)
            {
                int num1 = num + 5;
                Console.WriteLine($"O resultado da operação é: {num1}");
            }
            else
            {
                int num1 = num + 8;
                Console.WriteLine($"O resultado da operação é: {num1}");
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
