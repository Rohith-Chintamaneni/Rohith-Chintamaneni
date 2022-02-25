using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Recursion
{
    class RecursionBasics
    {
        public int CountListIterative(List<int> n)
        {
            int count = 0;
            for (int i = 0; i < n.Count; i++)
            {
                count++;
            }

            return count;
        }

        // recursion 1
        public int CountListRecursive1(List<int> n)
        {
            if (n.Count ==0) return 0;
            
            return 1+CountListRecursive1(n.Skip(1).ToList());
        }

        public int CountListRecursive2(List<int> n, int count)
        {
            if (n.Count == 0) return count;

            return CountListRecursive2(n.Skip(1).ToList(), count+1);
        }


        public int CountListRecursive3(List<int> n)
        {
            if (n.Count == 0) return 0;

            int count = 1;
            count+= CountListRecursive3(n.Skip(1).ToList());
            return count;
        }
    }
}
