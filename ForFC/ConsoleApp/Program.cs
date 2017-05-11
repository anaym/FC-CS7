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
        }

        public override bool Equals(object obj)
        {
            Console.WriteLine("Equals");
            return true;
        }
    }
}
