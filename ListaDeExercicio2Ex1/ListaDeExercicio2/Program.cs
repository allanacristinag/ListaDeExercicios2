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

            Console.Write("Digite o primeiro valor: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digte o segundo valor: ");
            n2 = double.Parse(Console.ReadLine());

            if (n1 < n2)
            {
                Console.WriteLine("{0} é o maior número", n2);
            }
            else
            {
                Console.WriteLine("{0} é o maior número", n1);
            }
        }
    }
}
