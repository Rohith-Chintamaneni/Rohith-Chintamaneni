using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataStructures.Arrays
{
    [TestClass]
    public class TwoSumTest
    {
        [DataTestMethod]
        [DataRow(new int[4] { 2, 7, 11, 15 }, 9)]
        [TestMethod]
        public void ArraySumofTwoTest(int[] arr, int target)
        {
            TwoSumProblem prb = new TwoSumProblem();
            CollectionAssert.AreEqual(new int[2] { 0, 1 }, prb.TwoSumN(arr, target));
        }

        [DataTestMethod]
        [DataRow(new int[3] { 3, 2, 4 }, 6)]
        [TestMethod]
        public void ArraySumofTwoTestEx2(int[] arr, int target)
        {
            TwoSumProblem prb = new TwoSumProblem();
            CollectionAssert.AreEqual(new int[2] { 1, 2 }, prb.TwoSumN(arr, target));
        } [DataTestMethod]
        [DataRow(new int[2] { 3,3}, 6)]
        [TestMethod]
        public void ArraySumofTwoTestEx3(int[] arr, int target)
        {
            TwoSumProblem prb = new TwoSumProblem();
            CollectionAssert.AreEqual(new int[2] { 0, 1 }, prb.TwoSumN(arr, target));
        }
    }
}
