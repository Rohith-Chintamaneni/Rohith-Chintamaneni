using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stacks
{

    // custom stack implemented using LinkedLIst
   public class CustomStackUsingLinkedList
   {
       public StackNode topNode;


       public void Push(int val)
       {
           StackNode node = new StackNode(val);
           //if (topNode == null)
           //{
           //    topNode = node;
           //}
           //else
           //{
           //    var temp = topNode;
           //    node.NextNode = temp;
           //    topNode = node;


           //}

            // Improvised version
            node.NextNode = topNode;
            topNode = node;


       }

       public int Pop()
       {
           if (topNode == null)
           {
               return -1;
           }

           var temp = topNode;
           topNode = topNode.NextNode;
           return temp.data;

       }

       public int Peek()
       {
           if (topNode == null)
           {
               return -1;
           }
           return topNode.data;
       }


       public bool IsEmpty()
       {

           return topNode == null;
       }

   }
}
