using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiple(63, 7));
        }

         static bool Multiple( int num1, int num2)
        {

           return (num1 % num2 == 0);
        }
    }
}
