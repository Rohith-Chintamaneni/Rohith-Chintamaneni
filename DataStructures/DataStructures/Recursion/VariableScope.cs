using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Recursion
{
    public class VariableScope
    {
        public void Print(int a)
        {
            if (a == 0) return;
            int m = 10;
            Console.WriteLine(a);
            Console.WriteLine(m);
            --m;
            Print(--a);
        }
    }
}
