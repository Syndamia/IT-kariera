using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trains {
    class Train {
        public int Number { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }
        public int Cars { get; private set; }

        public Train(int number, string name, string type, int cars) {
            Number = number;
            Name = name;
            Type = type;
            Cars = cars;
        }

        public override string ToString() {
            return $"{Number} {Name} {Type} {Cars}";
        }
    }
}
