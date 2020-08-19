using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string inputString = Console.ReadLine();
            if(checkPalindrome(inputString))
                Console.WriteLine($"{inputString} word is palindrome!");
            else
                Console.WriteLine($"{inputString} word is not palindrome!");

            Console.ReadLine();
        }
        static bool checkPalindrome(string inputString)
        {
            for (int i = 0; i < inputString.Length / 2; i++)
            {
                if (inputString[i] != inputString[inputString.Length - 1 - i])
                    return false;
            }
            return true;
        }

    }
}
