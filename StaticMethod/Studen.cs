using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethod
{
    class Studen
    {
        private int rollno;
        private string name;
        private static string college = "BBDIT";

        public Studen(int r, string n)
        {
            rollno = r;
            name = n;
        }
        public static void Change()
        {
            college = "PHUXUAN";
        }
        public void Display()
        {
            Console.WriteLine(rollno + "  " + name + "  " + college);
        }
    }
}
