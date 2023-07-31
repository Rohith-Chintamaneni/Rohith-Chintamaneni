using System;
using System.Collections.Generic;
using DataStructures.Arrays;
using DataStructures.Arrays._2pointer;
using DataStructures.Arrays.JaggedArrays;
using DataStructures.Arrays.Medium;
using DataStructures.BinarySearch;
using DataStructures.BinarySearchArrays;
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
using DataStructures.Graphs;
using DataStructures.LowLevelDesign.SlotMachine;
using DataStructures.MathProblems;
using DataStructures.SimpleForloops;

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
            var palindromeresult = plp.IsPalindrome2(head2);

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
            var ans = RkNfl.RemoveNthFromEnd2(removeKthNodefromList, 2);

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
            IOTP.Intersect2(new[] { 4, 9, 5 }, new[] { 9, 4, 9, 8, 4 });

            IntersectionofTwoArrays IOTA = new IntersectionofTwoArrays();
            IOTA.Intersection(new[] { 4, 9, 5 }, new[] { 9, 4, 9, 8, 4 });

            ReverseWordsinaStringIIIProblem RWIASP = new ReverseWordsinaStringIIIProblem();
            Console.WriteLine("Reverse String = {0}", RWIASP.ReverseWords("God Ding"));


            ShortestDistancetoaCharacter SDTOC = new ShortestDistancetoaCharacter();
            var SDTOCresult = SDTOC.ShortestToChar2("loveleetcode", 'e');


            SortArrayByParityProblem SABPA = new SortArrayByParityProblem();
            SABPA.SortArrayByParity(new int[4] { 3, 1, 2, 4 });


            DuplicateArraysProblem DAP = new DuplicateArraysProblem();
            DAP.DuplicateZerosSecondAppraoch(new[] { 0, 4, 1, 0, 0, 8, 0, 0, 3 });

            ValidMountainProblem VMP = new ValidMountainProblem();
            VMP.validMountainNewWay(new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9});


            int[][] m = { new[] { 2, 3, 4 }, new[] { 3, 4, 5 } };

            RichestCustomerWealth RCW = new RichestCustomerWealth();
           Console.WriteLine("Richest Wealth = {0}", RCW.MaximumWealth(m));

            RichestCustomerWealth RCW1 = new RichestCustomerWealth();
            Console.WriteLine("Richest Wealth using method 2 = {0}", RCW1.MaximumWealth1(m));

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
            root.left.right = new TreeNode(7);
            root.right.right = new TreeNode(6);
            SumFromNodes sFn = new SumFromNodes();
            Console.WriteLine("Sum = {0}", sFn.CalculateSum(root));

            TreeTraversing Tt = new TreeTraversing();
            Tt.PrintLeftNodes(root);
            Tt.PrintRightNodes(root);
            Tt.PreOrderTraversal(root);
            Tt.PreOrderTraversalWithOutRecursion(root);
            Tt.PreOrderTraversalWithOutRecursion2(root);
            Tt.InOrderTraversal(root);
            Tt.InOrderTraversalWithOutRecursion(root);           
            Tt.POstOrderTraversal(root);
         //   Tt.POstOrderTraversalWithOutRecursion(root); failing
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
          var Lswrcpresult = Lswrcp.LengthOfLongestSubstringBF(" ");

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
             var Mklpresponse = MKLp.mergeKListsusingDivideAndConquer(new[]
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

            var secondcase = new int[][]
            {
                new int[]{1, 4 },
                new int[]{0, 2 },
                new int[]{3, 5 }
            };

             MergeIntervalsProblem MIP = new MergeIntervalsProblem();
             var miresult = MIP.MergeAlternate_RC(secondcase);

            
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
          Console.WriteLine("Max cost using recursion with DP ={0}", ksp.KnapsackDPTopDown(new int[] { 1, 4, 5, 2 }, new int[] { 10, 15, 4, 6 }, 7, 4));
          Console.WriteLine("Max cost using Bottom up with DP ={0}", ksp.KnapsackDPBottomUp(new int[] { 1, 4, 5, 2 }, new int[] { 10, 15, 4, 6 }, 7, 4));


          SubsetSum ssSubsetSum = new SubsetSum();
         Console.WriteLine("Does Subset exist = {0}", ssSubsetSum.SubSetSum_DP(new int[] { 2, 3, 6, 8, 10 }, 15, 5));

         PartitionEqualSubsetSum pess = new PartitionEqualSubsetSum();
         Console.WriteLine("Equal Sum Partition Exist = {0}",pess.canPartitionUsingRecursion(new int[] { 1, 2, 3, 7 }));

         CountOfSubSetProblem cosp = new CountOfSubSetProblem();
         Console.WriteLine("Count of subsets in an array equal to input sum ={0}", cosp.COuntOfSubsetUsingRecursion(new int[]{2,3,5,8,10}, 10));

         UnboundKnapsack uksp = new UnboundKnapsack();
         Console.WriteLine("unbound knapsack max cost using recursion={0}", uksp.UnboundknapsackUsingRecursionMemoization(new int[] { 1, 4, 5, 2 }, new int[] { 10, 15, 4, 6 }, 7, 4));

         CoinChangeWithMaximumWays ccwmw = new CoinChangeWithMaximumWays();
         Console.WriteLine("maximum ways to get sum from coin array using DP={0}", ccwmw.CoinChangeWithMaximumWaysDP(new int[] { 1, 2, 5}, 5));
         Console.WriteLine("maximum ways to get sum from coin array using recursion={0}", ccwmw.CoinChangeWithMaximumWaysRecursion_Memoize(new int[] { 1, 2, 5 }, 5));

         CoinChangeProblemMinimumNumberofCoins ccpm = new CoinChangeProblemMinimumNumberofCoins();
         Console.WriteLine("Minimum number of ways to get to sum = {0}", ccpm.CoinChangeUsingRecursionWithMemoize(new int[]{ 1, 2, 5 }, 11));
         Console.WriteLine("Minimum number of ways to get to sum = {0}", ccpm.CoinChangeUsingDP(new int[] { 1, 2, 5 }, 11));


         LongestCommonSubSequenceProblem lcsp = new LongestCommonSubSequenceProblem();
         Console.WriteLine("Longest common Subsequence = {0}", lcsp.LongestCommonSubsequence3("abcde", "ace"));

         LongestCommonSubstringProblem lcsbp = new LongestCommonSubstringProblem();
         Console.WriteLine("Longest common substring = {0}", lcsbp.LongestSubstring("abcde", "abdcf"));

         PrintLongestCommonSubSequence pcls = new PrintLongestCommonSubSequence();
         Console.WriteLine("Printing Longest common Subsequence = {0}", pcls.PrintLongestCommonSubsequence("abcde", "ace", 5,3));

         ShortestCommonSuperSequenceProblem Scssp = new ShortestCommonSuperSequenceProblem();
         Console.WriteLine("Shortest common Super sequence = {0}", Scssp.ShortestCommonSuperSequence_DP("abcdemnk", "acenk", 8, 5));

         MinimumNumberOfInsertionAndDeletion mnoi = new MinimumNumberOfInsertionAndDeletion();
         Console.WriteLine("Minimum number of inserts and deletes = {0}", mnoi.MinimumNumberOfInsertionAndDeletion_DP("heap", "pea", 4, 3));

         LongestPalindromicSubsequenceProblem lpsp = new LongestPalindromicSubsequenceProblem();
         Console.WriteLine("Longest palindrome subsequence  = {0}", lpsp.LongestPalindromeSubsequence("bbbab"));

            SubSetsProblem ssp = new SubSetsProblem();
            var aaspresilt = ssp.findSubsets(new int[] { 1, 2});

            PermutationsProblem Pp = new PermutationsProblem();
            var ppreuslt = Pp.Permute(new int[] { 1, 2, 3 });

            List<int> obj1 = new List<int> { 1, 2, 3 };
            List<int> obj2 = new List<int>(obj1);
            obj2[0] = 100;

            foreach (var item in obj1)
            {
                Console.WriteLine(item);
            }

            foreach (var item in obj2)
            {
                Console.WriteLine(item);
            }

            List<Person> objstr1 = new List<Person> { new Person(1, "Rohtih" ),new Person(2, "ram" )
            };
            List<Person> objstr2 = new List<Person>(objstr1);

            Person p1 = new Person(10, "Ram");
          

            foreach (var item in objstr1)
            {
                Console.WriteLine(item.Age+ " " + item.Name);
            }

            foreach (var item in objstr2)
            {
                Console.WriteLine(item.Age + " " + item.Name);
            }


            //  [1,2,3,4,null,null,5]
            var root1 = new TreeNode(1);
            root1.left = new TreeNode(2);
            root1.right = new TreeNode(3);
            root1.left.left = new TreeNode(4);
            root1.right.right = new TreeNode(5);
            LevelOrderTraversalProblem lotp = new LevelOrderTraversalProblem();
           var levelorderresults = lotp.LevelOrderIterative(root1);

            TreeNode vbst = new TreeNode(20);
            vbst.left = new TreeNode(17);
            vbst.right = new TreeNode(28);
            vbst.left.left = new TreeNode(15);
            vbst.left.left = new TreeNode(16);
            vbst.left.left.left = new TreeNode(10);
            ValidateBinarySearchTreeProblem vbtp = new ValidateBinarySearchTreeProblem();
           Console.WriteLine("Is Give tree a valid binary tree = {0}", vbtp.IsValidBST(vbst));

            TreeNode ksmbstt = new TreeNode(3);
            ksmbstt.left = new TreeNode(1);
            ksmbstt.right = new TreeNode(4);
          //  ksmbstt.left.left = new TreeNode(15);
            ksmbstt.left.right = new TreeNode(2);
            //ksmbstt.left.left.left = new TreeNode(10);
            KthSmallestElementinaBSTProblem ksmbst = new KthSmallestElementinaBSTProblem();
            Console.WriteLine("Kth Smallest Element in a BST = {0}", ksmbst.KthSmallest(ksmbstt, 1));

            PathSumProblem psp = new PathSumProblem();
            Console.WriteLine("PathSum exist? = {0}", psp.HasPathSumIterative(ksmbstt, 10));


            MaxDeptOfBInaryTreeProblem mdobtp = new MaxDeptOfBInaryTreeProblem();
            Console.WriteLine("TOP down Approach of recursion = {0}", mdobtp.MaxDepthTopDown(ksmbstt));
            Console.WriteLine("Bottom Up Approach of recursion = {0}", mdobtp.MaxDepthBottomUp(ksmbstt));

            TreeNode custv = new TreeNode(5);
            custv.left = new TreeNode(1);
            custv.right = new TreeNode(5);
            custv.left.left = new TreeNode(5);
            custv.left.right = new TreeNode(5);
            custv.right.right = new TreeNode(5);
            CountUniValueSubTreesProblem cuvst =new CountUniValueSubTreesProblem();
            Console.WriteLine("Top down Approach of uni value nodes = {0}", cuvst.CountUnivalSubtrees(custv));

            ValidAnagramProblem vap = new ValidAnagramProblem();
            Console.WriteLine("Are the given string form anagram {0}",vap.IsAnagramUsingArray( "anagram",  "samuela"));

            GroupAnagramProblem gap = new GroupAnagramProblem();
            var list = gap.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });

            ValidParenthesesProblem vpp = new ValidParenthesesProblem();
            Console.WriteLine("Is given input has valid parenthesis {0}", vpp.IsValid("()"));

            var muotppa = new int[3][];
            muotppa[0] = new int[] { 1, 3 };
            muotppa[1] = new int[] { 2, 2 };
            muotppa[2] = new int[] { 3, 1 };
        

            MaximumUnitsonaTruckProblem muotp = new MaximumUnitsonaTruckProblem();
            Console.WriteLine("max number of units = {0}", muotp.MaximumUnits(muotppa, 4));

            MaximumSubarrayProblem msp = new MaximumSubarrayProblem();
            Console.WriteLine("Maximum Subarray = {0}", msp.MaxSubArrayKadaneAlgorithm(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));

            ShuffletheArrayProblem sap = new ShuffletheArrayProblem();
            var saps = sap.Shuffle3(new int[] { 2, 5, 1, 3, 4, 7 }, 3);

            FindANumberInSortedArray faisa = new FindANumberInSortedArray();
            Console.WriteLine("the searchindex = {0}", faisa.FindNumberInSortedArrayProblem(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 1));

            FindFirstandLastPositionofElementinSortedArray fflp = new FindFirstandLastPositionofElementinSortedArray();
            var fflpresult = fflp.SearchRange(new int[] { 1, 3, 7, 7, 7, 8, 9 }, 7);

            CountTheElementsInASortedArray cteia = new CountTheElementsInASortedArray();
            var cteiaresult = cteia.COunttheElementsINSortedArrayProblem(new int[] { 1, 3, 7, 7, 7, 8, 9 }, 7);

            FIndPeakElementProblem fpep = new FIndPeakElementProblem();
            var fpepresult = fpep.FindPeakElement(new int[] { 1, 2, 3, 1 });

            PermutationsProblem pp = new PermutationsProblem();
            var ppresult = pp.PermuteUsingSwap(new int[] { 1, 2 });


            var swapNodeslist = new ListNode(99)
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
            SwapNodesInPairsProblem snip = new SwapNodesInPairsProblem();
           // var snipresult = snip.SwapPairsIterative(swapNodeslist);
            var snipresulrrecursive = snip.SwapPairsRecursive(swapNodeslist);

            PascalTriangleProblem ptp = new PascalTriangleProblem();
            var ptpresult = ptp.GeneratePascalTriangle(5);

            PascalTriangle2Problem ptp2 = new PascalTriangle2Problem();
            var ptpresult2 = ptp2.GetRow(3);

            ClimbingStairsProblem csp = new ClimbingStairsProblem();
            var cspresult = csp.ClimbStairsUsingDP(5);

            PrintAdjacentGraphProblem pagp = new PrintAdjacentGraphProblem();
           //initialize
            var adjlist = new List<List<int>>();
            adjlist.Add(new List<int>());
            adjlist.Add(new List<int>());
            adjlist.Add(new List<int>());
            adjlist.Add(new List<int>());
          
            // add list
            var AdjList = pagp.AddEdge(adjlist,0,1) ;         
            AdjList = pagp.AddEdge(adjlist, 0, 2);         
            AdjList = pagp.AddEdge(adjlist, 1, 2);         
            AdjList = pagp.AddEdge(adjlist, 1, 3);
          
            var paganns = pagp.PrintGraph(4, AdjList);

            adjlist.Add(new List<int>());
            adjlist.Add(new List<int>());
            adjlist.Add(new List<int>());
            AdjList = pagp.AddEdge(adjlist, 4, 5);
            AdjList = pagp.AddEdge(adjlist, 5, 6);
            AdjList = pagp.AddEdge(adjlist, 4, 6);
            BFSOFAGraphProblem BFSAgp = new BFSOFAGraphProblem();
            // adjacency list, number of vertices and source vertice 
            var bfsagpresult = BFSAgp.BFS(adjlist, 6, 0);

           BFSAgp.BFSDIS(adjlist, 7);

        
                var edges = new int[][]
                {
                    new int[]{0,1},
                    new int[]{1,2},
                    new int[]{3,4}
                };

            NumberofConnectedComponentsinanUndirectedGraphProblem noccugp = new NumberofConnectedComponentsinanUndirectedGraphProblem();
            var noccupgresult = noccugp.CountComponentsUsingDFS(5, edges);



            IterativeBinarySearchInSortedArray IBSISA = new IterativeBinarySearchInSortedArray();
            Console.WriteLine("Element is found at an index = {0}",IBSISA.FindtheIndexOfElementInSortedArrray(new int[] { 10, 20, 30, 40, 50, 60 }, 50));


            RecursiveBinarySearchOfSortedArray RBSISA = new RecursiveBinarySearchOfSortedArray();
            Console.WriteLine("Element is found at an index using recursion = {0}", RBSISA.BSearchRecursive(new int[] { 10, 20, 30, 40, 50, 60 }, 10, 0, 5));

            ArrangingCoins AC = new ArrangingCoins();
            Console.WriteLine("Number of rows = {0}", AC.ArrangeCoins(5));



            SearchInsertPosition SIP = new SearchInsertPosition();
            Console.WriteLine("Index = {0}", SIP.SearchInsert(new int[] { 1, 2, 5, 6 }, 7));

            FirstOccurenceInSortedArray FoISA = new FirstOccurenceInSortedArray();
            Console.WriteLine("INdex of First Occurence Element ={0}", FoISA.FirstOccurence(new int[] { 10, 20, 30, 30, 30, 50 }, 30));


            LastOccurenceInASortedArray LoISA = new LastOccurenceInASortedArray();
            Console.WriteLine("INdex of Last Occurence Element ={0}", LoISA.LastOccurence(new int[] { 10, 20, 30, 30, 30, 30 }, 30));

            CountOfOccurencesInSortedArray CoISA = new CountOfOccurencesInSortedArray();
            Console.WriteLine("Count of occurences an element exist ={0}", CoISA.CountOfOccurences(new int[] { 10, 20, 30, 30, 30, 30 }, 30));

            CountOf1sInASortedBinaryArray CoASBA = new CountOf1sInASortedBinaryArray();
            Console.WriteLine("Count of 1s in a sorted Binary array={0}", CoASBA.CountOfOnesBinaryArray(new int[] { 0, 0, 0, 0, 1, 1, 1 }));

            SQRT sqr = new SQRT();
            Console.WriteLine("SquareRoot of number {0}= {1}", 16, sqr.SquareOFnumber(16));


            TwoSumProblemIndexed tspi = new TwoSumProblemIndexed();
            var tspiresult = tspi.TwoSumN2pointer(new int[] { 2, 3, 4 }, 6);

            IntersectionofTwoArraysII Iso2 = new IntersectionofTwoArraysII();
            var Iso2result = Iso2.Intersect3(new int[] { 4, 9, 5 }, new int[] {9, 4, 9, 8, 4});
            var Iso2result2 = Iso2.Intersect3(new int[] { 1,2,2,1 }, new int[] { 2,2 });

            TransposeMatrix867 TM = new TransposeMatrix867();
            var matrix = new int[][] { new int[] { 1, 2, 3 },
                                       new int[]{ 4, 5, 6 },
                                       new int[] { 7, 8, 9 }
                                                     };
            var matrix2 = new int[][] { new int[] { 1, 2, 3 },
                                       new int[]{ 4, 5, 6 }
                                      
                                                     };
            var resulttm = TM.Transpose(matrix2);

            ReverseAstring186 reverseAstring = new ReverseAstring186();
            var reverseresult = reverseAstring.ReverseWords(new char[] { 't', 'h', 'e', ' ', 's', 'k', 'y', ' ', 'i', 's', ' ', 'b', 'l', 'u', 'e' });

            AddStrings415 as415 = new AddStrings415();
            var as415result = as415.AddStrings("11", "123");

            FirstUniqueCharacterinaString387 fucs = new FirstUniqueCharacterinaString387();
            var fucsindex = fucs.FirstUniqChar("leetcode");

            FindAllNumbersDisappearedInArray448 fandia = new FindAllNumbersDisappearedInArray448();
            var fandiaresult = fandia.FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 });

            RecursionBasics rb = new RecursionBasics();
            var rbinterative = rb.CountListIterative(new List<int> { 1, 2, 3, 4 });

            var rbrecursion1 = rb.CountListRecursive1(new List<int> { 1, 2, 3, 4 });

            var rbrecursion3 = rb.CountListRecursive3(new List<int> { 1, 2, 3, 4 });


            CanPlaceFlowers605 cpf = new CanPlaceFlowers605();
            var cpfresult = cpf.CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 2);

            RotateString796 rs = new RotateString796();
            var rsresult = rs.RotateString("abcde", "abced");

            SquareRoot Sq = new SquareRoot();
            var sqresult = Sq.FindSquareRoot(11);

            SQRT69 sq69 = new SQRT69();
            var sq69result = sq69.MySqrt(8);


            List<List<int>> fulllist = new List<List<int>>(2);
            Console.WriteLine("Capacity of fulllist={0}", fulllist.Capacity);
            var sublist = new List<int>();
            for (int mk = 0; mk < 4; mk++)
            {
                sublist.Add(mk);
            }
            fulllist.Add(sublist);
            fulllist.Add(sublist);
            fulllist.Add(sublist);
            fulllist.Add(sublist);
            Console.WriteLine("Capacity of fulllist={0}", fulllist.Capacity);
            Console.WriteLine("Capacity of sublist={0}", sublist.Capacity);
            Console.WriteLine("count of fulllist={0}", fulllist.Count);
            Console.WriteLine("COunt of sublist={0}", sublist.Count);


            FiveStarsPatterns Fsir = new FiveStarsPatterns();
            Fsir.Print5StarsInRow(5);

            Fsir.PrintStarsOneInRowBasedOnlines(5);

            Fsir.Pattern3(5);
            Fsir.Pattern4(5);
            Fsir.Pattern5(5);

            SumofDigitsUsingRecurison SDUR = new SumofDigitsUsingRecurison();
            Console.WriteLine("Sum of digits using recurison = {0}", SDUR.SumofDigits(51));

            ReverseDigits RD = new ReverseDigits();
            RD.Reverse1(1294);
            Console.WriteLine("Reversing Digits using method 1 = {0}", RD.sum);

            Console.WriteLine("Reversing Digits using method 2 = {0}", RD.Reverse2(1294));


            CountNumberofZerosUsingRecursion Cnzr = new CountNumberofZerosUsingRecursion();
            Console.WriteLine("COunt of Zeros in a given number = {0}", Cnzr.CountNumberofZeros(0060));

            NumberOfSteps NOS = new NumberOfSteps();
            Console.WriteLine("NUmber of Steps to convert a number to Zero = {0}", NOS.COuntNumberOfStepsToZero(8));

            NumberOfSteps NOS2 = new NumberOfSteps();
            Console.WriteLine("NUmber of Steps to convert a number to Zero = {0}", NOS2.COuntNumberOfStepsToZeroHelper1(14));


            SortedArray sa = new SortedArray();
            Console.WriteLine("IS the given array sorted = {0}", sa.CHeckIfArrayisSorted(new int[] { 3,2, 4, 5, 8, 7 }));

            SortedArray sa1 = new SortedArray();
            Console.WriteLine("IS the given array sorted = {0}", sa1.CHeckIfArrayisSortedHelper1(new int[] { 1, 2, 4, 5, 7, 8 }, 0 , 5));

            LinearSearchUsingRecursion LSUr = new LinearSearchUsingRecursion();
            Console.WriteLine("target is found in given array at index = {0}", LSUr.PerformLinearSearch(new int[] { 1, 2, 4, 5, 7, 8 }, 7));

            LinearSearchUsingRecursion LSUr1 = new LinearSearchUsingRecursion();
            var  resultsforMatchingMultipleElements = LSUr1.PerformSearchForMultipleMatchingElements(new int[] { 1, 2, 7, 7, 7, 8 }, 7);
            foreach (var item in resultsforMatchingMultipleElements)
            {
                Console.WriteLine("Indexes = {0}", item);
            }
           

            ImplementBinarySearch IBS = new ImplementBinarySearch();
            Console.WriteLine("IMplement Binary Search using REcursion. The index for target is {0}", IBS.SearchusingRecursion(new int[] { 1, 4, 5, 6, 8, 9, 13, 18 }, 18));

            ImplementBinarySearch IBS1 = new ImplementBinarySearch();
            Console.WriteLine("IMplement Binary Search using REcursion. The index for target is {0}", IBS1.SearchUsingInteration(new int[] { 1, 4, 5, 6, 8, 9, 13, 18 }, 18));

            SquareRootUsingBinarySearch Srur = new SquareRootUsingBinarySearch();
            Console.WriteLine("Square root of a number = {0}", Srur.FindSquareRootBinarySearch(2));

            Console.ReadLine();

          

            //var slotMachine = CreateSlotMachine();
            //var slotmachineresult = slotMachine.Play();
            //Console.WriteLine(slotmachineresult.ToString());

        }

        public static SlotMachine CreateSlotMachine()
        {
            Console.WriteLine("Please enter the roller Size");
            var rollersize = Convert.ToInt16(Console.ReadLine());
            SlotMachine m = new SlotMachine(rollersize, new List<IRule> {new EvenNumberWinningLottery(), new SameNumberWinningLottery()});
            return m;
        }

    public class Person
        {
            public int Age { get; set; }
            public string Name { get; private set; }
            public Person(int age, string name)
            {
                Age = age;
                Name = name;
            }
        }
    }
}
