using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Recursion
{
    public class SumofDigitsUsingRecurison
    {
        public int SumofDigits(int n)
        {
          //  if (n / 10 == 0) return n % 10; // I wrote it but this can be changed to simple version
            if (n == 0) return 0;

            int remainder = n % 10;

            return remainder + SumofDigits(n / 10);

        }
    }
}
