using System;
using System.Collections.Generic;
using System.Linq;

namespace ForFC
{
    public class LocalFunctions
    {
        private static Dictionary<int, int> Cache;

        public int Factorial(int n, int weight)
        {
            if (n < 0) throw new ArgumentException();

            int Factorial(int j)
            {
                return j <= 1 ? weight : weight * j * Factorial(j - 1);
            }

            return Factorial(n);
        }

        public object o = "";
        public IEnumerable<IEnumerable<int>> ToRanges(IEnumerable<int> limits)
        {
            lock (o)
            {
                IEnumerable<int> Range(int n)
                {
                    for (var i = 0; i < n; i++)
                        yield return i;
                }
                Func<int, IEnumerable<int>> range = Range;
                return limits.Select(Range);
            }
        }
    }
}
 