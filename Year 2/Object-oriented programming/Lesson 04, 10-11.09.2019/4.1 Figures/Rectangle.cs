using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_Figures {
    class Rectangle : IDrawable{
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Rectangle(int width, int height) {
            this.Width = width;
            this.Height = height;
        }

        //Draw and DrawLine are given by task
        public void Draw() {
            DrawLine(this.Width, '*', '*');
            for (int i = 1; i < this.Height - 1; ++i)
                DrawLine(this.Width, '*', ' ');
            DrawLine(this.Width, '*', '*');
        }

        private void DrawLine(int width, char end, char mid) {
            Console.Write(end);
            for (int i = 1; i < width - 1; ++i)
                Console.Write(mid);
            Console.WriteLine(end);
        }

    }
}
