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
                Console.WriteLine("Left Nodes ={0}", root.val);
                root = root.left;
            }
            
        }

        public void PrintRightNodes(TreeNode root)
        {
            while (root != null)
            {
                Console.WriteLine("Right Nodes ={0}", root.val);
                root = root.right;
            }

        }

        public void PreOrderTraversal(TreeNode root)
        {
            if (root == null) return;
            Console.WriteLine("PreOrder={0}", root.val);
            PreOrderTraversal(root.left);
            PreOrderTraversal(root.right);
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
                    Console.WriteLine("pre Order using Iterative={0}", currRoot.val);
                    S.Push(currRoot);
                    currRoot = currRoot.left;
                }

                currRoot = S.Pop();

               

                currRoot = currRoot.right;

            }


        }


        public void InOrderTraversal(TreeNode root)
        {
            if (root == null) return;
            InOrderTraversal(root.left);
            Console.WriteLine("InOrder={0}", root.val);
            InOrderTraversal(root.right);
        }

        // While lo while to go over all left nodes first then pop print and set the currnode to its right
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
                    currRoot = currRoot.left;
                }

                currRoot = S.Pop();

                Console.WriteLine("In Order using Iterative={0}", currRoot.val);

                currRoot = currRoot.right;

            }


        }

        // Not working
        //public void POstOrderTraversalWithOutRecursion(TreeNode root)
        //{

        //    if (root == null) return;

        //    Stack<TreeNode> S = new Stack<TreeNode>();
        //    var currRoot = root;
        //    while (currRoot != null || S.Count > 0)
        //    {

        //        while (currRoot != null)
        //        {
        //            S.Push(currRoot);
        //            currRoot = currRoot.left;
        //        }

        //        currRoot = S.Pop();

               

        //        currRoot = currRoot.right;
        //        Console.WriteLine("POst Order using Iterative={0}", currRoot.val);
        //    }


        //}

        public void PreOrderTraversalWithOutRecursion2(TreeNode root)
        {
            List<int> answer = new List<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            if (root != null)
            {
                s.Push(root);
            }
            TreeNode cur;
            while (s.Count >  0)
            {
                cur = s.Pop();
            
                //  answer.Add(cur.val);            // visit the root
                if (cur.right != null)
                {
                    s.Push(cur.right);          // push right child to stack if it is not null
                }
                Console.WriteLine("Pre Order using Iterative using second method with single loop={0}", cur.val);
                if (cur.left != null)
                {
                    s.Push(cur.left);           // push left child to stack if it is not null
                }
            }
            //return answer;
        }
        public void POstOrderTraversal(TreeNode root)
        {
            if (root == null) return;
            POstOrderTraversal(root.left);          
            POstOrderTraversal(root.right);
            Console.WriteLine("POstOrder={0}", root.val);
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
                Console.WriteLine("Level Order ={0}", currnode.val);
               
                if(currnode.left != null) S.Enqueue(currnode.left);
                if (currnode.right != null) S.Enqueue(currnode.right);
            
            }
           
            
           
           
        }


        void PreOrderTraveringAgain(TreeNode root)
        {

            Stack<TreeNode> s = new Stack<TreeNode>();
            var curr = root;

            while(curr != null || s.Count >0)
            {

                while( curr != null)
                {
                    Console.WriteLine("Preorder =" + curr.val);
                    s.Push(curr.left);
                    curr = curr.left;
                }

                curr = s.Pop();
                curr = curr.right;

            }

        }

        void InOrderTraveringAgain(TreeNode root)
        {

            Stack<TreeNode> s = new Stack<TreeNode>();
            var curr = root;

            while (curr != null || s.Count > 0)
            {

                while (curr != null)
                {
                    s.Push(curr.left);
                    curr = curr.left;
                }

                curr = s.Pop();
                Console.WriteLine("Inorder =" + curr.val);
                curr = curr.right;

            }

        }


    }


   
}
