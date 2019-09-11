using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_and._2_Border_control_and_Birthday {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Task 8.1 test:");

            List<IIdentifiable> currPopulation = new List<IIdentifiable>();

            while (true) {
                var input = Console.ReadLine().Split(' ').ToArray();
                if (input[0].ToLower() == "end") break;

                if (input.Length == 2) {
                    currPopulation.Add(new Robot(input[1], input[0]));
                }
                else {
                    currPopulation.Add(new Citizen(input[0], int.Parse(input[1]), input[2], new DateTime()));
                }
            }
            string fakeIdEnding = Console.ReadLine();

            foreach (var fake in currPopulation.Where(p => p.HasFakeId(fakeIdEnding))) {
                Console.WriteLine(fake.Id);
            }

            Console.WriteLine();
            Console.WriteLine("Task 8.2 test:");

            List<IBirthable> livingPopulation = new List<IBirthable>();

            while (true) {
                var input = Console.ReadLine().Split(' ').ToArray();
                if (input[0].ToLower() == "end") break;

                switch (input[0]) {
                    case "Citizen":
                        int[] date = input.Last().Split('/').Select(int.Parse).ToArray();
                        livingPopulation.Add(new Citizen(input[1], int.Parse(input[2]), input[3], new DateTime(date[2], date[1], date[0])));
                        break;
                    case "Pet":
                        date = input.Last().Split('/').Select(int.Parse).ToArray();
                        livingPopulation.Add(new Pet(input[1], new DateTime(date[2], date[1], date[0])));
                        break;

                }
            }
            int wantedYear = int.Parse(Console.ReadLine());

            foreach (var b in livingPopulation.Where(p => p.BirthDay.Year == wantedYear)) {
                Console.WriteLine($"{b.BirthDay.Day}/{b.BirthDay.Month}/{b.BirthDay.Year}");
            }
        }
    }
}
