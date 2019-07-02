using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___7_SumNAvg {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int>();

            while(true) {
                try {
                    numbers.Add(int.Parse(Console.ReadLine()));
                } catch (Exception) { break; }
            }

            try { Console.WriteLine($"Sum={numbers.Sum()}; Avg={numbers.Average():F2}"); }
            catch(Exception) { Console.WriteLine("Sum=0; Avg=0.00"); }
        }
    }
}
