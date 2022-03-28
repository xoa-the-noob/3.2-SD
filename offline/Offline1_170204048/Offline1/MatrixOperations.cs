using System;
using System.Collections.Generic;
using System.Text;

namespace Offline1
{
    class MatrixOperations
    {
        public void trace() {
            Console.WriteLine("Enter size :");
            int n = Convert.ToInt32(Console.ReadLine());
            var trace = 0;
            int[,] matrix = new int[n, n];
            Console.WriteLine("Enter values :");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            /*for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(matrix[i, j]);
                }
            }*/

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        trace = trace + matrix[i, j];
                    }
                }
            }

            Console.WriteLine($"The trace of the matrix is {trace}");
        }
    }
}
