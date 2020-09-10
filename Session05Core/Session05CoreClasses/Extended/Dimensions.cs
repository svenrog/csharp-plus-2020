using System;
using System.Collections.Generic;
using System.Text;

namespace Session05CoreClasses.Extended
{
    public struct Dimensions
    {
        public readonly int Width;
        public readonly int Height;
        public readonly int Depth;

        public Dimensions(int width, int height, int depth)
        {
            Width = width;
            Height = height;
            Depth = depth;
        }
    }
}
