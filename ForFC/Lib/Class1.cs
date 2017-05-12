using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Class1
    {
        public (int Value, int Index) Foo(IEnumerable<int> seq)
        {
            return new ValueTuple<int, int>(1, 2);

            var cnst = new List<int>();
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
