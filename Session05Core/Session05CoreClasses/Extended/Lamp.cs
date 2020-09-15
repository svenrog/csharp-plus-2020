using System;
using System.Collections.Generic;
using System.Text;

namespace Session05CoreClasses.Extended
{
    public class Lamp : Furniture
    {
        public string BulbType { get; set; }

        public Lamp(Dimensions dimensions, Position position, string bulbType) : base(dimensions, position)
        {
            BulbType = bulbType;
        }
    }
}
