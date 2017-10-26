using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTestTaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "I have some cheese";
            int count = 0;

            foreach (char item in input)
            {
                if (item == 'e')
                {
                    count++;
                }
            }

            //Console.WriteLine(input);
            //The number of time the character E occurrences is :
            Console.WriteLine(" {0}", count);
            Console.ReadLine();
        }
    }
}
