using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_library
{
    
        public delegate string AttachStringToEachOther(string s1, string s2);

        class A
        {
            public string ConcatStrings(string s1, string s2)
            {
                return s1 + s2;
            }
        }


    
}
