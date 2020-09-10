using System;
using System.Collections.Generic;
using System.Text;

namespace Session05CoreClasses.Extended
{
    // Klasser med nyckelordet abstract kan man ej skapa via new
    public abstract class Furniture
    {
        // Egenskaper
        //public int WidthInMM { get; set; }
        //public int HeightInMM { get; set; }
        //public int DepthInMM { get; set; }

        //Gruppera egenskaper i komplexa objekt
        public Dimensions Dimensions { get; set; }

        //public double PositionX { get; set; }
        //public double PositionY { get; set; }
        public Position Position { get; set; }

        // Publik konstruktor
        public Furniture(int width, int height, int depth, int posX, int posY)
        {
            Dimensions = new Dimensions(width, height, depth);
            Position = new Position(posX, posY);
        }

        // Antalet parametrar som används kan reduceras genom att gruppera data egna datatyper
        public Furniture(Dimensions dimensions, Position position)
        {
            Dimensions = dimensions;
            Position = position;
        }

    }
}
