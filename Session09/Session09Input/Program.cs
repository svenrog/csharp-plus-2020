using System;

namespace Session09Input
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriver en rad till konsolen
            Console.WriteLine("Mata in din längd i cm:");

            // Tar emot inmatade värden från användaren, tills användarent trycker enter
            string line = Console.ReadLine();

            int? length;

            try
            {
                length = Convert.ToInt32(line);
            }
            catch (Exception)
            {
                // do nothing
            }

            //Console.Write("");

            //// Tar emot en enda knapptryckning
            //ConsoleKeyInfo key = Console.ReadKey();


            
        }
    }
}
