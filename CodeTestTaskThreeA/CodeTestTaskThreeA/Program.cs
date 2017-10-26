using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTestTaskThreeA
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] censoredwords = { "cat", "dog", "large" };
            string input = "I have a cat named Meow and a dog name Woof. I love the dog a lot. He is larger than a small horse.";
            var total = 0;
            Console.WriteLine();
            Console.WriteLine("Input");
            Console.WriteLine(input);
            Console.WriteLine();
            Console.WriteLine("Output");
            foreach (string item in censoredwords)
            {

                if (input.Contains(item))
                {

                    Console.Write("{0}: {1},  ", item, TextCount.CountOccurrences(input, item));
                    total += TextCount.CountOccurrences(input, item);
                }
            }

            Console.WriteLine("Total: {0}", total);
            Console.ReadLine();

        }
    }
}
