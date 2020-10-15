using System;
using System.Collections.Generic;
using System.Text;

namespace KlassStruktur.Order
{
    public class Order
    {
        public System.String OrderNumber { get; set; }
        public OrderStatus Status { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
        public System.Collections.Generic.List<LineItem> LineItems { get; set; }
        public System.Decimal ShippingCost { get; set; }

        public System.Decimal TotalPrice
        {
            get { return GetTotalPrice(); }
        }

        private System.Decimal GetTotalPrice()
        {
            System.Decimal totalPrice = 0;

            foreach (LineItem item in LineItems)
            {
                totalPrice += item.Price * item.Quantity;
            }

            totalPrice += ShippingCost;

            return totalPrice;
        }
    }
}
