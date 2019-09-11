using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3_FoodShortage {
    class Rebel :IBuyer {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Group { get; private set; }

        public int Food { get; private set; }

        public Rebel(string name, int age, string group) {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public void BuyFood() {
            this.Food += 5;
        }
    }
}
