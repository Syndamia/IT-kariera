using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_BONUS_ClassRationalNumer {
    class RationalNumber {
        private int numerator;
        private int denumerator;

        public RationalNumber(int numerator, int denumerator) {
            this.Numerator = numerator;
            this.Denumerator = denumerator;
        }

        public override string ToString() {
            return $"{numerator}/{denumerator}";
        }

        public int Numerator {
            get { return this.numerator; }
            private set {
                if (value == 0) {
                    throw new ArgumentException("Numerator cannot be 0");
                }
                this.numerator = value;
            }
        }

        public int Denumerator {
            get { return this.denumerator; }
            private set {
                if (value == 0) {
                    throw new ArgumentException("Denumerator cannot be 0");
                }
                this.denumerator = value;
            }
        }
    }
}
