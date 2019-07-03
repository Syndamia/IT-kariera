using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___2_InsSort {
    class InsertionSort {
        public static void Sort<T>(T[] arr) where T : IComparable<T> {
            for (int i = 0; i < arr.Length; i++) {
                var currItem = arr[i];
                for (int j = 0; j < arr.Length - 1; j++) {
                    if(currItem.CompareTo(arr[j]) < 0) Swap(arr, i, j);
                }
            }
        }

        private static void Swap<T>(T[] collection, int from, int to) {
            var temp = collection[to];
            collection[to] = collection[from];
            collection[from] = temp;
        }
    }
}
