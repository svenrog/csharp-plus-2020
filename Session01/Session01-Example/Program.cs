using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a comment

            /* This is a multiline
             * comment */

            int[] myArray = new int[] { 1, 2, 4, 5 };

            int myArrayInteger = myArray.Length;

            int? integer = null;

            if (true)
            {

                // Strängkonkatenering, sammanslagning
                string data = "this integer has value" + integer.ToString();

                // Stränginterpolation
                string secondData = $"this integer has value {integer}";

                // Strängformattering
                string thirdData = string.Format("this integer has value {0}", integer);

                // Implicit strängkonkatenering
                string fourthData = "this integer has value" + integer; // Gör ej

                Console.WriteLine(fourthData);

            }

            #region console interaction



            Console.ReadLine();

            Print("value to print");

            #endregion

            #if Debug
                
            #endif
        }

        static string Print(object value)
        {
            return string.Empty;
        }

        static int Print(int value)
        {
            return 0;
        }

        static string Print(object valueOne, object valueTwo)
        {
            var stringValue = valueOne.ToString();
            Console.WriteLine("Värdet är: " + stringValue);
            
            return stringValue;
        }
    }
}
