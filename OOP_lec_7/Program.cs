using OOP_lec_7;
using static System.Console;
B b = new B();
try
{
    b.Method(10);
    b.Method(0);
    b.Method(101);
}
catch (Exception ex)
{
    WriteLine(ex.Message);
    WriteLine(ex.StackTrace);
}