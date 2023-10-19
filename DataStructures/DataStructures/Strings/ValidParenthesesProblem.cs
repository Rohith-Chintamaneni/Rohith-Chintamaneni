using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings
{
    class ValidParenthesesProblem
    {
      
        
        public bool IsValid(string s)
        {
            Dictionary<char, char> map = new Dictionary<char, char>();
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

        public bool IsValid2(string s)
        {

            Stack<char> stack = new Stack<char>(); // create an empty stack
            foreach (var c in s.ToCharArray())
            { // loop through each character in the string
                if (c == '(') // if the character is an opening parenthesis
                    stack.Push(')'); // push the corresponding closing parenthesis onto the stack
                else if (c == '{') // if the character is an opening brace
                    stack.Push('}'); // push the corresponding closing brace onto the stack
                else if (c == '[') // if the character is an opening bracket
                    stack.Push(']'); // push the corresponding closing bracket onto the stack
                else if (stack.Count == 0 || stack.Pop() != c) // if the character is a closing bracket
                                                               // if the stack is empty (i.e., there is no matching opening bracket) or the top of the stack
                                                               // does not match the closing bracket, the string is not valid, so return false
                    return false;
            }
            // if the stack is empty, all opening brackets have been matched with their corresponding closing brackets,
            // so the string is valid, otherwise, there are unmatched opening brackets, so return false
            return stack.Count == 0;
        }
    }
}
