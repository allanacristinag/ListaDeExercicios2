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

            double baze;
            double altura;
            double area;

            Console.Write("Digite o valor da base do retângulo: ");
            baze = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura do retângulo: ");
            altura = double.Parse(Console.ReadLine());
            area = baze * altura;

            if (area > 100)
            {
                Console.Write("Terreno grande");
            }
            else
            {
                Console.Write("Terreno pequeno");
            }
        }
    }
}
