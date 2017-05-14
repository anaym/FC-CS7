using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    struct Program
    {
        static void Main(string[] args)
        {
            var program = (object)new Program();
            Console.WriteLine(program is 2);
            var tuple = (1, 2, 3);
            Console.WriteLine(tuple);
            Console.WriteLine((1, new Program()).Equals((1, new Program())));

            Goo((new List<int>(), new List<int>()));
            //Goo(Tuple.Create(new List<int>(), new List<int>()));

            var ts = ("a", "b");
            (object, object) t = ("a", "b");
            Action <(object, object)> ota = _ => { };
            //Action<(string, string)> sta = ota;

            Action<object> oa = _ => { };
            Action<string> sa = oa;

            Action<Tuple<object, object>> ooa = _ => { };
            //Action<Tuple<string, string>> soa = ooa;

            //t = null;
            Tuple<int, int> o = null;

            var a = 1;
            var b = 2;
            (b, a) = (a, b);

            t.Item1 = 1;

            Console.WriteLine(ts);
            Console.WriteLine(t);

            var n = new BinaryTree.Node(10);
            n.Insert(5);
            n.Insert(15);
            n.Insert(20);
        }

        public static void Goo((IList<int>, IList<int>) tuple)
        { }

        public static void Goo(Tuple<IList<int>, IList<int>> tuple)
        {  }

        public override bool Equals(object obj)
        {
            Console.WriteLine("!!!");
            return true;
        }
    }

    public class BinaryTree
    {
        public object Field;

        public ref object Foo()
        {
            return ref Field;
        }

        public class Node {
            public Node Left;
            public Node Right;
            public int Value;
            public bool IsLeaf => Left == null && Right == null;
            public Node(int value) => Value = value;
            private static Node N;

            public void Insert(int value) {
                ref Node node = ref ChooseNodeForInsert(value);
                if (IsLeaf || node is null)
                    node = new Node(value);
                else
                    node.Insert(value);
            }

            public ref Node ChooseNodeForInsert(int value) {
                if (value >= Value)
                    return ref Right;
                return ref N;
            }
        }
    }
}
