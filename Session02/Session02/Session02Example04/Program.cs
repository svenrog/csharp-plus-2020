using System;

namespace Session02Example04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ålder:");

            var input = Console.ReadLine();
            var integer = Convert.ToInt32(input);

            if (integer >= 18)
            {
                Console.WriteLine("Du får köpa tobaksprodukter");
            }
            else
            {
                Console.WriteLine("Du får inte köpa tobaksprodukter");
            }

            if (integer >= 40)
            {
                Console.WriteLine("Du är även jättegammal");
            }
        }
    }
}
