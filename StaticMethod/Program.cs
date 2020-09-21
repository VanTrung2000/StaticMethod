using System;

namespace StaticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Studen.Change();
            Studen s1 = new Studen(12, "trung");
            Studen s2 = new Studen(13, "trung1");
            s1.Display();
            s2.Display();
        }
    }
}
