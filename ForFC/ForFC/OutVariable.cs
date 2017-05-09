using System;

namespace ForFC
{
    public class OutVariable
    {
        public void Goo()
        {
            int result;
            if (int.TryParse("123", out result))
            {
                Console.WriteLine(result + 2);
            }
        }

        public void Foo()
        {
            if (int.TryParse("123", out var result))
            {
                Console.WriteLine(result + 2);
            }
        }
    }
}
