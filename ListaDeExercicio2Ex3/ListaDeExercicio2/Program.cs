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
            double n1;
            double n2;
            double n3;

            Console.Write("Digite o primeiro valor: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            n3 = double.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)

            {
                Console.Write("O maior valor é:{0}", n1);
            }

            if (n2 > n1 && n2 > n3)
            {
                Console.Write("O maior valor é:{0}", n2);
            }

            if (n3 > n1 && n3 > n2)
            {
                Console.Write("O maior valor é:{0}", n3);
            }
            else
            {
                Console.Write("Os valores digitados são iguais.");
            }
                

            
            
        }
    }
}
