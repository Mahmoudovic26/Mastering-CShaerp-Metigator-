using System;
namespace CAEvent
{
    public class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock("Amazon");
            stock.Price = 100;
            stock.OnPriceChanged += Stock_OnPriceChange ; //Subscribed
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Stock before change = ${stock.Price}");
            stock.ChangeStockPriceBy(0.0m);
            stock.ChangeStockPriceBy(-0.05m);
            stock.ChangeStockPriceBy(0.05m);
            var stock2 = new Stock("Apple");
            stock2.Price = 150;
            stock2.OnPriceChanged +=(Stock stock,decimal oldprice) =>
            {
            string result = "";
            if(stock.Price > oldprice)
            {
                result = "UP";
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if(oldprice >stock.Price)
            {
                result = "Down";
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                result = "Normal";
                Console.ForegroundColor = ConsoleColor.Black;
                
            }
            Console.WriteLine($"{stock.Name}: ${stock.Price} :status {result}");

            };
            stock2.ChangeStockPriceBy(0.02m);
            stock2.ChangeStockPriceBy(-0.0m);

            
            
        }
        private static void Stock_OnPriceChange(Stock stock,decimal oldprice)
        {
            string result = "";
            if(stock.Price > oldprice)
            {
                result = "UP";
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if(oldprice >stock.Price)
            {
                result = "Down";
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                result = "Normal";
                Console.ForegroundColor = ConsoleColor.Black;
                
            }
            Console.WriteLine($"{stock.Name}: ${stock.Price} :status {result}");
        }
    }
    public delegate void StockPriceChangeHandler(Stock stock,decimal oldprice);
    public class Stock
    {
        private string name;
        private decimal price;

        //Event declaration 
        public event StockPriceChangeHandler OnPriceChanged;
        public string Name => this.name;
        public decimal Price{get => this.price; set => this.price=value;}

        public Stock(string stockname)
        {
            this.name = stockname;
        }
        public void ChangeStockPriceBy(decimal percecnt)
        {
            decimal oldprice = this.price;
            this.price += Math.Round(this.price*(percecnt),2);
            if(OnPriceChanged != null) // Make sure that there is Subscriber 
            {
                OnPriceChanged(this,oldprice); //Firing the event
            }
        }
    }
}