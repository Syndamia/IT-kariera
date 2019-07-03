using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ReverseNumbers {
    class Program {
        static void Main(string[] args) {
            //това е (най-вероятно) най-бързия начин, но в задачата искат да използваме Pop и Put(Push)
            //var numbers = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));

            var numbersArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var numbers = new Stack<int>();
            foreach(var n in numbersArr) {
                numbers.Push(n);
            }

            //не е нужно да използваме .Reverse понеже Stack е тип "Last in, first out"
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
