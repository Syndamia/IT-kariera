using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Animal_Kingdom_2 {
    public class Cat : IAnimal {
        public string MakeNoise() => "Meow!";

        public string MakeTrick() => "No trick for you! I'm too lazy!";

        public string Perform() {
            return MakeNoise() + "\n" + MakeTrick(); ;
        }
    }
}
