using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Film
    {
        // Mock film
        public Film(string name, string director, double rating, string release, string length, int price, int temp2, string temp3)
        {
            titel = name;
            mmCreator = director;
            grade = rating;
            releaseDate = release;
            playTime = length;
            this.price = price;
        }

        public string titel { get; }
        public string mmCreator { get; }
        public double grade { get; }
        public string releaseDate { get; }
        public string playTime { get; }
        public int price { get; }
    }
}
