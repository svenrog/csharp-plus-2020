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

            List<Animal> animals = new List<Animal>();
            ISet<string> typeOfAnimals = new HashSet<string>();

            animals.Add(GetChicken(1));
            animals.Add(GetChicken(2));
            animals.Add(GetCow(1));

            Console.WriteLine($"In my barnyard there are {animals.Count} animals.");

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
                IBarnyardAnimal barnyardAnimal = (IBarnyardAnimal)animal;

                Console.WriteLine($"Found: 1 {animalType}, aged {animal.AgeInYears} years, tagged {barnyardAnimal.Tag}");
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
