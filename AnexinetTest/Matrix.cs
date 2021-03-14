using System;
using System.Collections.Generic;
using System.Text;

namespace Anexinet
{
    public static class Matrix
    {
        public static int[][] TransposedMatrix(int[][] matrix)
        {
            if(matrix.Length > 0)
            {
                int[][] transposedMatrix = new int[matrix[0].Length][];
                for (int x = 0; x < transposedMatrix.Length; x++) {
                    transposedMatrix[x] = new int[matrix.Length];
                    for (int i = 0; i < matrix.Length; i++)
                    {
                        transposedMatrix[x][i] = matrix[i][x];
                    }
                }
                return transposedMatrix;
            }
            return new int[0][];
        }
    }
}
