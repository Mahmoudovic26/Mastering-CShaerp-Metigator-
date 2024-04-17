using System;
namespace CAGenericDelegate
{ //Builtin Generic delegates Action,Func,Predicate
    public delegate bool Filter(int number);
    public delegate bool InGenericFilter<in T>(T num); // Cannot be used in return 
    public delegate T OutGenericFilter<out T>(); // Cannot be used in return 

    class Program
    {
        static void Main(string[] args)
        {
            Action<string> action = Printf;
            action("Mahmoud");
            Func<int,int,int> addD = Add;
            System.Console.WriteLine(addD(3,5));
            Predicate<int> predicate = IsEven;
            System.Console.WriteLine(predicate(120));


            System.Console.WriteLine("-------------------");
            IEnumerable<int> lis1 = new int[] {2,4,6,8,10,12};
            PrintNumberLessThanSix(lis1);
            System.Console.WriteLine("Less than 6");
            PrintNumber(lis1,num=>num<6);
            System.Console.WriteLine("Less than 7");
            PrintNumber(lis1,num=>num<7);
            System.Console.WriteLine("Even Numbers");
            PrintNumber(lis1,n=>n%2==0);
            System.Console.WriteLine("---------------");
            IEnumerable<decimal> list2 = new decimal[] {2.33m,4.56m,6.22m,8.45m,10.54m,12.98m};
            System.Console.WriteLine("Less than 6");
            GenericPrintNumber(list2,num=>num<6.6m);
            System.Console.WriteLine("Less than 7");
            GenericPrintNumber(list2,num=>num<7);
            System.Console.WriteLine("Even Numbers");
            GenericPrintNumber(list2,n=>n%2==0); 
             System.Console.WriteLine("---------------P");
            IEnumerable<decimal> list3 = new decimal[] {2.33m,4.56m,6.22m,8.45m,10.54m,12.98m};
            System.Console.WriteLine("Less than 6");
            GenericPrintNumber(list3,num=>num<6.6m);
            System.Console.WriteLine("Less than 7");
            GenericPrintNumber(list3,num=>num<7);
            System.Console.WriteLine("Even Numbers");
            GenericPrintNumber(list3,n=>n%2==0); 
        }
        static void Printf(string name) => System.Console.WriteLine(name);
        static int Add(int n1,int n2) => n1+n2;
        static bool IsEven(int n) => n%2==0;

        static void PredicatePrintNumber<T>(IEnumerable<T> numbers, Predicate<T> filter)
        {
            foreach (var item in numbers)
            {
                if (filter(item))
                {
                    System.Console.WriteLine(item);
                }
            }
        }
        static void GenericPrintNumber<T>(IEnumerable<T> numbers, InGenericFilter<T> filter)
        {
            foreach (var item in numbers)
            {
                if (filter(item))
                {
                    System.Console.WriteLine(item);
                }
            }
        }
        static void PrintNumber(IEnumerable<int> numbers, Filter filter)
        {
            foreach (var item in numbers)
            {
                if (filter(item))
                {
                    System.Console.WriteLine(item);
                }
            }
        }
        static void PrintNumberLessThan(IEnumerable<int> numbers, int PivotNumber)
        {
            foreach (var item in numbers)
            {
                if (item <PivotNumber)
                {
                    System.Console.WriteLine(item);
                }
            }
        }
        static void PrintNumberLessThanSix(IEnumerable<int> numbers)
        {
            foreach (var item in numbers)
            {
                if (item <6)
                {
                    System.Console.WriteLine(item);
                }
            }
        }
    }
}