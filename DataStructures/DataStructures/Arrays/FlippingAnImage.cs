using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class FlippingAnImage
    {
        public int[][] FlipAndInvertImage(int[][] image)
        {

            // reverse. If you can do it for half an array the elements are already swapped. 
            for (int i = 0; i < image.Length; i++)
            {
                int colsize = image[i].Length - 1;

                for (int j = 0; j < (image[i].Length) / 2; j++)
                {
                    var temp = image[i][j];
                    image[i][j] = image[i][colsize];
                    image[i][colsize] = temp;
                    colsize--;
                }

            }
            // Flip
            for (int i = 0; i < image.Length; i++)
            {
                for (int j = 0; j < (image[i].Length); j++)
                {
                    if (image[i][j] == 0) image[i][j] = 1;
                    else image[i][j] = 0;
                }
            }

            return image;
        }
    }
}
