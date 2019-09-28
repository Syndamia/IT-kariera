using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Animal_Farm {
    abstract class Feline : Mammal {
        public Feline(string animalType, string animalName, double animalWeight, string livingRegion)
        : base(animalType, animalName, animalWeight, livingRegion) { }
    }
}
