using System;
using System.Collections.Generic;
using System.Text;

namespace Session05Animals
{
    public interface IBarnyardAnimal
    {
        string Tag { get; set; }
        string RestingArea { get; }
        string FeedingArea { get; set; }
    }
}
