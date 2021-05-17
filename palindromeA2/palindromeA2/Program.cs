using System;

namespace palindromeA2
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "Sator Arepo Tenet Opera Rotas";
            string reversed = Reverse(original);
            bool isPalindrome = IsPalindrome(original);

            Console.WriteLine("Original=" + original);
            Console.WriteLine("Reversed=" + reversed);
            Console.WriteLine("isPalindrome=" + isPalindrome);
        }

        private static string Reverse(string text)
        {
            char[] reversed = new char[text.Length];
            /*
             *   index =>        | Length (=5)
             *--------------------------------
             *  0 | 1 | 2 | 3 | 4 |
             *--------------------------------
             *  H | e | l | l | o |
             *--------------------------------
             *    |   |   |   |   |
             *--------------------------------
             * 1) when Index = 0 => 4 (Length - index - 1)
             * 2) when Index = 1 => 3 (Length - index - 1)
             * 3) when Index = 2 => 2 (Length - index - 1)
             * 4) when Index = 3 => 1 (Length - index - 1) 
             * 5) when Index = 4 => 0 (Length - index - 1)
             */

            for (int index = 0; index < text.Length; index++)
            {
                char c = text[index];
                int indexInReversed = text.Length - index - 1;
                reversed[indexInReversed] = c;
            }
            return new string(reversed);

        }

        private static bool IsPalindrome(string text);
        {
            string reversed = Reverse(text);
            bool isPalyndrome = string.Equals(text, reversed, StringComparison.OrdinalIgnoreCase);
            return isPalyndrome;
        }
    }
}
