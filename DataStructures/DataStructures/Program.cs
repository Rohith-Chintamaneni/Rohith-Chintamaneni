using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DataStructures.Arrays;
using DataStructures.Arrays.Medium;
using DataStructures.LinkedList;
using DataStructures.Queues;
using DataStructures.Recursion;
using DataStructures.SlidingWindow;
using DataStructures.Sort.MergeSort;
using DataStructures.Stacks;

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
            pb1.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
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


            var thirdnode = new ListNode(300, new ListNode(400, new ListNode(500, null)));
            var secondnode = new ListNode(200, thirdnode);
            var head = new ListNode(100, secondnode);
            ReverseLinkedListProblem obj = new ReverseLinkedListProblem();
           var resultlist = obj.ReverseList(head);

           while (resultlist !=null)
           {
               Console.WriteLine(resultlist.val);
               resultlist = resultlist.next;
           }

            PalindromeLinkedListProblem plp = new PalindromeLinkedListProblem();
            var head2 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    
                    next = new ListNode(3)
                    {
                        next = new ListNode(2)
                        {
                            next = new ListNode(1)
                        }
                      
                    }
                }
            };
            var palindromeresult  = plp.IsPalindrome(head2);

            MiddleOfLinkedList middleOfLinked = new MiddleOfLinkedList();
            var head3 = new ListNode(100)
            {
                next = new ListNode(200)
                {
                    next = new ListNode(402)
                    {
                        next = new ListNode(109)
                        {
                            next =   new ListNode(500)
                        }
                    }
                }
            };
            var middleNoderesult = middleOfLinked.MiddleNode(head3);



            CustomStackUsingLinkedList stackobj = new CustomStackUsingLinkedList();
            var isempty = stackobj.IsEmpty();
            stackobj.Push(10);
            stackobj.Push(20);
            var isempty2 = stackobj.IsEmpty();
            var peekedobj = stackobj.Peek();
            var poppedval = stackobj.Pop();
            var peekedobj2 = stackobj.Peek();
            var poppedval2 = stackobj.Pop();



            CustomQueueImplementation queueImplementation = new CustomQueueImplementation();
            queueImplementation.Enqueue(10);
            queueImplementation.Enqueue(20);
            queueImplementation.Enqueue(30);
            queueImplementation.Dequeue();
            queueImplementation.Dequeue();
            queueImplementation.Dequeue();
            queueImplementation.Dequeue();

            SmallestSubArrayProblem ssap = new SmallestSubArrayProblem();
           int minwindowsize = ssap.smallestSubarray(8, new int[] { 4, 2, 2, 7, 8, 1, 2, 8, 1, 0 });

           var DuplicateListnode = new Node(12)
           {
               NextNode = new Node(11)
               {
                   NextNode = new Node(12)
                   {
                       NextNode = new Node(21)
                       {
                           NextNode = new Node(41)
                           {
                               NextNode = new Node(43)
                               {
                                   NextNode = new Node(21)
                               }
                           }
                       }
                   }
               }

           };

           RemoveDuplicateFromUnSortedLinkedList removeDuplicate = new RemoveDuplicateFromUnSortedLinkedList();
          var afterremovingduplicatenodes= removeDuplicate.RemoveDuplicates(DuplicateListnode);

          var duplicateListnodeSorted = new ListNode(11)
          {
              next = new ListNode(11)
              {
                  next = new ListNode(11)
                  {
                      next = new ListNode(21)
                      {
                          next = new ListNode(43)
                          {
                              next = new ListNode(43)
                              {
                                  next = new ListNode(60)
                              }
                          }
                      }
                  }
              }

          };

          RemoveDuplicatesFromSortedList rdfs = new RemoveDuplicatesFromSortedList();
          var responseofRemoveDuplicatesOfSorted= rdfs.RemoveDuplicatesFromSorted(duplicateListnodeSorted);


        }
    }
}
