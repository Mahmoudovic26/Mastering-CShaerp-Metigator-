// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;
namespace lec11_property
{
   class Program
    { 
      static void Main(string[] args)
      {
          Dollar dollar = new Dollar(0m);
          dollar.Amount = 0m; //Set
          System.Console.WriteLine(dollar.Amount); //get
          System.Console.WriteLine(dollar.IsZero);

      }
    }
    public class Dollar
    {
      private decimal _amount; // takes decimal amounts
      
      //property 
      public decimal Amount
      {
        get
        {
            return this._amount;
        }
        set //private set --> Can't set in public  
        {
          this._amount = ProcessValue(value);

        }
      }
      public bool IsZero // public bool IsZero => _amount ==0;
      {
        get
        {
          return _amount ==0;
        }
      }
      /** //This if i want to make Set private 
      public void SetAmount(decimal value)
      {
        Amount = value;
      }
      */
      public decimal ConversionFactor {get;} = 1.99m; //initialization 
      public Dollar(decimal amount)
      {
        this._amount = ProcessValue(amount);
      }
      private decimal ProcessValue(decimal value) => value <= 0 ? 0:Math.Round(value,2);

    }
}