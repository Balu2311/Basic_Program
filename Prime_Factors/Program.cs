using System;

namespace Prime_Factors
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter the number to get its Prime Factor : ");
            int N = Convert.ToInt32(Console.ReadLine());
            //primeFactors(N);
            while (N % 2 == 0)
            {
                Console.Write(2 + " ");
                N /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(N); i += 2)
            {
                while (N % i == 0)
                {
                    Console.Write(i + " ");
                    N /= i;
                }
            }
            if (N > 2)
                Console.Write(N);
        }
    }
}

