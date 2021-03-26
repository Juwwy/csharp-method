using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(IntergerPower());
        }

        static int IntergerPower ()
        {
            Console.Write("Enter first number ");
            int answer = int.Parse(Console.ReadLine());

            Console.Write("Enter second number ");
            int exp = int.Parse(Console.ReadLine());
            
            int result = 1;
            if(answer > 0 && exp > 0){
                for(int i = 0; i < exp; i++)
            {
             result *= answer;
            }
            }else{
                Console.Write("Invalid Input");
            }
            return result;
        }
    }
}
