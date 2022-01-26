using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
    class CountOfOccurencesInSortedArray
    {
        public FirstOccurenceInSortedArray firstOccrence { get; set; }
        public LastOccurenceInASortedArray LastOccrence { get; set; }
        public CountOfOccurencesInSortedArray()
        {
            firstOccrence = new FirstOccurenceInSortedArray();
            LastOccrence = new LastOccurenceInASortedArray();

        }
      


        public int CountOfOccurences(int[] arr, int target)
        {
            int firstindex = firstOccrence.FirstOccurence(arr, target);
            if (firstindex == -1) return 0;
            else return (LastOccrence.LastOccurence(arr, target) - firstindex + 1);

        }
    }
}
