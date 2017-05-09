using System;

namespace ForFC
{
    class Tuple7_1
    {
        static void Function()
        {
            var point = CreatePoint(4, 2);
            var x = point.X;
            var y = point.Y;
        }

        public static (int X, int Y) CreatePoint(int x, int y)
        {
            return (x, y);
        }

        public static void Do()
        {
            var tuple = (1, 2);         //неименованный кортеж
            var named = (X: 1, Y: 2);   //именованный кортеж

            tuple.Item2 = 3;
            named.Y = 3;

            var (x, y) = tuple;
            (x, y) = named;
        }
    }
}
