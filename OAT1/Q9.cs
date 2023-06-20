using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATII
{
    internal class Q9
    {
        public Q9()
        {
            string sexo = string.Empty;
            decimal pesoIdeal = 0;

            Console.WriteLine("QUESTÃO 09");
            Console.WriteLine();

            do
            {
                Console.WriteLine("Digite o seu sexo, digite f para feminino e m para masculino: ");
                sexo = Console.ReadLine().ToUpper();
                
                if (sexo != "F" && sexo != "M")
                Console.WriteLine("Digite novamente:");

            } while (sexo != "F" && sexo != "M");


                if (sexo == "M")
                {
                    Console.WriteLine("Digite a sua altura:");
                    decimal h = decimal.Parse(Console.ReadLine());
                    pesoIdeal = (decimal.Parse("72,7") * h) - 58;
                }
                if (sexo == "F")
                {
                    Console.WriteLine("Digite a sua altura:");
                    decimal h = decimal.Parse(Console.ReadLine());
                    pesoIdeal = (decimal.Parse("62,1") * h) - decimal.Parse("44,7");
                }

                    Console.WriteLine($"O peso ideal é: {pesoIdeal}");
            Console.ReadKey();
            Console.Clear();
                    
        }
    }
}
