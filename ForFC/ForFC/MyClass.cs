using System;

namespace ForFC
{
    public class MyClass
    {
        public MyClass(int x)  => field = x;
        public int Field
        {
            get => field;
            set => field = value;
        }
        ~MyClass() => Console.WriteLine("~");

        private int field;
    }
}
