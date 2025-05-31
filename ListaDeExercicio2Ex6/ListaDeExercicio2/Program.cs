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

            double peso;
            double altura;
            double relacao;

            Console.Write("Qual o peso da pessoa?: ");
            peso = double.Parse(Console.ReadLine());
            Console.Write("Qual a altura da pessoa?: ");
            altura = double.Parse(Console.ReadLine());
            relacao = peso / (altura * altura);

                if (relacao < 20)
            {
                Console.Write("Abaixo do peso");
            }
            if (relacao > 19 && relacao < 25)
            {
                Console.Write("Peso ideal");
            }
            if (relacao > 25)
            {
                Console.Write("Acima do peso");
            }
        }

    }
}
