using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace DataStructures.Trees
{
    public class TreeTraversing
    {
        public void PrintLeftNodes(TreeNode root)
        {
            while (root != null)
            {
                Console.WriteLine("Left Nodes ={0}", root.data);
                root = root.leftNode;
            }

        }

        public void PrintRightNodes(TreeNode root)
        {
            while (root != null)
            {
                Console.WriteLine("Right Nodes ={0}", root.data);
                root = root.rightNode;
            }

        }

        public void PreOrderTraversal(TreeNode root)
        {
            if (root == null) return;
            Console.WriteLine("PreOrder={0}", root.data);
            PreOrderTraversal(root.leftNode);
            PreOrderTraversal(root.rightNode);
        }

        public void PreOrderTraversalWithOutRecursion(TreeNode root)
        {

            if (root == null) return;

            Stack<TreeNode> S = new Stack<TreeNode>();
            var currRoot = root;
            while (currRoot != null || S.Count > 0)
            {

                while (currRoot != null)
                {
                    Console.WriteLine("pre Order using Iterative={0}", currRoot.data);
                    S.Push(currRoot);
                    currRoot = currRoot.leftNode;
                }

                currRoot = S.Pop();

               

                currRoot = currRoot.rightNode;

            }


        }


        public void InOrderTraversal(TreeNode root)
        {
            if (root == null) return;
            InOrderTraversal(root.leftNode);
            Console.WriteLine("InOrder={0}", root.data);
            InOrderTraversal(root.rightNode);
        }

        public void InOrderTraversalWithOutRecursion(TreeNode root)
        {

            if (root == null) return;

            Stack<TreeNode> S = new Stack<TreeNode>();
            var currRoot = root;
            while (currRoot != null || S.Count > 0)
            {

                while (currRoot != null)
                {
                    S.Push(currRoot);
                    currRoot = currRoot.leftNode;
                }

                currRoot = S.Pop();

                Console.WriteLine("In Order using Iterative={0}", currRoot.data);

                currRoot = currRoot.rightNode;

            }


        }


        public void POstOrderTraversal(TreeNode root)
        {
            if (root == null) return;
            POstOrderTraversal(root.rightNode);
            Console.WriteLine("POstOrder={0}", root.data);
            POstOrderTraversal(root.leftNode);
        }





        public void LevelOrderTraversalWithOutRecurrsion(TreeNode root)
        {
            if (root == null) return;
            var currnode = root;
            Queue<TreeNode> S = new Queue<TreeNode>();
            S.Enqueue(currnode);
            while ( S.Count >0)
            {
                currnode = S.Dequeue();
                Console.WriteLine("Level Order ={0}", currnode.data);
               
                if(currnode.leftNode != null) S.Enqueue(currnode.leftNode);
                if (currnode.rightNode != null) S.Enqueue(currnode.rightNode);
            
            }
           
            
           
           
        }
    }


   
}
