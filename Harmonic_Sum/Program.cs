using System;

namespace Harmonic_Sum
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("*** Welcome to Harmonic Sum ");
            int i, N;
            double s = 0.0;

            Console.Write("Enter the Harmonic Number: ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            if(N<0)
            {
                Console.WriteLine("Please Enter the Positive Value");
            }
            for (i = 1; i <= N; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.Write("\n\nSum of Series upto {0} terms : {1} \n", N, s);
        }
    }
}
