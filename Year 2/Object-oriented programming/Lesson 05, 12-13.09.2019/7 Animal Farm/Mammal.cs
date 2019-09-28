using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Animal_Farm {
    public abstract class Mammal : Animal {
        public Mammal(string animalType, string animalName, double animalWeight, string livingRegion)
        :base(animalType, animalName, animalWeight) {
            this.livingRegion = livingRegion;
        }

        public string livingRegion { get; private set; }

        public override string ToString()
            => $"{animalType}[{animalName}, {animalWeight}, {livingRegion}, {foodEaten}]";
    }
}
