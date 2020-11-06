using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpelAlgoritme
{
    class Order
    {
        public List<Product> Products { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }
        public double GiveMaximumPrice()
        {
            double maxPrice = double.MinValue;
            foreach(Product product in Products)
            {
                if (product.Price > maxPrice)
                {
                    maxPrice = product.Price;
                }
            }
            return maxPrice;
        }
        
        public double GiveAveragePrice()
        {
            double AvgPrice = 0;
            int countList = Products.Count;
            foreach (Product product in Products)
            {
                AvgPrice = AvgPrice + product.Price;
            }
            return AvgPrice/countList;
        }
        public string GiveProductWherePriceIsMinimum()
        {
            double minPrice = double.MaxValue;
            string nameProduct = "";
            foreach(Product product in Products)
            {
                if (minPrice > product.Price)
                {
                    minPrice = product.Price;
                    nameProduct = product.Name;
                }
            }
            return nameProduct;
        }

        public List<Product> SortProductsByPrice()
        {
            Products.Sort(delegate (Product x, Product y)
            {
                if (x.Price == null && y.Price == null) return 0;
                else if (x.Price == null) return -1;
                else if (y.Price == null) return 1;
                else return x.Price.CompareTo(y.Price);
            });
            return Products;
        }
    }
}
