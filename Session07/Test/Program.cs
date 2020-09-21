using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Film movie1 = new Film("En bedrövlig film", "Donald Trump", 4.5, "20 April 2020", "2h 39min", 1, 0, "");
            Console.WriteLine($@"Film: {movie1.titel} Regissör: {movie1.mmCreator} Betyg: {movie1.grade} Release Datum: {movie1.releaseDate} Tid: {movie1.playTime} Pris: {movie1.price} kr ");
           
            Film movie2 = new Film("Den förvirrade programeran", "Frej Björnsson", 9.9, "21 Augusti 1996", "1h 2min", 100, 0, "");
            Console.WriteLine($"\nFilm: {movie2.titel} Regissör: {movie2.mmCreator} Betyg: {movie2.grade} Release Datum: {movie2.releaseDate} Tid: {movie2.playTime} Pris: {movie2.price} kr ");
            
            Film movie3 = new Film("Den ledsna kocken", "Jonas Lindberg", 2.1, "14 December 2009", "1h 2min", 100, 0, "");
            Console.WriteLine($"\nFilm: {movie3.titel} Regissör: {movie3.mmCreator} Betyg: {movie3.grade} Release Datum: {movie3.releaseDate} Tid: {movie3.playTime} Pris: {movie3.price} kr ");

            List<Film> movies = new List<Film>() { movie1, movie2, movie3 };
            movies.Sort(delegate (Film x, Film y)
            {
                return x.releaseDate.CompareTo(y.releaseDate);
            });

            Console.WriteLine(String.Join(Environment.NewLine, movies));
            Console.ReadKey();
        }
    }
}
