using System;
using System.Collections.Generic;
using System.Linq;

namespace Session10GenericsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> dictionaryWithIntegerKeys = new Dictionary<int, string>();

            //dictionaryWithIntegerKeys.Add(1, "stop");
            //dictionaryWithIntegerKeys.Add(2, "go");

            Dictionary<int, string> dictionaryWithIntegerKeys = new Dictionary<int, string>
            {
                { 1, "stop" }, { 2, "go" }, { 100, "invalidValue" }
            };

            // Kontrollera om ett värde finns eller ej
            bool dictionaryContainsOne = dictionaryWithIntegerKeys.ContainsKey(1);

            if (dictionaryContainsOne)
            {
                string stringValueWithStop = dictionaryWithIntegerKeys[1];

                // Detta genererar ett fel
                //string notFoundValue = dictionaryWithIntegerKeys[3];
            }

            // Inte en bra approach
            //for (int i = int.MinValue; i < int.MaxValue; i++)
            //{
            //    if (!dictionaryWithIntegerKeys.ContainsKey(i))
            //    {
            //        continue;
            //    }
            //}

            // Loopa alla värden i dictionary
            foreach (var value in dictionaryWithIntegerKeys.Values)
            {

            }

            // Loopa alla nycklar i dictionary
            foreach (var key in dictionaryWithIntegerKeys.Keys)
            {
                // möjlighet att hämta värdet
                string value = dictionaryWithIntegerKeys[key];
            }

            // Loopa alla nyckelvärden i dictionary
            foreach (var keyValue in dictionaryWithIntegerKeys)
            {
                // Värdet
                // keyValue.Value;
                
                // Nyckeln
                // keyValue.Key;
            }

            // Lista med nyckelvärdepar
            // Ej sorterad, måste eftersorteras med .Sort, eller LINQ
            dictionaryWithIntegerKeys.ToList();
            
            foreach (var keyValue in dictionaryWithIntegerKeys)
            {
                Console.WriteLine($"Key: {keyValue.Key}, Value: {keyValue.Value}");
            }

            // Array med värden
            // Ej sorterade heller
            string[] valueArray = dictionaryWithIntegerKeys.Values.ToArray();

            for (int i = 0; i < valueArray.Length; i++)
            {
                Console.WriteLine(valueArray[i]);
            }

            Guid.NewGuid();

            Dictionary<int, (int Id, string Name)> inventory = new Dictionary<int, (int Id, string Name)>
            {
                { 1, (1, "Bok, Kalas Alfons Åberg") },
                { 2, (2, "Leksak, Ugglis, Pyjamashjältarna") }
            };

            
            if (inventory.ContainsKey(1))
            {
                var value = inventory[1];

                // I detta fallet pekar value på referenstyp
                // Värdet i inventory kommer ej uppdateras
                value.Name = "New name for product 1";
            }

            Dictionary<int, Product> productInventory = new Dictionary<int, Product>
            {
                { 1, new Product(1) { Name = "Briotåg" } },
                { 2, new Product(2) { Name = "Leksakshäst" } }
            };

            if (productInventory.ContainsKey(1))
            {
                var value = productInventory[1];

                value.Name = "Briotåg 2";

                // Fullt möjligt att ändra på egenskaper på detta sätt med
                productInventory[1].Name = "Briotåg 3";
                //productInventory[2].Id = 2;
            }

            Index<int, Product> productIndex = new Index<int, Product>();

            productIndex.Add(1, new Product(1) { Name = "Leksaksbil" });
            productIndex.Add(2, new Product(2) { Name = "Legobyggsats, City" });
            productIndex.Add(3, new Product(3) { Name = "Legobyggsats, Pirater" });

            IEnumerable<Product> legoProducts = productIndex.Find(x => x.Name.StartsWith("Lego"));

            IEnumerable<Product> buildingKitProducts = productIndex.Find(x => x.Name.Contains("byggsats"));

            IEnumerable<Product> pirateProducts = productIndex.Find(x => x.Name.EndsWith("Pirater"));

            IEnumerable<Product> legoProductsViaIndex = productIndex.Find(x => x.Name.IndexOf("Lego") > 0);

            foreach (Product product in legoProducts)
            {
                Console.WriteLine(product.ToString());
            }

            var parsedValue = GetValue<double>("1");

            var convertedValue = ConvertValue<Product, int>(new Product(1));

            var convertedValue2 = Convert.ChangeType(new Product(1), typeof(int));
        }

        static T GetValue<T>(string input) where T : IConvertible
        {
            try
            {
                return (T)Convert.ChangeType(input, typeof(T));
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        static TTarget ConvertValue<TSource, TTarget>(TSource input)
            where TSource : IConvertible
            where TTarget : IConvertible
        {
            try
            {
                return (TTarget)Convert.ChangeType(input, typeof(TTarget));
            }
            catch (Exception)
            {
                return default(TTarget);
            }
        }
    }
}
