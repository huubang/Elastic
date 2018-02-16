using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string input)
        {
            return input == null || input.Equals(string.Empty);
        }
    }

    public static class EnumerableExtensions
    {
        public static IEnumerable<int> MostAppearance(this IEnumerable<int> sequence)
        {
            var stars = from n in sequence
                        group n by n into grp
                        orderby grp.Count() descending
                        select new
                        {
                            Value = grp.Key,
                            Count = grp.Count()
                        };

            var max = stars.Max(s => s.Count);

            var result = from s in stars
                         where s.Count == max
                         select s.Value;

            return result;
        }
    }
}
