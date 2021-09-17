using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queues
{
   public class CustomQueueImplementation
   {
       public QueueNode HeadNode;
       public QueueNode TailNode;

       public void Enqueue(int val)
       {
           QueueNode node = new QueueNode(val);
           if (TailNode == null)
           {
               HeadNode = node;
               TailNode = node;
           }
           else
           {
               TailNode.NextNode = node;
               TailNode = node;

           }
       }
        // always deque from last node
        public void Dequeue()
        {
            if(HeadNode == null) return;
           
            HeadNode = HeadNode.NextNode;

            if (HeadNode == null) TailNode = null;
          
        }

    }
}
