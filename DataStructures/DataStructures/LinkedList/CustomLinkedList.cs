using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    public class CustomLinkedList
    {
        public Node headnode;

        public void AddAtEnd(int val)
        {
            Node newNode = new Node(val);
            if (headnode == null)
            {
                headnode = newNode;
            }
            else
            {
                var tempnode = headnode;
                while (tempnode.NextNode != null)
                {
                    tempnode = tempnode.NextNode;
                }

                tempnode.NextNode = newNode;
            }
        }

        private Node GetLastNode(Node headnode)
        {
            var temp = new Node(0);
            while (headnode.NextNode != null)
            {
                temp = this.headnode.NextNode;
                headnode = headnode.NextNode;
            }

            return temp;
        }

        public void AddElementAtStart(int val)
        {
            Node newNode = new Node(val);
            var temp = headnode;
            if (headnode != null)
            {
                newNode.NextNode = headnode;
                headnode = newNode;
            }

        }

        public void AddElementatLocation(int val, int location)
        {
            Node newNode = new Node(val);
            int count = 0;

            if (location == 0)
            {
                AddElementAtStart(val);
            }
            else
            {
                var tempnode = headnode;
                while (count < location - 1)
                {
                    tempnode = tempnode.NextNode;
                    count++;
                }

                newNode.NextNode = tempnode.NextNode;
                tempnode.NextNode = newNode;
            }


        }

        public void PrintLinkedList()
        {
            var tempnode = headnode;
            while (tempnode.NextNode != null)
            {
                Console.WriteLine(tempnode.data);
                tempnode = tempnode.NextNode;
            }

            Console.WriteLine(tempnode.data); //printing the last element of linkedlist
        }

        public void DeleteAT(int index)
        {
            var count = 0;
            var Cuurentnode = headnode;
            if (index == 0)
            {
                headnode = headnode.NextNode;
            }
            else
            {
                
                

                while (count < index - 1)
                {
                    Cuurentnode = Cuurentnode.NextNode;
                    count++;
                }

                var tempnode = Cuurentnode.NextNode;
                Cuurentnode.NextNode = tempnode.NextNode;
            }
           

        }

        

}
}
