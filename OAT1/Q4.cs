using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATII
{
    internal class Q4
    {
        public Q4()
        {
            int A, B, C;

            Console.WriteLine("QUESTÃO 04");
            Console.WriteLine();

            Console.Write("Insira dois números inteiros: ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            Console.Clear();

            if (A == B)
            {
                C = A + B;
                Console.WriteLine($"O resultado é: {C}");
            }
            else
            {
                C = A * B;
                Console.WriteLine($"O resultado é: {C}");
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
