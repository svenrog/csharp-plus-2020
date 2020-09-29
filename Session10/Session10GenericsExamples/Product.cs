using System;
using System.Collections.Generic;
using System.Text;

namespace Session10GenericsExamples
{
    class Product
    {
        public Product(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
