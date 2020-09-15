using System;
using System.Collections.Generic;
using System.Text;

namespace Session05Example01
{
    class CupOfCoffee
    {
        // Statiskt fält, delat för hela klassen.
        public static string DefaultBeanType = "Arabica";
        public static string[] BeanTypes;

        // Normalt används properties
        public string BeanType; /* { get; set; } */
        public bool Instant;
        public bool Milk;
        public byte SugarCubes;
        public string Description;

        private string _id;

        // Statisk konstruktor
        static CupOfCoffee()
        {
            BeanTypes = new [] { "Arusha", "Arabica", "Blue Mountain", "Robusta" };

            /* Ovan är samma sak som detta
            BeanTypes = new string[4];
            BeanTypes[0] = "Arusha";
            BeanTypes[1] = "Arabica";
            BeanTypes[2] = "Blue Mountain";
            BeanTypes[3] = "Robusta";
            */
        }

        // Konstruktor
        // Identiskt namn med klassen
        public CupOfCoffee()
        {

        }

        // Konstruktor med inparametrar
        public CupOfCoffee(bool milk, byte sugarCubes)
        {
            SugarCubes = sugarCubes;
            Milk = milk;
        }

        // Finalizer eller destruktor
        // Ej nödvändig om inte IDisposeable
        ~CupOfCoffee()
        {

        }

        public override string ToString()
        {
            var builder = new StringBuilder($"{BeanType}");

            if (!string.IsNullOrEmpty(Description))
                builder.Append($", {Description}");

            if (SugarCubes > 0)
                builder.Append($", {SugarCubes} sugars");

            if (Milk) builder.Append(", add milk");

            return builder.ToString();
        }


    }
}
