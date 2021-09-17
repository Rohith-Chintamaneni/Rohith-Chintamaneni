using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
   public class RemoveDuplicateFromUnSortedLinkedList
    {

        // 3 ways Either use 2 loops or use a merge sort first to sort it and then use algorithm to remove duplicates or use dictonary to keep a list of values which are already traversed.
        public Node RemoveDuplicates(Node headnode)
        {
            Node slowNode;
            Node fastNode;
            Node dummynode = new Node(0);
            dummynode.NextNode = headnode;

            slowNode = headnode;
            fastNode = headnode.NextNode;
            Node tempnode= fastNode;
            while (fastNode != null && fastNode.NextNode != null)
            {
                
                if (slowNode.data == fastNode.data)
                {
                    tempnode.NextNode = fastNode.NextNode;
                    slowNode = tempnode.NextNode;
                    fastNode = fastNode.NextNode;
                }
                tempnode = fastNode;
                fastNode = fastNode.NextNode;
            }

            return dummynode.NextNode;
        }
    }
}
