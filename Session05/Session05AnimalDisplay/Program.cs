using Session05Animals;
using System;
using System.Collections.Generic;

namespace Session05AnimalDisplay
{
    class Program
    {
        static int _tagCounter;

        static void Main(string[] args)
        {
            _tagCounter = 0;

            Animal[] animals = new Animal[3];

            // För att fylla arrayen automatiskt med 3 kycklingar
            // kan man tex använda en for-loop
            for (var i = 0; i < animals.Length; i++)
            {
                animals[i] = GetChicken(i);
            }

            // Man kan även skapa arrayer av mer specifika typer
            // Men... då begränsas även vilken datatyp man kan tilldela till arrayen
            Cow[] cows = new Cow[3];

            //List<Animal> animals = new List<Animal>();
            //List<Cow> cows;
            //List<Chicken> chickens;

            ISet<string> typeOfAnimals = new HashSet<string>();

            animals[0] = GetChicken(1);
            animals[1] = GetChicken(2);
            animals[2] = GetCow(1);

            //Detta går ej, då chicken inte härstammar (ärver) från Cow
            //cows[0] = GetChicken(1);

            //animals.Add(GetChicken(1));
            //animals.Add(GetChicken(2));
            //animals.Add(GetCow(1));

            Console.WriteLine($"In my barnyard there are {animals.Length} animals.");

            foreach (Animal animal in animals)
            {
                string animalType = GetTypeName(animal);

                if (typeOfAnimals.Contains(animalType) == false)
                {
                    typeOfAnimals.Add(animalType);
                }
            }

            Console.WriteLine($"There are {typeOfAnimals.Count} types of animals");
            Console.WriteLine(string.Join(", ", typeOfAnimals));

            foreach (Animal animal in animals)
            {
                // typeof används för att få ut en jämförbar datatyp
                //string animalType = animal.GetType() == typeof(Chicken) ? "Chicken" : "Cow";

                // går även att skriva
                //string animalTypeExplicit;
                //if (animal.GetType() == typeof(Chicken))
                //{
                //    animalType = "Chicken";
                //}
                //else
                //{
                //    animalType = "Cow";
                //}

                string animalType = GetTypeName(animal);

                // Kan generera en InvalidCastException
                //IBarnyardAnimal barnyardAnimal = (IBarnyardAnimal)animal;

                // Man kan konvertera med as, om konvertering misslyckas blir värdet null
                IBarnyardAnimal barnyardAnimal = animal as IBarnyardAnimal;            

                Console.WriteLine($"Found: {animalType}, aged {animal.AgeInYears} years, tagged {barnyardAnimal.Tag}");
            }
        }

        static string GetTypeName(object objectOfType)
        {
            Type type = objectOfType.GetType();
            return type.Name;
        }

        static Cow GetCow(int ageInYears)
        {
            var cow = new Cow(ageInYears);

            cow.Tag = GetTag();

            return cow;
        }

        static Chicken GetChicken(int ageInYears)
        {
            Chicken result = new Chicken(ageInYears);

            result.FeedingArea = "Feeding area " + result.AgeInYears.ToString();
            result.Tag = GetTag();

            return result;
        }

        static string GetTag()
        {
            _tagCounter++;
            return _tagCounter.ToString().PadLeft(3, '0');
        }
    }
}
