using System;
using System.Collections.Generic;
using System.Text;

namespace Session05Animals
{
    public class Chicken : Animal, IBarnyardAnimal
    {
        private string _restingArea;
        private string _feedingArea;

        // Genväg för att kalla på konstruktor i basklass
        public Chicken(int ageInYears) : base(ageInYears)
        {
        }

        // Egenskapsdefinition
        public string FeedingArea 
        { 
            get 
            {
                return _feedingArea;
            }
            set 
            {
                _feedingArea = value;
            }
        }

        // => är en genväg för att skriva en get-instruktion
        public string RestingArea => _restingArea;

        public string Tag { get; set; }

        public override void EatFood()
        {
           /* Implementation av metoden */
           /* Fyller metoden med logik */
        }
    }
}
