using System;
using System.Collections.Generic;
using System.Text;

namespace Session05CoreClasses.Extended
{
    public class Sofa : Furniture
    {
        public int Seats { get; set; }
        public string CushionType { get; set; }

        public Sofa(Dimensions dimensions, Position position) : base(dimensions, position)
        {

        }
    }
}
