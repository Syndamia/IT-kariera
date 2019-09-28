using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Animals {
    class Cat : Animal {
        public Cat(string name, string favouriteFood)
        :base (name, favouriteFood) { }

        public override string ExplainMyself() {
            return base.ExplainMyself() + "\nMEEOW";
        }
    }
}
