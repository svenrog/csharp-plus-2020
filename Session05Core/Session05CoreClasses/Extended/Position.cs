using System;
using System.Collections.Generic;
using System.Text;

namespace Session05CoreClasses.Extended
{
    // Värdetyp via struct
    public struct Position
    {
        public readonly double X;
        public readonly double Y;

        // Tvinga värden att sättas via konstruktor
        public Position(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
