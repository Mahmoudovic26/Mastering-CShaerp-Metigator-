using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
namespace lec10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // dd//mm/yyyy
            Date d1 = new Date(2000);
            System.Console.WriteLine(d1.GetDate());
            Employee e1 = new Employee();
            System.Console.WriteLine(e1.DisplayName());
            PEmployee e2 =  PEmployee.Create(1000,"MA","MM");
            System.Console.WriteLine(e2.DisplayName());


        }
    }
    public class Date
    {
        // Constructor -> <AccessModifier> <TypeName> <Parameter>
        //{
        // series of statement 
        //}
        private static readonly int[] daysToMonth365 = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] daysToMonth366 = {0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private int dayInMonth;
        // or 
        private int _dayInMonth;

        private readonly int day   =1;
        private readonly int month =1;
        private readonly int year  =1;
        //Constructor 
        public  Date(int day ,int month, int year)
        {
            var isleap = year % 4 == 0 && (year % 100 != 0 || year % 400 ==0);
            if(year >= 1 && year <= 9999 && month >=1 && month <=12)
            {
                int[] days = isleap ? daysToMonth366 : daysToMonth365; 
                if(day >= 1 && day <= days[month])
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;
                }
            }
        }
        public Date(int year): this(01,01,year)
        {}
        public Date(int month,int year): this(01,month,year)
        {}
         
        public string GetDate()
        {
            return $"{day.ToString().PadLeft(2,'0')}/{month.ToString().PadLeft(2,'0')}/{year.ToString().PadLeft(4,'0')}";
        }
    }
    public class Employee
    {
        public Employee(int id,string fname ,string lname)
        {
            Id = id;
            FName = fname;
            LName = lname;     
        }
        public Employee(int id):this(id,"","")
        {
        }
        public Employee():this(0,"","")
        {}
        public int Id = 0;
        public string FName = "";
        public string LName = "";
        public string DisplayName()
        {
            return $"Id: {Id}\n Name: {FName} {LName}";
        }
    }
    public class PEmployee
    {
        private PEmployee(){}
        private PEmployee(int id, string fname,string lname) 
        {
            this.id = id;
            this.lname = lname;
            this.fname = fname;
        }
        public static PEmployee Create(int id, string fname,string lname)
        {
            return new PEmployee(id,fname,lname);
        }
        private int id = 0;
        private string fname = "";
        private string lname = "";
        public string DisplayName()
        {
            return $"Id: {id}\n Name: {fname} {lname}";
        }
    }
}