using System;
using System.Collections.Generic;
using System.Linq;

namespace ForFC
{
    public class PatternMatching
    {
        public void Foo(object obj)
        {
            var b1 = obj is int number; //с объявлением новой переменной
            var b11 = obj is int;       //без объявления новой переменной
            var b2 = obj is 3;
            var b3 = obj is var o;

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

        public T GetLastOrDefault<T>(this IEnumerable<T> sequence)
        {
            if (sequence is IReadOnlyList<T>)
            {
                var list = (IReadOnlyList<T>)sequence;
                if (list.Count > 0)
                    return list[list.Count - 1];
            }
            else if (sequence != null)
                return sequence.LastOrDefault();
            throw new ArgumentNullException();
        }

        public T GetLastOrDefault<T>(this IEnumerable<T> sequence)
        {
            if (sequence is IReadOnlyList<T> list && list.Count > 0)
                return list[list.Count - 1];
            else if (sequence != null)
                return sequence.LastOrDefault();
            throw new ArgumentNullException();
        }

        public bool IsContains(this Shape shape, Point point)
        {
            switch (shape)
            {
                case Point p:
                    return p == point;
                case Circle c when c.Radius > 0:
                    return c.Centre.DistanceTo(point) <= c.Radius;
                case Rectangle r
                    return 
            }
        }

        public int X;
        public int Y;
    }

    public class Point : Shape
    { }

    public class Shape
    { }
}
