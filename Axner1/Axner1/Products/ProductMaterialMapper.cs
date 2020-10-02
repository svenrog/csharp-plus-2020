using System;
using System.Collections.Generic;
using System.Text;

namespace Axner1.Products
{
    static class ProductMaterialMapper
    {
        public static string Map(string material)
        {
            switch (material)
            {
                case "Suede":
                    return "Leather";
                case "Cotton":
                    return "Fabric";
                case "Rubber":
                    return "Latex";
                default: return material;
            }
        }
    }
}
