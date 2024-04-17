// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Xml.Serialization;
using Lec09oop;
namespace Lec09oop02
{

    class Program
    {


        static void Main(string[] args)
        {
            Employee[] emps = new Employee[2];
            
            Employee e1 = new Employee();
            System.Console.Write("\nFirst Name: ");
            e1.FName = Console.ReadLine();

            System.Console.Write("Last Name: ");
            e1.LName = Console.ReadLine();

            Console.Write("Wage: ");
            e1.Wage = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Logged hors: ");
            e1.LoggedHours  = Convert.ToDouble(Console.ReadLine());
             
            emps[0] = e1;

            Employee e2 = new Employee();
            System.Console.Write("\nFirst Name: ");
            e2.FName = Console.ReadLine();

            System.Console.Write("Last Name: ");
            e2.LName = Console.ReadLine();

            Console.Write("Wage: ");
            e2.Wage = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Logged hors: ");
            e2.LoggedHours  = Convert.ToDouble(Console.ReadLine());
            emps[1]  = e2;
            foreach (var emp in emps)
            {
                System.Console.WriteLine(emp.printSlip());
                
            }
            //---------------------
            Demo d1 = new Demo();
            //Caller
            int x = 20;
            // x is the argument passed (we send to caller)
            //x = d1.DoSomething(ref  x);
            //System.Console.WriteLine($"square: {x}");
            /**var numString  = "01124876300";
            int number;
            if(!int.TryParse(numString,out number))
            {
                System.Console.WriteLine("Invalid number");
            }else
            {
                System.Console.WriteLine($"Valid number {number}");
            }*/
            //----------------
            /*
            sigmethod sig1 = new sigmethod();
            sig1.Promote(100,"Amman-Istanbul","five-Star 3days/two nights");
            var result = d1.IsEven(6);
            System.Console.WriteLine(result);
            System.Console.WriteLine("-------------------");
            d1.PrintEvens(new int[] {1,2,3,4,5,6,9,7,98,1,1,22,102});
            */
        }




    }
    public class Demo 
    {
        //Method syntax(simple)
        //<AccessModifier> <DataType>/void MethodName(<parameter list>)
        //{
        // //series of statement 
        //}

        // Callee 
        // x is an parameter 
        public int DoSomething(ref int x)
        {
            System.Console.WriteLine("Do something method");
            return x*x;
        }
        public bool IsEven(int number) => number % 2 == 0; // bodied method 

        public void PrintEvens(int[] original)
        {
            foreach (var n in original)
            {
                if(IsEven(n))
                {
                    System.Console.WriteLine(n +" ");
                }
            }
        }
    }
    public class sigmethod
    {
        // method signature (Name + parameter type + parameter order)
        // Method Overloading (A common way of implementing polymorphism)
        public void Promote(double amount)
        {
            System.Console.WriteLine($"You've got a promotion of ${amount}");
        }
        public void Promote(double amount, String trip)
        {
            System.Console.WriteLine($"You've got a promotion of ${amount} and a trip {trip}");
        }
        public void Promote(double amount, String trip,string Hotel)
        {
            System.Console.WriteLine($"You've got a promotion of ${amount} and a trip {trip} with {Hotel}");
        }

    }



}