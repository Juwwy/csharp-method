using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The smallest number of your input is: {Maximum3()}");
        }

        static float Maximum3 ()
        {
            Console.Write("Enter a number: ");
            float num1 = float.Parse(Console.ReadLine());
            
            Console.Write("Enter a number: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.Write("Enter a number: ");
            float num3 = float.Parse(Console.ReadLine());

            float answer = (float)Math.Min(num1, (float)Math.Min(num2, num3));

            return answer;
        }
    }
}
