using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTestTaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "I have some cheese";
            Console.WriteLine(input1);
            Console.WriteLine(IsPalindrome(input1));
            Console.WriteLine();
            string input2 = "God saved Eva’s dog";
            Console.WriteLine(input2);
            Console.WriteLine(IsPalindrome(input2));

            //Console.WriteLine("Enter a String");
            //input = Console.ReadLine();

            Console.ReadLine();
        }

        public static bool IsPalindrome(string input)
        {

            int min = 0;
            int max = input.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char text = input[min];
                char word = input[max];

                while (!char.IsLetterOrDigit(text))
                {
                    min++;
                    if (min > max)
                    {
                        return true;
                    }
                    text = input[min];
                }

                // Scan backward for word while invalid.
                while (!char.IsLetterOrDigit(word))
                {
                    max--;
                    if (min > max)
                    {
                        return true;
                    }
                    word = input[max];
                }

                if (char.ToLower(text) != char.ToLower(word))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
