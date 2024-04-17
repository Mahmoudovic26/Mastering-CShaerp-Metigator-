using System;
namespace CAInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager mm = new Manager(1000,"Mahmoud",176m,10m);
            Maintenance ma = new Maintenance(1001,"Ola",179,8);
            Developer dev = new Developer(10002,"Mahmoud",190,true,15);
            Sales sl = new Sales(1003,"Habiba",180,9,10000,0.05m);
            Employee[] employees = {mm,ma,sl,dev};
            foreach (var item in employees)
            {
                System.Console.WriteLine("\n---------------------");
                System.Console.WriteLine(item);
            }
        }
    }

}