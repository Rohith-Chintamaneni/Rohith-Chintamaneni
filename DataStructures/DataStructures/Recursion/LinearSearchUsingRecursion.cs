using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Recursion
{
    public class LinearSearchUsingRecursion
    {
        public int PerformLinearSearch(int[] arr, int target)
        {
            return PerformLinearSearchHelper(arr, target, 0);
        }

        private int PerformLinearSearchHelper(int[] arr, int target, int index)
        {
            if (index >= arr.Length) return -1;

            if(arr[index] == target) return index;

            return PerformLinearSearchHelper(arr, target, index + 1);


        }
        // In this example, we are creating a list in each function call and when returning we are checking if there is any from below function calls include my answer also, which is avaiable only for that function call.
        // THis approach is still not the best implementation because we are creating a list in each function call
        // A Better way to do is you create a empty list and pass the empty list as one of parameter and add the answers to empty list and finally return it
        // THis is to showcase how we can also handle when list's are created in each function call 
        public List<int> PerformSearchForMultipleMatchingElements(int[] arr, int target)
        {
            return PerformSearchForMultipleMatchingElementsHelper(arr, target, 0);
        }

        private List<int> PerformSearchForMultipleMatchingElementsHelper(int[] arr, int target, int index)
        {
            List<int> list = new List<int>();

            if (index >= arr.Length - 1) return list;
            // The answer is added only to that function call but can't be passed to below function calls
            if (arr[index] == target) list.Add(index);

            //var ansfrombelowFunctioncalls = PerformSearchForMultipleMatchingElementsHelper(arr, target, index + 1);
            //ansfrombelowFunctioncalls.AddRange(list);
            //return ansfrombelowFunctioncalls;

            // whether you want to add your results to below ans or add ans list to your function call list both can work but order will be changed
            var listfrombelowFunctioncalls = PerformSearchForMultipleMatchingElementsHelper(arr, target, index + 1);
            list.AddRange(listfrombelowFunctioncalls);
            return list;
        }
    }
}
