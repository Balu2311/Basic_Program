using System;

namespace Swap_Two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome two the Swap Two Numbers ");
            int number1, number2, temp;
            Console.Write("\nEnter the First Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);
        }
    }
}
