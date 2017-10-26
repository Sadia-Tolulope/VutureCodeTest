using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTestTaskThreeA
{
    public static class TextCount
    {
        public static int CountOccurrences(string text, string pattern)
        {
            int count = 0;
            int i = 0;
            //int total = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
                //total += i;
            }

            return count;

        }
    }
}
