using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Animals {
    abstract class Animal {
        private string name;
        private string favouriteFood;

        public Animal(string name, string favouriteFood) {
            this.name = name;
            this.favouriteFood = favouriteFood;
        }

        public virtual string ExplainMyself() {
            return $"I am {this.name} and my favourite food is {this.favouriteFood}";
        }
    }
}
