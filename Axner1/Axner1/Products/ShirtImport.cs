namespace Axner1.Products
{
    class ShirtImport
    {
        public Shirt[] GetShirts()
        {
            var myShirt = new Shirt();
            myShirt.Brand = "Levis";
            myShirt.Material = "Polyester";
            myShirt.Size = 140;
            myShirt.Type = "T-shirt";
            myShirt.Color = "rgb(255, 255, 255)";

            var mySecondShirt = new Shirt();
            mySecondShirt.Brand = "HM";
            mySecondShirt.Material = "Rubber";
            mySecondShirt.Size = 130;
            mySecondShirt.Type = "Shirt";
            mySecondShirt.Color = "rgb(0, 0, 0)";

            return new Shirt[] {myShirt, mySecondShirt};

        }
    }
}
