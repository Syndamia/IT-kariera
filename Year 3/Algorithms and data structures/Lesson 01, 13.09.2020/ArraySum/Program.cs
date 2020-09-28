using System;
using System.Linq;

namespace ArraySum {
    class MainClass {
        public static int Sum(int[] elements, int index = 0) {
            if (index == elements.Length - 1) {
                return elements[index];
            }

            return elements[index] + Sum(elements, index + 1);
        }

        public static void Main(string[] args) {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(Sum(elements));
        }
    }
}
