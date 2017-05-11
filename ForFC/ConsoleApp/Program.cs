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
            Goo(Tuple.Create(new List<int>(), new List<int>()));

            (object, object) t = ("", "");
            Action <(object, object)> ota = _ => { };
            Action<(string, string)> sta = ota;

            Action<object> oa = _ => { };
            Action<string> sa = oa;

            Action<Tuple<object, object>> ooa = _ => { };
            Action<Tuple<string, string>> soa = ooa;

            t = null;
            Tuple<int, int> o = null;

            var a = 1;
            var b = 2;
            (b, a) = (a, b);

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
}
