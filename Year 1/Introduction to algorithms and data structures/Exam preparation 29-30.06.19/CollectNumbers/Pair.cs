using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectNumbers {
    class Pair {
        public int First { get; set; }
        public int Last { get; set; }

        public Pair(int first, int last) {
            First = first;
            Last = last;
        }

        public override string ToString() {
            return $"({First}, {Last})";
        }

        public int Difference() {
            return Math.Abs(First - Last);
        }
    }

}
