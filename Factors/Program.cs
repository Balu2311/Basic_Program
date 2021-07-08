using System;

namespace Factors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Welcome to Factors ***");
            int N;
            Console.WriteLine("Please enter your Number number: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("\n{0} th value of factors \n", N);
            for (int i = 1; i * i <= N; i++) // i <= N this use print up to Nth value 
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            //Console.ReadLine();
        }
    }
}
