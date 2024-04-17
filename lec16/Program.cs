using System;
namespace CAFinalizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var P = new Person();
            P.Name = "Ali"; 
            //---------
            MakeSomeGarbage();
            System.Console.WriteLine($"Memory use before collecting {GC.GetTotalMemory(false):N0}");
            GC.Collect(); //Explicit Cleaning 
            System.Console.WriteLine($"Memory use after collection {GC.GetTotalMemory(true):N0}"); 
        }
        static void MakeSomeGarbage()
        {
            Version v;
            for (int i = 0; i < 1000; i++)
            {
                v = new Version();
            }
        }
    }
    class Person
    {
        public string Name{get;set;}
        public Person()
        {
            System.Console.WriteLine("this is person Constructor ");
        }
        //Destructor definition we call it when destroy the object 
        // we dispose the object when goes out the scope  
        ~Person()
        {
            System.Console.WriteLine("Destructor");
        }
    }
} 