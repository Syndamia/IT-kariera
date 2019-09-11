using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3_FoodShortage {
    class Citizen : IBirthable, IBuyer {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }
        public DateTime BirthDay { get; private set; }

        public int Food { get; private set; }

        public Citizen(string name, int age, string id, DateTime birthDay) {
            Name = name;
            Age = age;
            Id = id;
            this.BirthDay = birthDay;
        }

        public void BuyFood() {
            this.Food += 10;
        }
    }
}
