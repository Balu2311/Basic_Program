using System;

namespace Leap_Year_Model2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Welcome to Leap Year ***");
            Console.WriteLine(" Enter the year : ");
            int Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Year :" + Year);
            if (Year % 4 == 0)
            {
                if (Year % 100 != 0)
                {
                    if (Year % 400 == 0)
                    {
                        Console.WriteLine("{0} is a Leap Year.", Year);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a Leap Year.", Year);
                    }

                }
                else
                {
                    Console.WriteLine("{0} is not a Leap Year.", Year);
                }
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year.", Year);
            }
            //   Console.ReadLine();
        }
    }
}
