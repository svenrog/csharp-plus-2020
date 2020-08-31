using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace Session04Example06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vad klockan är
            DateTime currentDateTime = DateTime.Now;
            DateTime currentTimeZoneNeutralDateTime = DateTime.UtcNow;

            // Kontrollera skottår
            DateTime.IsLeapYear(currentDateTime.Date.Year);
            
            // Maximala och minimala tiden
            DateTime minValue = DateTime.MinValue;
            DateTime maxValue = DateTime.MaxValue;

            // Hämta ut ett datum från en sträng
            var parsedDate = DateTime.Parse("2020-01-01");
            //DateTime failedParseDate = DateTime.Parse("asdf");

            // out-parameter sätter alltid värdet, parsedDate är ändrat
            // DateTime.TryParse fungerar på samma sätt som int.TryParse...
            bool dateWasParsed = DateTime.TryParse("asdf", out parsedDate);

            // Tiden
            TimeSpan currentTime = currentDateTime.TimeOfDay;
            //Baseras på ticks
            //currentTime.Ticks;

            //Hur många Ticks som går på en sekund
            // TimeSpan.TicksPerSecond;

            TimeSpan createdTimeSpan = new TimeSpan(1, 2, 3);

            Stopwatch timer = new Stopwatch();
            timer.Start();
            
            // Pausa programmet manuellt
            Thread.Sleep(1000);

            timer.Stop();

            DateTime today = DateTime.Today;
            DateTime yesterday = DateTime.Today.AddDays(-1)
                                               .AddSeconds(-1);

            TimeSpan resultOfTwoTimes = today - yesterday;
            TimeSpan negativeResultOfTwoTimes = yesterday - today;

            // Formattera, skriva ut tid
            Console.WriteLine(resultOfTwoTimes);

            // Formattera datum, 
            Console.WriteLine($"{currentDateTime:yyyy-MM-dd}");

            // Formattera datum på ett specifikt språk
            Console.WriteLine(currentDateTime.ToString(CultureInfo.InvariantCulture));

            // Standardformattering
            Console.WriteLine(currentDateTime);

            // Slumpa värden
            Random randomizer = new Random();
            int randomNumber = randomizer.Next(0, 100);
            int randomNumber2 = randomizer.Next(0, 100);

            // Gör inte så här, detta leder till att ni får duplicerade värden
            // Detta på grund av att slumpade värden
            randomNumber = new Random().Next(0, 100);
            randomNumber2 = new Random().Next(0, 100);


            // Experiment med slump
            IDictionary<int, int> randomNumbersFromGlobalRandomizer = new Dictionary<int, int>(100);
            IDictionary<int, int> randomNumbersFromLocalRandomizer = new Dictionary<int, int>(100);

            for (var i = 0; i < 10000; i++)
            {
                int globalRandomNumber = randomizer.Next(0, 100);

                if (randomNumbersFromGlobalRandomizer.ContainsKey(globalRandomNumber))
                {
                    randomNumbersFromGlobalRandomizer[globalRandomNumber]++;
                }
                else
                {
                    randomNumbersFromGlobalRandomizer.Add(globalRandomNumber, 1);
                }

                int localRandomNumber = new Random().Next(0, 100);

                if (randomNumbersFromLocalRandomizer.ContainsKey(localRandomNumber))
                {
                    randomNumbersFromLocalRandomizer[localRandomNumber]++;
                }
                else
                {
                    randomNumbersFromLocalRandomizer.Add(localRandomNumber, 1);
                }
            }


        }
    }
}
