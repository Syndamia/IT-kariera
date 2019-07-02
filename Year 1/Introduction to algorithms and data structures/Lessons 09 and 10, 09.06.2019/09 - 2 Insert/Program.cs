using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___2_Insert {
    class Program {
        static void Main(string[] args) {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var numToInsert = int.Parse(Console.ReadLine());

            var orderedNumbers = numbers.Append(numToInsert).OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(" ", orderedNumbers));

            Console.WriteLine($"Before: {string.Join(" ", orderedNumbers)}, after: {string.Join(" ", orderedNumbers)}");
        }
    }
}
