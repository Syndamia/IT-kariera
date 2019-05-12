using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineStore
{
    class Program //Program.cs is predetermined by task
    {
        static Dictionary<int, Order> orders = new Dictionary<int, Order>();
        static Dictionary<string, Product> products = new Dictionary<string, Product>();

        static void Main(string[] args)
        {
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var commandArgs = command.Split(' ').ToArray();

                switch (commandArgs[0])
                {
                    case "CreateProduct":
                        AddProducts(commandArgs.Skip(1).ToArray());
                        break;
                    case "CreateOrder":
                        CreateOrder(commandArgs.Skip(1).ToArray());
                        break;
                    case "AddToOrder":
                        AddToOrder(commandArgs.Skip(1).ToArray());
                        break;
                    case "GetOrderTotalPrice":
                        GetOrderTotalPrice(commandArgs.Skip(1).ToArray());
                        break;
                    case "GetOrderDiscountedProductsPrice":
                        GetOrderDiscountedProductsPrice(commandArgs.Skip(1).ToArray());
                        break;
                    case "GetOrderDiscountedProductsCount":
                        GetDiscountedProductsCount(commandArgs.Skip(1).ToArray());
                        break;
                    case "GetTotalOrdersCount":
                        GetTotalOrdersCount();
                        break;
                    case "PrintProductInfoByName":
                        PrintProductInfoByName(commandArgs.Skip(1).ToArray());
                        break;
                    case "PrintOrderByNumber":
                        PrintOrderByNumber(commandArgs.Skip(1).ToArray());
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }
        }

        private static void PrintOrderByNumber(string[] number)
        {
            int orderNumber = int.Parse(number[0]);

            if (!orders.ContainsKey(orderNumber))
            {
                Console.WriteLine("Non existing order!");
                return;
            }

            Console.WriteLine(orders[orderNumber].ToString());
        }

        private static void PrintProductInfoByName(string[] name)
        {
            string productName = name[0];

            if (!products.ContainsKey(productName))
            {
                Console.WriteLine($"Invalid product {productName}");
                return;
            }

            Console.WriteLine(products[productName].ToString());
        }

        private static void GetTotalOrdersCount()
        {
            Console.WriteLine(Order.OrdersCount);
        }

        private static void GetDiscountedProductsCount(string[] orderInfo)
        {
            int orderNumber = int.Parse(orderInfo[0]);
            if (!orders.ContainsKey(orderNumber))
            {
                Console.WriteLine("Non existing order!");
                return;
            }

            Console.WriteLine(orders[orderNumber].GetDiscountedProductsCount());
        }

        private static void GetOrderDiscountedProductsPrice(string[] orderInfo)
        {
            int orderNumber = int.Parse(orderInfo[0]);
            if (!orders.ContainsKey(orderNumber))
            {
                Console.WriteLine("Non existing order!");
                return;
            }

            Console.WriteLine(orders[orderNumber].GetDiscountedProductsTotalPrice());
        }

        private static void GetOrderTotalPrice(string[] orderInfo)
        {
            int orderNumber = int.Parse(orderInfo[0]);
            if (!orders.ContainsKey(orderNumber))
            {
                Console.WriteLine("Non existing order!");
                return;
            }

            Console.WriteLine(orders[orderNumber].GetOrderTotalPrice());
        }

        private static void AddToOrder(string[] orderInfo)
        {
            int orderNumber = int.Parse(orderInfo[0]);
            if (!orders.ContainsKey(orderNumber))
            {
                Console.WriteLine("Non existing order!");

                return;
            }
            Order order = orders[orderNumber];

            orderInfo.Skip(1).ToList().ForEach(p =>
            {
                if (!products.ContainsKey(p))
                {
                    Console.WriteLine($"Invalid product {p}");
                }
                else
                {
                    order.AddProduct(products[p]);
                }
            });
        }

        private static void CreateOrder(string[] orderInfo)
        {
            int orderNumber = int.Parse(orderInfo[0]);

            if (orders.ContainsKey(orderNumber))
            {
                Console.WriteLine("Cannot create order! Order already exists!");

                return;
            }

            List<Product> productsList = orderInfo
                .Skip(1)
                .Where(p => products.ContainsKey(p))
                .Select(p => products[p])
                .ToList();

            Order order = new Order(orderNumber, productsList);
            orders.Add(order.OrderNumber, order);
        }

        private static void AddProducts(string[] productInfo)
        {
            string name = productInfo[0];
            double price = double.Parse(productInfo[1]);

            if (products.ContainsKey(name))
            {
                Console.WriteLine("Cannot add product! Product already exists!");

                return;
            }

            try
            {
                Product product;

                if (productInfo.Length > 2)
                {
                    bool isOnPromotion = bool.Parse(productInfo[2]);
                    product = new Product(name, price, isOnPromotion);
                }
                else
                {
                    product = new Product(name, price);
                }

                products.Add(name, product);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
