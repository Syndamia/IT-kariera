using System;
using System.Linq;

namespace Combinations {
    class MainClass {
        public static void GenCom(int[] set, int[] vector, int index = 0, int start = 0) {
            if (index >= vector.Length) {
                Console.WriteLine(string.Join(" ", vector));
            }
            else {
                for(int i = start + index; i < set.Length; i++) {
                    vector[index] = set[i];
                    GenCom(set, vector, index + 1, i);
                }
            }
        }

        public static void Main(string[] args) {
            int[] set = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            GenCom(set, new int[k]);
        }
    }
}
