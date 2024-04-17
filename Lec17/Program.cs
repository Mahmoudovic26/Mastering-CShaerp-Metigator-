using System;
using lib;
namespace CANestedTypes
{
    class Person
    {
        static void Main(string[] args)
        {
            Empolyee e1 = new Empolyee();
            System.Console.WriteLine(e1.EmployeeInsurance.CompanyName);
        }
    }
    class Empolyee
    {
        public int Id{get;set;}
        public string Name {get;set;}
        public Insurance EmployeeInsurance {get;set;} //Composition 
        public Empolyee()
        {
            EmployeeInsurance = new Insurance {PolicyId = -1,CompanyName = "N/A"};
        }
         public class Insurance
        {
            public int PolicyId{get;set;}
            public string CompanyName {get;set;}
        }
    }
    class Insurance
    {
        public int PolicyId{get;set;}
        public string CompanyName {get;set;}
    }
    class Department
    {
        public int PolicyId{get;set;}
        public string Name {get;set;}
    }
} 