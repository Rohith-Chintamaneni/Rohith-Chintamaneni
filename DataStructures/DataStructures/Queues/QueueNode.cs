using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queues
{
    public class QueueNode
    {
        public int data;
        public QueueNode NextNode;

        public QueueNode(int data)
        {
            this.data = data;
            NextNode = null;
        }
    }
}
