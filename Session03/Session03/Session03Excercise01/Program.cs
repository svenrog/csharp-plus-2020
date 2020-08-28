using System;

namespace Session03Excercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerValues = new [] { 1, 2, 3 };
            var integerValuesName = nameof(integerValues);

            for (var i = 0; i < integerValues.Length; i++)
            {
                var value = integerValues[i];

                Console.WriteLine($"Index {i} i arrayen {integerValuesName} har värdet: {value}");
            }

            var doWhileIndex = 0;

            do
            {
                var value = integerValues[doWhileIndex];

                Console.WriteLine($"Do while Index {doWhileIndex} i arrayen {integerValuesName} har värdet: {value}");

                doWhileIndex++;
            }
            while (doWhileIndex < integerValues.Length);

            var whileIndex = 0;

            while (whileIndex < integerValues.Length)
            {
                var value = integerValues[whileIndex];

                Console.WriteLine($"While Index {whileIndex} i arrayen {integerValuesName} har värdet: {value}");

                whileIndex++;
            }
        }
    }
}
