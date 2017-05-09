using System;

namespace ForFC
{
    class Tuple6
    {
        static void Function()
        {
            var tuple = CreatePoint(4, 2);
            var x = tuple.Item1;
            var y = tuple.Item2;
        }

        public static Tuple<int, int> CreatePoint(int x, int y)
        {
            return new Tuple<int, int>(x, y);
        }
    }
}
