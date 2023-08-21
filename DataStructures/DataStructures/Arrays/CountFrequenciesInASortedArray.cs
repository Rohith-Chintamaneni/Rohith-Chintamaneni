using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class CountFrequenciesInASortedArray
    {
        public void CountFrequencies(int[] arr)
        {
            if (arr.Length == 0) Console.WriteLine(0);
            int count = 1;
            int num = arr[0];
            if (arr.Length == 1) Console.WriteLine("Count of elements at array element{0} = {1} ", num, count);
                

            for(int j=1; j< arr.Length; j++)
            {
                if(arr[j] != num)
                {
                    Console.WriteLine("Count of elements at array element{0} = {1}", num, count);
                    count = 0;
                    num = arr[j];
                }
                count++;
            }
            Console.WriteLine("Count of elements at array element{0} = {1}", num, count);

        }
    }
}
