using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product productA = new Product("Масло", "Молочнi продукти", 50);
            Product productB = new Product("Хлiб", "Випiчка", 25);
            Product productC = new Product("Молоко", "Молочнi продукти", 40);
            Product productD = new Product("М'ясо", "М'яснi продукти", 120);
            Product productE = new Product("Яблука", "Фрукти", 25);
            Product productF = new Product("Ковбаса", "М'яснi продукти", 120);

            List<Product> products = new List<Product>()
            { productA, productB, productC, productD, productE, productF};

            Console.WriteLine("Продукти: ");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name}, категорiя: {product.Category}, цiна: {product.Price} грн");
            }

            Console.WriteLine();
            Console.WriteLine("Групування за категорiями: ");

            var selectedByCategory = products.GroupBy(x => x.Category).ToList();
            foreach (var category in selectedByCategory)
            {
                Console.WriteLine($"{category.Key}:");

                foreach (var product in category)
                {
                    Console.WriteLine($"{product.Name}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Групування за цiнами:");

            var selectedByPrice = products.GroupBy(x => x.Price).ToList();
            foreach (var price in selectedByPrice)
            {
                Console.WriteLine($"{price.Key} грн:");

                foreach (var product in price)
                {
                    Console.WriteLine($"{product.Name}");
                }
                Console.WriteLine();
            }
        }
    }
}
