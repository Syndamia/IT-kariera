using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_BONUS_Fraction {
    class Program {
        static void Main(string[] args) {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (input.Length % 2 != 0) {
                throw new ArgumentException("You must type an even number of numbers");
            }

            var rationalNumers = new List<RationalNumber>();
            for (int i = 0; i < input.Length; i++) {
                rationalNumers.Add(new RationalNumber(input[i], input[++i]));
            }

            //a bit unecessary but that's how the task wants it
            
            var dividedRationalNumbers = new List<RationalNumber>();
            foreach (var num in rationalNumers) {
                dividedRationalNumbers.Add(new RationalNumber(num.Numerator, num.Denumerator, true));
            }

            Console.WriteLine(string.Join("; ", dividedRationalNumbers));
        }
    }
}
