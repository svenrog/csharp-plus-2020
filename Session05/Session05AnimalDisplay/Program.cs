using Session05Animals;
using System;
using System.Collections.Generic;

namespace Session05AnimalDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
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

                Console.WriteLine($"Found: 1 {animalType}, aged {animal.AgeInYears} years");
            }
        }

        static string GetTypeName(object objectOfType)
        {
            Type type = objectOfType.GetType();
            return type.Name;
        }

        static Cow GetCow(int ageInYears)
        {
            return new Cow(ageInYears);
        }

        static Chicken GetChicken(int ageInYears)
        {
            return new Chicken(ageInYears);
        }
    }
}
