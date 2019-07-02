using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___15_Fashion {
    class Program {
        static void Main(string[] args) {
            var numbers = Console.ReadLine().Split(' ', ',').Where(x => x != "").Select(int.Parse).ToArray();

            var numComm = new Dictionary<int, int>();
            foreach(var n in numbers.Distinct()) {
                numComm.Add(n, numbers.Count(x => x == n));
            }
            numComm = numComm.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);

            if (numComm.Count(pair => pair.Value == numComm.First().Value) > 1) {
                //по условие пише да извадим средно аритметично ама в примера сумата им е разделена с по колко са се повтаряли (всяко по отделно, не общо)
                Console.WriteLine(numComm.Where(pair => pair.Value == numComm.First().Value).Sum(pair => pair.Key) / numComm.First().Value);
            }
            else {
                Console.WriteLine(numComm.First().Key);
            }
        }
    }
}