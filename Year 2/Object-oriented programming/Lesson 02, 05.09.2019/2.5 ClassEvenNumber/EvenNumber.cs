using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_ClassEvenNumber {
    class EvenNumber {
        public static List<EvenNumber> evenNumbers = new List<EvenNumber>();

        public int Num { get; private set; }

        public EvenNumber(int number) {
            this.Num = number;
        }

        public override string ToString() {
            return $"{Num}";
        }
    }
}
