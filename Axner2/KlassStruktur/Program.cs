using System;
using System.Collections.Generic;
using KlassStruktur.Order;

namespace KlassStruktur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Computer comp = new Computer("1234", "16", 17, 10, 10, 10)
            {
                Color = ColorEnum.Green
            };

            int computerVolume = comp.GetVolume();

            Console.WriteLine(comp.ScreenSze);
            Console.WriteLine(comp.Ram);

            Console.WriteLine(comp.Color);

            Employee emp;
            emp.EmployeeId = "ett id";

            //Computer comp2 = new Computer("9876", "32", 15);

            //Console.WriteLine(comp2.ScreenSze);
            //Console.WriteLine(comp2.Ram);

            var item1 = new LineItem();
            item1.Price = 12;
            item1.ProductId = "1";

            var lineItems = new List<LineItem>();
            lineItems.Add(item1);


            Order.Order myOrder = new Order.Order
            {
                OrderNumber = "123", 
                Status = OrderStatus.New,
                BillingAddress = new Address
                {
                    StreetAddress = "Viravägen 4",
                    ZipCode = "81120",
                    City = "Sandarne"
                },
                ShippingAddress = new Address
                {
                    StreetAddress = "Viravägen 4",
                    ZipCode = "81120",
                    City = "Sandarne"
                },
                LineItems = new List<LineItem>
                {
                    new LineItem { Price = 15, ProductId = "1", ProductName = "Sko", Quantity = 1},
                    new LineItem {Price = 10, ProductId = "2", ProductName = "Skjorta", Quantity = 2}
                },
                ShippingCost = 20
            };

            Console.WriteLine(myOrder.TotalPrice);

        }
    }
}
