using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATII
{
    internal class Q10
    {
        public Q10()
        {
            string sexo = string.Empty;
            decimal imc = 0, altura = 0, peso = 0;

            Console.WriteLine("QUESTÃO 10");
            Console.WriteLine("");
            Console.WriteLine("Digite a sua altura:");
            altura = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Insira seu peso:");
            peso = decimal.Parse(Console.ReadLine());

            Console.Clear();
            imc = peso / (altura * altura);

            if (imc < 18.5m)
            {
                Console.WriteLine($"Você está abaixo do IMC saudável, seu IMC é: {imc}");
            }
            else if (imc >= 18.5m && imc <= 25)
            {

                Console.WriteLine($"Você tem o IMC ideal e saudável, seu IMC é: {imc}");
            }
            else if (imc >= 25 && imc <= 30)
            {
                Console.WriteLine($"Seu IMC é de uma pessoa acima do peso, seu IMC é: {imc}");
            }
            else
            {
                Console.WriteLine($"Seu IMC é de uma pessoa obesa, seu IMC é: {imc}");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
