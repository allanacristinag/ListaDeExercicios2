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

            Console.Write("Digitar primeiro valor: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digitar segundo valor: ");
            n2 = double.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.Write("O maior valor é:{0}", n1);

            }
            else if (n1 < n2)
            {
                Console.Write("O maior valor é:{0}", n2);
            
            }
            else
            {
                Console.Write("Os valores digitados são iguais.");
            }


            
           
           

        }
    }
}
