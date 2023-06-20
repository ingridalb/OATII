using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha;

            do
            {

                Console.WriteLine("LISTA DE QUESTÕES");
                Console.Write("Digite uma questão de 1 até 12: ");
                escolha = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (escolha)
                {
                    case 1:

                        Q1 objQ1 = new Q1();

                    break;

                    case 2:

                        Q2 objQ2 = new Q2();

                    break;

                    case 3:

                        Q3 objQ3 = new Q3();

                    break;

                    case 4:

                        Q4 objQ4 = new Q4();

                    break;

                    case 5:

                        Q5 objQ5 = new Q5();

                    break;

                    case 6:

                        Q6 objQ6 = new Q6();

                    break;

                    case 7:

                        Q7 objQ7 = new Q7();

                    break;

                    case 8:

                        Q8 objQ8 = new Q8();

                    break;

                    case 9:

                        Q9 objQ9 = new Q9();

                    break;

                    case 10:

                        Q10 objQ10 = new Q10();

                    break;

                    case 11:

                        Q11 objQ11 = new Q11();

                    break;

                    case 12:

                        Q12 objQ12 = new Q12();

                    break;
                
                }
            } while (escolha != 14);

            Console.ReadKey();
            
        }
    }
}
