using System;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Escolha qual o sinal que deseja fazer a operação:");
            Console.WriteLine("Adição(+)");
            Console.WriteLine("Subtração(-)");
            Console.WriteLine("Multiplicação(*)");
            Console.WriteLine("Divisão(/)");
            string opera = Console.ReadLine();

            if (opera == "+")
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Insira o primeiro numero:");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Insira o segundo numero:");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Insira o terceiro numero:");
                double num3 = double.Parse(Console.ReadLine());

                var result = num1 + num2 + num3;

                Console.WriteLine("--------------------------------------");

                Console.WriteLine(result);

            }

            else if (opera == "-")
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Insira o primeiro numero:");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Insira o segundo numero:");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Insira o terceiro numero:");
                double num3 = double.Parse(Console.ReadLine());

                var result = num1 - num2 - num3;

                Console.WriteLine("--------------------------------------");

                Console.WriteLine(result);

            }

            else if (opera == "*")
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Insira o primeiro numero:");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Insira o segundo numero:");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Insira o terceiro numero:");
                double num3 = double.Parse(Console.ReadLine());

                var result = num1 * num2 * num3;

                Console.WriteLine("--------------------------------------");

                Console.WriteLine(result);

            }

            else if (opera == "/")
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Insira o primeiro numero:");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Insira o segundo numero:");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Insira o terceiro numero:");
                double num3 = double.Parse(Console.ReadLine());

                var result = num1 / num2 / num3;

                Console.WriteLine("--------------------------------------");

                Console.WriteLine(result);

            }









        }
    }
}
