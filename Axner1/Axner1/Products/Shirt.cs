namespace Axner1.Products
{
    class Shirt : IProduct
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
                case "rgb(255, 255, 255)":
                    return "White";
                case "rgb(0, 0, 0)":
                    return "Black";
                default: return "No color";
            }
        }
    }
}
