using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___3_Visualis {
    class Quick {
        public static void Sort<T>(T[] arr) where T : IComparable<T> {
            Sort(arr, 0, arr.Length - 1);
        }

        private static void Sort<T>(T[] arr, int lo, int hi) where T : IComparable<T> {
            if(lo >= hi) {
                return;
            }
            else {
                int p = Partition(arr, lo, hi);
                Console.WriteLine($"Made {p} a pivot");
                Sort(arr, lo, p - 1);
                Sort(arr, p + 1, hi);
            }
        }

        private static int Partition<T>(T[] arr, int lo, int hi) where T : IComparable<T> {
            if (lo >= hi) {
                return lo;
            }
            else {
                int i = lo;
                int j = hi + 1;
                while(true) {
                    while (arr[++i].CompareTo(arr[lo]) < 0) {
                        if(i == hi) break;
                    }
                    while (arr[lo].CompareTo(arr[--j]) < 0) {
                        if(j == lo) break;
                    }

                    if(i >= j) break;
                    Swap(arr, i, j);
                }
                Swap(arr, lo, j);
                return j;
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
