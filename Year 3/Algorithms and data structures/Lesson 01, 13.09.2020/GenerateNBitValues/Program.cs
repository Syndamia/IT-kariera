using System;

namespace GenerateNBitValues {
    class MainClass {
        public static void Generate(int[] vector, int index = 0) {
            if (index >= vector.Length) {
                Console.WriteLine(string.Join(" ", vector));
            }
            else {
                for (int i = 0; i <= 1; i++) {
                    vector[index] = i;
                    Generate(vector, index + 1);
                }
            }
        }

        public static void Main(string[] args) {
            int length = int.Parse(Console.ReadLine());
            Generate(new int[length]);
        }
    }
}
