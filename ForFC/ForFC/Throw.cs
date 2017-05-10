using System;

namespace ForFC
{
    public class Throw
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string ToString()
        {
            return FirstName ?? LastName ?? throw new Exception();
        }

        public string ToString()
        {
            var str = FirstName ?? LastName;
            if (str == null)
                throw new Exception();
            return str;
        }
    }
}
