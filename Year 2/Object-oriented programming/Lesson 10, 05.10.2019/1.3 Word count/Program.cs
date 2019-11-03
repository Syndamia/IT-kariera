using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_Word_count {
    class Program {
        static void Main(string[] args) {
            //note: if you have the same words in words.txt it will throw an exception
            Dictionary<string, int> temp = new Dictionary<string, int>();

            using (StreamReader wordsReader = new StreamReader(@"..\..\words.txt")) {
                while (!wordsReader.EndOfStream) {
                    string currW = wordsReader.ReadLine().ToLower();
                    int occ = 0;

                    using (StreamReader textReader = new StreamReader(@"..\..\text.txt")) {
                        while (!textReader.EndOfStream) {
                            occ += textReader.ReadLine()
                                             .Split(' ', ',', '.', '-', '!', '?', ';', ':').Where(w => w != "")
                                             .Count(w => w.ToLower() == currW);
                        }
                    }
                    temp.Add($"{currW} - {occ}", occ);
                }
            }

            using (StreamWriter resultWriter = new StreamWriter(@"..\..\result.txt")) {
                foreach(var currLine in temp.OrderByDescending(p => p.Value)) {
                    resultWriter.WriteLine(currLine.Key);
                }
            } 
        }
    }
}
