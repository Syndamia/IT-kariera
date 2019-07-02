using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___1_Contains {
    class Program {
        static void Main(string[] args) {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var numToCheck = int.Parse(Console.ReadLine());

            if (numbers.Contains(numToCheck)) { //може и да се използват .Count(), .Any(); (вече с try catch) .First(), .Last(), .Single(), .Where(), .TakeWhile(), .SkipWhile() и още (по-звъртяни) други
                Console.WriteLine("{0} Exists in the List", numToCheck); //за разнообразие го направих така
            }
            else Console.WriteLine($"{numToCheck} Not exists in the list");
        }
    }
}
