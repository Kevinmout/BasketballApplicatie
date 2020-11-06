using System;

namespace SimpelAlgoritme
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            order.Products.Add(new Product { Name = "Table", Price = 500 });
            order.Products.Add(new Product { Name = "Tank", Price = 192 });
            order.Products.Add(new Product { Name = "Car", Price = 3939 });
            string Max = order.GiveMaximumPrice().ToString();
            string Avg = order.GiveAveragePrice().ToString();
            string Min = order.GiveProductWherePriceIsMinimum();
            Console.WriteLine(Max);
            Console.WriteLine(Avg);
            Console.WriteLine(Min);
            foreach(var product in order.SortProductsByPrice())
            {
                Console.WriteLine("{0} is {1} dollars.",product.Name,product.Price);
            }
            //order.GiveMaximumPrice(2);
        }
    }
}
