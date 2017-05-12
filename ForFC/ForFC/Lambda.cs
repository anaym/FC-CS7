using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ForFC
{
    public class Lambda
    {
        public void Foo()
        {
            //Func<IEnumerable<int>> factorial = () =>
            //{
            //    for (var i = 0; i < 10; i++)
            //        yield return i;
            //};

            async Task<int> Doo(int n) => 1;
        }
    }
}
