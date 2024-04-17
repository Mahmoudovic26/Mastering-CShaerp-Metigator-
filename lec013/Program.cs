using System;
using System.Drawing;
using CADelegate;
namespace CADelegate
{
    public delegate void RectDelegate(decimal width,decimal hight);
    class Program
    {
        static void Main(string[] args)
        {
            var emps = new Employee[]
            {
                new Employee {Id = 1, Name = "Mahmoud M",Gender = "M",TotalSales=65000m },
                new Employee {Id = 2, Name = "Habiba M",Gender = "F",TotalSales=50000m },
                new Employee {Id = 3, Name = "Muhammad M",Gender = "M",TotalSales=65000m },
                new Employee {Id = 4, Name = "Ola M",Gender = "F",TotalSales=40000m },
                new Employee {Id = 5, Name = "Omar M",Gender = "M",TotalSales =20000m },
                new Employee {Id = 6, Name = "Sara M",Gender = "F",TotalSales=30000m },
                new Employee {Id = 7, Name = "Mohanad M",Gender = "M",TotalSales=16000m },
                new Employee {Id = 8, Name = "Reem M",Gender = "F",TotalSales=10000m },
            };
            var report = new Report();
            
            report.ProcessEmployee(emps,"Employees with Sales >= 60,000",e=> e.TotalSales > 60000m);
            report.ProcessEmployee(emps,"Employees with 30,000< Sales <60,000 ",e =>e.TotalSales <60000m && e.TotalSales>=30000);
            report.ProcessEmployee(emps,"Employees with Sales <= 30,000",e=>e.TotalSales <30000m);
            System.Console.WriteLine("=========================");  
            var helper = new RecatngleHelper();

            RectDelegate rect = helper.GetArea; 
            rect +=helper.GetPerimeter;
            rect(10,10);





            /**
            report.ProcessEmployee(emps,"Employees with Sales >= 60,000",delegate (Employee e){return e.TotalSales > 60000m;});
            report.ProcessEmployee(emps,"Employees with 30,000< Sales <60,000 ",delegate (Employee e){return e.TotalSales <60000m && e.TotalSales>=30000;});
            report.ProcessEmployee(emps,"Employees with Sales <= 30,000",delegate (Employee e){return e.TotalSales <30000m;});
            
            */

        }
        /**static bool IsGreaterThanOrEqual60000(Employee e) => e.TotalSales >60000m;
        static bool IsBetween30000And60000(Employee e) => e.TotalSales <60000m && e.TotalSales>=30000;
        static bool IsLessThan30000(Employee e) => e.TotalSales <30000m;
        */
    }
    public class RecatngleHelper
    {
        public void GetArea(decimal width,decimal hight)
        {
            var result = width*hight;
            System.Console.WriteLine($"Area: {width} X {hight}  = {result}"); 
        }
        public void GetPerimeter(decimal width,decimal hight)
        {
            var result = 2*(width+hight);
            System.Console.WriteLine($"Perimeter: 2 X ({width} + {hight})  = {result}"); 
        }
    }
}