using System;

namespace Harmonice_Number
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("*** Welcome to Harmoni Nth Number find ***");
            Console.WriteLine("Enter the Nth value: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Harmonic values:  " + N);
            int i ;
            double s = 0.0;
            if (N <= 0 )
            {
                Console.WriteLine(" Please Enter the Positive value ");
                return;
            }
            else
            {
                for (i = 1; i <= N; i++)
                {
                    Console.Write("1/{0}  ", i);
                    s = 1 / (float)i;
                    
                }
                Console.Write("\n\n{0}th Harmonic Number : {1} \n", N, s);
                //Console.Write("\nSum of Series upto {0} terms : {1} \n", N, s); // s += 1 / (float)i;  Sum of the harmonic value
            }

        }
    }
}
