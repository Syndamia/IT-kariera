using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Animal_Farm {
    public abstract class Animal : IAnimal {
        public string animalName { get; private set; }
        public string animalType { get; private set; }
        public double animalWeight { get; private set; }
        public int foodEaten { get; private set; }

        protected Animal(string animalType, string animalName, double animalWeight) {
            this.animalName = animalName;
            this.animalType = animalType;
            this.animalWeight = animalWeight;
        }

        public abstract string makeSound();

        public virtual void eat(IFood foodToEat) => this.foodEaten += foodToEat.quantity;
    }
}
