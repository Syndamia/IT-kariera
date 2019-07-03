using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___1_BubbleS {
    class Program {
        static void Main(string[] args) {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            BubbleSort.Sort(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
