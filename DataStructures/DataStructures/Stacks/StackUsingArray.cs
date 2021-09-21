using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stacks
{
    public class StackUsingArray
    {
        private int size;
        private int top;
        private int[] stackarray;

        public StackUsingArray(int sizeofstack)
        {
            this.size = sizeofstack;
            top = -1;
            stackarray = new int[this.size];
        }

        public void Push(int val)
        {
            stackarray[++top] = val;
        }

        public int Pop()
        {
            return stackarray[top--];
        }
    }
}
