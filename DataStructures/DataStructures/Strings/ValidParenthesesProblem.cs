using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings
{
    class ValidParenthesesProblem
    {
        Dictionary<char, char> map = new Dictionary<char, char>();
        
        public bool IsValid(string s)
        {
            map.Add('(', ')');
            map.Add('{', '}');
            map.Add('[', ']');

            var arry = s.ToCharArray();
            Stack<char> stack = new Stack<char>();

            foreach (var item in arry)
            {
                if(map.ContainsKey(item)) 
                stack.Push(item);
                else
                {
                    if (stack.Count == 0) return false;

                    var prev = stack.Pop();
                    if (item != map[prev]) return false;
                }

            }

            return stack.Count == 0;
        }
    }
}
