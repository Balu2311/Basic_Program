using System;

namespace PowerOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Welcome to Power of 2 values ***");
            Console.WriteLine("Enter the power value: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("power values 2^N: " + N);
            int i = 0;
            int powerofTwo = 1;
            /*while (i < N)
            {
                Console.WriteLine(i + " " + powerofTwo); // this print Index(i) values
                powerofTwo = 2 * powerofTwo;
                i = i + 1;
            }*/
            if (N > 31)
            {
                Console.WriteLine(" Please Enter the value less than 31 ");
                return;
            }
            else
            {
                Console.WriteLine(powerofTwo);
                for (i = 1; i <= N; i++)
                {
                    powerofTwo = powerofTwo * 2;
                    Console.WriteLine(powerofTwo);
                }
            }
        }
    }
}
