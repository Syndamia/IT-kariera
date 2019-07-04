using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___5_SRndCol {
    class MatrixSort {
        public static void Sort<T>(T[,] matrix, int colComparator) where T : IComparable<T> { //modified bubble sort
            for(int i = 0; i < matrix.GetLength(0); i++) {
                for(int j = 0; j < matrix.GetLength(0) - 1; j++) {
                    if(matrix[j, colComparator].CompareTo(matrix[j + 1, colComparator]) > 0) SwapRows(matrix, j, j + 1);
                }
            }
        }

        private static void SwapRows<T>(T[,] matrix, int rowFrom, int rowTO) {
            var rLength = matrix.GetLength(1);

            var temp = new T[rLength];
            for (int i = 0; i < rLength; i++) {
                temp[i] = matrix[rowTO, i];
            }
            for (int i = 0; i < rLength; i++) {
                matrix[rowTO, i] = matrix[rowFrom, i];
            }
            for (int i = 0; i < rLength; i++) {
                matrix[rowFrom, i] = temp[i];
            }
        }
    }
}
