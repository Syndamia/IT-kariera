using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Animal_kingdom {
    abstract class Animal : IMakeNoise, IMakeTrick {
        private string name { get; set; }
        private int age { get; set; }

        protected Animal(string name, int age) {
            this.name = name;
            this.age = age;
        }

        public virtual string MakeNoise() {
            return $"My name is {this.name}. I am {this.age} old.";
        }

        public virtual string MakeTrick() {
            return "Look at my trick!";
        }
    }
}
