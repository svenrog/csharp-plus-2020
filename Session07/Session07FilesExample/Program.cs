using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Session07FilesExample
{
    class Program
    {
        const string _separator = ";";

        static void Main(string[] args)
        {
            // Läsa in en fils textinnehåll
            // Filestream för att läsa filens innehåll som bytes från början till slut
            using (FileStream stream = File.Open("maxfritid.csv", FileMode.Open))
            {
                // Streamreader för att konvertera bytes till tecken
                using (StreamReader reader = new StreamReader(stream))
                {
                    // Så här är kan man få ut all text på en gång
                    string fileContent = reader.ReadToEnd();
                }
            }

            // Går att skriva så här istället
            string simpleReadFileContent = File.ReadAllText("maxfritid.csv");

            Stream manuallyDisposedStream = File.Open("maxfritid.csv", FileMode.Open);

            // Logik här

            manuallyDisposedStream.Dispose();

            // Definera en lista som vi kan lagra produktdatat i
            List<Product> products = new List<Product>();

            using (FileStream stream = File.Open("maxfritid.csv", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line; // = reader.ReadLine();
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Logik för raden
                        string[] columns = line.Split(_separator);

                        try
                        {
                            Product product = CreateProduct(columns);

                            // Placera behandling av produkten efter inläsningen, i samma try-sats
                            // För att undvika behandling av ogiltig data
                            products.Add(product);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }

            // Sortera en lista via CompareTo på klassen
            products.Sort();

            // Sortera en lista med en egen comparer
            products.Sort(new ProductNameComparer());

            // Sortera en lista med egen comparer via LINQ
            IEnumerable<Product> productsSortedByName = products.OrderBy(x => x, new ProductNameComparer());

            // Sortera en lista via LINQ helt och hållet
            productsSortedByName = products.OrderBy(p => p.ProductName)
                                            .ThenBy(p => p.Id)
                                            .ThenByDescending(p => p.ProductSupplier)
                                            .ToList(); // <- För att genomföra sorteringen till en variabel,
                                                       // Annars körs sorteringen varje gång man loopar innehållet i variabeln.

            PrintProducts(productsSortedByName);
        }

        static void PrintProducts(IEnumerable<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Id}: {product.ProductName}");
            }
        }

        static Product CreateProduct(string[] columns)
        {
            return new Product
            {
                Id = Convert.ToInt32(columns[0]),
                ProductNumber = columns[2],
                ProductName = columns[3],
                ProductBrand = ConvertToNullableInt(columns[4]) ?? 5,
                ProductSupplier = columns[5],
                ProductSynonyms = ConvertToArray(columns[6])
            };
        }

        // Konvertera till int
        static int ConvertToInt(string input)
        {
            int.TryParse(input, out int result);

            return result;
        }

        // Konvertera till int?
        static int? ConvertToNullableInt(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        // Konvertera till array
        static string[] ConvertToArray(string input)
        {
            if (input == null) 
                return new string[0];

            return input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        }

    }
}
