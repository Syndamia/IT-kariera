using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Enter_numbers {
    class Program {
        static void Main(string[] args) {
            int[] nums = new int[10];

            for(int i = 0; i < 10; i++) {
                try {
                    nums[i] = ReadNumber(1, 100);

                    if (i > 0) {
                        if (nums[i - 1] > nums[i]) {
                            throw new ArgumentException("value", "Number must be bigger than the previous one");
                        }
                    }
                } 
                catch (ArgumentException ex) {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please reenter the number:");
                    i--;
                }
            }
            Console.WriteLine(string.Join(", ", nums));
        }
        public static int ReadNumber(int start, int end) {
            int n = int.Parse(Console.ReadLine());

            if (n < start || n > end) {
                throw new ArgumentException("value", $"Number must be in range [{start} ... {end}]");
            }
            return n;
        }
    }
}
