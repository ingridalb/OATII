using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATII
{
    internal class Q12
    {
        public Q12() 
        {
            int nota1, nota2, nota3, ME, MA;

            Console.WriteLine("QUESTÃO 12");
            Console.WriteLine();
            Console.WriteLine("Insira seu número de identificação:");
            int identificacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira sua primeira nota:");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira sua segunda nota:");
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira sua terceira nota:");
            nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a sua nota de média dos exercícios:");
            ME = int.Parse(Console.ReadLine());
            Console.Clear();

            MA = (nota1 + nota2 * 2 + nota3 * 3 + ME) / 7;

            if (MA >= 90)
            {
                Console.WriteLine($"Identificação do aluno : {identificacao}");
                Console.WriteLine($"NOTA 1: {nota1}, NOTA 2: {nota2}, NOTA 3: {nota3}, NOTA MÉDIA DE EXERCÍCIOS: {ME}.");
            
                Console.WriteLine($"Média de aproveitamento: {MA}.");
                Console.WriteLine("Conceito A. Parabéns, você foi APROVADO(A)!");
            }
            else if (MA >= 75 || MA < 90)
            {
                Console.WriteLine($"Identificação do aluno : {identificacao}");
                Console.WriteLine($"NOTA 1: {nota1}, NOTA 2: {nota2}, NOTA 3: {nota3}, NOTA MÉDIA DE EXERCÍCIOS: {ME}.");
            
                Console.WriteLine($"Média de aproveitamento: {MA}.");
                Console.WriteLine("Conceito B. Parabéns, você foi APROVADO(A)!");
            }
            else if (MA >= 60 || MA < 75)
            {
                Console.WriteLine($"Identificação do aluno : {identificacao}");
                Console.WriteLine($"NOTA 1: {nota1}, NOTA 2: {nota2}, NOTA 3: {nota3}, NOTA MÉDIA DE EXERCÍCIOS: {ME}.");
            
                Console.WriteLine($"Média de aproveitamento: {MA}.");
                Console.WriteLine("Conceito C. Parabéns, você foi APROVADO(A)!");
            }
            else if (MA >= 40 || MA < 65)
            {
                Console.WriteLine($"Identificação do aluno : {identificacao}");
                Console.WriteLine($"NOTA 1: {nota1}, NOTA 2: {nota2}, NOTA 3: {nota3}, NOTA MÉDIA DE EXERCÍCIOS: {ME}.");
            
                Console.WriteLine($"Média de aproveitamento: {MA}.");
                Console.WriteLine("Conceito D. Que pena, você foi REPROVADO(A)!");
            }
            else
            {
                Console.WriteLine($"Identificação do aluno : {identificacao}");
                Console.WriteLine($"NOTA 1: {nota1}, NOTA 2: {nota2}, NOTA 3: {nota3}, NOTA MÉDIA DE EXERCÍCIOS: {ME}.");
            
                Console.WriteLine($"Média de aproveitamento: {MA}.");
                Console.WriteLine("Conceito E. Que pena, você foi REPROVADO(A)!");
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
