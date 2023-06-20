using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATII
{
    internal class Q3
    {
        public Q3()
        {
            int num;

            Console.WriteLine("QUESTÃO 03");
            Console.WriteLine();

            Console.WriteLine("Insira um número:");
            num = int.Parse(Console.ReadLine());
            Console.Clear();

            if (num % 2 == 0)
            {
                Console.WriteLine("{0} é um número par", num);
            }
            else
            {
                Console.WriteLine("{0} é um número ímpar!", num);
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
