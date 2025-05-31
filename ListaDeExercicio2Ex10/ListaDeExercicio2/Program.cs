using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, media;

            Console.Write("qual o valor da primeira prova?: ");
            p1 = double.Parse(Console.ReadLine());
            Console.Write("Qual o valor da primeira prova?: ");
            p2 = double.Parse(Console.ReadLine());
            media = (p1 + (2 * p2)) / 3;

            if (media < 5)
            {
                Console.Write("Aluno reprovado");
            }
            else
            {
                Console.Write("Aluno aprovado");
            }

           
        }
    }
}
