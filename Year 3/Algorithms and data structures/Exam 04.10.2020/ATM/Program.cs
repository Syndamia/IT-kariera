using System;

namespace ATM {
    class MainClass {
        public static void Main(string[] args) {
            int sum = int.Parse(Console.ReadLine());

            int banknotes = 0;

            if (sum / 100 > 0) {
                banknotes += sum / 100;
                sum %= 100;
            }
            if (sum / 50 > 0) {
                banknotes += sum / 50;
                sum %= 50;
            }
            if (sum / 20 > 0) {
                banknotes += sum / 20;
                sum %= 20;
            }
            if (sum / 10 > 0) {
                banknotes += sum / 10;
                sum %= 10;
            }
            if (sum / 5 > 0) {
                banknotes += sum / 5;
                sum %= 5;
            }
            if (sum / 2 > 0) {
                banknotes += sum / 2;
                sum %= 2;
            }
            if (sum > 0) {
                banknotes += sum;
            }

            Console.WriteLine(banknotes);
        }
    }
}
