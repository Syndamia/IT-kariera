using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___5_SRndCol {
    class MatrixSort {
        public static void Sort<T>(T[,] matrix, int colComparator) where T : IComparable<T> {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++) {
                for (int rowToComp = 0; rowToComp < matrix.GetLength(0); rowToComp++) {
                    if(matrix[row, colComparator].CompareTo(matrix[rowToComp, colComparator]) > 0) {
                        SwapRows(matrix, row, rowToComp);
                    }
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
