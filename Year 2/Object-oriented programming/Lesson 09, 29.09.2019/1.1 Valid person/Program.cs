using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_Valid_person {
    class Program {
        static void Main(string[] args) {
            Person pesho = new Person("Pesho", "Peshev", 24);

            for(int i = 0; i < 5; i++) {
                try {
                    switch (i) {
                        case 0: Person noName = new Person(string.Empty, "Goshev", 31); break;
                        case 1: Person noLastName = new Person("Ivan", null, 63); break;
                        case 2: Person negativeAge = new Person("Stoyan", "Kolev", -1); break;
                        case 3: Person tooOldForThisProgram = new Person("Iskren", "Ivanov", 121); break;
                    }
                } catch (ArgumentNullException ex) {
                    Console.WriteLine("Exception thrown: " + ex.Message);
                }
                catch (ArgumentOutOfRangeException ex) {
                    Console.WriteLine("Exception thrown: " + ex.Message);
                }
            }

        }
    }
}
