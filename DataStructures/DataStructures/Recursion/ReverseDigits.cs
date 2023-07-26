using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Recursion
{
    public class ReverseDigits
    {

        public int sum = 0;  // we are using an external variable to handle the calculations. Which is why you don't need anything inside the recursion.
        public void Reverse1(int n)
        {
            if (n == 0) return;
            int remainder = n % 10;
            sum = sum * 10 + remainder;
            Reverse1(n / 10);
        }

        // IMP:Sometimes you might need additionals variables in the functions.
        // At this point you can use the helper methods with additional variables
        // and those helper methods can go into recursion
        public int Reverse2(int n)
        {

            int digits = (int)Math.Log10(n) + 1;
            return ReverseHelper(n, digits);
           
        }

        private int ReverseHelper(int n, int digits)
        {
            if (n % 10 == n) return n;

            var remainder = n % 10;
            var totalsum = remainder * (int)Math.Pow(10, digits - 1) + ReverseHelper(n / 10, digits - 1);
            return totalsum;
        }
    }
}
/* VIMP
 * 3 things to remember
 * Aruguments to be passed to recurisive calls
 * variables used in the body, will be accessible only inside the body
 * return type. 
 *
 * */