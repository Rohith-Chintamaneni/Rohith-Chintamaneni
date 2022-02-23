using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.CoreUtilities.Extensions;

namespace DataStructures.Arrays
{
    class AddStrings415
    {
        public string AddStrings(string num1, string num2)
        {
           
            int i = num1.Length-1;
            int j = num2.Length-1;

            int carry = 0; 
            StringBuilder result = new StringBuilder();
         
            // STep 1 : convert a character to int
            // to get the remainder use %
            // to get the carry use divide
            // use stringBUilder to add each result
            // return stringbuilder in reverse.
            while (i >= 0 || j >= 0)
            {
                var firstnum = i >= 0 ? num1[i] - '0': 0;
                var secondnum = j >= 0 ? num2[j] - '0': 0;
                int value = (firstnum + secondnum + carry)% 10;
                carry = (firstnum + secondnum + carry) / 10;
                result.Append(value);
                i--;
                j--;
            }

            if (carry != 0)
            {
                result.Append(carry);
            }

            return new string(result.ToString().Reverse().ToArray());
        }
    }
}
