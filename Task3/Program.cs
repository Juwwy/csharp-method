using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(CalculateCharhges(9));
        }

       static double CalculateCharhges(double hour)
       {
           double cost = 2.00;
           if(hour <=  3)
           {
               return cost;
           }else if (hour <= 20 && hour >3)
           {
               return cost = cost + ((hour-3) * 0.5);
           }else{
               return cost;
           }
       }
    }
}
