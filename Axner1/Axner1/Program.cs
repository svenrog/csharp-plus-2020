using System;
using System.Collections.Generic;
using Axner1.Products;

namespace Axner1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintProducts();
        }

        private static void PrintProducts()
        {
            var productFactory = new ProductFactory();
            var products = productFactory.GetProducts();

            for (int i = 0; i < products.Count; i++)
            {
                var product = products[i];

                Console.WriteLine(product.Brand);
                Console.WriteLine(ProductMaterialMapper.Map(product.Material));
                Console.WriteLine(product.Size);
                Console.WriteLine(product.Type);
                Console.WriteLine(product.MapColor());
                Console.WriteLine("-----");
            }
        }
    }
}