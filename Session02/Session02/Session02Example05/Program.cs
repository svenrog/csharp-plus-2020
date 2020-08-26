using System;

namespace Session02Example05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange vattentemperatur i grader C:");

            var input = Console.ReadLine();
            var integer = Convert.ToInt32(input);

            string waterLabel = integer >= 27 ? "Går att bada" : "Går inte att bada";

            // Är samma sak som
            //if (integer >= 27)
            //{
            //    waterLabel = "Går att bada";
            //}
            //else
            //{
            //    waterLabel = "Går inte att bada";
            //}

            switch (integer)
            {
                case 1: waterLabel = "Går inte att bada alls"; break;
                case -3: waterLabel = "Det är 3 minusgrader"; break;
                default: /* Här kan man göra något om inget träffar */ break;
            }

            Console.WriteLine(waterLabel + " i havet");
        }
    }
}
