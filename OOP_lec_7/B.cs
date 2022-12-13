using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OOP_lec_7
{
    internal class B : A
    {
        public override void Method(int x)
        {
            try
            {
                WriteLine("Метод METHOD начал работу");
                base.Method(x);
                WriteLine("Class B. x = {0}", x);
            }
            catch (SmallException ex)
            {
                WriteLine(ex.Message);
                WriteLine(ex.StackTrace);
            }
            catch (LargeException ex)
            {
                WriteLine(ex.Message);
                WriteLine(ex.StackTrace);
            }
            finally
            {
                WriteLine("Метод METHOD закончил работу");
            }
        }
    }
}
