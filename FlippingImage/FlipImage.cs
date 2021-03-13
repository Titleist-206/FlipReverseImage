using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlippingImage
{
    class FlipImage
    {
        public int[][] FlipAndInvertImage(int[][] matrix)
        {

            for (int i = 0; i < matrix.Length; i++)
            {
                Array.Reverse(matrix[i]);  //first reverse (flip) each row in the matrix
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j]++;
                    matrix[i][j] %= 2;  //Then invert each value
                }
            }

            return matrix;
        }
    }
}




