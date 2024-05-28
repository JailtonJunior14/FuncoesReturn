using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncoesReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escolha a operação:[ +, -, *, / ]");
            string operacao = Console.ReadLine().ToLower();
            Console.WriteLine("Primero numero: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());
            switch (operacao)
            {
                case "+":
                    
                    Console.WriteLine("Resultado: " + Soma(n1, n2));
                    break;
                case "-":
                    Console.WriteLine("Resultado: " + Sub(n1, n2));
                    break;

                case "/":
                    Console.WriteLine("Resultado: " + Divisao(n1, n2));
                    break;

                case "*":
                    Console.WriteLine("Resultado: " + Multi(n1, n2));
                    break;


            }
            Console.ReadKey();

        }
        static double Soma ( double v1, double v2)
        {
            return v1 + v2;
        }
        static double Sub(double v1, double v2)
        {
            return v1 - v2;
        }
        static double Divisao(double v1, double v2)
        {
            return v1 / v2;
        }
        static double Multi(double v1, double v2)
        {
            return v1 * v2;
        }
    }
}
