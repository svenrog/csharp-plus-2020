using Session05Animals;
using System;

namespace Session05Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            var beanType = CupOfCoffee.DefaultBeanType;

            Animal myAnimal = new Chicken(1);
            
            //Kalla på metod
            //myAnimal.EatFood() <-
            //myAnimal.AgeInYears.ToString();

            myAnimal = new Cow(1);

            // Tvingad datakonvertering
            // Genererar InvalidCastException
            Cow myCow = (Cow)myAnimal;

            // Säker datakonvertering
            // Blir null om typen inte går att konvertera
            myCow = myAnimal as Cow;

            IBarnyardAnimal myBarnyardAnimal = new Chicken(1);
            myBarnyardAnimal.FeedingArea = "Main yard";
            myBarnyardAnimal.FeedingArea = "Feeding area " + myAnimal.AgeInYears.ToString();
            //myBarnyardAnimal.RestingArea = ""; går inte

            myAnimal = (Animal)myBarnyardAnimal;

            Chicken myChicken = new Chicken(1);

            //För att skapa ett objekt med värden satta
            CupOfCoffee myCupOfCoffe = new CupOfCoffee(false, 0)
            {
                BeanType = "Arabica",
                Description = "Serve cold",
                Instant = false,
                Milk = true,
                //SugarCubes = 0
            };

            Console.WriteLine($"{myCupOfCoffe}");
        }

        public CupOfCoffee GetCupOfCoffee(bool milk, byte sugarCubes)
        {
            return new CupOfCoffee(milk, sugarCubes)
            {
                BeanType = GetRandomBeanType()
            };
        }

        public string GetRandomBeanType()
        {
            var length = CupOfCoffee.BeanTypes.Length;
            return CupOfCoffee.BeanTypes[new Random().Next(0, length)];
        }
    }
}
