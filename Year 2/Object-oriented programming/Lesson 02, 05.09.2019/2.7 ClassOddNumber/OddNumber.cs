using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7_ClassOddNumber {
    class OddNumber {
        public static List<OddNumber> oddNumbers = new List<OddNumber>();

        public int Num { get; private set; }

        public OddNumber(int number) {
            this.Num = number;
        }

        public override string ToString() {
            return $"{Num}";
        }
    }
}
