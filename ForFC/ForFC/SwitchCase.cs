using System;
using System.Collections.Generic;
using System.Linq;

namespace ForFC
{
    public class SwitchCase
    {
        public T GetLastOrDefault<T>(IEnumerable<T> seq)
        {
            switch (seq)
            {
                case IList<T> list when list.Count > 0:
                    return list[list.Count - 1];
                case IReadOnlyList<T> list when list.Count > 0:
                    return list[list.Count - 1];
                case null:
                    throw new ArgumentNullException();
                default:
                    return seq.LastOrDefault();
            }
        }
    }


}
 