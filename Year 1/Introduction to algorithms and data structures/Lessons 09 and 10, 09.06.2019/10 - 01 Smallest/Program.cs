using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___1_Smallest {
    class Program {
        static void Main(string[] args) {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //това е много бързо и ефикасно решение, ама отдолу я реших по начина по който искат (подсказката)
            //Console.WriteLine(numbers.OrderBy(x => x).First());

            var minimum = numbers.First();
            for (int i = 1; i < numbers.Length; i++) {
                if(numbers[i] < minimum) minimum = numbers[i];
            }
            Console.WriteLine(minimum);
        }
    }
}
