using System;

namespace Session04Example02Errors
{
    class Program
    {
        static void Main(string[] args)
        {
            //int buildError = "stringValue";

            // För att undvika att fel avslutar körning måste man hantera eventuella körtidsfel med try catch.
            try
            {
                string word = "12a";
                int integer = int.Parse(word);
            }
            catch (Exception ex)
            {
                // Denna del är till för att hantera felet, visa fel för användaren eller att skriva till logg.
                Console.WriteLine(ex.Message);
                // Går att använda throw; för att kasta om felet.
            }
            finally
            {
                // Körs alltid, är till för att städa upp körningen.
                // Körs även om try-satsen innehåller return;
            }
            

        }
    }
}
