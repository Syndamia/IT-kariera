using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._8_MultipleOfK {
    class Program {
        static void Main(string[] args) {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            MultipleOfK.multiplesOfK.AddRange(input.Where(n => n % k == 0).Select(n => new MultipleOfK(n)));

            Console.WriteLine(string.Join(", ", MultipleOfK.multiplesOfK));
        }
    }
}
