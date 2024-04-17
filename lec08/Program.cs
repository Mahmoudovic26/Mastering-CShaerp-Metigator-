// See https://aka.ms/new-console-template for more information


using System.ComponentModel;
using Lec08oop;


/**@author Mahmoud M.Bayoumi
***@brief Lec08 OOP introduction
**/
namespace Lec08
{
    class Program
    {
        
            
        static void Main(string[] args)
        {    
            //OOP
            /** Company is looking for Application to do salary slip calculation for
            Employee based on daily bases following the rule total Earnings is equal
            to Hours logged times his wage. fixed tax is applied 3% on all.
            user need to enter input and salary will be shown accordingly */
            const double TAX = 0.03;

            /**System.Console.Write("\nFirst Name: ");
            var FName = Console.ReadLine();

            System.Console.Write("Last Name: ");
            var LName = Console.ReadLine();

            Console.Write("Wage: ");
            var wage = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Logged hors: ");
            var LoggedHours  = Convert.ToDouble(Console.ReadLine());

            var netSalary  = (wage * LoggedHours) - ((wage*LoggedHours)*TAX);

            Console.WriteLine($"\n First Name: {FName}\n Last Name: {LName} \n Wage: {wage} \n logged hours: {LoggedHours} \nSalary: {netSalary} ");
            */
            // Object (Instance) syntax ;
            // Declaration <Type> <object Name>;
            // Assignment  <object Name> = new <type>;
            // Initialization <Type> <object Name> = new <type>();
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
            foreach(var emp in emps)
            {
                var netSalary  = (emp.Wage * emp.LoggedHours) - ((emp.Wage * emp.LoggedHours)*Employee.TAX);

                Console.WriteLine($"\n First Name: {emp.FName}\n Last Name: {emp.LName} \n Wage: {emp.Wage} \n logged hours: {emp.LoggedHours} \nSalary: {netSalary} ");
            }



            


            Console.ReadKey();
        }
       
       
    }




}