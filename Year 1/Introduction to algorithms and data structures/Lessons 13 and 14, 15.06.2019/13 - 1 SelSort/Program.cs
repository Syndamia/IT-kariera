using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___1_SelSort {
    class Program {
        static void Main(string[] args) {
            var elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            SelectionSort.Sort(elements);
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
