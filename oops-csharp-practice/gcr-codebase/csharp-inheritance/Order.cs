using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgeLabzTraining.inheritance
{
    //Base class Order
    class Order
    {
        public int OrderId;
        public string OrderDate;

        public Order(int id, string date)
        {
            OrderId = id;
            OrderDate = date;
        }

        public virtual void GetOrderStatus()
        {
            Console.WriteLine("Order Placed");
        }
    }

    //Intermediate class
    class ShippedOrder : Order
    {
        public string TrackingNumber;

        public ShippedOrder(int id, string date, string tracking)
            : base(id, date)
        {
            TrackingNumber = tracking;
        }

        public override void GetOrderStatus()
        {
            Console.WriteLine("Order Shipped");
        }
    }

    //Final subclass
    class DeliveredOrder : ShippedOrder
    {
        public string DeliveryDate;

        public DeliveredOrder(int id, string date, string tracking, string deliveryDate)
            : base(id, date, tracking)
        {
            DeliveryDate = deliveryDate;
        }

        public override void GetOrderStatus()
        {
            Console.WriteLine("Order Delivered on " + DeliveryDate);
        }
    }

    class Program
    {
        static void Main()
        {
            Order o = new DeliveredOrder(101, "10-Jan", "TRK123", "15-Jan");
            o.GetOrderStatus();
        }
    }
}
