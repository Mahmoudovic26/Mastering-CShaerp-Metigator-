using System;
namespace CSEnumeratorEnumerable
{
    class Progarm
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("==================");
            var temps = new List<Tempreture>();
            Random rnd = new Random();

            for (var i = 0; i < 100; i++)
            {
                temps.Add(new Tempreture(rnd.Next(-30, 50)));

            }
            temps.Sort();
            foreach (var item in temps)
            {
                System.Console.WriteLine(item.Value);
            }
            System.Console.WriteLine("---------------------");
            var ints = new FiveIntegers(1, 2, 3, 4, 5);
            foreach (var item in ints)
            {
                System.Console.WriteLine(item);
            }
            var e = new Employee { Id = 1001, Name = "Mahmoud", Salary = 200m, Department = "IT" };
            var e2 = new Employee { Id = 1001, Name = "Mahmoud", Salary = 200m, Department = "IT" };
            System.Console.WriteLine(e == e2); //here will give false because it is reference type and it comparing the value type
            var s1 = "Mahmoud";
            var s2 = "Mahmoud";
            System.Console.WriteLine(s1 == s2); // Here will give true because only in strings comparing the value of referenced 
            System.Console.WriteLine(e.Equals(e2));
            System.Console.WriteLine(e.GetHashCode());
            System.Console.WriteLine(e2.GetHashCode());
        }
    }

}

