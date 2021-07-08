using System;

namespace Even_Odd_nu_print
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Even and Odd numbers");
            Console.WriteLine("Enter the range of number: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEven Numbers : ");
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");

                }
                
            }
            Console.WriteLine("\nOdd Numbers :");

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
