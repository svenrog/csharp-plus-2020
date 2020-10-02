using System;

namespace TestsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new [] { "Lorem", "ipsum", "dolor", "sit", "amet,", "consectetur", "adipiscing", "elit.", "Integer", "malesuada", "elit", "eget", "eleifend", "ultricies.", "Fusce", "eu", "tristique", "lacus.", "Etiam", "pharetra", "ullamcorper", "sem,", "eu", "maximus", "risus", "dictum", "vel.", "Aenean", "scelerisque", "massa", "felis.", "Proin", "sapien", "est,", "vestibulum", "et", "varius", "non,", "pretium", "et", "neque.", "Mauris", "eu", "lacus", "vel", "metus", "egestas", "aliquet.", "Curabitur", "eget", "consequat", "tortor,", "a", "sagittis", "purus.", "Morbi", "a", "urna", "vulputate,", "imperdiet", "massa", "id,", "eleifend", "erat." };
            
            for (var i = 1; i < 65; i *= 2)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
