using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Animal_Kingdom_2 {
    public class Dog : IAnimal {
        public string MakeNoise() => "Woof!";

        public string MakeTrick() => "Hold my paw, human!";

        public string Perform() {
            return MakeNoise() + "\n" + MakeTrick();
        }
    }
}
