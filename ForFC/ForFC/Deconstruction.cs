namespace ForFC
{
    public static class Deconstruction
    {
        public class MyClass
        {
            public void Deconstruct (out int x, out string text)
            {
                x = 1;
                text = "Hello, world";
            }
        }

        public static void Foo()
        {
            var obj = new MyClass();
            var (num, str) = obj;

            num += 1;
            str += "!";
        }

        public static void Deconstruct (this string self, out int length, out int hash)
        {
            length = self.Length;
            hash = self.GetHashCode();
        }

        public static void Goo()
        {
            var str = "Hello, world!";
            var (len, hash) = str;

            len += 1;
            hash ^= 0b1010_1100;
        }
    }
}
