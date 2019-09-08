using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_ClassRationalNumber {
    class Program {
        static void Main(string[] args) {
            var rationalNumers = new List<RationalNumber>();

            //task doesn't specify how many rational numbers will be typed, but the example (of this and future tasks) gives only three
            for (int i = 0; i < 3; i++) {
                var numerator = int.Parse(Console.ReadLine());
                var denumerator = int.Parse(Console.ReadLine());

                rationalNumers.Add(new RationalNumber(numerator, denumerator));
            }
            rationalNumers.ForEach(rn => Console.WriteLine(rn.ToString()));
        }
    }
}
