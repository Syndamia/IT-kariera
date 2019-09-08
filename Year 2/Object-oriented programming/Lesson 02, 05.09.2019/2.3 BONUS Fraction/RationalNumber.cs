using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_BONUS_Fraction {
    class RationalNumber {
        private int numerator;
        private int denumerator;

        public RationalNumber(int numerator, int denumerator) :this(numerator, denumerator, false) 
        { }

        public RationalNumber(int numerator, int denumerator, bool divide) {
            this.Numerator = numerator;
            this.Denumerator = denumerator;

            if (divide) {
                var nod = BiggestDivider(numerator, denumerator);
                this.Numerator /= nod;
                this.Denumerator /= nod;
            }
        }

        private int BiggestDivider(int numerator, int denumerator) {
            if (numerator == 0) {
                return denumerator;
            }
            return BiggestDivider(denumerator % numerator, numerator);
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
