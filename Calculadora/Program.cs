using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double x, y, total;
            string op;
            Console.WriteLine("Soma");
            Console.WriteLine("Digite um Número: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um Operador: ");
            op = Console.ReadLine();
            Console.WriteLine(x + " " + op);
            Console.WriteLine("Digite um Número: ");
            y = double.Parse(Console.ReadLine());

            switch (op)
            {

                case "+":
                    total = x + y;
                    break;

                case "-":
                    total = x + y;
                    break;

                case "*":
                    total = x + y;
                    break;

                case "/":
                    total = x + y;
                    break;

                case "%":
                    total = x % y;
                    break;


                default:
                    total = 0;
                    break;
            }

            Console.WriteLine(total);
        }
    }
}
