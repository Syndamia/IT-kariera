using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___1_BubbleS {
    class BubbleSort {
        public static void Sort<T>(T[] arr) where T : IComparable<T> {
            for (int i = 0; i < arr.Length; i++) {
                for(int j = 0; j < arr.Length - 1; j++) {
                    if(arr[j].CompareTo(arr[j + 1]) > 0) Swap(arr, j, j + 1);
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
