using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___5_CrossRun {
    class Program {
        static void Main(string[] args) {
            var dayOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var dayTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var runners = CombineArrays(dayOne, dayTwo);
            SelectionSort.Sort(runners);

            Console.WriteLine(string.Join(" ", runners));
        }

        private static int[] CombineArrays(int[] first, int[] second) {
            var combinedArr = new int[first.Length + second.Length];

            for(int i = 0; i < first.Length; i++) {
                combinedArr[i] = first[i];
            }
            for(int j = 0; j < second.Length; j++) {
                combinedArr[j + first.Length] = second[j];
            }
            return combinedArr;
        }
    }
}
