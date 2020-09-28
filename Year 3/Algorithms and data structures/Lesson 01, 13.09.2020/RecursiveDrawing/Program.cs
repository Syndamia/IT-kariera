using System;
using System.Text;

namespace RecursiveDrawing {
    class MainClass {
        public static void DrawFigure(int length) {
            if (length == 0) return;

            Console.WriteLine(new string('*', length));

            DrawFigure(length - 1);

            Console.WriteLine(new string('#', length));
        }

        // Version that returns the figure as a string, 
        // which is more efficient than constalntly writing to the console
        public static string GetFigure(int length) {
            if (length == 0) return null;

            return new string('*', length) + "\n" +
            	   GetFigure(length - 1)   + ((length > 1) ? "\n" : null) +
            	   new string('#', length);
        }

        public static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            DrawFigure(n);

            //Console.WriteLine(GetFigure(n));
        }
    }
}
