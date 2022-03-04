using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings
{
    class RotateString796
    {
        public bool RotateString(string s, string goal)
            {
                if (s.Length != goal.Length) return false;
                int scounter = 0;
                int gcounter = 0;

                for (int i = 0; i < s.Length; i++)
                {

                    if (s[scounter] != goal[gcounter])
                    {
                        scounter++;
                    }
                    else if ((s[scounter] == goal[gcounter]))
                    {
                        scounter++;
                        gcounter++;
                    }
                }

           // start checking again from first character
                int startindex = 0;
                for (int i = gcounter; i < goal.Length; i++)
                {
                    if (startindex < (goal.Length - gcounter) && s[startindex] != goal[i])
                    {
                        return false;
                    }
                    startindex++;

                }
                return true;
            }
        }
    
}
