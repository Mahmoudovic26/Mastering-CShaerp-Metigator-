using System;
namespace CAInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Cashier ca= new Cashier(new Cash());
            Cashier ca2 = new Cashier(new MasterCard());
            ca.Checkout(99999.99m);
            ca2.Checkout(125000m);
            Vehicle ve = new Honda("Honda","Civic",2021); 
            System.Console.WriteLine(ve);
        }
    }
    class Cashier 
    {
        private IPayment _payment;
        public Cashier(IPayment payment)
        {
            this._payment = payment;
        }
        public void Checkout(decimal amount)
        {
            _payment.Pay(amount);
        }
    }
    class Visa:IPayment
    {
        public void Pay(decimal amount)
        {
            System.Console.WriteLine($"Visa Payment: ${Math.Round(amount,2):N0}");
        }
    }
    class MasterCard:IPayment
    {
        public void Pay(decimal amount)
        {
            System.Console.WriteLine($"MasterCard Payment: ${Math.Round(amount,2):N0}");
        }
    }
    class Debit:IPayment
    {
        public void Pay(decimal amount)
        {
            System.Console.WriteLine($"Debit Payment: ${Math.Round(amount,2):N0}");
        }
    }
    interface IPayment
    {
        void Pay(decimal amount);
    }
    class Cash:IPayment
    {
        public void Pay(decimal amount)
        {
            System.Console.WriteLine($"Cash Payment: ${Math.Round(amount,2):N0}");
        }
    }
    abstract class Vehicle //Abstract Type
    {
        protected string Brand;
        protected string Model;
        protected int Year;
        public Vehicle(string brand,string model,int year)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
        }
    }
    interface IDrivable
    {
        void Move();
        void New()
        {
            System.Console.WriteLine("New");
        }
        void Stop();
    }
    interface ILoader
    {
        void Load();
        void UnLoad();
    }
    class Honda : Vehicle,IDrivable //Concrete Type
    {
        public Honda(string brand,string model,int year):base( brand, model, year)
        {
            
        }

        public void Move()
        {
                System.Console.WriteLine("Moving");
        }

        public void Stop()
        {
            System.Console.WriteLine("Stop");
        }
    }
    class Caterpillar:Vehicle,ILoader
    {
        
        public Caterpillar(string brand,string model,int year):base( brand, model, year)
        {
            
        }

        public void Load()
        {
            System.Console.WriteLine("Loading");
        }

        public void UnLoad()
        {
            System.Console.WriteLine("UnLoading");
        }
    }
}