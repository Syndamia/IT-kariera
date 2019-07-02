using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___5_SumNAvg {
    class Program {
        static void Main(string[] args) {
            int sum = 0; double avg = 0.00;

            try {
                var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                sum = numbers.Sum();
                avg = numbers.Average();
            } catch(Exception) { }

            Console.WriteLine($"Sum={sum}; Average={avg:F2}");
        }
    }
}
