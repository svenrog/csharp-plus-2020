using System;
using System.Collections;
using System.Collections.Generic;

namespace Session08CollectionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instansiera en kollektion av typen StringCollection
            /* Flerradskommentarer
             * En rad till */
            StringCollection collection = new StringCollection();

            // Lägga till strängar i kollektionen
            collection.AddString("this is a string");
            collection.AddString("this is another string");

            string firstEnteredString = collection.GetString(0);
            string firstStringViaArray = collection[0];

            // Instansiering av IDictionary, typen StringDictionary
            StringDictionary dictionary = new StringDictionary();

            dictionary.AddString("duck", "anka");
            dictionary.AddString("horse", "häst");

            bool dictionaryContainsKey = dictionary.ContainsKey("duck");
            bool dictionaryDoesNotContainKey = dictionary.ContainsKey("dog");

            string valueForKeyDuck = dictionary.GetValue("duck");

            List<string> genericStringList = new List<string>();
            
            // Komma åt data på index
            //string value = genericStringList[0];


            //IEnumerable
            foreach (string genericValue in genericStringList)
            {
                // Chans att behandla varje värde
            }

            IEnumerator enumerator = genericStringList.GetEnumerator();
            while(enumerator.MoveNext())
            {
                // nuvarande värde via
                //enumerator.Current;
            }

            // Om man har en ICollection kan man hämta index
            for (int i = 0; i < genericStringList.Count; i++)
            {
                string currentValue = genericStringList[i];
            }

            int currentIndex = 0;
            // För att hämta från en yield-metod
            foreach (string item in collection.GetItems())
            {
                // behandla nuvarande värde
                currentIndex++;
            }

            var random = new Random();

            var firstPerson = new Person { Name = "Sven-Erik", AgeInYears = random.Next(0, 100) };
            var secondPerson = new Person { Name = "Sven-Erik",  AgeInYears = random.Next(0, 100) };

            secondPerson.Name = "Patrik";

            var thirdPerson = new Person { Name = "Jens", AgeInYears = random.Next(0, 100) };
            var fourthPerson = thirdPerson.Clone();

            fourthPerson.Name = "Sanna";

            var fifthPerson = firstPerson + secondPerson;
            var sixthPerson = new Person { Name = "Jens", AgeInYears = random.Next(0, 100) };
            var seventhPerson = new Person { Name = "Patrik", AgeInYears = random.Next(0, 100) };

            List<Person> myListOfPersons = new List<Person>();

            myListOfPersons.Add(firstPerson);
            myListOfPersons.Add(secondPerson);
            myListOfPersons.Add(thirdPerson);
            myListOfPersons.Add(fourthPerson);
            myListOfPersons.Add(fifthPerson);
            myListOfPersons.Add(sixthPerson);
            myListOfPersons.Add(seventhPerson);

            // Listan sorteras i detta fallet enligt CompareTo på person
            myListOfPersons.Sort();


            List<int> numberList = new List<int>();

            numberList.Add(random.Next(0, 100));
            numberList.Add(random.Next(0, 100));
            numberList.Add(random.Next(0, 100));

            numberList.Sort();

            List<string> stringNumberList = new List<string>();

            stringNumberList.Add(random.Next(0, 100).ToString());
            stringNumberList.Add(random.Next(0, 100).ToString());
            stringNumberList.Add(random.Next(0, 100).ToString());
            
            stringNumberList.Sort();

            List<string> stringList = new List<string>();

            stringList.Add("       abc padded left value");
            stringList.Add("abc padded right value        ");
            stringList.Add("Jens");
            stringList.Add("Jens Backman");
            
            stringList.Sort();

        }
    }
}
