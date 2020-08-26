using System;

namespace Session02Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Binary operation
            var additionResult = 1 + 2;

            Console.WriteLine("additionResult " + additionResult.ToString());

            // Detta lagras i den nya variabeln
            var prefixIncrementResult = ++additionResult;

            // Detta lagras inte i den nya variabeln
            var suffixIncrementResult = additionResult++;

            Console.WriteLine("prefixIncrementResult " + prefixIncrementResult.ToString());
            Console.WriteLine("suffixIncrementResult " + suffixIncrementResult.ToString());

            var trueValue = true;
            var falseValue = false;

            // Bitwise-operationer
            var andResult = 0b0010 & 0b0100; // 0b0110;
            var orResult = 0b0001 | 0b0001; // 0b0001;
            var xorResult = 0b0001 ^ 0b0001; // 0b0000;

            Console.WriteLine("andResult " + andResult);
            Console.WriteLine("orResult " + orResult);
            Console.WriteLine("xorResult " + xorResult);

            var moduloResult = 3 % 2;

            Console.WriteLine("moduloResult " + moduloResult);

            var highInteger = 1000;
            var integerDivisionResult = highInteger / 3;

            // Implicit värdekonvertering till double
            var doubleDivisionResult = highInteger / 3.0;

            Console.WriteLine("integerDivisionResult " + integerDivisionResult);
            Console.WriteLine("doubleDivisionResult " + doubleDivisionResult);

            var castIntDivisionResult = (int)(highInteger / 3.0);

            Console.WriteLine("castIntDivisionResult " + castIntDivisionResult);

            var conversionResult = Convert.ToInt32(doubleDivisionResult);

            Console.WriteLine("conversionResult " + conversionResult);

            var midpointDivisionResult = 10.0 / 3.0;

            Console.WriteLine("midpointDivisionResult " + midpointDivisionResult);
            Console.WriteLine("castToInt " + ((int)midpointDivisionResult).ToString());
            Console.WriteLine("ceiling " + Math.Ceiling(midpointDivisionResult));
            Console.WriteLine("floor " + Math.Floor(midpointDivisionResult));
            Console.WriteLine("round " + Math.Round(midpointDivisionResult, 3));

            // Det går även att använda sammanlslagna operatorer likt följande
            additionResult += 2;
            additionResult -= 2;
            additionResult /= 2;
            additionResult *= 2;

            // Booleska jämförelseoperationer
            var greaterResult = 5 > 3;
            var lessThanResult = 5 < 3;
            var greaterOrEqual = 5 >= 5;
            var lessOrEqual = 3 <= 5;

            Console.WriteLine("greaterResult " + greaterResult);
            Console.WriteLine("lessThanResult " + lessThanResult);
            Console.WriteLine("greaterOrEqual " + greaterOrEqual);
            Console.WriteLine("lessOrEqual " + lessOrEqual);

            var andOperationResult = true && false;
            var orOperationResult = false || true;

            Console.WriteLine("andOperationResult " + greaterResult);
            Console.WriteLine("orOperationResult " + lessThanResult);

            Console.ReadKey();
        }
    }
}
