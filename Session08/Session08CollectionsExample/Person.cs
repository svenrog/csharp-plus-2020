using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Session08CollectionsExample
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public string[] Aliases { get; set; }
        public int AgeInYears { get; set; }

        public Person Clone()
        {
            // Grund (shallow) kopia
            //return (Person)MemberwiseClone();

            // Om man behöver göra en djupare kopia
            // Så behöver man skriva kopieringen själv
            return new Person
            {
                Name = (string)Name?.Clone(),
                Aliases = (string[])Aliases?.Clone(),

                // Värdetyper behöver inte klonas, de kopieras varje gång man tilldelar
                AgeInYears = AgeInYears
            };
        }

        public int CompareTo([AllowNull] Person other)
        {
            // Orsakar fel om other är null
            //return Name.CompareTo(other.Name);

            // Om vi vill att alla nullvärden hamnar sist
            if (other == null)
                return -1;

            // Förstahandssortering
            int nameComparison = Name.CompareTo(other.Name);
            if (nameComparison != 0)
                return nameComparison;

            // Andrahandssortering
            if (AgeInYears > other.AgeInYears)
                return -1;

            //if (AgeInYears == other.AgeInYears)
                //return 0;

            if (AgeInYears < other.AgeInYears)
                return 1;
            
            return 0;
        }

        public static Person operator +(Person a, Person b)
        {
            return new Person
            {
                Name = a.Name + b.Name,
                AgeInYears = a.AgeInYears + b.AgeInYears,
                Aliases = a.Aliases
            };
        }

        public override string ToString()
        {
            return $"{Name}: {AgeInYears}";
        }
    }
}
