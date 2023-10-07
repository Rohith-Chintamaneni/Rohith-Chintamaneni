using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Recursion
{
    public class Number_of_steps_to_reduce_a_number_to_zero
    {// approach 1:

        int count = 0;
        public int NumberOfSteps(int num)
        {

            NumberOfStepsHelper(num);
            return count;
        }

        public void NumberOfStepsHelper(int num)
        {
            if (num == 0) return;
            count = count + 1;
            if (num % 2 == 0)
            {
                NumberOfStepsHelper(num / 2);
            }
            else // when it is not return any datatype, wrapping with else is very important
                 // (pay close attention by comparing other approaches)
                 //if not result will be wrong
            {
                NumberOfStepsHelper(num - 1); 
            }

           

        }

        //Appraoch 2: More clean way to pass variable in arguments;
        public int NumberOfSteps2(int num)
        {
            int count = 0;
            return NumberOfStepsHelper2(num, count);
        }

        public int NumberOfStepsHelper2(int num, int count)
        {
            if (num == 0) return count;

            if (num % 2 == 0) return NumberOfStepsHelper2(num / 2, count + 1);

            return NumberOfStepsHelper2(num - 1, count + 1);

        }

        // approach 3: no vairable is passed
        public int NumberOfSteps3(int num)
        {

            return NumberOfStepsHelper3(num);
        }

        public int NumberOfStepsHelper3(int num)
        {
            if (num == 0) return 0;

            if (num % 2 == 0) return 1 + NumberOfStepsHelper3(num / 2);

            return 1 + NumberOfStepsHelper3(num - 1);

        }
    }
}
