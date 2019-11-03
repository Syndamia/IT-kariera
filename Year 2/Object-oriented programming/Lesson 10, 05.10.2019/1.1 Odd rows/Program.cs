using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_Odd_rows {
    class Program {
        static void Main(string[] args) {
            
            using (StreamReader mySR = new StreamReader(@"..\..\text.txt")) {
                for (int i = 0; !mySR.EndOfStream; i++) {
                    string currLine = mySR.ReadLine();

                    if (i % 2 != 0) Console.WriteLine(currLine);
                }
            }
        }
    }
}
