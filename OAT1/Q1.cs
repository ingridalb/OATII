using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATII
{
    internal class Q1
    {
        public Q1()
        {

            int A, B, C, valor;

            Console.WriteLine("QUESTÃO 01");
            Console.WriteLine();

            Console.Write("Digite o valor A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor B: ");
            B = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor C: ");
            C = int.Parse(Console.ReadLine());

            valor = A + B;

            Console.Clear();
            Console.WriteLine("O valor da soma é: " + valor);

            if (valor < C)
            {

                Console.WriteLine("A resultado da soma de A e B é menor que o valor de C!");
            }
            else
            {
                Console.WriteLine("O resultado da soma de A e B é maior ou igual ao valor de C!");
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
