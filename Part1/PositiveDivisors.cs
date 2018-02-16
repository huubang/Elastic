using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class PositiveDivisors
    {
        public static IEnumerable<int> Of(int input)
        {
            if (input <= 0)
            {
                throw new ArgumentOutOfRangeException("Input must be a single positive integer.");
            }

            var result = from n in Enumerable.Range(1, input)
                         where (input % n) == 0
                         select n;

            return result;
        }
    }
}
