using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Animal_kingdom {
    class Dog : Animal{
        public Dog(string name, int age)
            : base(name, age) { }

        public override string MakeNoise() {
            return "Woof! " + base.MakeNoise();
        }

        public override string MakeTrick() {
            return "Hold my paw, human!";
        }
    }
}
