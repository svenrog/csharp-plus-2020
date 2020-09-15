using System;
using System.Collections.Generic;
using System.Text;

namespace Session05Animals
{
    public class Cow : Animal, IBarnyardAnimal
    {
        private string _restingArea;

        /// <summary>
        /// Creates an instance of a Cow object
        /// </summary>
        /// <param name="ageInYears">The age of the cow in years</param>
        public Cow(int ageInYears) : base(ageInYears)
        {
        }

        public string Tag { get; set; }

        public string RestingArea => _restingArea;

        public string FeedingArea { get; set; }

        public override void EatFood()
        {
            /* Denna metod saknar implementation, men det är okej för att det finns ingen returtyp */
        }

        public void SupplyMilk()
        {
            /* Här skulle man kunna returnera hur mycket mjölk tex */
        }
    }
}
