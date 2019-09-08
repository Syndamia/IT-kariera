using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___1_MergeSor {
    class Program {
        static void Main(string[] args) {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            MergeSort<int>.Sort(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
