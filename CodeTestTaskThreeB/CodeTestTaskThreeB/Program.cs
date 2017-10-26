using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeTestTaskThreeB
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "I have a cat named Meow and a dog name Woof. I love the dog a lot. He is larger than a small horse!";
            string[] censoredword = { "meow", "woof" };
            string censoredText = "$$$$";
            string pattern = @"(eo|oo)";

            IEnumerable<Regex> censoredWordMatchers = censoredText.
                         Select(x => new Regex(string.Format(pattern.ToLower(), x)));

            string output = censoredWordMatchers.
                    Aggregate(input, (current, matcher) => matcher.Replace(current, censoredText));

            Console.WriteLine("Input");
            Console.WriteLine(input);
            Console.WriteLine();
            Console.WriteLine("Output");
            Console.WriteLine(output);
            Console.ReadLine();

        }
    }
}
