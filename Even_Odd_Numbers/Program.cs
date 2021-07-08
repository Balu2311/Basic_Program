using System;

namespace Even_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Even and Odd check Numbers");
            Console.WriteLine("Enter a Number : ");
            int numb = Convert.ToInt32(Console.ReadLine());
            if (numb % 2 == 0)
                Console.WriteLine(numb + " is Even Number");
            else
                Console.WriteLine(numb + " is Odd Number");
        }
    }
}
