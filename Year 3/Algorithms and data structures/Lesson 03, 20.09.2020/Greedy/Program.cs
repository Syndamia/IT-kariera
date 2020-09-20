using System;
using System.Text;

namespace Greedy {
    class MainClass {
        public static void Main(string[] args) {
            int[] start = { 1, 3, 0, 5, 3, 5,  6,  8,  8,  2, 12 };
            int[] end   = { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            for(int i = 0; i < start.Length; i++) {
                if (end[i] < 0) {
                    continue;
                }

                for (int j = i + 1; j < start.Length - 1; j++) {
                    // Because this is a greedy algorithm, it only works 
                    // when the end array is ordered from smallest to biggest
                    if (start[j] <= end[i]) {
                        // Although I set invalid values to remove a time,
                        // an implementation with a collection might be better
                        start[j] = -1;
                        end[j]   = -1;
                    }
                }
            }

            PrintArray(start);
            PrintArray(end);
        }

        private static void PrintArray(int[] arr) {
            StringBuilder sb = new StringBuilder();

            foreach(int num in arr) {
                if (num > -1) {
                    sb.Append($" {num:D2}");
                }
            }

            Console.WriteLine(sb);
        }
    }
}
