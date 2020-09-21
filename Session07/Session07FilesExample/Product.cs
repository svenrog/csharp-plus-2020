using System;

namespace Session07FilesExample
{
    class Product
    {
        
        public int Id { get; set; }
        public string ProductNumber { get; set; }
        public string ProductName { get; set; }
        public int? ProductBrand { get; set; }
        public string ProductSupplier { get; set; }
        public string[] ProductSynonyms { get; set; }
    }
}
