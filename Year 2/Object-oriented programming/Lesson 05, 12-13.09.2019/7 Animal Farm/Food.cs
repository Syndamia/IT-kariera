using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Animal_Farm {
    public abstract class Food : IFood{
        public int quantity { get; private set; }

        public Food(int quantity) {
            this.quantity = quantity;
        }
    }
}
