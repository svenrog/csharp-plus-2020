using System;
using System.Collections.Generic;
using System.Text;

namespace Session05CoreClasses
{
    // Allt från Vehicle kopieras in (ärvs in) i denna klass
    public class Car : Vehicle
    {
        // Fält
        public string CarColor;

        // Metoder
        public bool HasValidCarColor()
        {
            return string.IsNullOrEmpty(CarColor) == false;
        }
    }
}
