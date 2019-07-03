using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___3_Visualiz {
    class Program {
        static void Main(string[] args) {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var numbers1 = new int[numbers.Length];
            Array.Copy(numbers, numbers1, numbers.Length);

            Console.WriteLine("Insertion sort:");
            InsertionSort.Sort(numbers);

            Console.WriteLine("Bubble sort:");
            BubbleSort.Sort(numbers1);

            Console.WriteLine("Final sort:");
            Console.WriteLine(string.Join(" ", numbers1));
        }
    }
}
