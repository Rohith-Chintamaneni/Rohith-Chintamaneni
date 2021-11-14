using System;
using System.Collections.Generic;
using DataStructures.Arrays;
using DataStructures.Arrays._2pointer;
using DataStructures.Arrays.JaggedArrays;
using DataStructures.Arrays.Medium;
using DataStructures.BinarySearch;
using DataStructures.BitManipulation;
using DataStructures.Dynamic_Programming;
using DataStructures.Heaps;
using DataStructures.Intervals;
using DataStructures.LinkedList;
using DataStructures.LinkedList.Hard;
using DataStructures.LinkedList.Medium;
using DataStructures.Queues;
using DataStructures.Recursion;
using DataStructures.SlidingWindow;
using DataStructures.SlidingWindow.Medium;
using DataStructures.Sort;
using DataStructures.Sort.CyclicSort;
using DataStructures.Sort.MergeSort;
using DataStructures.Stacks;
using DataStructures.Strings;
using DataStructures.Trees;

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


            TwoSumProblem TsumProblem = new TwoSumProblem();
            var TsumProblemresult = TsumProblem.TwoSumN(new int[3] { 3, 2, 4 }, 6);
            Console.Write($"Indices = {TsumProblemresult[0]}, {TsumProblemresult[1]}");

            //  RemoveElementProblem removeElementprbProblem = new RemoveElementProblem();
            // var removeElementprbProblemresult= removeElementprbProblem.RemoveElement(new int[8]{0, 1, 2, 2, 3, 0, 4, 2}, 2);


            RemoveDuplicatesFromSortedArrayProblem r1 = new RemoveDuplicatesFromSortedArrayProblem();
            var s1 = r1.RemoveDuplicates(new int[10] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });

            BuyNSellStockProblemType1 pb1 = new BuyNSellStockProblemType1();
            Console.WriteLine(pb1.MaxProfit(new[] { 7, 1, 5, 3, 6, 4 }));

            //  Console.Write($"value = {s1}");

            SumProblemUsingRecursion sb = new SumProblemUsingRecursion();
            var valsum = sb.Sum(new int[4] { 5, 7, 93, 10 }, 4); // size of array as second parameter
            var valsum2 = sb.Sum2(new int[4] { 5, 7, 93, 10 });

            var sumproblem = sb.SumOftwoNumbers(10, 2);
            var productProblem = sb.ProductOftwoNumbers(17, 7);
            CountUsingRecursion cb = new CountUsingRecursion();
            var countvalue = cb.Count(new int[4] { 5, 7, 93, 10 }, 4);

            var staticRecursion = CountUsingRecursion.CountRecursiveWithNoVariables(5);

            MaxUsingRecursion MR = new MaxUsingRecursion();
            var Max = MR.Max(new int[4] { 5, 7, 93, 10 }, 4);


            RotateArrayProblem RPA = new RotateArrayProblem();
           // RPA.Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 },3); // rotate 3 positions, the right paramters tells you how many times to rotate
           RPA.Rotate2ndApproach(new[] { 1, 2, 3, 4, 5, 6, 7 }, 3);

            QuickSort Qs = new QuickSort();
            Qs.QuickSortImplementation(new[] { 5, 3, 2, 11, 1, 0, -8, 10 }, 0,
                7); // 0 and 4 are start and length of array-1

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


            var thirdnode = new ListNode(300, new ListNode(400, new ListNode(500)));
            var secondnode = new ListNode(200, thirdnode);
            var head = new ListNode(100, secondnode);
            ReverseLinkedListProblem obj = new ReverseLinkedListProblem();
            var resultlist = obj.ReverseList(head);

            while (resultlist != null)
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
            var palindromeresult = plp.IsPalindrome(head2);

            MiddleOfLinkedList middleOfLinked = new MiddleOfLinkedList();
            var head3 = new ListNode(100)
            {
                next = new ListNode(200)
                {
                    next = new ListNode(402)
                    {
                        next = new ListNode(109)
                        {
                            next = new ListNode(500)
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
            int minwindowsize = ssap.smallestSubarray(8, new[] { 4, 2, 2, 7, 8, 1, 2, 8, 1, 0 });

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
            var afterremovingduplicatenodes = removeDuplicate.RemoveDuplicates(DuplicateListnode);

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
            var responseofRemoveDuplicatesOfSorted = rdfs.RemoveDuplicatesFromSorted(duplicateListnodeSorted);

            RemoveDuplicatesFromSortedArrayProblemAuxStorage aux =
                new RemoveDuplicatesFromSortedArrayProblemAuxStorage();
            var auxstorage = aux.RemoveDuplicates(new int[10] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });


            var removeKthNodefromList = new ListNode(11)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(4)
                            {
                                next = new ListNode(5)

                            }
                        }
                    }
                }

            };

            //  verify the you tube kenny talks. Still not the correct way
            DeleteKthElementFromLinkedList RkNfl = new DeleteKthElementFromLinkedList();
            var ans = RkNfl.RemoveNthFromEnd(removeKthNodefromList, 2);

            MaximumAverageSubarrayProblem MaspUb = new MaximumAverageSubarrayProblem();
            Console.WriteLine("Max Avg of subarray of size 3={0}",
                MaspUb.FindMaxAverage(new[] { 0, 1, 1, 3, 3 }, 4));

            MaximumSumOfAContinousArrayOfSizeK MSASC = new MaximumSumOfAContinousArrayOfSizeK();
            Console.WriteLine("max sum ={0}", MSASC.FindMaxSumSubArray(new[] { 4, 2, 1, 7, 8, 1, 2, 8, 1, 0 }, 3));



            MergeTwoSortedArraysProblem MTSAP = new MergeTwoSortedArraysProblem();
            MTSAP.Merge(new int[6] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3);


            ReversePrefixOfAWordProblem RPOWP = new ReversePrefixOfAWordProblem();
            Console.WriteLine("Reverse Prefix= {0}", RPOWP.ReversePrefix("abcdef", 'd'));

            SquaresofaSortedArrayProblem SOSAP = new SquaresofaSortedArrayProblem();
            var result = SOSAP.SortedSquares(new int[5] { -7, -3, 2, 3, 11 });

            IntersectionofTwoArraysIIProblem IOTP = new IntersectionofTwoArraysIIProblem();
            IOTP.Intersect(new[] { 4, 9, 5 }, new[] { 9, 4, 9, 8, 4 });

            ReverseWordsinaStringIIIProblem RWIASP = new ReverseWordsinaStringIIIProblem();
            Console.WriteLine("Reverse String = {0}", RWIASP.ReverseWords("God Ding"));


            ShortestDistancetoaCharacter SDTOC = new ShortestDistancetoaCharacter();
            var SDTOCresult = SDTOC.ShortestToChar2("loveleetcode", 'e');


            SortArrayByParityProblem SABPA = new SortArrayByParityProblem();
            SABPA.SortArrayByParity(new int[4] { 3, 1, 2, 4 });


            DuplicateArraysProblem DAP = new DuplicateArraysProblem();
            DAP.DuplicateZerosSecondAppraoch(new[] { 0, 4, 1, 0, 0, 8, 0, 0, 3 });

            ValidMountainProblem VMP = new ValidMountainProblem();
            VMP.ValidMountainArray(new[] { 0, 3, 2, 1 });


            int[][] m = { new[] { 2, 3, 4 }, new[] { 3, 4, 5 } };

            RichestCustomerWealth RCW = new RichestCustomerWealth();
            RCW.MaximumWealth(m);

            KidsWiththeGreatestNumberOfCandies numberOfCandies = new KidsWiththeGreatestNumberOfCandies();
            var numofcandiesresult = numberOfCandies.KidsWithCandies(new[] { 2, 3, 5, 1, 3 }, 3);

            var Node1 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(4)

                }
            };

            var Node2 = new ListNode(1)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(4)

                }
            };

            //var Node1 = new ListNode(2);

            //var Node2 = new ListNode(1);


            MergeTwoSortedLists MTSL = new MergeTwoSortedLists();
            var mergerlist = MTSL.MergeTwoLists(Node1, Node2);

            var root = new TreeNode(1);
            root.left = new TreeNode(3);
            root.right = new TreeNode(4);
            root.left.left = new TreeNode(5);
            root.right.right = new TreeNode(6);
            SumFromNodes sFn = new SumFromNodes();
            Console.WriteLine("Sum = {0}", sFn.CalculateSum(root));

            TreeTraversing Tt = new TreeTraversing();
            Tt.PrintLeftNodes(root);
            Tt.PrintRightNodes(root);
            Tt.PreOrderTraversal(root);
            Tt.PreOrderTraversalWithOutRecursion(root);
            Tt.InOrderTraversal(root);
            Tt.InOrderTraversalWithOutRecursion(root);
            Tt.POstOrderTraversal(root);
            Tt.LevelOrderTraversalWithOutRecurrsion(root);

            MaxheapImplementation MHI = new MaxheapImplementation();
            var mhipresult = MHI.MaxHeapSort(new[] { 2, 9, 10, 10, 9, 9 });
            //Console.WriteLine("Max value of Heap = {0}", MHI.Peek(mhipresult));
           



           int[] arr = { 10, 5, 3, 2, 9 };
           int n = arr.Length;
           n = MHI.deleteRoot(arr, n);
           n = MHI.deleteRoot(arr, n);
           n = MHI.deleteRoot(arr, n);
            MHI.printArray(arr, n);

            var btroot = new TreeNode(1);
            btroot.left = new TreeNode(3);
            btroot.right = new TreeNode(4);
            btroot.left.left = new TreeNode(5);
            btroot.left.right = new TreeNode(6);

            BinaryTreeInorderTraversal BTIT = new BinaryTreeInorderTraversal();
            var btitresult = BTIT.InorderTraversal(btroot);

            var sllnode = new TreeNode(3);
            sllnode.left = new TreeNode(9);
            sllnode.right = new TreeNode(20);
            sllnode.right.left = new TreeNode(15);
            sllnode.right.right = new TreeNode(7);
            SumofLeftLeaves Sll = new SumofLeftLeaves();
            var sllans= Sll.SumOfLeftLeaves(sllnode);

            InsertionSort Isort = new InsertionSort();
            var rsultIsort = Isort.InsertionSorting(new[]{ 0, 43, 5, 1, 2, });


            SelectionSort selectionSortj = new SelectionSort();
            var selectionSortjresultSelectionSorting = selectionSortj.SelectionSorting(new[] { 0,43, 5, 1, 2, });

            MajorityElement meMajorityElement = new MajorityElement();
           var memajorityelement= meMajorityElement.MajorityElementProblem(new[] { 3, 1, 2, 3, 3, 3, 3 });


           LongestSubStringWithoutRepeatingCharactersProblem Lswrcp =
               new LongestSubStringWithoutRepeatingCharactersProblem();
          var Lswrcpresult = Lswrcp.LengthOfLongestSubstring("abcabcbb");

          var lswrcpresultbrute = Lswrcp.LengthOfLongestSubstringBFOptimized_O_Nsquare("dvdf");

          ListNode reorderlist = new ListNode(1)
          {
              next = new ListNode(2)
              {
                  next = new ListNode(3)
                  {
                      next = new ListNode(4)
                          { next = new ListNode(5) }
                  }
              }
          };


          ReorderListProblem rlpobj = new ReorderListProblem();
             rlpobj.ReorderList(reorderlist);


             MissingNumberProblem Mnp = new MissingNumberProblem();
             var mnpreslt = Mnp.MissingNumber(new[]{3, 0, 1});

             FindtheDuplicateNumber FtDn = new FindtheDuplicateNumber();
             var Ftdnresult= FtDn.FindDuplicateLinkedList(new[] { 1, 3, 4, 2, 2 });

             MergeKLinkedListProblem MKLp =new MergeKLinkedListProblem();
             var Mklpresponse = MKLp.MergeKLists_Improvised(new[]
             {
                 new ListNode(1){next= new ListNode(4){next = new ListNode(5)}},
                 new ListNode(1){next= new ListNode(3){next = new ListNode(4)}},
                 new ListNode(2){next = new ListNode(6)}
             });


             var jaggedarray = new int[][]
             {
                new int[] { 1, 3 },
                new int[] { 2, 6 },
                new int[] { 8, 10 },
                new int[] { 15, 18 }
             };
             //[1,3],[2,6],[8,10],[15,18]
             BasicsOfJaggedArray BOJA = new BasicsOfJaggedArray();
             BOJA.AccessArrays(jaggedarray);


             MergeIntervalsProblem MIP = new MergeIntervalsProblem();
             var miresult = MIP.MergeAlternate_RC(jaggedarray);

            
             var IIParray = new int[][]
             {
                 new int[] { 1, 5 },
               //  new int[] { 6, 9 },
             };

             
             var newinterval = new int[] { 0, 0 };
             InsertIntervalProblem IIP = new InsertIntervalProblem();
             var IIPresult = IIP.Insert(IIParray, newinterval);

            var nonparameter = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 1, 2 },
                new int[] { 1, 2 },
              //  new int[] { 1, 3 },
                //  new int[] { 6, 9 },
            };
            //[[1,2],[2,3],[3,4],[1,3]]
            NonOverlappingIntervals noi = new NonOverlappingIntervals();
            noi.EraseOverlapIntervals(nonparameter);


            SumofTwoIntegers SOTI = new SumofTwoIntegers();
            Console.WriteLine(SOTI.GetSumLanguageSpecific(15, 8));

            NumberOf1bits nob = new NumberOf1bits();
            nob.HammingWeight(10);


            CountingBits CBs = new CountingBits();
            CBs.CountBits(10);

            ReversingBits rbs = new ReversingBits();
           var rbsresult= rbs.ReverseBitsUsingBitManipulation(14);

           var meetingroomsobject = new int[][]
           {
                new int[]{7, 10},
               new int[] {2, 4}
           };

           MeetingRooms meetingRooms = new MeetingRooms();
          var mrresult= meetingRooms.CanAttendMeetings(meetingroomsobject);


          MeetingRooms2 meetingRooms2 = new MeetingRooms2();
          var mr2result = meetingRooms2.MinMeetingRooms(meetingroomsobject);


          ValidPalindrome vp = new ValidPalindrome();
          Console.WriteLine(vp.isPalindrome2("race a car"));

          HowmanyApplesCanYouPutInBasket HMAB = new HowmanyApplesCanYouPutInBasket();
          Console.WriteLine(HMAB.MaxNumberOfApples(new int[]{ 988, 641, 984, 635, 461, 527, 491, 610, 274, 104, 348, 468, 220, 837, 126, 111, 536, 368, 89, 201, 589, 481, 849, 708, 258, 853, 563, 868, 92, 76, 566, 398, 272, 697, 584, 851, 302, 766, 88, 428, 276, 797, 460, 244, 950, 134, 838, 161, 15, 330 }));


          FibonacciUsingMemoization fum = new FibonacciUsingMemoization();
          Console.WriteLine("Fibonacci Number={0}", fum.CalculateFibonacci(50));


          //FibonacciUsingMemoization fum2 = new FibonacciUsingMemoization();
          //Console.WriteLine("Fibonacci Number without memoization={0}", fum2.FibonacciWithOutMemoization(50));

          KnapsackProblem ksp = new KnapsackProblem();
          Console.WriteLine("Max cost ={0}", ksp.KnapsackDPTopDown(new int[] { 1, 4, 5, 2 }, new int[] { 10, 15, 4, 6 }, 7, 4)); 

        }
    }
}
