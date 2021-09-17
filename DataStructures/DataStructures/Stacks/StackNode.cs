using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DataStructures.Stacks
{
    public class StackNode
    {
        public int data { get; set; }
        public StackNode NextNode { get; set; }

        public StackNode(int val)
        {
            data = val;
            NextNode = null;
        }
    }
}
