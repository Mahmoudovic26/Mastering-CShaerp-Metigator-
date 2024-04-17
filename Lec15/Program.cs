using System;
namespace CAOverloadedOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Money m = new Money(150m);
            Money m2 = new Money(160m);
            Money m3 = m +m2;
            Money m4 = m - m2;
            var mm=m.Amount; 
            System.Console.WriteLine($"Money one ${m.Amount}: Money Two ${m2.Amount}");
            System.Console.WriteLine($"Money three = Money One + Money two = ${m3.Amount}");
            System.Console.WriteLine($"Money four = Money One - Money two = ${m4.Amount}");
            System.Console.WriteLine(m4<m3);
            System.Console.WriteLine(m3>m4);
        }
    }
    class Money
    {
        private decimal _amount;
        public decimal Amount=>_amount;
        public Money(decimal value)
        {
            this._amount = Math.Round(value,2);
        }
        public static Money operator +(Money money1,Money money2)
        {
            var value = money1.Amount+money2.Amount;
            return new Money(value);
        }
        public static Money operator -(Money money1,Money money2)
        {
            var value = Math.Abs(money1.Amount - money2.Amount);
            return new Money(value); 
        }
        public static bool operator >(Money money1,Money money2)
        {
            
            return money1.Amount > money2.Amount; 
        }
        public static bool operator <(Money money1,Money money2)
        {
            return money1.Amount < money2.Amount;
        }
    }
}