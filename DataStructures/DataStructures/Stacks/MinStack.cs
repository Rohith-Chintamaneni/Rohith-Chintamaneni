using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stacks
{
    public class MinStackProblem
    {
        private Stack<int> valueStack;
        private Stack<int> minstack ;
            /** initialize your data structure here. */
            public MinStackProblem()
            {
                valueStack = new Stack<int>();
                minstack = new Stack<int>();
            }

            public void Push(int val)
            {
                if (valueStack.Count == 0)
                {
                    valueStack.Push(val);
                    minstack.Push(val);
                }
                else if(val < minstack.Peek())
                {
                    valueStack.Push(val);
                    minstack.Push(Math.Min(val, minstack.Peek()));
                }
                else
                {
                    valueStack.Push(val);
                    minstack.Push(minstack.Peek());
                }
            }

            public void Pop()
            {
                valueStack.Pop();
                minstack.Pop();
            }

            public int Top()
            {
                return valueStack.Peek();
            }

            public int GetMin()
            {
               return minstack.Peek();
            }
        
    }
}
