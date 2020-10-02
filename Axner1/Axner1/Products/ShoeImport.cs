namespace Axner1.Products
{
    class ShoeImport
    {
        public Shoe[] GetShoes()
        {
            var myShoe = new Shoe();
            myShoe.Brand = "Nike";
            myShoe.Material = "Cotton";
            myShoe.Size = 39;
            myShoe.Type = "Sneaker";
            myShoe.Color = "#ffffff";

            var mySecondShoe = new Shoe();
            mySecondShoe.Brand = "Adidas";
            mySecondShoe.Material = "Suede";
            mySecondShoe.Size = 40;
            mySecondShoe.Type = "Boot";
            mySecondShoe.Color = "#000000";

            return new Shoe[] {myShoe, mySecondShoe};
        }
    }
}