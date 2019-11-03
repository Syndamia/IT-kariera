using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_Square_root {
    class Program {
        static void Main(string[] args) {
            try {
                int n = int.Parse(Console.ReadLine());

                if (n < 0) throw new ArgumentException();

                Console.WriteLine(Math.Sqrt(n));
            } 
            catch (OverflowException) {
                Console.WriteLine("Invalid number!");
            } 
            catch (ArgumentException) {
                Console.WriteLine("Invalid number!");
            } 
            finally {
                Console.WriteLine("Good bye");
            }
        }
    }
}
