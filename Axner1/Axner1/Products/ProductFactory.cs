using System.Collections.Generic;

namespace Axner1.Products
{
    class ProductFactory
    {
        public List<IProduct> GetProducts()
        {
            var shoeImport = new ShoeImport();
            var shoes = shoeImport.GetShoes();

            var shirtImport = new ShirtImport();
            var shirts = shirtImport.GetShirts();

            var products = new List<IProduct>();

            products.AddRange(shoes);
            products.AddRange(shirts);

            return products;
        }
    }
}
