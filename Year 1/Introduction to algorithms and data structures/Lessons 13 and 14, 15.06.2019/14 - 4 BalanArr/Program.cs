using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___4_BalanArr {
    class Program {
        static void Main(string[] args) {
            var size = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            BubbleSort.Sort(numbers, size);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
