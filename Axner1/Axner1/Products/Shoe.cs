﻿namespace Axner1.Products
{
    class Shoe :IProduct
    {
        public int Size { get; set; }
        public string Brand { get; set; }
        public string Material { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        public string MapColor()
        {
            switch (Color)
            {
                case "#ffffff":
                    return "White";
                case "#000000":
                    return "Black";
                default: return "No color";
            }
        }
    }
}