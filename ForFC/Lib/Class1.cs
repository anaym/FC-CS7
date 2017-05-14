using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Class1
    {
        [ThreadStatic]
        public (int Name, int Value) Field;

        public (int Value, int Index) Foo(IEnumerable<int> seq)
        {
            var variable = (0, 1, 2, 3, 4, 5, 6, 7);
            var tuple = new ValueTuple<int, int, int, int, int, int, int, ValueTuple<int>>(0, 1, 2, 3, 4, 5, 6, new ValueTuple<int>(7));
            var cnst = new List<int>(Field.Name + variable.Item8);
            switch (seq)
            {
                case List<int> l when l.Count > 0:
                    return (1, 0);
            }
            

            if (seq is IReadOnlyList<int> list && list.Count > 0)
                return (list[list.Count - 1], list.Count - 1);
            else
                return (seq.LastOrDefault(), -100500);
        }
    }
}
