using System;

namespace Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*** Welcome to Leap Year ***");
            Console.WriteLine(" Enter the year : ");
            int Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Year :" + Year);
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) 
                Console.WriteLine("{0} is a Leap Year.", Year);
            else 
                Console.WriteLine("{0} is not a Leap Year.", Year);
            Console.ReadLine();
        }
    }
}
