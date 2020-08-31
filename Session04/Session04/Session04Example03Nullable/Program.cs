using System;

namespace Session04Example03Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int? nullableInteger = null;
            double? nullableDouble = null;
            char?[] nullableCharArray = new char?[] { 'a', null, 'b' };

            //nullableInteger.HasValue;
            //nullableInteger.Value;

            for (var i = 0; i < nullableCharArray.Length; i++)
            {
                char? currentChar = nullableCharArray[i];

                // för att kontrollera om värdet är null kan man
                if (currentChar.HasValue == false) continue;
                // eller
                if (currentChar == null) continue;

                // för att komma åt ett värde kan man
                char currentCharValue = currentChar.Value;
                // eller
                currentCharValue = (char)currentChar;
            }

            string defaultString = null;

            // Olika typer av konstanter
            int minValue = int.MinValue;
            double maxValue = double.MaxValue;
            double nanValue = double.NaN;
            double infinityValue = double.PositiveInfinity;

            // Värde som överstiger datatypens lagringsförmåga, kommer automatiskt att tilldelas det lägsta värdet istället.
            byte byteValue = 255;
            byteValue += 1;

            // Om man vill kontrollera att värdet inte överstigs används nyckelordet checked
            checked
            {
                byteValue = 255;
                byteValue += 1;
            }

            // Det går även att använda nyckelordet unchecked, men då görs detta om man är i ett block som är markerat checked.
            checked
            {
                byteValue = 255;
                unchecked
                {
                    byteValue += 1;
                }
            }
        }
    }
}
