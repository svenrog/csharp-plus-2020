using System;
using System.Collections.Generic;

namespace Session08Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "This is a string value";

            // Utvärderas när man kompilerar
            Type myStringType = typeof(string);

            // Utvärderas när man kör programmet, till för när man inte vet datatypen
            Type myStringTypeViaReflection = myString.GetType();


            // Jämföra om det är exakt samma datatyp
            if (myStringType == myStringTypeViaReflection)
            {

            }

            // Jämför och tar hänsyn till arv
            if (myStringTypeViaReflection.IsAssignableFrom(myStringType))
            {

            }

            List<string> myStringList = new List<string>();
            string[] myStringArray = new string[0];

            // Boxing
            IEnumerable<string> myEnumerable = myStringList;
            
            myEnumerable = myStringArray;

            // Unboxing via casting
            myStringArray = (string[])myEnumerable;
            
            // Unboxing via casting till fel datatyp orsakar InvalidCastException
            //myStringList = (List<string>)myEnumerable;

            // Unboxing via as blir null om datatypen är felaktig
            myStringList = myEnumerable as List<string>;

            // här återställer vi till korrekta värden
            myEnumerable = new List<string>();

            #region Enumerable 
                // Pattern matching kan användas för att kontrollera om en variabel är av viss typ
                if (myEnumerable is List<string> myStringListPatternMatched)
                {
                    myStringListPatternMatched.Add("added value");
                }
            #endregion

            

            // Går även att jämföra utan tilldelning
            if (myEnumerable is List<string>)
            {
                // I sådant fall kan man exekvera annan logik tex.
            }



        }
    }
}
