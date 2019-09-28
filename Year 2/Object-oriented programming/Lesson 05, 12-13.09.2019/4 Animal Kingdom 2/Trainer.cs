using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Animal_Kingdom_2 {
    class Trainer {
        public IAnimal Entity { get; set; }

        public Trainer(IAnimal entity) {
            this.Entity = entity;
        }

        public string Make() => Entity.Perform();
    }
}
