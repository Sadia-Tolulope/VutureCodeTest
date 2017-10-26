using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTaskThreeC
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Anna went to vote in the election to fulfil her civic duty";

            Console.WriteLine("Input");
            Console.WriteLine(input);
            Console.WriteLine();
            input = input.Replace("Anna", "A&&a")
                            .Replace("civic", "c$$$c");
            Console.WriteLine("Output");
            Console.WriteLine(input);

            Console.ReadLine();

        }
    }
}
