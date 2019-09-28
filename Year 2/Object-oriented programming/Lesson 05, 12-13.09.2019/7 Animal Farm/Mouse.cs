using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Animal_Farm {
    public class Mouse : Mammal {
        public Mouse(string animalType, string animalName, double animalWeight, string livingRegion)
        : base(animalType, animalName, animalWeight, livingRegion) { }

        public override void eat(IFood foodToEat) {
            if (foodToEat is Meat) {
                throw new ArgumentException("Mouse are not eating that type of food!");
            }
            base.eat(foodToEat);
        }

        public override string makeSound() => "SQUEEEAAAK!";
    }
}
