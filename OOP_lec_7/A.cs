using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OOP_lec_7
{
    public class SmallException : Exception
    {
        public SmallException() : base("ИКС МЕНЬШЕ 1")
        {
        }
    }
    public class LargeException : Exception
    {
        public LargeException() : base("ИКС БОЛЬШЕ 100")
        {
        }
    }
    internal class A
    {
        public virtual void Method(int x)
        {
            if (x <= 1) throw new SmallException();
            if (x > 100) throw new LargeException();
            WriteLine("Class A. x = {0}", x);
        }
    }
}
