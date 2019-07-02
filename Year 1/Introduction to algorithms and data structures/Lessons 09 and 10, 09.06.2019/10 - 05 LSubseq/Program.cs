using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___5_LSubseq {
    class Program {
        static void Main(string[] args) {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int currLength = 1, longestLength = 1, repeatedNum = numbers.First();
            for(int i = 0; i < numbers.Count - 1; i++) {
                if (numbers[i] == numbers[i + 1]) {
                    currLength++;
                    if (currLength > longestLength) {
                        longestLength = currLength;
                        repeatedNum = numbers[i];
                    }
                }
                else currLength = 1;
            }

            var longestSubsequence = new List<int>();
            for(int i = 0; i < longestLength; i++) longestSubsequence.Add(repeatedNum);
            Console.WriteLine(string.Join(" ", longestSubsequence));
        }
    }
}