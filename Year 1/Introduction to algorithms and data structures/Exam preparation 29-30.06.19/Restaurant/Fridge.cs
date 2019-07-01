using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant {
    class Fridge {
        private Product head;
        private Product tail;
        private int count;

        public Fridge() { }

        public int Count {
            get { return count; }
            private set { count = value; }
        }

        public void AddProduct(string ProductName) {
            var newProduct = new Product(ProductName);

            if (head == null) {
                head = newProduct;
                tail = newProduct;
            }
            else {
                tail.Next = newProduct;
                tail = newProduct;
            }

            Count++;
        }

        public string[] CookMeal(int start, int end) {
            var currP = head;
            var mealProducts = new List<string>();
            
            for (int i = 0; i < Count && currP != null; i++) {
                if (i >= start && i <= end) {
                    mealProducts.Add(currP.Name);
                }
                currP = currP.Next;
            }

            return mealProducts.ToArray(); 
        }

        public string RemoveProductByIndex(int index) {
            if(index < 0 || index >= Count) return null;
            else {
                var currP = head;
                string toReturn = null;

                if (index == 0) {
                    toReturn = currP.Name;
                    head = head.Next;
                }
                else {
                    for(int i = 0; i < index; i++) {
                        if(i == index - 1) {
                            toReturn = currP.Next.Name;

                            if(currP.Next == tail) {
                                tail = currP;
                                tail.Next = null;
                            }
                            else currP.Next = currP.Next.Next;
                            break;
                        }
                        currP = currP.Next;
                    }
                }

                Count--;
                return toReturn;
            }
        }

        public string RemoveProductByName(string name) {
            for(var currP = head; currP != null ; currP = currP.Next) {
                if(currP.Name == name) return RemoveProductByIndex(i);
            }

            return null;
        }

        public bool CheckProductIsInStock(string name) {
            for (var currP = head; currP != null; currP = currP.Next) {
                if(currP.Name == name) return true;
            }

            return false;
        }

        public string[] ProvideInformationAboutAllProducts() {
            var currP = head;
            var info = new string[Count];

            for (int i = 0; i < Count; i++) {
                info[i] = currP.ToString();
                currP = currP.Next;
            }

            return info;
        }
    }
}