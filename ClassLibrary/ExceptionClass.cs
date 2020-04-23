using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MyException : Exception
    {
        public MyException(bool f1, bool f2, bool f3)
        {
            flag1 = f1;
            flag2 = f2;
            flag3 = f3;
        }

        public bool flag1
        {
            get;
        }

        public bool flag2
        {
            get;
        }

        public bool flag3
        {
            get;
        }
    }
}
