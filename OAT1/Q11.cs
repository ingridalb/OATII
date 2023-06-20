using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATII
{
    internal class Q11
    {
        public Q11()
        {
            int escolha;
            double desconto = 0, valor, acrescimo = 0;

            Console.WriteLine("QUESTÃO 11");
            Console.WriteLine();

            do
            {
                Console.WriteLine("Computador R$2000,00 | Opções de pagamento: ");
                Console.WriteLine(" ");
                Console.WriteLine("1. A vista no dinheiro ou cheque.");
                Console.WriteLine("2. À vista no cartão de crédito.");
                Console.WriteLine("3. Parcelado duas vezes sem juros.");
                Console.WriteLine("4. Parcelado quatro vezes com juros.");
                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    switch (escolha)
                    {
                        case 1:

                            valor = 10.0 / 100 * 2000;
                            desconto = 2000 - valor;

                            Console.WriteLine($"O pagamento à vista no dinheiro ou cheque recebe 10% de desconto (R${valor:F2}), " +
                                $"o valor total fica R${desconto:F2}");
                        break;

                        case 2:
                            valor = 15.0 / 100 * 2000;
                            desconto = 2000 - valor;

                            Console.WriteLine($"O pagamento à vista no crédito recebe 15% de desconto(R${valor:F2})," +
                                $" o valor total fica R${desconto:F2}");
                    
                        break;

                        case 3:

                            int parcela = 2000 / 2;
                            Console.WriteLine($"O pagamento parcelado em duas vezes tem parcelas de R${parcela:F2} cada.");
                    
                        break;

                        case 4:

                            valor = ((10.0 / 100) * 2000) + 2000;
                            acrescimo = valor / 4;
                            Console.WriteLine($"O  ́pagamento parcelado em quatro vezes tem acréscimo de 10% de juros, " +
                                $"total de R${valor:F2}, as parcelas ficam R${acrescimo:F2} cada.");
                    
                        break;

                        default:
                            Console.WriteLine("Opção incorreta, tente novamente!");
                        break;
                    }
                }
            } while (escolha != 4);

                Console.ReadLine();
                Console.Clear();
        }
    }
}
