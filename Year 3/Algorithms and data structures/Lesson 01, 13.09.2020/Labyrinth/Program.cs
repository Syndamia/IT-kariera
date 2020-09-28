using System;

namespace Labyrinth {
    class MainClass {
        private const char f = '-'; // floor ; where you can walk on
        private const char w = '*'; // wall
        private const char e = 'e'; // exit

        private static char[,] lab = {
            { f, f, f, w, f, f, f },
            { w, w, f, w, f, w, f },
            { f, f, f, f, f, f, f },
            { f, w, w, w, w, w, f },
            { f, f, f, f, f, f, e }
        };

        private const char v = ':'; // visited

        public static void FindPath(int row = 0, int col = 0) {
            if (!InLabBounds(row, col)) return;

            if (lab[row, col] == e) {
                //Console.WriteLine("Path found!");
                PrintLab();
            }
            else if (lab[row, col] == f) { // if you can walk to it (and it isn't visited)
                lab[row, col] = v;

                FindPath(row - 1, col); // left
                FindPath(row + 1, col); // right
                FindPath(row, col - 1); // up
                FindPath(row, col + 1); // down

                lab[row, col] = f;
            }
        }

        private static bool InLabBounds(int row, int col) {
            return row >= 0 && row < lab.GetLength(0) &&
                   col >= 0 && col < lab.GetLength(1);
        }

        private static void PrintLab() { // Could be improved by generating a string and printing that
            for (int row = 0; row < lab.GetLength(0); row++) {
                for (int col = 0; col < lab.GetLength(1); col++) {
                    Console.Write(lab[row, col]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static void Main(string[] args) {
            FindPath();
        }
    }
}
