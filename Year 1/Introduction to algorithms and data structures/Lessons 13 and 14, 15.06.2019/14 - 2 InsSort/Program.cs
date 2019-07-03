using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___2_InsSort {
    class Program {
        static void Main(string[] args) {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            InsertionSort.Sort(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
