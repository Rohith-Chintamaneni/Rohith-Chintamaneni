using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class Panagram
    {
        public bool CheckIfPangram(string sentence)
        {
            var ispangram = true;
            // two pass solution
            int[] letters = new int[126];
            Array.Fill(letters, 0);
            var characters = sentence.ToCharArray();
            // you can declare array of 26 characters and subtract -'a' 
            for (int i = 0; i < characters.Length; i++)
            {
                letters[characters[i]] = letters[characters[i]] + 1;
            }
           
            for (int i = 97; i <= 122; i++)
            {
                if (letters[i] != 0) ispangram = false;
            }

            return ispangram;

        }
    }
}
