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

            checked
            {
                byte byteValue = 255;
                byteValue += 1;
            }
            

        }
    }
}
