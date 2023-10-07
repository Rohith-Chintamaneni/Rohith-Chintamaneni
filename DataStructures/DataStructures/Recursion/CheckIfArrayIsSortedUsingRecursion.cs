using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Recursion
{
   public class CheckIfArrayIsSortedUsingRecursion
    {
        public bool Check(int[] arr)
        {
            return CHeckHelper(arr, 0);
        }
        // my way but there is better way. I am using nested if and else.
        public bool CHeckHelper(int[] arr, int index)
        {
            if (index == arr.Length-1) return true;

            if (arr[index] < arr[index + 1]) return CHeckHelper(arr, index + 1);
            else return false;


        }

        public bool Check2(int[] arr)
        {
            return CHeckHelper2(arr, 0);
        }
        // more elegant way using && instead of if else
        public bool CHeckHelper2(int[] arr, int index)
        {
            if (index == arr.Length - 1) return true;

            return arr[index] < arr[index + 1] && CHeckHelper2(arr, index + 1);
           


        }
        // similarily when want to search in array using recursion you use || condition
    }
}
