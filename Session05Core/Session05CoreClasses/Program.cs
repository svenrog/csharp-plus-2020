using Session05CoreClasses.Extended;
using System;

namespace Session05CoreClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Man kan tilldela alla datatyper som ärver från Vehicle i denna variabel
            // Generellt sett används Car som datatyp
            Vehicle myVehicle = new Car();
            // Exempel på boxing, vi packar ner datatypen i en låda vars innehåll glöms bort

            // Tilldela värde 123 på fältet VINNumber
            myVehicle.VINNumber = 123;
            myVehicle.Wheels = 4;
            myVehicle.RegistrationNumber = "ABC123";

            // Värdekonvertering som orsakar fel
            Car myCar = (Car)myVehicle;
            // Exempel på unboxing, vi packar upp data ur en låda

            // Värdekonvertering som blir null
            Car myNullableCar = myVehicle as Car;

            // Sätta det specifika fältet CarColor till ett värde
            myCar.CarColor = "Brown";
            myCar.PassangerSeats = 4;
            // Kommer ej åt på generella datatypen
            // myVehicle.CarColor

            // Skapa avancerade objekt
            Position lampPosition = new Position(0, 0);
            Dimensions lampDimensions = new Dimensions(300, 400, 250);
            string lampBulbType = "Incandescent";

            // Skapa instanser med komplexa objekt
            Furniture myFurniture = new Lamp(lampDimensions, lampPosition, lampBulbType);
            Lamp myLamp = (Lamp)myFurniture;

            // Komma åt egenskaper underobjekt
            int lampWidth = myLamp.Dimensions.Width;
            int lampHeight = myLamp.Dimensions.Height;
        }
    }
}
