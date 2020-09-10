using System;
using System.Collections.Generic;
using System.Text;

namespace Session05CoreClasses
{
    public class Vehicle
    {
        // Fält
        public int VINNumber;
        public int PassangerSeats;
        public string RegistrationNumber;
        public int Wheels;

        // Metoder
        public bool IsVINValid()
        {
            return VINNumber > 0;
        }
    }
}
