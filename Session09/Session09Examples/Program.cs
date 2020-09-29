using Session09Examples.Models;
using System;
using System.Collections;

namespace Session09Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Värdetyp
            int integer;
            System.Int32 integerWithoutAlias;

            int myNewInteger = 0;
            int myAdditionalInteger = 0;
            int myNextInteger = 0;

            int maxValue = int.MaxValue;
            int minValue = int.MinValue;
            
            char character = 'a';
            char characterWithEscape = '\t';

            bool boolean = false;
            bool booleanWithTrue = true;
            
            // sätt att få ut standardvärdet
            bool defaultBoolean = default(bool);

            //float floatValue = 1.0f;
            double doubleValue = 1.0;
            //decimal decimalValue = 1.000000m;

            // struct
            DateTime datum = new DateTime(2004, 1, 1);
            TimeSpan timeSpan;

            // enum är ett sätt att förknippa heltal med komplicerade koncept
            DayOfWeek day = DayOfWeek.Monday;

            // nullbara värdetyper
            int? nullableInteger = null;

            (int, string) integerString = (0, "hej");

            //Referenstyp
            string stringValue = "This is a text value defined as a string";

            object objectValue = new object();

            int[] integers = new int[3];

            IEnumerable enumerable = integers;
        }
    }
}
