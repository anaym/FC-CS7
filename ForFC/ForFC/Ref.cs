using System.Collections.Generic;

namespace ForFC
{
    public class Ref
    {
        public object Field;

        public ref object Foo()
        {
            return ref Field;
        }
    }
}
