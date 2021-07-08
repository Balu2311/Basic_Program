using System;

namespace Flip_Coin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Welcome come to FlipCoin Percentage ***");
            int heads = 0;
            int tails = 0;
            int counter = 0;
            Random coinflip = new Random();
            Console.WriteLine(" Enter the number of times Coin Flip : ");
            counter = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Total Flip Coin Times: " + counter);
            for (int i = 0; i < counter; i++)
            {
                int flip = coinflip.Next(0, 2);
                if (flip < 0.5)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }
            }
            Console.WriteLine("You flipped a coin " + counter + " times " + "and you got " + heads + " Heads and " + tails + " Tails.");
            Console.WriteLine();
            Console.WriteLine("Percentage of Heads: " + heads + "%");
            Console.WriteLine("Percentage of Tails: " + tails + "%");
        }
    }
}
