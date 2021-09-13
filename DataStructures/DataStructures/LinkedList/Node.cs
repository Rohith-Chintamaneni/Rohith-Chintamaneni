using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    public class Node
    {
        public int data;
        public Node NextNode;

        public Node(int data)
        {
            this.data = data;
            NextNode = null;
        }
    }
}
