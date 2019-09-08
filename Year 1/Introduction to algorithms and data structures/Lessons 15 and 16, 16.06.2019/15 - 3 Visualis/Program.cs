using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___3_Visualis {
    class Program {
        static void Main(string[] args) {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var numbers1 = new int[numbers.Length];
            Array.Copy(numbers, numbers1, numbers.Length);

            Console.WriteLine("Merge sort:");
            MergeSort<int>.Sort(numbers);

            Console.WriteLine("Quick sort:");
            Quick.Sort(numbers1);

            Console.WriteLine("Sorted:");
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
