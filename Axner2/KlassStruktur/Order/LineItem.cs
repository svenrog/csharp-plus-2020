using System;
using System.Collections.Generic;
using System.Text;

namespace KlassStruktur.Order
{
    public class LineItem
    {
        public System.String ProductId { get; set; }
        public System.String ProductName { get; set; }
        public System.Decimal Price { get; set; }
        public System.Int32 Quantity { get; set; }
    }
}
