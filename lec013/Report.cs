namespace CADelegate
{
    public class Report
    {
        public delegate bool IllegilesSales (Employee e);
        public void ProcessEmployee(Employee[] employees ,string title,IllegilesSales IsIllegible)
        {
            System.Console.WriteLine(title);
            System.Console.WriteLine("------------------------------");
            foreach (var e in employees)
            {
                if(IsIllegible(e))
                {
                    System.Console.WriteLine($"Id:{e.Id}|{e.Name}|{e.Gender}|{e.TotalSales}");
                }
            }
            System.Console.WriteLine("\n\n");
        }
    }
}