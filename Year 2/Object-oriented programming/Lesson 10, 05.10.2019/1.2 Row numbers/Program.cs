using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_Row_numbers {
    class Program {
        static void Main(string[] args) {

            using (StreamReader mySR = new StreamReader(@"../../text.txt")) {
                using (StreamWriter mySW = new StreamWriter(@"../../output.txt")) {

                    for (int i = 1; !mySR.EndOfStream; i++) {
                        mySW.WriteLine($"Line {i}: {mySR.ReadLine()}");
                    }
                }
            }
        }
    }
}
