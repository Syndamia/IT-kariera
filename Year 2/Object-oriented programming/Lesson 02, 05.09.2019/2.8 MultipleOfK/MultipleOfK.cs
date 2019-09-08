using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._8_MultipleOfK {
    class MultipleOfK {
        public static List<MultipleOfK> multiplesOfK = new List<MultipleOfK>();

        public int Num { get; private set; }

        public MultipleOfK(int number) {
            this.Num = number;
        }

        public override string ToString() {
            return $"{Num}";
        }
    }
}
