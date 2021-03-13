using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlippingImage
{
    class Program
    {
        static void Main(string[] args)
        {
            var flipImage = new FlipImage();  //Instantiate our class

            int[][] matrix = new int[3][];  //Create a jagged array, populate
            matrix[0] = new int[] { 1, 1, 0 };
            matrix[1] = new int[] { 1, 0, 1 };
            matrix[2] = new int[] { 0, 0, 0 };

            flipImage.FlipAndInvertImage(matrix); 
        }
    }
}




//Input: image = [[1, 1, 0],[1,0,1],[0,0,0]]
//Output:[[1,0,0],[0,1,0],[1,1,1]]
//Explanation: First reverse each row: [[0,1,1],[1,0,1],[0,0,0]].
//Then, invert the image: [[1,0,0],[0,1,0],[1,1,1]]