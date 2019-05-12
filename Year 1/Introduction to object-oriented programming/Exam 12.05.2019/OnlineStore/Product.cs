using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class Product
    {
        private string name;
        private double price;
        private bool isOnPromotion;

        public Product(string name, double price) : this(name, price, false)
        { }

        public Product(string name, double price, bool isOnPromotion)
        {
            IsOnPromotion = isOnPromotion;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Product -> {Name} with price {Price:F2}. On promotion: {(isOnPromotion ? "YES" : "NO")}";

            /* Submitted version:
             * if (isOnPromotion) return $"Product -> {Name} with price {Price:F2}. On promotion: YES";
             * else return $"Product -> {Name} with price {Price:F2}. On promotion: NO";
            */
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3)
                { throw new ArgumentException("Invalid product name!"); }

                name = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0.00)
                { throw new ArgumentException("Price should be positive!"); }


                if (isOnPromotion && price <= 50)
                { price = 0.8 * value; }
                else if (isOnPromotion && price > 50)
                { price = 0.7 * value; }
                else
                { price = value; }
            }
        }

        public bool IsOnPromotion
        {
            get { return isOnPromotion; }
            set { isOnPromotion = value; }
        }
    }
}
