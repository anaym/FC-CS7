using System;
using System.Collections.Generic;
using System.Linq;

namespace ForFC
{
    static class Tuple6
    {
        static void Function()
        {
            var tuple = CreatePoint(4, 2);
            var x = tuple.Item1;
            var y = tuple.Item2;

            var sequence = new[] { 1, 2, 3 };
            var result = Find(sequence, i => i > 2);
            Console.WriteLine($"{result.Index}: {result.Value}");
        }

        public static Tuple<int, int> CreatePoint(int x, int y)
        {
            return new Tuple<int, int>(x, y);
        }

        Tuple<T, int> Find_<T>(IEnumerable<int> seq, Predicate<T> p)
        {
            return seq
                .Select((v, i) => Tuple.Create(v, i))
                .FirstOrDefault(pair => p(pair.Item1));
        }

        static (int Value, int Index) Find(IEnumerable<int> seq, Predicate<int> p)
        {
            return seq
                .Select((v, i) => (v, i))
                .FirstOrDefault(pair => p(pair.Item1));
        }
    }
}
