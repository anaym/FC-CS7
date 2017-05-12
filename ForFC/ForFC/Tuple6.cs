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

            new ValueTuple<int, int>

            var fod = sequence.Select(i => new { Value = i, Index = i }).FirstOrDefault();
        }

        public static Tuple<int, int> CreatePoint(int x, int y)
        {
            return new Tuple<int, int>(x, y);
        }

        Tuple<int, int> Find(IEnumerable<int> seq, Predicate<int> p)
        {
            return seq
                .Select((v, i) => new Tuple<int, int>(v, i))
                .First(pair => p(pair.Item1));
        }

        static (int Value, int Index) Find(IEnumerable<int> seq, Predicate<int> p)
        {
            return seq
                .Select((v, i) => (v, i))
                .First(pair => p(pair.Item1));
        }
    }
}
