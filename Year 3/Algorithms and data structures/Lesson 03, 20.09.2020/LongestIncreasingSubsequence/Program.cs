using System;
using System.Collections.Generic;

namespace LongestIncreasingSubsequence {
    class MainClass {
        static int[] seq = { 3, 14, 5, 12, 15, 7, 8, 9, 11, 10, 1 };
        static int[] len = new int[seq.Length];

        static int[] prevIndex = new int[seq.Length];
        static int maxIndex; // maximum value for a prevIndex (representing the longest subsequence)

        public static void Main(string[] args) {
            FindAllSubsequences();

            List<string> solutions = new List<string>();
            AddSolutionsTo(solutions);

            Console.WriteLine(string.Join("\n", solutions));
        }

        public static void FindAllSubsequences() {
            len[0] = 1;
            prevIndex[0] = -1;

            for (int i = 1; i < seq.Length; i++) {
                prevIndex[i] = -1;

                if (seq[i] > seq[i - 1]) {
                    if (i - 1 > maxIndex) {
                        maxIndex = i - 1;
                    }

                    len[i] = len[i - 1] + 1;
                    prevIndex[i] = i - 1;
                    continue;
                }

                for (int j = i - 1; j >= 0; j--) {
                    if (seq[i] > seq[j]) {
                        if (j > maxIndex) {
                            maxIndex = j;
                        }

                        len[i] = len[j] + 1;
                        prevIndex[i] = j;
                        break;
                    }
                }
            }
        }

        public static void AddSolutionsTo(List<string> solutions) {
            for (int i = 0; i < seq.Length; i++) {
                if (prevIndex[i] == maxIndex) {
                    // Using an array that is filled with the properly ordered
                    // values is used for optimisation purposes

                    string[] solution = new string[maxIndex - 1];

                    // Solution is filled in reverse order, so numbers go 
                    // from smallest (on index 0) to biggest (on last index)
                    solution[solution.Length - 1] = $"{seq[i]} }}";

                    for (int j = solution.Length - 2, k = maxIndex; j >= 0; j--) {
                        if (j == 0) {
                            solution[j] = $"{{ {seq[k]}, ";
                        }
                        else {
                            solution[j] = $"{seq[k]}, ";
                        }
                        k = prevIndex[k];
                    }

                    solutions.Add(string.Join("", solution));
                }
            }
        }

        public static void PrintResults() {
            /* This is my original printing method, it prints ALL subsequences.
             * It is left as an (legacy) alternative to printing the results.           
             * 
             * Pros: doesn't require prevIndex and maxIndex (less memory)
             *       nicer code  
             *       a bit faster
             * Cons: requires more processing (compared to memory)
             *       possibilities are ordered biggest to smallest  
             *       prints ALL of the subsequences
             */            

            List<int> lis = new List<int>();

            for (int i = len.Length - 1; i >= 0; i--) {
                lis.Add(seq[i]);

                for (int j = i - 1; j >= 0; j--) {
                    if (len[j] == len[i] - lis.Count) {
                        lis.Add(seq[j]);
                    }
                }

                lis.Reverse();
                Console.WriteLine("{ " + string.Join(", ", lis) + " }");
                lis.Clear();
            }
        }
    }
}
