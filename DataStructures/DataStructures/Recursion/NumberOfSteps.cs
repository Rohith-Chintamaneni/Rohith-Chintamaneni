using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Recursion
{
    public class NumberOfSteps
    {
        // I have to count so this tells me that I need to keep a variable to track now many steps are required.
        // Hence it makes sense to use a helper function
        public int COuntNumberOfStepsToZero(int n)
        {
            return COuntNumberOfStepsToZeroHelper(n, 0);
        }
        // passed accumalator as a variable inside method. Count in this case
        private int COuntNumberOfStepsToZeroHelper(int n, int count)
        {
            if (n == 0) return count;

            if (n % 2 == 0)           
            {                
                return COuntNumberOfStepsToZeroHelper(n / 2, count+1);
            }
            return COuntNumberOfStepsToZeroHelper(n - 1, count + 1);
        }

        // used accumaltor inside the recursive call itself
        public int COuntNumberOfStepsToZeroHelper1(int n)
        {
            if (n == 0) return 0;
            int count = 0;
            if (n % 2 == 0)
            {
                count++;
                count += COuntNumberOfStepsToZeroHelper1(n / 2);
            }
            else
            {
                count++;
                count += COuntNumberOfStepsToZeroHelper1(n - 1);
            }

            return count;
        }
    }
}
