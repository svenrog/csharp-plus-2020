using System;
using System.Collections.Generic;
using System.Text;

namespace Session05Animals
{
    public interface IBarnyardAnimal
    {
        string RestingArea { get; }
        string FeedingArea { get; set; }
    }
}
