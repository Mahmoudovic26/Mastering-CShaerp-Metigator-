using System;
using System.Diagnostics;
namespace CAExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var del = new Delivery { Id = 101, CustomerName = "Mahmoud", Address = "11St", DeliveryStatus = DeliveryStatus.PROCESSED };
            var ser = new DeliveryService();
            ser.Start(del);
            System.Console.WriteLine(del);
        }
    }
}