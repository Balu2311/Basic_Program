using System;

namespace VowelConsonant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Alphabet is Vowel or Consonant");
            Console.WriteLine(" Enter a character : ");
            char ch = Convert.ToChar(Console.ReadLine().ToUpper());

            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U') //|| ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine(ch + " is a Vowel ");
            }
            else if ((ch >= 'A' && ch <= 'Z')) // || (ch >= 'a' && ch <= 'z'))
            {
                Console.WriteLine(ch + " is a Consonant ");
            }
            else
            {
                Console.WriteLine(ch + " not an Alphabate");
            }
        }
    }
}
