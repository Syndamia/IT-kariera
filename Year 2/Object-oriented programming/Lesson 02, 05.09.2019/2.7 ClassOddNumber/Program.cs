using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7_ClassOddNumber {
    class Program {
        static void Main(string[] args) {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            OddNumber.oddNumbers.AddRange(input.Where(n => n % 2 != 0).Select(n => new OddNumber(n)));

            Console.WriteLine(string.Join(", ", OddNumber.oddNumbers));
        }
    }
}
