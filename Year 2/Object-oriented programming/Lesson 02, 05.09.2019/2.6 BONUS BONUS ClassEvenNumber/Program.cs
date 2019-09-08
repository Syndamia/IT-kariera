using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6_BONUS_BONUS_ClassEvenNumber {
    class Program {
        static void Main(string[] args) {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            EvenNumber.evenNumbers.AddRange(input.Where(n => n % 2 == 0).Select(n => new EvenNumber(n)));

            Console.WriteLine(string.Join(", ", EvenNumber.evenNumbers));
        }
    }
}
