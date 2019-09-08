using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_ClassEvenNumber {
    class Program {
        static void Main(string[] args) {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            foreach(var number in input) {
                if (number % 2 == 0) {
                    EvenNumber.evenNumbers.Add(new EvenNumber(number));
                }
            }
            Console.WriteLine(string.Join(", ", EvenNumber.evenNumbers));
        }
    }
}
