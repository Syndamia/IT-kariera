using System;

namespace Permutations {
    class MainClass {
        public static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            int[] elements = new int[n];
            for (int i = 1; i <= n; i++) {
                elements[i - 1] = i;
            }

            Permute(0, elements, new int[n], new bool[n]);
        }

        public static void Permute(int index, int[] elements, int[] permuted, bool[] used) {
            if (index >= elements.Length) {
                // Not using string.Join, because the system wouldn't give some points
                foreach (var num in permuted) {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
                return;
            }

            for (int i = 0; i < elements.Length; i++) {
                if (!used[i]) {
                    used[i] = true;
                    permuted[index] = elements[i];
                    Permute(index + 1, elements, permuted, used);
                    used[i] = false;
                }
            }
        }
    }
}
