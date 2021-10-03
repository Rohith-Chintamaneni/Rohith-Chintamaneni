using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays._2pointer
{
    class ShortestDistancetoaCharacter
    {
        // Leetcode 821
        public int[] ShortestToChar(string s, char c)
        {
            // Step1: initialize 2 arrays as left and right and set them to max values
            // STep2 : iterate through string(left to right) and start filling the distance after encountering the character
            // Step3: do step 2 now from (right to left on right array)
            // Step 4: Min of both array in to a new array.
            int[] leftarray = new int[s.Length];
            int[] rightarray = new int[s.Length];
            //// step 1
            for (int i = 0; i < s.Length; i++)
            {
                leftarray[i] = Int32.MaxValue;
                rightarray[i] = Int32.MaxValue;

            }

            int runningDistance = Int32.MaxValue;
            // Step2:
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    runningDistance = 0;
                    leftarray[i] = runningDistance;

                }
                else
                {
                    if (runningDistance != Int32.MaxValue)
                    {
                        runningDistance++;
                        leftarray[i] = runningDistance;
                    }
                }
               

            }

            //step 3:
            for (int i = s.Length-1; i >= 0; i--)
            {
                if (s[i] == c)
                {
                    runningDistance = 0;
                    rightarray[i] = runningDistance;

                }
                else
                {
                    if (runningDistance != Int32.MaxValue)
                    {
                        runningDistance++;
                        rightarray[i] = runningDistance;
                    }
                }


            }

            int[] result = new int[s.Length];
            // step4
            for (int i = 0; i < s.Length; i++)
            {
                result[i] = Math.Min(leftarray[i], rightarray[i]);
            }



            return result;
        }

        public int[] ShortestToChar2(string S, char C)
        {
            int[] result = new int[S.Length];
            int head = S.Length + 1;
            int tail = S.Length + 1;

            for (int i = 0, j = S.Length - 1; i < S.Length; i++, j--)
            {
                if (S[i] == C)
                {
                    head = 0;
                }

                if (S[j] == C)
                {
                    tail = 0;
                }

                if (i < j)
                {
                    result[i] = head++;
                    result[j] = tail++;
                }
                else if (i == j)
                {
                    result[i] = Math.Min(head++, tail++);
                }
                else
                {
                    result[i] = Math.Min(head++, result[i]);
                    result[j] = Math.Min(tail++, result[j]);
                }
            }

            return result;
        }
    }
}

