using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Animal_Farm {
    class Cat : Feline {
        public Cat(string animalType, string animalName, double animalWeight, string livingRegion, string breed)
        : base(animalType, animalName, animalWeight, livingRegion) {
            this.breed = breed;
        }

        public string breed { get; private set; }

        public override string makeSound() => "Meowwww";

        public override string ToString()
            => base.ToString().Insert(base.ToString().IndexOf(' ') + 1, $"{breed}, ");
    }
}
