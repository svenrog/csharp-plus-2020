using System;
using System.Collections.Generic;
using System.Text;

namespace Session10Classes
{
    abstract class Page : IPage
    {
        public Page()
        {
            // Körs alltid, även fast den inte finns utskriven
        }

        //~Page()
        //{
        //    // Finalizer, används bara om man implementerar IDisposable
        //}

        // Går även jättebra att göra publika fält
        // Rekommenderas ej
        //public int Id;

        // Privat fält
        //int _id;
        private int _id;

        public virtual int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > 100)
                    throw new ArgumentOutOfRangeException();

                _id = value;
            }
        }

        //Enklaste sättet att lägga till fält
        //public int Id { get; set; } // <--- Berättar att detta är en egenskap

        public string Title { get; set; }

        public override string ToString()
        {
            var type = GetType();

            return $"Id: {Id}, {type.Name}, Title: {Title}";
        }

        public virtual Type GetPageType()
        {
            return typeof(Page);
        }

        public abstract string Render();
    }
}
