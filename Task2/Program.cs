using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Hypotenus(5, 8):F}");
        }

        static double Hypotenus(double num1, double num2)
        { 

            double calculate = Math.Sqrt((num1 * num1) + (num2 * num2));

            return calculate;

        }
    }
}
