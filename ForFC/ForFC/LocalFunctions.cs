using System;
using System.Collections.Generic;
using System.Linq;

namespace ForFC
{
    public class LocalFunctions
    {
        public Func<int, int> Foo()
        {
            int weight = 10;
            int Factorial(int n)
            {
                return n <= 1 ? weight : weight * n * Factorial(n - 1);
            }
            return Factorial;
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
