using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class Order
    {
        public static int OrdersCount;

        private int orderNumber;
        private List<Product> products;

        public void AddProduct(Product productToAdd)
        {
            products.Add(productToAdd);
        }

        public double GetOrderTotalPrice()
        {
            return products.Sum(p => p.Price);
        }

        public double GetDiscountedProductsTotalPrice()
        {
            return products.Where(p => p.IsOnPromotion).Sum(p => p.Price);
        }

        public int GetDiscountedProductsCount()
        {
            return products.Count(p => p.IsOnPromotion);
        }

        public Order(int orderNumber, List<Product> products)
        {
            this.products = products;
            OrderNumber = orderNumber;
            OrdersCount++;
        }

        public override string ToString()
        {
            StringBuilder stringInfo = new StringBuilder($"Order #{OrderNumber} has the following products:");

            foreach (var prod in products)
            { stringInfo.Append($"\r\n### {prod.ToString()}"); }

            return stringInfo.ToString();
        }

        public int OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; }
        }
    }
}
