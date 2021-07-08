using System;

namespace Compute_Quotient_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Dividend : ");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Divisor : ");
            int divisor = Convert.ToInt32(Console.ReadLine());


            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend: " + dividend + " Divisor: " + divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
