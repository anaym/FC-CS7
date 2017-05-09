namespace ForFC
{
    class Tuple7
    {
        static void Function()
        {
            (var x, var y) = CreatePoint(4, 2);
        }

        public static (int, int) CreatePoint(int x, int y)
        {
            return (x, y);
        }
    }
}
