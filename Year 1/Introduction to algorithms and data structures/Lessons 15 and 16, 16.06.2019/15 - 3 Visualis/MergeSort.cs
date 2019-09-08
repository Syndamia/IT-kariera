using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___3_Visualis {
    class MergeSort<T> where T : IComparable {
        private static T[] aux;
        public static void Sort(T[] arr) {
            aux = new T[arr.Length];
            Sort(arr, 0, arr.Length - 1);
        }

        private static void Merge(T[] arr, int lo, int mid, int hi) {
            if (arr[mid].CompareTo(arr[mid + 1]) < 0) {
                return;
            }
            else {
                for (int index = lo; index < hi + 1; index++) {
                    aux[index] = arr[index];
                }

                int i = lo;
                int j = mid + 1;
                for (int k = lo; k <= hi; k++) {
                    if (i > mid) {
                        Console.WriteLine($"Replaced {arr[k]} with {aux[j ]}");
                        arr[k] = aux[j++];
                    }
                    else if (j > hi) {
                        Console.WriteLine($"Replaced {arr[k]} with {aux[i ]}");
                        arr[k] = aux[i++];                      
                    }
                    else if (aux[i].CompareTo(aux[j]) < 0) {
                        Console.WriteLine($"Replaced {arr[k]} with {aux[i ]}");
                        arr[k] = aux[i++];
                        
                    }
                    else {
                        Console.WriteLine($"Replaced {arr[k]} with {aux[j]}");
                        arr[k] = aux[j++];
                        
                    }
                }
            }
        }

        private static void Sort(T[] arr, int lo, int hi) {
            if (lo >= hi) {
                return;
            }
            else {
                int mid = (lo + hi) / 2;
                Console.WriteLine($"Mid is now {mid}");
                Sort(arr, lo, mid);
                Sort(arr, mid + 1, hi);
                Merge(arr, lo, mid, hi);
            }
        }
    }
}
