using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___3_Ranking {
    class SelectionSort {
        public static void Sort<T>(T[] arr) where T : IComparable<T> {
            for (int i = 0; i < arr.Length; i++) {
                for (int j = i + 1; j < arr.Length; j++) {
                    if (arr[j].CompareTo(arr[i]) > 0) {
                        Swap(arr, i, j);
                    }
                }
            }
        }

        private static void Swap<T>(T[] collection, int from, int to) {
            var temp = collection[to];
            collection[to] = collection[from];
            collection[from] = temp;
            Console.WriteLine($"Swapped {collection[to]} with {collection[from]}: {string.Join(" ", collection)}");
        }
    }
}
