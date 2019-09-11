using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3_Smartphone {
    class Program {
        static void Main(string[] args) {
            var inputNumbers = Console.ReadLine().Split(' ').ToList();
            var inputSites = Console.ReadLine().Split(' ').ToList();

            Smartphone mySmartphone = new Smartphone(inputNumbers, inputSites);
            Console.WriteLine(mySmartphone.CallEveryone());
            Console.WriteLine(mySmartphone.BrowseEverySite());
        }
    }
}
