using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3_FoodShortage {
    class Program {
        static void Main(string[] args) {
            var population = new Dictionary<string, IBuyer>();

            for (int i = int.Parse(Console.ReadLine()); i > 0; i--) {
                var newPerson = Console.ReadLine().Split(' ').ToArray();

                if (newPerson.Length == 3) {
                    population.Add(newPerson[0], new Rebel(newPerson[0], int.Parse(newPerson[1]), newPerson[2]));
                } else {
                    var date = newPerson[3].Split('/').Select(int.Parse).ToArray();
                    population.Add(newPerson[0], new Citizen(newPerson[0], int.Parse(newPerson[1]), newPerson[2], new DateTime(date[2], date[1], date[0])));
                }
            }

            while (true) {
                string input = Console.ReadLine();
                if (input.ToLower() == "end") break;

                if (population.ContainsKey(input)) {
                    population[input].BuyFood();
                }
            }

            Console.WriteLine(population.Values.Sum(b => b.Food));
        }
    }
}
