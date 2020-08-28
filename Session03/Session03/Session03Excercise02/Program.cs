using System;
using System.Diagnostics;
using System.Globalization;

namespace Session03Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");
            var input = Console.ReadLine();
            var inputArray = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            double?[] numberArray = new double?[inputArray.Length];

            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    try
            //    {
            //        numberArray[i] = Convert.ToDouble(inputArray[i]);
            //    }
            //    catch (Exception)
            //    {
            //        numberArray[i] = 0;
            //    }
            //}

            for (int i = 0; i < inputArray.Length; i++)
            {
                NumberStyles numberStyle = NumberStyles.Integer | NumberStyles.Float;
                IFormatProvider formatProvider = CultureInfo.InvariantCulture;

                bool parsed = double.TryParse(inputArray[i], numberStyle, formatProvider, out double parsedValue);

                if (parsed == true)
                {
                    numberArray[i] = parsedValue;
                }
                else
                {
                    numberArray[i] = null;
                }

                //numberArray[i] = GetDoubleValue(inputArray[i]);
            }

            //foreach (var number in numberArray)
            //{
            //    Console.WriteLine("Värde: " + number.ToString());
            //}

            //int exceptionStatus = GetExceptionStatus();

        }

        // Metod som returnerar en siffra baserat på en sträng
        static double GetDoubleValue(string input)
        {
            try
            {
                var result = int.Parse(input);

                return result;
            }
            catch (FormatException ex) when (ex.Message.Contains("Input string"))
            {
                return double.MinValue;
            }
            catch (Exception ex)
            {
                return 0;
            }
            
        }
        
        // Metod som returnerar ett heltal, saknar inparameter
        static int GetExceptionStatus()
        {
            int exceptionResult;

            try
            {
                exceptionResult = -1;

                throw new Exception("Provocerat fel");

                return exceptionResult;
            }
            catch (Exception ex)
            {
                exceptionResult = ex.HResult;

                return exceptionResult;
            }
            finally
            {
                exceptionResult = int.MaxValue;
            }
        }
    }
}
