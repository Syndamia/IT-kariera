using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___5_SRndCol {
    class Program {
        static void Main(string[] args) {
            var sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int R = sizes[0], C = sizes[1], S = sizes[2];

            int[,] matrix = new int[R, C];
            for(int row = 0; row < R; row++) {
                var rowNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for(int col = 0; col < C; col++) {
                    matrix[row, col] = rowNumbers[col];
                }
            }

            MatrixSort.Sort(matrix, S - 1);
            Console.WriteLine("Sorted:");

            for(int row = 0; row < R; row++) {
                for(int col = 0; col < C; col++) {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
