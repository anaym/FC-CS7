using System;
using System.Collections.Generic;
using System.Linq;

namespace ForFC
{
    public class PatternMatching
    {
        public void Foo(object obj)
        {
            if (obj is int i && i > 0)
            {

            }

            switch (obj)
            {
                case int j when j > 0:
                    break;
                case PatternMatching p when X > 0:
                    break;
            }
        }

        public List<T> CastToArray<T>(this IEnumerable<T> sequence)
        {
            if (sequence is List<T> arr)
                return arr;
            return sequence.ToList();
        }

        public List<T> CastToArray<T>(this IEnumerable<T> sequence)
        {
            if (sequence is List<T>)
                return (List<T>)sequence;
            return sequence.ToList();
        }

        public int X;
        public int Y;
    }
}
