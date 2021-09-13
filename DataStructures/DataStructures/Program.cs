using System;
using System.Collections.Generic;
using DataStructures.Arrays;
using DataStructures.Arrays.Medium;
using DataStructures.LinkedList;
using DataStructures.Recursion;
using DataStructures.SlidingWindow;
using DataStructures.Sort.MergeSort;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            Console.WriteLine(i++);
            Console.WriteLine(++i);

            //Dictionary<int, int> someDictionary = new Dictionary<int, int>()
            //{
            //    { 2, 10 },
            //    { 3, 10 },
            //    { 4, 10 },
            //    { 5, 10 },
            //};
            //someDictionary.
            //foreach (var VARIABLE in someDictionary.Keys)
            //{

            //    Console.WriteLine(VARIABLE);
            //}


            //TwoSumProblem obj = new TwoSumProblem();
            //var result =  obj.TwoSumNSquare(new int[4] {2,5 ,5,11 }, 10);
            //Console.Write($"Indices = {result[0]}, {result[1]}");

            //  RemoveElementProblem removeElementprbProblem = new RemoveElementProblem();
            // var removeElementprbProblemresult= removeElementprbProblem.RemoveElement(new int[8]{0, 1, 2, 2, 3, 0, 4, 2}, 2);


            RemoveDuplicatesFromSortedArrayProblem r1 = new RemoveDuplicatesFromSortedArrayProblem();
            var s1 = r1.RemoveDuplicates(new int[10] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });

            BuyNSellStockProblemType1 pb1 = new BuyNSellStockProblemType1();
            pb1.MaxProfit(new int[] { 0, 1, 5, 3, 6, 4 });
            //  Console.Write($"value = {s1}");

            SumProblemUsingRecursion sb = new SumProblemUsingRecursion();
            var valsum  = sb.Sum(new int[4] { 5, 7, 93, 10 }, 4); // size of array as second parameter

            CountUsingRecursion cb = new CountUsingRecursion();
            var countvalue = cb.Count(new int[4] { 5, 7, 93, 10 }, 4);


            MaxUsingRecursion MR = new MaxUsingRecursion();
            var Max = MR.Max(new int[4] { 5, 7, 93, 10 }, 4);


            RotateArrayProblem RPA = new RotateArrayProblem();
             RPA.Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3); // rotate 3 positions, the right paramters tells you how many times to rotate


             QuickSort Qs = new QuickSort();
             Qs.QuickSortImplementation(new int[] { 5, 3, 2, 11 , 1,0,-8,10}, 0, 7); // 0 and 4 are start and length of array-1

              //  int[] input = new int[] { 4, 2, 2, 7, 8, 1, 2, 8, 10 };
              //   int targetSum = 8;
              //Console.WriteLine(new SmallestSubArrayProblem().smallestSubarray(targetSum, input));
              LinkedList<int> node = new LinkedList<int>();
              //node.AddAfter(new LinkedListNode<int>(100), 100);
              //node.AddAfter(new LinkedListNode<int>(200), 200);
              

            CustomLinkedList linkedList = new CustomLinkedList();
              linkedList.AddAtEnd(100);
              linkedList.AddAtEnd(200);
              linkedList.AddAtEnd(300);
              linkedList.AddAtEnd(400);
              linkedList.AddAtEnd(500);
              linkedList.AddElementAtStart(50);
              linkedList.AddElementatLocation(150, 2);
              linkedList.AddElementatLocation(20, 0);
              linkedList.DeleteAT(3);
              linkedList.DeleteAT(0);
            linkedList.PrintLinkedList();



           
            
        }
    }
}
