using System;

namespace ForFC
{
    public class Throw
    {
        public void Foo(string str)
        {
            str = str ?? throw new ArgumentNullException("", nameof(str));
        }

        public void Old(string str)
        {
            if (str == null)
                throw new ArgumentException("", nameof(str));
        }
    }
}
