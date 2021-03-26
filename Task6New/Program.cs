using System;

namespace Task6New
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
           int i = 1;
            for(int num = 1; num <= 100; num++)
            {
                if(num % i == 0)
                {
                    
                    total += i;
                            i++;

                        if (total == num)
                        {
                           Console.Write(num); 
                        }
                   
                } 
                
                 
            }
        }

    }
}
