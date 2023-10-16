using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings
{
    public class ExcelSheetColumn
    {  // Just like how numbers are added 19+1 => 20 29+1 => 30 same way the alphabets are added but in number system we start with 0 here they A=1 since you need to sutract 1 for remainder and quotient 
        // very interesting problem: This is to the base 26. When you have number greater than AZ,it becomes BA. 
        public string ConvertToTitle(int columnNumber)
        {
            StringBuilder sb = new StringBuilder();
            while (columnNumber > 0)
            {
                int offset = (columnNumber - 1) % 26;
                sb.Append((char)(65 + offset));
                columnNumber = (columnNumber - 1) / 26;
            }

            return new string(sb.ToString().Reverse().ToArray());
        }

    }
}
