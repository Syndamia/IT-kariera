using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Animal_Kingdom_2 {
    class Program {
        static void Main(string[] args) {
            Trainer myAnimalTrainer = new Trainer(new Cat());

            Console.WriteLine(myAnimalTrainer.Make());

            myAnimalTrainer.Entity = new Dog();

            Console.WriteLine(myAnimalTrainer.Make());
        }
    }
}
