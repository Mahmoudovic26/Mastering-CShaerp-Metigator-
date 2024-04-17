using System;
using System.Net.NetworkInformation;
namespace CAExtensionMethods
{
    class Program
    {
        static void Main()
        {
            DateTime dt = DateTime.Now;
            System.Console.WriteLine(dt);
            DateTimeOffset dto = DateTimeOffset.UtcNow;

            System.Console.WriteLine($"Comparison: {dto.CompareTo(dt)} ");
            System.Console.WriteLine(dto);
            TimeSpan ts = new TimeSpan(2, 15, 15);
            dt = dt.Add(ts);
            System.Console.WriteLine(dt);
            System.Console.WriteLine($"Is week End {DateTimeHelper.IsWeekEnd(dt)}");
            System.Console.WriteLine($"Is week Day {DateTimeHelper.IsWeekDay(dt)}");
            System.Console.WriteLine(dt.IsWeekDay());
            System.Console.WriteLine(dt.IsWeekEnd());
            System.Console.WriteLine($"Is leap Year: {DateTime.IsLeapYear(2024)}");
            Pizza p = new Pizza();
            p.AddDough("thin");
            p.AddDSauce();
            p.AddDCheese(true);
            System.Console.WriteLine(p);
            System.Console.WriteLine($"Contents: {p.Content}\n Total Price {p.TotalPrice}");
            System.Console.WriteLine("I hate Egypt");
        }
    }
    class Pizza
    {
        public string Content { get; set; }
        public decimal TotalPrice { get; set; }
        public override string ToString()
        {
            return $"{Content}\n---------------\nTotal price:{TotalPrice}";
        }
    }
}