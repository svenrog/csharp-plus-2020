namespace Axner1.Products
{
    interface IProduct
    {
        int Size { get; set; }
        string Brand { get; set; }
        string Material { get; set; }
        string Type { get; set; }
        string Color { get; set; }

        string MapColor();
    }
}
